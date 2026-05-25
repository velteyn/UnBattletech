# CONTEXT: BattleTech - The Crescent Hawk's Inception (1988) Reverse Engineering Project

## Project Overview

This is an extensive reverse engineering effort targeting **BattleTech: The Crescent Hawk's Inception**, a 1988 MS-DOS 16-bit real-mode game by Infocom. The original executable `BTECH.EXE` was unpacked to `UNBTECH.EXE`. The project aims to fully understand the game's internals — code, data formats, game logic — to produce comprehensive documentation enabling a full rewrite with modern technologies.

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

### Reko Decompiler (v0.12.2.0)
- Produced full decompilation in `UNBTECH.reko/`: 70+ files covering all segments
- Output formats: `.c` (C source), `.dis` (disassembly listing), `.asm` (assembly)
- Generated `UNBTECH.h` (695KB header with all struct/union equivalence classes)
- Key struct `Eq_57354` contains story state array `aC744[]` of `Eq_107947` elements (125 bytes each, stride 0x7D)
- Globals file maps segment pointers (e.g., `g_ptrFFFA0000`, `g_w046E`)

### Spice86 (Open Source x86 Emulator)
- Full emulation replay with memory dump at `spice86/spice86dumpMemoryDump.bin`
- 1427 Ghidra-recognized symbols in `spice86dumpGhidraSymbols.txt`
- Generated `.cs` files for ~23 code segments (24 files, `GeneratedCode.cs` through `GeneratedCode23.cs`, plus `GeneratedOverrides.cs`)
- Execution flow recorded in `spice86dumpExecutionFlow.json`
- CPU register trace in `spice86dumpCpuRegisters.json`
- Code generator logs in `Spice86CodeGenerator.txt` (354KB) and `Spice86DataImport.txt`

### Ghidra (via Spice86 integration)
- Memory dump addresses mapped to function symbols
- Functions named with pattern: `ghidra_guess_SEGMENT_OFFSET_LINEAR` or `unknown_SEGMENT_OFFSET_LINEAR`
- Combined disassembly in `UNBTECH_all.asm` (59,567 lines)

---

## 3. MEMORY MAP & DATA SEGMENTS

Key memory regions identified in data segment `3000` and others:

| Address Range | Purpose | Source |
|---------------|---------|--------|
| `3000:32C6` | Tile properties (movement cost, blocking) | discoveries.asm |
| `3000:CC30` | .BLD filename list | discoveries.asm |
| `0xC79B` (in struct at `DS:0x558E`) | Story state byte (b0057 of `Eq_107947`) | TECHNICAL_ANALYSIS.md |
| `0xA44B` | Unit X coordinate / cursor X | TECHNICAL_ANALYSIS.md |
| `0xA44D` | Unit Y coordinate / cursor Y | TECHNICAL_ANALYSIS.md |
| `0x4004` (segment `0x5592`) | Unit X positions array (ID * 2 offset) | TECHNICAL_ANALYSIS.md |
| `0x4036` (segment `0x5590`) | Unit Y positions array (ID * 2 offset) | TECHNICAL_ANALYSIS.md |
| `0x406A` | Unit status (0 = inactive/dead) | TECHNICAL_ANALYSIS.md |
| `2A02:C724` | Fog of War data | UNVERIFIED_DISCOVERIES.md |

### Per-Story Slot Structure (`Eq_107947`, 0x7D bytes each)

| Offset | Field | Purpose |
|--------|-------|---------|
| `0x00` | `b0000` | Generic per-story status byte |
| `0x04`-`0x05` | `b0004`/`b0005` | Nibble-packed flag fields |
| `0x06` | `b0006` | Timing/counter nibble |
| `0x55` | `b0055` | Counter (capped at 3) for property 0x20 |
| `0x56` | `b0056` | Counter (capped at 2) for property 0x20 |
| `0x57` | `b0057` | Story state byte (0=Training, 1=Citadel Attack, 2=Post-Attack) |
| `0x58` | `b0058` | One-shot latch/marker for property 0x1F |

### Story Progression Mechanism (`fn1631_11AB`)
- Property `0x1F`: Increments `b0057` (citadel attack state, max value 2)
- Property `0x20`: Multi-step story counter, increments `b0055`/`b0056`, clears `b0000` and sets `wE484=1` when complete
- Citadel attack triggered via script interpreter at `1E56:03F5`, displaying "They're trying to actually kill you!" from segment `3EDB:32F0`

