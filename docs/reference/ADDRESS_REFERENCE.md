# Complete Address Reference from TECHNICAL_ANALYSIS.md

## SECTION HEADINGS

```
# Technical Analysis of BattleTech: The Crescent Hawk's Inception
## Identified Destination Maps
## Combat System Analysis
### 1. OVERALL COMBAT FLOW
### 2. MOVEMENT PHASE
### 3. AI TARGET SELECTION
### 4. TARGETING / LINE OF SIGHT & RANGE CHECK
### 5. LINE OF SIGHT / FIRE VALIDATION
#### 5.1 Algorithm (Ray-Cast LoS)
#### 5.2 Direction Tables (8-entry word arrays in DS segment)
#### 5.3 Skill Gate (Tile Blocking Check)
#### 5.4 Segment Pointers for LoS
### 6. TO-HIT FORMULA (2D6 SYSTEM)
#### 6.1 2D6 Roll Generator
#### 6.2 To-Hit Target Number (TN)
#### 6.3 Heat Generation per Shot
#### 6.4 Heat Dissipation (End-of-Round Reset)
#### 6.5 Ammo Check
#### 6.6 Cluster Weapons — Damage Grouping
#### 6.7 Hit Determination
#### 6.8 RNG Usage in Hit Location
### 7. FIRE PHASE
### 8. GRID ADJACENCY / CRITICAL HIT TRANSFER
### 9. DAMAGE APPLICATION
### 10. RNG IMPLEMENTATION
### 11. POST-FIRE CLEANUP
### 12. COMBAT STATE MACHINE
### 13. DATA STRUCTURES REFERENCE
### 14. COMBAT PHASE MAPPING TO TABLETOP BATTLE TECH
### 15. KNOWN GAPS (STILL UNVERIFIED)
### 16. RNG IMPLEMENTATION
### 17. WORLD MAP RANDOM ENCOUNTER SYSTEM
#### 17.1 Core Check
#### 17.2 Probability Mask (bD330 at segment offset 0xD330)
#### 17.3 Encounter Population (fn0DAB_0D3D, segment 0DAB:0D3D)
#### 17.4 Encounter Positioning (fn183B_28DB, segment 183B:28DB)
#### 17.5 Mode Guards
#### 17.6 Encounter Initiation: fn183B_000A (segment 183B:000A)
#### 17.7 World Map Movement System
#### 17.8 World Map Coordinate System
#### 17.9 Relationship to Segment 0D27 (Action Menu)
#### 17.10 Encounter Flow Summary
## 17. STORY ARC & PROGRESSION SYSTEM
### 17.1 Three-Layer State Architecture
### 17.2 BLD Script Interpreter Architecture
### 17.3 BLD Opcode Dispatch (fn0FDC_01C0)
### 17.4 fn1CD3_0004 Case Dispatch (47 Cases, 0x01-0x2F)
### 17.5 fn1631_11AB Story Property Handler (segment 1631:11AB)
### 17.6 Complete Story Arc: Phase by Phase
### 17.7 Story State Data Structure (Eq_107947)
### 17.8 How the Map-Event System Drives the Story
### 17.9 The citadel attack chain in detail (TRAINING.BLD offset ~5900-6200)
### 17.10 Mech/Unit Inventory System
### 17.11 Shop and Inventory System
### 17.12 Player Interface System
### 17.13 Known Gaps
```

---

## 1. CODE SEGMENTS (EXECUTABLE SECTIONS)

### Combat System Segments

| Segment | Linear Range | Description | Source File |
|---------|-------------|-------------|-------------|
| `19EF` | `0x1A861-0x1BCE8` | Movement, RNG, fire phase, grid adjacency, damage application | `GeneratedCode18.cs`, `GeneratedCode19.cs` |
| `1000` | `0x105C5-0x14672` | Combat loop, targeting, LoS/range check, weapon data access | `GeneratedCode13.cs`, `GeneratedCode10.cs`, `GeneratedCode11.cs` |
| `0000` | `0x30DD-0x3113` | 2D6 to-hit roll generator | `GeneratedCode1.cs` |

### BLD / Story Segments

