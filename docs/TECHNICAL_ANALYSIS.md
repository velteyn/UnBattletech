# Technical Analysis of BattleTech: The Crescent Hawk's Inception

## Identified Destination Maps

- **MAP1.MTP**: Training Center (Start location).
- **MAP2.MTP**: Main City (Chameleon training, Arena).
- **MAP3.MTP**: Small outpost/village.
- **MAP4.MTP**: Large industrial complex / city.
- **MAP5.MTP**: Medium settlement.
- **MAP6.MTP**: Medium settlement.
- **MAP7.MTP**: Medium settlement.
- **MAP8.MTP**: Medium settlement.
- **MAP9.MTP**: Outpost.
- **MAP10.MTP**: Medium settlement.
- **MAP11.MTP**: Destroyed Training Center (Post-attack).
- **MAP12.MTP**: Large city/base.
- **MAP13.MTP**: Medium settlement.
- **MAP14.MTP**: Cave / Underground complex.

---

## Combat System Analysis

The combat system is split across two code segments that are **not** covered by the Reko decompiler output:
- **Segment 19EF** (linear 0x1A861-0x1BCE8): Movement, RNG, fire phase, grid adjacency, damage application
- **Segment 1000** (linear 0x105C5-0x14672): Combat loop, targeting, LoS/range check, weapon data access
- **Segment 0000** (linear 0x30DD-0x3113): **2D6 to-hit roll generator** (`ghidra_guess_0000_30DD_030DD`)

Source files: `spice86/GeneratedCode18.cs` (segment 19EF), `spice86/GeneratedCode13.cs`, `spice86/GeneratedCode10.cs` (segment 1000)

---

### 1. OVERALL COMBAT FLOW

```
COMBAT ENCOUNTER (two triggers: walking on world map 0800:192 or BLD script action menu)
  │
  ├─► Walking encounter: main loop checks RNG & bD330 == 0 every frame (see §16)
  │   → fn183B_000A initializes combat, populates enemies, sets w4FBA = 2
  │
  ├─► BLD script encounter: action menu at 0D27, "fight" choice sets w4FBA = 2
  │
  ├─► Set w4FBA = 2 (combat mode)
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
   │     └─► EXIT: loop termination → w4FBA = 3 (post-combat) on completion
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

**Function:** `ghidra_guess_0000_30DD_030DD` (segment 0000:30DD, linear 0x30DD)
**File:** `GeneratedCode1.cs` (lines 3237-3328)

Generates a **2-12 roll** matching tabletop 2D6:

```
// Sub-function: single D6 (ghidra_guess_0000_30F3_030F3)
d6():
    do {
        r = RNG() & 0x7    // 0-7 from 24-bit LFSR
    } while (r > 5)         // Rejection sampling: discard 6,7
    return r + 1            // 1-6

// Main: 2D6 roll
roll_2d6():
    return d6() + d6()      // 2-12
```

Each D6 is generated by:
1. Call `unknown_19EF_0BC0_1AAB0` (24-bit LFSR) → returns byte 0-255
2. Mask with 0x7 → 0-7
3. If result > 5, retry (rejection sampling for uniform 0-5)
4. Increment → 1-6
5. Two D6 calls summed → range 2-12

The 2D6 roll is called **once per attack** in the combat loop at `1000:4FC2` (GeneratedCode13.cs line 4697).

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

#### 7.10 VGA Impact Visual Effect

**Function:** `unknown_19EF_18EF_1B7DF`
**File:** `GeneratedCode19.cs` (lines 2509+)
**Segment:Offset:** 19EF:18EF (linear 0x1B7DF)

This is called **after** damage is applied, to render the visual impact effect:

```
    DS = 0x1DDC
    DI = 0x34 + 0x244B = 0x247F  ← screen buffer offset
    [0xA452] = 8                  ← drawing width
    [0xA454] = 0x994              ← Y coordinate parameter
    [0xA456] = 0x494              ← X coordinate parameter

    // VGA hardware acceleration (mode X, when tB764 == 2):
    DX = 0x3CE                    ← VGA Graphics Controller port
    AX = 0x205                    ← Set/Reset register: set bit 0 (plane 0)
    OUT DX, AX
    AX = 0x8                      ← Bit Mask register
    OUT DX, AX

    // 13-iteration loop (CX = 0xD):
    for i in 0..12:
        // Read/write to video memory at cursor position
        // Uses A44B/A44D packed coordinates
        // Draws impact sprite frame

    // Cleanup: restore VGA registers
```

**Purpose:** Draws the weapon impact animation at the cursor/target position using VGA hardware acceleration (Set/Reset and Bit Mask registers at port 0x3CE). The 13 iterations likely correspond to a splash/explosion sequence or frame animation.

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

The pair `DS:[0xA44B]` and `DS:[0xA44D]` serves dual purpose:

**As cursor coordinates (world map/text mode):**
| Register | Low Byte | High Byte |
|----------|----------|-----------|
| `0xA44B` | Sub-tile X | Tile column X |
| `0xA44D` | Sub-tile Y | Tile row Y |

Grid coordinate extraction: `tile_x = (A44B & 0x7F) >> 1` (range 0-63)
                          `tile_y = (A44D & 0x7F) >> 1`

**As phase/action counters (combat mode):**
- `0xA44D` low byte = combat sub-phase counter (decremented by phase function)
- `0xA44B` low byte = action/weapon slot counter
- Overflow handling: when low byte underflows (sign flag), high byte decrements by 0x10, low byte resets to 0x7F

---

### 10. RNG IMPLEMENTATION

**Function:** `unknown_19EF_0BC0_1AAB0`
**File:** `GeneratedCode18.cs` (lines 2225-2322)
**Segment:Offset:** 19EF:0BC0 (linear 0x1AAB0)

**State:** 3 bytes at `ES:0x4FC0-0x4FC2` with `ES = 0x384B`, `DS = 0x1DDC`

**Algorithm (pseudocode):**
```
rng():
    AL = state[0] >> 2           // Extract top 2 bits of state byte 0
    state[2] = RCL(state[2], 1)  // Rotate byte 2 left through carry
    state[1] = RCL(state[1], 1)  // Rotate byte 1 left through carry
    CMC                          // Complement carry flag
    AL = SBB(AL, state[0])       // AL -= state[0] + (carry ? 1 : 0)
    AL >>= 1                     // Shift right 1
    state[0] = RCR(state[0], 1)  // Rotate byte 0 right through carry
    AL = state[0] XOR state[1]   // Final mixing
    return AL                    // Random byte in AL
```

This is a **Linear Feedback Shift Register (LFSR)** variant:
- 24-bit state (3 bytes) shifted/rotated
- XOR feedback taps between state bytes
- Produces one pseudorandom byte per call
- Used for: to-hit rolls, hit location, damage variation

---

### 11. POST-FIRE CLEANUP

**Function:** `unknown_19EF_1DF8_1BCE8`
**Segment:Offset:** 19EF:1DF8 (linear 0x1BCE8)

Handles state cleanup after a unit completes its fire phase:
- Updates unit action status
- Possibly checks for unit destruction
- Advances to next unit in the loop

---

### 12. COMBAT STATE MACHINE

**State variable:** `w4FBA` (located in Eq_57354 at varying offsets depending on segment context)

| Value | Meaning |
|-------|---------|
| 0 | Safe/training mode (no enemy aggression) |
| 1 | Alert/flee mode (enemy present, can escape) |
| 2 | Combat in progress (active engagement) |
| 3 | Post-combat (victory/retreat resolved) |

**Triggering combat:**
- BLD script interpreter (1E56:03F5) dispatches combat-related property handlers
- The handler sets `w4FBA = 2` when an encounter begins
- Story property `0x1F` triggers the citadel attack (training→combat transition)
- Story property `0x20` handles multi-step combat/encounter resolution

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

| Field | Offset | Description |
|-------|--------|-------------|
| Name | +0x00 | 10 bytes, ASCII null-padded |
| Damage | +0x0A | uint8 |
| Shots/Ammo | +0x0B | uint8 (0x81 = infinite?) |
| Heat | +0x0C | uint8 |
| Sound/VFX | +0x0D | uint8 |
| Range | +0x0E | uint16 LE |
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

The only direction variable in the game is for **NPC world-map sprite rendering** ([`TECHNICAL_ANALYSIS.md §18`]) — high nibble of `ES:[0xD398]` = BLD index, low nibble = facing direction (0-7). This is never read during combat.

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

### 17. WORLD MAP RANDOM ENCOUNTER SYSTEM

**RESOLVED:** Full encounter mechanics documented below.

The random encounter system is triggered by **walking on the world map** (not by entering buildings or the action menu). It is checked **every frame** in the main game loop at segment `0800`.

#### 17.1 Core Check

**File:** `UNBTECH.reko/UNBTECH_0800.c:192-201` (segment `0800`)
**Spice86:** `spice86/GeneratedCode.cs:1527-1549` (segment `0170:0287`)

```c
int16 ax_540 = fn207F_0BC0();          // RNG → random byte (0-255)
selector es_547 = ...;
if ((ax_540 & es_547->bD330) == 0x00   // Probability mask check
    && es_547->bD310 != 0x00           // On world map
    && es_547->bD346 == 0x00)          // NOT on star map / alternate view
{
    fn183B_000A(..., 0, ...);          // Initiate encounter → combat setup
}
```

#### 17.2 Probability Mask (`bD330` at segment offset `0xD330`)

The check is: **`RNG_byte & bD330 == 0`**. Since RNG returns 0-255 uniformly, the mask determines probability:

| Value | Binary | Match Condition | Probability | Context |
|-------|--------|----------------|-------------|---------|
| `0x1F` | `00011111` | 8/256 values match (0x00, 0x20, 0x40, 0x60, 0x80, 0xA0, 0xC0, 0xE0) | **1/32 ≈ 3.125% per frame** | World map walking (set at `UNBTECH_11B8.c:1120`) |
| `0x7F` | `01111111` | 2/256 values match (0x00, 0x80) | **1/128 ≈ 0.78% per frame** | After encounter/combat (set at `UNBTECH_183B.c:804`) |

**There is NO terrain/tile modifier**: the probability is flat regardless of which tile the player is on. No encounter rate table per tile type exists.

#### 17.3 Encounter Population (`fn0DAB_0D3D`, segment 0DAB:0D3D)

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

#### 17.4 Encounter Positioning (`fn183B_28DB`, segment 183B:28DB)

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

#### 17.5 Mode Guards

**`bD310`** (at `0xD310`) — **World map active flag**:
- Set to `0x01` when entering the world map view (`UNBTECH_0FDC.c:1075` / `GeneratedCode7.cs:2754`)
- Must be non-zero for encounters (player must be on world map, not in a building/menu)

**`bD346`** (at `0xD346`) — **Star map / alternate view flag**:
- Set to `0x01` by `fn0800_2DA8` when `wArg06 == 0x0E` (`UNBTECH_0800.c:2913-2917`)
- Must be zero for encounters (player must not be on the star map or in combat view)

#### 17.6 Encounter Initiation: `fn183B_000A` (segment `183B:000A`)

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

#### 17.7 World Map Movement System (How Walking Happens)

**File:** `UNBTECH.reko/UNBTECH_207F.c:1920-2074`

| Function | Description |
|----------|-------------|
| `fn207F_158C` | Move cursor **up** (decrement Y, with scroll wrap) |
| `fn207F_163B` | Move cursor **down** (increment Y, with scroll wrap) |
| `fn207F_16E3` | Move cursor **left** (decrement X, with scroll wrap) |
| `fn207F_17C5` | Move cursor **right** (increment X, with scroll wrap) |

High-level movement dispatch at `fn0800_17BB`/`fn0800_186F`/`fn0800_191B` in `UNBTECH_0800.c:1142-1219`. Keyboard input handled by `fn0800_231D` at `UNBTECH_0800.c:2004-2078`.

All direction functions handle screen scrolling by copying video memory when cursor crosses tile boundaries (wrapping at 0x00/0xF0 for coordinate high byte).

#### 17.8 World Map Coordinate System

From `UNBTECH_0FDC.c:868-869`:
```c
tile_x = (A44B & 0x7F) >> 1;   // 0-63 range
tile_y = (A44D & 0x7F) >> 1;   // 0-63 range
```

- Low byte: sub-tile position within a 16×16 grid (step size 2 pixels)
- High byte: tile column/row index
- Star map (MAP15) tiles accessed as `tile[y * 32 + x]` where x=0..31, y=0..23 (768 bytes, linear format)

#### 17.9 Relationship to Segment 0D27 (Action Menu)

Segment `0D27:0044` is **NOT** the random encounter handler. It is the **action menu handler** triggered by pressing SPACE at a location. It presents options 1-4 (actions like enter building, leave city, etc.) and processes the player's choice. The `w4FBA = 2` transition seen there is from the menu choice going into combat (e.g., selecting "fight" at a location), not from random walking encounters.

#### 17.10 Encounter Flow Summary

```
Main Game Loop (fn0800_0000)
  │
  ├─ Read keyboard → fn0800_231D (key dispatch)
  │   └─ Arrow keys → movement functions (update A44B/A44D)
  │
  ├─ Space bar → fn0800_2C50 (action menu at 0D27)
  │
  ├─ ENCOUNTER CHECK (0800:192-201 every frame):
  │   RNG & bD330 == 0  AND  bD310 != 0  AND  bD346 == 0
  │   │
  │   └─ True → fn183B_000A
  │       ├─ Save current positions
  │       ├─ Initialize combat arrays (clear all units)
  │       ├─ Populate enemies via fn0DAB_0D3D + fn183B_28DB
  │       ├─ Execute BLD script 0x33FC for encounter narration
  │       ├─ Set bD330 = 0x7F (reduce re-encounter probability)
  │       └─ Transition to combat mode (w4FBA → 2)
  │
  ├─ Decrement timers (bD320-bD323)
  │
  └─ fn0800_240B/fn0800_24C2 (refresh cycle)
