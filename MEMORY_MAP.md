# Memory Map: BattleTech - The Crescent Hawk's Inception

## MZ EXE Physical Segment Layout

The executable `UNBTECH.EXE` has **3 physical segments** in the MZ relocation table:

| Segment | Relocs | Contents | Reko Sub-Segments |
|---------|--------|----------|-------------------|
| `0x0000` | 1608 | Main code + some data | 0800, 0D27, 0DAB, 0FDC, 11B8, 135D, 1431, 1467, 1543, 1631, 183B, 1AE8, 1CD3, 1E56, 1F3D, 1FC5, 204B, 207F, 246C, 2FE8, 3EDB |
| `0x1000` | 830 | Combat code segment | (combat system, Spice86 segment 1000) |
| `0x3000` | 854 | Primary data segment | Tile props, BLD filenames, game state |

**EXE Entry Point**: `0x187F:0x2D82` (linear `0x1B572`), but CONTEXT.md states `19EF:2D82` — the difference of `0x170` is the runtime load segment base.

## Spice86 Runtime Segment Mapping

Spice86 observes these runtime segments (relocation-adjusted):

| Spice86 ID | Segment | Content |
|------------|---------|---------|
| cs1 | `0x0000` | PSP + low memory vectors |
| cs2 | `0x0170` | Early init code |
| cs3 | `0x0697` | Init/loading code |
| cs4 | `0x071B` | Init code |
| cs5 | `0x094C` | BLD loader/interpreter (0FDC in Reko) |
| cs6 | `0x0DD7` | Utility functions |
| cs7 | `0x0FA1` | Combat/interaction code |
| cs8 | `0x1000` | Combat system (core) |
| cs9 | `0x1643` | Combat support (1CD3 in Reko) |
| cs10 | `0x17C6` | Text renderer (1E56 in Reko) |
| cs11 | `0x18AD` | Border/UI (1F3D in Reko) |
| cs12 | `0x1935` | Graphics rendering (207F in Reko) |
| cs13 | `0x19BB` | Interrupt handlers / sound |
| cs14 | `0x19EF` | Combat subroutines |
| cs15 | `0x2000` | Combat/weapon data tables |
| cs16 | `0x24D7` | Tile/animation code (246C in Reko) |
| cs17 | `0xC000` | BIOS/VGA ROM |
| cs18 | `0xF000` | BIOS ROM |
| cs19 | `0xF100` | VGA ROM |

## Data Segment (0x3000 / runtime segment) Memory Layout

All offsets are relative to the data segment base (`DS` register, typically segment 0x3000 at runtime, reachable via the relocation table).

### 1. SYSTEM VARIABLES (Offset 0x0000-0x03FF)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0x0046C` | 2 | `g_t046C` | Global struct |
| `0x0046E` | 2 | `g_w046E` | Global word |
| `0x0062` | 2 | `t0062` | General purpose word |
| `0x006A` | 2 | `w006A` | General purpose word |
| `0x006C` | 2 | `t006C` | General purpose word |
| `0x009C` | 2 | `t009C` | General purpose word |
| `0x014A` | 2 | `w014A` | Screen refresh flag (0=no refresh, 1=refresh needed) |
| `0x014E` | 2 | `t014E` | General purpose |
| `0x0150` | 2 | `t0150` | Skill gate threshold for LoS blocking |
| `0x0152` | 2 | `w0152` | Exit flag (while `w0152==0`, main loop runs) |
| `0x0168` | 2 | `w0168` | Alternative price for case 0x09 hospital |
| `0x0178` | 2 | `t0178` | General purpose |
| `0x0198` | 2 | `t0198` | General purpose |
| `0x01A8` | 2 | `t01A8` | General purpose |
| `0x01B8` | 2 | `t01B8` | General purpose |
| `0x01F6` | 2 | `w01F6` | Cursor/position word |
| `0x01F8` | 2 | `t01F8` | Cursor/position word |
| `0x0202` | 2 | `t0202` | General purpose |
| `0x0206` | 2 | `t0206` | General purpose |
| `0x0208` | 2 | `t0208` | General purpose |
| `0x022E` | 2 | `t022E` | Timer counter 1 |
| `0x0230` | 2 | `t0230` | Timer counter 2 |
| `0x0232` | 2 | `t0232` | Timer counter 3 |
| `0x0234` | 2 | `t0234` | Timer counter 4 |
| `0x0256` | 2 | `t0256` | General purpose word |
| `0x0258` | 2 | `t0258` | General purpose word |
| `0x026E` | 2 | `t026E` | Graphics mode byte |
| `0x0270` | 2 | `t0270` | Graphics mode byte |
| `0x0272` | 2 | `t0272` | Screen dimension byte |
| `0x0273` | 2 | `t0273` | Screen dimension byte |
| `0x0279` | 2 | `t0279` | Screen dimension byte |
| `0x027A` | 2 | `t027A` | Screen dimension byte |
| `0x027B` | 2 | `t027B` | Screen dimension byte |
| `0x027C` | 2 | `t027C` | Screen dimension byte |
| `0x02A2` | 2 | `t02A2` | General purpose |
| `0x02C9` | 2 | `t02C9` | Screen dimension byte |
| `0x02CA` | 2 | `t02CA` | Screen dimension byte |
| `0x0338` | 2 | `w0338` | Main loop control word (compared to 0x00) |
| `0x09F3` | ? | `t09F3` | World tile entry offset (used in arrow key handler) |