| Segment | Description |
|---------|-------------|
| `0FDC:0008` | fn0FDC_0008 — BLD entry point, loads data by index |
| `0FDC:01C0` | fn0FDC_01C0 — Bytecode interpreter (opcodes 0xE4-0xFF) |
| `0FDC:05F7` | fn0FDC_05F7 — Reads 16-bit LE absolute jump offset |
| `0FDC:1D30` | fn0FDC_1D30 — Prepares buffer for BLD data |
| `0FDC:13DE` | fn0FDC_13DE — Hospital/unit selection UI |
| `0FDC:15E6` | fn0FDC_15E6 — Garage/swap unit selection UI |
| `0FDC:17B9` | fn0FDC_17B9 — Close shop/action |
| `0FDC:1C9B` | fn0FDC_1C9B — Dispatch target |
| `0FDC:1A26` | fn0FDC_1A26 — Dispatch target |
| `1CD3:0004` | fn1CD3_0004 — Room/building interaction dispatcher (47-case switch, 0x01-0x2F) |
| `1CD3:17C6` | fn1CD3_17C6 — BLD processing (building text) |
| `1E56:03F5` | fn1E56_03F5 — Text renderer, cipher text decoder, word-wrapping |
| `1E56:0388` | fn1E56_0388 — Font/display params, text cleanup |
| `1E56:0281` | fn1E56_0281 — Set font |
| `1E56:0004` | fn1E56_0004 — Draw sprite |
| `1E56:0B5E` | fn1E56_0B5E — Computed GOTO dispatcher |
| `1E56:0D1D` | fn1E56_0D1D — Scancode remapper (WASD→arrows, numpad→diagonals) |
| `1E56:021D` | fn1E56_021D — Page flip, reset cursor position |
| `11B8:0D58` | fn11B8_0D58 — Room handler dispatcher |
| `11B8:0002` | fn11B8_0002 — Viewport/tile display |
| `11B8:080A` | fn11B8_080A — Building name/text overlay |
| `11B8:0925` | fn11B8_0925 — Text overlay |
| `11B8:104E` | fn11B8_104E — Render dispatch |
| `11B8:152F` | fn11B8_152F — Render dispatch |
| `11B8:1762` | fn11B8_1762 — Position/state management |
| `1631:11AB` | fn1631_11AB — Story property handler (properties 0x1C-0x23) |
| `1631:163E` | fn1631_163E — Counter/sequence operation |
| `1631:1FDF` | fn1631_1FDF — Repair/heal display function |
| `1631:0006` | fn1631_0006 — LoS pathfinding tile-step |
| `1AE8:000C` | fn1AE8_000C — Combat narrative handler |
| `1F3D:06C3` | fn1F3D_06C3 — Border dispatcher |
| `1F3D:0259` | fn1F3D_0259 — Key scanning input |
| `1F3D:086A` | fn1F3D_086A — Render room description |
| `1F3D:03EB` | fn1F3D_03EB — Mode-specific rendering param lookup |
| `1F3D:0006` | fn1F3D_0006 — Software timer decrement |
| `1F3D:002F` | fn1F3D_002F — Check key pending |
| `1F3D:0086` | fn1F3D_0086 — Sprite rendering |
| `1F3D:00D5` | fn1F3D_00D5 — Display helper |
| `0800:0000` | fn0800_0000 — Main game loop (6-phase) |
| `0800:051B` | fn0800_051B — Main unit processing (5-phase) |
| `0800:2C50` | fn0800_2C50 — SPACE menu handler (7 options) |
| `0800:218F` | fn0800_218F — Arrow key handler |
| `0800:240B` | fn0800_240B — Tile animation page swap |
| `0800:24C2` | fn0800_24C2 — Next animation frame |
| `0800:2A93` | fn0800_2A93 — World map tile renderer (64 tiles) |
| `0800:2DA8` | fn0800_2DA8 — Tile render |
| `0800:231D` | fn0800_231D — Key dispatch |
| `0800:2A2B` | fn0800_2A2B — Wait-for-key loop |
| `0800:48B7` | fn0800_48B7 — State machine init |
| `0800:1B8E` | fn0800_1B8E — Sub-dispatch |
| `0800:1A13` | fn0800_1A13 — State check |
| `0800:17BB` | fn0800_17BB — Movement dispatch high-level |
| `0800:186F` | fn0800_186F — Movement dispatch |
| `0800:191B` | fn0800_191B — Cursor snap |
| `0800:19DD` | fn0800_19DD — RNG-based attribute/2D6 generation |
| `0800:3D40` | fn0800_3D40 — Stat/inventory screen (SPACE menu option 6) |
| `0800:3FAE` | fn0800_3FAE — Stat screen rendering (8-phase) |
| `0800:3BD0` | fn0800_3BD0 — Party/equip (SPACE menu option 1) |
| `0800:378D` | fn0800_378D — Tech/repair (SPACE menu option 2) |
| `0800:32B3` | fn0800_32B3 — Enter building (SPACE menu option 4) |
| `0800:35D3` | fn0800_35D3 — Stock market (SPACE menu option 5) |
| `0800:4D57` | fn0800_4D57 — Special dispatch (SPACE menu option 7) |
| `0800:4CAC` | fn0800_4CAC — Cleanup |
| `0800:45C2` | fn0800_45C2 — w4FBA read-only sub-function |
| `0800:50C8` | fn0800_50C8 — Outer loop, initializes w4FBA to mode 0 |
| `0800:4DC7` | fn0800_4DC7 — Continue main menu |
| `0800:19F3` | fn0800_19F3 — RNG-sampled subcode generator |
| `0800:28A2` | fn0800_28A2 — Display helper (sets render mode to 0x0A/0x01) |
| `0800:29F5` | fn0800_29F5 — Credit display update |
| `183B:000A` | fn183B_000A — Encounter initiator |
| `183B:28DB` | fn183B_28DB — Encounter positioning |
| `183B:193B` | fn183B_193B — Movement-based fog clearing |
| `0D27:0044` | fn0D27_0044 — Action menu handler (segment 0D27) |
| `0DAB:0D3D` | fn0DAB_0D3D — Encounter population |
| `1467:0002` | fn1467_0002 — Trigger action / rebuild mode |
| `1431:0091` | fn1431_0091 — Map tile render |
| `1431:000A` | fn1431_000A — Star map (SPACE menu option 3) |
| `135D:0004+0x0000` | DISP — Display animation frame |
| `135D:0004+0x0010` | LOAD — Load animation data from ANM file |
| `135D:0004+0x0020` | INIT — Initialize animation sequence |
| `135D:0004+0x0030` | CLEAR — Clear animation state |
| `1543:0CDE` | fn1543_0CDE — Numeric keypad input |
| `204B` | Segment for SoundBlaster/PC Speaker interrupt handler |
| `094C:0008` | unknown_094C_0008_094C8 — BLD index translation |
| `094C:17B9` | unknown_094C_17B9_0AC79 — BLD index translation |
| `207F:0BC0` | fn207F_0BC0 — RNG (same algorithm, segment 207F) |
| `207F:2FDC` | fn207F_2FDC — Save segment context |
| `207F:18EF` | fn207F_18EF — Screen refresh (13×12 tile grid) |
| `207F:1CB8` | fn207F_1CB8 — Full border draw |
| `207F:1D3A` | fn207F_1D3A — Narrow border draw |
| `207F:245C` | fn207F_245C — Text overlay border |
| `207F:24D7` | fn207F_24D7 — Core EGA framebuffer blitter (4 cases) |
| `207F:275C` | fn207F_275C — VGA pixel writer (4 sub-modes) |
| `207F:158C` | fn207F_158C — Move cursor UP |
| `207F:163B` | fn207F_163B — Move cursor DOWN |
| `207F:16E3` | fn207F_16E3 — Move cursor LEFT |
| `207F:17C5` | fn207F_17C5 — Move cursor RIGHT |
| `207F:1314` | fn207F_1314 — Set cursor position |
| `207F:1DF8` | fn207F_1DF8 — Calculate tile index from cursor |
| `207F:1B80` | fn207F_1B80 — Configure viewport dimensions |
| `207F:1A97` | fn207F_1A97 — Apply clipping to coordinates |
| `207F:28A8` | fn207F_28A8 — 128-byte memcpy for tile animation |
| `207F:28EB` | fn207F_28EB — Tile blit to framebuffer |
| `207F:1AA8` | fn207F_1AA8 — Partial tile write |
| `207F:1ACE` | fn207F_1ACE — Full tile + left edge write |
| `207F:1AF4` | fn207F_1AF4 — Full tile write |
| `207F:1DA8` | fn207F_1DA8 — Tile render under cursor |
| `207F:3BB6` | fn207F_3BB6 — Display helper |
| `207F:3BD2` | fn207F_3BD2 — Format credits display |
| `207F:3D1C/3D44/3D6C` | fn207F_3D1C/3D44/3D6C — Stock price update |
| `207F:2209` | fn207F_2209 — Font blitter (mode 0) |
| `207F:21A8` | fn207F_21A8 — Font blitter (mode 1) |
| `207F:2251` | fn207F_2251 — Font blitter (mode 2) |
| `207F:22A5` | fn207F_22A5 — Font blitter (mode 3) |
| `207F:1FBE` | fn207F_1FBE — Screen clear |
| `207F:104E` | fn207F_104E — BTSTATS tile render |
| `207F:0A9F` | fn207F_0A9F — Text-mode tile addressing |

### Combat Functions (by Ghidra name)

| Function | Segment:Offset | Linear Address | Description |
|----------|---------------|----------------|-------------|
| `ghidra_guess_1000_458C_1458C` | `1000:458C` | `0x1458C` | Combat handler entry |
| `ghidra_guess_1000_0934_10934` | `1000:0934` | `0x10934` | Unit state check / targeting (returns 0-3) |
| `ghidra_guess_1000_0AB2_10AB2` | `1000:0AB2` | `0x10AB2` | AI target selection (n-th valid target from preference table) |
| `ghidra_guess_1000_160E_1160E` | `1000:160E` | `0x1160E` | LoS/fire validation (ray-cast) |
| `ghidra_guess_1000_05C5_105C5` | `1000:05C5` | `0x105C5` | LoS/range check |
| `ghidra_guess_1000_0673_10673` | `1000:0673` | `0x10673` | Heat dissipation (end-of-round) |
| `ghidra_guess_1000_1554_11554` | `1000:1554` | `0x11554` | Skill modifier (popcount of low 3 bits) |
| `ghidra_guess_0000_30DD_030DD` | `0000:30DD` | `0x30DD` | 2D6 roll generator |
| `ghidra_guess_0000_30F3_030F3` | `0000:30F3` | `0x30F3` | Single D6 roll |
| `ghidra_guess_0000_2EBB_02EBB` | `0000:2EBB` | `0x02EBB` | Coordinate utility |
| `ghidra_guess_0000_2F6F_02F6F` | `0000:2F6F` | `0x02F6F` | 8-direction angle calculation |
| `unknown_19EF_0971_1A861` | `19EF:0971` | `0x1A861` | Movement phase — direction calculation |
| `unknown_19EF_0BC0_1AAB0` | `19EF:0BC0` | `0x1AAB0` | 24-bit LFSR RNG |
| `unknown_19EF_1886_1B776` | `19EF:1886` | `0x1B776` | Fire phase (9 body part/weapon mount pairs) |
| `unknown_19EF_11BB_1B0AB` | `19EF:11BB` | `0x1B0AB` | Grid adjacency / critical hit transfer |
| `unknown_19EF_12BA_1B1AA` | `19EF:12BA` | `0x1B1AA` | Helper: grid adjacency |
| `unknown_19EF_12F2_1B1E2` | `19EF:12F2` | `0x1B1E2` | Helper: grid adjacency |
| `unknown_19EF_12D9_1B1C9` | `19EF:12D9` | `0x1B1C9` | Helper: grid adjacency |
| `unknown_19EF_18EF_1B7DF` | `19EF:18EF` | `0x1B7DF` | Damage application |
| `unknown_19EF_1DF8_1BCE8` | `19EF:1DF8` | `0x1BCE8` | Post-fire cleanup |
| `split_1000_A8C6_1A8C6` | `1000:A8C6` | `0x1A8C6` | Binary search refinement for movement direction |

