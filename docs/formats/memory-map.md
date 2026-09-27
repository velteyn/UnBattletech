# Memory Map: BattleTech - The Crescent Hawk's Inception

## MZ EXE Physical Segment Layout

The executable `UNBTECH.EXE` has **3 physical segments** in the MZ relocation table:

| Segment | Relocs | Contents | Reko Sub-Segments |
|---------|--------|----------|-------------------|
| `0x0000` | 1608 | Main code + some data | 0800, 0D27, 0DAB, 0FDC, 11B8, 135D, 1431, 1467, 1543, 1631, 183B, 1AE8, 1CD3, 1E56, 1F3D, 1FC5, 204B, 207F, 246C, 2FE8, 3EDB |
| `0x1000` | 830 | Combat code segment | (combat system, Spice86 segment 1000) |
| `0x3000` | 854 | Primary data segment | Tile props, BLD filenames, game state |

**EXE Entry Point**: `0x187F:0x2D82` (linear `0x1B572`), but the earlier CONTEXT.md analysis states `19EF:2D82` — the difference of `0x170` is the runtime load segment base.

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
| `0x538A` | 2 | `ptr538A` | **Pointer to world map viewport segment** (contains array data at D457, D497, D4D7, D517) |
| `0x53C6` | 2 | `ptr53C6` | **Pointer to world map tile buffer segment** (resolves dynamically) |
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

### 11. WORLD MAP TILE BUFFER

| Location | Size | Description |
|----------|-----:|-------------|
| `246C:244B` (linear 0x26B0B) | 4096 | **World Map Tile Buffer** (64×64 grid, 1 byte/tile ID) |
| `246C:42F6` | 4096 | **World Map Source Template** (base terrain, copied to 244B at init) |
| `DS:[ptr538A]:D457` | 64 | Viewport tile data array (tile IDs + packed flags) |
| `DS:[ptr538A]:D497` | 64 | Viewport packed screen X data |
| `DS:[ptr538A]:D4D7` | 64 | Viewport Y world coordinates |
| `DS:[ptr538A]:D517` | 64 | Viewport X world coordinates |
| `DS:[ptr538A]:D557` | 2 | Viewport next slot index |
| `DS:[ptr538A]:CB0C` | 2048 | **World Map Visibility bitmask** (128×128 bit-packed) |

### 12. TILE PROPERTIES

| Segment | Offset | Size | Description |
|---------|--------|------|-------------|
| `3000` | `0x32C6` | var | **Tile terrain TN modifier table** (stride 0x30, `0xFF`=impassable, packed X/Y coords) |
| `246C` | `0x7AD` | 1 per tile | **Tile property table** (LoS blocking, terrain visibility, movement cost factor) |
| `3000` | `0xCC30` | var | **BLD filename list** (array of .BLD file entries) |

### 13. SHOP / INVENTORY DATA (Offset 0xD300-0xD400)

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

1. ~~**SoundBlaster/PC Speaker data** — Segment 204B handles interrupt 0x08/0x1C, but format of sound/music data is unknown~~ **WONT_DO**: Irrelevant for reconstruction, replaceable with modern audio
2. **ANM animation file mapping** — How segment 135D maps animation IDs to specific .ANM files
3. **Exact tile dimensions and animation frame mapping** in segment 0x3092 tile buffer
4. **Complete BLD index translation table** at `0x4602` — only partial decode
5. **`w3988` animation guard** — What sets it, when is animation paused
6. **Item-to-unit ammo bridge** — How global inventory `aD374` connects to per-unit mech ammo bins at offset `+0x29`
7. **`fn1CD3_0004` case 0x05 C618 anomaly** — Post-buy increment suggests packed type/count encoding
8. **`tB764` mode 0x03** — VGA mode X used in combat/stat screens? Stride 0x0A00
9. **Most function parameter structs in Eq_5 union** — The Reko `Eq_5` union has 70+ member types, most unnamed
10. **Complete BLD filename mapping** — Which maps reference which BLD files via translation table


---

# Appendix: Address Reference (by code segment / function)

> Merged from the former `reference/ADDRESS_REFERENCE.md`. This is the
> segment/function-oriented complement to the DS-offset map above.

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