---

## 4. FILE FORMATS

### .CMP (Compressed Images)
- **Header**: 3 bytes (2-byte little-endian size + 1-byte format)
- **Format 0x01**: RLE + row-major (standard full-screen images like BTTITLE, INFOCOM, ENDMECH)
- **Format 0x02**: RLE + column-major (sprite sheets like MECHSHAP, tile sets like BTBORDER)
- **RLE scheme**: Non-zero byte = literal run length; zero byte = extended run (next 2 bytes = 16-bit run length + 1 data byte)
- **Output**: 32000 bytes (320x200, 4-bit nibbles) → converted to 1 byte/pixel via `write2mode_converter`
- **EGA Planar**: 4 bit-planes (B/G/R/I), scanline-interleaved or full-plane modes

### .ICN (Icon/Tile Files)
- Same header structure as .CMP but 16-pixel-wide strips (tile sets)
- Contains 16x16 pixel tiles for maps

### .MTP (Map Files)
- **MAP1-MAP14**: Detailed header (3 bytes header + MapSizeX/Y + 0x80 bytes NPC names + 0x100 bytes building names + variable blocks)
- **MAP15 (STARMAP)**: Special 32x24 map, linear format
- **BlockFormat** (maps 1-2): 8x8 block-encoded tile data
- **LinearFormat** (maps 3-10): Linear block-encoded tile data
- Maps identified: Training Center (MAP1), Main City/Arena (MAP2), Destroyed Training Center (MAP11), Cave (MAP14)

### .BLD (Building Data / Scripts)
- Contains bytecode/triggers defining room interactions
- Filename list at `3000:CC30`
- 26 .BLD files (362-7282 bytes each): TRAINING, CITADEL, BARRACKS, BARRACK2, COMSTAR, FINDIT, FROB, GARAGE, HOSPITAL, HUT, INSTRUCT, JAIL, LOUNGE, MAYOR, PARTY, REPAIR, THEATER, VIEWDISK, WEAPON, WEAPON2, WINSCENE, CLOTHES, ARMOR, ENTRANCE, ARENA, ENDMECH

### .BLD Text Encoding (Substitution Cipher)

All dialogue in .BLD files uses a substitution cipher. Each byte in the range 0x57-0x7F and 0x80-0x96 maps to a specific letter. The cipher was cracked via frequency analysis and verified against known BattleTech lore names.

**Complete Cipher Table:**

| Range | Bytes | Maps To |
|-------|-------|---------|
| 0x57-0x5F | 57 58 59 5A 5B 5C 5D 5E 5F | i h k j m l o n a |
| 0x60 | 60 | q |
| 0x61-0x76 | 61 62 63 64 65 66 67 68 69 6A 6C 6D 6E 6F 70 71 72 73 74 75 76 | c b e d g f y x i z l m n o p s r u t w v |
| 0x77-0x7F | 77 78 79 7A 7B 7C 7D 7E 7F | I H K J M L O N A |
| 0x80-0x96 | 81 82 83 84 85 86 87 90 91 92 93 94 95 96 | C B E D G F Y P S R U T W V |

Notable: 0x77='I' (first person), 0x78='H' (pronoun), 0x79='K', 0x7A='J' are uppercase letters encoded in the "lowercase" byte range. 0x6B is a control byte (not text). 0xA0 is a space separator. Some minor spelling variations in game text (e.g., "eouipment" for "equipment", "ouite" for "quite") are original 1988 typos, not cipher errors.

### .BLD Bytecode Format (Script Interpreter)

The .BLD files use an inline bytecode format -- text strings are stored **inline** as operands to opcodes, not in a separate string table. The interpreter at `1E56:03F5` reads sequentially: opcode → text → opcode → text, alternating between binary control segments and cipher-encoded text segments.

**Header (8+ bytes):** `[file_type] [interaction_count] [ee c6 eb ea signature] [type_code 2 bytes] [subtype]`

**Content types:** `c0 ec`=dialogue/story, `c0 f5`=shop/service, `c0 f4`=special, `c0 da`=endgame

