# Combat System — Reverse-Engineering Specification

> Canonical combat reference. Consolidated from the former `TECHNICAL_ANALYSIS.md`
> (combat sections + ammo lifecycle). See `docs/INDEX.md` for the documentation map.

## Combat System Analysis

The combat system is split across two code segments that are **not** covered by the Reko decompiler output:
- **Segment 19EF** (linear 0x1A861-0x1BCE8): Movement, RNG, fire phase, grid adjacency, damage application
- **Segment 1000** (linear 0x105C5-0x14672): Combat loop, targeting, LoS/range check, weapon data access
- **Segment 0000** (linear 0x30DD-0x3113): **2D6 to-hit roll generator** (`ghidra_guess_0000_30DD_030DD`)

Source: the **Spice86-generated decompilation** of both segments, now in-repo —
[`../reko/gencode/`](../reko/gencode/) (older Spice86; uses the game segments `19EF`/`1000` cited
below) and [`../reko/gencode-current/`](../reko/gencode-current/) (current Spice86; runtime segments).
See [`engine/segments-19ef-1000.md`](engine/segments-19ef-1000.md).

---

## B2 verification — combat formulas vs decompilation (2026-09-28)

Re-checked the core formulas against the recovered/regenerated decompilation. **Confirmed accurate:**

| Formula | Spec | Verified in code |
|---------|------|------------------|
| **To-hit base** | `targeting_return*2 + 4` | `[BP-0x5c] << 1 + 4` → `[BP-0x30]` (`1000:481A`) ✓ |
| **Kick override** | weapon 0x20 → TN = 3 | `cmp [BP-0x48],0x20` → `[BP-0x30] = 3` (`1000:4822`) ✓ |
| **Skill term** | `fn1554(unit, 0x24) + fn1554(unit, 0x25)` | `1000:483C`/`484E` ✓ |
| **Terrain** | `0x32C6[stride 0x30 × slot] + 1` | `IMUL 0x30`; `ES=[0x5654]; AL=ES:[BX+0x32C6]; INC` (`1000:4863`) ✓ |
| **Terrain table** | `[0x5656]:0x2D1A` | `1000:4883` ✓ |
| **Story penalty** | `+2 if 0xC79B != 0` | `cmp ES:[SI+0xC79B],0` → `TN += 2` (`1000:48CC`) ✓ |
| **Heat generation** | `weapon[0x2EE5] & 0xF` → `unit+0x92` | `IMUL 0x11`; `AND 0xF`; `[BX+0x92] += AL` (`1000:48E3`) ✓ |
| **Heat penalty** | thresholds **8/13/17/24 → +1 each** | `cmp [BX+0x6E],{8,D,11,18}` → `INC [BP-0x30]` ×4 (`1000:48FD`) ✓ |
| **Ammo (enemy mech)** | `0xC363 + 0x7D·slot + phase`, `0xFF` sentinel | `IMUL 0x7D; + 0xC363`; `cmp …,0xFF; DEC` (`1000:47FA`) ✓ |
| **RNG (LFSR)** | §16 algorithm, state `384B:4FC0` | `DS=0x1DDC; ES=0x384B; SI=0x4FC0; AL=S0>>2; RCL S2; RCL S1; CMC; SBB AL,S0; SHR AL,1; RCR S0; AL=S0^S1` (`19EF:0BC0`) ✓ |
| **Hit location A** | `RNG & 0x8` → `[0x566A]:0x2E43` → `[BP-0x60]` | `AND BX,0x8; ES=[0x566A]; AL=ES:[BX+0x2E43]` (`1000:4F60`) ✓ |
| **Cluster weapons** | skip table if col ≤ 1; `2D6*7 + col` → `[0x566C]:0x2E5E` | `CMP ES:[SI+0x2EE4],1; JBE skip; CALL 30DD; IMUL 7; BX=col+2D6*7; ES=[0x566C]; AL=ES:[BX+0x2E5E]` (`1000:4F92`) ✓ |
| **Heat dissipation** | pool(`0x92`, seg `0x55A6`)→penalty(`0x6E`, seg `0x5598`); `+6` if `0xD576`; conditional `-4`; clamp `0x1E` | `MOV AL,ES:[SI+0x92]; ES=[0x5598]; ADD ES:[SI+0x6E],AL; CMP ES:[SI+0xD576],0; ADD …,6; DEC; SUB …,4; CMP …,0x1E` (`1000:07D2`, inside fn `1000:0673`) ✓ |
| **Damage slot-advance** | `[0x11..0x18] → +0xB`; else internal jump table | `CMP arg,0x11 / 0x18 → ADD AX,0xB` (`1000:0B3D`) ✓ |
| **AI targeting** | scan story props `0x33..0x55`: `0x7D·unit + prop`, `[0x558E]:0xC724`, mask `0x7F`, keep `0x10..0x20` | `[BP-4]=0x33; IMUL 0x7D; ES=[0x558E]; AL=ES:[BX+0xC724]; AND AX,0x7F; range 0x10..0x20` (`1000:0AC9`) ✓ |

**Still open:** the damage **overflow** loop internals (`1000:0B32` jump-table tail) and — the real
goal — a **differential** test running the same inputs in the emulator and the rebuild (roadmap Track 3).

---

### 1. OVERALL COMBAT FLOW

> **Scope.** This is the **combat-side** flow. The encounter **trigger** (world-map walking:
> `RNG & bD330 == 0` + `bD310`/`bD346` guards) is canonical in [`world-map.md`](world-map.md)
> §17.1–§17.2, §17.5; the left-panel narrowing is `w4FBC` (engine) →
> [`engine/viewport.md`](engine/viewport.md); enemy population/positioning is §20 below.

```
COMBAT ENCOUNTER (two triggers: walking on world map 0800:192 or BLD script action menu)
  │
  ├─► Walking encounter: main loop checks RNG & bD330 == 0 every frame (see §16)
  │   → fn183B_000A initializes combat, populates enemies, sets w4FBC = 1 (narrow panel)
  │
  ├─► BLD script encounter: action menu at 0D27, "fight" choice sets w4FBC = 1
  │
  ├─► Narrow left panel via w4FBC = 1 (from 80px→4px), w4FBA unchanged
  │
  ├─► COMBAT HANDLER (ghidra_guess_1000_458C_1458C @ 0x1458C)
  │     │
  │     ├─► INIT PHASE:
  │     │   ├─► Save cursor position from 0xA44B/0xA44D
  │     │   ├─► Zero-initialize 24-byte combatant array at [BP-0x78] (per-unit state)
  │     │   └─► Zero-initialize 24-byte array at ES:0x78[unit] (external state)
  │     │
  │     ├─► MAIN LOOP (iterates unit slots [BP-0x28] = 0..0x17, max 24):
  │     │     │
  │     │     ├─► Unit ID range classification:
  │     │     │   ├─► 0..3 (indices 0-3) → player lance (4 MechWarriors)
  │     │     │   ├─► 4..0xB (indices 4-11) → enemy units (8 slots)
  │     │     │   └─► 0xC..0x17 (indices 12-23) → extended pool
  │     │     │
  │     │     ├─► Check ES:[ID*2 + 0x406A] != 0 (unit alive/active?)
  │     │     │   └─► If 0 → skip unit (dead/inactive)
  │     │     │
  │     │     ├─► Call ghidra_guess_1000_0934_10934(unitID, param):
  │     │     │   └─► Returns AX (action code: 0-3)
  │     │     │       AX < 3 → unit can act
  │     │     │       AX >= 3 → skip unit
  │     │     │
     │     │     ├─► AI TARGET SELECTION (enemy units 4-11):
     │     │     │   └─► Call ghidra_guess_1000_0AB2_10AB2(stageCounter, unitID)
     │     │     │       → Scans story state properties offsets 0x33-0x55
     │     │     │       → Each property byte = (target_slot_id + 1) in range 0x10-0x20
     │     │     │       → Selects n-th valid target where n = stage counter
     │     │     │       → Validates story state byte at offset 0x27+stage ≠ 0
     │     │     │       → Returns target ID or 0xFF (no target)
     │     │     │
     │     │     ├─► MOVEMENT PHASE (if unit can act):
     │     │     │   ├─► Push unit coords (ES:[ID*2+0x4004], ES:[ID*2+0x4036])
     │     │     │   ├─► Push cursor coords (0xA44B, 0xA44D)
     │     │     │   ├─► Call unknown_19EF_0971_1A861 (movement dir calc)
     │     │     │   └─► Returns direction code in AX (-1 = no move)
     │     │     │
     │     │     ├─► TARGETING PHASE:
     │     │     │   ├─► Updates cursor position to target unit's coords
     │     │     │   ├─► Calls ghidra_guess_0000_2EBB_02EBB (coordinate utility)
     │     │     │   ├─► Pushes (attackerID, targetID + targetX, targetY)
     │     │     │   └─► Calls ghidra_guess_1000_160E_1160E (LoS validation)
     │     │     │       → Ray-casts from attacker to target using 8-direction vectors
     │     │     │       → Checks tile blocking property (b07AD) vs skill gate (t0150)
     │     │     │       → Returns AX=0 (blocked) or AX≠0 (LoS clear)
     │     │     │
     │     │     ├─► TO-HIT SETUP:
     │     │     │   ├─► Weapon slot lookup (enemy units 4-11, slots 0xB):
     │     │     │   │   AX = 0x11 * weapon_slot → ES:[BX+0x2EE8] = weapon type
     │     │     │   │   Compares with currently equipped weapon, inc counter if match
     │     │     │   │   Ammo check: if finite → check remaining, handle out-of-ammo
     │     │     │   │
     │     │     │   ├─► TN computation at [BP-0x30]:
     │     │     │   │   AX = targeting_return * 2 + 4 → base TN
     │     │     │   │   If weapon type 0x20 (kick): override TN = 3
     │     │     │   │   + skill (popcount of story state byte 0x24 & 0x25)
     │     │     │   │   + terrain (tile property at 0x32C6 + 1)
     │     │     │   │   + terrain table (at 0x2D1A)
     │     │     │   │   + story state penalty (+2 if 0xC79B != 0)
     │     │     │   │   + heat penalty (thresholds 8/13/17/24 → +1 each)
     │     │     │   │
     │     │     │   ├─► Heat generation: weapon heat (0x2EE5 & 0xF) added to unit heat pool
     │     │     │   │   Player units → ES:[BX+0x92], Enemy units → ES:[BX+0x8A]
     │     │     │   │
     │     │     │   ├─► Hit check: 2D6 roll >= [BP-0x30] → HIT, else → MISS
     │     │     │   │
     │     │     │   └─► unknown_19EF_1886_1B776 (fire phase per body part)
     │     │     │
     │     │     └─► POST-FIRE: call unknown_19EF_1DF8_1BCE8 (cleanup)
  │     │
    │     └─► EXIT: loop termination → w4FBC = 0 (restore 80px panel), story state update
    │         bD330 set to 0x7F to reduce re-encounter probability
   │
   └─► Return to world map
```

---

### 2. MOVEMENT PHASE

**Function:** `unknown_19EF_0971_1A861` + `split_1000_A8C6_1A8C6`
**File:** `GeneratedCode18.cs` (lines 1058-1379)
**Segment:Offset:** 19EF:0971 (linear 0x1A861)

**Parameters (stack):**
| Param | Stack Offset | Description |
|-------|-------------|-------------|
| Source X | `[BP+0x6]` | Stored to DS:0x238 |
| Source Y | `[BP+0x8]` | Stored to DS:0x23A |
| Dest X   | `[BP+0xA]` | Stored to DS:0x23C |
| Dest Y   | `[BP+0xC]` | Stored to DS:0x23E |

**Algorithm:**
1. **Delta calculation:**
   - `dY = SourceY - DestY` (signed, with sign extension via `DEC DH` if negative)
   - `dX = DestX - SourceX`
2. **Coarse quadrant:** Determines which of the 4 quadrants the target lies in, sets base direction bits in `DX`
3. **Binary search refinement** (`split_1000_A8C6_1A8C6`):
   - Compares `2*|dY|` vs `|dX|`, then `2*|dX|` vs `|dY|`
   - Builds up nibble bits `0x8 | 0x4 | 0x2 | 0x1` in `DX` representing 16-way (or 32-way) angle
4. **Final lookup:** `DX` indexes table at `DS:[BX + 0x240]`
5. **Return:** `AL` = direction byte (CBW sign-extends to AX)

**Return values:**
- `0xFFFF (-1)` = no valid move (source == dest or error)
- Otherwise 0..31 or 0..15 = direction index

---

### 3. AI TARGET SELECTION

**Function:** `ghidra_guess_1000_0AB2_10AB2`
**File:** `GeneratedCode10.cs` (lines 3913-4062)
**Segment:Offset:** 1000:0AB2 (linear 0x10AB2)

Called for enemy units (ID 4-11) during the combat loop. The caller at `GeneratedCode13.cs:1953` pushes:
| Param | Stack Offset | Source | Meaning |
|-------|-------------|--------|---------|
| `unit_id` | `[BP+0x6]` | `[BP-0x2]` (slot iterator) | Current unit slot ID |
| `stage_counter` | `[BP+0x8]` | `[BP-0x42]` (phase sub-counter) | Which target in sequence to select |

**Algorithm:**
1. Initialize: `[BP-0x2] = 0` (match counter), `[BP-0x8] = 0xFF` (result = no target), `[BP-0x4] = 0x33` (first property offset)
2. Iterate through story state property offsets **0x33..0x55** (35 properties) for the current unit:
   ```
   For each property_offset in 0x33..0x55:
     SI = 0x7D * unit_id                  // story state base for this unit
     BX = property_offset + SI             // property byte within story state
     ES = DS:[0x558E]                      // story state segment
     AL = ES:[BX + 0xC724]                 // read story state byte
     DI = AL                               // save full value
     AX = AL & 0x7F                        // mask off high bit (bit 7)
     
     if (AX < 0x10 || AX > 0x20)           // property must be in range 0x10-0x20
         goto NEXT
     
     // This property is a valid target reference
     match_count = [BP-0x2]
     [BP-0x2]++
     
     if (match_count != stage_counter)      // not the n-th match
         goto NEXT
     
     // SELECTED: this is the target for current stage
     [BP-0x8] = DI - 1                      // target_id = full_byte_value - 1
     
     // Validate target:
     BX = stage_counter + SI                // use stage counter instead of property offset
     if (ES:[BX + 0xC74B] != 0)             // validation byte at offset 0x27+stage
         target stays as DI - 1              // valid
     else
         [BP-0x8] = 0xFF                    // invalid, no target
     
     [BP-0x4] = 0x57                        // force loop exit
     
   NEXT:
     [BP-0x4]++
     if ([BP-0x4] < 0x56) goto loop
   
   return [BP-0x8]                          // AX = target_id or 0xFF
   ```