### 2. GAME STATE (Offset 0x0D00-0x0DFF)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0x0D30C` | 256 | `aD30C[256]` | **Generic state array** — modified by BLD opcodes F1/F4, checked by F7/F3 |
| `0x0D30E` | 2 | `tD30E` | State array sub-field |
| `0x0D310` | 2 | `bD310` | **World map active flag** (0=not world map, !=0=world map active) |
| `0x0D314` | 1 | `bD314` | **Shop selection index** (0-2, current selected item slot) |
| `0x0D315` | 1 | `bD315` | Shop state byte |
| `0x0D316` | 1 | `bD316` | Alternative price flag (hospital: `!=0` uses `w0168`) |
| `0x0D317` | 1 | `bD317` | Event dispatch state |
| `0x0D318` | 2 | `bD318` | Event dispatch index (case 0x0B checks for 6 or 9) |
| `0x0D31A` | 2 | `tD31A` | State action parameter / jump target offset |
| `0x0D31B` | 1 | `bD31B` | State action parameter byte |
| `0x0D31C` | 2 | `tD31C` | State action parameter |
| `0x0D325` | 1 | `bD325` | State byte |
| `0x0D326` | 1 | `bD326` | State byte |
| `0x0D32F` | 1 | `bD32F` | State byte |
| `0x0D330` | 1 | `bD330` | **Encounter probability mask** — `0x1F`=1/32, `0x7F`=1/128 frames |
| `0x0D331` | 1 | `bD331` | Encounter state byte |
| `0x0D334` | 1 | `bD334` | Encounter timer / state |
| `0x0D335` | 1 | `bD335` | **Encounter cooldown timer** (0x3F=63 frames prevents re-encounter) |
| `0x0D343` | 1 | `bD343` | Compound movement timer 1 |
| `0x0D344` | 1 | `bD344` | Compound movement timer 2 |
| `0x0D345` | 1 | `bD345` | Compound movement timer 3 (citadel attack trigger) |
| `0x0D346` | 1 | `bD346` | **Star map / alternate view flag** |
| `0x0D370` | 4 | `dwD370` | **C-Bills** (32-bit: `tD370` low word, `tD372` high word) |
| `0x0D374` | N*4 | `aD374[]` | **Per-item-type player quantity array** (uint32 stride 4) |
| `0x0D376` | N*2 | `aD376[]` | **Per-item-type player data array** (uint16 stride 2) |
| `0x0D390` | ? | `tD390` | Inventory/unit data |
| `0x0D392` | ? | `tD392` | Inventory/unit data |
| `0x0D394` | ? | `tD394` | Inventory/unit data |
| `0x0D396` | ? | `tD396` | Inventory/unit data |
| `0x0D398` | ? | `tD398` | Inventory/unit data |
| `0x0D399` | ? | `tD399` | Inventory/unit data |
| `0x0D450` | 1 | `bD450` | **Training complete flag** |
| `0x0D451` | 1 | `bD451` | **Milestone marker flag** |
| `0x0D452` | 1 | `bD452` | State byte |
| `0x0D456` | 1 | `bD456` | State byte |
| `0x0D55E` | 2 | `tD55E` | State word |
| `0x0D56C` | 1 | `bD56C` | State byte |
| `0x0D56D` | 1 | `tD56D` | State byte |

### 3. UNIT / COMBAT STATE (Offset 0x4000-0x41FF)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0x4000` | ? | `t4000` | Combat parameter |
| `0x4004` | 48 | `a4004[24]` | **Unit X positions array** (ID * 2 offset → word) |
| `0x4020` | 2 | `t4020` | Unit position field |
| `0x4022` | 2 | `t4022` | Unit position field |
| `0x4024` | ? | `t4024` | Unit data |
| `0x4034` | 2 | `t4034` | Unit position field |
| `0x4036` | 48 | `a4036[24]` | **Unit Y positions array** (ID * 2 offset → word) |
| `0x403E` | ? | `t403E` | Unit data |
| `0x4052` | 2 | `t4052` | Unit state field |
| `0x4054` | 2 | `t4054` | Unit state field |
| `0x4056` | ? | `t4056` | Unit data |
| `0x4066` | 2 | `w4066` | Unit position / target field |
| `0x4068` | 2 | `t4068` | Unit position field |
| `0x406A` | 48 | `a406A[24]` | **Unit status array** (0=dead/inactive, ID * 2 offset → word) |
| `0x4086` | 2 | `w4086` | Unit word |
| `0x4088` | 2 | `t4088` | Unit word |
| `0x409A` | ? | `t409A` | Unit data |
| `0x40A8` | 1 | `b40A8` | Combat byte |
| `0x40A9` | 1 | `t40A9` | Combat byte |
| `0x40B4` | 288 | `GridA[12×24]` | **Combat Fog Grid A** (init 0x02=fogged, 0x00=clear) |
| `0x41D4` | 288 | `GridB[12×24]` | **Combat Fog Grid B** (init 0x02=fogged, 0x00=clear) |

