# CONTEXT: BattleTech - The Crescent Hawk's Inception (1988) Reverse Engineering Project

> Master overview / status. Deep technical detail lives in the canonical
> docs listed in `docs/INDEX.md`; sections below link out instead of duplicating.

## Project Overview

This is an extensive reverse engineering effort targeting **BattleTech: The Crescent Hawk's Inception**, a 1988 MS-DOS 16-bit real-mode game by Infocom. The original executable `BTECH.EXE` was unpacked to `UNBTECH.EXE`. The project aims to fully understand the game's internals — code, data formats, game logic — to produce comprehensive documentation enabling a full rewrite with modern technologies.

**Current status:** RE ~95% complete — all major systems understood (BLD bytecode, combat, maps, story, economy, world map). Engine rebuild underway in **Godot 4 + C#** (`BattleTechCHI/`). Phases 0-4 implemented; **Phase 5 in progress** (~8,000 lines C#): scaffold, data models, loaders, RLE decompressor, EGA palette, game loop, state machine, input, partial save/load, tile rendering, world/local map views, LocationMapper, BLD interpreter + 47-case dispatch, shops/dialogue, full combat system (2D6 to-hit, AI, heat, ammo, fog, HUD), ViewportManager, AnmPlayer with runtime ANM decompress, BldAnmMap, cursor-hover animation dispatch, and combat mech panel ANM (MechPortrait with state animation).

---

## 1. EXECUTABLE & COMPILER

| Property | Value |
|----------|-------|
| **Original binary** | `BTECH.EXE` (packed) |
| **Unpacked binary** | `UNBTECH.EXE` |
| **Platform** | MS-DOS 16-bit Real Mode (MZ executable) |
| **Compiler** | Microsoft C 5.0 (identified by Reko decompiler) |
| **Entry point** | `19EF:2D82` (linear 0x1CC72) |
| **Code segments** | `0800`, `0D27`, `0DAB`, `0FDC`, `11B8`, `135D`, `1431`, `1467`, `1543`, `1631`, `183B`, `1AE8`, `1CD3`, `1E56`, `1F3D`, `1FC5`, `204B`, `207F`, `246C`, `2FE8`, `3056`, `3058`, `305B`, `3092`, `3EDB` |

---

## 2. DECOMPILATION & ANALYSIS TOOLS

See [`docs/tools/analysis-tools.md`](tools/analysis-tools.md) for the tool inventory
(Reko, Spice86, Ghidra, InceptionTools, Python scripts).

## 3. MEMORY MAP & DATA SEGMENTS

See [`docs/formats/memory-map.md`](formats/memory-map.md) for the full memory map.
Story-slot layout and the progression mechanism (`fn1631_11AB`) are in
[`docs/story/story-system.md`](story/story-system.md).

## 4. FILE FORMATS

See the canonical format specs: [`formats/file-formats.md`](formats/file-formats.md),
[`formats/bld-bytecode.md`](formats/bld-bytecode.md),
[`formats/anm-format.md`](formats/anm-format.md).

## 5. COMBAT SYSTEM

See [`docs/combat-system.md`](combat-system.md).

## 6. WORLD MAP SYSTEM

See [`docs/world-map.md`](world-map.md).
## 7. RENDERING & GRAPHICS PIPELINE

- **Resolution**: 320x200 (standard DOS VGA/EGA Mode 13h-like)
- **Palette**: 16-color EGA (with per-asset swaps for title/Infocom/endgame screens)
- **EGA planar**: 4 bit-planes per pixel (Blue=0, Green=1, Red=2, Intensity=3)
- **Decompression path**: CMP/ICN → RLE decompress (Format01/02) → nibble-to-pixel → planar convert → bitmap
- **Sprite extraction**: From MECHSHAP.CMP (sub-rectangle coordinates in 8-pixel tile units)
- **Map rendering**: 16x16 tiles from tile sets, drawn to 320-wide bitmap
- **Animation**: XOR-based delta frames via EGA animation bit-shifting (4 left-shift-and-rotate operations per pixel)

Extracted assets (`.ppm` format in `extracted_assets/`, `.bmp` in `Assets/`):
- Title screen (BTTITLE.CMP), Infocom logo (INFOCOM.CMP), End game (ENDMECH.CMP)
- Statistics screen (BTSTATS.CMP), Border tiles (BTBORDER.CMP), Tiny land (TINYLAND.CMP)
- Icons: BTTLTECH.ICN, ANIMATE.ICN, STARLEAG.ICN, DESTRUCT.ICN, MAP.ICN
- Mech sprites (MECHSHAP.CMP): Locust, Commando, fire/impact/wreck, Character
- 22 animation sequences (O0-O21.ANM)
- Maps 1-15 rendered

---