---

## 2. COMBAT DATA — REGISTER-RELATIVE / STACK VARIABLES

| Address/Symbol | Type | Purpose |
|----------------|------|---------|
| `[BP-0x78]` | 24-byte array | Per-unit combatant state (zero-initialized) |
| `[BP-0x28]` | uint16 | Unit slot iterator (0..0x17, max 24) |
| `[BP-0x42]` | uint16 | Combat stage/phases sub-counter (0..0xB..0xC) |
| `[BP-0x30]` | uint16 | To-hit target number (TN) accumulator |
| `[BP-0x60]` | uint16 | Hit location / damage variance |
| `[BP-0x56]` | uint16 | Hit flag (0/1) |
| `[BP-0x2]` | uint16 | AI match counter (used in target selection) |
| `[BP-0x8]` | uint16 | AI result register (target_id or 0xFF) |
| `[BP-0x4]` | uint16 | AI property offset iterator (initial 0x33) |
| `[BP+0x6]` | stack param | Movement: Source X, Targeting: Unit ID |
| `[BP+0x8]` | stack param | Movement: Source Y, Targeting: param/weapon, AI: stage_counter |
| `[BP+0xA]` | stack param | Movement: Dest X, Targeting: target_x |
| `[BP+0xC]` | stack param | Movement: Dest Y, Targeting: target_y |

---

## 3. UNIT POSITION / STATUS ARRAYS

| Address | Type | Stride | Elements | Purpose |
|---------|------|--------|----------|---------|
| `ES:[ID*2 + 0x4004]` | uint16 | 2 | 24+ | Unit X coordinate (segment from DS:0x5590/0x5592) |
| `ES:[ID*2 + 0x4036]` | uint16 | 2 | 24+ | Unit Y coordinate |
| `ES:[ID*2 + 0x406A]` | uint16 | 2 | 24+ | Unit status (0=dead/inactive) |
| `ES:[0x40B4]` | uint16 | per-unit | — | Unit property byte (type/flags) |
| `ES:[0x40B5]` | uint16 | per-unit | — | Unit secondary property |
| `ES:[BX + 0x92]` | byte | — | — | Player unit heat pool |
| `ES:[BX + 0x8A]` | byte | — | — | Enemy unit heat pool |
| `ES:[BX + 0x6E]` | byte | — | — | Player heat penalty accumulator |
| `ES:[BX + 0x66]` | byte | — | — | Enemy heat penalty register |
| `ES:[SI + 0xD576]` | byte | — | — | Extra heat penalty counter |

---

## 4. CURSOR / TARGET POSITION

| Address | Segment Source | Type | Purpose |
|---------|----------------|------|---------|
| `ES:[0xA44B]` / `tA44B` | DS:0x5582 → A44B | uint16 | Cursor/target X coordinate |
| `ES:[0xA44D]` / `tA44D` | DS:0x5584 → A44D | uint16 | Cursor/target Y coordinate |
| `tA44B` at segment `0x569E` offset `+0x0131` | — | uint16 | Cursor X (low byte=pixel column, high byte=sub-pixel / grid flags) |
| `tA44D` at segment `0x569E` offset `+0x012F` | — | uint16 | Cursor Y (low byte=row, high byte=flags) |

---

## 5. WEAPON DATA TABLE (stride 17 = 0x11)

| Field | Instance Offset | Type | Description |
|-------|-----------------|------|-------------|
| Name | `+0x00` | 10 bytes ASCII | Weapon name, null-padded |
| Damage | `+0x0A` | uint8 | Damage value |
| Shots/Ammo | `+0x0B` | uint8 | Ammo count (0x81 = infinite?) |
| Heat | `+0x0C` | uint8 | Heat generated per shot |
| Sound/VFX | `+0x0D` | uint8 | Sound effect / visual effect |
| Range | `+0x0E` | uint16 LE | Maximum range |
| Skill | `+0x10` | uint8 | Skill class (0=B&Blades, 1=Pistol, 2=Rifle, 3=Gunnery, 4=Kick) |

### Weapon Instance Table Access

| Address | Type | Purpose |
|---------|------|---------|
| `DS:[0x5652]→0x2EE4` | byte (stride 0x11) | Weapon instance table base |
| `DS:[BX + 0x2EE4]` | byte | Weapon type/flags byte (bit 7=infinite ammo, low 7=remaining shots) |
| `DS:[BX + 0x2EE5]` | byte | Low nibble `& 0x0F` = heat per shot |
| `DS:[BX + 0x2EE6]` | byte | Skill/class (split: low 5 bits, high 3 bits>>5) |
| `DS:[BX + 0x2EE7]` | byte | Range threshold byte |
| `DS:[BX + 0x2EE3]` | byte | Per-missile damage (0x01=LRM, 0x02=SRM) |
| `DS:[SI + 0x2EE8]` | byte | Weapon type for comparison |
| `DS:[index + 0x2E43]` | byte | Hit location modifier (2-entry table) |

### Ammo Decrement Targets

| Address | Formula | Type | Purpose |
|---------|---------|------|---------|
| `0x2A02:C74B + unit_id * 0x7D + stage_counter` | player units 0-3 | byte | Player ammo decrement (stage_counter=0..0xA) |
| `0x2A02:C363 + unit_id * 0x7D + stage_counter` | enemy mechs 12-15 | byte | Enemy mech ammo decrement |
| `0x2A02:C5D4 + unit_id * 0x11 + weapon_type_field` | enemy infantry 4-11 | byte | Burst counter (capped at 4) |
| `DS:[0x5648]→[BX+0xD358]` | — | byte | Enemy shot counter |
| `[BX+0xD360]` | — | byte | Enemy weapon type |

### Cluster Weapons

| Address | Type | Purpose |
|---------|------|---------|
| `DS:[0x566C]→0x2E5E` | byte table | Cluster hits table (7-byte stride, 11 rows, columns 0-6) |
| `roll_2d6 * 7 + shots_byte` | formula | Index into cluster table |

---

## 6. MOVEMENT & LOS DIRECTION TABLES (8 × word16, DS segment)

| Address | Reko Name | Type | Content / Purpose |
|---------|-----------|------|-------------------|
| `DS:0x238` | — | uint16 | Movement source X (stored from stack) |
| `DS:0x23A` | — | uint16 | Movement source Y |
| `DS:0x23C` | — | uint16 | Movement dest X |
| `DS:0x23E` | — | uint16 | Movement dest Y |
| `DS:[BX + 0x240]` | — | uint16[] | Direction lookup table (indexed by DX nibble) |
| `DS:a328A` (0x328A) | `a328A[]` | 8 × word16 | X-coordinate delta per 8-direction |
| `DS:a329A` (0x329A) | `a329A[]` | 8 × word16 | Y-coordinate delta per 8-direction |
| `DS:a32AA` (0x32AA) | `a32AA[]` | 8 × word16 | X sub-pixel carry correction |
| `DS:a32BA` (0x32BA) | `a32BA[]` | 8 × word16 | Y sub-pixel carry correction |
| `DS:a32CA` (0x32CA) | `a32CA[]` | 8 × int16 | Extra map index advance for Y diagonal |
| `DS:0x311A`-`0x313A` | — | — | 8-direction delta tables for fn1631_0006 |

---

## 7. TILE PROPERTY TABLES