**Narrative mode switches** (single-byte, change how following text renders):
- `9e` = third-person narrative (924× most common)
- `9c` = character speech continuation (741×)
- `9b` = player internal thought (128×)
- `9f` = player-directed thought (97×)
- `a5` = sentence continuation (386×, appends lowercase)

**Control prefix `c0`** introduces structured blocks:
- `c0 e8 [2-byte state_id] [terminator]` = conditional state check (75×)
- `c0 f2 e9` = room description header (paired with `9e`)
- `c0 f3` = shop/service interaction (48×)
- `c0 e7` = shop item data block (24×)
- `c0 f5` = shop type switch (33×)
- `c0 f4` = special action type (28×)
- `c0 ec` = block terminator

**Menu system:** `9e bb bb` = header prompt, `aa bb` = first option, `bb` = subsequent option separators

**Known state IDs for conditionals:** `2f bf`=training mission, `ae b7`=armor shop, `e3 c2`=citadel attack state, `30 b8`=arena win/loss, `fb c2`=stock market, `f6 bf`=jailbreak state

For the complete opcode specification, opcode cross-reference table, and file-by-file breakdown, see `BLD_BYTECODE.md`.

### .ANM (Animation Files)
- 22 animation files (O0.ANM - O21.ANM)
- Fixed width: 88 pixels
- Start position at 0x33
- Size from first 2 bytes
- Uses XOR-based delta decompression (accumulative frames)

### Save Files (No Extension)
- 8 player infantry characters + 8 enemy infantry (17 bytes each)
- 4 lance mech slots + 4 enemy mech slots (125 bytes each)
- Map visibility (2048 bytes)
- Mission flags (CitadelMission, CitadelKatrinaVisit)
- Finance: C-Bills + stock values (DasHas, Nasdiv, BakPhar)
- Position (map X/Y coordinates)

### Mech Data Format (125 bytes per 'Mech)
Fields: Name (15 bytes), Tonnage, Armour (11 slots current+max), Internal Structure (8 slots current+max), Actuators (4 slots), EngineHeatSinks, Ammo (10 slots), WalkMove, JumpMove, Critical slots per location (7 per arm/torso, 2 per leg/center torso, 1 head)

---

## 5. COMBAT SYSTEM (Reverse-Engineered)

### Combat Loop (`GeneratedCode13.cs`)
- Iterates through unit slots (loop counter at `BP-0x28`, up to 0x0C units)
- Checks unit status at `ES:[BX+0x406A]` (0 = dead/inactive)
- Calls Unit State Check (`ghidra_guess_1000_0934_10934`)
- If unit can act (AX < 3), proceeds to Movement or Targeting

### Movement (`unknown_19EF_0971_1A861`)
- Source X/Y → `[0x238]`/`[0x23A]`, Dest X/Y → `[0x23C]`/`[0x23E]`
- Delta calculation: `DeltaY = SourceY - DestY`, `DeltaX = DestX - SourceX`
- Fine direction refinement via `split_1000_A8C6_1A8C6` (binary search on slope ratios)
- Sets bits 0x8/0x4/0x2/0x1 in DX → 16-way (or 32-way) angle
- Final lookup in table at `DS:[0x240]`

### Targeting (`ghidra_guess_1000_0934_10934`)
- Unit coordinates at `ES:[ID*2 + 0x4004]`/`ES:[ID*2 + 0x4036]`
- Target cursor at `ES:[0xA44B]`/`ES:[0xA44D]`
- Grid/sub-pixel coordinate system using masks 0xF7F, 0xF07F
- Calls `ghidra_guess_1000_05C5_105C5` for line-of-sight/range

### Fire Phase (`unknown_19EF_1886_1B776`)
- Iterates body parts/weapon mounts (SI=0x564, DI=0x324 offsets)
- Calls `unknown_19EF_11BB_1B0AB` (adjacency/grid processing):
  - 6x6 loop, bitwise ops on `[SI]`, `[SI±1]`, `[SI±8]`
  - Suggests grid width of 8 (critical hit transfer, splash damage, LoS)
- Damage application via `unknown_19EF_18EF_1B7DF` which calls RNG (`unknown_19EF_0BC0_1AAB0`)