```

---

## 17. STORY ARC & PROGRESSION SYSTEM

The game uses a **three-layer state system** to drive the narrative. These layers work independently but interact through BLD scripts.

### 17.1 Three-Layer State Architecture

**Layer 1: Generic State Array at `D30C` (256 bytes)**
- Modified by BLD opcodes: `0xF1` (ADD_TO_STATE) and `0xF4` (SET_STATE_VALUE)
- Checked by opcodes: `0xF7` (STATE_COND_CHECK) and `0xF3` (SHOP_INTERACTION)
- Handles day-to-day state: shop inventories, visited flags, quest progress, party status
- Persists across BLD script invocations — changes in one building affect conditionals in another

**Layer 2: Story Properties (`fn1631_11AB`, segment `1631:11AB`)**
- Properties `0x1F` and `0x20` drive major story milestones
- Called from `fn1AE8_000C` (combat narrative handler) during encounter resolution
- Stores state in the per-story-slot structure `Eq_107947` (0x7D bytes each, array `aC744[]`)
- Key fields: `b0057` (citadel attack state 0→1→2), `b0055`/`b0056` (multi-step counters)

**Layer 3: BLD Flag System**
- Flag `bD450` (at `0xD450`): training complete marker. Set by `fn1CD3_0004` case `0x19` (FLAG_D450)
- Flag `bD451` (at `0xD451`): milestone marker. Set by `fn1CD3_0004` case `0x1A` (FLAG_D451)
- Checked by opcodes `0xEB` (CHECK_FLAG_EB → checks `bD451`) and `0xEC` (CHECK_FLAG_EC → checks `bD450`)

### 17.2 BLD Script Interpreter Architecture

The .BLD file system is a **four-layer interpreter**:

```
Layer 1: fn0FDC_0008 (0FDC:0008)
  Entry point. Loads BLD data by index, calls fn0FDC_1D30 to prepare buffer.

Layer 2: fn0FDC_01C0 (0FDC:01C0)
  Bytecode interpreter. Handles opcodes 0xE4-0xFF (see §17.3).
  Bytes 0x00-0x7F are transparent (cipher text passes through).
  Bytes 0x80-0xC3 enter switch but match no cases (structural markers/no-ops).

Layer 3: fn1CD3_0004 (1CD3:0004)
  Room/building interaction dispatcher. 47-case switch (cases 0x01-0x2F).
  Handles: building entry/exit, shop buy/sell, combat, healing, flags, party.

Layer 4: fn1E56_03F5 (1E56:03F5)
  Text renderer. Formats cipher-encoded text with word-wrapping, margins.
  Special chars: 0x0D=CR, 0x02/0x06=soft break, 0x20=space, 0x09=indent.