| Address | Type | Stride | Purpose |
|---------|------|--------|---------|
| `DS:[0x55DC]→0x32C6` | byte | 0x30 (48) per unit slot | Terrain TN modifier table. `0xFF`=impassable, `0x00`=clear, higher=more cover |
| `+0x00` (`b32C6`) | byte | — | Tile property / movement cost |
| `+0x01` (`b32C7`) | byte | — | Packed X-coordinate high |
| `+0x02` (`b32C8`) | byte | — | Packed X-coordinate low |
| `+0x03` (`b32C9`) | byte | — | Sub-type / flag field |
| `DS:[0x5654]→0x32C6` | byte | 0x30 | Same terrain table, alternate segment access |
| `DS:[0x5588]→[index+0x7AD]` | byte | 1 | LoS blocking / tile property per tile |
| `seg 246C +0x7AD[tile_index]` | byte | 1 | Tile blocking strength for rendering/visibility |
| `DS:[0x558A]→t0150` | byte | — | Skill gate threshold (global) |
| `ES:[BX + 0x2D1A]` | byte | — | Additional terrain/status table modifier |
| `DS:(0x32C6)` at segment [0x5460] | byte | 16 (translation) | BLD index translation table loaded from MTP header |
| `0x3092:4602` | byte[16] | — | Translation table: tile property → BLD file index |

---

## 8. SEGMENT POINTERS (DS:Offset → Memory)

| DS Offset | Field Name | Points To | Purpose |
|-----------|------------|-----------|---------|
| `DS:0x5582` | `ptr5582` | `→A44B` | Cursor/attacker X |
| `DS:0x5584` | `ptr5584` | `→A44D` | Cursor/attacker Y |
| `DS:0x5586` | `ptr5586` | `→09ED` | Map tile data base pointer |
| `DS:0x5588` | `ptr5588` | `→[index+0x7AD]` | Tile blocking property |
| `DS:0x558A` | `ptr558A` | `→0150` | Skill gate threshold |
| `DS:0x558E` | `ptr558E` | `→aC744[]` | Story state segment (Eq_107947 array) |
| `DS:0x5590` | `ptr5590` | `→0x4004` | Unit X positions base |
| `DS:0x5592` | `ptr5592` | `→0x4036` | Unit Y positions base |
| `DS:0x559C` | `ptr559C` | `→E48E` | Combat-in-progress flag |
| `DS:0x55A6` | `ptr55A6` | `→[SI+0x92]` | Heat pool segment |
| `DS:0x5598` | `ptr5598` | `→[SI+0x6E]` | Heat penalty segment |
| `DS:0x5652` | `ptr5652` | `→0x2EE4` | Weapon instance table |
| `DS:0x5658` | `ptr5658` | `→[BX+0x92]/[BX+0x8A]` | Heat accumulator segment |
| `DS:0x5654` | `ptr5654` | `→0x32C6` | Terrain TN modifier table |
| `DS:0x55D8` | `ptr55D8` | `→0x40B4/0x41D4` | Combat fog grids (12×24 each) |
| `DS:0x55DC` | `ptr55DC` | `→0x32C6` | Tile property table (terrain TN) |
| `DS:0x566C` | `ptr566C` | `→0x2E5E` | Cluster hits table |
| `DS:0x5630` | `ptr5630` | `→[0x14A]` | Guard for dissipation call |
| `DS:0x5648` | `ptr5648` | `→[BX+0xD358]` | Enemy shot counter |
| `DS:0x5434` | `ptr5434` | `→0x2CF4` | Weapon instance data for infantry |
| `DS:0x5436` | `ptr5436` | `→0x2DF8` | Enemy mech template table (3 entries) |
| `DS:0x5460` | `ptr5460` | `→0x4602` | BLD index translation table (16 bytes) |
| `DS:0x55D4` | `ptr55D4` | `→bC620` | Special encounter flag |
| `DS:0x5582`-`0x559C` | various | — | LS segment pointers for LoS checks |
| `DS:0x569E` | `ptr569E` | struct Eq_80552 | Main game state struct (w4FBA, shop data, etc.) |
| `DS:0x53A0` | `ptr53A0` | `→w4FBA` | Selector for w4FBA |

---

## 9. GAME STATE VARIABLES (by name)

### World Map / Encounter State

| Name | Address | Type | Purpose |
|------|---------|------|---------|
| `bD310` | `0xD310` | byte | World map active flag (0/1) |
| `bD330` | `0xD330` | byte | Encounter probability mask (`0x1F`=1/32, `0x7F`=1/128) |
| `bD346` | `0xD346` | byte | Star map / alternate view flag |
| `bD335` | `0xD335` | byte | Encounter movement cooldown timer (0x3F=63 frames) |
| `bD343` | `0xD343` | byte | Timer cascade part 1 (citadel attack trigger) |
| `bD344` | `0xD344` | byte | Timer cascade part 2 |
| `bD345` | `0xD345` | byte | Timer cascade part 3 |
| `bD329` | `0xD329` | byte | UI timer |
| `bD320` | `0xD320` | byte | Generic timer |
| `bD321` | `0xD321` | byte | Generic timer |
| `bD322` | `0xD322` | byte | Generic timer |
| `bD323` | `0xD323` | byte | Economy/production timer (3-day cycle) |
| `bD33D` | `0xD33D` | byte | Fog update guard flag |
| `bD30E` | `0xD30E` | byte | Building entry variant flag |
| `bD334` | `0xD334` | byte | Post-dispatch flag (case 0x28) |
| `b37FE` / `w37FE` | — | uint16 | Text mode flag (0x0F after encounter population) |
| `w37FE` | — | uint16 | Encounter active count |
| `t3770` | — | uint16 | Search step range (0x1E = 30) |
| `w3938` | — | uint16 | Key wait state gate |
| `t458E`/`t4590` | — | uint16 | Movement offset deltas (LoS stepping output) |
| `t400C`/`t403E` | — | uint16 | Location offset for encounter positioning |

### Story State Flags

| Name | Address | Type | Purpose |
|------|---------|------|---------|
| `bD450` | `0xD450` | byte | Training complete marker (0/1) |
| `bD451` | `0xD451` | byte | Milestone marker (0/1) |
| `bD456` | `0xD456` | byte | Unit ID incrementing counter |
| `bD55E` | `0xD55E` | byte | Story slot backup flag |
| `bD31A` | `0xD31A` | byte | State variable / story slot index |
| `bD31B` | `0xD31B` | byte | Equipment slot 5 flag |
| `bD31C` | `0xD31C` | byte | Count result (story/uppercase slots) |
| `bD325` | `0xD325` | byte | Equip consistency mismatch flag |
| `bD326` | `0xD326` | byte | Garage service table index |
| `bD32B` | `0xD32B` | byte | Copied slot flag |
| `bD331` | `0xD331` | byte | Unit slot index |
| `bD332` | `0xD332` | byte | Room handler gate |
| `w0152` | `0x0152` | uint16 | Game loop exit flag (0=running) |
| `w014A` | `0x014A` | uint16 | Screen refresh needed flag |
| `w01A8` | `0x01A8` | uint16 | BLD force processing flag |
| `w4FBA` | `0x569E:0x00FD` | uint16 | Global UI mode (0=WorldMap, 1=LocalTiles, 2=Text, 3=BuildingName) |
| `wE484` | — | uint16 | Story action complete flag (set by property 0x20 when cap reached) |
| `wD55C` | — | uint16 | Text processing break flag |
| `w3988` | — | uint16 | Animation page swap guard flag |
| `w5800` | — | uint16 | Animation page counter (0→1→2→0 cycles) |
| `0x57FE` | — | uint16 | Animation frame counter (wraps at 3) |
| `wArg06` | — | uint16 | Variable function parameter |
| `wArg04` | — | uint16 | Variable function parameter |

### General State Array

| Name | Address | Type | Purpose |
|------|---------|------|---------|
| `D30C` | `0xD30C` | byte[256] | Generic state array (day-to-day: shop, quest, party, flags) |

### Economy / Credits

| Name | Address | Type | Purpose |
|------|---------|------|---------|
| `tD370` | `0xD370` | uint16 | Credits low word |
| `tD372` | `0xD372` | uint16 | Credits high word |
| `wD390`/`wD392` | — | uint16[] | Stock value arrays (stride 0x1A = 26 bytes) |
| `wD394`/`wD396` | — | uint16[] | Alternate stock fields |
| `0x4024`/`0x4056` | — | uint16[] | Alternate stock value storage / saved positions |
| `0x4564`/`0x4572` | — | — | Stock value source tables |
| `0x4596`/`0x45A4` | — | — | Stock value source tables |

