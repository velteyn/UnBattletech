# MEMORY MAP: BattleTech — The Crescent Hawk's Inception (1988)

> **Binary:** `UNBTECH.EXE` (unpacked from `BTECH.EXE`)
> **Platform:** MS-DOS 16-bit Real Mode (MZ executable)
> **Compiler:** Microsoft C 5.0
> **Entry Point:** `19EF:2D82` (linear `0x1CC72`)
> **Total Code Segments:** ~25 (spanning linear 0x0000–0xF100)
> **Framebuffer:** `A000:0000` (EGA planar, 320×200)

---

## TABLE OF CONTENTS

1. [CODE SEGMENT OVERVIEW](#1-code-segment-overview)
2. [MAIN GAME LOOP](#2-main-game-loop)
3. [STORY STATE SYSTEM](#3-story-state-system)
4. [BLD INTERPRETER SYSTEM](#4-bld-interpreter-system)
5. [COMBAT SYSTEM](#5-combat-system)
6. [RENDERING SYSTEM](#6-rendering-system)
7. [ECONOMY & INVENTORY](#7-economy--inventory)
8. [UI / PLAYER INTERFACE](#8-ui--player-interface)
9. [SAVE FILE LAYOUT](#9-save-file-layout)
10. [ANIMATION SYSTEM](#10-animation-system)
11. [ENEMY / ENCOUNTER SYSTEM](#11-enemy--encounter-system)
12. [DATA TABLES](#12-data-tables)
13. [RNG IMPLEMENTATION](#13-rng-implementation)
14. [SEGMENT POINTERS REGISTRY](#14-segment-pointers-registry)
15. [UNMAPPED / GAPS](#15-unmapped--gaps)

---

## 1. CODE SEGMENT OVERVIEW

### 1.1 Segment Map

| Segment | Linear Base | Linear Range | Size | Description | Spice86 File |
|---------|-------------|--------------|------|-------------|-------------|
| `0000` (cs1) | `0x00000` | `0x0000C–0x0F565` | ~62KB | Primary code segment: game loop, rendering preludes, 2D6 roll, coordinate utilities, interrupt glue | GeneratedCode1.cs, Gen4-6, Gen8-10 |
| `0170` (cs2) | `0x01700` | `0x01700–0x067C8` | ~20KB | Arrow keys, world map render, SPACE menu, animation, tile render | GeneratedCode2.cs, Gen3.cs |
| `0697` (cs3) | `0x06970` | `0x0697A–0x069B4` | ~0.2KB | Small segment (2 functions: 000A, 0044) | GeneratedCode.cs |
| `071B` (cs4) | `0x071B0` | `0x07D45–0x07E3F` | ~0.4KB | Small segment (2 functions: 0B95, 0C8F) | GeneratedCode.cs |
| `094C` (cs5) | `0x094C0` | `0x094C8–0x0AC79` | ~6KB | **BLD bytecode interpreter** (`fn0FDC_0008`, `fn0FDC_01C0`, `fn0FDC_05F7`, `fn0FDC_1D30`) | GeneratedCode7.cs |
| `0DD7` (cs6) | `0x0DD70` | `0x0E618` | ~0.4KB | 1 function (`split_0000_E7E5`) | GeneratedCode.cs |
| `0FA1` (cs7) | `0x0FA10` | `0x0FA10`+ | ~0.3KB | 3 functions (including `fn0FA1_1FDF`) | GeneratedCode.cs |
| `1000` (cs8) | `0x10000` | `0x105C5–0x14672` | ~16KB | **Main combat segment**: LoS, AI, targeting, combat loop, encounter init | GeneratedCode11–14, 16–18, 20–22 |
| `1643` (cs9) | `0x16430` | — | ~3KB | Room handler dispatch | GeneratedCode15.cs |
| `17C6` (cs10) | `0x17C60` | — | ~3KB | **Text renderer** (`fn1E56_03F5`), scancode remapper, jump indexed | GeneratedCode.cs |
| `18AD` (cs11) | `0x18AD0` | — | ~3KB | 14 functions: border drawing, room handlers | GeneratedCode.cs |
| `1935` (cs12) | `0x19350` | — | ~2KB | **Combat fog/setup** (8 functions) | GeneratedCode.cs |
| `19BB` (cs13) | `0x19BB0` | — | ~0.5KB | **Interrupt handlers**: timer (INT 8) + misc | GeneratedCode.cs |
| `19EF` (cs14) | `0x19EF0` | `0x1A861–0x1BCE8` | ~12KB | **Combat movement/RNG/fire/rendering** (80+ functions) | GeneratedCode19.cs |
| `2000` (cs15) | `0x20000` | — | — | Data/code (6 functions listed) | GeneratedCode.cs |
| `204B` | — | — | — | SoundBlaster/PC Speaker + timer interrupt handler | UNBTECH_204B.* |
| `207F` | — | — | — | **Utility/Helper**: blitter, cursor, border, font, VGA regs | UNBTECH_207F.* |
| `246C` | — | — | — | Tile properties (`+0x7AD`), pixel format flag (`tB764`), tile buffer | UNBTECH_246C.* |
| `24D7` (cs16) | `0x24D70` | — | — | 1 entry function | GeneratedCode23.cs |
| `2FE8` | — | — | — | Data segment | UNBTECH_2FE8.* |
| `3056/3058/305B` | — | — | — | Data segments | UNBTECH_3056.* |
| `3092` | — | — | — | **Mech story slot array** (`aC724[0..7]`, stride 125) + world map visibility | UNBTECH_3092.* |
| `3EDB` | — | — | — | Story text strings, RNG state alias | UNBTECH_3EDB_0000.* |
| `C000` (cs17) | `0xC0000` | — | — | Interrupt handlers (0x1F, 0x43) | GeneratedCode.cs |
| `F000` (cs18) | `0xF0000` | — | — | **BIOS interrupt handlers** (int 8, 9, C, D, F, 10–13, 15, 16, 1A, 1C, 20, 21, 25, 26, 28, 2F, 33, 72–74) | GeneratedCode.cs |
| `F100` (cs19) | `0xF1000` | — | — | INT 0x67 handler | GeneratedCode.cs |

### 1.2 Spice86 ↔ Reko Segment Mapping

> **Key:** Spice86 captures runtime segment values (after DOS relocation). Reko assigns EXE-native segment numbers. The relationship is: **Reko = Spice86 + 0x690** (or equivalently, Spice86 = Reko − 0x690). This offset is consistent across 12+ matching code segments. All offsets within segments are identical between both representations.

| Spice86 cs# | Spice86 Seg | Reko Seg | Description |
|-------------|-------------|----------|-------------|
| cs1 | `0x000` | — | Primary code (0000) |
| cs2 | `0x170` | `0x800` | Main loop, world map, SPACE menu |
| cs3 | `0x697` | `0xD27` | Action menu handler |
| cs4 | `0x71B` | `0xDAB` | Encounter population |
| cs5 | `0x94C` | `0xFDC` | **BLD bytecode interpreter** |
| cs6 | `0xDD7` | `0x1467` | Trigger action |
| cs7 | `0xFA1` | `0x1631` | Story progression |
| cs8 | `0x1000` | — | Combat (LoS, AI, targeting) |
| cs9 | `0x1643` | `0x1CD3` | Room/dispatcher (47-case) |
| cs10 | `0x17C6` | `0x1E56` | Text renderer |
| cs14 | `0x19EF` | `0x207F` | Combat movement/RNG + utility |

### 1.3 Reko Segment Files

| Reko File | Corresponding EXE Segment | Description |
|-----------|--------------------------|-------------|
| `UNBTECH_0800.*` | `0800` | Core game logic (main loop, SPACE menu, movement, tile animation, economy) |
| `UNBTECH_0D27.*` | `0D27` | Action menu handler |
| `UNBTECH_0DAB.*` | `0DAB` | Encounter population (enemy spawn) |
| `UNBTECH_0FDC.*` | `0FDC` | BLD bytecode interpreter |
| `UNBTECH_11B8.*` | `11B8` | Room handler dispatch, viewport/tile display |
| `UNBTECH_135D.*` | `135D` | Animation dispatch (DISP/LOAD/INIT/CLEAR) |
| `UNBTECH_1431.*` | `1431` | Star map, map tile render |
| `UNBTECH_1467.*` | `1467` | Trigger action / rebuild mode |
| `UNBTECH_1543.*` | `1543` | Numeric input, utility functions |
| `UNBTECH_1631.*` | `1631` | Story progression, story property handler, LoS stepping |
| `UNBTECH_183B.*` | `183B` | Graphics init, encounter initiator, fog clearing |
| `UNBTECH_1AE8.*` | `1AE8` | Combat narrative handler |
| `UNBTECH_1CD3.*` | `1CD3` | Room/building dispatcher (47-case switch) |
| `UNBTECH_1E56.*` | `1E56` | Text renderer, cipher decoder, scancode remapping |
| `UNBTECH_1F3D.*` | `1F3D` | Border dispatcher, key input, sprite rendering |
| `UNBTECH_1FC5.*` | `1FC5` | (Border dispatching subsegment) |
| `UNBTECH_204B.*` | `204B` | Timer (INT 8) & Sound (PC Speaker) |
| `UNBTECH_207F.*` | `207F` | Utility: blitter, cursor, viewport, font, VGA reg programming |
| `UNBTECH_246C.*` | `246C` | Tile property table `+0x7AD`, `tB764` flag |
| `UNBTECH_2FE8.*` | `2FE8` | (Data segment) |
| `UNBTECH_3056.*` | `3056` | (Data segment) |
| `UNBTECH_3058.*` | `3058` | (Data segment) |
| `UNBTECH_305B.*` | `305B` | (Data segment) |
| `UNBTECH_3092.*` | `3092` | Mech story slot array + world map visibility |
| `UNBTECH_3EDB_0000.*` | `3EDB` | Data/story text |

---

## 2. MAIN GAME LOOP

### 2.1 Entry Point & Init

| Address | Name | Purpose |
|---------|------|---------|
| `19EF:2D82` (linear `0x1CC72`) | `entry_point` | Program entry point |
| `0800:50C8` | `fn0800_50C8` | Outer loop init, sets `w4FBA = 0` (world map mode) |
| `207F:2FDC` | `fn207F_2FDC` | Save segment context, stack frame allocator |
| `0000:0C` | `ghidra_guess_0000_000C` | Early init function |
| `0000:5C5` | `ghidra_guess_0000_05C5` | Early init function |

### 2.2 Main Loop Variables

| Address | Name | Type | Purpose |
|---------|------|------|---------|
| `ds:0x0152` | `w0152` | uint16 | Main loop exit guard (0=running, non-zero=exit) |
| `ds:0x014A` | `w014A` | uint16 | Screen refresh needed flag |
| `ds:0x01A8` | `w01A8` | uint16 | BLD force processing flag |
| `ds:0x3938` | `w3938` | uint16 | Key wait state gate |
| `ds:0x3988` | `w3988` | uint16 | Animation page swap guard |
| `ds:0x398E` | `w398E` | uint16 | World map mech render flag |
| `ds:0x5800` | `w5800` | uint16 | Animation page counter (0→1→2→0) |
| `ds:0x57FE` | `—` | uint16 | Animation frame counter (wraps at 3) |

### 2.3 Main Loop (`fn0800_0000`)

```
    ┌─► INPUT PHASE
    │   └─ fn1F3D_002F → fn1F3D_0259 (check key, scan scancode)
    │   └─ fn0800_2A2B (wait-for-key loop)
    │   └─ fn1E56_0D1D (WASD→arrows, numpad→diagonals)
    │   └─ fn1E56_0281 (set font)
    │
    ├─► KEY DISPATCH (loops fn0800_218F per pending key)
    │   └─ fn0800_231D (key dispatch)
    │   └─ fn0800_2C50 (SPACE menu handler, 7 options)
    │
    ├─► TIMER PHASE
    │   └─ fn1F3D_0006 (software timer decrement)
    │   └─ Timer cascade: bD335, bD343-345, bD329, bD320-322, bD323
    │   └─ Encounter probability check (RNG & bD330 == 0)
    │   └─ fn183B_000A (init combat if probability check passes)
    │
    ├─► ECONOMY PHASE
    │   └─ fn0800_29F5 (credit/stock market update)
    │
    ├─► ANIMATION + RENDER + BORDER (fn0800_240B + fn207F_18EF + fn1F3D_06C3)
    │   └─ fn0800_240B (tile animation page swap, if w3988==0)
    │   └─ fn0800_24C2 (next frame, every 3rd frame)
    │   └─ fn207F_18EF (screen refresh: 13×12 tile grid)
    │   └─ fn1F3D_06C3 (border draw based on w4FBA)
    │
    └─► BLD PHASE
        └─ fn1E56_03F5 (text renderer / cipher decode)
```

### 2.4 Key Dispatch Sub-functions

| Address | Name | Purpose |
|---------|------|---------|
| `0800:231D` | `fn0800_231D` | Key dispatch |
| `0800:218F` | `fn0800_218F` | Arrow key handler |
| `0800:1B8E` | `fn0800_1B8E` | Sub-dispatch |
| `0800:191B` | `fn0800_191B` | Cursor snap |
| `0800:186F` | `fn0800_186F` | Movement dispatch |
| `0800:17BB` | `fn0800_17BB` | Movement dispatch (high-level) |
| `0800:1A13` | `fn0800_1A13` | State check (used by BLD opcode F6) |
| `0800:48B7` | `fn0800_48B7` | State machine init (used by BLD opcode EA) |
| `0800:2A2B` | `fn0800_2A2B` | Wait-for-key loop |
| `0800:28A2` | `fn0800_28A2` | Display helper (render mode 0x0A/0x01) |
| `0800:29F5` | `fn0800_29F5` | Credit display update |

### 2.5 Arrow Key Movement (`fn0800_218F`)

Scancodes decoded by `fn1E56_0D1D` → (dx, dy) deltas. Calls per frame:
1. `fn207F_158C` or `fn207F_163B` (vertical move)
2. `fn207F_17C5` or `fn207F_16E3` (horizontal move)
3. `fn0800_2DA8` (render 3 tiles under cursor)
4. `fn207F_1DA8` (tile render under cursor)
5. `fn207F_1314` (set cursor position)
6. `fn207F_1DF8` (tile index from cursor)

---

## 3. STORY STATE SYSTEM

### 3.1 Three-Layer Architecture

| Layer | Location | Type | Size | Purpose |
|-------|----------|------|------|---------|
| **1** | `DS:0xD30C` | `byte[256]` | 256 bytes | Generic state array (shop inventories, visited flags, quest progress, party status) |
| **2** | `fn1631_11AB` | code | — | Story properties `0x1C-0x23` (story progression, skill tracking) |
| **3** | `bD450`/`bD451` | byte | 2 | Flag system (training complete, milestone marker) |

### 3.2 Layer 1: Generic State Array (`DS:0xD30C`)

| Offset | Access | Purpose |
|--------|--------|---------|
| `0xD30C + idx` | BLD opcodes `0xF1`, `0xF4`, `0xF3`, `0xF7` | Variable per-index; indexed by BLD bytecode operands |

### 3.3 Layer 2: Story Properties (`fn1631_11AB`, segment `1631:11AB`)

Properties `0x1C–0x23` handled:

| Property | Purpose |
|----------|---------|
| `0x1F` | Citadel attack state: increments `b0057` (max 2). Subcodes 2/5 increment; subcodes 1/6 latch `b0058=0xFF` |
| `0x20` | Multi-step story counter: inc `b0055` (cap 3) / `b0056` (cap 2), clears `b0000`, sets `wE484=1` on completion |
| `0x24` | Skill tracking nibble field |
| `0x25` | Skill tracking nibble field |

### 3.4 Layer 3: Flag System

| Address | Name | Type | Purpose |
|---------|------|------|---------|
| `0xD450` | `bD450` | byte | Training complete (set by case 0x19). Checked by BLD opcode `0xEC` |
| `0xD451` | `bD451` | byte | Milestone marker (set by case 0x1A). Checked by BLD opcode `0xEB` |

### 3.5 Story Progression Phase Map

| Phase | Condition | World State |
|-------|-----------|-------------|
| 1. NewGame | Init | MAP1, Training active |
| 2. Training | Before `bD450=1` | MAP1, `b0057=0` |
| 3. CitadelAttack | `bD450=1` + BLD 0xF5 trigger | MAP1→MAP11 transition, `b0057=1` |
| 4. FreeRoam | After attack | MAP2–10, `b0057=2`, encounter probability on |
| 5. EventTriggers | Variable | BLD checks against `D30C` state |
| 6. MultiStep | `b0055/b0056` tracking | Property 0x20 driven |
| 7. Endgame | BLD WINSCENE | Hyperpulse Generator → DropShip → Katrina |

### 3.6 Story State Data Structure (`Eq_107947`, stride `0x7D = 125 bytes`)

Array `aC744[]` at segment pointed by `DS:0x558E`.

> **Offset note:** Two conventions exist. The **code-base** uses `C724` as slot 0 base (0x20 bytes before `aC744`). The table below uses **code-base offsets** (C724-relative) matching TECHNICAL_ANALYSIS.md. To convert to struct-relative offsets (Eq_107947-relative from aC744), subtract 0x20. E.g., `+0x24` code-base = `+0x04` struct-relative = `b0004`.

```
C724+   Size  Reko Field   Purpose
------  ----  -----------  -------
+0x00   1     b0000        Generic per-story status byte (0xFF=empty slot, cleared by prop 0x20 completion)
+0x01   3     —            (unnamed, used as base for byte copy in 1CD3)
+0x04   1     b0004        Nibble-packed flag field (inventory/equipment)
+0x05   1     b0005        Nibble-packed flag field
+0x06   1     b0006        Timing/counter nibble
+0x07   1     —            Current ammo bin 0 (0xFF=sentinel empty, DEC on fire, INC on reload)
+0x08   1     —            Current ammo bin 1
+0x09   1     —            Current ammo bin 2
+0x0A   1     —            Current ammo bin 3
+0x0B   1     —            Current ammo bin 4
+0x0C   1     —            Current ammo bin 5
+0x0D   1     —            Current ammo bin 6
+0x0E   2     —            (unnamed)
+0x10   1     —            AI target validation byte (stage 9)
+0x11   1     —            AI target validation byte (stage 10, init 0x07)
+0x12   1     —            AI target validation byte (stage 11, init 0x00)
+0x13   23    —            AI target preference table entries 0-22 (35 bytes: +0x13 to +0x55)
+0x1F   1     —            Story state / property gate
+0x20   1     —            Story state / property gate
+0x21   3     —            (unnamed)
+0x24   1     b0004^       Skill property A (prop 0x1C: popcount low 3 bits → 0-3 = TN penalty)
+0x25   1     b0005^       Skill property B (prop 0x21: popcount low 3 bits → 0-3 = TN penalty)
+0x26   1     —            (unnamed)
+0x27   1     —            Last entry of target preference table (at +0x55 as 0-index) [ammo overlap at combat stage 0]
+0x28   8     —            Tail of target preference table (entries at +0x56..+0x5D)
+0x30   1     —            AI target validation (stage 0, checked at C74B=+0x27)
+0x33   1     —            Target preference entry 0 (init 0x11=17)
+0x34   1     —            Target preference entry 1 (init 0x11)
+0x35   1     —            Target preference entry 2 (init 0x11)
...      ...               (Target preference table extends to +0x55 = 35 entries total)
+0x55   1     b0055        Property 0x20 counter (major steps, capped at 3)
+0x56   1     b0056        Property 0x20 counter (minor steps, capped at 2)
+0x57   1     b0057        Story state (0=Training, 1=CitadelAttacked, 2=PostAttack)
+0x58   1     b0058        One-shot latch/marker for property 0x1F
+0x59   1     —            Equipment/weapon type index
+0x5A   1     —            Equipment state (0xFF=ready)
+0x5B   1     —            Gameplay mode counter / state
+0x5C   1     —            Status flags (bit 1 set = initialized)
+0x5D   0x0C  —            (unnamed)
+0x69   1     —            Upper nibble comparison target for skill prop at +0x24
+0x6A   1     —            Upper nibble comparison target for skill prop at +0x25
+0x6B   0x0A  —            (unnamed)
+0x75   1     —            Encounter/combat state
+0x76   1     —            Encounter/combat state
+0x77   1     —            (unnamed, penalty byte: non-zero → +2 TN)
+0x79   1     —            Primary unit slot index (0xFF=unassigned)
+0x7A   1     —            Secondary unit slot index (0xFF=unassigned)
+0x7B   1     —            Mech type ID (0x00=Locust, 0xC8=Chameleon, etc.)
+0x7C   1     —            (padding to 0x7D)
```

> **Note on overlapping fields:** The target preference table (+0x13-+0x55) and combat ammo bins (+0x07-+0x0D) occupy different code-base offsets. The ammo decrement uses stage_counter (0..0xA) as offset from C74B (= C724 + 0x27), so stage 0 targets +0x27 which is the LAST entry of the target pref table. See §5.6 for ammo addressing details.

**Key slot base addresses:**
| Address | Contents |
|---------|----------|
| `0xC724` | Code-base of `aC744[0]` (first story slot, 0x20 bytes before struct start) |
| `0xC744` | Actual start of `Eq_107947 aC744[0]` (struct-relative offset 0x00) |
| `0xC724 + ID × 0x7D` | Per-slot code-base |
| `0xC744 + ID × 0x7D` | Per-slot struct base |
| `0xC79B` = `0xC724 + 0x77` | Story state penalty byte (non-zero → `+2 TN`) |
| `0xC74B` = `0xC724 + 0x27` | Player ammo decrement base (stage_counter is sub-offset)

### 3.7 Mech Data Layout (within story slot, stride 125 bytes)

```
Offset  Size  Field            Description
------  ----  -----            -----------
+0x00   15    Name             Mech name (ASCII, null-padded)
+0x0F   1     Tonnage          Tonnage (uint8)
+0x10   11    CurrentArmour[11] Current armour by location
+0x1B   8     CurrentStructure[8] Current internal structure by location
+0x23   4     CurrentActuators[4] Current actuator status
+0x27   1     EngineHeatSinks  Heat sink count
+0x28   10    CurrentAmmo[10]  Current ammo bins
+0x32   1     WalkMove         Walk MP (uint8)
+0x33   1     JumpMove         Jump MP (uint8)
+0x34   47    CritSlotData[47] Critical slot data
+0x63   11    MaxArmour[11]    Maximum armour (template)
+0x6E   8     MaxStructure[8]  Maximum structure (template)
+0x76   4     MaxActuators[4]  Maximum actuators (template)
+0x7A   10    MaxAmmo[10]      Maximum ammo (template)
+0x7C   1     —                Zero padding to 0x7D
```

### 3.8 Unit Slot Data Structure (`aC614[]`, stride 0x11 = 17 bytes, 8 entries)

```
Offset  Field          Purpose
------  -----          -------
+0x00   b0000          Unit type ID (0xFF=empty slot)
+0x01   b0001          Generated attribute (from fn0800_19DD)
+0x02   6              (unmapped)
+0x08   b0008          Derived attribute (= b0001 * 10, halved if slot >= 4)
+0x09   b0009          Another generated attribute
+0x0A   2              (unmapped)
+0x0C   b000C          Linked story slot index (0x08=unassigned)
+0x0D   b000D          Supplementary attribute
+0x0E   b000E          Supplementary attribute
+0x0F   b000F          Supplementary attribute
```

### 3.9 State-Related Variables

| Address | Name | Type | Purpose |
|---------|------|------|---------|
| `0xD310` | `bD310` | byte | World map active flag |
| `0xD330` | `bD330` | byte | Encounter probability mask (0x1F=1/32, 0x7F=1/128) |
| `0xD346` | `bD346` | byte | Star map / alternate view flag |
| `0xD335` | `bD335` | byte | Movement cooldown timer (0x3F=63 frames) |
| `0xD343` | `bD343` | byte | Timer cascade part 1 (citadel attack trigger at 0x0800-0x0D00 × 0x6000-0xB000) |
| `0xD344` | `bD344` | byte | Timer cascade part 2 |
| `0xD345` | `bD345` | byte | Timer cascade part 3 |
| `0xD329` | `bD329` | byte | UI timer |
| `0xD320` | `bD320` | byte | Generic timer |
| `0xD321` | `bD321` | byte | Generic timer |
| `0xD322` | `bD322` | byte | Generic timer |
| `0xD323` | `bD323` | byte | Economy/production timer (3-day stock cycle) |
| `0xD33D` | `bD33D` | byte | Fog update guard |
| `0xD30E` | `bD30E` | byte | Building entry variant flag |
| `0xD334` | `bD334` | byte | Post-dispatch flag (case 0x28) |
| `0xD456` | `bD456` | byte | Unit ID incrementing counter |
| `0xD55E` | `bD55E` | byte | Story slot backup flag |
| `0xD31A` | `bD31A` | byte | State variable / story slot index |
| `0xD31B` | `bD31B` | byte | Equipment slot 5 flag |
| `0xD31C` | `bD31C` | byte | Count result (story/uppercase slots) |
| `0xD325` | `bD325` | byte | Equip consistency mismatch flag |
| `0xD326` | `bD326` | byte | Garage service table index |
| `0xD32B` | `bD32B` | byte | Copied slot flag |
| `0xD331` | `bD331` | byte | Unit slot index |
| `0xD332` | `bD332` | byte | Room handler gate |
| `0xE484` | `wE484` | uint16 | Story action complete flag (set by property 0x20) |
| `0xD55C` | `wD55C` | uint16 | Text processing break flag |
| `0xE48E` | `wE48E` | uint16 | Combat-in-progress flag |

---

## 4. BLD INTERPRETER SYSTEM

### 4.1 Four-Layer Architecture

| Layer | Function | Segment:Offset | Purpose |
|-------|----------|---------------|---------|
| 1 | `fn0FDC_0008` | `0FDC:0008` | Entry point. Loads BLD data by index, prepares buffer via `fn0FDC_1D30` |
| 2 | `fn0FDC_01C0` | `0FDC:01C0` | Bytecode interpreter. Handles opcodes `0xE4–0xFF` |
| 3 | `fn1CD3_0004` | `1CD3:0004` | Room/building interaction dispatcher (47-case switch `0x01–0x2F`) |
| 4 | `fn1E56_03F5` | `1E56:03F5` | Text renderer. Cipher decode, word-wrap, margins |

### 4.2 BLD Interpreter Variables

| Address | Name | Type | Purpose |
|---------|------|------|---------|
| `DS:[0x5460]→0x4602` | `bld_translation[]` | `byte[16]` | BLD index translation table (MTP tile property → BLD file index) |
| `3000:CC30` | `bld_filenames[]` | `string[]` | BLD filename list |
| `0x33FC` | `encounter_bld_idx` | byte | Encounter narration BLD script index |

### 4.3 BLD Opcode Dispatch Table

| Opcode | Reko Case | Description | Operand |
|--------|-----------|-------------|---------|
| `0xE4` | `~0x1B` | WRITE_CHAR | 1 byte: char to write |
| `0xE5` | `~0x1A` | ADD_CREDITS | 2 bytes LE: signed value to add to `tD370` |
| `0xE6` | `~0x19` | SET_CURSOR_XY | 4 bytes LE: cursor X/Y |
| `0xE7` | `65511` | CMP_CURSOR_X | 2B LE compare_val + 2B LE abs_jump. If cursor X == val → jump; else skip 2B |
| `0xE8` | `~0x17` | RNG_CHECK | 1B mask + 2B LE abs_jump. If `RNG() & mask != 0` → jump; else skip 2B |
| `0xE9` | `~0x16` | CALL_ROOM_HANDLER | 1 byte: handler index → `fn11B8_0D58(op)` |
| `0xEA` | `~0x15` | COND_STATE_ACTION | 1 byte: conditional action via `fn0800_48B7` (if `w3938==0`) |
| `0xEB` | `65515` | CHECK_FLAG_EB | 0 bytes: skip if `bD451 == 0` |
| `0xEC` | `65516` | CHECK_FLAG_EC | 0 bytes: skip if `bD450 == 0` |
| `0xED` | `~0x12` | UNIT_CHECK_LOOP | 2 bytes: loop 8 units checking `aC60F` state |
| `0xEE` | `~0x11` | SPEND_CREDITS | 2 bytes LE: deduct from `tD370` (zero-floor) |
| `0xEF` | `~0x10` | CHECK_CREDITS | 2 bytes LE: skip if insufficient funds |
| `0xF0` | `~0x0F` | SET_TEXT_MARGINS | 2 bytes: left/right margins |
| `0xF1` | `~0x0E` | ADD_TO_STATE | 2 bytes: `D30C[index] += value` |
| `0xF2` | `~0x0D` | ROOM_DESCRIPTION | 0 bytes: render room description |
| `0xF3` | `~0x0C` | SHOP_INTERACTION | 1 byte: index into `D30C`, indirect dispatch via `D30C[index]*2` |
| `0xF4` | `~0x0B` | SET_STATE_VALUE | 2 bytes: `D30C[index] = value` |
| `0xF5` | `~0x0A` | SHOP_DISPATCH | 1 byte: case index → `fn1CD3_0004(op)` |
| `0xF6` | `~0x09` | CHECK_CONDITION | 0 bytes: skip if `fn0800_1A13(1)` returns 0 |
| `0xF7` | `~0x08` | STATE_COND_CHECK | 1 byte: skip if `D30C[index] == 0` |
| `0xF8` | `~0x07` | JUMP_FORWARD | 0 bytes: skip forward 2 bytes (GOTO) |
| `0xF9` | `~0x06` | JUMP_INDEXED | 1 byte: computed GOTO, skip by `fn1E56_0B5E(op)*2+2` |
| `0xFA` | `~0x05` | DRAW_SPRITE | 1 byte: sprite ID → `fn1E56_0004(op)` |
| `0xFB` | `~0x04` | ADVANCE_INPUT | 0 bytes: wait for key |
| `0xFC` | `~0x03` | RENDER_TEXT | N bytes: display cipher text, advance past string |
| `0xFD` | `~0x02` | SET_FONT2 | 0 bytes: font/display parameters |
| `0xFE` | `~0x01` | SET_FONT | 1 byte: set font |
| `0xFF` | `~0x00` | EXIT | 0 bytes: set exit flag, stop interpreter |

### 4.4 BLD Narrative Mode Markers

| Byte | Purpose |
|------|---------|
| `0x9E` | Third-person narrative |
| `0x9C` | Character speech continuation |
| `0x9B` | Player internal thought |
| `0x9F` | Player-directed thought |
| `0xA5` | Sentence continuation (appends lowercase) |

### 4.5 BLD Content Type Codes

| Pattern | Meaning |
|---------|---------|
| `c0 ec` | Dialogue/story content |
| `c0 f5` | Shop/service content |
| `c0 f4` | Special content |
| `c0 da` | Endgame marker |

### 4.6 Text Cipher

| Byte Range | Maps To | Case |
|------------|---------|------|
| `0x57–0x5F` | i h k j m l o n a | lower |
| `0x60` | q | lower |
| `0x61–0x76` | c b e d g f y x i z l m n o p s r u t w v | lower |
| `0x77–0x7F` | I H K J M L O N A | upper |
| `0x80–0x96` (skip 0x88–0x8F) | C B E D G F Y P S R U T W V | upper |
| `0xA0` | space | — |
| `0x6B` | control byte | — |
| `0xC0` | no-op (structural separator) | — |

### 4.7 fn1CD3_0004 Case Dispatch (47 Cases, 0x01–0x2F)

| Case | Name | Description |
|------|------|-------------|
| `0x01` | ENTER_BUILDING | Load building BLD data, init viewport |
| `0x02` | SHOW_GREETING | Display building entry text |
| `0x03` | EXIT_BUILDING | Clear building state, restore coordinates |
| `0x04` | SHOW_SHOP_ITEMS | Render 3 items from `C618[0..2]`, price = `C618[n] * 125 + 75` |
| `0x05` | BUY_ITEM_SINGLE | `C618[bD314] += 1`, `tD370 -= C618[bD314]*125+75` |
| `0x06` | SHOW_PLAYER_ITEMS | Display owned items (`aD374[n] != 0`) |
| `0x07` | BUY_ITEM_BULK | Bulk buy at 1 cr/unit |
| `0x08` | SELL_ITEM_BULK | Bulk sell at 1 cr/unit |
| `0x09` | HOSPITAL_HEAL | Cost from `0x4F26/0x4F28`, 32-bit credit check |
| `0x0A` | SHOW_CREDITS | Display current credits |
| `0x0B` | BUY_WITH_UNIT_SEL | Cost from `0x4F44/0x4F46`, calls `fn0FDC_15E6` unit selection |
| `0x0C` | CLOSE_ACTION | Close current shop/building action |
| `0x0D` | EQUIPMENT_MENU | Equip/unit management menu |
| `0x0E` | COUNT_UNITS | Count active unit slots |
| `0x0F` | EQUIP_SLOT5 | Equip slot 5 (500 cr) |
| `0x10` | CHECK_SLOT5 | Check if slot 5 occupied |
| `0x11` | COUNT_STORY_SLOTS | Count occupied story slots |
| `0x12` | DISPATCH_11B8_0002 | Dispatch: `fn11B8_0002` |
| `0x13` | DISPATCH_11B8_080A | Dispatch: `fn11B8_080A` |
| `0x14` | DISPATCH_11B8_0925 | Dispatch: `fn11B8_0925` |
| `0x15` | EQUIP_SLOT6 | Equip slot 6 (500 cr) |
| `0x16` | CHECK_SLOT6 | Check if slot 6 occupied |
| `0x17` | EQUIP_CONSISTENCY | Equip consistency check |
| `0x18` | GARAGE_SERVICE | Garage service (cost table at `0x4F6E`) |
| `0x19` | FLAG_D450 | Set `bD450 = 1` (training complete) |
| `0x1A` | FLAG_D451 | Set `bD451 = 1` (milestone) |
| `0x1B` | GOTO_2E_SHARED | Shared goto for case 0x2E |
| `0x1C` | CLEAR_ALL_SLOTS | Clear all unit slots |
| `0x1D` | COUNT_UPPERCASE | Count uppercase story slots |
| `0x1E` | DISPATCH_11B8_104E | Dispatch: `fn11B8_104E` |
| `0x1F` | READ_SLOT_FLAG | Read slot flag byte |
| `0x20` | COMPLEX_EQUIP | Complex equip/validation (table at `0x4DDB`) |
| `0x21` | DISPATCH_0FDC_1C9B | Dispatch: `fn0FDC_1C9B` |
| `0x22` | DISPATCH_0FDC_1A26 | Dispatch: `fn0FDC_1A26` |
| `0x23` | NEW_GAME_INIT | Full game init: clear state, load templates |
| `0x24` | READ_UNIT_SLOT | Read unit slot data |
| `0x25` | CLEAR_UNIT_SLOT | Clear unit slot |
| `0x26` | READ_D456 | Read D456 counter |
| `0x27` | TRIGGER_ACTION | Mode trigger via `fn1467_0002` |
| `0x28` | DISPATCH_11B8_152F | Dispatch: `fn11B8_152F` |
| `0x29` | COMBAT_HEAL | Apply RNG damage/healing to party |
| `0x2A` | SAVE_POSITIONS | Save unit positions |
| `0x2B` | RESTORE_POSITIONS | Restore unit positions |
| `0x2C` | DISPATCH_11B8_1762 | Dispatch: `fn11B8_1762` |
| `0x2D` | COMBAT_ENCOUNTER | Handle combat state transitions (0→2→3) |
| `0x2E` | RESTORE_SLOTS | Restore story slots from backup |
| `0x2F` | DECREMENT_STATE | Decrement state variable |

---

## 5. COMBAT SYSTEM

### 5.1 Combat Entry Points

| Function | Seg:Off | Linear | Description |
|----------|---------|--------|-------------|
| `ghidra_guess_1000_458C` | `1000:458C` | `0x1458C` | Main combat handler entry |
| `ghidra_guess_1000_0934` | `1000:0934` | `0x10934` | Unit state check (returns 0-3 action code) |
| `ghidra_guess_1000_0AB2` | `1000:0AB2` | `0x10AB2` | AI target selection (n-th from preference table) |
| `ghidra_guess_1000_160E` | `1000:160E` | `0x1160E` | LoS/fire validation (Bresenham ray-cast) |
| `ghidra_guess_1000_05C5` | `1000:05C5` | `0x105C5` | LoS/range check |
| `ghidra_guess_1000_0673` | `1000:0673` | `0x10673` | Heat dissipation (end-of-round) |
| `ghidra_guess_1000_1554` | `1000:1554` | `0x11554` | Skill modifier (popcount low 3 bits) |
| `unknown_19EF_0971` | `19EF:0971` | `0x1A861` | Movement phase direction calculation |
| `unknown_19EF_0BC0` | `19EF:0BC0` | `0x1AAB0` | 24-bit LFSR RNG |
| `unknown_19EF_1886` | `19EF:1886` | `0x1B776` | Fire phase (9 body part/weapon mount pairs) |
| `unknown_19EF_11BB` | `19EF:11BB` | `0x1B0AB` | Grid adjacency / critical hit transfer |
| `unknown_19EF_18EF` | `19EF:18EF` | `0x1B7DF` | Damage application |
| `unknown_19EF_1DF8` | `19EF:1DF8` | `0x1BCE8` | Post-fire cleanup |
| `split_1000_A8C6` | `1000:A8C6` | `0x1A8C6` | Binary search refinement for movement direction |
| `ghidra_guess_0000_30DD` | `0000:30DD` | `0x030DD` | 2D6 roll generator |
| `ghidra_guess_0000_30F3` | `0000:30F3` | `0x030F3` | Single D6 roll |
| `ghidra_guess_0000_2EBB` | `0000:2EBB` | `0x02EBB` | Coordinate utility |
| `ghidra_guess_0000_2F6F` | `0000:2F6F` | `0x02F6F` | 8-direction angle calculation |
| `ghidra_guess_1000_3F24` | `1000:3F24` | `0x13F24` | Weapon range calc |
| `ghidra_guess_1000_4041` | `1000:4041` | `0x14041` | Combat encounter init |
| `ghidra_guess_1000_2F32` | `1000:2F32` | `0x12F32` | Combat fog/setup |
| `ghidra_guess_1000_2F73` | `1000:2F73` | `0x12F73` | Combat init (frame setup) |

### 5.2 Unit Position / Status Arrays

| Address | Type | Stride | Elements | Purpose |
|---------|------|--------|----------|---------|
| `ES:[ID×2 + 0x4004]` | uint16 | 2 | 24+ | Unit X coordinate |
| `ES:[ID×2 + 0x4036]` | uint16 | 2 | 24+ | Unit Y coordinate |
| `ES:[ID×2 + 0x406A]` | uint16 | 2 | 24+ | Unit status (0=dead/inactive) |
| `ES:[0x4082]` | uint16 | — | — | Unit equipment/state flag array |

### 5.3 Cursor / Target Position

| Address | Segment Source | Type | Purpose |
|---------|----------------|------|---------|
| `ES:[0xA44B]` | `DS:0x5582→A44B` | uint16 | Cursor/target X |
| `ES:[0xA44D]` | `DS:0x5584→A44D` | uint16 | Cursor/target Y |
| `0xA44B` within `0x569E` | `+0x0131` | uint16 | Cursor X (low byte=col, high=sub-pixel) |
| `0xA44D` within `0x569E` | `+0x012F` | uint16 | Cursor Y |
| `0xE486` | — | uint16 | Saved cursor X (combat enter) |
| `0xE488` | — | uint16 | Saved cursor Y (combat enter) |

### 5.4 Combat Stack Variables

| Address | Type | Purpose |
|---------|------|---------|
| `[BP-0x78]` | 24× byte | Per-unit combatant state (zero-initialized) |
| `[BP-0x28]` | uint16 | Unit slot iterator (0..0x17, max 24) |
| `[BP-0x42]` | uint16 | Combat stage/phases sub-counter (0..0xB..0xC) |
| `[BP-0x30]` | uint16 | To-hit target number (TN) accumulator |
| `[BP-0x60]` | uint16 | Hit location / damage variance |
| `[BP-0x56]` | uint16 | Hit flag (0/1) |

### 5.5 Heat System

| Address | Type | Purpose |
|---------|------|---------|
| `ES:[BX+0x92]` | byte | Player unit heat pool (cleared each round) |
| `ES:[BX+0x8A]` | byte | Enemy unit heat pool (never cleared!) |
| `ES:[BX+0x6E]` | byte | Player heat penalty accumulator (copied from pool, then cleared) |
| `ES:[BX+0x66]` | byte | Enemy heat penalty register |
| `ES:[SI+0xD576]` | byte | Extra heat penalty counter |

**Heat thresholds:** 8/13/17/24 → +1 TN each (up to +4)

### 5.6 Ammo System

| Combat Unit ID | Story Slot | Ammo Address | Stride | Type |
|---------------|------------|-------------|--------|------|
| 0–3 | 0–3 | `0x2A02:C74B + id × 0x7D + stage` | 0x7D | byte |
| 4–11 | (separate) | `0x2A02:C5D4 + id × 0x11 + weapon_type` | 0x11 | byte (burst, capped 4) |
| 12–15 | 4–7 | `0x2A02:C363 + id × 0x7D + stage` | 0x7D | byte |

### 5.7 Fire Phase — 9 Body Part Pairs

Iterated in `unknown_19EF_1886_1B776`, stride `0x40`:

| # | SI (source) | DI (dest) | Body Location |
|---|-------------|-----------|---------------|
| 1 | `0x564` | `0x324` | Right Arm |
| 2 | `0x5A4` | `0x364` | Right Leg |
| 3 | `0x5E4` | `0x3A4` | Right Torso |
| 4 | `0x624` | `0x3E4` | Head |
| 5 | `0x664` | `0x424` | Center Torso |
| 6 | `0x6A4` | `0x464` | Left Arm |
| 7 | `0x6E4` | `0x4A4` | Left Leg |
| 8 | `0x724` | `0x4E4` | Left Torso |
| 9 | `0x764` | `0x524` | Center Torso (rear) |

### 5.8 Combat Fog Grids

| Address | Dimensions | Init | Purpose |
|---------|-----------|------|---------|
| `DS:[0x55D8]→0x40B4` | 12×24=288B | `0x02`=fogged | Combat Fog Grid A |
| `DS:[0x55D8]→0x41D4` | 12×24=288B | `0x02`=fogged | Combat Fog Grid B |
| `0xCB0C` | bit-packed 128×128 | — | World map visibility |
| `0xCAFC`/`0xCB1C` | — | — | Additional fog/visibility |

### 5.9 Encounter Init / Positioning

| Function | Segment | Purpose |
|----------|---------|---------|
| `fn183B_000A` | `183B:000A` | Encounter initiator |
| `fn183B_28DB` | `183B:28DB` | Encounter positioning (±10-17 from (26,12)) |
| `fn183B_193B` | `183B:193B` | Movement-based fog clearing |
| `fn0DAB_0D3D` | `0DAB:0D3D` | Encounter population (3 fixed mech templates) |

### 5.10 Combat State Machine

| Phase | Value | Description |
|-------|-------|-------------|
| Combat encounter init | `C2=1, C6=3, C8=0` | Initial values |
| Combat loop stage | `[BP-0x42]=0..0xB` | 12 stages |
| Exit | `w4FBA=3` | Post-combat mode |
| Re-encounter probability | `bD330=0x7F` | Reduced after combat |

### 5.11 To-Hit Formula

```
TN = action_code × 2 + 4    (base: 4/6/8/10 for no/short/medium/long range)
   + skill_modifier          (popcount(~byte[0x24] & 7) + popcount(~byte[0x25] & 7), 0-6)
   + terrain_modifier        (sign_extend(table[0x32C6]) + 1)
   + terrain_table_mod       (table at 0x2D1A)
   + story_state_penalty     (+2 if byte at 0xC79B != 0)
   + heat_penalty            (+1 per threshold 8/13/17/24, up to +4)

Special: weapon type 0x20 (kick) → TN = 3
Roll: 2D6 >= TN → HIT
```

---

## 6. RENDERING SYSTEM

### 6.1 Framebuffer & Video Mode

| Parameter | Value |
|-----------|-------|
| Resolution | 320 × 200 |
| Default mode | EGA planar (4 planes) |
| Framebuffer base | `A000:0000` |
| Plane stride | `0x2000` (8192 bytes) |
| Bytes/plane/scanline | 40 (320px ÷ 8) |
| Row-pair stride | `0x50` (80 bytes) |
| VGA ports | `0x3C4` (sequencer), `0x3CE` (graphics controller) |

### 6.2 Pixel Format Flag (`tB764` at segment 246C)

| Value | Mode | Framebuffer | Stride | Notes |
|-------|------|-------------|--------|-------|
| `0x00` | CGA | `0xB800` | `0x28` | 2-bit pixels, odd/even `0x2000` shift |
| `0x02` | VGA text | `0xA000→0xAC00` | `0x28` | Linear |
| `0x01` | EGA planar | `0xA000` | `0x28` | 4-bit planar, interleave |
| default | Full frame | `0xA000` | `0x0140` | Linear 320px |

### 6.3 Screen Layout

| Panel | Width | Content |
|-------|-------|---------|
| Left panel | 80px (`0x50`) | Location graphic + action menu |
| Right area | 240px | Map viewport (13×12 tiles) / text |

### 6.4 Border Variants (`fn1F3D_06C3`)

| Variant | Function | Used for |
|---------|----------|----------|
| Full border | `fn207F_1CB8` | w4FBA=0,1 |
| Narrow border | `fn207F_1D3A` | w4FBA=2 (200 rows × 27 words) |
| Text overlay | `fn207F_245C` | w4FBA=3 (13-column strip) |

### 6.5 Rendering Pipeline (Main Loop)

```
Pass 1: fn207F_18EF — Right panel: 13×12 tile grid centered on cursor (A44B, A44D)
  └─ Reads tile property from seg 246C +0x7AD[tile_index]
  └─ Calls fn207F_1AA8/1ACE/1AF4 for tile writes to VRAM

Pass 2: fn1F3D_06C3 — Left panel border based on w4FBA

Pass 3: fn1E56_03F5 — Text overlay (BLD phase)
```

### 6.6 Global UI Mode (`w4FBA`)

| Value | Mode | Description |
|-------|------|-------------|
| 0 | WorldMap | World map display + movement |
| 1 | LocalTiles | Local tile view |
| 2 | Text | Combat / text mode |
| 3 | BuildingName | Building interior / name mode |

**Set once at startup** from keys 1-4 (`fn0D27_0044` subtracts `0x31`). NEVER dynamically changed during gameplay.

### 6.7 EGA Planar Blitter (`fn207F_24D7`)

| Case | Width | Description |
|------|-------|-------------|
| `0x00` | 80px | Left panel width, planar interleave |
| `0x02` | 40px (text column) | Linear |
| `0x01` | 160px | 4-way planar |
| default | 320px | Full frame, linear |

### 6.8 World Map Coordinates

| Expression | Range | Purpose |
|------------|-------|---------|
| `(A44B & 0x7F) >> 1` | 0–63 | Tile X from cursor |
| `(A44D & 0x7F) >> 1` | 0–63 | Tile Y from cursor |
| `(tA44B >> 1 & 0x07) + 2` | 2–9 | Cursor grid X |
| `(tA44D >> 1 & 0x07) + 2` | 2–9 | Cursor grid Y |
| `tileX + tileY × 24` | — | Tile index (map grid 24 wide) |

**Combat coordinate packing:**
```
X = (val & 0xF00) >> 1 | (val & 0x7F)
Y = (val & 0xF000) >> 5 | (val & 0x7F)
Masks: 0xF7F, 0xF07F
```

### 6.9 Viewport Registers (`fn207F_1B80`)

| Register | Purpose |
|----------|---------|
| `tB78E`/`tB790` | Destination base address |
| `tB792`/`tB794` | Source X/Y |
| `tB79A`/`tB79C` | Clip width/height |

### 6.10 Rendering Functions

| Function | Seg:Off | Purpose |
|----------|---------|---------|
| `fn207F_18EF` | `207F:18EF` | Screen refresh (13×12 tile grid) |
| `fn207F_1CB8` | `207F:1CB8` | Full border draw |
| `fn207F_1D3A` | `207F:1D3A` | Narrow border draw |
| `fn207F_245C` | `207F:245C` | Text overlay border |
| `fn207F_24D7` | `207F:24D7` | Core EGA blitter (4 cases) |
| `fn207F_275C` | `207F:275C` | VGA pixel writer (4 sub-modes) |
| `fn207F_1314` | `207F:1314` | Set cursor position |
| `fn207F_1DF8` | `207F:1DF8` | Calculate tile index from cursor |
| `fn207F_1DA8` | `207F:1DA8` | Tile render under cursor |
| `fn207F_158C` | `207F:158C` | Move cursor UP |
| `fn207F_163B` | `207F:163B` | Move cursor DOWN |
| `fn207F_16E3` | `207F:16E3` | Move cursor LEFT |
| `fn207F_17C5` | `207F:17C5` | Move cursor RIGHT |
| `fn207F_28A8` | `207F:28A8` | 128-byte tile memcpy |
| `fn207F_28EB` | `207F:28EB` | Tile blit to framebuffer |
| `fn207F_1AA8/1ACE/1AF4` | `207F` | Partial/full tile writes |
| `fn207F_1FBE` | `207F:1FBE` | Screen clear |
| `fn207F_104E` | `207F:104E` | BTSTATS tile render |
| `fn207F_0A9F` | `207F:0A9F` | Text-mode tile addressing |
| `fn207F_1B80` | `207F:1B80` | Configure viewport dimensions |
| `fn207F_1A97` | `207F:1A97` | Apply clipping to coordinates |
| `fn0800_2A93` | `0800:2A93` | World map tile render (64 tiles) |
| `fn0800_2DA8` | `0800:2DA8` | Tile render under cursor |
| `fn1F3D_06C3` | `1F3D:06C3` | Border dispatcher |
| `fn1F3D_0259` | `1F3D:0259` | Key scanning input |
| `fn1F3D_086A` | `1F3D:086A` | Render room description |
| `fn1F3D_03EB` | `1F3D:03EB` | Mode-specific rendering param lookup |
| `fn1F3D_0086` | `1F3D:0086` | Sprite rendering |
| `fn1F3D_00D5` | `1F3D:00D5` | Display helper |

---

## 7. ECONOMY & INVENTORY

### 7.1 Credits

| Address | Name | Type | Purpose |
|---------|------|------|---------|
| `0xD370` | `tD370` | uint16 | Credits low word |
| `0xD372` | `tD372` | uint16 | Credits high word |

### 7.2 Shop Inventory

| Name | Type | Purpose |
|------|------|---------|
| `C618[0..2]` | uint16[3] | 3 item type numbers displayed in shop |
| `bD314` | byte | Selection cursor (0-2) |
| `bD315` | byte | Purchase success flag |
| `bD316` | byte | Discount/insurance flag for hospital |
| `bD317` | byte | Repair success flag |
| `bD318` | byte | Bulk quantity threshold (6 or 9) |

### 7.3 Player Inventory

| Name | Type | Stride | Purpose |
|------|------|--------|---------|
| `aD374[]` | uint32[] | 4 | Per-item-type player quantity |
| `aD376[]` | uint16[] | 2 | Per-item-type player data |

### 7.4 Stock Market

| Name | Type | Purpose |
|------|------|---------|
| `wD390`/`wD392` | uint16[] | Stock value arrays (stride 0x1A=26) |
| `wD394`/`wD396` | uint16[] | Alternate stock fields |
| `0x4024`/`0x4056` | uint16[] | Saved/additional stock values |

### 7.5 Price Tables

| Address | Type | Usage |
|---------|------|-------|
| `ds:0x4F26/0x4F28` | uint16[] | Hospital healing cost (case 0x09) |
| `ds:0x4F44/0x4F46` | uint16[] | Unit purchase cost (case 0x0B) |
| `ds:0x4F6E` | uint16[] | Garage service cost (case 0x18) |
| `0x4DDB` | table | Equipment validation (case 0x20) |

### 7.6 BLD Price Encoding (Inline)

| Byte | Value |
|------|-------|
| `0xAF–0xB3` | 40–44 |
| `0xB4–0xB8` | 105–113 |
| `0xBE` | 125 |
| `0xBF` | 127 |

---

## 8. UI / PLAYER INTERFACE

### 8.1 SPACE Menu (`fn0800_2C50`)

| Option | Handler | Description |
|--------|---------|-------------|
| 1 | `fn0800_3BD0` | Party/equip (5 sub-modes) |
| 2 | `fn0800_378D` | Tech/repair (7 item slots) |
| 3 | `fn1431_000A` | Star map |
| 4 | `fn0800_32B3` | Enter building |
| 5 | `fn0800_35D3` | Stock market (w4FBA-aware) |
| 6 | `fn0800_3D40` | Stat/inventory screen (modal) |
| 7 | `fn0800_4D57` | Special dispatch |

All handlers call `fn0800_4CAC(1)` for cleanup.

### 8.2 Stat/Inventory Screen (`fn0800_3D40`)

**8-phase rendering** via `fn0800_3FAE`:
1. Screen clear (`fn207F_1FBE`)
2. Coordinate setup
3. Star map or normal background (48-row BTSTATS tile render)
4. 3×3 subtile unit data overlay
5. Visibility/fog overlay (24×40)
6. Direction/status text
7. Bottom bar animation + sparkle effect
8. Key wait

Cleanup: restore cursor, `fn207F_1314`, `fn207F_18EF`, `fn1F3D_06C3`, `fn0800_4CAC(1)`, `w014A=0`.

### 8.3 Action Menu (`fn0D27_0044`)

| Address | Name | Purpose |
|---------|------|---------|
| `0D27:0044` | `fn0D27_0044` | Action menu handler. Subtracts `0x31` from key → sets `w4FBA` |

### 8.4 Scancode Remapper (`fn1E56_0D1D`)

Pure remapper: WASD ↦ arrows, numpad ↦ diagonals. No side effects.

### 8.5 Numeric Input (`fn1543_0CDE`)

| Address | Purpose |
|---------|---------|
| `ES:0x0012` | Digit input array (max 7 digits) |
| Keys `0–9` | Accumulate `value = value × 10 + digit` |
| `0x08` | Backspace (delete last) |
| `0x0D` | Enter (finalize) |

---

## 9. SAVE FILE LAYOUT

| Offset | Content | Size | Type |
|--------|---------|------|------|
| `0x01–0x88` | Infantry characters 01–08 | 8 × 17 = 136 | 8 infantry character structs |
| `0x89–0x110` | Enemy infantry 01–04 | 4 × 17 = 68 | 4 enemy infantry structs |
| `0x111–0x288` | Lance mechs 01–04 | 4 × 125 = 500 | Mech structs (story slots 0-3) |
| `0x289–0x304` | (gap?) | 124 | Unknown |
| `0x305–0x4F8` | Enemy mechs 01–04 | 4 × 125 = 500 | Mech structs (story slots 4-7) |
| `0x4F9` | Map visibility | 2048 | Bit-packed 128×128 |
| `0xCF9` | Mission flags | — | CitadelMissionFlag, CitadelKatrinaVisit, etc. |
| `0xD5D` | Finance | — | C-Bills + 3 stock values (DefHes, NasDiv, BakPhar) |
| `0xF45` | Position | — | PartyMapPositionX/Y |

---

## 10. ANIMATION SYSTEM

### 10.1 Segment 135D Animation Dispatch

| Function | Offset | Purpose |
|----------|--------|---------|
| DISP | `135D:0004 + 0x0000` | Display animation frame |
| LOAD | `135D:0004 + 0x0010` | Load animation data from ANM file |
| INIT | `135D:0004 + 0x0020` | Initialize animation sequence |
| CLEAR | `135D:0004 + 0x0030` | Clear animation state |

### 10.2 Tile Animation

| Variable | Purpose |
|----------|---------|
| `w5800` | Page counter (0→1→2→0) |
| Source offset | `(w5800 << 7) + 54658` |
| Tile count | 4100 tiles per page |
| Tile stride | 128 bytes |
| `w3988` | Animation guard flag (when set, page swap paused) |
| `fn207F_28A8` | 128-byte memcpy (tile copy, NOT VGA hw) |
| `fn0800_240B` | Page swap function (guarded by w3988) |
| `fn0800_24C2` | Next animation frame (every 3rd frame via w5800 wrap) |

### 10.3 ANM File Format

| Field | Size | Description |
|-------|------|-------------|
| Width | 2 bytes | Fixed width (88 pixels) |
| Start pos | `0x33` | Start position |
| Data | variable | XOR-based delta decompression (accumulative frames) |

22 animation files: `O0.ANM`–`O21.ANM`.

---

## 11. ENEMY / ENCOUNTER SYSTEM

### 11.1 Encounter Population

| Address | Type | Content |
|---------|------|---------|
| `[DS:0x5436]:0x2DF8` | word[3] | Fixed 3-entry enemy mech template table |
| `DS:[0x5434] + 0x2CF4` | byte[] | Infantry weapon instance data (stride 0x11) |

### 11.2 Enemy Mech Templates

| Mech ID | Name | Tonnage | Walk | Jump | Availability |
|---------|------|---------|------|------|-------------|
| `0x00` | LOCUST | 20t | 8 | 0 | Random encounter |
| `0x01` | WASP | 20t | 6 | 6 | Random encounter |
| `0x02` | STINGER | 20t | 6 | 6 | Random encounter |
| `0x03` | COMMANDO | 25t | 6 | 0 | Random encounter |
| `0x06` | URBANMECH | 30t | 2 | 2 | Story-only |
| `0x09` | JENNER | 35t | 7 | 5 | Story-only (Kuritan) |
| `0xC8` | CHAMELEON | 50t | 6 | 6 | Player starting mech |

**Random encounter pool:** 3 fixed templates (Locust/Wasp/Stinger), selected via `RNG % 3`. **No dynamic balancing.**

### 11.3 Encounter Positioning

| Parameter | Value |
|-----------|-------|
| Center | (26, 12) on 32×24 world grid |
| Offset | `±(RNG & 0x07 + 0x0A)` = ±10–17 |
| Direction | 8-direction from center |

### 11.4 Encounter Probability

| State | Mask | Effective Rate |
|-------|------|----------------|
| Normal | `bD330 = 0x1F` | ~1/32 frames |
| Post-combat | `bD330 = 0x7F` | ~1/128 frames |
| Cooldown | `bD335 = 0x3F` | 63 frames no encounter |

---

## 12. DATA TABLES

### 12.1 Weapon Data Table (stride 0x11 = 17 bytes)

| Offset | Size | Field | Description |
|--------|------|-------|-------------|
| `+0x00` | 10 | Name | ASCII, null-padded |
| `+0x0A` | 1 | Damage | Damage value |
| `+0x0B` | 1 | Shots | Ammo count (bit 7 = infinite) |
| `+0x0C` | 1 | Heat | Heat per shot |
| `+0x0D` | 1 | Sound | Sound effect / visual effect ID |
| `+0x0E` | 2 | Range | Maximum range (uint16 LE) |
| `+0x10` | 1 | Skill | Skill class (0=B&Blades, 1=Pistol, 2=Rifle, 3=Gunnery, 4=Kick) |

### 12.2 Weapon Instance Table

| Address | Field | Purpose |
|---------|-------|---------|
| `DS:[0x5652]→0x2EE4` | Base | Weapon instance table |
| `DS:[BX+0x2EE4]` | byte | Type/flags (bit7=infinite ammo, low7=shots) |
| `DS:[BX+0x2EE5]` | byte | Low nibble = heat/shot |
| `DS:[BX+0x2EE6]` | byte | Skill/class (low5/>>5 split) |
| `DS:[BX+0x2EE7]` | byte | Range threshold |
| `DS:[BX+0x2EE3]` | byte | Per-missile damage (LRM=1, SRM=2) |
| `DS:[SI+0x2EE8]` | byte | Weapon type for comparison |

### 12.3 Direction Tables (DS segment, 8 × word16)

| Address | Name | Purpose |
|---------|------|---------|
| `DS:0x328A` | `a328A[8]` | X-coordinate delta per direction |
| `DS:0x329A` | `a329A[8]` | Y-coordinate delta per direction |
| `DS:0x32AA` | `a32AA[8]` | X sub-pixel carry correction |
| `DS:0x32BA` | `a32BA[8]` | Y sub-pixel carry correction |
| `DS:0x32CA` | `a32CA[8]` | Extra map index advance for Y diagonal |
| `DS:0x311A–0x313A` | — | 8-direction tables for fn1631_0006 |

### 12.4 Cluster Hits Table

| Address | Type | Access |
|---------|------|--------|
| `DS:[0x566C]→0x2E5E` | byte[77] | `roll_2d6 × 7 + shots_column` |

### 12.5 Tile Property Tables

| Address | Type | Stride | Purpose |
|---------|------|--------|---------|
| `seg 246C + 0x7AD[tile_index]` | byte | 1 | LoS blocking, terrain visibility, movement cost |
| `DS:[0x55DC]→0x32C6` | byte | 0x30 | Terrain TN modifier (0xFF=impassable, 0=clear, higher=cover) |
| `+0x00` (b32C6) | byte | — | Property / cost |
| `+0x01` (b32C7) | byte | — | Packed X high |
| `+0x02` (b32C8) | byte | — | Packed X low |
| `+0x03` (b32C9) | byte | — | Sub-type / flags |
| `DS:[0x5654]→0x32C6` | byte | 0x30 | Same table, alternate access |
| `DS:[0x558A]→t0150` | byte | — | Skill gate threshold (global) |

### 12.6 Movement Stack Variables

| Address | Type | Purpose |
|---------|------|---------|
| `DS:0x238` | uint16 | Source X |
| `DS:0x23A` | uint16 | Source Y |
| `DS:0x23C` | uint16 | Dest X |
| `DS:0x23E` | uint16 | Dest Y |
| `DS:[BX+0x240]` | uint16[] | Direction lookup table |

---

## 13. RNG IMPLEMENTATION

### 13.1 RNG State

| Address | Size | Description |
|---------|------|-------------|
| `384B:4FC0` | byte | LFSR state byte 0 |
| `384B:4FC1` | byte | LFSR state byte 1 |
| `384B:4FC2` | byte | LFSR state byte 2 |
| `3EDB:4FC0` | byte | Same state (aliased segment) |

### 13.2 Algorithm (`unknown_19EF_0BC0_1AAB0`)

24-bit LFSR variant:
```
Operations: SHR, RCL, RCL, CMC, SBB, SHR, RCR, XOR on state bytes
Returns: byte in AL per call
```

### 13.3 Usage

| Function | RNG usage |
|----------|-----------|
| 2D6 roll | `RNG & 0x7`, rejection-sample >5, INC → 1..6 |
| Hit location | RNG-based cursor coord → vid mem address |
| Encounter probability | `RNG() & bD330 == 0` per frame |
| Encounter position | `RNG & 0x07 + 0x0A` (offset) |
| Enemy mech selection | `RNG % 3` (template index) |
| Enemy infantry equip | `RNG & 0x03` (4-option table) |
| Combat healing | RNG damage/healing values |
| BLD opcode E8 | `RNG() & mask != 0` → jump |

---

## 14. SEGMENT POINTERS REGISTRY

| DS Offset | Field Name | Points To | Purpose |
|-----------|------------|-----------|---------|
| `DS:0x5582` | `ptr5582` | `→0xA44B` | Cursor/target X |
| `DS:0x5584` | `ptr5584` | `→0xA44D` | Cursor/target Y |
| `DS:0x5586` | `ptr5586` | `→0x09ED` | Map tile data base |
| `DS:0x5588` | `ptr5588` | `→[idx+0x7AD]` | Tile blocking property |
| `DS:0x558A` | `ptr558A` | `→0x0150` | Skill gate threshold |
| `DS:0x558E` | `ptr558E` | `→aC744[]` | Story state segment (Eq_107947) |
| `DS:0x5590` | `ptr5590` | `→0x4004` | Unit X positions |
| `DS:0x5592` | `ptr5592` | `→0x4036` | Unit Y positions |
| `DS:0x5594` | `ptr5594` | — | (unit array segment) |
| `DS:0x559C` | `ptr559C` | `→0xE48E` | Combat-in-progress flag |
| `DS:0x55A6` | `ptr55A6` | `→[SI+0x92]` | Heat pool segment |
| `DS:0x5598` | `ptr5598` | `→[SI+0x6E]` | Heat penalty segment |
| `DS:0x5652` | `ptr5652` | `→0x2EE4` | Weapon instance table |
| `DS:0x5654` | `ptr5654` | `→0x32C6` | Terrain TN modifier table |
| `DS:0x5658` | `ptr5658` | `→[BX+0x92/0x8A]` | Heat accumulator segment |
| `DS:0x55D8` | `ptr55D8` | `→0x40B4/0x41D4` | Combat fog grids (12×24) |
| `DS:0x55DC` | `ptr55DC` | `→0x32C6` | Tile property table |
| `DS:0x566C` | `ptr566C` | `→0x2E5E` | Cluster hits table |
| `DS:0x5630` | `ptr5630` | `→0x14A` | Guard for dissipation call |
| `DS:0x5648` | `ptr5648` | `→[BX+0xD358]` | Enemy shot counter |
| `DS:0x5434` | `ptr5434` | `→0x2CF4` | Weapon data for infantry |
| `DS:0x5436` | `ptr5436` | `→0x2DF8` | Enemy mech template table |
| `DS:0x5460` | `ptr5460` | `→0x4602` | BLD index translation table (16B) |
| `DS:0x55D4` | `ptr55D4` | `→bC620` | Special encounter flag |
| `DS:0x569E` | `ptr569E` | struct Eq_80552 | Main game state struct |
| `DS:0x53A0` | `ptr53A0` | `→w4FBA` | w4FBA selector |
| `DS:0x5384` | — | `→0x3938` | w3938 access |
| `DS:0x5386` | — | `→0xD55C` | Text break flag access |
| `DS:0x5388` | — | `→0x37FE` | Text mode flag |
| `DS:0x538A` | — | `→0xD33D` | Fog guard segment |
| `DS:0x538C` | — | `→0xA44B` | Cursor X access (alt) |
| `DS:0x538E` | — | `→0xA44D` | Cursor Y access (alt) |
| `DS:0x5582–0x559C` | various | — | LoS segment pointers group |
| `DS:0x54C8` | — | — | Template arrays segment |
| `DS:0x1A58` | — | — | BTBORDER tile cache segment |

---

## 15. UNMAPPED / GAPS

These areas need further investigation:

| Area | Reason |
|------|--------|
| **Complete memory layout** of all data segments | Spice86 dump exists but not fully cross-referenced |
| **Sound/music data** at segment 204B | SoundBlaster config found but format unknown |
| **Character skill/level-up mechanics** | How skills increase (RNG-based? XP?) |
| **Save/load implementation** | File I/O interrupt handlers not traced |
| **Most Reko functions** (~1350 of ~1400) | Only ~50 have documented purposes |
| **EGA animation format** (.ANM XOR-delta) | Algorithm partially understood |
| **Item-to-unit ammo bridge** | How aD374 connects to mech ammo bins at +0x27 |
| **C618[bD314]++ anomaly** | Whether C618 stores packed (type<<N \| count) |
| **Tile buffer layout in 0x3092** | 4100 tiles × 128B, 3 pages — tile dims unknown |
| **Segment 135D ANM mapping** | How ANM file IDs map to animation sequence IDs |
| **w3988 animation guard trigger** | What sets it, when animation is paused |
| **BLD index translation table** | Per-location mapping from tile property → BLD index |
| **Segment 0x5594** | Unit array segment (not documented) |
| **Reko Eq structs** | Eq_57354, Eq_80552, Eq_49571 not fully mapped |

---

> **Built from:** TECHNICAL_ANALYSIS.md (2088 lines), Spice86 GeneratedCode*.cs (4762 lines), Reko .dis/.c files, Ghidra symbols (1427 entries), CONTEXT.md (668 lines), ADDRESS_REFERENCE.md (1035 lines).
> **Last updated:** 2026-05-28