```

### 17.3 BLD Opcode Dispatch (fn0FDC_01C0)

Opcodes 0xE4-0xFF are handled in a switch at `UNBTECH_0FDC.c:197-535`:

| Opcode | Reko Case | Name | Operand | Description |
|--------|-----------|------|---------|-------------|
| `0xE4` | `~0x1B` | WRITE_CHAR | 1 byte | Read byte, write as character via `fn0800_19BF` |
| `0xE5` | `~0x1A` | ADD_CREDITS | 2 bytes LE | Add signed value to `tD370` (C-Bills) |
| `0xE6` | `~0x19` | SET_CURSOR_XY | 4 bytes LE | Set cursor X (`A44B`) and Y (`A44D`) |
| `0xE7` | `65511` | CMP_CURSOR_X | 2 bytes LE | Compare with `A44B`. If NOT equal, skip next opcode |
| `0xE8` | `~0x17` | RNG_CHECK | 1 byte | If `(RNG() & operand) == 0`, skip next opcode |
| `0xE9` | `~0x16` | CALL_ROOM_HANDLER | 1 byte | Call `fn11B8_0D58(operand)` |
| `0xEA` | `~0x15` | COND_STATE_ACTION | 2 bytes (cond+action) | If `w3938==0`, call `fn0800_48B7(cond, action)` |
| `0xEB` | `65515` | CHECK_FLAG_EB | 0 bytes | Skip if `bD451 == 0` |
| `0xEC` | `65516` | CHECK_FLAG_EC | 0 bytes | Skip if `bD450 == 0` |
| `0xED` | `~0x12` | UNIT_CHECK_LOOP | 2 bytes | Loop 8 units checking `aC60F` state |
| `0xEE` | `~0x11` | SPEND_CREDITS | 2 bytes LE | Deduct from `tD370` (with zero-floor) |
| `0xEF` | `~0x10` | CHECK_CREDITS | 2 bytes LE | Skip if insufficient funds |
| `0xF0` | `~0x0F` | SET_TEXT_MARGINS | 2 bytes | Set left/right text margins |
| `0xF1` | `~0x0E` | ADD_TO_STATE | 2 bytes | `D30C[index] += value` |
| `0xF2` | `~0x0D` | ROOM_DESCRIPTION | 0 bytes | Call `fn1F3D_086A` to render room description |
| `0xF3` | `~0x0C` | SHOP_INTERACTION | 1 byte | Index into `D30C` state array, indirect dispatch |
| `0xF4` | `~0x0B` | SET_STATE_VALUE | 2 bytes | `D30C[index] = value` |
| `0xF5` | `~0x0A` | SHOP_DISPATCH | 1 byte | Call `fn1CD3_0004(operand)` — dispatches to room handler |
| `0xF6` | `~0x09` | CHECK_CONDITION | 0 bytes | Call `fn0800_1A13(1)`, skip if returns 0 |
| `0xF7` | `~0x08` | STATE_COND_CHECK | 1 byte | Skip if `D30C[index] == 0` |
| `0xF8` | `~0x07` | JUMP_FORWARD | 2 bytes LE | Read 2-byte WORD → absolute jump target (new IP = word value) |
| `0xF9` | `~0x06` | JUMP_INDEXED | 1 byte | Read 1 byte menuId, calls `fn1E56_0B5E(menuId)` → returns index, reads WORD at `base + _ip + index*2` as new IP (absolute jump table) |
| `0xFA` | `~0x05` | DRAW_SPRITE | 1 byte | Draw sprite via `fn1E56_0004(operand)` |
| `0xFB` | `~0x04` | ADVANCE_INPUT | 0 bytes | Wait for key via `fn1F3D_0259` |
| `0xFC` | `~0x03` | RENDER_TEXT | N bytes | Display cipher text via `fn1E56_03F5`. Advance past string |
| `0xFD` | `~0x02` | SET_FONT2 | 0 bytes | Call `fn1E56_0388` for font/display params |
| `0xFE` | `~0x01` | SET_FONT | 1 byte | Call `fn1E56_0281(operand)` to set font |
| `0xFF` | `~0x00` | EXIT | 0 bytes | Set exit flag, stop interpreter |

### 17.4 fn1CD3_0004 Case Dispatch (47 Cases, 0x01-0x2F)

**File:** `UNBTECH.reko/UNBTECH_1CD3.c` (segment `1CD3:0004`)

Called from BLD opcode `0xF5` and various game functions. All 47 cases present.

| Case | Name | Description |
|------|------|-------------|
| `0x01` | ENTER_BUILDING | Load building BLD data, init viewport, check `bD30E` for variants |
| `0x02` | SHOW_GREETING | Display entry text via `fn1E56_03F5`. Checks `bC724` for variant |
| `0x03` | EXIT_BUILDING | Clear building state, restore world coordinates, reset NPCs |
| `0x04` | SHOW_SHOP_ITEMS | Render 3 shop item slots (loop 0-2). Reads `C618[n]`, computes price, calls `fn207F_3BB6`/`fn1F3D_00D5` |
| `0x05` | BUY_ITEM_SINGLE | Single item: `C618[bD314] += 1`, `tD370 -= C618[bD314] * 125 + 75` |
| `0x06` | SHOW_PLAYER_ITEMS | Display player's owned items (`aD374[n] != 0`) for potential sale |
| `0x07` | BUY_ITEM_BULK | Bulk buy at 1 cr/unit: `fn1543_0CDE`→qty, `aD374[sel] += qty`, `tD370 -= qty` |
| `0x08` | SELL_ITEM_BULK | Bulk sell at 1 cr/unit: `fn1543_0CDE`→qty, `aD374[sel] -= qty`, `tD370 += qty` |
| `0x09` | HOSPITAL_HEAL | Deduct healing cost from table 0x4F26/0x4F28, call `fn1631_1FDF` + `fn0FDC_13DE` |
| `0x0A` | SHOW_CREDITS | Display `tD370/tD372` formatted via `fn207F_3BD2` |
| `0x0B` | BUY_WITH_UNIT_SEL | Purchase + unit selection. Cost from table 0x4F44/0x4F46. Calls `fn1631_1FDF` + `fn0FDC_15E6` |
| `0x0C` | CLOSE_ACTION | Close current shop/action via `fn0FDC_17B9` |
| `0x0D` | EQUIPMENT_MENU | Equipment selection from unit slots. Lists items at `0xC61C[stride 0x11]`, calls `fn1E56_03F5` + `fn1E56_0B5E` for menu. Stores selected unit index in `bD31A` |
| `0x0E` | COUNT_UNIT_SLOTS | Count occupied units (8 slots `bC614[]`, stride 0x11). Result in `bD31A` |
| `0x0F` | EQUIP_SLOT5 | Equip item type 5: 500cr debit, `C618[5][bD31A]++`, set `bC623[].bit0`. Calls `fn1631_1FDF` |
| `0x10` | CHECK_EQUIP_SLOT5 | Query: `bD31B = bC623[bD31A] & 0x01` (slot 5 flag) |
| `0x11` | COUNT_STORY_SLOTS | Count occupied story/mech slots (4 slots `bC724[]`, stride 0x7D). Result in `bD31C` |
| `0x12` | DISPATCH_11B8_0002 | Render via `fn11B8_0002` (viewport/tile display) |
| `0x13` | DISPATCH_11B8_080A | Render overlay via `fn11B8_080A` (building name/text) |
| `0x14` | DISPATCH_11B8_0925 | Render text overlay via `fn11B8_0925` |
| `0x15` | EQUIP_SLOT6 | Equip item type 6: 500cr debit, `C618[6][bD31A]++`, set `bC623[].bit1`. Calls `fn1631_1FDF` |
| `0x16` | CHECK_EQUIP_SLOT6 | Query: `bD31B = bC623[bD31A] & 0x02` (slot 6 flag) |
| `0x17` | EQUIP_CONSISTENCY | Verify equip state vs expected: compare `aC615[n]*10` vs `bC623[n]`. Sets `bD325=1` on mismatch |
| `0x18` | GARAGE_SERVICE | Paid service dispatch. Reads cost from table 0x4F6E indexed by `bD326`. Debits credits, calls `fn1431_000A` for service. Insufficient funds: shows message + grants 25cr pity |
| `0x19` | FLAG_D450 | **Set `bD450 = 1`** — training complete marker |
| `0x1A` | FLAG_D451 | **Set `bD451 = 1`** — milestone marker |
| `0x1B` | GOTO_2E_SHARED | Shared path with case 0x2E |
| `0x1C` | CLEAR_ALL_SLOTS | Clear 4 story/mech slots: save `bC724[n]` to temp, set to 0xFF, reset `bC620[n]=8` |
| `0x1D` | COUNT_UPPERCASE | Count story slots with IDs in 'A'-'Z' range (0x41-0x5A). Result in `bD31C` |
| `0x1E` | DISPATCH_11B8_104E | Render via `fn11B8_104E` |
| `0x1F` | READ_SLOT_FLAG | Copy `bC620[1][bD31A]` → `bD32B` |
| `0x20` | COMPLEX_EQUIP | Multi-step equip interaction: reads item type from `bC620[1][bD31A]`, validates vs table 0x4DDB, handles bulk buy loops with `fn0800_1A13`, calls `fn1631_1FDF` |
| `0x21` | DISPATCH_0FDC_1C9B | Call `fn0FDC_1C9B` |
| `0x22` | DISPATCH_0FDC_1A26 | Call `fn0FDC_1A26` |
| `0x23` | NEW_GAME_INIT | **Full game init**: clear state, load char templates, set party, init graphics, init viewport |
| `0x24` | READ_UNIT_SLOT | Read `bC614[bD331].b0000` → display via item name lookup |
| `0x25` | CLEAR_UNIT_SLOT | Clear `w014A=0`, set `bC614[0]=0xFF` (empty first slot) |
| `0x26` | READ_D456 | Read `bD456`, look up item name in `a01CC/a01CA` tables, render via `fn1E56_03F5` |
| `0x27` | TRIGGER_ACTION | Call `fn1467_0002(0x01)` — mode trigger |
| `0x28` | DISPATCH_11B8_152F | Call `fn11B8_152F`, optionally set `bD334=1` |
| `0x29` | COMBAT_HEAL | Apply RNG damage/healing to party: `heal = (RNG&1 + 6) * unit_max`, capped at current damage |
| `0x2A` | SAVE_POSITIONS | Save unit positions (X to `0x4024[]`, Y to `0x4056[]`) + COMSTAR state |
| `0x2B` | RESTORE_POSITIONS | Restore positions from saved arrays (`0x4024`/`0xD390` for X, `0x4056`/`0xD392` for Y) |
| `0x2C` | DISPATCH_11B8_1762 | Position/state management via `fn11B8_1762` |
| `0x2D` | COMBAT_ENCOUNTER | **Combat transition**: handle `w4FBA` states 0→2→3, setup viewport, template load, border draw |
| `0x2E` | RESTORE_SLOTS | Restore 4 story slots from temporary backup, update `bD55E`, call `fn1467_0002` |
| `0x2F` | DECREMENT_STATE | If `bC623 > 5`, decrement by 4 |

### 17.5 fn1631_11AB Story Property Handler (segment `1631:11AB`)

**File:** `UNBTECH.reko/UNBTECH_1631.c:1019-1317`

Called with `wArg04` (story slot index) and `wArg06` (property ID, 0x1C-0x23).

**Property 0x1C-0x23** are nibble-packed flag management for slot 0x24/0x25 (skill) and slot 0x3A/0x48/0x4F/0x51 (inventory/equipment).

**Property 0x1F (Citadel Attack):**
- Subcode from `fn0800_19F3` (RNG-based):
  - `1`: Checks `b0058[wArg04]`. If non-zero → set to `0xFF` (latch/one-shot marker)
  - `2` or `5`: Increments `b0057[wArg04]` up to 2 (citadel attack state)
  - `3`: Clears story byte at `0xC79B + offset`
  - `4`: Calls `fn1631_163E` for counter/sequence operation
  - `6`: Same as subcode 1 (b0058 latch)

**Property 0x20 (Multi-Step Counter):**
- Calls `fn0800_19F3` twice for RNG-sampled subcode
- If first result ≤ 3: increments `b0056[wArg04]` (capped at 2)
- If second result ≤ 3: increments `b0055[wArg04]` (capped at 3)
- When cap reached: clears `b0000[wArg04]`, sets `wE484 = 1` (story action complete flag)
- Otherwise: calls `fn1631_163E` to decrement remaining step counter

### 17.6 Complete Story Arc: Phase by Phase

#### Phase 1: New Game Init
- **Call**: `fn1CD3_0004` case `0x23` (NEW_GAME_INIT)
- **Code**: `UNBTECH_1CD3.c:156-259`
- Clears all game state, loads character templates from template table
- Sets initial party (Jason Youngblood in slot 0, potentially 0-3 others)
- Positions player at Training Center: `A44B=0x0C3C`, `A44D=0xC04F` (MAP1: Training Center/Citadel)
- `b0057 = 0` (training mode)
- `bD330 = 0` (no random encounters during training — citadel is isolated)

#### Phase 2: Training (TRAINING.BLD / MAP1)
- Player on MAP1, enters TRAINING.BLD by pressing SPACE at designated tile
- `fn0FDC_0008(0)` called with BLD index 0 (TRAINING.BLD)
- 8 training missions via dialogue choices and combat encounters:
  1. Familiarization — basic movement
  2. Rubble pickup — object interaction
  3. Weapons practice — target shooting
  4. Reactionary combat — enemy response
  5. Remote-controlled Locust duel
  6. Multi-Mech engagement
  7. Assessment — instructor evaluation
  8. **Final exam** — full combat scenario
- Each completion modifies state array at `D30C` via opcodes `0xF1`/`0xF4`
- **Training completion**: BLD script calls `0xF5` with dispatch → `fn1CD3_0004` case `0x19` (FLAG_D450) → sets `bD450 = 1`
- Rick Atlas event in LOUNGE.BLD gives Jason the mysterious device

#### Phase 3: Citadel Attack (triggered from TRAINING.BLD)
- After `bD450 = 1`, the TRAINING.BLD script transitions from training to attack narrative
- At TRAINING.BLD offset ~6018: opcode `0xF5` with operand `0xC3` (195) dispatches to `fn1CD3_0004(195)`
- The "kill-you line" at segment `3EDB:32F0`: *"They're trying to actually kill you! This is no training mission!"*
- During the encounter: `fn1AE8_000C` (combat narrative) calls `fn1631_11AB` with **property 0x1F**
- `b0057` incremented from 0→1→2 through successive property 0x1F subcode 2/5 calls
- **Side effects**:
  - MAP1 tile properties updated to point to MAP11 (Destroyed Training Center)
  - `bD330` set to `0x1F` (encounter probability 1/32 per frame — world becomes dangerous)
  - `bD310` gates world map interactions (enabled after attack)
  - Story state penalty `+2` to-hit modifier activated in combat (checked at `C79B`)

#### Phase 4: Post-Attack Free-Roam (World Map)
- Player now on the world map (MAP15, 32×24 tile grid)
- Encounter check runs **every frame**: `RNG & 0x1F == 0` → `fn183B_000A`
- Walking triggers random encounters irrespective of terrain (flat 1/32 probability)
- City tiles on map are gated by plot: most are locked during training, unlocked after attack
- SPACE at a city tile → action menu at segment `0D27:0044`:
  - Option 1: Enter building → `fn0FDC_0008(bld_index)`
  - Option 2: Leave city
  - Option 3: Fight → sets `w4FBA = 2` (combat mode)
  - Option 4: Rest

#### Phase 5: Building/Script Trigger Map

Each world map location is tied to a BLD file. The BLD index is determined by:
1. The map tile property at the player's position (from tile property table at `DS:[0x55DC]→0x32C6`)
2. A translation table at `segment [0x5460]:0x4602` (16-byte signed array loaded from MTP file header at `0x3092:4602`): remaps tile property value → BLD file index, handled by segment 094C functions `unknown_094C_0008_094C8` and `unknown_094C_17B9_0AC79`

| Map | BLD File | Trigger | Story Purpose |
|-----|----------|---------|---------------|
| MAP1/11 | TRAINING | Default start + post-attack | Training missions + citadel attack |
| MAP1/11 | CITADEL | `b0057 ≥ 1` | Post-attack citadel exploration |
| MAP2 | BARRACKS | At barracks tile | Recruit NPCs, interact with cadets |
| MAP2 | BARRACK2 | At secondary barracks | Additional soldier interactions |
| MAP2 | LOUNGE | At lounge tile | Rick gives device, mentions Starport |
| MAP2 | COMSTAR | At ComStar building | Banking, stock market (DefHes, NasDiv, BakPhar) |
| MAP2 | PARTY | At party house | Rex rescues Jason, gives Jeremiah's box |
| MAP2 | MAYOR | At mayor's house | Read newspaper, view holodisk, escape mayor |
| MAP2 | JAIL | At jail, if state[?] ≥ threshold | Rescue agent, acquire Stinger from impound |
| MAP2 | WEAPON/WEAPON2 | At weapon shop | Buy infantry weapons (Kuritan collaborator) |
| MAP2 | ARMOR | At armor shop | Buy armor (FlakVest, FlakSuit, etc.) |
| MAP2 | CLOTHES | At clothes shop | Buy civilian clothes |
| MAP2 | HOSPITAL | At hospital | Healing services |
| MAP2 | GARAGE | At garage | Vehicle services |
| MAP2 | REPAIR | At repair center | Recruit tech, modify Mechs |
| MAP2 | ARENA | At arena | Mech combat arena |
| MAP2 | ENTRANCE | At city entrance | Story transition point |
| MAP2 | THEATER | At theater | Entertainment/plot |
| MAP3-10 | FINDIT | At specific world map tile | Search for cache clues |
| MAP14 (Cave) | HUT | At Tellhim's hut location | Face holographic tests, repair holodisk |
| MAP14 (Cave) | FROB | At puzzle entrance | Tellhim's gauntlet: answer questions about Jeremiah |
| MAP14 (Cave) | INSTRUCT | At cache entrance | Jeremiah's color-coded lock instructions |
| MAP14 (Cave) | VIEWDISK | At cache interior | Play Jeremiah's holodisk message |
| Endgame | WINSCENE | At cache completion | Hyperpulse Generator → Katrina → Crescent Hawks |
| Endgame | ENDMECH | At ending | Endgame image and credits |

#### Phase 6: Story Property 0x20 Multi-Step Counter
- After citadel attack, property `0x20` triggers during encounters to track multi-step progress:
  - `b0055` incremented (cap 3): tracking major steps
  - `b0056` incremented (cap 2): tracking minor steps
- When counters reach cap: `b0000` cleared, `wE484 = 1` signals story action complete
- This gates which conditional branches unlock in BLD scripts:
  - BLD scripts check state array values via opcode `0xF7` (STATE_COND_CHECK)
  - Server room access, jailbreak readiness, cache location clues

#### Phase 7: Endgame
- Cache entry requires: holodisk repaired (HUT.BLD) + password learned (FROB.BLD) + cache location known (FINDIT.BLD)
- INSTRUCT.BLD at cave entrance: color-coded lock puzzle (Jeremiah's note)
- Inside cache: VIEWDISK.BLD shows Jeremiah's holodisk message
- WINSCENE.BLD (type `c0 da`): activates Hyperpulse Generator → signals Katrina Steiner
- DropShip arrives, Katrina offers commission as Lyran Lieutenant
- Jason declines to search for his father
- The Crescent Hawks are formed as an independent unit
- ENDMECH.CMP renders the endgame image: *"Press any key to end the game"*

### 17.7 Story State Data Structure (Eq_107947)

Per-story-slot structure at `aC744[]` (stride 0x7D = 125 bytes), segment pointed by `DS:0x558E`:

| Offset | Field | Purpose |
|--------|-------|---------|
| `0x00` | `b0000` | Generic per-story status byte (cleared by property 0x20 completion) |
| `0x04`-`0x05` | `b0004`/`b0005` | Nibble-packed flag fields for inventory/equipment |
| `0x06` | `b0006` | Timing/counter nibble |
| `0x24` | Skill property byte | Skill tracking (popcount of low 3 bits → 0-3) |
| `0x25` | Skill property byte | Skill tracking (popcount of low 3 bits → 0-3) |
| `0x33`-`0x55` | Target preference table | Encoded AI target preferences |
| `0x55` | `b0055` | Counter for property 0x20 major steps (capped at 3) |
| `0x56` | `b0056` | Counter for property 0x20 minor steps (capped at 2) |
| `0x57` | `b0057` | Story state byte: 0=Training, 1=Citadel Attacked, 2=Post-Attack |
| `0x58` | `b0058` | One-shot latch/marker for property 0x1F |

### 17.8 How the Map-Event System Drives the Story

The game is NOT driven by a linear script or trigger table. The story is **emergent** from:

1. **World map state controls availability**: `bD330` (encounter probability), `bD310` (world map active), `bD346` (star map mode) gate what happens
2. **Citadel attack state gates the world**: `b0057 = 0` means training mode (locked city tiles, no encounters); `b0057 ≥ 1` opens the world
3. **BLD scripts contain their own logic**: Each building's script has conditionals (`0xEB`/`0xEC`/`0xF7`) that check flags and state array values, producing different dialogue/outcomes based on story progress
4. **State array persists across visits**: Modifications through `0xF1`/`0xF4` in one building affect condition checks in another — creating the illusion of a persistent world
5. **Combat encounters advance plot**: `fn1AE8_000C` during combat calls `fn1631_11AB` for story property updates, tying narrative progression to combat resolution

### 17.9 The citadel attack chain in detail (TRAINING.BLD offset ~5900-6200)

At the point of attack in TRAINING.BLD:
```
[... training complete ...]
→ Third-person narrative: "Kuritan Mechs have made a lightning raid on Pacifica"
→ "They have destroyed the citadel"
→ opcode 0xF5 operand 0xC3: dispatches combat encounter (the Jenner attack)
→ "One of the Kuritan Jenner tries to crush you in your Mech's cockpit"
→ "but you barely escape before the deadly blow can cut you down"
→ Third-person: "You manage to hide in the trees"
→ "Some of the remnant of the Lyran Guard engage the Mechs"
→ Third-person: "Your comrades are wiped out"
→ opcode 0xF5: SHOP_DISPATCH to case handler → triggers property 0x1F → b0057++
→ Encounter probability enabled globally
```

### 17.10 Mech/Unit Inventory System

The game uses a **two-tier architecture** for tracking the player's owned units (Mechs and infantry): story slots represent characters, and unit slots represent the actual combat units those characters pilot/operate.

#### Architecture Overview

```
Story Slots (aC724, 4×125 bytes)         Unit Slots (aC614, 8×17 bytes)
┌──────────────────────┐                ┌──────────────────────┐
│ Slot 0: Jason        │───b0079───────►│ Slot 0: Primary Mech │
│       b0079 = prim.  │                │  b0000 = type ID     │
│       b007A = sec.   │───b007A───────►│ Slot 4: Secondary    │
├──────────────────────┤                ├──────────────────────┤
│ Slot 1: Rex          │───b0079───────►│ Slot 1: Primary Mech │
│       b0079 = prim.  │                │  b0000 = type ID     │
│       b007A = sec.   │───b007A───────►│ Slot 5: Secondary    │
├──────────────────────┤                ├──────────────────────┤
│ Slot 2: Character 2  │───b0079───────►│ Slot 2: Primary Mech │
│       b0079 = prim.  │                │                       │
│       b007A = sec.   │───b007A───────►│ Slot 6: Secondary    │
├──────────────────────┤                ├──────────────────────┤
│ Slot 3: Character 3  │───b0079───────►│ Slot 3: Primary Mech │
│       b0079 = prim.  │                │                       │
│       b007A = sec.   │───b007A───────►│ Slot 7: Secondary    │
└──────────────────────┘                └──────────────────────┘