### Combat Fog Grids

| Address | Type | Size | Purpose |
|---------|------|------|---------|
| `DS:[0x55D8]→0x40B4` | byte | 12×24=288 | Combat Fog Grid A (init 0x02=fogged) |
| `DS:[0x55D8]→0x41D4` | byte | 12×24=288 | Combat Fog Grid B (init 0x02=fogged) |
| `0xCB0C` | bit-packed | — | World map visibility bits (128×128 bit grid) |
| `0xCAFC`/`0xCB1C` | — | — | Additional fog/visibility grids |

---

## 10. RNG STATE

| Address | Type | Size | Purpose |
|---------|------|------|---------|
| `384B:4FC0` | byte | 3 bytes | LFSR state byte 0 (S0) |
| `384B:4FC1` | byte | 3 bytes | LFSR state byte 1 (S1) |
| `384B:4FC2` | byte | 3 bytes | LFSR state byte 2 (S2) |
| `3EDB:4FC0` | byte | 3 bytes | Same RNG state (aliased segment) |
| `DS = 0x1DDC` | segment | — | DS value for RNG access in segment 19EF |

---

## 11. STORY STATE DATA STRUCTURE (Eq_107947, stride 0x7D = 125 bytes)

Array `aC744[]` at segment pointed by `DS:0x558E`. Base `0xC724` for slot 0.

| Offset | Field | Type | Purpose |
|--------|-------|------|---------|
| `+0x00` | `b0000` | byte | Generic per-story status (cleared by property 0x20 completion) |
| `+0x04` | `b0004` | byte | Nibble-packed flag field (inventory/equipment) |
| `+0x05` | `b0005` | byte | Nibble-packed flag field |
| `+0x06` | `b0006` | byte | Timing/counter nibble |
| `+0x1F` | `b001F` | byte | Story state / property gate |
| `+0x20` | `b0020` | byte | Story state / property gate |
| `+0x24` | `b0024` | byte | Skill property (popcount low 3 bits → 0-3) |
| `+0x25` | `b0025` | byte | Skill property (popcount low 3 bits → 0-3) |
| `+0x27` | Ammo[0] | byte | First current ammo bin (offset within mech struct) |
| `+0x30` | WalkMove | uint16 | Walk movement points |
| `+0x31` | JumpMove | uint16 | Jump movement points |
| `+0x33`-`0x55` | Target pref. table | byte[35] | AI target preference sequence |
| `+0x55` | `b0055` | byte | Counter for property 0x20 major steps (capped at 3) |
| `+0x56` | `b0056` | byte | Counter for property 0x20 minor steps (capped at 2) |
| `+0x57` | `b0057` | byte | Story state (0=Training, 1=Citadel Attacked, 2=Post-Attack) |
| `+0x58` | `b0058` | byte | One-shot latch/marker for property 0x1F |
| `+0x69` | `b0069` | byte | Upper nibble comparison target for `b0024` |
| `+0x6A` | `b006A` | byte | Upper nibble comparison target for `b0025` |
| `+0x75` | `b0075` | byte | Encounter/combat state |
| `+0x76` | `b0076` | byte | Encounter/combat state |
| `+0x79` | `b0079` | byte | Primary unit slot index (0xFF=unassigned) |
| `+0x7A` | `b007A` | byte | Secondary unit slot index (0xFF=unassigned) |
| `+0x7B` | Mech ID | byte | Mech type ID (e.g., 0x00=Locust, 0xC8=Chameleon) |
| `0xC724 + unitID * 0x7D` | — | — | Story state byte read for skill modifiers |
| `0xC79B` (= `0xC724 + 0x77`) | — | byte | Story state penalty check (citadel attacked = 0 → +2 TN) |
| `0xC530[slot * 0x7D]` | Guard byte | byte | Template occupancy check (`!= ~0x00`) |
| `D566[slot]` | — | byte | Post-copy template flag (0x00 or 0x92) |
| `bC61F[1][slot]` | — | byte | Infantry weapon class |
| `C618[slot][0..6]` | — | byte[7] | Infantry random item types 0-3 |

### Mech Data Layout (125 bytes, within story slot array)

| Offset Range | Field | Type | Size |
|-------------|-------|------|------|
| `+0x00` | Name | char[] | 15 |
| `+0x0F` | Tonnage | uint8 | 1 |
| `+0x10` | CurrentArmour | uint8[] | 11 |
| `+0x1B` | CurrentStructure | uint8[] | 8 |
| `+0x23` | CurrentActuators | uint8[] | 4 |
| `+0x27` | EngineHeatSinks | uint8 | 1 |
| `+0x28` | CurrentAmmo | uint8[] | 10 |
| `+0x32` | WalkMove | uint8 | 1 |
| `+0x33` | JumpMove | uint8 | 1 |
| `+0x34` | CritSlotData | uint8[] | 47 |
| `+0x63` | MaxArmour | uint8[] | 11 |
| `+0x6E` | MaxStructure | uint8[] | 8 |
| `+0x76` | MaxActuators | uint8[] | 4 |
| `+0x7A` | MaxAmmo | uint8[] | 10 |
| `+0x7C` | Unknown | uint8[] | 4 |

---

## 12. UNIT SLOT DATA STRUCTURE (aC614[], stride 17 = 0x11, 8 entries)

| Offset | Field | Type | Purpose |
|--------|-------|------|---------|
| `+0x00` | `b0000` | byte | Unit type ID (0xFF=empty slot) |
| `+0x01` | `b0001` | byte | Generated attribute (from `fn0800_19DD`) |
| `+0x08` | `b0008` | byte | Derived attribute (= b0001 * 10, halved if slot≥4) |
| `+0x09` | `b0009` | byte | Another generated attribute |
| `+0x0C` | `b000C` | byte | Linked story slot index (0x08=unassigned) |
| `+0x0D` | `b000D` | byte | Supplementary attribute |
| `+0x0E` | `b000E` | byte | Supplementary attribute |
| `+0x0F` | `b000F` | byte | Supplementary attribute |

---

## 13. SHOP / INVENTORY DATA STRUCTURES (segment 0x569E, Eq_80552)

| Name | Type | Purpose |
|------|------|---------|
| `C618[0..2]` | uint16[3] | 3 item type numbers displayed in shop |
| `bD314` | byte | Selection cursor (0-2) |
| `bD315` | byte | Purchase success flag |
| `bD316` | byte | Discount/insurance flag for hospital |
| `bD317` | byte | Repair success flag |
| `bD318` | byte | Bulk quantity threshold (6 or 9, used in case 0x0B) |
| `bD31A` | byte | State variable for unit operations |
| `tD370` | uint16 | Credits low word |
| `tD372` | uint16 | Credits high word |
| `aD374[]` | uint32[] | Per-item-type player quantity array (stride 4) |
| `aD376[]` | uint16[] | Per-item-type player data array (stride 2) |

### Price / Cost Tables

| Address | Type | Purpose |
|---------|------|---------|
| `ds:0x4F26/0x4F28` | uint16[?] | Healing cost table (case 0x09) |
| `ds:0x4F44/0x4F46` | uint16[?] | Unit purchase cost table (case 0x0B) |
| `ds:0x4F6E` | uint16[?] | Garage service cost table (case 0x18) |
| `0x4DDB` | table | Equipment validation table (case 0x20) |

### Shop Case Reference