### 4. UNIT / STORY DATA (Offset 0xC600-0xC7FF)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0xC614` | 6 | `aC614[?]` | Unit data array |
| `0xC618` | 6 | `aC618[3]` | **Shop item slots** (3 item type numbers currently displayed) |
| `0xC61F` | 1 | `bC61F` | Selection index |
| `0xC620` | ? | `tC620` | Unit/story interaction data |
| `0xC623` | 1 | `bC623` | Unit data byte |
| `0xC724` | N*125 | `aC724[]` | **Story state array** of `Eq_107947` (125 bytes each, stride 0x7D) |
| `0xC79B` | 1 | `b0057` | **Story state byte** within Eq_107947 struct (0=Training, 1=Citadel Attack, 2=Post-Attack) |
| `0xC79D` | 1 | `tC79D` | Story state byte |
| `0xC79F` | 1 | `tC79F` | Story state byte |

### 5. CURSOR / NAVIGATION (Offsets 0xA44B-0xA451)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0xA44B` | 2 | `wA44B` | **Cursor X / Unit X coordinate** |
| `0xA44D` | 2 | `wA44D` | **Cursor Y / Unit Y coordinate** |
| `0xA44F` | 1 | `bA44F` | Cursor sub-pixel byte |
| `0xA450` | 1 | `bA450` | Cursor sub-pixel byte |
| `0xA451` | 1 | `bA451` | Cursor sub-pixel byte |

### 6. UI / SCREEN STATE (Offset 0x3700-0x3A00)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0x3748` | 2 | `t3748` | Screen data word |
| `0x374E` | 2 | `t374E` | Screen data word |
| `0x3776` | 2 | `t3776` | Screen data word |
| `0x377E` | 2 | `t377E` | Screen data word |
| `0x37FE` | 2 | `w37FE` | **Text mode flag** |
| `0x392E` | 2 | `t392E` | Screen data |
| `0x392F` | 2 | `t392F` | Screen data |
| `0x3938` | 2 | `t3938` | Segment pointer / screen data |
| `0x393A` | 2 | `t393A` | Screen data |
| `0x397A` | 2 | `t397A` | Screen data |
| `0x397B` | 2 | `t397B` | Screen data |
| `0x3984` | 2 | `t3984` | Screen data |
| `0x3986` | 2 | `t3986` | Screen data |
| `0x398A` | 2 | `t398A` | Screen data |
| `0x398C` | 2 | `t398C` | Screen data |
| `0x3990` | 2 | `t3990` | Screen data |
| `0x39A0` | 2 | `t39A0` | Screen data |
| `0x39A2` | 2 | `t39A2` | Screen data |
| `0x39A4` | 2 | `t39A4` | Screen data |
| `0x39F4` | 2 | `t39F4` | Screen data |
| `0x39F6` | 2 | `t39F6` | Screen data |
| `0x39F8` | 2 | `t39F8` | Screen data |
| `0x3988` | 2 | `w3988` | **Animation guard flag** (guards tile animation page swap) |
| `0x398E` | 2 | `w398E` | World map mech render flag |