**Interpretation:**
- Story state properties at offsets **0x33-0x55** encode a **target preference sequence** per unit
- Each property byte = `(target_slot_id + 1)`, optionally with bit 7 set
- The `stage_counter` (from `[BP-0x42]` in the combat loop) selects which target in the sequence to use
- Validation byte at story state offset **(stage_counter + 0x27)** must be non-zero for the target to be valid
- Target IDs 0x10-0x20 in the encoded byte → slots 0x0F-0x1F (15-31), covering extended unit pool
- Returns **0xFF** if no valid target found (unit cannot act)

**Combat loop stage counter** (`[BP-0x42]`):
- Increments for each combat sub-phase
- Compared against 0xB (enemy slot count) and 0xC thresholds
- Used as the `stage_counter` parameter to select which target preference to use

---

### 4. TARGETING / LINE OF SIGHT & RANGE CHECK

**Function:** `ghidra_guess_1000_0934_10934`
**File:** `GeneratedCode10.cs` (lines 3466-3832)
**Segment:Offset:** 1000:0934 (linear 0x10934)

**Parameters (stack):**
| Param | Stack Offset | Description |
|-------|-------------|-------------|
| Unit ID | `[BP+0x6]` | Slot index 0-23 |
| Param   | `[BP+0x8]` | Weapon/attack type selector |

**Data access pattern:**
- Segment pointers loaded from DS:0x5582, 0x5584, 0x5590, 0x5592
- Unit X: `ES:[SI + 0x4004]` (SI = UnitID << 1)
- Unit Y: `ES:[SI + 0x4036]`
- Cursor X: `ES:[0xA44B]`
- Cursor Y: `ES:[0xA44D]`
- Weapon data accessed via: `BX = 0x11 * param` (weapon struct stride = 17 bytes)
  - `DS:[BX + 0x2EE4]` = weapon type/flags byte
  - `DS:[BX + 0x2EE6]` = skill/class (split: low 5 bits, high 3 bits >>5)
  - `DS:[BX + 0x2EE7]` = range threshold byte

**Logic:**
1. Classifies Unit ID range (0-3, 4-11, 12-23) → different team assignments
2. Fetches unit's current X/Y from position arrays
3. Compares with cursor/target position
4. Adjusts internal target coordinates iteratively
5. Coordinate masking with `0xF7F` and `0xF07F` → sub-pixel grid granularity
6. **LoS/Range check** via `ghidra_guess_1000_05C5_105C5` (called twice):
   - Takes packed coordinates with bit field extraction:
     - X: mask `0xF00` >> 1 | `0x7F` (low 7 bits + high nibble)
     - Y: mask `0xF000` >> 5 | `0x7F`
   - Computes absolute deltas between source and target
   - Checks against weapon range from the weapon data table:
     - `AX = weaponRange (from 0x2EE7)` compared with `[BP-0x8]` (calculated distance)
   - Returns whether target is in range and has line of sight

**Return value (AX) — action code:**
- `3` = in range, can fire (long range band)
- `2` = medium range band
- `1` = short range band
- `0` = no valid target / out of range

---

### 5. LINE OF SIGHT / FIRE VALIDATION

**Function:** `ghidra_guess_1000_160E_1160E` (Reko name `fn1631_1BFE`)
**File:** `GeneratedCode11.cs` (lines 1570-2059)
**Segment:Offset:** 1000:160E (linear 0x1160E)

Called from the combat loop at `GeneratedCode13.cs:2184` with 4 stack params:
| Param | Stack Offset | Source |
|-------|-------------|--------|
| `attacker_id` | `[BP+0x6]` | Current unit slot ID (unused in function body) |
| `target_id` | `[BP+0x8]` | Target unit slot ID |
| `target_x` | `[BP+0xA]` | Target's X coordinate |
| `target_y` | `[BP+0xC]` | Target's Y coordinate |

Attacker position is read from global cursor at `seg5582->A44B` (X) and `seg5584->A44D` (Y).

**Returns:** `AX` = 0 (blocked, cannot fire) or non-zero (LoS clear, can fire).

#### 5.1 Algorithm (Ray-Cast LoS)

```
fn_can_fire(attacker_id, target_id, target_x, target_y):
    cur_x = cursor.A44B    // attacker X from global cursor
    cur_y = cursor.A44D    // attacker Y
    
    // Special case: training dummy
    if (seg559C->E48E != 0 && target_id == 0xD):
        return 1           // training dummy always targetable
    
    // Initialize map tile index
    map_index = seg5586->ptr09ED + 0x96  // base map tile data + 150 offset
    diagonal_parity = 1
    y_subpixel = cur_y & 1
    if (cur_x & 1):                       // odd X → adjust start
        map_index++
        diagonal_parity = 0
    
    // Calculate initial 8-direction angle (ghidra_guess_0000_2F6F_02F6F)
    direction = fn_direction(cur_x, cur_y, target_x, target_y)
    
    can_fire = 1
    
    // FIRST TILE CHECK at starting position
    tile_prop = seg5588->data[map_index + 0x7AD]
    if (seg558A->skill_gate_0150 <= tile_prop):
        return 0  // blocked at starting position
    
    // MAIN RAY-CAST LOOP
    while (cur_x != target_x || cur_y != target_y):
        // Recalculate direction to home in on target
        new_dir = fn_direction(cur_x, cur_y, target_x, target_y)
        dir_diff = (new_dir - direction) & 7
        if (dir_diff != 0):
            if (dir_diff < 5): direction++   // rotate clockwise toward target
            else:              direction--   // rotate CCW (wrap around)
            direction &= 7
        
        // Step one unit in current direction
        cur_x += a328A[direction]  // X delta for this direction
        if (cur_x & 0x80):         // sub-pixel carry/underflow
            cur_x += a32AA[direction]
        
        cur_y += a329A[direction]  // Y delta
        if (cur_y & 0x80):         // sub-pixel carry/underflow
            cur_y += a32BA[direction]
        
        // Diagonal stepping (Bresenham-style tile index advance)
        if (a328A[direction] != 0):
            diagonal_parity = (diagonal_parity + a328A[direction]) & 1
            if (diagonal_parity == 0):
                map_index += a328A[direction]
        
        if (a329A[direction] != 0):
            y_subpixel = (y_subpixel + a329A[direction]) & 1
            if (y_subpixel == 0):
                map_index += a32CA[direction]  // extra Y diagonal advance
        
        // CHECK TILE BLOCKING at new stepped position
        tile_prop = seg5588->data[map_index + 0x7AD]
        if (seg558A->skill_gate_0150 <= tile_prop):
            // BLOCKED: snap to target, mark blocked
            cur_x = target_x
            cur_y = target_y
            can_fire = 0
    
    return can_fire
```

#### 5.2 Direction Tables (8-entry word arrays in DS segment)

| Address | Reko Name | Content | Purpose |
|---------|-----------|---------|---------|
| `DS:a328A` (0x328A) | `a328A[]` | 8 × `word16` | X-coordinate delta per direction |
| `DS:a329A` (0x329A) | `a329A[]` | 8 × `word16` | Y-coordinate delta per direction |
| `DS:a32AA` (0x32AA) | `a32AA[]` | 8 × `word16` | X sub-pixel carry correction |
| `DS:a32BA` (0x32BA) | `a32BA[]` | 8 × `word16` | Y sub-pixel carry correction |
| `DS:a32CA` (0x32CA) | `a32CA[]` | 8 × `int16` | Extra map index advance for Y diagonal |

The "sub-pixel corrections" handle carry/underflow in the coordinate system: `(byte)val & 0x80` detects crossing a 256-unit boundary.

#### 5.3 Skill Gate (Tile Blocking Check)

Two identical checks occur — at origin and each step:
```
tile_property = seg5588->data[map_index + 0x7AD]   // per-tile blocking strength
skill_gate = seg558A->t0150                          // global threshold

if (skill_gate <= tile_property) → BLOCKED
if (skill_gate > tile_property)  → PASSABLE
```

#### 5.4 Segment Pointers for LoS

| DS Offset | Seg Field | Memory | Purpose |
|-----------|-----------|--------|---------|
| `DS:0x5582` | `ptr5582` | `->A44B` | Cursor/attacker X |
| `DS:0x5584` | `ptr5584` | `->A44D` | Cursor/attacker Y |
| `DS:0x5586` | `ptr5586` | `->09ED` | Map tile data base pointer |
| `DS:0x5588` | `ptr5588` | `->[index+0x7AD]` | Tile blocking property (b07AD) |
| `DS:0x558A` | `ptr558A` | `->0150` | Skill gate threshold (t0150) |
| `DS:0x559C` | `ptr559C` | `->E48E` | Combat-in-progress flag |

---

### 6. TO-HIT FORMULA (2D6 SYSTEM)

The game implements a **tabletop BattleTech 2D6 to-hit system** — confirmed via Spice86 reverse engineering.

#### 6.1 2D6 Roll Generator

**Function:** `ghidra_guess_0000_30DD_030DD` (linear `0x30DD`). Generates a **2–12** roll matching
tabletop 2D6: `d6()` = rejection-sample `RNG() & 0x7` until `≤ 5`, then `+1` → 1–6; `roll_2d6()` =
`d6() + d6()`. Called **once per attack** at `1000:4FC2`. The underlying 24-bit LFSR is specified in
**§16** (canonical RNG spec).

#### 6.2 To-Hit Target Number (TN)

The target number is computed in the combat loop at `[BP-0x30]` (GeneratedCode13.cs lines 2444-2886).

**Base TN** (line 2444-2455):
```
[BP-0x30] = action_code * 2 + 4
```
Where `action_code` is the return from `ghidra_guess_1000_0934_10934` (targeting state check):
| Action Code | Range Band | Base TN |
|-------------|------------|---------|
| 0 | No target / out of range | 4 (minimum) |
| 1 | Short range | 6 |
| 2 | Medium range | 8 |
| 3 | Long range | 10 |

**Special override** (line 2457-2466): If weapon type = 0x20 (kick/unarmed), override TN = 3.

**Skill modifiers** (lines 2496-2523 via `ghidra_guess_1000_1554_11554`):
```
TN += popcount(~story_state[unit].byte[0x24] & 0x7)  // 0-3: bits 0,1,2 clear → +1 each
TN += popcount(~story_state[unit].byte[0x25] & 0x7)  // 0-3
```

The skill function reads from the story state structure (Eq_107947, stride 0x7D) at:
- `ES:[BX + 0xC724 + unitID * 0x7D + property_offset]`
- Property 0x24 → byte at slot offset 0x24
- Property 0x25 → byte at slot offset 0x25
- Returns count of low 3 bits that are 0 (0-3 range)

**Skill Modifier Function:** `ghidra_guess_1000_1554_11554`
**File:** `GeneratedCode11.cs` (lines 1324-1421)

```
fn_skill_modifier(uint16 slot_offset, uint16 unit_id):
    // slot_offset = story state property offset (e.g. 0x24, 0x25)
    // unit_id = unit slot index
    
    index = 0x7D * unit_id + slot_offset   // story state struct offset
    ES = DS:[0x558E]                        // story state segment
    state_byte = ES:[BX + 0xC724]           // read story state byte
    
    // Popcount of low 3 bits that are CLEAR (0):
    count = 0
    if (!(state_byte & 0x01)) count++       // bit 0 clear → +1
    if (!(state_byte & 0x02)) count++       // bit 1 clear → +1
    if (!(state_byte & 0x04)) count++       // bit 2 clear → +1
    
    return count                            // 0-3
```

Called twice per unit in the TN calculation:
- `fn_skill(0x24, unit_id)` → skill_A modifier (0-3)
- `fn_skill(0x25, unit_id)` → skill_B modifier (0-3)
- Total range: 0-6 added to target number

The story state properties at offsets 0x24/0x25 encode a unit's piloting and gunnery skill. Each cleared bit in the low 3 bits represents a +1 TN penalty (i.e., less skilled). A fully cleared byte (0x00) gives +3 penalty per property; a fully set byte (0x07) gives +0.

**Terrain modifier** (lines 2540-2551):
```
tile_property = ES:[BX + 0x32C6]  // tile movement cost/terrain type
TN += sign_extend(tile_property) + 1
```
The tile at `unit_id * 0x30` from segment at DS:0x5654 — terrain affects to-hit.

Tile property table at `DS:[0x55DC]→0x32C6` (also accessible via `DS:[0x5654]→0x32C6`):
- **4-byte record per tile** within 0x30 (48-byte) stride per unit slot:
  - `+0` (`b32C6`): Tile property / movement cost — 0xFF=impassable, 0x00=clear terrain, higher=more cover
  - `+1` (`b32C7`): Packed X-coordinate high (from `((X & 0x0F00 | Y & 0xF000) >> 8)`)
  - `+2` (`b32C8`): Packed X-coordinate low (from `(X & 0x7F)`)
  - `+3` (`b32C9`): Sub-type / flag field (compared to determine blocking writes)
- Value ranges: `0xFF` = impassable/uninitialized; `0x00-0x02` = normal terrain; higher = more cover
- To-hit contribution: `sign_extend(value) + 1` → `0xFF`→`0`, `0x00`→`+1`, `0x01`→`+2`, etc.
- Separate LoS blocking check at `DS:[0x5588]→[index+0x7AD]` — uses a different property value compared against skill gate at `DS:[0x558A]→t0150`

**Terrain table modifier** (lines 2568-2575):
```
TN += sign_extend(ES:[BX + 0x2D1A])  // additional terrain/status table
```

**Story state penalty** (lines 2655-2665):
```
if (unit.story_state @ 0xC79B != 0)   // citadel attacked or destroyed
    TN += 2
```

**Heat penalty** — Player units (unit_id < 4, lines 2705-2749):
```
status_byte = ES:[BX + 0x6E]   // unit heat level
if (status_byte >= 8)  TN += 1    // threshold 1: heat ≥ 8
if (status_byte >= 13) TN += 1    // threshold 2: heat ≥ 13 (total +2)
if (status_byte >= 17) TN += 1    // threshold 3: heat ≥ 17 (total +3)
if (status_byte >= 24) TN += 1    // threshold 4: heat ≥ 24 (total +4)
```

**Heat penalty** — Enemy units (unit_id 4-11, lines 2842-2886):
```
status_byte = ES:[BX + 0x66]   // enemy heat level (different offset!)
if (status_byte >= 8)  TN += 1
if (status_byte >= 13) TN += 1
if (status_byte >= 17) TN += 1
if (status_byte >= 24) TN += 1
```

#### 6.3 Heat Generation per Shot

After to-hit TN calculation but before the hit check, weapon heat is accumulated (GeneratedCode13.cs lines 2670-2697):