| Case | Purpose | Called From |
|------|---------|-------------|
| 0x01 | ENTER_BUILDING | BLD |
| 0x02 | SHOW_GREETING | BLD |
| 0x03 | EXIT_BUILDING | BLD |
| 0x04 | SHOW_SHOP_ITEMS | BLD |
| 0x05 | BUY_ITEM_SINGLE | BLD |
| 0x06 | SHOW_PLAYER_ITEMS | BLD |
| 0x07 | BUY_ITEM_BULK | BLD |
| 0x08 | SELL_ITEM_BULK | BLD |
| 0x09 | HOSPITAL_HEAL | BLD |
| 0x0A | SHOW_CREDITS | BLD |
| 0x0B | BUY_WITH_UNIT_SEL | BLD |
| 0x0C | CLOSE_ACTION | BLD |
| 0x0D | EQUIPMENT_MENU | BLD |
| 0x0E | COUNT_UNIT_SLOTS | BLD |
| 0x0F | EQUIP_SLOT5 | BLD |
| 0x10 | CHECK_EQUIP_SLOT5 | BLD |
| 0x11 | COUNT_STORY_SLOTS | BLD |
| 0x12 | DISPATCH_11B8_0002 | BLD |
| 0x13 | DISPATCH_11B8_080A | BLD |
| 0x14 | DISPATCH_11B8_0925 | BLD |
| 0x15 | EQUIP_SLOT6 | BLD |
| 0x16 | CHECK_EQUIP_SLOT6 | BLD |
| 0x17 | EQUIP_CONSISTENCY | BLD |
| 0x18 | GARAGE_SERVICE | BLD |
| 0x19 | FLAG_D450 | BLD |
| 0x1A | FLAG_D451 | BLD |
| 0x1B | GOTO_2E_SHARED | BLD |
| 0x1C | CLEAR_ALL_SLOTS | BLD |
| 0x1D | COUNT_UPPERCASE | BLD |
| 0x1E | DISPATCH_11B8_104E | BLD |
| 0x1F | READ_SLOT_FLAG | BLD |
| 0x20 | COMPLEX_EQUIP | BLD |
| 0x21 | DISPATCH_0FDC_1C9B | BLD |
| 0x22 | DISPATCH_0FDC_1A26 | BLD |
| 0x23 | NEW_GAME_INIT | BLD |
| 0x24 | READ_UNIT_SLOT | BLD |
| 0x25 | CLEAR_UNIT_SLOT | BLD |
| 0x26 | READ_D456 | BLD |
| 0x27 | TRIGGER_ACTION | BLD |
| 0x28 | DISPATCH_11B8_152F | BLD |
| 0x29 | COMBAT_HEAL | BLD |
| 0x2A | SAVE_POSITIONS | BLD |
| 0x2B | RESTORE_POSITIONS | BLD |
| 0x2C | DISPATCH_11B8_1762 | BLD |
| 0x2D | COMBAT_ENCOUNTER | BLD |
| 0x2E | RESTORE_SLOTS | BLD |
| 0x2F | DECREMENT_STATE | BLD |

---

## 14. AMMO SLOT MAPPING

| Combat Unit | Story Slot | Ammo Address (base + id × stride + stage) | Stride | Type |
|-------------|------------|-------------------------------------------|--------|------|
| 0-3 | 0-3 | `0x2A02:C74B + id × 0x7D + stage` | 0x7D = 125 | byte |
| 4-11 | (separate) | `0x2A02:C5D4 + id × 0x11 + weapon_type` | 0x11 = 17 | byte (burst, capped 4) |
| 12-15 | 4-7 | `0x2A02:C363 + id × 0x7D + stage` | 0x7D = 125 | byte |

### Base Addresses
| Address | Formula | Purpose |
|---------|---------|---------|
| `0xC724` | `0xC79B - 0x77` | Base of story slot array Eq_107947[0] |
| `0xC74B` | `0xC724 + 0x27` | Base for player ammo (offset +0x27 in story slot) |
| `0xC363` | `0xC724 + (0-8) × 125 + 0x27` = `0xC724 - 0x3C1` | Remapped base for enemy mech ammo (slots 4-7) |
| `0xC5D4` | — | Enemy infantry burst counter base |

---

## 15. FIRE PHASE — 9 BODY PART PAIRS

Each pair iterated in `unknown_19EF_1886_1B776`, stride 0x40 (64):

| Iteration | SI (source) | DI (dest) | Body Location |
|-----------|-------------|-----------|---------------|
| 1 | `0x564` | `0x324` | Right Arm |
| 2 | `0x5A4` | `0x364` | Right Leg |
| 3 | `0x5E4` | `0x3A4` | Right Torso |
| 4 | `0x624` | `0x3E4` | Head |
| 5 | `0x664` | `0x424` | Center Torso |
| 6 | `0x6A4` | `0x464` | Left Arm |
| 7 | `0x6E4` | `0x4A4` | Left Leg |
| 8 | `0x724` | `0x4E4` | Left Torso |
| 9 | `0x764` | `0x524` | Center Torso (rear) |

---

## 16. SAVE FILE LAYOUT

| Offset | Content | Size (bytes) | Type |
|--------|---------|-------------|------|
| `0x01`-`0x88` | Infantry characters 01-08 | 8 × 17 = 136 | 8 infantry characters |
| `0x89`-`0x110` | Enemy infantry 01-04 | 4 × 17 = 68 | 4 enemy infantry characters |
| `0x111`-`0x288` | Lance mechs 01-04 | 4 × 125 = 500 | 4 lance mech structs (story slots 0-3) |
| `0x289`-`0x304` | — | 124 | (gap?) |
| `0x305`-`0x4F8` | Enemy mechs 01-04 | 4 × 125 = 500 | 4 enemy mech structs (story slots 4-7) |
| `0x4F9` | Map visibility | 2048 | Bit-packed 128×128 world map visibility |
| `0xCF9` | Flags | — | CitadelMissionFlag, etc. |
| `0xD5D` | Finance | — | C-Bills + 3 stock values |
| `0xF45` | Position | — | PartyMapPositionX/Y |

---

## 17. BLD INTERPRETER — OPCODES (0xE4-0xFF)

| Opcode | Reko Case | Operand | Description |
|--------|-----------|---------|-------------|
| `0xE4` | `~0x1B` | 1 byte | WRITE_CHAR — Read byte, write as character |
| `0xE5` | `~0x1A` | 2 bytes LE | ADD_CREDITS — Add signed to `tD370` |
| `0xE6` | `~0x19` | 4 bytes LE | SET_CURSOR_XY — Set cursor X/Y |
| `0xE7` | `65511` | 2 bytes LE compare_val, 2 bytes LE abs_jump | CMP_CURSOR_X — If cursor X != compare, skip 2B; else jump |
| `0xE8` | `~0x17` | 1 byte mask, 2 bytes LE abs_jump | RNG_CHECK — If `RNG() & mask != 0`, jump |
| `0xE9` | `~0x16` | 1 byte | CALL_ROOM_HANDLER — Call `fn11B8_0D58(operand)` |
| `0xEA` | `~0x15` | 2 bytes (cond+action) | COND_STATE_ACTION — If `w3938==0`, call `fn0800_48B7(cond, action)` |
| `0xEB` | `65515` | 0 bytes | CHECK_FLAG_EB — Skip if `bD451 == 0` |
| `0xEC` | `65516` | 0 bytes | CHECK_FLAG_EC — Skip if `bD450 == 0` |
| `0xED` | `~0x12` | 2 bytes | UNIT_CHECK_LOOP — Loop 8 units checking `aC60F` |
| `0xEE` | `~0x11` | 2 bytes LE | SPEND_CREDITS — Deduct from `tD370` (zero-floor) |
| `0xEF` | `~0x10` | 2 bytes LE | CHECK_CREDITS — Skip if insufficient funds |
| `0xF0` | `~0x0F` | 2 bytes | SET_TEXT_MARGINS — Set left/right margins |
| `0xF1` | `~0x0E` | 2 bytes | ADD_TO_STATE — `D30C[index] += value` |
| `0xF2` | `~0x0D` | 0 bytes | ROOM_DESCRIPTION — Render room description |
| `0xF3` | `~0x0C` | 1 byte | SHOP_INTERACTION — Index into `D30C`, indirect dispatch |
| `0xF4` | `~0x0B` | 2 bytes | SET_STATE_VALUE — `D30C[index] = value` |
| `0xF5` | `~0x0A` | 1 byte | SHOP_DISPATCH — Call `fn1CD3_0004(operand)` |
| `0xF6` | `~0x09` | 0 bytes | CHECK_CONDITION — Skip if `fn0800_1A13(1)` returns 0 |
| `0xF7` | `~0x08` | 1 byte | STATE_COND_CHECK — Skip if `D30C[index] == 0` |
| `0xF8` | `~0x07` | 2 bytes LE | JUMP_FORWARD — Read 2-byte WORD → absolute jump target (new IP = word value) |
| `0xF9` | `~0x06` | 1 byte | JUMP_INDEXED — Read 1 byte menuId, calls `fn1E56_0B5E(menuId)` → returns index, reads WORD at `base + _ip + index*2` as new IP |
| `0xFA` | `~0x05` | 1 byte | DRAW_SPRITE — Draw sprite via `fn1E56_0004(operand)` |
| `0xFB` | `~0x04` | 0 bytes | ADVANCE_INPUT — Wait for key |
| `0xFC` | `~0x03` | N bytes | RENDER_TEXT — Display cipher text, advance past string |
| `0xFD` | `~0x02` | 0 bytes | SET_FONT2 — Font/display params |
| `0xFE` | `~0x01` | 1 byte | SET_FONT — Set font |
| `0xFF` | `~0x00` | 0 bytes | EXIT — Set exit flag, stop interpreter |