Mech Data (125 bytes each, in story slot array at segment 0x3092)
┌────────────────────────────────────────────────────┐
│ Story slots 0-3 (player) → combat units 0-3        │
│  Ammo at C74B + id×125 (= C724 + id×125 + 0x27)    │
├────────────────────────────────────────────────────┤
│ Story slots 4-7 (enemy templates) → combat 12-15    │
│  Ammo at C363 + id×125 (= C724 + (id-8)×125 + 0x27)│
├────────────────────────────────────────────────────┤
│ Enemies 4-11 use burst counter at C5D4 + id×17      │
│ (not full mech structs)                              │
└────────────────────────────────────────────────────┘
```

#### Data Structures

**Story Slot (`aC724[]`, 4 entries, stride 125/0x7D)**

Segment structure reference: `Eq_49571` (UNBTECH.h:54256), `Eq_107547` (UNBTECH.h:685747)

| Offset | Field | Purpose |
|--------|-------|---------|
| `+0x00` | `b0000` | Occupancy (`0xFF` = empty, no character in slot) |
| `+0x1F` | `b001F` | Story state / property gate |
| `+0x20` | `b0020` | Story state / property gate |
| `+0x24` | `b0024` | Nibble-packed skill/flag field (popcount → skill mod 0-3) |
| `+0x25` | `b0025` | Nibble-packed skill/flag field (popcount → skill mod 0-3) |
| `+0x69` | `b0069` | Upper nibble comparison target for `b0024` |
| `+0x6A` | `b006A` | Upper nibble comparison target for `b0025` |
| `+0x75` | `b0075` | Encounter/combat state for character |
| `+0x76` | `b0076` | Encounter/combat state for character |
| **`+0x79`** | **`b0079`** | **Primary unit slot index** (`0xFF` = unassigned) |
| **`+0x7A`** | **`b007A`** | **Secondary unit slot index** (`0xFF` = unassigned) |

Fields `+0x79` and `+0x7A` link the story character to the unit slots they own. Each character can own up to **two** units — a primary (used in combat lance) and a secondary (garage/backup).

**Unit Slot (`aC614[]`, 8 entries, stride 17/0x11)**

Segment structure reference: `Eq_107577` (UNBTECH.h:685781), `Eq_106563` (UNBTECH.h:684673)

| Offset | Field | Purpose |
|--------|-------|---------|
| **`+0x00`** | **`b0000`** | **Unit type ID** (`0xFF` = empty slot). Determines mech/infantry template |
| `+0x01` | `b0001` | Generated attribute (from `fn0800_19DD`) |
| `+0x08` | `b0008` | Derived attribute (`= b0001 * 10`, modified if slot ≥ 4) |
| `+0x09` | `b0009` | Another generated attribute |
| **`+0x0C`** | **`b000C`** | **Linked story slot index** (`0x08` = unassigned). Back-reference to owner |
| `+0x0D` | `b000D` | Supplementary attribute |
| `+0x0E` | `b000E` | Supplementary attribute |
| `+0x0F` | `b000F` | Supplementary attribute |

The unit type ID at `+0x00` determines which mech/infantry template is used. Templates are defined at segment `0x54C8` in arrays `a01CC[]` and `a01CA[]` (name strings at `es_238->a01CC[0].w0000[ax_233]` and type strings at `es_238->a01CA[0].u5[ax_233]`).

#### Unit Slot Organization

Unit slots 0-3 serve as the **primary lance** (one per character). Slots 4-7 serve as **secondary/garage** slots (one backup per character). The layout is:

| Character (Story Slot) | Primary Unit Slot | Secondary Unit Slot |
|------------------------|------------------|-------------------|
| 0 (Jason) | 0 | 4 |
| 1 (Rex) | 1 | 5 |
| 2 | 2 | 6 |
| 3 | 3 | 7 |

This is not enforced by the code — the `b0079`/`b007A` fields can point to any slot — but this is the natural assignment when units are created.

#### Mech Data Pools

The actual mech state (armor, structure, ammo, components) is stored as **125-byte structs** within the story slot array `aC724[]` (segment `0x3092`). The ammo field is at offset `+0x27` within each 125-byte slot:

| Combat unit | Address formula | Story slot | Ammo at | Contents |
|-------------|-----------------|------------|---------|----------|
| 0-3 | `C74B + id × 125` | slots 0-3 | `C724 + id×125 + 0x27` | Player lance mechs |
| 4-11 | `C5D4 + id × 17` | (separate) | `C5D4 + id×17 + stage` | Enemy infantry (burst counter, 17B stride) |
| 12-15 | `C363 + id × 125` | slots 4-7 | `C724 + (id-8)×125 + 0x27` | Enemy mech templates |

The **same story slot array** (`aC724[0..7]`) holds both player and enemy mech data. Combat units 0-3 access story slots 0-3 directly via `C74B`. Combat units 12-15 access story slots 4-7 via `C363`, using a shifted base to compensate for the index remapping (`C363 = C724 - 8×125 + 0x27`). There are no separate "pools" — it's one contiguous array with two access patterns.

The mech data format (per `InceptionTools/Data/SaveGame.cs`): Name(15), Tonnage, CurrentArmour[11], CurrentStructure[8], CurrentActuators[4], EngineHeatSinks, CurrentAmmo[10], WalkMove, JumpMove, CritSlotData[47], MaxArmour[11], MaxStructure[8], MaxActuators[4], MaxAmmo[10], Unknown[4].

#### Combat Slot Mapping

The combat system uses a **different 24-slot array** that is populated from the story/unit system:

| Combat Slot | Source | Description |
|-------------|--------|-------------|
| 0-3 | Story primary units (aC724[0..3].b0079 → aC614[N]) | Player lance mechs |
| 4-11 | Generated enemies | Enemy mechs + infantry (8 slots) |
| 12-15 | Extended pool (garage/secondary) | Backup/garage mechs in combat |
| 16-23 | Unused/pool | Extended pool |

The ammo decrement logic reflects the remapping:
- Player units (combat slots 0-3, story slots 0-3): `DEC [0x2A02:C74B + unit_id × 125 + stage_counter]`
- Enemy mechs (combat slots 12-15, story slots 4-7): `DEC [0x2A02:C363 + unit_id × 125 + stage_counter]`
- Enemy infantry (combat slots 4-11): burst counter `INC [0x2A02:C5D4 + unit_id × 17]` capped at 4

#### Unit Creation and Assignment (`fn11B8_0D58`)

When a new unit is created (via BLD opcode `0xE9` CALL_ROOM_HANDLER → `fn11B8_0D58`):

1. Iterates unit slots 0-7 looking for an empty slot (`aC614[slot].b0000 == 0xFF`)
2. Assigns a new unit ID from incrementing counter `bD456`
3. Generates random attributes via `fn0800_19DD` (3 calls for b0001, b0005, b0007)
4. Derived attribute at offset +0x08 = `b0001 * 10` (halved if slot is 4+, i.e. secondary)
5. Initializes inventory bytes (`aC618[slot][0..6]`) with random bit values
6. Sets the linked-story-slot field (`aC614[slot].b000C`) to `0x08` (unassigned initially)
7. **Finds the first occupied story slot that has no unit assignment** (`aC724[story].b0079 == 0xFF`) and links them: `aC724[story].b0079 = unit_slot` and `aC614[unit].b000C = story_slot`

This means new units are automatically assigned to the first character without a primary unit.

#### REBUILD Mode (`fn1467_0002` with `wArg04 == 0`)

Called from `fn1CD3_0004` case `0x2E` (RESET_ROOM). Re-establishes all story→unit links:
1. For each occupied story slot, reads `b0079` and `b007A`
2. Sets the unit slot's `b000C` to point back to the story slot index
3. This ensures consistency after save/load or state transitions

When `wArg04 != 0` (CLEAR mode, case `0x27` TRIGGER_ACTION):
1. Sets all unit slot `b000C` fields to `0x08` (unassigned)
2. Sets all story slot `b0079` and `b007A` fields to `0xFF` (unassigned)
3. Effectively wipes all character→mech assignments for a fresh rebuild

#### Garage/Swap UI (`fn0FDC_15E6`)

This is the **mech bay/repair center UI** where the player can swap which mech is in which slot:

1. Collects all non-empty unit slots into a selection list (up to 8)
2. If 0 or 1 unit available: auto-selects (no UI needed)
3. If 2+ units: renders a scrollable list with unit names from `a01CC[]` template table
4. Player selects which unit slot to swap with the "incoming" type (passed as `wArg04`)
5. On selection: **exchanges unit type IDs** between the selected slot and the incoming type
6. If the selected unit was linked to a character (`b000C != 0x08`), clears old links
7. If incoming type was already owned by a character, updates the story slot's `b007A` (secondary) field
8. Returns the selected unit slot index

The `wArg04` parameter acts as both a filter and a swap source:
- If non-zero, `bC61F` is set to its value (filtering which type of unit to display)
- On swap, the selected unit's old type becomes the new "incoming" for continued swapping
- When the user exits (no swap made), the UI concludes and returns the current selection

#### Save File Layout

From `InceptionTools/Data/SaveGame.cs`, the save file stores:
- **8 infantry characters** (17 bytes each, offsets 0x01-0x88): party members 01-08
- **4 enemy infantry characters** (17 bytes each, offsets 0x89-0x110)
- **4 lance mechs** (125 bytes each, offsets 0x111-0x304): Lance01-Lance04
- **4 enemy mechs** (125 bytes each, offsets 0x305-0x4F8): EnemyMech01-EnemyMech04
- **Map visibility** (2048 bytes, offset 0x4F9)
- **Finance** (offset 0xD5D): C-Bills + 3 stock values
- **Flags** (offset 0xCF9): CitadelMissionFlag, etc.
- **Position** (offset 0xF45): PartyMapPositionX/Y

The 4 lance mechs (save offsets 0x111-0x288) load into story slots 0-3 (player characters). The 4 enemy mechs (save offsets 0x305-0x4F8) load into story slots 4-7 (enemy templates). Both are in the same `aC724[]` array at segment `0x3092`, stride 125. During combat, player mechs use story slots 0-3 via `C74B`, and enemy mechs use story slots 4-7 via `C363`. The save format does not persist secondary/garage mechs (unit slots 4-7 in `aC614[]`), suggesting those are transient and need to be re-acquired.

#### Key Design Insights

1. **Characters own mechs, not the reverse**: The story slot points to unit slots. A character can have 0, 1, or 2 units.
2. **Max player garage**: 8 unit slots total (4 characters × 2 each). No larger pool exists.
3. **Secondary mechs are a swap buffer**: The `fn0FDC_15E6` garage UI swaps type IDs between slots. Secondary slots (4-7) are essentially a holding area for mechs not currently in the primary lance.
4. **Single story slot array holds all mech data**: `aC724[0..7]` (segment `0x3092`, stride 125) stores both player (slots 0-3) and enemy template (slots 4-7) mech structs. Combat maps: units 0-3 → story slots 0-3 via `C74B`, units 12-15 → story slots 4-7 via `C363`. Enemy infantry (combat units 4-11) use a burst counter at `C5D4 + id×17` instead of full mech data.
5. **No mech bay building in code**: The REPAIR.BLD and GARAGE.BLD scripts call through to `fn0FDC_15E6` for mech swapping. There is no separate "mech storage" screen — the mech bay IS the unit slot selection UI.

### 17.11 Shop and Inventory System

The shop/purchase system routes through `fn1CD3_0004` dispatch cases 0x04-0x0C, called from BLD opcode 0xF5 (SHOP_DISPATCH).

#### Data Structures

```
struct Eq_80552 at segment 0x569E:
  C618[0..2]: 3 item type numbers currently displayed in shop window
  D314 (bD314): Selection cursor (0-2), selects which C618 slot
  D315 (bD315): Purchase success flag
  D316 (bD316): Discount/insurance flag for hospital
  D317 (bD317): Repair success flag
  D318 (bD318): Bulk quantity threshold (6 or 9, used in case 0x0B)
  D31A (bD31A): State variable (story slot index for unit operations)
  D370 (tD370): Credits low word (uint16)
  D372 (tD372): Credits high word (uint16)
  D374[]: Per-item-type player quantity array (uint32 stride 4)
  D376[]: Per-item-type player data array (uint16 stride 2)