### Weapon Data (33 weapons defined)
Types: Cludgel, Knife, Sword, Vibroblade, Shortbow, Longbow, Crossbow, Pistol, Rifle, MachineGun, SRMissile, Inferno, LaserPistol, LaserRifle, Flamer, Small/Medium/Large Laser, PPC, AC/2/5/10/20, LRM5/10/15/20, SRM2/4/6, Kick
Fields per weapon (17 bytes): Name(10), Damage, Shots?, Heat, SoundEffect?, Range(16-bit), Skill

### Known 'Mech Definitions
- **Chameleon** (50t): LargeLaser, MediumLasers, SmallLasers, MachineGuns
- **Locust** (20t): 2x MachineGun RA/LA, MediumLaser CT
- **Stinger** (20t): MachineGun + MediumLaser, jump jets
- **Wasp** (20t): MediumLaser RA, SRM2, jump jets
- **Commando** (25t): MediumLaser + SRM4/6
- **Jenner** (35t): 4x MediumLaser, SRM4, jump jets
- **UrbanMech** (30t): AC/10, SmallLaser
- **Spectator** (20t): Decoy/non-combatant mech

---

## 6. GAME'S WORLD MAPS

| File | Location | Notes |
|------|----------|-------|
| MAP1.MTP | Training Center / Citadel | Player start |
| MAP2.MTP | Main City | Chameleon training, Arena |
| MAP3.MTP | Small outpost/village | |
| MAP4.MTP | Large industrial city | |
| MAP5-8.MTP | Medium settlements | |
| MAP9.MTP | Outpost | |
| MAP10.MTP | Medium settlement | |
| MAP11.MTP | Destroyed Training Center | Post-attack state |
| MAP12.MTP | Large city/base | |
| MAP13.MTP | Medium settlement | |
| MAP14.MTP | Cave / Underground complex | |
| MAP15.MTP | Star Map | 32x24 special format |

---

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

## 9. JAVA REIMPLEMENTATION PROTOTYPE

A Swing-based Java prototype exists at `java_project/src/main/java/com/btech/`:

| File | Purpose |
|------|---------|
| `Main.java` | Entry point, JFrame 800x600, switches from startup to game |
| `Game.java` | Main panel: player/enemy mechs, stock market, combat log, Move/Fire/Market/Scan/Tech buttons |
| `Mech.java` | Mech model: name, tonnage, heat, armor, 25+ components, heat sinks |
| `MechComponent.java` | Component with name/hit points |
| `StockMarket.java` | 3-stock simulation (DefHes, NasDiv, BakPhar), random price fluctuation |
| `Palette.java` | Color palette for rendering |
| `PpmLoader.java` | PPM image loading |
| `GameGraphics.java` | Graphics handling |
| `GameStrings.java` | Generated game text strings from Reko disassembly |
| `MainViewPanel.java` | Central view panel |
| `SideBarPanel.java` | Sidebar UI |
| `TechScreen.java` | Tech/Repair screen |
| `VillagePanel.java` | Village view |
| `GeneralMapPanel.java` | World map |
| `StartupSequence.java` | Animated startup |

**Status**: Very early prototype — basic combat loop, placeholder graphics, incomplete game logic. Heavily hardcoded/anecdotal rather than data-driven from the reversed binary.

---

## 10. .NET ASSET EXTRACTION TOOLKIT (InceptionTools)

A C# console application (`.NET Core 3.1`) at `InceptionTools/` provides:

- **Asset extraction**: Full pipeline for all game assets (images, sprites, maps, animations)
- **Compression**: 3 RLE variants (Format01 row-major, Format02 column-major, Animation XOR-delta)
- **File format parsers**: CMP, ICN, MTP, ANM, Save files
- **Graphics**: EGA planar decoder, 16-color palette management, sprite sheet extraction, map tile rendering
- **Data definitions**: Weapon database (33 weapons), 8 mech definitions, infantry character parser, save game binary parser
- **Sprite enum**: Named constants for Locust, Commando, Character, Fire/Impact/Wreck sprites

---

## 11. PYTHON ANALYSIS SCRIPTS