```
// For all units — weapon instance heat value
SI = 0x11 * weapon_slot              // weapon instance stride
ES = DS:[0x5652]                      // weapon instance segment
AL = ES:[SI + 0x2EE5] & 0x0F          // heat per shot from weapon instance byte 1

// Add to unit's heat pool:
BX = unit_id
if (unit_id < 4):                      // player unit
    ES = DS:[0x5658]
    ES:[BX + 0x92] += AL              // player heat accumulator
else:                                  // enemy unit
    ES = DS:[0x5658]
    ES:[BX + 0x8A] += AL              // enemy heat accumulator (different offset)
```

The weapon INSTANCE table at `DS:[0x5652]:0x2EE4` with stride 0x11 stores per-equipped-weapon state:
| Instance Offset | Field | Description |
|----------------|-------|-------------|
| `+0x00` (0x2EE4) | Ammo state | Bit 7 = infinite ammo flag, low 7 bits = remaining ammo count |
| `+0x01` (0x2EE5) | Heat | Low nibble (`& 0x0F`) = heat generated per shot |

The heat pool offset differs between player (`0x92`) and enemy (`0x8A`) units, at segment `DS:[0x5658]`.

#### 6.4 Heat Dissipation (End-of-Round Reset)

**Function:** `ghidra_guess_1000_0673_10673`
**File:** `GeneratedCode10.cs` (lines 2677-3330)
**Called from:** `GeneratedCode13.cs:6953` (end of combat loop, guarded by `ES:[0x14A]`)

Heat does NOT dissipate gradually between turns. Instead, at the **end of each combat round** (after all units have acted), the system:

1. **Transfers** the accumulated heat pool to the penalty register:
   ```
   // For each player unit (IDs 0-3):
   ES = DS:[0x55A6]         // heat pool segment
   AL = ES:[SI + 0x92]      // read heat pool (current round's accumulated heat)
   ES = DS:[0x5598]          // heat penalty segment
   ES:[SI + 0x6E] += AL     // ADD pool value to penalty accumulator
   ```
   The penalty register at `0x6E` accumulates across rounds — each round adds the pool value.

2. **Clears** the heat pool to zero:
   ```
   ES = DS:[0x55A6]
   ES:[BX + 0x92] = 0       // reset heat pool for next round
   ```

3. **Optional extra penalty**: If a counter at `ES:[SI + 0xD576]` is non-zero:
   - Adds an additional +6 to the penalty at `0x6E`
   - Decrements the counter

4. **Conditional penalty reduction**: Under certain conditions (weapon range check):
   - Subtracts 4 from the penalty at `0x6E`

5. **Clamp**: The penalty at `0x6E` is capped at 30 (`0x1E`):
   ```
   if (ES:[BX + 0x6E] > 0x1E)
       ES:[BX + 0x6E] = 0x1E
   ```

**Enemy units** — the heat pool at `0x8A` and penalty at `0x66` are **NOT** cleared by this function. Enemy heat pool only increases from weapon fire. The enemy penalty is clamped at 30 (`0x1E`) elsewhere (GeneratedCode13.cs line 5804-5805).

**Guarding mechanism:** The dissipation call is skipped if `ES:[0x14A]` (from segment `DS:[0x5630]`) is zero.

**Summary:**
| Event | Player Heat Pool (0x92) | Player Heat Penalty (0x6E) | Enemy Pool (0x8A) | Enemy Penalty (0x66) |
|-------|------------------------|---------------------------|-------------------|---------------------|
| Weapon fires | +heat value | — | +heat value | — |
| End of round | → copied to penalty, then cleared to 0 | += pool value | — (never cleared) | — (never cleared) |
| Clamp | — | ≤ 30 | — | ≤ 30 |

#### 6.5 Ammo Check (lines 4610-4670)

Before firing, the weapon's ammo state is checked:
```
ES = DS:[0x5652]
SI = 0x11 * weapon_slot

TEST ES:[SI + 0x2EE4], 0x80     // check bit 7 (infinite ammo flag)
if NZ:  goto skip_ammo_check     // infinite ammo — skip all ammo handling

// Finite ammo:
CMP ES:[SI + 0x2EE4], 0x1       // compare remaining count with 1
if ammo <= 1 (JBE):
    → out-of-ammo path (skip damage roll, weapon still "fires" but does no damage)

if ammo > 1:
    → roll 2D6 and compute damage variance based on remaining ammo
```

The ammo count byte `ES:[SI + 0x2EE4]` with bit 7 clear stores initial remaining shots. This weapon instance table at `DS:[0x5652]→0x2EE4` (stride 0x11) is **read-only during combat** — the byte is checked (bit 7 = infinite, CMP ≤ 1 = out-of-ammo) but never written back.

The actual ammo decrement happens on the **mech's 125-byte per-unit struct** in segment `0x2A02`, NOT on the weapon instance table:

**Player units (0-3):**
```
DEC byte ptr [0x2A02 : 0xC74B + unit_id * 0x7D + stage_counter]
```
- Guard: `unit_id < 4 && stage_counter < 0xB` (stage_counter = [BP-0x42], 0..0xA)
- Guard: value != 0xFF (empty/absent ammo bin)
- Base 0xC74B = 0xC724 + 0x27: offset 0x27 = byte 39 = first CurrentAmmo[0] in the mech struct
- The stage_counter (0..0xA) indexes into ammo bins 0-10 matching the 10-slot CurrentAmmo[10] array

**Extended pool units (12-15):**
```
DEC byte ptr [0x2A02 : 0xC363 + unit_id * 0x7D + stage_counter]
```
- Same stride and guards, different base

**Enemy units (4-11):** Use a burst counter mechanism instead of ammo bins:
```
INC byte ptr [0x2A02 : 0xC5D4 + unit_id * 0x11 + weapon_type_field]
```
- Capped at 4 (CMP 0x4, JGE = skip)
- Per-unit weapon tracking at `DS:[0x5648]→[BX+0xD358]` (shot counter) and `[BX+0xD360]` (weapon type)
- Enemies get unlimited "bursts" of up to 4 shots per weapon type rather than limited ammo

#### 6.6 Cluster Weapons — Damage Grouping (lines 4636-4693)

LRM and SRM weapons fire as a **single aggregated salvo** — per-missile hit location rolling is NOT implemented:

```
// Read per-missile damage and shots/cluster column index
damage_per_missile = ES:[SI + 0x2EE3]       // 0x01=LRM, 0x02=SRM (b0000 of weapon instance)
cluster_col        = ES:[SI + 0x2EE4]        // column index into cluster hits table (bit 7 = infinite)

if (bit 7 SET): → skip cluster table, use energy weapon path (direct damage)
if (cluster_col <= 1): → skip cluster table (single-shot weapon)

// Cluster hits table lookup
Call 0000:30DD (2D6 roll)                  // 2D6 (2-12)
index    = 2D6 * 7 + cluster_col            // row*7 + column (row=2D6 result, col=low7 of 0x2EE4)
ES = UInt16[DS, 0x566C]                     // cluster table segment
hits     = UInt8[ES, (BX + 0x2E5E)]        // number of missiles that hit
total_damage = damage_per_missile * hits    // single aggregated value → [BP-0x7C]
```

Key points:
- **Cluster table** at `DS:[0x566C]→0x2E5E`: 7-byte stride per row (column index 0-6), 11 rows (2D6=2..12)
- **Result**: single total damage value → applied to ONE hit location (not per-missile distribution)
- **Ammo**: The `cluster_col` (0x2EE4 & 0x7F) doubles as cluster table column index and is NOT decremented (weapon instance table is read-only). Actual ammo consumption happens on the mech struct ammo bins (see §6.5)
- **Energy weapons** (bit 7 set): skip cluster table entirely, using a different direct-damage path

#### 6.7 Hit Determination (lines 4696-4708)

```
Call 0000:30DD (2D6 to-hit roll)
if (roll < TN)  → MISS
if (roll >= TN) → HIT
```

**On MISS** (line 4709-4734):
- Display miss message (string at segment 0x3EDE)
- Set damage = 0
- Check if unit has returning fire capability

**On HIT** (line 4953-4985):
- Display hit message (string at segment 0x3EE7)
- Call damage application with [BP-0x60] (hit location offset from RNG & 0x8 table)
- Set [BP-0x56] = 1 (hit flag)

#### 6.8 Hit Location Selection (lines 4586-4607, 4367-4450)

The hit location offset is determined by two complementary paths:

**Path A — RNG-driven variant** (for combat units, lines 4586-4607):
```
Call unknown_19EF_0BC0_1AAB0 (RNG)
BX = AX & 0x8    // 0 or 8 — selects one of 2 table entries
ES = UInt16[DS, 0x566A]
AL = UInt8[ES, BX + 0x2E43]  // 2-entry hit location offset table
AH = 0
[BP-0x60] = AX  // hit location offset within 125-byte struct
```

**Path B — Weapon-to-location mapping** (for enemy mechs slots 0xC-0xF, lines 4367-4450):
```
BX = [BP-0x28]  // unit ID (0xC-0xF for enemy mechs)
ES = UInt16[DS, 0x563C]
AL = UInt8[ES, BX + 0x396C]  // weapon-to-body-part mapping table
if AL == -1 (0xFF):
    ES = UInt16[DS, 0x5666]
    AL = UInt8[ES, BX + 0x45B6]  // fallback mapping
[BP-0x46] = AL
BX = [BP-0x46] - [BP-0x60]  // compute difference from current slot
// ... continues with slot comparison/validation
```

The two-entry table at `DS:[0x566A]→0x2E43` encodes 2 possible hit locations per target type. RNG & 0x8 picks one, providing 50/50 variance. The hit location offset `[BP-0x60]` indexes into the 125-byte story slot struct, pointing to the specific armor/internal field at `C724 + unit_id*125 + offset`.

---

### 7. COMPLETE COMBAT DAMAGE APPLICATION PIPELINE

**File:** `GeneratedCode13.cs` (segment 1000, function starting ~0x4C00)
**Key variables on stack frame:**

| BP Offset | Variable | Description |
|-----------|----------|-------------|
| `-0x0C` | unit_id | Target unit slot (combat index 0-23, mapped to story slot) |
| `-0x28` | combat_slot | Original combat loop iteration slot |
| `-0x30` | target_number | To-hit target number (TN, built earlier in phase) |
| `-0x34` | ammo_counter | Remaining shots counter for multi-shot/volley |
| `-0x48` | weapon_slot | Weapon mount/body part index (stage counter, 0-10) |
| `-0x52` | armor_value | Current armor value at the hit location (read from struct) |
| `-0x56` | hit_flag | Set to 1 if attack hit, 0 if miss |
| `-0x60` | loc_offset | Hit location offset within 125-byte mech struct |
| `-0x7C` | damage | Damage accumulator (per-missile damage × cluster hits) |

**Overall flow:**

```
Weapon Instance Loading (§7.1)
  │
  ├─► Non-cluster weapon (§7.2a): damage = per-missile damage
  └─► Cluster weapon (§7.2b): damage = per-missile × cluster_table[2D6*7 + col]
  │
  ▼
To-Hit Check (§7.3): 2D6 vs TN
  │
  ├─► MISS: damage = 0, display miss message
  │
  └─► HIT: display hit message
  │
  ▼
Hit Location Selection (§7.4): via RNG + 2-entry table at [0x566A]:0x2E43
  │
  ▼
Armor Read (§7.5): armor = story_struct[C724 + unit_id*125 + loc_offset]
  │
  ▼
CMP damage vs armor
  │
  ├─► damage <= armor (§7.6 Normal Path):
  │     story_struct.armor -= damage
  │     if loc in [0x1C-0x23]: call critical_handler(unit, loc)
  │     damage = 0
  │
  └─► damage > armor (§7.7 Overkill Path):
        excess = damage - armor
        story_struct.armor = 0
        if loc in [0x1C-0x23]: call critical_handler(unit, loc)
        damage = excess
  │
  ▼
Slot Advance (§7.11): loc_offset = advance(loc_offset)
  │
  ▼
  CMP damage, 0
  │
  ├─► damage > 0 → LOOP back to Armor Read (§7.5) with next location
  │
  └─► damage == 0 → DONE
```

---

#### 7.1 Weapon Instance Loading (lines 4586-4648)

Sets up weapon data and computes base damage per missile:

```
    FarCall to 0000:30DD (2D6 roll)
    ── used as initial seed/RNG consume ──

    RNG → BX &= 0x8 → read hit location variant from [0x566A]:0x2E43
    ── [BP-0x60] = hit location offset (see §7.4) ──

    // Weapon data access
    SI = [BP-0x48] * 0x11    // weapon_slot × 17-byte stride
    ES = UInt16[DS, 0x5652]   // weapon instance segment

    // Infinite ammo check
    TEST ES:[SI + 0x2EE4], 0x80
    if NZ → skip (infinite ammo, e.g. energy weapons)

    // Base per-missile damage
    AL = ES:[SI + 0x2EE3]      // damage per missile (0x01 LRM, 0x02 SRM)
    AH = 0
    [BP-0x7C] = AX             // store as initial damage

    // Cluster weapon check
    CMP ES:[SI + 0x2EE4], 1
    JBE → skip cluster table (single-shot weapon)
```

**Weapon instance table** at `DS:[0x5652]` (stride 0x11 = 17 bytes):

| Offset | Field | Description |
|--------|-------|-------------|
| `+0x00` (0x2EE4) | ammo_type | Bit 7 = infinite ammo, low 7 = remaining shots / cluster column index |
| `+0x01` (0x2EE5) | heat | Low nibble (`& 0x0F`) = heat per shot |
| (other fields) | name/damage/range | Copied from master weapon table at init |

---

#### 7.2a Damage Value — Non-Cluster Weapons (lines 4636-4648)

For weapons with `0x2EE4 <= 1` (single-shot, non-cluster):
- Base damage = `ES:[SI + 0x2EE3]` (per-missile damage field)
- Stored directly to `[BP-0x7C]`

#### 7.2b Damage Value — Cluster Weapons (lines 4649-4693)

For weapons with `0x2EE4 > 1` (LRM, SRM, multi-shot):

```
    FarCall to 0000:30DD (2D6 roll)    → AX = 2..12
    CX = 7
    IMUL CX                              → AX = 2D6 * 7 (row index into cluster table)
    ES = UInt16[DS, 0x5652]              ← weapon instance segment (reload)
    BL = ES:[SI + 0x2EE4]               ← cluster column index (low 7 bits)
    BH = 0
    BX += AX                             → BX = column + 2D6*7
    ES = UInt16[DS, 0x566C]              ← cluster table segment
    AL = ES:[BX + 0x2E5E]               ← number of hits from table
    AH = 0
    IMUL [BP-0x7C]                       → total = hits × per_missile_damage
    [BP-0x7C] = AX
```

**Cluster hits table** at `DS:[0x566C]→0x2E5E`:

```
    Rows:    11 rows indexed by 2D6-2 (2,3,4,...,12)
    Columns: 7 columns indexed by weapon subtype (0-6)
    Stride:  7 bytes per row
    Cell:    uint8 = number of missiles that hit

    Total damage = cell_value × per_missile_damage
    Applied as single value to ONE hit location
```

---

#### 7.3 To-Hit Check (lines 4694-4708)

```
    FarCall to 0000:30DD (2D6 roll)     → AX = 2..12
    CMP AX, [BP-0x30]                   ← compare with TN (target number)
    JL → MISS
    JMP → HIT
```

**On MISS** (lines 4709-4734):
```
    Display miss message (segment 0x3EDE)
    [BP-0x56] = 0    ← miss flag
    [BP-0x7C] = 0    ← zero damage
    Check unit visibility at ES:[0x5662]:0x32AE[unit]
    → if visible, set up return fire check
```

**On HIT** (lines 4953-4985):
```
    Display hit message (segment 0x3EE7)
    [BP-0x56] = 1    ← hit flag
    → falls through to damage application
```

---

#### 7.4 Hit Location Selection (lines 4586-4607 and 4367-4450)

[Duplicate of §6.8 — see above for details]

The hit location offset `[BP-0x60]` selects which field within the 125-byte mech struct receives damage. It indexes into the armor+internal array at `C724 + unit_id*125 + offset`.

---

#### 7.5 Armor Read and Damage Application Entry (lines 5040-5079)

```
    AX = 0x7D
    IMUL [BP-0x0C]                 → unit_id * 125
    BX = AX
    ADD BX, [BP-0x60]              → BX = unit_id*125 + hit_location_offset
    ES = UInt16[DS, 0x5648]        ← story data segment
    AL = ES:[BX + 0xC724]          ← current armor value at hit location
    AH = 0
    [BP-0x52] = AX                 ← save armor value

    CMP [BP-0x7C], AX              ← compare damage vs armor
    JLE → normal damage path (§7.6)
    JMP → overkill damage path (§7.7)
```

The base address `0xC724` is the start of the story slot state array (Eq_107947, stride 0x7D). The 125-byte struct stores 11 armor locations (starting at offset 0x11 in the struct), 8 internal structure slots (offset 0x1C), and ammo bins (offset 0x27). The hit location offset `[BP-0x60]` indexes into these:
- `0x00-0x10`: Name/slot metadata (not armor)
- `0x11-0x1B`: CurrentArmour[11] (11 bytes, locations 0-10)
- `0x1C-0x23`: CurrentStructure[8] (8 bytes, locations 0-7)
- `0x24-0x27`: Actuators[4]
- `0x28`: EngineHeatSinks
- `0x29-0x32`: CurrentAmmo[10]

The comparison at line 5070 uses offset range 0x1C-0x23 and 0x1F/0x20 for special handling, confirming these as internal structure slots.

---

#### 7.6 Normal Damage Path (damage <= armor, lines 5080-5168)

```
    // At label 0x5116:
    CMP [BP-0x7C], [BP-0x52]   → if damage == armor:
        // Exact armor depletion: check if hit location is internal structure
        CMP [BP-0x60], 0x1C    → structure slot 0?
        JZ → set flag
        CMP [BP-0x60], 0x21    → structure slot 5?
        JNZ → skip
        // Set internal damage flag at [0x5676]:0x3986
        ES = UInt16[DS, 0x5676]
        ES:[0x3986] = 1

    // Apply damage subtraction
    AL = [BP-0x7C]             ← damage value
    CX = AX
    BX = unit_id * 0x7D + [BP-0x60]
    ES = UInt16[DS, 0x5648]
    ES:[BX + 0xC724] -= CL     ← subtract damage from armor

    [BP-0x7C] = 0              ← reset damage accumulator

    // Critical/internal damage check
    CMP [BP-0x60], 0x1C
    JL → skip (not internal structure)
    CMP [BP-0x60], 0x23
    JG → skip (not internal structure)
    // Range [0x1C-0x23]: internal structure hit
    PUSH [BP-0x60]
    PUSH [BP-0x0C]             ← unit_id
    CALL ghidra_guess_1000_0BBB_10BBB  ← critical/destruction handler
    ADD SP, 4

    // Post-critical check
    CMP [BP-0x60], 0x1F
    JZ → continue_special
    CMP [BP-0x60], 0x20
    JZ → continue_special
    JMP → exit_path
```

---

#### 7.7 Overkill/Overflow Damage Path (damage > armor, lines 5269-5402)

```
    // At label 0x51C4:
    AX = [BP-0x52]                 ← original armor value
    [BP-0x7C] -= AX                ← excess = damage - armor (carries to next slot)

    // Zero out armor at this location
    BX = unit_id * 0x7D + [BP-0x60]
    ES = UInt16[DS, 0x5648]
    ES:[BX + 0xC724] = 0           ← armor destroyed

    // Check if this location had armor > 0 (was worth processing)
    CMP [BP-0x52], 0
    JZ → skip_critical              ← no armor to begin with

    // Same internal structure check as normal path:
    CMP [BP-0x60], 0x1C
    JZ → call_critical
    CMP [BP-0x60], 0x21
    JNZ → skip_critical

    // Set internal damage flag for structure slots
    ES = UInt16[DS, 0x5676]
    ES:[0x3986] = 1

    // Call critical/destruction handler for range [0x1C-0x23]
    PUSH [BP-0x60]
    PUSH [BP-0x0C]
    CALL ghidra_guess_1000_0BBB_10BBB
    ADD SP, 4

    // After critical: check for mech destruction
    PUSH [BP-0x60]
    CALL ghidra_guess_1000_0B32_10B32   ← advance to next slot
    ADD SP, 2
    [BP-0x60] = AX                       ← new hit location

    // Destruction check branch:
    CMP [BP-0x28], 0              ← combat slot 0?
    JZ → check_mech_destroyed
    JMP → exit

    // If target's combat slot is 0 AND [BP+0x6] != 0 → unit destroyed
    // Calls ghidra_guess_0000_EAEE_0EAEE for destruction handling
```

---

#### 7.8 Damage Overflow Loop (lines 5403-5414)

After both normal and overkill paths converge at `label_1000_524A_1524A`:

```
    CMP [BP-0x7C], 0              ← check remaining damage
    JZ → exit (all damage applied)

    // Still have damage — loop back to apply to next slot
    JMP → label_1000_50C3_150C3   ← re-enter damage loop
```

The loop entry at `0x50C3` (line 4986):
```
    AX = 0x7D
    IMUL [BP-0x0C]               → unit_id * 125 stride
    BX = AX
    ES = UInt16[DS, 0x5648]
    CMP ES:[BX + 0xC724], 0xFF   ← check sentinel (0xFF = slot end)
    JNZ → continue
    JMP → exit (no more valid slots)

    CMP [BP-0x48], 0xB           ← weapon slot counter == 0xB?
    JNZ → skip_special
    // Special handling for slot 0xB:
    ES = UInt16[DS, 0x5674]
    ES:[BX + 0xD576] = 3         ← set some status flag
    [BP-0x34] = 0                ← reset counter
    [BP-0x7C] = 0                ← clear remaining damage

    // Falls through to armor read at §7.5 with new [BP-0x60]
```

The overflow loop allows damage to **punch through** armor into internal structure, and from one body part to the next. A weapon that does 25 damage to a location with 8 armor will:
1. Armor = 0 (8 absorbed)
2. Excess = 17 → applied to next location (internal structure at offset 0x1C+)
3. If internal structure is depleted, continues to next slot

---

#### 7.9 Critical Hit Propagation (Grid Adjacency)

**Function:** `unknown_19EF_11BB_1B0AB`
**File:** `GeneratedCode18.cs` (lines 4354-4653)
**Segment:Offset:** 19EF:11BB (linear 0x1B0AB)

Called from `unknown_19EF_1886_1B776` which iterates 9 body part pairs:

| Iteration | SI (source) | DI (dest) | Body Location |
|-----------|-------------|-----------|---------------|
| 1 | 0x564 | 0x324 | Right Arm |
| 2 | 0x5A4 | 0x364 | Right Leg |
| 3 | 0x5E4 | 0x3A4 | Right Torso |
| 4 | 0x624 | 0x3E4 | Head |
| 5 | 0x664 | 0x424 | Center Torso |
| 6 | 0x6A4 | 0x464 | Left Arm |
| 7 | 0x6E4 | 0x4A4 | Left Leg |
| 8 | 0x724 | 0x4E4 | Left Torso |
| 9 | 0x764 | 0x524 | Center Torso (rear) |

**Structure:** 6×6 grid with width 8 (±1, ±8 neighbor offsets)

**Operations per cell:**
1. Reads byte at `[SI]`, `[SI-1]`, `[SI+1]`, `[SI-8]`, `[SI+8]`
2. Compares current cell value with neighbors
3. Sets bits in `[DI]`:
   - Bit 0x8 = destroyed status
   - Bit 0x4 = neighbor match
   - Bit 0x2 = secondary/transfer flag

**Purpose:** When a critical slot is destroyed (e.g., an ammo bin or gyro), the grid propagates destruction status to adjacent slots within the same body location. The 6×6 grid maps to the critical slot layout (BattleTech mechs have 6-12 critical slots per location).

Also called by helper sub-functions:
- `unknown_19EF_12BA_1B1AA` — single-slot grid evaluation
- `unknown_19EF_12F2_1B1E2` — multi-slot comparison
- `unknown_19EF_12D9_1B1C9` — slot scroll/rotate variant

---

#### 7.10 VGA Impact Visual Effect → `engine/viewport.md`

The impact/VFX **rendering** (VGA `0x3CE` Set/Reset + Bit Mask, `0xA452`/`0xA454`/`0xA456`,
13-frame splash loop) is engine rendering, moved to
[`engine/viewport.md`](engine/viewport.md) ("Impact VFX"). Combat calls it after damage is applied.

---

#### 7.11 Slot Advance Function

**Function:** `ghidra_guess_1000_0B32_10B32`
**File:** `GeneratedCode10.cs` (lines 4074+)
**Segment:Offset:** 1000:0B32 (linear 0x10B32)

Called with the current hit location offset as argument, returns the next location to process:

```
    // Jump table dispatch based on input offset:
    if offset in [0x11..0x18]:     ← armor slots 0-7
        return offset + 0xB        ← maps to corresponding internal structure slot

    offset -= 0x19                 ← after armor range
    if offset > 0xA:
        return original_value      ← out of range, return unchanged

    // For offsets 0x19-0x23 (internal structure range):
    BX = offset * 2
    switch CS:[BX + 0x118E]:       ← jump table at code segment
        case ...: return next_offset
```

**Purpose:** Determines the sequence of body locations that excess damage flows through. When armor at `offset 0x11` is depleted, the next damage goes to `offset 0x11+0xB = 0x1C` (the corresponding internal structure). Within the internal structure range (0x1C-0x23), a jump table defines the traversal order.

---

#### 7.12 Phase 3 Combat Stage Function — `unknown_19EF_1DF8_1BCE8` and Variants

**File:** `GeneratedCode19.cs` (lines 1192-1462) — function `unknown_19EF_158C_1B47C`

This is the **primary damage phase function** (Phase 3 in the combat loop). It:

1. Decrements the cursor/phase counter at `0xA44D` (see §7.13)
2. On counter underflow (AL goes negative):
   - Resets counter: AH -= 0x10, AL = 0x7F → writes back to `0xA44D`
   - Calls `unknown_19EF_0BFB_1AAEB` for each of the 9 body part pairs
   - Calls `unknown_19EF_1886_1B776` (critical transfer) on iterations 3 and 9
   - Writes animation/sparkle data to `0x9F3` buffer:
     ```
     [0x9F3] = 0x100 or 0x706     ← sparkle/animation type
     [0x9F5] = 0x01               ← animation frame
     Coordinates packed from A44B/A44D:
         AL = ((A44D | A44B) >> 8) - 0x11
     ```

The 0x9F3 buffer is consumed by the rendering code in `GeneratedCode2.cs` (segment 0170), which iterates 3 entries, reads `0x9F3`/`0x9F6`/`0x9F3`, draws damage sparkles, and sets each consumed entry to 0xFF.

The sibling functions handle specific phase transitions:
- `unknown_19EF_163B_1B52B` — increments the `0xA44D` counter (phase advance, edge detection)
- `unknown_19EF_16E3_1B5D3` — decrements the `0xA44B` counter (X coordinate adjust)
- `unknown_19EF_17C5_1B6B5` — increments the `0xA44B` counter (X coordinate adjust)

---

#### 7.13 The 0xA44B/0xA44D Packed Cursor/Counter Register

`DS:[0xA44B]`/`DS:[0xA44D]` are **dual-purpose**.

- **As cursor coordinates** (world map / text): low byte = sub-tile X/Y, high byte = tile column/row;
  `tile_x = (A44B & 0x7F) >> 1`. Canonical in
  [`engine/input-navigation.md`](engine/input-navigation.md) ("Cursor system").
- **As phase/action counters** (combat-specific): `0xA44D` low byte = combat sub-phase counter
  (decremented by the phase function); `0xA44B` low byte = action/weapon slot counter. Overflow: when
  the low byte underflows (sign flag), the high byte decrements by `0x10` and the low byte resets to
  `0x7F`.

---

### 10. RNG IMPLEMENTATION

See §16 below for the full RNG specification (24-bit LFSR, state aliasing across
segments, and the 2D6 roll built on top of it).

---
### 11. POST-FIRE CLEANUP

**Function:** `unknown_19EF_1DF8_1BCE8`
**Segment:Offset:** 19EF:1DF8 (linear 0x1BCE8)

Handles state cleanup after a unit completes its fire phase:
- Updates unit action status
- Possibly checks for unit destruction
- Advances to next unit in the loop

---

### 12. COMBAT STATE & MODE FLAGS

> **Corrected (2026-09-28).** Earlier this section presented `w4FBA` as the "combat state machine".
> That is wrong and contradicted `engine/viewport.md`: **`w4FBA` is the global UI/render mode**, set
> at startup and toggled `0↔1` around the render pass — it is **not** changed during gameplay. The
> actual dynamic screen change for combat is **`w4FBC`** (left panel narrows `80px → 4px`), and the
> actual combat **phase** machine is §1 / `CombatManager`.

- **Screen change on entering combat**: `w4FBC` narrow panel → [`engine/viewport.md`](engine/viewport.md).
- **Combat phases / state**: §1 Overall Combat Flow, §7 damage pipeline, §13 data structures.
- **Story-driven encounters** (props `0x1F` citadel attack, `0x20` multi-step): canonical in
  [`story/story-system.md`](story/story-system.md) §17.5–§17.6.

---

### 13. DATA STRUCTURES REFERENCE

#### Unit Position/Status Arrays (Segment from DS:0x5590/0x5592 range)