---

## 18. BLD TEXT CIPHER

| Byte Range | Maps To | Note |
|------------|---------|------|
| `0x57-0x5F` | i h k j m l o n a | lowercase |
| `0x60` | q | lowercase |
| `0x61-0x76` | c b e d g f y x i z l m n o p s r u t w v | lowercase |
| `0x77-0x7F` | I H K J M L O N A | uppercase (in "lowercase" range) |
| `0x80-0x96` (skip 0x88-0x8F) | C B E D G F Y P S R U T W V | uppercase |
| `0xA0` | space | separator |
| `0x6B` | control byte | not text |
| `0xAF-0xBF` | numeric digit display | price encoding |
| `0xC0` | no-op (structural separator) | consumed silently |

---

## 19. RENDERING / GRAPHICS SYSTEM

### Framebuffer Layout

| Address | Purpose | Format |
|---------|---------|--------|
| `A000:0000` | VGA framebuffer base | EGA planar |
| `A000:2000` | Odd scanlines (bank 1) | Plane offset `0x2000` |
| `B800:0000` | CGA framebuffer | tB764 mode 0x00 |
| `A000:AC00` | VGA text buffer | tB764 mode 0x02 |

### EGA Planar Layout

| Property | Value |
|----------|-------|
| Bit planes | 4 (Blue=0, Green=1, Red=2, Intensity=3) |
| Bytes/plane/scanline | 40 (320px / 8) |
| Plane stride | `0x2000` (8192 bytes) |
| Row-pair stride | `0x50` (80 bytes) |
| Total framebuffer | ~32768 bytes (`0x8000`) |
| VGA ports | `0x3C4` (sequencer), `0x3CE` (graphics controller) |
| VGA write mode 2 | `out 0x03CE, 0x0105` |

### Pixel Format Flag (tB764 at segment 246C)

| Value | Mode | Framebuffer | Stride | Description |
|-------|------|-------------|--------|-------------|
| `0x00` | CGA/Herc | `0xB800` | `0x28` (40) | 2-bit pixels, odd/even `0x2000` plane shift |
| `0x02` | VGA text | `0xAC00`→`0xA000` | `0x28` (40) | Linear, write mode 2, no planar |
| `0x01` | EGA planar | `0xA000` | `0x28` (40) | 4-bit planar interleave (bx = row & 0x03) |
| default | Full frame | `0xA000` | `0x0140` (320) | Linear full-width copy |

### Viewport Hardware Registers (fn207F_1B80)

| Register | Purpose |
|----------|---------|
| `tB78E`/`tB790` | Destination base address |
| `tB792`/`tB794` | Source X/Y |
| `tB79A`/`tB79C` | Clip width/height |

### Screen Layout

| Panel | Width (px) | Content |
|-------|-----------|---------|
| Left panel | `80` (`0x50`) | Location graphic + action menu |
| Right area | `240` (320-80) | Main viewport (map, tiles, text) |

### Border Variants (fn1F3D_06C3)

| Variant | Function | Used For |
|---------|----------|----------|
| Full border | `fn207F_1CB8` | w4FBA=0,1 (100 rows×54B or 50 rows×108B) |
| Narrow border | `fn207F_1D3A` | w4FBA=2 (200 rows×27 words) |
| Text overlay | `fn207F_245C` | w4FBA=3 (13-column strip) |

### World Map Tile Calculation

| Expression | Range | Purpose |
|------------|-------|---------|
| `(A44B & 0x7F) >> 1` | 0-63 | Tile X from cursor |
| `(A44D & 0x7F) >> 1` | 0-63 | Tile Y from cursor |
| `(tA44B >> 1 & 0x07) + 2` | 2-9 | Cursor grid X (fn207F_1DF8) |
| `(tA44D >> 1 & 0x07) + 2` | 2-9 | Cursor grid Y |
| `tileX + tileY * 24` | — | Tile index (map grid 24 tiles wide) |
| `0x246C:0x244B` | — | Tile buffer (world map, local) |

### Combat Fog Grids

| Address | Dimensions | Init Value | Purpose |
|---------|-----------|------------|---------|
| `DS:[0x55D8]→0x40B4` | 12 × 24 = 288 bytes | `0x02`=fogged | Combat Fog Grid A |
| `DS:[0x55D8]→0x41D4` | 12 × 24 = 288 bytes | `0x02`=fogged | Combat Fog Grid B |

### Animation / Tile System

| Address/Symbol | Type | Purpose |
|----------------|------|---------|
| `3000:CC30` | filename[] | BLD filename list |
| `w5800` | uint16 | Page counter (0→1→2→0), source = `(w5800 << 7) + 54658` |
| 54658 | uint16 | Tile buffer base offset (0xD582?) |
| 4100 | count | Number of tiles per page |
| 128 | bytes | Stride per tile (`fn207F_28A8` memcpy size) |
| `w3988` | uint16 | Animation guard flag |
| `0x57FE` | uint16 | Animation frame counter (wraps at 3) |
| `0x1A` (26) | stride | Unit slot stride for fn0800_24C2 |

### Coordinate Packing (Combat)

| Formula | Purpose |
|---------|---------|
| `X = (val & 0xF00) >> 1 \| (val & 0x7F)` | Packed X extraction |
| `Y = (val & 0xF000) >> 5 \| (val & 0x7F)` | Packed Y extraction |
| Mask `0xF7F` | grid/sub-pixel precision |
| Mask `0xF07F` | grid/sub-pixel precision |

### BTSTATS.CMP

| Address | Purpose |
|---------|---------|
| Segment 0x246C via `fn207F_104E` | BTSTATS tile render (48 rows) |
| `fn0800_3D40` | Stat/inventory screen |
| `fn0800_3FAE` | Stat screen rendering (8-phase) |

---

## 20. ENEMY TEMPLATES — MECH TABLE

| Mech ID | Name | Tonnage | Walk | Jump | Notes |
|---------|------|---------|------|------|-------|
| `0x00` | LOCUST | 20t | 8 | 0 | Random encounter pool (template) |
| `0x01` | WASP | 20t | 6 | 6 | Random encounter pool (template) |
| `0x02` | STINGER | 20t | 6 | 6 | Random encounter pool (template) |
| `0x03` | COMMANDO | 25t | 6 | 0 | Random encounter pool |
| `0x06` | URBANMECH | 30t | 2 | 2 | Story-only |
| `0x09` | JENNER | 35t | 7 | 5 | Story-only (Kuritan) |
| `0xC8` | CHAMELEON | 50t | 6 | 6 | Player starting mech, story-only |

---

## 21. ENEMY ENCOUNTER DATA

| Address | Type | Purpose |
|---------|------|---------|
| `[DS:0x5436]:0x2DF8` | word[3] | Fixed 3-entry enemy mech template table (near offsets) |
| `DS:[0x5434] + 0x2CF4` | byte[] | Infantry weapon instance data (stride 0x11) |
| Position center: (26, 12) | coordinate | Encounter spawn center on 32×24 world grid |
| Offset: ±10-17 from center | formula via `RNG & 0x07 + 0x0A` | Random position offset |

---