### Core Tools
- **BLD interpreter** (`decode_bld_interp.py`): Full bytecode interpreter implementing all 26 opcodes (0xE4-0xFF), cipher text decoding, narrative marker handling, conditional skip/jump-forward branching, state tracking (credits, flags, cursor, state array). Validated against Reko decompilation — 24 of 28 opcodes used in actual BLD files, 4 unused (0xE5/0xF7/0xFA/0xFC).
- **BLD ↔ JSON converter** (`bld_json_converter.py`): Round-trip safe converter — parses BLD into structured JSON blocks (opcodes with annotations, decoded text, markers, control bytes) and reassembles JSON back to exact binary via byte concatenation. CLI: `to-json`, `to-bld`, `roundtrip`. All 26 BLD files verified byte-identical through round-trip.
- **Story extraction** (`extract_story.py`): Extracts all cipher-decoded narrative text from all 26 BLD files into readable English story script. Output: `STORY_TEXT.txt`.
- **Text extraction** (`extract_bld_text.py`, `extract_strings.py`): Pull game text from .BLD files and Reko disassembly.

### Other Scripts
- **Header analysis**: `analyze_header.py` (MZ EXE parsing)
- **Memory dump analysis**: `analyze_refs.py`, `analyze_refs_v2.py`, `debug_refs.py`, `find_refs.py`, `find_strings.py`, `search_refs.py`, `dump_locations.py`, `dump_msgs.py` — search Spice86 dump for strings and code references
- **Asset extraction**: `extract_assets.py` (RLE decompression + EGA planar rendering to PPM)
- **Format testing**: `debug_rle.py`, `render_cmp.py`, `test_planar.py` (experimental RLE/planar decoding)
- **Utilities**: `check_dims.py`, `inspect_headers.py`

### Output Files
- `STORY_TEXT.txt`: 90,451 characters, 2,319 lines, 797 dialogue lines across all 26 BLD files — complete game narrative in readable English.

---

## 12. STORY SUMMARY (Fully Decoded from .BLD Files)

The game's complete narrative is now readable from all 26 .BLD files. Set on the Lyran Commonwealth world **Pacifica**:

### Act 1: Training (TRAINING.BLD)
- Cadet **Jason Youngblood** undergoes MechWarrior training at the Citadel training center
- 8 training missions: familiarization, rubble pickup, weapons practice, reactionary combat, remote-controlled Locust duel, multi-Mech engagement, final exam
- **Rick Atlas**, an older cadet, befriends Jason and invites him to the lounge (LOUNGE.BLD)
- Rick gives Jason a mysterious device ("you'll know when you need to") and mentions he's never been to the Starport