### 7. SEGMENT POINTERS & FUNCTION TABLES (Offset 0x4F00-0x5722)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0x4FBA` | 2 | `w4FBA` | **Global UI mode** (0=WorldMap, 1=LocalTiles, 2=Text, 3=BuildingName) |
| `0x4FBC` | 2 | `t4FBC` | Related to w4FBA |
| `0x4FBE` | 2 | `t4FBE` | Related to w4FBA |
| `0x4FB8` | 2 | `t4FB8` | UI word |
| `0x52D6` | ! | `t52D6` | Weapon/data pointer |
| `0x52E5` | ! | `t52E5` | Weapon/data pointer |
| `0x52F1` | ! | `t52F1` | Weapon/data pointer |
| `0x52F3` | ! | `t52F3` | Weapon/data pointer |
| `0x52F7` | ! | `t52F7` | Weapon/data table |
| `0x52F9` | ! | `t52F9` | Weapon/data pointer |
| `0x52FC` | ! | `t52FC` | Weapon/data pointer |
| `0x5280` | ! | `t5280` | Weapon/data table pointer |
| `0x5284` | ! | `t5284` | Weapon/data table pointer |
| `0x5300` | ! | `a5300[5]` | Data array |
| `0x532C` | 2 | `t532C` | Weapon/data pointer |
| `0x532E` | 2 | `t532E` | Weapon/data pointer |
| `0x5334` | ! | `t5334` | Weapon/data pointer |
| `0x5350` | ! | `t5350` | Weapon/data pointer |
| `0x5352` | ! | `t5352` | Weapon/data pointer |
| `0x5356` | ! | `t5356` | Weapon/data pointer |
| `0x535A` | ! | `t535A` | Weapon/data pointer |
| `0x535C` | ! | `t535C` | Weapon/data pointer |
| `0x535E` | ! | `t535E` | Weapon/data table |
| `0x5360` | ! | `t5360` | Weapon/data pointer |
| `0x5364` | ! | `t5364` | Weapon/data pointer |
| `0x5378` | ! | `t5378` | Weapon/data pointer |
| `0x537A` | ! | `t537A` | Weapon/data pointer |
| `0x538A` | 2 | `ptr538A` | Pointer to segment data |
| `0x5436` | 2 | `t5436` | Segment pointer for mech tables |
| `0x5460` | 2 | `t5460` | Segment pointer for BLD translation table |
| `0x5588` | 2 | `t5588` | Segment pointer for tile properties |
| `0x558A` | 2 | `t558A` | Segment pointer for skill gate threshold |
| `0x5590` | 2 | `t5590` | Segment pointer for Y positions |
| `0x5592` | 2 | `t5592` | Segment pointer for X positions |
| `0x55D8` | 2 | `t55D8` | Segment pointer for fog grids |
| `0x55DC` | 2 | `t55DC` | Segment pointer for terrain TN modifiers |
| `0x5636` | 2 | `t5636` | Data segment pointer |
| `0x5638` | 2 | `t5638` | Data segment pointer |
| `0x5642` | 2 | `t5642` | Data segment pointer |
| `0x569E` | 2 | `t569E` | **Primary data segment** (contains w4FBA at offset 0x00FD) |
| `0x56A2` | 2 | `ptr56A2` | Data pointer |
| `0x56A4` | 2 | `t56A4` | Data pointer |
| `0x56A6` | 2 | `t56A6` | Data pointer |
| `0x56A8` | 2 | `t56A8` | Data pointer |
| `0x56AA` | 2 | `t56AA` | Data pointer |
| `0x56AC` | 2 | `t56AC` | Data pointer |
| `0x56AE` | 2 | `t56AE` | Data pointer |
| `0x56B0` | 2 | `t56B0` | Data pointer |
| `0x56B2` | 2 | `t56B2` | Data pointer |
| `0x56B4` | 2 | `t56B4` | Data pointer |
| `0x56B8` | 2 | `t56B8` | Data pointer |
| `0x56C4` | 2 | `t56C4` | Data pointer |
| `0x56C6` | 2 | `t56C6` | Data pointer |
| `0x56CE` | 2 | `t56CE` | Data pointer |
| `0x56D0` | 2 | `ptr56D0` | Screen/page render data pointer |
| `0x56D2` | 2 | `t56D2` | Screen/page render data |
| `0x56D4` | 2 | `ptr56D4` | Screen/page render data pointer |
| `0x56D6` | 2 | `t56D6` | Screen/page render data |
| `0x56D8` | 2 | `t56D8` | Screen/page render data |
| `0x56DA` | 2 | `t56DA` | Screen/page render data |
| `0x56DC` | 2 | `t56DC` | Screen/page render data |
| `0x56DE` | 2 | `t56DE` | Screen/page render data |
| `0x56E0` | 2 | `t56E0` | Screen/page render data |
| `0x56E2` | 2 | `ptr56E2` | Screen/page render data pointer |
| `0x56E4` | 2 | `ptr56E4` | Screen/page render data pointer |
| `0x56E6` | 2 | `t56E6` | Screen/page render data |
| `0x56E8` | 2 | `t56E8` | Screen/page render data |
| `0x56EA` | 2 | `t56EA` | Screen/page render data |
| `0x56EC` | 2 | `t56EC` | Screen/page render data |
| `0x56EE` | 2 | `ptr56EE` | Screen/data pointer |
| `0x56F0` | 2 | `t56F0` | Combat data |
| `0x56F2` | 2 | `t56F2` | Combat data |
| `0x56F4` | 2 | `t56F4` | Combat data |
| `0x56F6` | 2 | `t56F6` | Combat data |
| `0x56F8` | 2 | `t56F8` | Combat data |
| `0x56FA` | 2 | `t56FA` | Combat data |
| `0x56FC` | 2 | `ptr56FC` | Combat data pointer |
| `0x56FE` | 2 | `t56FE` | Combat data |
| `0x5700` | 2 | `t5700` | Combat data |
| `0x5702` | 2 | `t5702` | Combat data |
| `0x5704` | 2 | `t5704` | Combat data |
| `0x5706` | 2 | `t5706` | Combat data |
| `0x5708` | 2 | `t5708` | Combat data |
| `0x570A` | 2 | `t570A` | Combat data |
| `0x570C` | 2 | `t570C` | Combat data |
| `0x570E` | 2 | `t570E` | Combat data |
| `0x5710` | 2 | `t5710` | Combat data |
| `0x5712` | 2 | `t5712` | Combat data |
| `0x5714` | 2 | `t5714` | Combat data |
| `0x5716` | 2 | `t5716` | Combat data |
| `0x5718` | 2 | `t5718` | Combat data |
| `0x571A` | 2 | `t571A` | Combat data |
| `0x571C` | 2 | `t571C` | Combat data |
| `0x571E` | 2 | `t571E` | Combat data |
| `0x5720` | 2 | `ptr5720` | Combat data pointer |
| `0x5722` | 2 | `t5722` | Combat data |
| `0x572C` | 2 | `t572C` | Combat data |