## 22. BMP-RELATED ADDRESSES (from CONTEXT, in codebase)

| Address | Segment | Description |
|---------|---------|-------------|
| `3000:32C6` | — | Tile properties (movement cost, blocking) |
| `3000:CC30` | — | .BLD filename list |
| `DS:0x4602` | `0x5460`→0x4602 | BLD index translation table (22 entries in CTX, 16-byte in doc) |
| `DS:[0x55D8]→0x40B4` | — | Combat Fog Grid A |
| `DS:[0x55D8]→0x41D4` | — | Combat Fog Grid B |
| `DS:[0x3092]→0x04F9` | — | World Map Visibility (2048 bytes, bit-packed 128×128) |

---

## 23. MISCELLANEOUS ADDRESSES

| Address / Symbol | Type | Purpose |
|------------------|------|---------|
| `ES:0x14A` | uint16 | Guard for heat dissipation call (from segment DS:0x5630) |
| `0xA452`, `0xA454`, `0xA456` | uint16 | VGA drawing parameters (damage VFX) |
| `0x9ED` | address | Screen buffer position (damage coordinate conversion result) |
| `ES:0x0012` | uint8[] | Digit input array (max 7 digits, fn1543_0CDE) |
| `BTBORDER.TIL` | tileset | Border tiles (loaded into segment 1A58 tile cache) |
| `0x3092` segment | mech struct[] | Mechanized unit story slot array (aC724[0..7], stride 125) |
| `0x54C8` segment | — | Template arrays (a01CC[] name strings, a01CA[] type strings) |
| `0x1A00` segment | — | Static mech definitions |
| `0x1A58` segment | — | BTBORDER tile cache |
| `3EDB:32F0` | string | "They're trying to actually kill you!" text |
| `0xCC30` at segment 3000 | string[] | BLD filename list |
| `0x33FC` | BLD index | Encounter narration BLD script index |
| `0x569E` segment | struct Eq_80552 | Main game state struct |
| `0x394C` | segment | BLD index translation handler segment |

---

## 24. KEY STRING ADDRESSES

| Address | Content | Context |
|---------|---------|---------|
| Segment `0x3EDE` in data seg | Miss message | Combat miss text |
| Segment `0x3EE7` | Hit message | Combat hit text |
| `3EDB:32F0` | "They're trying to actually kill you!" | Citadel attack narrative |

---

## 25. LAYERED STATE SYSTEM

| Layer | Location | Type | Size | Purpose |
|-------|----------|------|------|---------|
| Layer 1 | `DS:0xD30C` | byte[] | 256 | Generic state array |
| Layer 2 | `fn1631_11AB` (segment `1631:11AB`) | code | — | Story properties (0x1C-0x23) |
| Layer 3 | `bD450` at `0xD450`, `bD451` at `0xD451` | byte | 2 | BLD flag system |

---

## 26. FOUR-LAYER BLD INTERPRETER ARCHITECTURE

| Layer | Function | Segment:Offset | Purpose |
|-------|----------|---------------|---------|
| 1 | `fn0FDC_0008` | `0FDC:0008` | Entry point, loads BLD by index |
| 2 | `fn0FDC_01C0` | `0FDC:01C0` | Bytecode interpreter (0xE4-0xFF) |
| 3 | `fn1CD3_0004` | `1CD3:0004` | Room/bld interaction dispatcher (47 cases) |
| 4 | `fn1E56_03F5` | `1E56:03F5` | Text renderer (word-wrapping, margins) |

---

## 27. MAP FILES

| File | Map | Description |
|------|-----|-------------|
| MAP1.MTP | — | Training Center / Citadel (start) |
| MAP2.MTP | — | Main City, Chameleon training, Arena |
| MAP3.MTP | — | Small outpost/village |
| MAP4.MTP | — | Large industrial complex |
| MAP5-8.MTP | — | Medium settlements |
| MAP9.MTP | — | Outpost |
| MAP10.MTP | — | Medium settlement |
| MAP11.MTP | — | Destroyed Training Center (post-attack) |
| MAP12.MTP | — | Large city/base |
| MAP13.MTP | — | Medium settlement |
| MAP14.MTP | — | Cave / Underground complex |
| MAP15.MTP | — | Star Map (32×24, linear format) |

---

## 28. BLD FILE INDEX / MAP EVENT MAPPING

| BLD File | Map(s) | Story Purpose |
|----------|--------|---------------|
| TRAINING | MAP1/11 | Training missions + citadel attack |
| CITADEL | MAP1/11 | Post-attack citadel (b0057 ≥ 1) |
| BARRACKS | MAP2 | Recruit NPCs |
| BARRACK2 | MAP2 | Additional soldier interactions |
| LOUNGE | MAP2 | Rick gives device, mentions Starport |
| COMSTAR | MAP2 | Banking, stock market |
| PARTY | MAP2 | Rex rescues Jason |
| MAYOR | MAP2 | Read newspaper, holodisk, escape |
| JAIL | MAP2 | Rescue agent, acquire Stinger |
| WEAPON/WEAPON2 | MAP2 | Buy infantry weapons |
| ARMOR | MAP2 | Armor shop |
| CLOTHES | MAP2 | Civilian clothes shop |
| HOSPITAL | MAP2 | Healing services |
| GARAGE | MAP2 | Vehicle services |
| REPAIR | MAP2 | Recruit tech, modify Mechs |
| ARENA | MAP2 | Mech combat arena |
| ENTRANCE | MAP2 | Story transition |
| THEATER | MAP2 | Entertainment/plot |
| FINDIT | MAP3-10 | Search for cache clues |
| HUT | MAP14 (Cave) | Tellhim's holographic tests |
| FROB | MAP14 (Cave) | Tellhim's gauntlet puzzle |
| INSTRUCT | MAP14 (Cave) | Cache entrance instructions |
| VIEWDISK | MAP14 (Cave) | Jeremiah's holodisk |
| WINSCENE | Endgame | Hyperpulse Generator → Katrina |
| ENDMECH | Endgame | Endgame image/credits |

---

## 29. C STRUCT EQ REFERENCE (UNBTECH.h)

| Eq Name | UNBTECH.h Line | Description |
|---------|----------------|-------------|
| `Eq_57354` | — | Main game state struct (contains w4FBA, story state) |
| `Eq_107947` | — | Per-story-slot struct (stride 0x7D = 125 bytes, aC744[]) |
| `Eq_80552` | — | Segment 0x569E struct (shop, credits, UI state) |
| `Eq_49571` | UNBTECH.h:54256 | Story slot segment reference |
| `Eq_107547` | UNBTECH.h:685747 | Story slot segment reference |
| `Eq_107577` | UNBTECH.h:685781 | Unit slot struct reference (stride 0x11) |
| `Eq_106563` | UNBTECH.h:684673 | Unit slot struct reference |

---

## 30. BLD CONTENT TYPE CODES

| Code | Meaning |
|------|---------|
| `c0 ec` | Dialogue/story content |
| `c0 f5` | Shop/service content |
| `c0 f4` | Special content |
| `c0 da` | Endgame marker |
| `9e` | Third-person narrative |
| `9c` | Character speech continuation |
| `9b` | Player internal thought |
| `9f` | Player-directed thought |
| `a5` | Sentence continuation (appends lowercase) |

---

## 31. PRICE DISPLAY ENCODING (BLD text)

| Byte Range | Encoded Values |
|------------|----------------|
| `0xAF-0xB3` | Values 40-44 (left column of numpad font) |
| `0xB4-0xB8` | Values 105-113 (right column, odd numbers) |
| `0xBE` | 125 |
| `0xBF` | 127 |

---

## 32. GAME ENTRY / MAIN FLOW

| Address | Purpose |
|---------|---------|
| `19EF:2D82` (linear `0x1CC72`) | Entry point of UNBTECH.EXE |
| `w0152` at offset `0x0152` | Main loop exit guard |
| `w014A` at offset `0x014A` | Screen refresh flag |
| `fn0800_0000` at `0800:0000` | Main game loop (runs while `w0152==0`) |
| `fn0800_50C8` | Outer loop initialization |