### Act 2: The Invasion (TRAINING.BLD Citadel Attack)
- **Kuritan** (House Kurita) forces launch a lightning raid on Pacifica
- A Kuritan **Jenner** tries to crush Jason in his Mech's cockpit
- The Lyran Guard is wiped out; the Citadel is destroyed
- **Jeremiah Youngblood** (Jason's father) is missing, presumed dead
- Overheard shouts confirm: "Kuritan invaders! They've destroyed our army!"

### Act 3: Escape & Recruitment
- Jason must reach the **Starport** to escape the planet
- **Rex Pearce** (Crescent Hawk agent found via Rick's device) rescues Jason from a Kuritan party (PARTY.BLD)
- Rex gives Jason Jeremiah's box, containing a damaged holodisk and biochip
- The holodisk (VIEWDISK.BLD) contains Jeremiah's final message about the **Star League cache**
- Jeremiah had Dr. **Edward Tellhim** create a lock keyed to Rex's retinal scan + a password only Jason knows

### Act 4: Gathering Allies
- **Weapon Shop** (WEAPON.BLD, WEAPON2.BLD): buy infantry weapons; shopkeeper is a Kuritan collaborator
- **Repair Center** (REPAIR.BLD): recruit a tech as a Crescent Hawk agent; modify Mechs
- **Jail** (JAIL.BLD): rescue an imprisoned Crescent Hawk agent from the Pacifica Internment Center; acquire a **Stinger** from the impound yard
- **Hut** (HUT.BLD): face Dr. Tellhim's gauntlet of holographic tests; he repairs the holodisk, reveals the password, and directs Jason to the cache in a cave southeast of his hut
- **Frob** (FROB.BLD): navigate Tellhim's puzzle gauntlet (holographic face asks questions about Jeremiah)
- **Findit** (FINDIT.BLD): search the world map for clues to the cache
- **Mayor's House** (MAYOR.BLD): break in to read the newspaper (reveals "MECH STOLEN" and "KURITANS STARPORT TAKE OVER"), view Jeremiah's holodisk, escape the returning mayor
- **Barracks/Barrack2** (BARRACKS.BLD, BARRACK2.BLD): interact with other cadets and soldiers
- **ComStar** (COMSTAR.BLD): banking/stock market interface
- **Armor Shop** (ARMOR.BLD), **Clothes Shop** (CLOTHES.BLD), **Hospital** (HOSPITAL.BLD), **Garage** (GARAGE.BLD): various services
- **Arena** (ARENA.BLD): Mech combat arena
- **Entrance** (ENTRANCE.BLD), **Citadel** (CITADEL.BLD): story transition points

### Act 5: The Cache & Endgame
- **Instruct** (INSTRUCT.BLD): Jeremiah's note in the cache entrance explains the color-coded lock system
- Inside the Star League cache, Jason finds repair parts and Jeremiah's **Phoenix Hawk LAM** (Land-Air Mech)
- Using the **Hyperpulse Generator**, Jason signals **Archon Katrina Steiner**
- A **DropShip** arrives to extract the equipment
- Katrina offers Jason a commission as a Lieutenant in the **Lyran Commonwealth Armed Forces**
- **Jason declines**, believing his father may still be alive
- Evidence: the Phoenix Hawk LAM was programmed for a future mission, and Jeremiah was a **Kell Hound** targeted by Kurita's code of honor
- Katrina allows Jason, Rex, and the others to operate as an independent unit: **the Crescent Hawks**
- *"Press any key to end the game"* — Jason begins his search for Jeremiah

---

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
- Asset extraction → all graphics extracted and viewable

### Partially Understood
- Map tile properties at `3000:32C6` (movement cost, blocking, water)
- World map data location (suspected `2A02` or heap at `384B`)
- RNG implementation (`unknown_19EF_0BC0_1AAB0`)
- Fog of War data structure
- Script interpreter at `1E56:03F5` (can now correlate with decoded bytecode semantics — all 26 opcodes identified, conditional branching understood)
- Dialogue triggers and room interactions (can now correlate with decoded text; BLD↔JSON editing pipeline operational)
- Shop item data blocks (`c0 e7` format not fully parsed)

### Still Unknown / Needs Investigation
- Full script bytecode format and opcodes for .BLD files (partially documented in BLD_BYTECODE.md — 100+ opcodes identified, but some subtypes still unknown)
- Complete memory layout and data structure map
- AI decision logic
- Sound/music data (SoundBlaster config found but format unknown)
- RNG seed and distribution
- Pathfinding on the world map
- Inventory/item system details
- Character skill and level-up mechanics
- Save/load implementation details
- Many function-purposes in Reko decompilation (~1400+ functions, mostly unlabeled)
- EGA animation format full specification

---

## 14. NEXT STEPS & RECOMMENDATIONS

1. **Complete function labeling**: Map all ~1400 Ghidra/Reko functions to game actions using Spice86 trace data
2. **Script bytecode RE**: (~60% complete) Reverse engineer the .BLD script interpreter (at `1E56:03F5`), document all opcodes — major opcodes identified, c0 e8 conditional format understood, c0 e7 shop data still opaque
3. **Full memory map**: Cross-reference Spice86 dumps with Reko struct definitions to build complete variable map
4. **Animation format**: Fully document the .ANM XOR-delta format and EGA animation bit-shift algorithm
5. **Dialogue tree mapping**: (~70% complete) Extract all dialogue from .BLD bytecode and map conversation flow — text fully decodable, opcode semantics identified, room-entry/menu/conditional/dialogue flow understood
6. **RNG analysis**: Document the RNG polynomial/algorithm for accurate combat reproduction
7. **AI logic**: Trace AI decision trees in combat (target selection, movement priorities)
8. **Sound**: Investigate SoundBlaster/PC Speaker interrupt handler at segment 204B
9. **Data-driven recreation**: Port weapon/mech/map data from reversed structures into the Java prototype (or a more modern framework like Godot/Unity)
10. **Play through and trace**: Use Spice86 with targeted breakpoints to map story progression for all missions
9. **Data-driven recreation**: Port weapon/mech/map data from reversed structures into the Java prototype (or a more modern framework like Godot/Unity)
10. **Play through and trace**: Use Spice86 with targeted breakpoints to map story progression for all missions