## 8. GAME SYSTEMS (Identified from Strings & Code)

- **RPG Stats**: Body, Dexterity, Charisma; Skills (Bows&Blades, Pistol, Rifle, Gunnery, Piloting, Tech, Medical)
- **Infantry weapons**: Knife through LaserRifle, SRM, Inferno
- **Infantry armour**: FlakVest, FlakSuit, Light/Hvy Environment Suit, Ablative
- **Characters**: Jason Youngblood (protagonist), Katrina Steiner (Archon), Jeremiah Youngblood (father/Kell Hound), Rex Pearce (Crescent Hawk agent), Dr. Edward Tellhim (inventor), Rick Atlas (cadet), Russ, Zeke, Possum, Marco, Rusty, Hunter, Hawk
- **Economy**: C-Bills currency, Stock Market (DefHes, NasDiv, BakPhar tickers)
- **Equipment**: Weapons Shops, Armor Shops, Mechit-Lube, Repair/Tech screens
- **Mech components**: Engine, Gyro, Sensors, Actuators (arm/leg), Heat Sinks, Ammo, Myomer, Jump Jets, etc.
- **Critical slots**: 8 locations (R/L Arm, R/L Leg, R/L Torso, Head, Center Torso)

---

## 9. GODOT 4 + C# ENGINE REBUILD

See [`docs/rebuild/progress.md`](rebuild/progress.md) (status) and
[`docs/rebuild/roadmap.md`](rebuild/roadmap.md) (phases).

## 10. .NET ASSET EXTRACTION TOOLKIT (InceptionTools)

See [`docs/tools/analysis-tools.md`](tools/analysis-tools.md).

## 11. PYTHON ANALYSIS SCRIPTS

See [`docs/tools/analysis-tools.md`](tools/analysis-tools.md).

## 12. STORY SUMMARY

See [`docs/story/story-arc.md`](story/story-arc.md) (narrative) and
[`docs/story/story-system.md`](story/story-system.md) (internals).
## 13. WHAT'S KNOWN VS UNKNOWN