### 8. EVENT / ANIMATION STATE (Offset 0xE480-0xE48E)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0xE482` | 2 | `wE482` | Event word |
| `0xE484` | 2 | `wE484` | Story completion flag (set when story property 0x20 completes) |
| `0xE486` | 2 | `tE486` | Event word |
| `0xE488` | 2 | `tE488` | Event word |
| `0xE48C` | 2 | `tE48C` | Event word |
| `0xE48E` | 2 | `tE48E` | Event word |

### 9. GRAPHICS MODE / PIXEL FORMAT

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0xB764` | 2 | `tB764` | **Pixel format flag** (0x00=CGA 0xB800, 0x02=VGA text 0xAC00, 0x03=VGA mode X 0xA000 stride 0x0A00, default=EGA planar 0xA000) |

### 10. WORLD MAP VISIBILITY

| Segment | Offset | Size | Description |
|---------|--------|------|-------------|
| `[0x3092]` | `0x04F9` | 2048 bytes | **World Map Visibility** (bit-packed 128×128 grid, persisted in save files) |

### 11. TILE PROPERTIES

| Segment | Offset | Size | Description |
|---------|--------|------|-------------|
| `3000` | `0x32C6` | var | **Tile terrain TN modifier table** (stride 0x30, `0xFF`=impassable, packed X/Y coords) |
| `246C` | `0x7AD` | 1 per tile | **Tile property table** (LoS blocking, terrain visibility, movement cost factor) |
| `3000` | `0xCC30` | var | **BLD filename list** (array of .BLD file entries) |

### 12. SHOP / INVENTORY DATA (Offset 0xD300-0xD400)

| Offset | Size | Name | Description |
|--------|------|------|-------------|
| `0xD314` | 1 | `bD314` | Shop selection index (0-2) |
| `0xD315` | 1 | `bD315` | Shop state byte |
| `0xD316` | 1 | `bD316` | Alternative price flag |
| `0xD317` | 1 | `bD317` | Event dispatch state |
| `0xD318` | 2 | `bD318` | Event dispatch index |
| `0xD31A` | 2 | `tD31A` | Action parameter |
| `0xD31B` | 1 | `bD31B` | Action parameter byte |
| `0xD31C` | 2 | `tD31C` | Action parameter |
| `0xD370` | 4 | `dwD370` | **C-Bills** (32-bit) |
| `0xD374` | var | `aD374[]` | Per-item-type player quantity array (uint32 stride 4) |
| `0xD376` | var | `aD376[]` | Per-item-type data array (uint16 stride 2) |
| `0xD390` | var | `tD390` | Additional data |
| `0xD392` | var | `tD392` | Additional data |
| `0xD394` | var | `tD394` | Additional data |
| `0xD396` | var | `tD396` | Additional data |
| `0xD398` | var | `tD398` | Additional data |
| `0xD399` | var | `tD399` | Additional data |

### 13. SAVE GAME LAYOUT (at segment 0x3092:0xC164 / memory offset)

The save file binary (no extension) has this layout:

| Offset | Size | Description |
|--------|------|-------------|
| `0x0000` | 1 | Header byte |
| `0x0001`-`0x0011` | 17 bytes | Infantry Party[0] (Jason) |
| `0x0012`-`0x0022` | 17 bytes | Infantry Party[1] |
| `0x0023`-`0x0033` | 17 bytes | Infantry Party[2] |
| `0x0034`-`0x0044` | 17 bytes | Infantry Party[3] |
| `0x0045`-`0x0055` | 17 bytes | Infantry Party[4] |
| `0x0056`-`0x0066` | 17 bytes | Infantry Party[5] |
| `0x0067`-`0x0077` | 17 bytes | Infantry Party[6] |
| `0x0078`-`0x0088` | 17 bytes | Infantry Party[7] |
| `0x0089`-`0x0099` | 17 bytes | Enemy Infantry[0] |
| `0x009A`-`0x00AA` | 17 bytes | Enemy Infantry[1] |
| `0x00AB`-`0x00BB` | 17 bytes | Enemy Infantry[2] |
| `0x00BC`-`0x00CC` | 17 bytes | Enemy Infantry[3] |
| `0x00CD`-`0x00DD` | 17 bytes | Enemy Infantry[4] |
| `0x00DE`-`0x00EE` | 17 bytes | Enemy Infantry[5] |
| `0x00EF`-`0x00FF` | 17 bytes | Enemy Infantry[6] |
| `0x0100`-`0x0110` | 17 bytes | Enemy Infantry[7] |
| `0x0111`-`0x018D` | 125 bytes | Mech: Lance[0] |
| `0x018E`-`0x020A` | 125 bytes | Mech: Lance[1] |
| `0x020B`-`0x0287` | 125 bytes | Mech: Lance[2] |
| `0x0288`-`0x0304` | 125 bytes | Mech: Lance[3] |
| `0x0305`-`0x0381` | 125 bytes | Mech: Enemy[0] |
| `0x0382`-`0x03FE` | 125 bytes | Mech: Enemy[1] |
| `0x03FF`-`0x047B` | 125 bytes | Mech: Enemy[2] |
| `0x047C`-`0x04F8` | 125 bytes | Mech: Enemy[3] |
| `0x04F9`-`0x0CF8` | 2048 bytes | World Map Visibility (128×128 bit-packed) |
| `0x0CF9` | 1 | Citadel Mission Flag |
| `0x0D50`-`0x0D5D` | 4 bytes | C-Bill value (32-bit) |
| `0x0D5D` | 8 bytes | Finance: C-Bills + Stock values (DefHes, NasDiv, BakPhar) |
| `0x0E30`-`0x0E0D` | — | First Aid (offset -0x0D) |
| `0x0E30`-`0x0E0E` | — | Field Medical Kit (offset -0x0E) |
| `0x0F45` | 2 | Party map position X |
| `0x0F47` | 2 | Party map position Y |

### Infantry Character Format (17 bytes each)

| Offset | Size | Field | Description |
|--------|------|-------|-------------|
| +0x00 | 1 | Character ID | Character type |
| +0x01 | 1 | Body | Body/RPG stat |
| +0x02 | 1 | Dexterity | Dexterity/RPG stat |
| +0x03 | 1 | Charisma | Charisma/RPG stat |
| +0x04 | 1 | Bows&Blades | Skill: Bows & Blades |
| +0x05 | 1 | Pistol | Skill: Pistol |
| +0x06 | 1 | Rifle | Skill: Rifle |
| +0x07 | 1 | Gunnery | Skill: Gunnery |
| +0x08 | 1 | Piloting | Skill: Piloting |
| +0x09 | 1 | Tech | Skill: Tech |
| +0x0A | 1 | Medical | Skill: Medical |
| +0x0B | 1 | Weapon | Equipped weapon type |
| +0x0C | 1 | Unknown | Unused/padding |
| +0x0D | 1 | ArmourType | Equipped armour type |
| +0x0E | 1 | ArmourValue | Current armour value |
| +0x0F | 1 | Health | Current health |
| +0x10 | 1 | Unknown2 | Unused/padding |

### Mech Data Format (125 bytes each, stride 0x7D)

| Offset | Size | Field | Description |
|--------|------|-------|-------------|
| +0x00 | 16 | Name | Mech name (ASCIIZ, null-padded) |
| +0x10 | 1 | Tonnage | Tonnage (uint8) |
| +0x11 | 11 | CurrentArmour[11] | Current armour by location |
| +0x1C | 8 | CurrentStructure[8] | Current internal structure |
| +0x24 | 4 | CurrentActuators[4] | Current actuator status |
| +0x28 | 1 | EngineHeatSinks | Heat sink count |
| +0x29 | 10 | CurrentAmmo[10] | Current ammo bins (decremented in combat) |
| +0x33 | 1 | WalkMove | Walk MP |
| +0x34 | 1 | JumpMove | Jump MP |
| +0x35 | 7 | Critical_L_Arm[7] | Left arm criticals |
| +0x3C | 7 | Critical_L_Torso[7] | Left torso criticals |
| +0x43 | 7 | Critical_R_Arm[7] | Right arm criticals |
| +0x4A | 7 | Critical_R_Torso[7] | Right torso criticals |
| +0x51 | 2 | Critical_L_Leg[2] | Left leg criticals |
| +0x53 | 2 | Critical_R_Leg[2] | Right leg criticals |
| +0x55 | 2 | Critical_C_Torso[2] | Center torso criticals |
| +0x57 | 1 | Critical_Head | Head criticals |
| +0x58 | 11 | MaxArmour[11] | Maximum armour (template) |
| +0x63 | 8 | MaxStructure[8] | Maximum structure (template) |
| +0x6B | 4 | MaxActuators[4] | Maximum actuators (template) |
| +0x6F | 10 | MaxAmmo[10] | Maximum ammo (template) |
| +0x79 | 4 | Unknown[4] | Unknown/padding |

## Reko Code Sub-Segments (within segment 0x0000)

These represent code sections within the main code segment, as labeled by Reko:

| Reko Name | Linear Offset | Description |
|-----------|--------------|-------------|
| `UNBTECH_0800` | 0x0800 | Main game loop (`fn0800_0000`), SPACE menu handlers, key dispatch |
| `UNBTECH_0D27` | 0x0D27 | Setup/init functions |
| `UNBTECH_0DAB` | 0x0DAB | Combat enemy spawning, random encounter setup |
| `UNBTECH_0FDC` | 0x0FDC | BLD loader/decrypt, bytecode interpreter (`fn0FDC_0008`, `fn0FDC_01C0`, `fn0FDC_1D30`) |
| `UNBTECH_11B8` | 0x11B8 | Room handler dispatch (`fn11B8_0D58`), encounter probability control |
| `UNBTECH_135D` | 0x135D | Animation dispatch (DISP/LOAD/INIT/CLEAR for left panel) |
| `UNBTECH_1431` | 0x1431 | Map rendering, star map |
| `UNBTECH_1467` | 0x1467 | Mode trigger functions |
| `UNBTECH_1543` | 0x1543 | Numeric input (`fn1543_0CDE`), utility functions |
| `UNBTECH_1631` | 0x1631 | Story properties (`fn1631_11AB`), LoS stepping (`fn1631_0006`), display |
| `UNBTECH_183B` | 0x183B | Combat initialization, enemy population |
| `UNBTECH_1AE8` | 0x1AE8 | Combat narrative dispatch |
| `UNBTECH_1CD3` | 0x1CD3 | Room/building interaction dispatcher (47 cases, `fn1CD3_0004`) |
| `UNBTECH_1E56` | 0x1E56 | Text renderer (`fn1E56_03F5`), scancode remapper (`fn1E56_0D1D`) |
| `UNBTECH_1F3D` | 0x1F3D | Border drawing dispatch (`fn1F3D_06C3`) |
| `UNBTECH_1FC5` | 0x1FC5 | Additional UI functions |
| `UNBTECH_204B` | 0x204B | Sound/interrupt handler |
| `UNBTECH_207F` | 0x207F | Screen rendering, blitter (`fn207F_24D7`), tile compositing (`fn207F_18EF`) |
| `UNBTECH_246C` | 0x246C | Tile property table, screen buffer functions |
| `UNBTECH_2FE8` | 0x2FE8 | Data segment |
| `UNBTECH_3056` | 0x3056 | Data segment (small) |
| `UNBTECH_3058` | 0x3058 | Data segment (small) |
| `UNBTECH_305B` | 0x305B | Data segment (small) |
| `UNBTECH_3092` | 0x3092 | Data segment (save game buffer, tile buffer) |
| `UNBTECH_3EDB` | 0x3EDB | Story text strings, data |

## Graphics / VGA Memory

| Address | Size | Description |
|---------|------|-------------|
| `A000:0000` | 64000 | EGA/VGA framebuffer (Mode 13h / Mode X planar) |
| `A000:(Y/2)*40 + plane*0x2000` | 40 bytes | Scanline Y even, plane P (Blue=0, Green=1, Red=2, Intensity=3) |
| `A000:2000+(Y/2)*40 + plane*0x2000` | 40 bytes | Scanline Y odd, plane P |
| `B800:0000` | 32768 | CGA/compatible text framebuffer |
| `AC00:0000` | — | VGA text framebuffer (VGA text mode) |

**NERVE.CENTER memory**: Located at `0x569E` segment (stored in `t569E` pointer). Contains `w4FBA` at offset `0x00FD` within this segment.

## Tile Buffer Layout (Segment 0x3092)

| Field | Description |
|-------|-------------|
| `4100 tiles × 128 bytes` | Tile animation buffer (3 pages, page select by `w5800` counter 0-1-2-0) |
| Source offset formula | `(w5800 << 7) + 0xD58A` (or `54658` depending on context) |
| Copy function | `fn207F_28A8` — 128-byte memcpy |
| Animation guard | `w3988` flag — when set, animation page swaps are paused |

## Known Combat-Related Memory

### Weapon Data (Segment 0x2000, 17 bytes per weapon, 33 weapons)

| Offset within weapon record | Size | Field |
|----------------------------|------|-------|
| `+0x00` | 10 | Name (ASCIIZ) |
| `+0x0A` | 1 | Damage |
| `+0x0B` | 1 | Shots/Volley |
| `+0x0C` | 1 | Heat per shot |
| `+0x0D` | 1 | Sound effect ID |
| `+0x0E` | 2 | Range (16-bit) |
| `+0x10` | 1 | Skill modifier |

Weapon instance byte at `ES:[SI+0x2EE4]` (17-byte stride):
- Bit 7 = infinite ammo flag
- Low 7 bits = initial remaining shots

Weapon instance byte at `ES:[SI+0x2EE3]` (17-byte stride):
- Per-missile damage for cluster weapons (LRM=1, SRM=2)

### Combat System Variables (Stack Frame)

In the combat handler `ghidra_guess_1000_458C_1458C`:

| BP Offset | Size | Description |
|-----------|------|-------------|
| `[BP-0x78]` | 24 | Per-unit combatant state array |
| `[BP-0x42]` | 1 | Stage counter (0..0xB, 12 stages, selects AI target preference) |
| `[BP-0x30]` | 2 | Computed Target Number (TN) |
| `[BP-0x28]` | 1 | Unit ID loop counter (0..0x17) |

### Heat System

| Memory Location | Size | Description |
|-----------------|------|-------------|
| `ES:[BX+0x92]` | 1 | Player heat pool (accumulated, cleared end-of-round) |
| `ES:[BX+0x6E]` | 1 | Player heat penalty accumulator (copied from pool, capped at 30) |
| `ES:[BX+0x8A]` | 1 | Enemy heat pool (accumulated, NEVER cleared) |
| `ES:[BX+0x66]` | 1 | Enemy heat penalty accumulator |

### Per-Unit Story State (inside Eq_107947 struct, stride 0x7D)

| Struct Offset | Size | Field |
|---------------|------|-------|
| `+0x00` | 1 | Generic per-story status byte |
| `+0x04`-`+0x05` | 2 | Nibble-packed flag fields |
| `+0x06` | 1 | Timing/counter nibble |
| `+0x24` | 1 | Skill modifier byte (popcount low 3 bits → 0-3) |
| `+0x25` | 1 | Second skill modifier byte |
| `+0x27` | 1 | AI target validation (non-zero = valid target) |
| `+0x33`~`+0x55` | 35 | AI target preference table (each byte = target_slot_id + 1, range 0x10-0x20) |
| `+0x55` | 1 | Counter for property 0x20 (capped at 3) |
| `+0x56` | 1 | Counter for property 0x20 (capped at 2) |
| `+0x57` | 1 | Story state byte: 0=Training, 1=Citadel Attack, 2=Post-Attack |
| `+0x58` | 1 | One-shot latch for property 0x1F |

## Known Data Tables

| Segment | Offset | Description |
|---------|--------|-------------|
| `DS:[0x5436]` | `0x2DF8` | Enemy mech pool table (3 light mech templates) |
| `DS:[0x566C]` | `0x2E5E` | Cluster hits table (LRM/SRM) |
| `DS` | `0x311A`-`0x313A` | 8-direction delta tables for LoS stepping |
| `DS` | `0x328A`/`0x329A`/`0x32AA`/`0x32BA`/`0x32CA` | 8-direction movement vectors |
| `DS:[0x5460]` | `0x4602` | BLD index translation table (22 entries, maps tile property→BLD file) |
| `DS` | `0x4F26`/`0x4F28` | Hospital cost table |
| `DS` | `0x4F44`/`0x4F46` | Unit selection buy cost table |
| `DS` | `0x4F6E` | Garage service cost table |

## Still Unknown / Gaps

1. **SoundBlaster/PC Speaker data** — Segment 204B handles interrupt 0x08/0x1C, but format of sound/music data is unknown
2. **ANM animation file mapping** — How segment 135D maps animation IDs to specific .ANM files
3. **Exact tile dimensions and animation frame mapping** in segment 0x3092 tile buffer
4. **Complete BLD index translation table** at `0x4602` — only partial decode
5. **`w3988` animation guard** — What sets it, when is animation paused
6. **Item-to-unit ammo bridge** — How global inventory `aD374` connects to per-unit mech ammo bins at offset `+0x29`
7. **`fn1CD3_0004` case 0x05 C618 anomaly** — Post-buy increment suggests packed type/count encoding
8. **`tB764` mode 0x03** — VGA mode X used in combat/stat screens? Stride 0x0A00
9. **Most function parameter structs in Eq_5 union** — The Reko `Eq_5` union has 70+ member types, most unnamed
10. **Complete BLD filename mapping** — Which maps reference which BLD files via translation table