```

#### Purchase Cases

**Case 0x05 — Single item buy (formula pricing)**
```
item_type = C618[bD314]
price = item_type * 125 + 75
if (tD372 >= 0 && (tD372 > 0 || price <= tD370)) {  // 32-bit credit check
    bD315 = 1
    C618[bD314] += 1        // increment "shop stock counter"? Or item type id slot?
    tD370 -= price
}
```
Line 384: `C618[bD314] += 1` — this increments the value in C618. If C618 stores item type numbers, incrementing would change the item type to the next one. This is unusual — might be a purchase count, or C618 might encode (type_id << N) | count.

**Case 0x07 — Bulk buy at 1 credit/unit**
```
quantity = fn1543_0CDE()  // digit input → uint32
if (quantity > tD370) quantity = tD370  // cap to credits
aD374[sel] += quantity    // player receives items
tD370 -= quantity          // player pays quantity credits
```

**Case 0x08 — Bulk sell at 1 credit/unit**
```
quantity = fn1543_0CDE()  // digit input → uint32
if (quantity > aD374[sel]) quantity = aD374[sel]  // cap to owned
aD374[sel] -= quantity     // player loses items
tD370 += quantity           // player receives quantity credits
```

#### fn1543_0CDE — Numeric Input Function

At segment `1543:0CDE`. Reads keypad input in a loop:
- Digits `'0'-'9'` (0x30-0x39): stored in an array at `es:0x0012` (max 7 digits)
- Backspace (0x08): deletes last digit from array
- Escape (0x1B): clears the entire array
- Enter (0x0D): exits input loop
- On exit: converts digit array to uint32 via `value = sum(digit[n] * 10^(n))`
- Returns 32-bit value in `ax` (low) / `dx` (high)

#### Price Sources by Case

| Case | Price Source | Unit Price |
|------|-------------|------------|
| 0x05 | `C618[bD314] * 125 + 75` | Variable by item type |
| 0x07 | User-entered value = quantity | 1 credit/unit |
| 0x08 | User-entered value = quantity | 1 credit/unit |
| 0x09 | Table at `ds:0x4F26/0x4F28` | Fixed per index |
| 0x0B | Table at `ds:0x4F44/0x4F46` | Fixed per index |

#### BLD Price Display Encoding

Prices in BLD narrative text use byte range `0xAF-0xBF` to encode numeric digits for display:
- `0xAF-0xB3`: encode values 40-44 (left column of numpad font)
- `0xB4-0xB8`: encode values 105-113 (right column, odd numbers)
- `0xBE`: 125, `0xBF`: 127
- Consecutive markers concatenate their rendered text (e.g., `[40][41]` = "4041")
- These are purely for DISPLAY in dialogue text; the actual purchase price uses formula/table

#### fn1631_1FDF — Repair/Heal Display Function

At segment `1631:1FDF`. Called from cases 0x09 and 0x0B after cost is checked. This is a UI display function only — it shows the repair/heal cost and current credits. The actual cost is pre-computed from tables before this function is called. Internally:
1. Sets up text rendering parameters
2. Renders cost header string
3. Calls `fn0800_28A2` (display helper, sets render mode to 0x0A/0x01)
4. Reads and displays credits (`tD370`/`tD372`)
5. Fills a 10-char buffer with spaces (formatting)
6. Returns

#### fn0FDC_13DE — Hospital/Unit Selection UI

At segment `0FDC:13DE`. Called from case 0x09 after cost is paid. Handles player unit selection for healing/repair:
1. Initializes 8 unit slot indices to 0xFFFF (invalid)
2. Iterates 8 unit slots (stride 0x11) checking `bC614[slot] == 0xFFFF` (non-empty)
3. Collects non-empty unit indices into a selection array
4. If only 1 unit: auto-selects it (writes to `bC621`/`bC622`)
5. If multiple: renders unit selection UI via `fn1E56_03F5`, reads choice from string table
6. Returns selected unit index

#### fn0FDC_15E6 — Garage/Swap Unit Selection UI

At segment `0FDC:15E6`. Called from case 0x0B for mech component purchase and from BLD scripts (GARAGE.BLD, REPAIR.BLD) for mech bay operations:
1. Collects all non-empty unit slots (0-7, stride 0x11)
2. Renders scrollable list of owned units
3. Allows player to select source and destination slots
4. Swaps unit type IDs between slots (effectively reassigning which mech is in which slot)
5. Acts as the mech bay interface — no separate "garage" screen exists

#### Stock Market (COMSTAR)

The stock market simulation handles 3 tickers (DefHes, NasDiv, BakPhar) via data fields at the 0x569E segment struct:
- `wD390`/`wD392`: Stock value arrays (stride 0x1A = 26 bytes per stock)
- `wD394`/`wD396`: Additional stock fields (alternate value sources)
- `0x4024`/`0x4056`: Alternate stock value storage
- `0x4564`/`0x4572`/`0x4596`/`0x45A4`: Source tables for stock values

**Case 0x2A (42) — Stock init**: Loops 8 stocks, copies cursor coordinates (`A44B`, `A44D`) as seed values into both `0x4024`/`0x4056` and `D390`/`D392` arrays. Sets type byte to 0x77.

**Case 0x2B (43) — Stock refresh**: Reads values from source tables at `0x4572`/`0x45A4`, copies to `0x4024`/`0x4056` and `D390`/`D392`. Sets `wD394`/`wD396` from `0x4564`/`0x4596`. Sets type byte to 0x70.

The market "fluctuation" is driven by per-visit randomization when entering COMSTAR — values are refreshed from source tables each visit. No continuous price simulation tick.

### 17.12 Player Interface System

#### Screen Layout

The game renders at **320×200 EGA** (VGA compatible mode 0x0E, 16 colors). The screen is divided vertically into two panels:

| Panel | Width | Description |
|-------|-------|-------------|
| Left panel | **80px** (`0x50`) | Location graphic + action menu |
| Right area | **240px** (320-80) | Main viewport (world map, local tiles, or text) |

The 80px left panel width is a hardcoded constant (`0x50`) used across 7+ source files for viewport clipping (`fn207F_24D7`), text layout (`fn1E56_0388`), sprite rendering (`fn1F3D_0086`), and screen buffer addressing (`fn207F_245C`/`fn207F_24D7`).

The EGA framebuffer uses a planar layout:
- **4 bit-planes** (Blue=0, Green=1, Red=2, Intensity=3)
- **40 bytes per plane per scanline** (320px / 8)
- **Odd/even row interleaving**: even scanlines in bank 0, odd scanlines in bank 1, offset by `0x2000` (8192 bytes)
- **Row-pair stride**: 80 bytes (0x50) per plane for two interleaved rows
- **Total framebuffer**: ~32768 bytes (0x8000) for 4 planes, used via VGA ports `0x3C4`/`0x3CE` for plane selection

#### Global UI Mode: `w4FBA` (at segment `0x569E` offset `0x00FD`, via selector at `0x53A0`)

Controls which rendering mode is active. Checked by 60+ code paths across 8 code segments. Modes 4-6 **do not exist** — only 0-3 are used.

| Value | Mode | Right Panel | Border Style | Char Stride | Font Blitter | Framebuffer |
|-------|------|-------------|--------------|-------------|--------------|-------------|
| `0` | World Map | Hex/overhead map | Full border (`fn207F_1CB8`) | 1× (2-byte) | `fn207F_2209` | `0x246C:0x244B` |
| `1` | Local Tiles | Building interior tiles | Full border | 2× (4-byte) | `fn207F_21A8` | `0x246C:0x244B` |
| `2` | Text Only | Cipher-decoded text | Text border (`fn207F_245C`) | 1× direct | `fn207F_2251` | `0xA000:0xAC00` |
| `3` | Building Name | Overlay text | Narrow border (`fn207F_1D3A`) | 8× (8-byte) | `fn207F_22A5` | `0x246C:0x244B` |

**Assignment**: The user presses keys `1`/`2`/`3`/`4` (ASCII 0x31-0x34), and the value is decremented by 0x31 to yield 0-3. This happens in `fn0D27_0044` (segment `0D27:0044`), the action menu handler.

**Set by**:
- **Key 1-4** → decrement by 0x31 → 0-3
- **BLD action menu**: select "Fight" → `w4FBA = 2` (combat text mode)
- **BLD opcode `0xB0`** (SET_OVERLAY): sets `w4FBA = 3` (building name)
- **Building entry `fn0FDC_0008`**: sets `w4FBA = 1` (local tiles) or `2` (text)
- **`fn0800_50C8` outer loop**: initializes to mode 0
- **Post-combat**: sets to mode 3

**Mode-specific rendering parameters** (from `fn1F3D_03EB` lookup tables at `a4FC4[][w4FBA]`, `a4FCC[][w4FBA]`, `a4FD4[][w4FBA]`):
- Mode 0: left panel width = 80px, row stride = 0x0140 (320 bytes), line advance by 320
- Mode 1: left panel width = 80px, double pixel width
- Mode 2: no left panel (fullscreen text), VGA buffer at 0xAC00, row stride = 40 text columns
- Mode 3: overlay with 0x0A00 stride (2560 = character row * 320 * 8), 8× pixel font

#### Border Drawing System

Dispatched by `fn1F3D_06C3()` (segment `1F3D:06C3`), called from 16+ locations across all major rendering paths. Uses `BTBORDER.TIL` tileset loaded into segment 1A58's tile cache.

**Three border variants:**

1. **Full border** (`fn207F_1CB8`, default for w4FBA=0,1): Draws a decorative frame around the entire 320×200 screen. Two sub-variants based on `tB764` flag:
   - `tB764 == 0`: Standard frame using 0x1A offset, 54-byte tiles at 100-row loop
   - `tB764 != 0`: Wide frame using 0x34 offset, 108-byte tiles at 50-row loop, with 4 side-panel sections

2. **Narrow border** (`fn207F_1D3A`, w4FBA=2): Draws only the left side border for text-only mode. Loops 200 rows:
   - Each row: writes 27 words (54 bytes) to VGA memory via `SEQ(al, al) & 0x0FF0` nibble expansion
   - Creates a narrower text area (approximately 27 character columns)

3. **Text overlay border** (`fn207F_245C`, w4FBA=3): Called with params `(0x00, 0xAC00, 0x00, 0xA000, 0x0D, 0x00, 0x1B, 200)` — renders a 13-column-wide text strip in the left panel at Y offset 0 for building name display

#### Main Game Loop (`fn0800_0000`, segment `0800:0000`)

The core rendering loop runs continuously while `w0152` (offset `0x0152`) is zero. The actual code order is: **Input → Key Dispatch → Timer → Economy → Animation+Render+Border → BLD**.

```
fn0800_0000(wArg04):
    fn207F_2FDC(0x30)         // Save segment context
    fn0800_48B7(0x0F)         // Init state machine (fn0800_1B8E sub-dispatch)
    
    while (w0152 == 0):
    
        // ══════════ PHASE 1: INPUT ══════════
        if (fn1F3D_002F() == 0):        // No key pending
            fn1F3D_0006(1)               // Software timer decrement
            continue                     // Skip to timer phase
        else:
            fn1F3D_0259()                // Read scancode → wLoc28
            
        // ══════════ PHASE 2: KEY DISPATCH ══════════
        fn0800_2A2B()                    // Wait-for-key loop (busy-wait if w3938==0)
        fn1E56_0D1D(scancode)            // Echo character to echo buffer
        fn1E56_0281(4)                   // Text mode init (set w4FBA mode)
        
        // Character processing loop (runs for all bytes in buffer up to 0x015A)
        for (i = 0; i < 0x015A; i++):
            if (key != 0x20):            // Not space
                fn0800_218F(key)          // Arrow key / char handler
                    └─ fn0800_1C12 → check disabled
                    └─ fn207F_158C/163B (vertical scroll)
                    └─ Loop 3 tiles: fn0800_2DA8 → fn207F_1DA8
                    └─ fn207F_17C5/16E3 (horizontal scroll)
                    └─ fn207F_1314(cursor) + fn207F_1DF8(tile index)
            fn0800_051B()                // Unit/map processing
                └─ fn0800_2A93 (world map tile render, 64 tiles)
                └─ fn207F_28EB (tile blit to framebuffer)
            if (wD55C != 0): break
        
        fn0800_231D(key)                 // Post-key handler
        if (key == 0x20):                // Space key = action menu
            fn0800_2C50()                // Action dispatch (long, 3000+ lines)
        
        // Visibility/fog update
        if (bD33D != 0 && bD346 == 0):
            Update fog grid at 0xCB0C/0xCAFC/0xCB1C (column-based iteration)
        else:
            Update world map visibility bits at 0xCB0C (fog of war)
        
        // ══════════ PHASE 3: TIMER ══════════
        Decrement: bD335 (encounter movement timer)
        Decrement: bD343/bD344/bD345 (encounter spawn cooldown, 3-byte cascade)
        Decrement: bD329 (UI timer), bD320/bD321/bD322 (various timers)
        Decrement: bD323 (economy/production timer, 3-day cycle)
        
        // ══════════ PHASE 4: ECONOMY ══════════
        When bD323 expires:
            fn0800_29F5() / fn1631_1FDF()   // Credit display update
            if (bD310 == 0):                 // World map active
                For 3 stock tickers:
                    fn207F_3D1C/3D44/3D6C    // Stock price update (RNG+coefficient)
            Decrement economy timers
        
        // ══════════ PHASE 5: ANIMATION + RENDER + BORDER ══════════
        fn0800_240B()                       // Tile animation page swap
            └─ w3988 guard (enabled when != 0)
            └─ w5800 cycles 0→1→2→0 (3 frames)
            └─ Source: (w5800 << 7) + 54658 (tile buffer page)
            └─ Copies 4100×3 tiles via fn207F_28A8 (128-byte memcpy per tile)
            └─ w4FBA==2: uses fn207F_0A9F instead (text-mode addressing)
        
        Counter 0x57FE += 1; wrap at 3:
        if (0x57FE wraps):  fn0800_24C2()    // Next animation frame
            └─ Iterates 8 unit slots (stride 0x1A)
            └─ Decrements bD399[n].counter
            └─ On expiry: copies coords from templates 0x4564/17814
            └─ On despawn (slot empty): cursor snap via fn0800_191B
        
        if (w014A != 0):                     // Screen refresh needed
            fn207F_1314(tA44D, tA44B)        // Set cursor position
            fn207F_18EF()                    // Screen refresh (tile grid render)
                └─ tB764 == 0x02: VGA text mode (3CE:0205+08)
                └─ tB764 == 0x00: halved dimensions
                └─ Default: full planar EGA
                └─ Draws 13×12 tile grid centered on cursor
                └─ fn207F_1AA8/1ACE/1AF4 (partial/full tile writes)
            fn1F3D_06C3()                    // Draw border (w4FBA dispatch)
                └─ w4FBA==2: fn207F_245C (text overlay)
                └─ w4FBA==3: fn207F_1D3A (narrow border)
                └─ Default: fn207F_1CB8 (full border, 0x32 rows × 0x6C bytes)
        
        // ══════════ PHASE 6: BLD/BUILDING ══════════
        if (w014A == 0 || w01A8 != 0):
            fn1CD3_17C6()                    // BLD processing (building text)
            if (w014A == 0):
                fn1E56_03F5(text_id, ds)      // Display cipher-decoded text
                fn1F3D_0259()                  // Wait for keypress
                fn1E56_0388()                  // Text cleanup (clear wD55C)
            
            fn0800_1A13(1)                    // State check (fn0800_2A2B inside)
            if (continue): fn0800_4DC7()      // Continue main menu
            else: w0152 = 1                   // Exit game loop