### Well-Understood
- Executable structure, compiler, entry point → fully mapped
- Image compression (RLE formats 01/02, EGA planar) → extraction pipeline working
- Map file format (.MTP) → header fully parsed, all maps extracted
- Save file binary format → fully documented
- Mech data format (125 bytes per mech) → fully reversed, 8 mechs defined
- Weapon data format → 33 weapons defined with stats
- Story state byte (C79B) and progression mechanism → confirmed through Reko/Ghidra
- **.BLD text encoding (substitution cipher) → fully cracked, all 26 files decodable**
- **Complete story narrative → fully extracted from dialogue**
- **.BLD bytecode opcodes → all 26 opcodes (0xE4-0xFF) implemented in interpreter, 24 confirmed used in-game**
- **BLD ↔ JSON round-trip → verified byte-identical for all 26 files**
- Combat loop structure → movement phase, targeting, fire phase identified
- World map random encounter system → flat RNG probability check (`RNG & bD330 == 0`) every frame at segment 0800:192-201, probability mask `0x1F` (1/32) / `0x7F` (1/128), no terrain modifier
- Heat system → weapon heat generation from instance byte, end-of-round dissipation via penalty accumulator transfer + pool clear
- To-hit formula → fully confirmed: 2D6 + skill(popcount) + terrain + heat(thresholds) + story state
- AI target selection → data-driven via story state property table at offsets 0x33-0x55
- **AI stage counter `[BP-0x42]`** → phase dispatch counter (0..0xB, 12 stages) selecting which n-th valid target preference to use. Passed to `ghidra_guess_1000_0AB2_10AB2` which iterates preference table, finds (stage)-th entry in range 0x10-0x20, returns target slot (value-1) if active. Stage 0xB is special handling. Counter set to 0xC to exit
- Asset extraction → all graphics extracted and viewable
- **Fog of War (Combat)** → twin 12×24 grids at `DS:[0x55D8]→0x40B4`/`0x41D4`, init 0x02 fogged, LoS clears to 0x00, fog blocks targeting/rendering
- **World Map Visibility** → 2048 bytes (bit-packed 128×128) persisted in save files at offset 0x04F9
- **Three-layer story state system** → state array at D30C (256 bytes), story properties fn1631_11AB (0x1C-0x23), flag system (bD450/bD451)
- **BLD opcode dispatch** → all 26 opcodes (0xE4-0xFF) decoded from fn0FDC_01C0, implemented in Python interpreter
- **fn1CD3_0004 case dispatch** → 47 cases (0x01-0x2F) mapping building/room interactions. Shop cases (0x04-0x0C) fully documented: single-item buy (formula `type*125+75`), bulk buy/sell (1 cr/unit), hospital, credit display, unit selection buy.
- **Shop/inventory data structures** → `aC618[0..2]` (3 shop item slots), `aD374[]` (per-item-type player qty, ui32 stride 4), `aD376[]` (per-item-type data, word16 stride 2), `tD370`/`tD372` (32-bit credits). Documented at `story/story-system.md` §17.11.
- **Story arc progression** → 7 phases: NewGame→Training→CitadelAttack→FreeRoam→EventTriggers→MultiStep→Endgame
- **Map→BLD event mapping** → BLD index determined by tile properties at 0x32C6 + translation table at segment `[0x5460]:0x4602` (16-byte table loaded from MTP header, maps tile property→BLD file index)
- **Screen layout mapped**: 320×200 EGA. Left panel = **80px** (`0x50` constant, confirmed by `fn207F_24D7` clipping to `0x50`), right panel = 240px.
- **Global UI mode `w4FBA`** (seg `0x569E`+0x00FD): 4 modes — 0=WorldMap, 1=LocalTiles, 2=Text, 3=BuildingName. Modes 4-6 do not exist. Checked at 60+ code paths across 8 segments. Set at startup from keys 1-4: raw ASCII (0x31-0x34) stored at pseudocode line 5922, normalized to 0-3 at line 5961 (`-= 0x31`) after protection screen. During main render loop (lines 6110-6132): if w4FBA==0, temporarily toggled to 1 during rendering then restored to 0. Values 0 and 1 produce same border variant. No BLD opcode or function changes w4FBA to a different mode during gameplay.
- **`w4FBC` viewport flag** (selector `0x53E8`, offset `0x4FBC`): Binary flag (0/1) for left-panel width narrowing (80px→4px). The actual mechanism for combat, building, and menu viewport changes. Set/cleared across 9+ pseudocode sites.
- **`tB764` rendering sub-mode** (seg `0x246C`, offset `0xB764`): Font stride/blitter selection. 0=CGA, 1=EGA planar, 2=VGA text, 3=VGA mode X. Set by `fn207F_2CE1`.
- **Border system**: 3 variants dispatched by `fn1F3D_06C3()`. Full border (`fn207F_1CB8`) for w4FBA 0/1; narrow text border (`fn207F_1D3A`, 27 word writes per row) for w4FBA 2; text overlay (`fn207F_245C`, wrapper calling `fn207F_24D7`) for w4FBA 3.
- **Main game loop (`fn0800_0000`)**: 6-phase architecture — Input → Key Dispatch → Timer → Economy → Animation+Render → BLD. Runs while `w0152==0`. Screen refresh driven by `w014A` flag. w014A values: 0=normal (render + BLD process), 1=suspend normal refresh (modal screens like stat/inventory), 2=suspend ALL processing (game ticks stop, timers freeze, no key dispatch, used during building transition/loading). Value 2 seen empirically at tile (27,6) after Space-clearing dialogs near COMSTAR. **Re-diagnosis (2026-09-27)**: that stall was actually a BIOS `int 16h` key-wait at `0x19FC:0xB57` (cycles still advancing, IP parked in the wait wrapper), and delivering a key (Space) resumes the game — `w014A=2` was a side effect, not the blocker. See AGENTS.md Known Issues #4.
- **Rendering pipeline**: 3-pass compositing. Pass 1 = right panel via `fn207F_18EF` (13×12 tile grid centered on cursor). Pass 2 = left panel border via `fn1F3D_06C3`. Pass 3 = text overlay via `fn1E56_03F5`.
- **EGA planar framebuffer**: 4 bit-planes, 40 bytes/plane/scanline. Odd/even row interleaving with `0x2000` plane stride. Row-pair stride = 80 bytes (`0x50`). `fn207F_24D7` has 4 cases: 0x00 (80px left, planar interleave), 0x02 (40px text, linear), 0x01 (160px, 4-way planar), default (320px full, linear).
- **`tB764` pixel format flag**: At seg 246C. 0x00=CGA (0xB800), 0x02=VGA text (0xAC00), 0x03=VGA mode X (0xA000, stride 0x0A00), default=EGA planar (0xA000).
- **Tile animation**: `fn0800_240B` implements 3-frame page swap via `w5800` counter (0→1→2→0). Source offset = `(w5800 << 7) + 54658`. Copies 4100 tiles × 128 bytes each frame via `fn207F_28A8`. Guarded by `w3988` flag. `fn0800_24C2` handles unit position updates on every 3rd frame.
- **NPC world-map movement engine (`fn0800_24C2`)**: 8 story NPCs with waypoint-based wandering. Per-NPC movement delay timer `bD399[slot]` counts down each frame. On arrival at waypoint, picks random direction via `RNG() & 0x1F`, looks up new destination from table `0x4564`/`0x57D6`. Step-toward uses `fn0800_191B` + `fn1631_0006` (LoS tile-step). Direction/state packed nibble in `0xD398[slot]`. See `world-map.md` (NPC world-map movement).
- **fn1CD3_0004 dispatch cases 0x0D-0x18**: Full equip/unit management mapped — EQUIPMENT_MENU (0x0D), COUNT_UNITS (0x0E), EQUIP_SLOT5 (0x0F, 500cr), CHECK_SLOT5 (0x10), COUNT_STORY_SLOTS (0x11), DISPATCH_11B8 (0x12-0x14), EQUIP_SLOT6 (0x15, 500cr), CHECK_SLOT6 (0x16), EQUIP_CONSISTENCY (0x17), GARAGE_SERVICE (0x18, cost table at 0x4F6E).
- **Arrow key handler `fn0800_218F`**: Decodes scancodes → (dx,dy) movement. Calls `fn207F_158C/163B` (vertical) or `fn207F_17C5/16E3` (horizontal). Renders 3 tiles under cursor via `fn0800_2DA8` + `fn207F_1DA8`. Each frame ends with `fn207F_1314` (cursor set) + `fn207F_1DF8` (tile index update).
- **World map rendering `fn0800_2A93`**: Renders 64 tiles (0x40) centered on cursor for w4FBA=0. For w4FBA=2 (text), renders 8-wide character grid to 0xAC00 via `fn207F_0377`. Otherwise renders tiles to 0x246C:0x244B via `fn207F_28EB`.
- **Screen refresh `fn207F_18EF`**: Based on `tB764`. For default mode: draws 13×12 tile grid centered on cursor `(A44B, A44D)`. Reads tile property from seg 246C `+0x7AD[tile_index]`. Calls `fn207F_1AA8`/`1ACE`/`1AF4` for tile writes to VRAM.
- **`0xC0` is a pure no-op in BLD bytecode** — NOT a control prefix. Byte `0xC0` is consumed silently; the actual opcode is the following byte (0xE4-0xFF). All absolute jumps use `fn0FDC_05F7` to read 16-bit LE absolute offsets within BLD data.
- **E7 (CMP_CURSOR_X) format**: `[2B LE compare_val] [2B LE abs_jump]` — if cursor X matches, jump to `abs_jump`; else skip 2 bytes.
- **E8 (RNG_CHECK) format**: `[1B mask] [2B LE abs_jump]` — if `RNG() & mask != 0`, jump to `abs_jump`; else skip 2 bytes.
- **Stat/inventory screen (`fn0800_3D40`)**: SPACE menu option 6. Sets `w014A = 1` (suspend normal refresh). Own input loop via `fn0800_3FAE` which has 8 rendering phases: screen clear (`fn207F_1FBE`), coordinate setup, star map or normal background (48-row BTSTATS.CMP tile render from seg 0x246C via `fn207F_104E`), 3×3 subtile unit data overlay, visibility/fog overlay (24×40), direction/status text, bottom bar animation + sparkle effect, key wait. Cleanup on SPACE exit: restores cursor, `fn207F_1314`, `fn207F_18EF`, `fn1F3D_06C3`, `fn0800_4CAC(1)`, `w014A = 0`. BTSTATS.CMP pre-loaded at game init. No CMP/ICN/BLD loading in stat screen path. w4FBA read-only (in `fn0800_45C2` only).
- **SPACE menu handlers**: All 7 options mapped — option 1=`fn0800_3BD0` (party/equip, 5 sub-modes), option 2=`fn0800_378D` (tech/repair, 7 item slots, flag display), option 3=`fn1431_000A` (star map), option 4=`fn0800_32B3` (enter building), option 5=`fn0800_35D3` (stock market, w4FBA-aware), option 6=`fn0800_3D40` (stat/inventory, modal), option 7=`fn0800_4D57` (special dispatch). All call `fn0800_4CAC(1)` for cleanup.

### Partially Understood
- **Mech/Unit inventory system**: Two-tier (story slots aC724→unit slots aC614). 4 characters × 2 mechs each = 8 owned units. Garage/swap UI at `fn0FDC_15E6`. See `story/story-system.md` §17.10.
- BLD index translation table at `segment [0x5460]:0x4602` — not fully decoded per-location

### Still Unknown / Needs Investigation
- Complete memory layout and data structure map
- Sound/music data (SoundBlaster config found but format unknown) — **WONT_DO**: irrelevant for reconstruction, replaceable with modern audio
- Character skill and level-up mechanics
- Save/load implementation details
- Many function-purposes in Reko decompilation (~1400+ functions, mostly unlabeled)
- EGA animation format full specification

---

## 14. NEXT STEPS & RECOMMENDATIONS

See [`docs/rebuild/roadmap.md`](rebuild/roadmap.md).