| Address | Type | Elements | Description |
|---------|------|----------|-------------|
| `ES:[ID*2 + 0x4004]` | uint16 | 24+ | Unit X coordinate |
| `ES:[ID*2 + 0x4036]` | uint16 | 24+ | Unit Y coordinate |
| `ES:[ID*2 + 0x406A]` | uint16 | 24+ | Unit status (0=dead/inactive) |
| `ES:[0x40B4]` | uint16 | per-unit | Unit property byte (type/flags) |
| `ES:[0x40B5]` | uint16 | per-unit | Unit secondary property |

#### Cursor/Target Position

| Address | Segment Source | Description |
|---------|----------------|-------------|
| `ES:[0xA44B]` | DS:0x5582 | Cursor/target X coordinate |
| `ES:[0xA44D]` | DS:0x5584 | Cursor/target Y coordinate |

Combat state at 0xA44B/0xA44D is saved/restored around the combat handler invocation.

#### Weapon Data Table (stride = 17 bytes = 0x11)

> ⚠️ **The offsets below are provisional and appear shifted by one vs the binary** (2026-09-28).
> A fresh dump of the 33-record definition table (`UNBTECH.exe` @ `0x3D088`) indicates
> **`+0x0B` = damage**, **`+0x0C` = cluster column/volley**, `+0x10` = skill; `+0x0A`/`+0x0D`/`+0x0E`
> are unresolved. See **§21** below for the dump +
> multi-shot (SRM/LRM) mechanics.

| Field | Offset | Description |
|-------|--------|-------------|
| Name | +0x00 | 10 bytes, ASCII null-padded |
| _(unresolved)_ | +0x0A | uint8 |
| **Damage (per-missile for cluster)** | **+0x0B** | uint8 |
| **Cluster column / volley** | **+0x0C** | uint8 (1 = single-shot) |
| Sound/VFX / heat? | +0x0D | uint8 (ambiguous) |
| Range (packed) | +0x0E | uint16 LE |
| Skill | +0x10 | uint8 (0=B&Blades, 1=Pistol, 2=Rifle, 3=Gunnery, 4=Kick) |

Access pattern: `BX = weaponSlot * 0x11`, then `DS:[BX + 0x2EE4]` (range table copy in data segment)

#### Mech/Unit State Array (stride = 0x7D = 125 bytes, Eq_107947)

Full battlefield unit state, including mechs and infantry. The 125-byte record matches the save game format documented in `InceptionTools/Data/SaveGame.cs`:
- Name (15 bytes), Tonnage, Armour (11 slots), Internal Structure (8 slots), Actuators (4 slots), Heat Sinks, Ammo (10 slots), Walk/Jump MP, Critical slots per location (7/7/7/7/2/2/2/1)

#### Combat State Arrays (at segment from DS:0x5648)

| Symbol | Size | Description |
|--------|------|-------------|
| `aD457` | 64 | Combatant status/type per slot |
| `aD497` | 65 | ID or team flags |
| `aD4D7` | 65 | Initial positions/movement state |
| `aD517` | 65 | Target coordinates or target ID |
| `tD557` | 1 | Combatant iteration index |

#### To-Hit Target Number

- The to-hit target number is built in `[BP-0x30]` throughout the combat loop
- Initial value = `targeting_return * 2 + 4` (maps range band to base TN)
- Weapon type 0x20 (kick) overrides to TN=3
- Accumulates skill, terrain, heat, and story state modifiers
- Final comparison: `2D6_roll >= [BP-0x30]` → hit

---

### 14. COMBAT PHASE MAPPING TO TABLETOP BATTLE TECH

The game implements a simplified version of the tabletop BattleTech rules:

| Tabletop Phase | Game Implementation | Status |
|----------------|-------------------|--------|
| **Initiative** | Slot-based turn order (sequential 0..23) rather than dice-off. Player units in slots 0-3, enemy in 4-11 | Confirmed |
| **Movement** | Direction calculation via `unknown_19EF_0971_1A861`. Walk/Jump MP from mech data at offset 0x30/0x31 | Confirmed |
| **Weapon Attack** | Per-body-part weapon mounts checked via 9-location loop (0x564 stride 0x40) | Confirmed |
| **To-Hit Roll** | 2D6 roll via `ghidra_guess_0000_30DD_030DD` (rejection-sampled D6 1-6). TN = base (action_code*2+4) + skill (popcount of story state bits) + terrain (tile property at 0x32C6 + 1) + heat (thresholds at 8/13/17/24 → +1 each) + story state (+2 if citadel attacked). Roll < TN = miss | CONFIRMED |
| **Hit Location** | 9 body part pairs processed in `unknown_19EF_1886_1B776` (RA, RL, RT, HD, CT, LA, LL, LT, CTR). RNG & 0x8 selects 1 of 2 hit location variants | Confirmed |
| **Damage** | Full pipeline: weapon instance load → per-missile damage → cluster hits table (2D6×7 + col → segment 0x566C:0x2E5E) → total = hits × per-missile → armor subtraction at `C724 + unit_id*125 + offset` → overflow to next slot | Fully mapped (§7) |
| **Critical Hits** | Grid adjacency `unknown_19EF_11BB_1B0AB` handles slot→slot transfer | Confirmed |
| **Heat** | Heat thresholds at `ES:[BX+0x6E]` (player) or `0x66` (enemy). 8/13/17/24 → cumulative +1 TN penalty each. Heat pool at `ES:[BX+0x92]` (player) / `0x8A` (enemy) accumulates weapon heat from instance byte `0x2EE5 & 0x0F` | Confirmed |
| **Ammo** | Weapon instance byte `ES:[SI+0x2EE4]` (stride 0x11): bit 7 = infinite ammo, low 7 bits = initial count. Read-only during combat (CMP check only). **Actual decrement** on mech struct: `0x2A02:C74B + unit_id*125 + stage_counter` for players, `0x2A02:C5D4 + unit_id*0x11` burst cap for enemies. 0xFF = empty bin sentinel | Confirmed |
| **AI Targeting** | Data-driven: story state properties 0x33-0x55 encode target preferences. `ghidra_guess_1000_0AB2_10AB2` selects n-th valid target matching stage counter | Confirmed |
| **Destruction** | Unit status at 0x406A set to 0 when destroyed | Confirmed |

#### 7.14 Mech Destruction / Kill Chain

The game uses a multi-layered destruction system spanning critical hit propagation, ammo explosion, overkill marking, fog clear, and unit removal. Three key functions implement this pipeline:

---

##### 7.14.1 Critical/Structure Damage Handler — `ghidra_guess_1000_0BBB_10BBB`

**File:** `GeneratedCode10.cs:4185-4584`
**Segment:Offset:** 1000:0BBB (linear 0x10BBB)

Parameters: `[BP+0x6]` = unit_id, `[BP+0x8]` = location_offset (0x11-0x23 range, structure area of the 125-byte mech record)

```
[BP-0x4] = 0           ; already_destroyed flag
[BP-0xA] = 1           ; ammo explosion multiplier (starts at 1)

BX = unit_id * 0x7D + location_offset
ES = [0x558E]          ; story data segment

if ES:[BX + 0xC724] == 0:       ; location already at 0?
    [BP-0x4] = 1                ; mark already destroyed

roll = ghidra_guess_0000_30DD_030DD()   ; 2D6 roll (2-12)

if roll >= 8:
    [BP-0xA] = (roll - 8) / 2 + 1       ; multiplier: 8→1, 10→2, 12→3

; Ammo explosion check
if [0x2E38] != 0 AND [BP-0xA] > 0:
    unknown_17C6_0281_17EE1(4)          ; explosion visual effect
    display_string(seg=DS, offset=0x315E) ; "ammo explosion" text
    ES = [0x55B4]
    ES:[0x4586] = 1                     ; mark ammo explosion happened

; --- Overkill propagation (already-destroyed location) ---
if [BP-0x4] != 0:
    [BP-0xA] = 0                        ; no explosion multiplier
    iter_start = [BX + 0x316E]          ; read from location→iteration table
    iter_count = [BX + 0x3176]          ; number of slots to process
    for i in 0..iter_count:
        addr = unit_id * 0x7D + iter_start + i + 0xC724
        ES = 0x2A02                     ; combat segment
        if ES:[BX] != 0:
            ES:[BX] |= 0x80             ; set bit 7 = destroyed marker

    ; Special nibble clears for CT/Head destruction:
    BX = unit_id * 0x7D
    ES = [0x558E]
    switch location_offset:
        0x1C (CT):  ES:[BX + 0xC748] &= 0x0F   ; clear high nibble (actuator 0)
        0x1E (Head): ES:[BX + 0xC748] &= 0xF0  ; clear low nibble (actuator 0)
        0x21:       ES:[BX + 0xC749] &= 0x0F   ; clear high nibble (actuator 1)
        0x23:       ES:[BX + 0xC749] &= 0xF0   ; clear low nibble (actuator 1)

; Post-handling
if [BP-0xA] == 0:
    EXIT                                    ; no explosion, done
else:
    normalized = [BP+0x8] - 0x1C
    if normalized <= 7:
        jump_table CS:[BX + 0x15E2]         ; location-specific follow-up
```

**Key details:**
- The `[0x2E38]` flag gates ammo explosions — when non-zero and a 2D6 roll ≥ 8 occurs, the ammo explosion visual+text fires and `ES:[0x4586]` is set to 1.
- The overkill path (`[BP-0x4] != 0`) handles a location already at 0 HP receiving additional damage. It marks every slot in the range `iter_start..iter_start+iter_count` with bit 7 (0x80 = destroyed marker) in the combat segment at `0x2A02`.
- `0xC748` and `0xC749` are at offsets `0x24` and `0x25` from the per-unit data base within the story slot — these correspond to the `CurrentActuators[4]` field. The nibble clears ensure that when CT or Head structure is destroyed, the corresponding actuator data is zeroed.
- Location offsets 0x1C (CT) and 0x1E (Head) correspond to the first two bytes of the 8-byte internal structure array within the 125-byte mech record at offset 0xC724.

---

##### 7.14.2 Overkill/Destruction Flow (Caller in GeneratedCode13.cs)

**File:** `GeneratedCode13.cs:5140-5390`

This is the main combat loop's damage application path. After armor is depleted at offsets 0x11-0x18 and damage overflows to structure offsets 0x1C-0x23:

```
; --- First critical handler call ---
if [BP-0x60] in range 0x1C..0x23:
    ghidra_guess_1000_0BBB_10BBB(loc_offset=[BP-0x60], unit_id=[BP-0xC])

; --- Special story state property handling ---
if [BP-0x60] == 0x1F OR [BP-0x60] == 0x20:   ; story state props
    BX = unit_id * 0x7D + [BP-0x60]
    ES = [0x5648]
    if ES:[BX + 0xC724] == 0:                  ; property byte just zeroed?
        ghidra_guess_0000_F565_0F565([BP-0x28])  ; special handler
        [BP-0x3A] = 1
        ES = [0x564C]
        ES:[0x4586] = 0                         ; clear ammo explosion flag
        if [BP-0x28] == 0 AND [BP+0x6] != 0:   ; target is slot 0 AND frame OK
            ghidra_guess_0000_EAEE_0EAEE()      ;  ← CLEAR WHOLE FOG GRID

; --- Second pass: zero the byte and check again ---
[BP-0x7C] -= [BP-0x52]                          ; subtract damage accumulator
BX = unit_id * 0x7D + [BP-0x60]
ES = [0x5648]
ES:[BX + 0xC724] = 0                            ; explicitly zero the structure byte

if [BP-0x52] > 0 AND ([BP-0x60] == 0x1C OR [BP-0x60] == 0x21):
    ES = [0x5676]
    ES:[0x3986] = 1                             ; CT destroyed flag

; --- Second critical handler call (for overkill) ---
if [BP-0x60] in range 0x1C..0x23:
    ghidra_guess_1000_0BBB_10BBB(loc_offset=[BP-0x60], unit_id=[BP-0xC])

; --- Slot advance for next body part ---
AX = ghidra_guess_1000_0B32_10B32(loc_offset=[BP-0x60])
[BP-0x60] = AX                                  ; advance to next location

if ES:[0xE484] != 0:                            ; story property 0x20 completed?
    ghidra_guess_0000_F565_0F565([BP-0x28])     ; trigger follow-up
```