```

#### Screen Composition Pipeline

Rendering follows a **3-pass compositing model**, not a unified draw call. The passes occur in sequence each frame, but from different call sites:

1. **Pass 1 — Right panel content** (from `fn207F_18EF`, Phase 5 of main loop):
   - World map tiles (seg 1431, mode 0): `fn0800_2A93` renders 64 tiles (0x40) centered on cursor
   - Local tiles (seg 0FDC, mode 1): building interior tile map via BLD interpreter
   - Text (seg 1E56, mode 2): dialogue text via `fn1E56_03F5` to 0xAC00 buffer
   - `fn207F_18EF` reads tile properties from seg 246C `+0x7AD[tile_index]`, renders 13×12 tile grid
   - Tile rendering uses `fn207F_1AA8` (partial tile), `fn207F_1ACE` (full tile + left edge), `fn207F_1AF4` (full tile)
   - For w4FBA=0: world map visibility fog applied at 0xCB0C/0xCAFC/0xCB1C

2. **Pass 2 — Left panel border + graphic** (from `fn1F3D_06C3`, Phase 5):
   - Full border: `fn207F_1CB8` copies 0x32 rows × 0x6C bytes from tile buffer. 4-plane variant:
     - tB764==0: 100 rows × 54 bytes (0x36)
     - tB764!=0: 50 rows × 108 bytes (0x6C), 4 side-panel sections (8084/16276/24468 plane strides)
   - Narrow border: `fn207F_1D3A` writes 200 rows × 27 words via `SEQ(al,al) & 0x0FF0`
   - Text overlay: `fn207F_245C` calls `fn207F_24D7` case 0x02 (40-column text clip)
   - Location graphic/animation in upper-left rendered via segment 135D DISP function

3. **Pass 3 — Text/menu overlay** (from `fn1E56_03F5` via Phase 6 BLD processing):
   - Action menu items and dialogue text rendered on top of existing content
   - Uses VGA write mode 2 for pixel writing (out 0x03CE/0x03C4 register pairs)
   - Character widths depend on w4FBA mode (1×, 2×, or 8× pixel stride)
   - Positioned relative to left panel's character grid (10 character columns = 80px)

#### Viewport Clipping System

Two functions in segment 207F manage rendering bounds:

- **`fn207F_1B80(left, top, width, height)`**: Configures viewport dimensions. Sets internal registers (`tB78E/tB790` = dest base, `tB792/tB794` = source X/Y, `tB79A/tB79C` = clip width/height).
- **`fn207F_1A97()`**: Applies configured clipping to coordinates. Clips source and destination to viewport bounds.

The core blitter `fn207F_24D7()` handles EGA framebuffer copying with 4 cases based on the `tB764` **pixel format flag** at seg 246C's rendering config struct:

| `tB764` | Mode | Width | Framebuffer | Stride | Details |
|---------|------|-------|-------------|--------|---------|
| `0x00` | CGA/Herc | 0x50 (80) | `0xB800` | 0x28 (40) | 2-bit pixels, odd/even 0x2000 plan shift, parity interleave |
| `0x02` | VGA text | 0x28 (40) | `0xAC00`→`0xA000` | 0x28 (40) | Linear, `out 0x03CE, 0x0105` write mode 2, no planar |
| `0x01` | EGA planar | 0xA0 (160) | `0xA000` | 0x28 (40) | 4-bit planar interleave (bx = row & 0x03), plane shift |
| default | Full frame | 0x140 (320) | `0xA000` | 0x0140 | Linear full-width copy, no planar interleave |

**Case 0x00 (left panel, 80px):** Clips width to max 0x50. Uses odd/even row interleaving: if `(row & 1) != 0`, address += 0x2000 (plane offset). Copies `clip_width/2` words per row via `memcpy`. Row-pair stride = 0x50 (80 bytes).

**Case 0x02 (text mode, 40 columns):** Clips width to max 0x28. Uses VGA write mode 2 (`out 0x03CE, 0x0105`). Copies `clip_width` bytes per row linearly via `memcpy`. Row stride = 0x28. No planar interleave.

**Case 0x01 (EGAP, 160px):** Clips width to max 0xA0. Uses 4-bit planar interleave where `bx = row & 0x03` selects plane. Same parity-based odd-row offset as case 0x00 but with 4-way (not 2-way) plane cycling.

**Default (320px full):** Clips width to max 0x140. Linear copy, `clip_width/2` words per row. Row stride = 0x0140. No planar interleave.

**VGA Pixel Writer (`fn207F_275C`):** Writes pixel data with 4 sub-modes based on `tB764`:
- `tB764==0x00`: CGA mode, writes to `0xB800`. 2-byte stride.
- `tB764==0x02`: VGA planar, writes to `0xA000`. 4-pass bit plane sequencing via `0x03C4` (ports 0x0102/0x0202/0x0402/0x0802). 8 pixels/byte, 1 bit/plane.
- `tB764==0x03`: VGA mode X, writes to `0xA000` with stride `0x0A00`. Nibble-packed (4-bit pixel replication `SEQ(al,al) & 0x0FF0`).
- default: `0xB800` text mode, 2-pass with 4-attribute bytes per character cell.

**`fn207F_245C` (text overlay wrapper):** Sets up blitter context registers (`tB78A-B79C`) with pixel-format-dependent scaling:
- `tB764==0x02`: direct params (no shift)
- `tB764==0x00`: params ×2
- `tB764==0x01`: params ×4
- `tB764==0x03`: params ×8
- Then calls `fn207F_24D7(0x246C)` to execute the blit.

#### Cursor System (`tA44B`/`tA44D`)

- **`tA44B`** (at segment `0x569E` offset `+0x0131`): Cursor X coordinate. Low byte = pixel column (0-39 in 8px character units), high byte = sub-pixel / grid flags.
- **`tA44D`** (at offset `+0x012F`): Cursor Y coordinate. Same format: low byte = row (0-24), high byte = flags.
- **Page flip**: `fn1E56_021D()` resets cursor position after page transitions.
- **Coordinate packing** (used in combat targeting): X = `(val & 0xF00) >> 1 | (val & 0x7F)`, Y = `(val & 0xF000) >> 5 | (val & 0x7F)`. Masking with `0xF7F`/`0xF07F` for grid/sub-pixel precision.

#### Keyboard/Menu Input (`fn1F3D_0259`)

Key scanning at segment `1F3D:0259`. Returns extended scan codes for arrow keys (combined with `~` bitwise NOT in the decompiled code):

| Key | Code | Handler |
|-----|------|---------|
| Up/Home/PgUp | `~0x47/48/49` | `fn207F_158C()` — cursor up/world scroll |
| Down/End/PgDn | `~0x4F/50/4E` | `fn207F_163B()` — cursor down/world scroll |
| Left | `~0x4C` | `fn207F_16E3()` — cursor left |
| Right | `~0x4D` | `fn207F_17C5()` — cursor right |
| Space | `0x20` | `fn0800_2C50()` — action/select menu |
| Enter | `0x0D` | Confirms selection |

The arrow key handler (`fn0800_218F`) loops 3 times over world tile entries at offset 0x09F3, rendering tiles beneath the cursor via `fn0800_2DA8()` and `fn207F_1DA8()`.

#### Animation System (segment 135D)

4-function dispatch for left panel location graphics:

| Function | Offset | Purpose |
|----------|--------|---------|
| DISP | `fn135D_0004+0x0000` | Display animation frame in left panel |
| LOAD | `+0x0010` | Load animation data from ANM file |
| INIT | `+0x0020` | Initialize animation sequence |
| CLEAR | `+0x0030` | Clear animation state |

Called from BLD building entry (`fn0FDC_0008`) to render the location portrait/building image in the upper-left panel area. The animation frame renders into the 80px wide clip region at the top of the left panel.

#### Building Interior Tiles (w4FBA=1)

When entering a building:
1. `fn0FDC_0008` loads BLD data by index from segment `3000:CC30` filename list
2. `fn0FDC_01C0` bytecode interpreter runs, starting with room description
3. Tile map renders into the right 240px panel via `fn0800_13F4()` / segment 0FDC
4. Left panel shows building image (via segment 135D) and action menu

#### World Map (w4FBA=0)

1. `fn1431_0091()` renders map tiles into the right panel
2. Scroll/viewport operations compensate by `-0x50` to align pixel X=80 with tile offset 0
3. `fn207F_1DF8()` calculates cursor tile position from `tA44B`/`tA44D`:
   - Tile X = `(tA44B >> 1 & 0x07) + 2`
   - Tile Y = `(tA44D >> 1 & 0x07) + 2`
   - Tile index = `tileX + tileY * 24` (map grid is 24 tiles wide)
4. 3 tiles beneath cursor rendered each frame via the arrow key handler

#### Image Rendering Pipeline

The game uses two image formats:

**1. Nibble-packed format (internal working buffer)**
```
[byte 0] = [pixel0(4bit) | pixel1(4bit)]
[byte 1] = [pixel2(4bit) | pixel3(4bit)]
...
```
Each byte stores 2 pixels (4-bit EGA color index 0-15). For a full 320×200 screen: 32000 bytes.

**2. EGA Planar format (VGA framebuffer)**
```
Scanline Y (even) at A000:0000 + (Y/2)*40 + plane*0x2000  (40 bytes)
Scanline Y (odd)  at A000:2000 + (Y/2)*40 + plane*0x2000   (40 bytes)
```
4 bit-planes × 40 bytes/scanline = 160 bytes per row-pair. Plane stride = 0x2000 (8192).

**Conversion path** (on-the-fly via VGA write mode 2):
```
Nibble-packed (32KB) → VGA write mode 2 → EGA planar framebuffer
  fn207F_24D7 case 0x00: writes to 80px left panel clip region (planar interleave)
  fn207F_24D7 case 0x02: writes to 40-column text region (linear, no planar)
```

**The C# extractor `Write2ModeConverter`** (in `InceptionTools/Graphics/EGA.cs`) converts nibble-packed (2px/byte) to byte-per-pixel (1px/byte, 64000 bytes). This is for modern display only — the game operates on the nibble-packed format internally and uses VGA hardware registers (`0x03C4`/`0x03CE`) to expand to planar.

**Asset loading pipeline:**
```
CMP/ICN file (header: 2-byte LE size + 1-byte format)
  → RLE decompress (Format01 row-major / Format02 column-major)
    → nibble-packed (32KB for 320×200, 2px/byte)
      → fn207F_28A8 (128-byte memcpy for tile animation)
      → fn207F_24D7 case 0x00/0x02/0x01/default (viewport blit to A000/B800)
      → fn207F_275C (VGA pixel writer with plane sequencing)
```

---

## 18. NPC World-Map Movement Engine

### 18.1 Overview

The game drives autonomous NPC movement through `fn0800_24C2` (segment `0800:24C2`), called every 3rd frame from the main game loop (`fn0800_0000`). It handles **8 story character slots** (indices 0-7) — named NPCs like Rick Atlas, Rex Pearce, and other plot-relevant characters that walk around the game world.

Generic background NPCs (the ones walking around the training center compound) are part of the **tile animation system** (`fn0800_240B`) — they are drawn as animated tile sprites, not as independently moving units.

### 18.2 Data Structures

| Address | Size | Field | Description |
|---------|------|-------|-------------|
| `seg 0x538A : 0xD398[slot]` | 1 byte × 8 | Direction/state nibble | High nibble = BLD index (which building NPC is in). Low nibble = facing direction (0-7). Packed as `(bld_idx << 4) \| direction` |
| `seg 0x538A : 0xD399[slot]` | 1 byte × 8 | Movement delay timer | Counts down each frame. When 0, NPC takes a step. Initialized to specific values per slot at game start. Reset to `~0x00` (0xFF) when slot 0 (`bD339`) triggers |
| `0x4024[slot * 2]` | word × 8 | Destination X | Target X coordinate NPC is walking toward |
| `0x4056[slot * 2]` | word × 8 | Destination Y | Target Y coordinate NPC is walking toward |
| `0x4004[(slot+0x10) * 2]` | word × 8 | Current X | NPC's actual X position on the map |
| `0x4036[(slot+0x10) * 2]` | word × 8 | Current Y | NPC's actual Y position on the map |
| `seg 0x53CA : 0x4564[idx * 2]` | word × 8 | Waypoint X table | 8 destination X coordinates indexed by direction (0-7) |
| `seg 0x53CC : 0x57D6[idx * 2]` | word × 8 | Waypoint Y table | 8 destination Y coordinates indexed by direction (0-7) |

### 18.3 Movement Algorithm (`fn0800_24C2`)

```
For each NPC slot (0..7):
  1. Check if NPC is active (non-zero at slot offset `0x1A` in story state)
  2. Decrement movement timer `bD399[slot]`
  3. IF timer just reached 0:
     a. Read direction nibble from `0xD398[slot] >> 4`
     b. Use direction as index into waypoint tables:
        Destination X = `0x4564[direction * 2]`
        Destination Y = `0x57D6[direction * 2]`
        
  4. IF NPC active (slot's `~0x2C66` offset != 0):
     a. Save current cursor (A44B/A44D)
     b. Call `fn0800_191B` to adjust cursor toward destination
     c. Compare adjusted cursor X with NPC's current X (from `0x4004[(slot+0x10)*2]`)
     d. Try moving toward destination by adjusting cursor + calling `fn0800_191B`
        in each axis (X first, then Y)
     e. Call `fn1631_0006` (LoS tile-step pathfinding) to validate the move
     f. Update position arrays:
        `0x4004[(slot+0x10)*2]` = new X
        `0x4036[(slot+0x10)*2]` = new Y
     g. Update direction-relative sprite offset for rendering
        
  5. IF NPC reached destination (current X/Y == waypoint X/Y):
     a. Generate new random direction: `RNG() & 0x1F`
     b. Extract low 3 bits as new direction: `al_407 = random & 0x07`
     c. Update `0xD398[slot]`:
        high nibble = old high nibble (BLD index preserved)
        low nibble = new direction
     d. Look up new waypoint from tables at `0x4564[dir*2]` / `0x57D6[dir*2]`
     e. Reset destination in story state at `54164[slot*0x1A]`/`54166[slot*0x1A]`
     f. Clear current position to 0 (NPC vanishes until next step)
        
  6. Restore original cursor (A44B/A44D)
```

### 18.4 Building Entry / NPC Detection

When the player enters a building, code at `fn0FDC` (~line 1750) checks which NPCs are inside:

1. For each NPC slot (0..7), checks `bD399[slot] != 0` as an activity flag
2. Reads `0xD398[slot] >> 4 & 0x07` to get the NPC's BLD index
3. If BLD index matches the building being entered:
   - Marks NPC as present in this building
   - Counts total matching NPCs
4. If any NPCs present:
   - Loads NPC dialogue text from BLD strings
   - If multiple NPCs, presents selection menu
   - Renders dialogue via `fn1E56_03F5`
5. Special cases:
   - If `bD339 != 0 && current_dir == 7 && selection == 0 && some_flag != 0`:
     Sets `bD33A = 1`, resets `bD399[slot] = 0` (story trigger)
   - If world map not active (`bD310 == 0`): loads additional room-specific text

### 18.5 Key Observations

- **No follow-player AI**: NPCs do not track or follow the player. They wander between fixed waypoints.
- **No A* pathfinding**: Movement uses `fn1631_0006` (LoS tile-step, 8-direction delta tables), which only checks immediate tile blocking. NPCs can get stuck on obstacles.
- **Building warping**: When NPCs enter buildings (BLD index matches), their world-map position clears to 0 and they "appear" inside via the BLD dialogue system.
- **Movement granularity**: Position coordinates use sub-tile precision (similar to cursor at `0xA44B`/`0xA44D` with sub-pixel flags). Movement step size is controlled by `fn0800_191B` which wraps coordinates in ranges.
- **Timer granularity**: `bD399` counts game frames (every 3rd frame = ~5 FPS at 60fps). Different slots may have different initial timer values, causing desynchronized movement.

### 18.6 Known Gaps

1. How NPC initial positions and BLD indices are assigned at game start
2. Exact waypoint table contents (8 coordinate pairs × direction)
3. How `fn0800_191B` cursor adjustment maps to grid-aligned NPC positions
4. Interaction between NPC movement and combat initialization (`fn183B_000A`)

---

### 17.13 Known Gaps

1. Exact BLD index translation table at `0x4602` — not fully decoded
2. How MAP1 terrain tiles update to MAP11 after attack — likely a second tile property table gated by `b0057`
3. ~~The `0xC0` prefix combined with specific sub-bytes (`c0 e8`, `c0 da`, etc.) — exact semantic at bytecode level needs further investigation~~ **RESOLVED**: `0xC0` is a pure no-op/structural separator. The byte following `0xC0` is the actual opcode (0xE4-0xFF). All `c0 xx` patterns are simply `C0` (skipped) + actual opcode. See CONTEXT.md §4 (BLD Bytecode Format) for details.
4. Animation tile selection in seg 135D — how individual animation frames map to specific CMP/ICN tiles
5. `tB764 mode 0x03` (VGA mode X) — used in combat/stat screens? Stride 0x0A00 is unusual and only referenced in `fn207F_275C`
6. `w3988` animation guard — what sets this flag and when does animation pause?
7. `w37FE` text mode flag — read in many places but exact semantics not fully traced
8. Combat/stat screen rendering — confirmed to use w4FBA 0+2+3 combos rather than modes 4-6, but exact screen layout for stats/combat UI not mapped

---

## 19. AMMO LIFECYCLE & ITEM-TO-UNIT BRIDGE

### Corrected Ammo Offsets

The mech struct at `C724` (0x7D stride per slot) stores ammo at:

| Field | Struct Offset | Code Offset | Width | Description |
|-------|--------------|-------------|-------|-------------|
| CurrentAmmo | +0x27 | `C74B` | 10 bytes | Per-weapon-slot ammo count (one per weapon, 0xFF = energy/infinite) |
| MaxAmmo | +0x6B | `C78F` | 10 bytes | Maximum capacity from mech template |

**Correction vs earlier documentation**: Struct table had +0x29/+0x6F; actual code confirms +0x27/+0x6B.

### Three Independent Systems

The game uses **three completely separate subsystems** for tracking items and ammo:

#### System A: `aD374` (Global Player Inventory, `DS:0xD374`)
- Tracks **equipment items** (infantry weapons, armor suits, etc.) owned by the player
- Per-item-type quantity array: `ui32 aD374[]` (stride 4 bytes)
- Per-item-type data array: `uint16 aD376[]` (stride 2 bytes)
- Modified by fn1CD3_0004 shop cases:
  - 0x06 (SHOW_PLAYER_ITEMS) — reads aD374 for display
  - 0x07 (BUY_ITEM_BULK) — `aD374[sel] += qty`, `tD370 -= qty` (1 cr/unit)
  - 0x08 (SELL_ITEM_BULK) — `aD374[sel] -= qty`, `tD370 += qty`
- 32-bit credits at `tD370`/`tD372` (low/high words)

#### System B: Per-Unit Equip Slots (`C61D`/`C61E`, `DS:0xC61D`)
- Two single-byte counters per unit slot (8 units)
- `C61D[slot]` = equip slot 5 (case 0x0F EQUIP_SLOT5, cost 500 cr)
- `C61E[slot]` = equip slot 6 (case 0x15 EQUIP_SLOT6, cost 500 cr)
- Flag bits at `C624[slot]`: bit 0 = slot 5 populated, bit 1 = slot 6 populated
- Purpose: track which equipment/upgrade slots a unit has purchased
- **NOT connected to ammo bins or aD374**

#### System C: Per-Mech Ammo Bins (`C724+0x27..0x32`, 10 bytes per slot)
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

## 20. WORLD MAP SYSTEM

The game has two distinct map layers: the **overworld map** (Pacifica island continent) and **local maps** (indoor/city areas from .MTP files). The local maps are documented in sections 1 and 6 of CONTEXT.md. This section covers the overworld.

### 20.1 Tile Buffer

| Field | Value |
|-------|-------|
| **Segment:Offset** | `0x246C:0x244B` |
| **Linear address** | `0x26B0B` (Spice86 memory dump) |
| **Size** | 4096 bytes |
| **Grid dimensions** | 64 × 64 tiles (1 byte per tile) |
| **Unique tile IDs (runtime)** | 93 |
| **Value range** | 0x00 – 0xFF |
| **Tile source** | MAP.ICN (~94 tiles, tile ID 0-93 direct index; values >93 via variants/other ICNs) |

At runtime, the tile buffer segment is loaded from the pointer at `DS:[0x53C6h]`. In the captured memory dump this resolves to segment `0xF187` (linear `0xF3CBB`). However, the actual tile buffer data used for display is at segment `0x246C:0x244B`.

### 20.2 Data Flow

```
EXE embedded initial data (76 unique tile values, base template)
     │
fn0800_48B7 (state machine init, clears tile buffer)
     │
fn0800_1AFD (copies from source 0x246C:0x42F6 → display 0x246C:0x244B)
     │
Game state overrides:
  ├─ Visibility grid (DS:[0x538Ah]→0xCB0C, 2048 bytes, 128×128 bit-packed)
  ├─ Story progression (e.g., Citadel destruction swaps tiles)
  └─ Encounter placement (fn183B_27C9 → viewport arrays)
     │
fn0800_051B (called every frame from main loop)
     │
fn0800_2A93 (renderer: reads 64 tiles from buffer → 8×8 tile viewport)
```

### 20.3 Visibility Grid

- **Address**: `DS:[0x538Ah]→0xCB0C` (also persisted at `0x3092:0x04F9` in save files)
- **Format**: 2048 bytes, bit-packed 128×128 grid
- **Each world map tile (64×64)**: has 2×2 visibility bits
- **Effect**: Controls which terrain/city tiles are revealed

### 20.4 Viewport Arrays (segment from DS:[0x538Ah])

| Offset | Size | Content |
|--------|------|---------|
| `0xD457` | 64 | Per-viewport-tile data (tile IDs with packed flags) |
| `0xD497` | 64 | Packed position/screen X data (viewport tile X + cursor offset) |
| `0xD4D7` | 64 | Y-component of world coordinates per tile |
| `0xD517` | 64 | X-component of world coordinates per tile |
| `0xD557` | 2 | Pointer/counter: next slot index into above arrays |

### 20.5 Coordinate System

```
Tile X = (wA44B & 0x7F) >> 1   → range 0-63
Tile Y = (wA44D & 0x7F) >> 1   → range 0-63
Tile index = Y * 64 + X         → offset in 4096-byte tile buffer
```

Save game coordinates at offsets `0x0F45`/`0x0F47` encode sub-tile position in the low 7 bits.

### 20.6 Terrain Composition (from runtime tile buffer)

| Category | Tile Count | Percentage |
|----------|-----------:|-----------:|
| Water (tile 0x00) | 727 | 17.7% |
| Land/ground (various) | 2,027 | 49.5% |
| City/building | 1,080 | 26.4% |
| Roads | 262 | 6.4% |

### 20.7 Identified Points of Interest

| # | Location | Center (X,Y) | Likely Identity |
|---|----------|-------------|-----------------|
| 1 | Training Center area | (26, 5) | Citadel + Training (MAP1) |
| 2 | Main city hub | (28, 10) | Barracks, shops, ComStar (MAP2) |
| 3 | East-central settlement | (32, 18) | Town cluster (MAP3/4 type) |
| 4 | Northwest settlement | (10, 10) | Small outpost |
| 5 | Southeast island | (55, 8) | Island town, cache |
| 6 | West coast town | (9, 21) | Outpost |
| 7 | Central village | (42, 25) | Outpost |
| 8-10 | Southern coastal towns | (5,49),(5,54),(5,59) | Row of towns |
| 11 | Large southern city | (33, 49) | Major southern settlement |

### 20.8 Key Functions

| Function | Address | Role |
|----------|---------|------|
| `fn0800_2A93` | `0800:2A93` | World map tile renderer — reads 64 tiles, positions on screen |
| `fn0800_48B7` | `0800:48B7` | State machine init — clears tile buffer, sets up source pointers |
| `fn0800_1AFD` | `0800:1AFD` | Copies tile data from source (`0x246C:0x42F6`) to display buffer |
| `fn0800_051B` | `0800:051B` | Main unit processing — calls tile renderer, initializes unit data |
| `fn183B_27C9` | `183B:27C9` | Writes encounter placement to viewport arrays `0xD457`/`0xD497`/`0xD4D7`/`0xD517` |
| `fn207F:28EB` | `207F:28EB` | Tile blit to framebuffer |
| `fn207F:23EC` | `207F:23EC` | Block memory copy (used by fn0800_1AFD) |

### 20.9 Is the World Map Procedural?

**Partially.**

- The **base terrain** (water vs land, ground types, road network) is **pre-defined** in the EXE's initial data at the tile buffer address. 76 unique tile values form the template.
- **82.5% of positions** (3,378/4,096) are modified at runtime by game state:
  - Visibility grid (`0xCB0C`) controls what tiles are "explored"
  - Story progression modifies building tiles (e.g., destroyed Citadel after attack)
  - Encounter placement writes specific tile values into viewport arrays
- ~17 new tile types appear at runtime beyond the EXE's 76 base values, through game state modifications

**Conclusion**: The world map is a **static template modified by dynamic game state**. No separate world map file exists because the data is embedded directly in the executable and modified in-place.

### 20.10 Tile ID Mapping

The tile buffer values (0-255, with 93 unique at runtime) directly index MAP.ICN's tile graphics. Values >93 have property entries at `0x246C:0x7AD` (256-entry table), suggesting the game supports additional tile types beyond the base 94. These may come from:
- Palette manipulation / re-coloring of base tiles
- Additional tiles loaded from ANIMATE.ICN, BTTLTECH.ICN, or other ICN files

**For Godot reconstruction**: Replicate the 64×64 tile grid as a TileMap (or 2D array), load MAP.ICN tiles as atlas, implement cursor→tile coordinate mapping, and add the 128×128 visibility grid as Fog of War.