**Destruction trigger conditions:**
1. A structure location in range 0x1C-0x23 takes damage → first `0BBB` call
2. If location is 0x1F or 0x20 (story state properties), the byte being zeroed triggers special handling:
   - `ghidra_guess_0000_F565_0F565` is called with the target combat slot
   - `ES:[0x4586]` is cleared (reset ammo explosion flag)
   - **Fog grid is fully cleared** when target is slot 0 (player's primary target) and frame condition is met
3. The byte is explicitly zeroed in the story data segment
4. If CT (0x1C or 0x21): global CT destroyed flag at `ES:[0x3986]` is set
5. Second `0BBB` call marks all overkill targets
6. Slot advance function moves to next body part
7. If `ES:[0xE484] != 0` (story property 0x20 multi-step complete): follow-up trigger

---

##### 7.14.3 Fog Grid Clear on Kill — `ghidra_guess_0000_EAEE_0EAEE`

**File:** `GeneratedCode9.cs:3444-3534`
**Segment:Offset:** 0000:EAEE (linear 0xEAEE)

Parameters: none (self-contained)

```
; Stack frame setup
unknown_19EF_2FDC_1CECC(4)     ; stack check

; Double loop: clear all 24×24 = 576 fog cells
for row in 0..0x17 (0 to 23):
    for col in 0..0x17 (0 to 23):
        ES = [0x5542]                     ; combat fog segment selector
        ES:[row * 0x18 + col + 0x40B4] = 0   ; set cell to "clear"
```

**Key details:**
- This clears **both** fog grids at once (Grid A and Grid B both reside within the same 24×24 region, or the function covers the entire fog segment region)
- Called **only** when the destruction logic detects a kill on combat slot 0 in specific conditions (frame count check)
- After this call, all previously fogged units become visible on the battlefield

---

##### 7.14.4 Unit Kill Handler — `ghidra_guess_0000_EB34_0EB34`

**File:** `GeneratedCode9.cs:3536-4243+`
**Segment:Offset:** 0000:EB34 (linear 0xEB34)

Parameters: `[BP+0x6]` = unit_id

Called from `GeneratedCode12.cs:727` in the combat phase dispatch when specific unit type conditions are met:

```
; Phase 1: Store AI target preferences to local array
for offset in 0x33..0x56 (12 bytes = AI target pref table):
    val = ES:[BX + 0xC724]              ; from story data
    val &= 0x7F                         ; strip destroyed bit
    if val in range 0x10..0x20:         ; valid target slot?
        local_array[i++] = val

; Phase 2: Story state checks
if ES:[BX + 0xC79B] == 1:               ; b0057 = 1 (citadel attacked)
    display_string(0x292D)               ; "destroyed" text variant
    unknown_18AD_0259_18D29()           ; sound/effect
    unknown_17C6_0388_17FE8()           ; state cleanup

if ES:[BX + 0xC79B] == 2:               ; b0057 = 2 (post-attack)
    display_string(0x2964)               ; different text variant
    unknown_18AD_0259_18D29()
    unknown_17C6_0388_17FE8()
    goto exit

; Phase 3: Death processing
display_string(0x29A3)                   ; death message
ghidra_guess_1000_3224_13224(unit_id, 1) ; clear unit state
fn(local_array) → computes X/Y params   ; position for death animation
ES:[0x56] = computed_value               ; death animation param 1
ES:[0x52] = other_value                  ; death animation param 2
unknown_17C6_0281_17EE1(5)              ; explosion visual 2
unknown_17C6_0004_17C64(0)              ; reset
unknown_17C6_0388_17FE8()               ; cleanup
unknown_0170_28A2_03FA2()               ; render update
display_string(0x29BE)                   ; death text

; Phase 4: Per-combat-slot cleanup
for slot in 0..0xB (12 combat slots):
    ES = [0x5552]
    ES:[0x37FE] = 1 or 8 or 2           ; death animation type
    weapon_idx = local_array[0] & 0x7F
    display_weapon_name(weapon_idx)      ; "destroyed by X"
    ES:[0x3748] = 0xB                    ; animation timer

    if bit 7 of local_array[0] set:
        display_string(0x29D9)           ; "Destroyed!" text
        ES = [0x554A]
        ES:[slot + 0x3800] = 0xFF        ; mark slot dead in combat
    else:
        ; Ammo/inventory cleanup path...
```

**Call site** (`GeneratedCode12.cs:700-727`):
Called when `[BP-0xA] >= 4` (combat unit type threshold) AND one of:
- `[BP-0xC] == 2` (enemy mech type)
- `[BP-0xC] == 6` (player unit type)
- `[BP-0xA] >= 4 AND [BP-0xC] == 4` (enemy infantry type)

**Key details:**
- Extracts AI target preference table (offsets 0x33-0x56) into a local buffer — this identifies which enemy units the killed unit was targeting
- Checks story state `b0057` (at `0xC79B`) for citadel-attack phase to select death text variant
- Computes animation parameters from the target preference array — used for death animation positioning
- Sets per-combat-slot destroyed markers at `ES:[0x3800 + slot]` to `0xFF` for the killed unit
- The `ES:[0x37FE]` value (1/8/2) controls which death animation type plays
- `w4FBA` check influences animation type — world map (0) forces type 2 animation

---

##### 7.14.5 Complete Destruction Sequence Summary

```
Phase 1: Critical Handler
  └→ ghidra_guess_1000_0BBB_10BBB(unit_id, loc_offset)
      ├─ Check if structure byte already 0
      ├─ Roll 2D6 for ammo explosion check (≥8 → mult 1-3)
      ├─ Ammo explosion visual + text (if enabled)
      ├─ Overkill: mark combat segment slots with bit 7
      └─ CT/Head: clear actuator nibbles at 0xC748/0xC749

Phase 2: Post-damage processing
  ├─ If story state (0x1F/0x20) zeroed: call F565 handler
  ├─ Clear ES:[0x4586] (ammo explosion flag)
  ├─ If slot 0 killed: ghidra_guess_0000_EAEE_0EAEE()
  │     └─ Clear 24×24 fog grid to 0
  ├─ Zero the structure byte at story data segment
  ├─ If CT (0x1C/0x21): set ES:[0x3986] = 1
  └─ Second call to 0BBB for overkill marking

Phase 3: Slot advance
  └─ ghidra_guess_1000_0B32_10B32 → next body part

Phase 4: Unit kill handler (conditionally)
  └─ ghidra_guess_0000_EB34_0EB34(unit_id)
      ├─ Snapshot AI target preferences
      ├─ Check story state for death text variant
      ├─ Display death message + animation
      ├─ Set ES:[0x37FE] death animation type (1/2/8)
      ├─ Display "destroyed by [weapon]" text
      └─ Mark unit slot as 0xFF (dead) in combat segment
```

#### 7.15 Facing / Firing Arcs — NOT IMPLEMENTED in Combat

**File:** All combat source files (GeneratedCode10-19.cs)
**Status:** Confirmed absent — the game has **no facing direction or firing arc enforcement**

The game's combat system does **not** implement the tabletop BattleTech facing/arc rules at all. Here is the exhaustive evidence:

**1. The 9 body-part loop (`unknown_19EF_1886_1B776`) is NOT a weapon fire loop**

The function at `19EF:1886` (linear 0x1B776) iterates 9 SI/DI source-destination pairs, but each iteration calls `unknown_19EF_11BB_1B0AB` which is a **grid adjacency / critical transfer function**:

| Iteration | SI | DI | Label | What happens |
|-----------|-----|-----|-------|-------------|
| 1 | 0x564 | 0x324 | RA | 6×6 grid, reads `[SI]`, compares with `[SI±1]`, `[SI±8]`, writes bitmask to `[DI]` |
| 2 | 0x5A4 | 0x364 | RL | Same cellular-automaton adjacency check |
| 3 | 0x5E4 | 0x3A4 | RT | Same |
| 4 | 0x624 | 0x3E4 | HD | Same |
| 5 | 0x664 | 0x424 | CT | Same |
| 6 | 0x6A4 | 0x464 | LA | Same |
| 7 | 0x6E4 | 0x4A4 | LL | Same |
| 8 | 0x724 | 0x4E4 | LT | Same |
| 9 | 0x764 | 0x524 | CTR | Same |

Each call processes a **6×6 grid with stride 8**, performing 4-direction neighbor comparison, OR-ing bits (0x8/0x4/0x2/0x1) into `[DI]`. This is a cellular automaton that propagates critical hit damage between adjacent body-part slots. No weapon damage, to-hit rolls, or range checks exist in this function.

**2. No facing-direction variable exists per combat unit**

The only direction variable in the game is for **NPC world-map sprite rendering** ([`world-map.md`](world-map.md)) — high nibble of `ES:[0xD398]` = BLD index, low nibble = facing direction (0-7). This is never read during combat.

The unit status field at `0x406A` is purely a **dead/alive flag** (0 = inactive, non-zero = active). No direction bits are stored or checked anywhere in the combat code.

The death animation type at `ES:[0x37FE]` (values 1, 2, 8, 0xE, 0xF) controls **explosion visual type**, not facing direction.

**3. Targeting function has zero facing checks**

`ghidra_guess_1000_0934_10934` (the targeting/state check function) only checks:
- Unit coordinates (`ES:[SI+0x4004]`, `ES:[SI+0x4036]`)
- Weapon range from instance table (`[BX+0x2EE7]`, `[SI+0x2EE6]`)
- Ammo state (`[SI+0x2EE4]` bit 7 = infinite)

**No call to any angle/direction function; no comparison of unit position vs target position for arc compliance.**

**4. The movement direction function is used only for pathfinding**

`unknown_19EF_0971_1A861` computes 8-direction vectors between source and destination. It is called in:
- `ghidra_guess_1000_160E_1160E` (LoS ray-cast) — for stepping tiles along the path
- Combat movement phase — for determining path, not for arc enforcement

The direction returned is used for tile stepping, NOT for checking whether a target is within a firing arc.

**5. Weapon iteration is per-slot, not per-arc**

Weapon instance table at `0x2EE4` has stride 0x11 (17 bytes per weapon). The targeting function reads exactly ONE weapon slot per invocation (the slot matching the target unit index). There is no iteration over all weapon mounts for a unit.

**6. AI target selection ignores facing**

`ghidra_guess_1000_0AB2_10AB2` selects targets purely from a story-state preference table (offsets 0x33-0x55, values 0x10-0x20 = target_slot+1). No angular or positional filtering.

**Conclusion:** The game's combat is a simplified 8-direction grid system where:
- Any weapon can fire at any target within range and LoS
- The 9 body-part pairs are for critical hit grid propagation, NOT weapon mount processing
- No torso twist / facing arc / rear arc rules exist
- Movement direction only affects pathfinding, not weapon availability

---

### 15. KNOWN GAPS (STILL UNVERIFIED)

1. ~~**Damage grouping:** How cluster weapons (LRM/SRM) distribute their multiple shots~~ **RESOLVED**: LRM/SRM fire as single aggregated salvo. 2D6 + cluster hits table at `DS:[0x566C]→0x2E5E` determines number of hits. Total damage = per_missile_damage (at 0x2EE3) × cluster_result, applied to ONE hit location. No per-missile distribution. See §6.6.
2. ~~**Ammo decrement instruction:** Where the ammo count is decremented~~ **RESOLVED**: Weapon instance table at `0x5652:0x2EE4` is read-only. Ammo decrement on the story slot mech struct (segment `0x3092`, stride 125, ammo at offset `+0x27`): players (combat units 0-3, story slots 0-3) at `0x2A02:C74B + unit_id*125 + stage_counter`, enemy mechs (combat units 12-15, story slots 4-7) at `0x2A02:C363 + unit_id*125 + stage_counter`. Enemies (units 4-11) use a burst counter at `0x2A02:C5D4 + unit_id*0x11` capped at 4. See §6.5 Ammo Check.
3. ~~**Heat dissipation:** The heat sink logic between combat turns — how unit heat pool at `0x92`/`0x8A` decreases between rounds or after combat~~ **RESOLVED**: `ghidra_guess_1000_0673_10673` copies heat pool to penalty accumulator (0x6E) and clears pool to zero at end of each round. No gradual dissipation
4. ~~**Facing / firing arcs:** Whether torso twist restricts which weapons can fire~~ **RESOLVED**: **Not implemented.** The 9 body-part loop `unknown_19EF_1886_1B776` is a critical hit grid-adjacency propagator (cellular automaton on 6×6 grid with stride 8), NOT a weapon fire loop. No facing-direction variable exists for combat units. The targeting function `ghidra_guess_1000_0934_10934` checks only range, LoS, and ammo — no arc check. AI target selection is purely data-driven from story state preference table. Movement direction is only used for pathfinding tile-stepping. See §7.15.
5. ~~**Complete damage pipeline:** How to-hit, cluster hits, armor subtraction, damage overflow, and VGA effects chain together~~ **RESOLVED**: Full pipeline documented in §7. The to-hit check (2D6 vs TN at 0x4FC2), cluster table lookup (0x4F9F-0x4FC2), armor read (0x50F5-0x510E), damage subtraction (0x5133-0x5147), overkill/overflow (0x51C4-0x5250), slot advance via jump table (0x0B32), and VGA impact effect (0x18EF) are all mapped. Key discovery: damage overflow loops back to apply excess to the next body part via `ghidra_guess_1000_0B32_10B32`.
5. **Prone/knockdown:** Whether mechs can fall and how they recover
6. **Fog of war (RESOLVED):** Combat fog is at `DS:[0x55D8]→0x40B4`/`0x41D4` (twin 12×24 grids, init 0x02=fogged, cleared by LoS to 0x00). Blocks target acquisition and tile rendering. World map visibility is a separate bit-packed 128×128 grid (2048 bytes in save files). The `2A02:C724` reference is NOT fog — it's a per-story-slot data array (stride 0x7D) before `aC744[]`.
7. ~~**AI stage counter (`[BP-0x42]`):** How this increments through combat sub-phases~~ **RESOLVED**: Counter (0-11) selects n-th valid target from preference table at story state offsets 0x33-0x55. Stage 0xB = special end-of-round processing. 0xC = exit marker.

---

### 16. RNG IMPLEMENTATION

The game uses a single 3-byte Linear Feedback Shift Register (LFSR) RNG with state at `segment:0x4FC0-4FC2`. Two code paths access it via different segments: `384B:4FC0` (19EF combat code) and `3EDB:4FC0` (207F world/BLD code), which may be aliased or mapped to the same physical memory.

**State:** 3 bytes at `[segment]:4FC0` (S0), `4FC1` (S1), `4FC2` (S2)

**Algorithm** (segment 19EF, linear 0x1AAB0, `unknown_19EF_0BC0_1AAB0`):

```
AL = S[0] >> 2                              // extract bits [7:2] from state byte 0
S[2] = RCL(S[2], 1)                         // rotate S2 left 1 through carry (carry = (S[0]>>2) & 2)
S[1] = RCL(S[1], 1)                         // rotate S1 left 1 through carry (carry = old S2 bit 7)
CMC                                         // complement carry
AL = SBB(AL, S[0])                          // AL = (S[0]>>2) - S[0] - borrow (from CMC)
AL >>= 1                                     // shift AL right 1
S[0] = RCR(S[0], 1)                         // rotate S0 right 1 through carry (carry = AL bit 0)
return S[0] XOR S[1]                        // output: XOR of state bytes 0 and 1
```

The segment 207F implementation (`fn207F_0BC0`) performs the same algorithm with the same 3-byte state at the same offset.

**2D6 Roll** (`ghidra_guess_0000_30F3_030F3` at segment 0000:30F3):
```
loop:
    RNG()                          → byte in AL
    AL &= 0x7                      → mask to 0-7
    if AL > 5: goto loop           → rejection sampling
    AL++                           → 1-6
    return AL
```
Called twice and summed for 2D6 range 2-12 (function at `ghidra_guess_0000_30DD_030DD`, segment 0000:30DD).


---

## 19. AMMO LIFECYCLE & ITEM-TO-UNIT BRIDGE

### Corrected Ammo Offsets

The mech struct at `C724` (0x7D stride per slot) stores ammo at:

| Field | Struct Offset | Code Offset | Width | Description |
|-------|--------------|-------------|-------|-------------|
| CurrentAmmo | +0x27 | `C74B` | 10 bytes | Per-weapon-slot ammo count (one per weapon, 0xFF = energy/infinite) |
| MaxAmmo | +0x6B | `C78F` | 10 bytes | Maximum capacity from mech template |

**Correction vs earlier documentation**: Struct table had +0x29/+0x6F; actual code confirms +0x27/+0x6B.

### Two subsystems: equipment vs ammo

The game tracks items and ammo in **separate** subsystems:

- **Equipment / inventory** — `aD374[]` (quantity) / `aD376[]` (data), shop cases 0x06/0x07/0x08, and
  per-unit equip slots `C61D`/`C61E` (500 cr). This is **economy/inventory**, canonical in
  [`story/story-system.md`](story/story-system.md) §17.11 — *not* covered here.
- **Per-mech ammo bins** — below.

### Per-Mech Ammo Bins (`C724+0x27..0x32`, 10 bytes per slot)
- Tracks current ammo counts for up to 10 weapon systems per mech
- Initialized from mech templates
- Decremented by combat code
- Reloaded via fn11B8_194A (garage/repair screen)
- **0xFF sentinel** = energy weapon / infinite ammo (skip decrement in combat)

### Ammo Initialization Flow

```
EXE mech templates (125-byte structs embedded in binary)
  │
  ├─ fn0DAB_0D3D (0DAB:0D3D) — Random encounter enemy mechs
  │   Source: 3 far pointers at [0x5436]:0x2DF8 (LOCUST/WASP/STINGER)
  │   Target: C724 + slot*0x7D for slots 4-7 (enemy story slots)
  │   Selection: RNG % 3
  │
  ├─ fn11B8_104E (11B8:104E) — COMMANDO (case 0x1E dispatch)
  │   Source: [0x54D6]:0x467 (segment ptr + 1127)
  │   Target: C724 + first_free_slot*0x7D
  │
  ├─ fn1CD3_0004 case 0x01 (ENTER_BUILDING) — Big struct init
  │   Copies 0x3959 bytes from template segment to C724
  │   Sets up multiple story slots at once
  │
  ├─ fn1CD3_0004 case 0x23 (NEW_GAME_INIT) — Full game init
  │   Calls fn11B8_137F → fn11B8_1441 → fn0FDC_0629 → fn11B8_104E
  │   Sets up Chameleon via template copy
  │
  └─ 0x22 memset at 0000:747C-74BD — Default fill
      Writes 0x22 (34) to all struct bytes 0..0x54 for slots 0-3
      Overwritten by template copies above
```

### Ammo Decrement in Combat

Combat code at segment `0x2A02`:

```
Player mechs:  DEC byte ptr [0x2A02:C74B + unit*0x7D + stage_counter]
Enemy mechs:   DEC byte ptr [0x2A02:C363 + unit*0x7D + stage_counter]
Enemy infantry: INC word ptr [0x2A02:C5D4 + unit*0x11] (burst counter, capped at 4)
```

- `stage_counter` = combat phase counter `[BP-0x42]` (0..0xB)
  - Stages 0-1 → struct offsets +0x27/+0x28 (actuator bytes, not ammo — **ammo starts at +0x29**)
  - Stages 2-0xB → struct offsets +0x29..+0x32 (ammo bytes 0-9)
- `0xFF` sentinel check: if byte == 0xFF, skip decrement (energy/infinite ammo)
- Weapon type check: weapon instance byte at `[SI+0x2EE4]` bit 7 = infinite flag; low 7 bits = initial shots

### Ammo Reload (Garage/Tech Screen)

Function at `fn11B8_194A` (`UNBTECH_11B8.c:1720-1835`):

```
For each weapon slot (0-9) where weapon type != invalid:
  1. Read current ammo:  es->C74B[slot + unit*0x7D]
  2. Read max ammo:      es->C78F[slot + unit*0x7D]
  3. If current == max:  skip (already full)
  4. Calculate capacity: max - current
  5. Get unit price:     table_0x2046[weapon_type] (or 2 for type 0x18)
  6. Prompt quantity via fn1543_0CDE()
  7. For each unit reloaded:
     a. Check tD370 >= unit_price
     b. INC byte at C74B[slot + unit*0x7D]
     c. tD370 -= unit_price
     d. fn1631_1FDF() redraw credits display
```

**Key observations:**
- Reload directly modifies per-unit ammo bins — no intermediate inventory
- Reload deducts directly from `tD370` credits — **never touches aD374**
- Price comes from weapon type lookup table, not from shop inventory

### Resolution: No Bridge Exists

**The `aD374` global inventory and per-unit mech ammo bins are entirely independent systems.**

| Operation | Affects aD374 | Affects C74B ammo | Affects tD370 |
|-----------|:---:|:---:|:---:|
| Shop: buy item (case 0x07) | +qty | — | −qty |
| Shop: sell item (case 0x08) | −qty | — | +qty |
| Equip slot 5/6 (case 0x0F/0x15) | — | — | −500 |
| Mech template init | — | writes initial | — |
| Combat firing | — | −1 per shot | — |
| Garage ammo reload | — | +1 per unit | −unit_price |

This means:
1. **Ammo** is tracked solely per-mech, initialized from templates, and reloaded by paying credits at the garage
2. **Equipment items** (weapons, armor, inventory objects) are tracked globally in aD374
3. **Equip slots** (C61D/C61E) are purchased upgrades (500 cr each) that enable unit capabilities

The original question ("how does aD374 connect to mech ammo bins?") was based on an incorrect assumption. There is no connection — ammo is managed entirely through the mech struct + credits, bypassing aD374 entirely.

---

## 20. ENCOUNTER SETUP & ENEMY GENERATION

> Moved from `world-map.md` §17.3–§17.6, §17.10 (2026-09-28): this is **combat setup**, not world-map
> behaviour. The world-map side — the encounter **trigger** (`RNG & bD330 == 0` plus the `bD310`/`bD346`
> mode guards) — stays in [`world-map.md`](world-map.md) §17.1–§17.2, §17.5.

### 20.1 Population (`fn0DAB_0D3D`, segment 0DAB:0D3D)

**File:** `UNBTECH.reko/UNBTECH_0DAB.c:972-1105`

When `fn183B_000A` is called, it invokes `fn0DAB_0D3D` to populate the enemy encounter group:

1. **Random position**: Units placed at (±10-17 from 26, ±10-17 from 12) on the 32×24 world map grid, independent of terrain type. Generated via `RNG & 0x07 + 0x0A`, with 50% sign negation.
2. **Clear all slots**: Slots 0-23 cleared (status=0, coords=0xFFFF) first
3. **Enemy infantry slots 8-15** (50% chance per slot):
   - Random equipment from table via 7-round loop: each round `RNG & 0x03` indexes 1 of 4 weapon types at `DS:[0x5434] + 0x2CF4` (weapon instance data, stride 0x11)
   - `bC61F[1][slot]` set to 0x08 (some type/weapon class)
   - `C618[slot][0..6]` each filled with `RNG & 0x03` (random item types 0-3)
   - HP/weapon state initialized via `fn0800_19DD` calls, combining 2D6 results
4. **Enemy mech slots 4-7** (50% chance per slot):
   - Guard check at `0xC530[slot * 0x7D] != ~0x00` — only populates if a valid template exists
   - Template selection: `RNG() % 3` indexes a table of **3 fixed word entries** (near offsets) at segment `[DS:0x5436]:0x2DF8`
   - Full 125-byte mech data copy from template to story slot
   - Post-copy: `D566[slot]` = 0x00 if template 0 selected, 0x92 if template 1 or 2 (∼67% chance of 0x92)
5. **Secondary weapon/position setup** (slots 8-15, if populated): terrain validation loop places each infantry unit on valid tiles, skipping if terrain property at `+0x7AD[tile] >= t0150` (blocked)

**IMPORTANT: No dynamic balancing** — There is NO code that reads the player's lance composition to calibrate enemy spawns. The 3 mech templates at `[DS:0x5436]:0x2DF8` are **read-only** (never written to after init). The template pointers are allocated at runtime (segment beyond EXE load image) and populated during game init from the static mech definitions in segment 1A00.

**Known mech definitions** (125-byte structs, stride 0x7D, mech ID at offset 0x7B):

| Mech ID | Name | Tonnage | Walk | Jump | Notes |
|---------|------|---------|------|------|-------|
| 0x00 | LOCUST | 20t | 8 | 0 | Fast scout |
| 0x01 | WASP | 20t | 6 | 6 | Jump-capable |
| 0x02 | STINGER | 20t | 6 | 6 | Jump-capable |
| 0x03 | COMMANDO | 25t | 6 | 0 | SRM-armed |
| 0x06 | URBANMECH | 30t | 2 | 2 | Slow heavy armor |
| 0x09 | JENNER | 35t | 7 | 5 | Story-only, Kuritan |
| 0xC8 | CHAMELEON | 50t | 6 | 6 | Player starting mech, story-only |

**Melee-only enemies:** The Spectator (decoy/non-combatant, mech ID 0x00 same as Locust) exists in the codebase but was not found in the EXE binary data.

**Known weapons** (17-byte stride, table at `DS:+0x2EE4`): 33 weapons total, range includes: Cludgel, Knife, Sword, Vibroblade, Shortbow, Longbow, Crossbow, Pistol, Rifle, MachineGun, SRMissile, Inferno, LaserPistol, LaserRifle, Flamer, Small/Medium/Large Laser, PPC, AC/2/5/10/20, LRM5/10/15/20, SRM2/4/6, Kick.

**Key insight**: The encounter system generates up to 4 random mechs from a **fixed pool of 3 light mech templates** (likely Locust, Wasp, Stinger — the 20t lights), plus up to 8 random infantry. Heavier units like the Jenner (35t), UrbanMech (30t), and Chameleon (50t) are **story-controlled only** and never appear in random walking encounters. The game has zero assault or heavy mechs — the 50t Chameleon is the maximum weight. The player's perception of "not encountering heavy mechs when piloting lights" is a consequence of the fixed light-mech template pool, not any dynamic balancing algorithm.

### 20.2 Positioning (`fn183B_28DB`, segment 183B:28DB)

After population, `fn183B_28DB` positions the encounter on the world map:

1. Reads cursor position (`A44B`/`A44D`) and location offsets (`t400C`/`t403E`)
2. Checks special encounter flag at `DS:55D4→bC620` — if `!= 0x08`, overrides position with unit 0's coordinates from `0x4004`/`0x4036`
3. Moves cursor to calculated position via `fn0800_17BB`
4. Scans extended pool (slots 12-23) for active units, records first found
5. Sets `t3770 = 0x1E` (30-step search range)
6. Iteratively adds `t458E`/`t4590` offsets toward target position, decrementing step counter until position match or 30 steps exhausted
7. Returns 1 (success) if a valid position was found, 0 otherwise
8. On success, `fn183B_000A` loads and displays the encounter BLD narrative text (index 13314)

**Key insight**: Enemies are placed relative to center (26, 12) regardless of terrain. The encounter system has no terrain-type modifiers for probability or composition. Story-progression gating happens through the bD330 probability mask changes (0x7F post-combat) and bD310/bD346 guards.

### 20.3 Initiation (`fn183B_000A`, segment `183B:000A`)

**File:** `UNBTECH.reko/UNBTECH_183B.c:7-303`

Called with `wArg04 = 0` when encounter triggers. Steps:

1. **Lines 104-117**: Saves current unit state into encounter save buffers
2. **Lines 118-153**: Initializes combat arrays:
   - Clears position data (`0x4004`/`0x4036` = -1 for all 24 slots)
   - Sets all unit slots to inactive/dead (`w406A = 0`)
   - Initializes visibility maps (24 rows × 24 columns for fog of war)
3. **Lines 154-166**: Initializes unit flags and counters (8 iterations for various flag arrays)
4. **Lines 167-224**: Positions units based on current `A44B`/`A44D` coordinates, applying offset via `fn0800_191B`/`fn0800_186F`
5. **Lines 230-251**: Calls `fn0DAB_0D3D` for unit population, sets `w37FE = 0x0F`, counts active units
6. **Lines 252-253**: Calls `fn183B_28DB` for encounter-specific enemy/environment setup
7. **Lines 254-303**: Loads and executes BLD script `0x33FC` for encounter narration, displays enemy count UI, and transitions into combat
8. **Line 804**: Sets `bD330 = 0x7F` to reduce re-encounter probability during/after combat

### 20.4 Encounter flow summary (combat branch)

```
ENCOUNTER CHECK (0800:192-201 every frame)  ← world-map trigger, see world-map.md §17.1
  └─ True → fn183B_000A
      ├─ Save current positions
      ├─ Initialize combat arrays (clear all units)
      ├─ Populate enemies via fn0DAB_0D3D + fn183B_28DB
      ├─ Execute BLD script 0x33FC for encounter narration
      ├─ Set bD330 = 0x7F (reduce re-encounter probability)
      └─ Transition to combat mode (w4FBC narrow panel; see engine/viewport.md)
```


---

## 21. WEAPON SYSTEM (all combat — mech *and* infantry)

> Consolidated reference for the weapon system — shareable. Sources: canonical
> [`../combat-system.md`](../combat-system.md) (§6.5 ammo, §6.6 cluster, §13/§20 weapon data) and the
> decompilation ([`../../reko/gencode/`](../../reko/gencode/)). Verified items are marked ✅; uncertain
> items ⚠️. Last pass: 2026-09-28 (roadmap B2).

### 1. Multi-shot weapons (SRM / LRM) — "SRM 6 and the rest" ✅

Multi-missile launchers fire as a **single aggregated salvo** — there is **no per-missile hit-location
rolling**. Verified in the decompilation against `1000:4F92`:

```
per_missile_damage = weapon_record[weapon].byte[+0x0B]     # LRM=1, SRM=2
cluster_col        = weapon_record[weapon].byte[+0x0C]     # 1=non-cluster; SRM2/4/6 → 2/3/5; LRM5/10/15/20 → 4/6/7/8
if bit7(ammo byte 0x2EE4) set → energy path (no cluster table)   # infinite ammo
if cluster_col <= 1          → single-shot path (no cluster table)

roll  = 2D6()                                  # 0000:30DD, calls the LFSR RNG
hits  = cluster_table[ roll*7 + cluster_col ]  # table via DS:[0x566C] + 0x2E5E, stride 7, rows 2..12
total_damage = per_missile_damage * hits       # applied to ONE hit location
```

- **Cluster hits table**: `DS:[0x566C] → 0x2E5E`, 7-byte stride per row (columns 0-6), 11 rows (2D6 = 2..12). The **column is per-weapon** (see `[+0x0C]` above).
- So an **SRM-6** rolls 2D6, looks up its column, gets the number of the 6 missiles that hit, and applies
  `2 × hits` damage to a **single** location — not six separate locations. Same for LRM-5/10/15/20.

### 2. Weapon **instance** struct (`DS:[0x5652] → 0x2EE4`, stride **0x11 / 17**) ✅

Runtime per-mounted-weapon state (read-only `0x2EE4` byte doubles as the cluster column above):

| Off | Abs | Meaning |
|-----|-----|---------|
| `+0x00` | `0x2EE4` | Ammo/type byte: **bit7 = infinite**, low7 = remaining shots; also the cluster-table column |
| `+0x01` | `0x2EE5` | Heat — **low nibble (`& 0x0F`)** added to the unit heat pool on fire (`1000:48E3`) |
| `+0x02` | `0x2EE6` | Skill class (low 5 bits; high 3 bits `>>5` as flags) |
| `+0x03` | `0x2EE7` | Range threshold byte |
| `+0x04` | `0x2EE8` | Weapon type id (used for comparisons) |

Ammo: energy weapons are `0x2EE4 == 0xFF` (infinite) and **skip the decrement**; per-mech ammo bins are
separate (see combat-system.md §19).

### 3. Weapon **definition** table (33 weapons, stride 17) — dumped from the binary

Located in `UNBTECH.exe` at file offset **`0x3D088`**, 33 records × 17 bytes, ending with `Kick`.
Names are 10 bytes ASCIIZ (`+0x00`). The trailing 7 bytes (offsets `+0x0A..+0x10`) are dumped verbatim
below; **field offsets are ⚠️ not fully verified** (see §4).

| # | Name | `+0A` | `+0B` | `+0C` | `+0D` | `+0E-0F` | `+10` |
|---|------|------|------|------|------|---------|------|
| 0 | Cudgel | 00 | 11 | 81 | 00 | 0221 | 00 |
| 1 | Knife | 00 | 10 | 81 | 00 | 0221 | 00 |
| 2 | Sword | 00 | 22 | 81 | 00 | 0221 | 00 |
| 3 | VibroBlade | 00 | 30 | 81 | 00 | 0221 | 00 |
| 4 | Shortbow | 00 | 11 | 81 | 00 | 0966 | 00 |
| 5 | Longbow | 00 | 13 | 81 | 00 | 0D87 | 00 |
| 6 | Crossbow | 00 | 23 | 81 | 00 | 0E88 | 00 |
| 7 | Pistol | 00 | 23 | 81 | 00 | 0965 | 01 |
| 8 | Rifle | 00 | 30 | 81 | 00 | 1FF0 | 02 |
| 9 | MachineGun | 00 | 30 | 84 | 00 | 0B88 | 02 |
| 10 | SR Missile | 00 | 02 | 01 | 00 | 28FF | 03 |
| 11 | Inferno | 00 | FF | 01 | 00 | 28FF | 03 |
| 12 | LaserPistl | 00 | 40 | 81 | 00 | 0D87 | 01 |
| 13 | LaserRifle | 00 | 42 | 81 | 00 | 2BF6 | 02 |
| 14 | Flamer | 00 | 20 | 81 | 00 | 0765 | 01 |
| 15 | SmallLaser | 00 | 03 | 01 | 01 | 0C43 | 03 |
| 16 | Med Laser | 00 | 05 | 01 | 03 | 1E87 | 03 |
| 17 | LargeLaser | 00 | 08 | 01 | 08 | 30CB | 03 |
| 18 | PPC | 00 | 0A | 01 | 3A | 39ED | 03 |
| 19 | AutoCann/2 | 00 | 02 | 01 | 41 | 4BF0 | 03 |
| 20 | AutoCann/5 | 00 | 05 | 01 | 31 | 39ED | 03 |
| 21 | AutoCann10 | 00 | 0A | 01 | 03 | 30CB | 03 |
| 22 | AutoCann20 | 00 | 14 | 01 | 07 | 1E87 | 03 |
| 23 | MachineGun | 00 | 02 | 01 | 00 | 0C43 | 03 |
| 24 | Flamer | 00 | 02 | 01 | 03 | 0C43 | 03 |
| 25 | LRMissile5 | 00 | 01 | 04 | 62 | 42EF | 03 |
| 26 | LRMissil10 | 00 | 01 | 06 | 64 | 42EF | 03 |
| 27 | LRMissil15 | 00 | 01 | 07 | 65 | 42EF | 03 |
| 28 | LRMissil20 | 00 | 01 | 08 | 66 | 42EF | 03 |
| 29 | SRMissile2 | 00 | 02 | 02 | 02 | 1E87 | 03 |
| 30 | SRMissile4 | 00 | 02 | 03 | 03 | 1E87 | 03 |
| 31 | SRMissile6 | 00 | 02 | 05 | 04 | 1E87 | 03 |
| 32 | Kick | 00 | 00 | 01 | 00 | 0221 | 04 |

### 4. Field-offset note (⚠️ — read this before trusting the old docs)

The *existing* `combat-system.md` §13 lists `Damage +0x0A, Shots +0x0B, Heat +0x0C, VFX +0x0D,
Range +0x0E, Skill +0x10`. **That looks shifted by one vs the binary dump above.** Evidence from the
dump (compare with tabletop stats):

- `+0x0B` matches **damage**: SmallLaser 3, Med 5, Large 8, PPC 0x0A=10, AC/20 0x14=20; LRM = 1 and
  SRM = 2 (per-missile) — exactly the cluster `0x2EE3` value the docs cite.
- `+0x0C` matches the **cluster column / volley**: 1 for single-shot; SRM2/4/6 → 2/3/5; LRM5/10/15/20 →
  4/6/7/8.
- `+0x10` matches the **skill class** (0 melee, 1 pistol, 2 rifle, 3 gunnery, 4 kick) — as documented.
- `+0x0D` is **ambiguous** (SmallLaser 1, Med 3, Large 8 look like heat, but PPC 0x3A=58 and AC/2
  0x41=65 look like sound/VFX ids) — **do not assume**.
- `+0x0E` range is a packed 16-bit value (not a plain distance); its packing is **undecoded**.

So: **treat the weapon-definition field offsets as provisional**; `+0x0B` = damage, `+0x0C` = cluster
column, `+0x10` = skill are the safe readings. A focused decode of `+0x0A`/`+0x0D`/`+0x0E` is still
open. Ping the project if you decode them — this is a known gap.

### 5. Cross-references

- Ammo model, heat generation, damage pipeline: [`../combat-system.md`](../combat-system.md) §6, §7, §19.
- Weapon combat data / templates: §13, §20.
- Cluster/hit-location tables: `[0x566C]:0x2E5E` (cluster), `[0x566A]:0x2E43` (hit location).

---

## 22. ENCOUNTER FLOW (runtime-observed)

> Observed live on 2026-09-28 while playing a **late-game save** (slot 5: party
> Jason/Rex/Russ). Complements [`../combat-system.md`](../combat-system.md) (the RE spec) with
> the actual on-screen flow and the commands needed to drive it. Combat state lives in the
> **game-state segment `0x2A0F`** (see `../UNVERIFIED_DISCOVERIES.md` §6).

### Trigger
A **random encounter** while **walking** on the map (the party's mechs are the red sprites you move).
No encounter in the starting/degraded state (state array unset); it fires normally with a **progressed
save** (e.g. load slot 5 → you are placed on the map with your party — *not* in combat — then walk
until `Attacking force: …` appears).

### Setup prompts (in the left panel)
1. `Attacking force: <N>.` / `Engage in combat?  Yes No`  (Yes highlighted)
   - **No** = avoid → back to the map.
2. `Do you want the computer to fight for you?  Yes No`  (No highlighted = manual)
3. `Combat messages:  None  Brief  Verbose`
4. `See combat graphics:  Yes No`

Observed attacking forces: `4 humans.`, `1 Mech and 6 humans.`

### Tactical combat
- **Left panel**: unit title `<Pilot>'s <MECH>` (e.g. `Jason's CHAMELEON`) over a command menu:
  `Walk / Run / Jump / Use Weapons / Kick / Computer / Scan Unit / Next Unit / Flee / Begin Fight`.
- **Right panel**: 12×24 tactical grid (grass/roads/buildings) with mech sprites; the active unit
  sits on a magenta tile highlight.
- **Begin Fight** executes the round: combat messages appear in the left panel, e.g.
  - `An enemy Mech uses a Med Laser on Jason's Mech. Missed!`
  - `An enemy Mech uses a MachineGun on Jason's Mech. Hit Center Torso.` (hit/damage lines are magenta)
- **Kick target selection** (physical attack): header `Choose the enemy to kick:`, `Target: <MECH>`,
  `Range: IN/OUT`; options `Target here / Next enemy / Cancel`.
- **Flee** (menu option): → `You have eluded your enemies! Press a key.` → returns to the world map.

### Combat data (verified live)
This file records the **observation**; the address spec is canonical in
[`../combat-system.md`](../combat-system.md) §13 and [`../formats/memory-map.md`](../formats/memory-map.md) §3.

Observed live in segment `0x2A0F`: unit arrays `0x4004` (X) / `0x4036` (Y) / `0x406A` (status), 24 slots;
fog grids `0x40B4` / `0x41D4` (12×24), fully fogged (`0x02`) at start.
`bt_read_combat_units` / `bt_read_combat_grids` return this.

### Driving it (playtest notes)
- The encounter fires while pressing movement keys (`w`/`x` reliably) on the world map.
- The setup prompts and the command menu respond to **Space** (confirm) + **Up/Down** (navigate).
- Menu highlight can be position-sensitive; re-sample the screen between steps.
---

## 23. INFANTRY / SOLDIER COMBAT (personal weapons & armour)

Infantry ("soldiers") are full combat units — see §1 (slots 4-11) and §20.1 (encounter population).
They use the **personal weapons** (weapon table entries 0-14: Cudgel, Knife, Sword, VibroBlade,
Shortbow, Longbow, Crossbow, Pistol, Rifle, MachineGun, SR Missile, Inferno, LaserPistol, LaserRifle,
Flamer) and **personal armour**, and are stored as **17-byte character records** (not 125-byte mechs).

### 23.1 Character record (17 bytes; see `formats/memory-map.md` §Infantry Character Format)

| Off | Field | Off | Field |
|-----|-------|-----|-------|
| `+0x00` | character id | `+0x09` | skill: Tech |
| `+0x01` | Body | `+0x0A` | skill: Medical |
| `+0x02` | Dexterity | **`+0x0B`** | **equipped weapon type** (index into the weapon table) |
| `+0x03` | Charisma | `+0x0C` | (unused) |
| `+0x04` | Bows & Blades | **`+0x0D`** | **armour type** |
| `+0x05` | Pistol | **`+0x0E`** | **current armour value** |
| `+0x06` | Rifle | **`+0x0F`** | **current health** |
| `+0x07` | Gunnery | `+0x10` | (unused) |
| `+0x08` | Piloting | | |

### 23.2 Burst fire — verified in the decompilation (`1000:476D`–`47B9`)

Each infantry **burst is capped at 4 shots** via a per-(unit, weapon) counter:

```
# DS:[0x5648] = combat-state segment
cur = ES:[unit + 0xD360]                 # weapon currently fired
if (cur == fired_weapon):
    ES:[unit + 0xD358]++                 # shot/burst counter
    counter = ES:[ (0xC5D4 + slot*0x11 + weapon) ]   # per-(slot,weapon) burst byte
    if (counter < 4) ...                 # CAP = 4
```

So infantry fire a **burst of up to 4** with the equipped weapon. Weapon damage/heat come from the
same weapon table (`+0x0B` damage, `+0x0C` cluster column); the personal armour/health are the record's
`+0x0E`/`+0x0F` fields.

### 23.2b Damage & armour resolution — verified in the decompilation (`1000:4DF0`–`4E8A`)

Infantry have **two damage-absorbing fields** (armour value, then health), applied **per shot** of the
burst. Record base `BX = 0xC614 + rec*0x11`:

```
dmg = incoming_damage
arm = ES:[BX + 0xC622]                 # +0x0E  armour value
if (arm != 0):
    if (arm < dmg/2):  dmg -= arm;  arm = 0                 # weak armour absorbs & shatters
    else:              dmg >>= 1;   arm -= dmg              # strong armour takes half the hit
hp  = ES:[BX + 0xC623]                 # +0x0F  health
if (hp > dmg): hp -= dmg  else: hp = 0                      # overflow/spill kills
```

- The whole block is inside a per-shot loop (`[BP-0x34]`), so a 4-round burst can strip armour and then
  health across shots; **health `== 0` → the soldier is dead** (`1000:4E8A`).
- `+0x0D` (`0xC621`) is the **armour type** (compared to `1` at `1000:3F7A`; the shop's personal-armour
  items — FlakVest/FlakSuit/Env Suit/Ablative — map to these types).
- So infantry survive roughly as `armour + health` HP, with a halving rule when armour is thick.

### 23.3a Infantry weapons used

The personal weapons (weapon-table entries 0-14, skill classes 0-2) — Cudgel, Knife, Sword, VibroBlade,
Shortbow, Longbow, Crossbow, Pistol, Rifle, MachineGun, SR Missile, Inferno, LaserPistol, LaserRifle,
Flamer — carry the weapon's `+0x0B` damage; the record's `+0x0B` picks which one is equipped.

### 23.3 Setup

- Encounter population creates up to **8 enemy infantry** (slots 8-15; 50% chance per slot) with a
  random personal weapon and `RNG & 0x04`-style item fill; HP/weapon state initialised via
  `fn0800_19DD` (2D6-based). See §20.1.
- Personal armour items (FlakVest, FlakSuit, Light/Hvy Environment Suit, Ablative) are inventory
  items purchased at the Armor shop (see `story/story-system.md` §17.11).

---

## 24. HEAT MANAGEMENT (mechs) — consolidated

> Heat is a **runtime combat resource**, not a build stat. All verified in the decompilation
> (roadmap B2). Code: `1000:48E3` (gen), `1000:07D2`–`0883` (dissipation), `1000:48FD` (to-hit),
> `1000:3EA9`/`3961` (effects).

### 24.1 Generation (on fire)
Weapon heat = `weapon_instance[weapon].byte[+0x01] (0x2EE5) & 0x0F`, added to the firing unit's pool:
**player pool = `+0x92`**, **enemy pool = `+0x8A`** (segment `DS:[0x5658]`). Energy/infinite-ammo
weapons still generate heat.

### 24.2 End-of-round dissipation (no gradual cooling)
Runs once per round (guarded). For each mech:

```
pool(0x92, seg 0x55A6)  ──►  penalty(0x6E, seg 0x5598)   # penalty += pool
pool = 0                                                  # pool cleared
if (counter(0xD576, seg 0x55A8) != 0): penalty += 6; counter--   # heat "surge" carry-over
if (<range condition>):                penalty -= 4              # cooling relief
penalty = min(penalty, 0x1E)                                  # CLAMP at 30
```

So heat **never** cools gradually; it accumulates into a **penalty** that is only clamped and
occasionally relieved.

### 24.3 Effects
- **To-hit penalty** (main effect): compare the penalty `0x6E` against thresholds **8 / 13 / 17 / 24**;
  **+1 TN per threshold met** (max +4). See §6.2.
- The penalty also feeds `penalty / 5` into combat state (`[0x5624]:0x4592`) and, at the **cap (30)**,
  a message path is taken (`0x3BCA`); separate **overheat text** paths exist (`0x3BF3`).
- No **shutdown**, no explicit **movement-MP** reduction were found — heat's proven effect is the
  to-hit penalty (+ the message/flag paths above).

### 24.4 Heat sinks — present but NOT modelled
Heat sinks exist as a mech field (`+0x27`/`+0x28`, `EngineHeatSinks`) and as a critical-slot item
(`$22` in the templates), **but the dissipation code does not read them** — the game does **not**
subtract heat-sink capacity. Treat heat sinks as flavour/crit-slot filler for combat maths.

### 24.5 Open
- The exact consumer of `[0x5624]:0x4592` (`penalty/5`) — likely an overheat flag / movement gating —
  is **not fully traced**. ⚠️
