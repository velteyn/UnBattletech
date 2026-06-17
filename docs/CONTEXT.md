# CONTEXT: BattleTech - The Crescent Hawk's Inception (1988) Reverse Engineering Project

## Project Overview

This is an extensive reverse engineering effort targeting **BattleTech: The Crescent Hawk's Inception**, a 1988 MS-DOS 16-bit real-mode game by Infocom. The original executable `BTECH.EXE` was unpacked to `UNBTECH.EXE`. The project aims to fully understand the game's internals — code, data formats, game logic — to produce comprehensive documentation enabling a full rewrite with modern technologies.

**Current status:** RE ~95% complete — all major systems understood (BLD bytecode, combat, maps, story, economy, world map). Engine rebuild underway in **Godot 4 + C#** (`BattleTechCHI/`). Phases 0-4 implemented; **Phase 5 in progress** (~7,800 lines C#): scaffold, data models, loaders, RLE decompressor, EGA palette, game loop, state machine, input, partial save/load, tile rendering, world/local map views, LocationMapper, BLD interpreter + 47-case dispatch, shops/dialogue, full combat system (2D6 to-hit, AI, heat, ammo, fog, HUD), ViewportManager, AnmPlayer with runtime ANM decompress, BldAnmMap, and cursor-hover animation dispatch.

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
| `3000:32C6` | Tile properties (movement cost, blocking, terrain TN mod) | discoveries.asm |
| `3000:CC30` | .BLD filename list | discoveries.asm |
| `0x246C:0x244B` | **World Map Tile Buffer** (4096 bytes = 64×64 grid, 1 byte/tile) | WORLD_MAP_FINDINGS.md |
| `0x246C:0x42F6` | World Map Source Template (copied to tile buffer at init) | WORLD_MAP_FINDINGS.md |
| `DS:[0x538Ah]→0xD457` | Viewport tile data array (64 entries, tile IDs + flags) | WORLD_MAP_FINDINGS.md |
| `DS:[0x538Ah]→0xD497` | Viewport packed screen X data (64 entries) | WORLD_MAP_FINDINGS.md |
| `DS:[0x538Ah]→0xD4D7` | Viewport Y world coordinates (64 entries) | WORLD_MAP_FINDINGS.md |
| `DS:[0x538Ah]→0xD517` | Viewport X world coordinates (64 entries) | WORLD_MAP_FINDINGS.md |
| `DS:[0x538Ah]→0xCB0C` | World Map Visibility (2048 bytes, bit-packed 128×128, also in save at 0x04F9) | WORLD_MAP_FINDINGS.md |
| `0x246C:0x7AD` | Per-tile property table (256 entries: LoS blocking, terrain visibility) | WORLD_MAP_FINDINGS.md |
| `0xC79B` (in struct at `DS:0x558E`) | Story state byte (b0057 of `Eq_107947`) | TECHNICAL_ANALYSIS.md |
| `0xA44B` | Unit X coordinate / cursor X | TECHNICAL_ANALYSIS.md |
| `0xA44D` | Unit Y coordinate / cursor Y | TECHNICAL_ANALYSIS.md |
| `0x4004` (segment `0x5592`) | Unit X positions array (ID * 2 offset) | TECHNICAL_ANALYSIS.md |
| `0x4036` (segment `0x5590`) | Unit Y positions array (ID * 2 offset) | TECHNICAL_ANALYSIS.md |
| `0x406A` | Unit status (0 = inactive/dead) | TECHNICAL_ANALYSIS.md |
| `DS:0xD30C` | Generic state array (256 bytes) | TECHNICAL_ANALYSIS.md |
| `DS:0xD450` | Training complete flag (`bD450`) | TECHNICAL_ANALYSIS.md |
| `DS:0xD451` | Milestone marker flag (`bD451`) | TECHNICAL_ANALYSIS.md |
| `DS:0xD330` | Encounter probability mask (`bD330`: 0x1F/0x7F) | TECHNICAL_ANALYSIS.md |
| `DS:0xD310` | World map active flag (`bD310`) | TECHNICAL_ANALYSIS.md |
| `DS:0xD346` | Star map/alternate view flag (`bD346`) | TECHNICAL_ANALYSIS.md |
| `DS:0x4602` | BLD index translation table (22 entries) | TECHNICAL_ANALYSIS.md |
| `DS:[0x55D8]→0x40B4` | Combat Fog Grid A (12×24, init 0x02=fogged) | GeneratedCode12.cs |
| `DS:[0x55D8]→0x41D4` | Combat Fog Grid B (12×24, init 0x02=fogged) | GeneratedCode12.cs |
| `DS:[0x3092]→0x04F9` | World Map Visibility (2048 bytes, bit-packed 128×128) | SaveGame.cs |

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
The game uses a **three-layer state system** to drive the narrative:

**Layer 1: Generic State Array at `DS:0xD30C` (256 bytes)**
- Modified by BLD opcodes `0xF1` (ADD_TO_STATE) and `0xF4` (SET_STATE_VALUE)
- Checked by opcodes `0xF7` (STATE_COND_CHECK) and `0xF3` (SHOP_INTERACTION)
- Handles day-to-day state: shop inventories, visited flags, quest progress, party status
- Persists across BLD script invocations

**Layer 2: Story Properties (`fn1631_11AB`, segment `1631:11AB`)**
- Property `0x1F`: Increments `b0057` (citadel attack state, max value 2). Subcodes 2/5 increment state; subcodes 1/6 latch `b0058` to 0xFF
- Property `0x20`: Multi-step story counter, increments `b0055` (cap 3) / `b0056` (cap 2), clears `b0000` and sets `wE484=1` when complete
- Property `0x1C-0x23`: Nibble-packed flag management for skill tracking (offset 0x24/0x25) and inventory/equipment

**Layer 3: BLD Flag System**
- Flag `bD450` (at `0xD450`): training complete marker. Set by `fn1CD3_0004` case `0x19` (FLAG_D450)
- Flag `bD451` (at `0xD451`): milestone marker. Set by `fn1CD3_0004` case `0x1A` (FLAG_D451)
- Checked by opcodes `0xEB` (CHECK_FLAG_EB → `bD451`) and `0xEC` (CHECK_FLAG_EC → `bD450`)

**Citadel attack chain**: Training completion sets `bD450=1` → TRAINING.BLD transitions to attack narrative → `0xF5` SHOP_DISPATCH triggers combat encounter → `fn1AE8_000C` (combat narrative) calls `fn1631_11AB` with property `0x1F` → `b0057` increments 0→1→2 → world changes (encounter probability enabled, MAP1→MAP11, city tiles unlocked)

**Key locations**: INC `byte ptr ES:[BX+0xC79B]` at offset `0x12A76` (`UNBTECH.exe`). Story text at `3EDB:32F0`: "They're trying to actually kill you!"

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

**Byte `0xC0`** is a structural separator consumed as a no-op by the interpreter. The byte immediately following `0xC0` is the actual opcode that does the work. This means `c0 e8` is NOT a composite prefix + sub-opcode — it is `C0` (skipped) + `E8` (RNG_CHECK opcode). Similarly for all C0-prefixed patterns.

Common C0-prefixed patterns (with actual opcode semantics):
- `c0 e8 [1B mask] [2B LE abs_jump]` = RNG_CHECK: if `RNG() & mask != 0`, jump to `abs_jump`; else skip 2 bytes
- `c0 e7 [2B LE compare_val] [2B LE abs_jump]` = CMP_CURSOR_X: if cursor X == compare_val, jump to `abs_jump`; else skip 2 bytes
- `c0 f3 [1B state_idx]` = SHOP_INTERACTION: read `D30C[state_idx] * 2` as absolute jump offset (dynamic dispatch)
- `c0 f5 [1B case]` = SHOP_DISPATCH: call `fn1CD3_0004(case)`
- `c0 f2 e9` = ROOM_DESCRIPTION + CALL_ROOM_HANDLER (two independent opcodes)
- `c0 f4 [1B idx] [1B val]` = SET_STATE_VALUE: `D30C[idx] = val`
- `c0 ec` = CHECK_FLAG_EC: check bD450; if set, read 2B abs_jump; else skip 2 bytes
- `c0 da` = pure structural marker (both C0 and DA are no-ops)
- `c0 e9 [1B handler]` = CALL_ROOM_HANDLER: call `fn11B8_0D58(handler)`

All absolute jumps in BLD bytecode (E7, E8, EC, F3, F8) use **fn0FDC_05F7** to read a 16-bit little-endian word that replaces the bytecode position counter — these are absolute offsets within the BLD data, not relative jumps.

### BLD Data Decryption & Interpreter Base Offset

All BLD data bytes at offset ≥0xA0 are decrypted in-place after loading. The decryption formula (confirmed from `fn0FDC_1D30` assembly at segment `0FDC:1D30`):
```
decrypted[0xA0 + bx] = ((raw[0xA0 + bx] + 41) & 0xFF) ^ 233   for bx = 0..8999
```

The bytecode interpreter `fn0FDC_01C0` reads from a **base offset of 0xA0** within the loaded BLD buffer — the first argument (SI register) is hardcoded as `0xA0`. Bytecode position 0 corresponds to memory address `segment:0xA0`. This means bytes at file offsets 0x00–0x9F (header/metadata area) are NEVER interpreted as bytecode by the in-game interpreter.

**Important caveat for `bld_json_converter.py`**: The converter reads from file offset 0 and parses ALL bytes, including the 0x00–0x9F header region. Any opcode annotations (like 0xF5 SHOP_DISPATCH) at positions < 0xA0 are **false positives** — raw bytes that happen to match opcode values but are NOT part of the actual bytecode stream. Only the decrypted bytes at positions ≥ 0xA0 represent real bytecode.

**SHOP_DISPATCH (0xF5) operand resolution**: The operand byte at bytecode position N reads the decrypted byte at `buffer[0xA0 + N + 1]` (1 byte past the 0xF5 opcode). This value is sign-extended and passed DIRECTLY as the case number to `fn1CD3_0004(case)`. It is NOT an indirect index into the buffer.

Confirmed real SHOP_DISPATCH calls in TRAINING.BLD (decrypted):

| Interpreter Pos | File Offset | Decrypted Case | Case Name |
|---|---|---|---|
| 2537 | 0x0A89 | 0x01 | ENTER_BUILDING |
| 4013 | 0x104D | 0x02 | SHOW_GREETING |
| 5588 | 0x1674 | 0x2B | (unknown) |
| 6987 | 0x1BEB | 0x0C | CLOSE_ACTION |
| 7117 | 0x1C6D | 0x03 | EXIT_BUILDING |

**Menu system:** `9e bb bb` = header prompt, `aa bb` = first option, `bb` = subsequent option separators

### Four-Layer Interpreter Architecture

```
Layer 1: fn0FDC_0008 (0FDC:0008)
  Entry point. Loads BLD data by index, prepares buffer via fn0FDC_1D30.

Layer 2: fn0FDC_01C0 (0FDC:01C0)
  Bytecode interpreter. Handles opcodes 0xE4-0xFF (see opcode table below).
  Bytes 0x00-0x7F are transparent (cipher text passes through to renderer).
  Bytes 0x80-0xC3 enter switch but match no cases (structural markers/no-ops).

Layer 3: fn1CD3_0004 (1CD3:0004)
  Room/building interaction dispatcher. 47-case switch (0x01-0x2F).
  Handles: building enter/exit, shop buy/sell, combat, healing, flags, party.

Layer 4: fn1E56_03F5 (1E56:03F5)
  Text renderer. Formats cipher-encoded text with word-wrapping, margins.
  Special chars: 0x0D=CR, 0x02/0x06=soft break, 0x20=space, 0x09=indent.
```

### BLD Opcode Dispatch Table (fn0FDC_01C0, 0xE4-0xFF)

| Opcode | Name | Operand | Description |
|--------|------|---------|-------------|
| `0xE4` | WRITE_CHAR | 1 byte | Read byte, write as character |
| `0xE5` | ADD_CREDITS | 2 bytes LE | Add signed value to `tD370` (C-Bills) |
| `0xE6` | SET_CURSOR_XY | 4 bytes LE | Set cursor X/Y coordinates |
| `0xE7` | CMP_CURSOR_X | 2 bytes LE | Compare with `A44B`; if NOT equal, skip 2 bytes (jump target); else read 2B LE abs_jump |
| `0xE8` | RNG_CHECK | 1 byte | If `(RNG() & mask) == 0`, skip 2 bytes (jump target); else read 2B LE abs_jump |
| `0xE9` | CALL_ROOM_HANDLER | 1 byte | Call `fn11B8_0D58(operand)` |
| `0xEA` | COND_STATE_ACTION | 2 bytes (cond+action) | If `w3938==0`, call `fn0800_48B7(cond, action)` |
| `0xEB` | CHECK_FLAG_EB | 0 bytes | Skip if `bD451 == 0` |
| `0xEC` | CHECK_FLAG_EC | 0 bytes | Skip if `bD450 == 0` |
| `0xED` | UNIT_CHECK_LOOP | 2 bytes | Loop 8 units checking `aC60F` state |
| `0xEE` | SPEND_CREDITS | 2 bytes LE | Deduct from `tD370` (zero-floor) |
| `0xEF` | CHECK_CREDITS | 2 bytes LE | Skip if insufficient funds |
| `0xF0` | SET_TEXT_MARGINS | 2 bytes | Set left/right margins |
| `0xF1` | ADD_TO_STATE | 2 bytes | `D30C[index] += value` |
| `0xF2` | ROOM_DESCRIPTION | 0 bytes | Render room description |
| `0xF3` | SHOP_INTERACTION | 1 byte | Index into `D30C`, indirect dispatch |
| `0xF4` | SET_STATE_VALUE | 2 bytes | `D30C[index] = value` |
| `0xF5` | SHOP_DISPATCH | 1 byte | Read 1 decrypted operand byte, pass DIRECTLY as case to `fn1CD3_0004(case)`. NOT an indirect index — byte IS the case value. |
| `0xF6` | CHECK_CONDITION | 0 bytes | Skip if `fn0800_1A13(1)` returns 0 |
| `0xF7` | STATE_COND_CHECK | 1 byte | Skip if `D30C[index] == 0` |
| `0xF8` | JUMP_FORWARD | 2 bytes LE | Read 2-byte WORD → absolute jump target (new IP = word value) |
| `0xF9` | JUMP_INDEXED | 1 byte | Calls `fn1E56_0B5E(op)` → returns selection index; reads WORD at `base + _ip + index*2` as new IP (absolute jump table). Jump table entries are WORDs right after operand byte |
| `0xFA` | DRAW_SPRITE | 1 byte | Draw sprite |
| `0xFB` | ADVANCE_INPUT | 0 bytes | Wait for key |
| `0xFC` | RENDER_TEXT | N bytes | Display cipher text, advance past string |
| `0xFD` | SET_FONT2 | 0 bytes | Font/display parameters |
| `0xFE` | SET_FONT | 1 byte | Set font |
| `0xFF` | EXIT | 0 bytes | Stop interpreter |

### fn1CD3_0004 Case Dispatch (Shop-Relevant Cases)

| Case | Name | Description |
|------|------|-------------|
| `0x01` | ENTER_BUILDING | Load building BLD data, init viewport |
| `0x02` | SHOW_GREETING | Display building entry text |
| `0x03` | EXIT_BUILDING | Clear building state, restore coordinates |
| `0x04` | SHOW_SHOP_ITEMS | Render 3 items from `C618[0..2]`, formula `price = C618[n] * 125 + 75` |
| `0x05` | BUY_ITEM_SINGLE | Single item: `C618[bD314] += 1`, `tD370 -= C618[bD314] * 125 + 75` |
| `0x06` | SHOW_PLAYER_ITEMS | Display player's owned items (`aD374[n] != 0`) in categories for potential sale |
| `0x07` | BUY_ITEM_BULK | Bulk buy at 1 cr/unit: `fn1543_0CDE`→qty, `aD374[sel] += qty`, `tD370 -= qty` |
| `0x08` | SELL_ITEM_BULK | Bulk sell at 1 cr/unit: `fn1543_0CDE`→qty, `aD374[sel] -= qty`, `tD370 += qty` |
| `0x09` | HOSPITAL_HEAL | Cost from table `0x4F26/0x4F28`, 32-bit credit check, `fn1631_1FDF` display |
| `0x0A` | SHOW_CREDITS | Display current credits `tD370`/`tD372` |
| `0x0B` | BUY_WITH_UNIT_SEL | Cost from table `0x4F44/0x4F46`, calls `fn0FDC_15E6` unit selection |
| `0x0C` | CLOSE_ACTION | Close current shop/building action |
| `0x19` | FLAG_D450 | Set `bD450 = 1` (training complete) |
| `0x1A` | FLAG_D451 | Set `bD451 = 1` (milestone marker) |
| `0x23` | NEW_GAME_INIT | Full game init: clear state, load templates |
| `0x27` | TRIGGER_ACTION | Mode trigger via `fn1467_0002` |
| `0x29` | COMBAT_HEAL | Apply RNG damage/healing to party |
| `0x2D` | COMBAT_ENCOUNTER | Handle combat state transitions (0→2→3) |

**Key details**:
- `fn1543_0CDE`: Numeric input from keypad (digits `'0'-'9'`), accumulates `value = value * 10 + digit`. Backspace (0x08) deletes last digit, Enter (0x0D) finalizes. Returns 32-bit value. In cases 0x07/0x08, the entered value IS both quantity AND total cost (unit price = 1 credit).
- `aC618[0..2]`: 3 item type numbers currently displayed in shop. `bD314` = selection index (0-2).
- `aD374[]`: Per-item-type player quantity array (uint32 stride 4).
- `aD376[]`: Per-item-type player data array (uint16 stride 2).
- `tD370`/`tD372`: 32-bit credits (low/high words).
- Case 0x09: `bD316 != 0` uses alternative price at `w0168`. Calls `fn1631_1FDF` (display only, cost pre-computed from table) + `fn0FDC_13DE` (heal UI).
- Case 0x0B: checks `bD318 == 6` or `== 9` for quantity thresholds. Calls `fn1631_1FDF` + `fn0FDC_15E6` (garage/swap UI).

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

### Mech Data Format (125 bytes per 'Mech, stride 0x7D)
```
Offset  Size  Field                 Description
------  ----  -----                 -----------
+0x00   16    Name                  Mech name (ASCIIZ, null-padded)
+0x10   1     Tonnage               Tonnage (uint8)
+0x11   11    CurrentArmour[11]     Current armour by location
+0x1C   8     CurrentStructure[8]   Current internal structure
+0x24   4     CurrentActuators[4]   Current actuator status
+0x28   1     EngineHeatSinks       Heat sink count
+0x29   10    CurrentAmmo[10]       Current ammo bins
+0x33   1     WalkMove              Walk MP
+0x34   1     JumpMove              Jump MP
+0x35   7     Critical_L_Arm[7]     Left arm criticals
+0x3C   7     Critical_L_Torso[7]   Left torso criticals
+0x43   7     Critical_R_Arm[7]     Right arm criticals
+0x4A   7     Critical_R_Torso[7]   Right torso criticals
+0x51   2     Critical_L_Leg[2]     Left leg criticals
+0x53   2     Critical_R_Leg[2]     Right leg criticals
+0x55   2     Critical_C_Torso[2]   Center torso criticals
+0x57   1     Critical_Head         Head criticals
+0x58   11    MaxArmour[11]         Maximum armour (template)
+0x63   8     MaxStructure[8]       Maximum structure (template)
+0x6B   4     MaxActuators[4]       Maximum actuators (template)
+0x6F   10    MaxAmmo[10]           Maximum ammo (template)
+0x79   4     Unknown[4]            Unknown/padding
```
Note: The `+0x29` ammo field is what combat code at segment `0x2A02` decrements. The overlapping struct-relative offset `+0x07` (code-base `C724+0x27`) serves dual purpose — last AI target preference entry in look-up context, first ammo decrement slot in combat context.

---

## 5. COMBAT SYSTEM (Reverse-Engineered)

### Combat Loop (`ghidra_guess_1000_458C_1458C`)
- Entry function at segment 1000:458C, spans `GeneratedCode13.cs` + `GeneratedCode10.cs` + `GeneratedCode18.cs` + `GeneratedCode19.cs`
- Iterates unit slots 0..0x17 (max 24), indexes split: 0-3 player lance, 4-0xB enemy (infantry burst counters), 0xC-0x17 enemy mechs (story slots 4-7)
- Checks unit status at `ES:[ID*2 + 0x406A]` (0 = dead/inactive)
- Calls Unit State Check (`ghidra_guess_1000_0934_10934`) → returns 0-3 action code (<3 = can act)
- Coordinates at `ES:[ID*2 + 0x4004]` (X) / `ES:[ID*2 + 0x4036]` (Y)
- Cursor at `ES:[0xA44B]` (X) / `ES:[0xA44D]` (Y)
- Combat sub-phase counter at `[BP-0x42]` — increments through phases (0..0xB..0xC), used to select AI target and control phase dispatch

### AI Target Selection (`ghidra_guess_1000_0AB2_10AB2`)
- **Data-driven**: Story state properties at offsets **0x33-0x55** encode a target preference sequence
- Each property byte = `(target_slot_id + 1)` in range 0x10-0x20; bit 7 may be set
- The combat loop stage counter (`[BP-0x42]`) selects which n-th valid target to use
- Validates target at story state offset `(stage_counter + 0x27)` — must be non-zero
- Returns target ID or 0xFF (no valid target → unit cannot act)

### Movement Phase (`unknown_19EF_0971_1A861`)
- Source X/Y → `[0x238]`/`[0x23A]`, Dest X/Y → `[0x23C]`/`[0x23E]`
- DeltaY = SourceY - DestY, DeltaX = DestX - SourceX
- Binary search on slope ratios via `split_1000_A8C6_1A8C6` → 16/32-way angle
- Sets bits 0x8/0x4/0x2/0x1 in DX → final lookup in table at `DS:[0x240]`
- Returns direction ID or -1 (no move)

### Targeting / State Check (`ghidra_guess_1000_0934_10934`)
- Weapon data access: `BX = 0x11 * weaponSlot` reads `DS:[BX+0x2EE4]` range/type table (17-byte stride)
- Calls `ghidra_guess_1000_05C5_105C5` for LoS/range:
  - Coordinate bitfield packing: X = `(val & 0xF00) >> 1 | (val & 0x7F)`, Y = `(val & 0xF000) >> 5 | (val & 0x7F)`
  - Computes absolute deltas, compares with weapon range from table
- Coordinate masking with 0xF7F, 0xF07F for grid/sub-pixel precision

### Line of Sight / Fire Validation (`ghidra_guess_1000_160E_1160E`)
- **Ray-cast algorithm** from attacker position (global cursor at `0xA44B`/`0xA44D`) to target coordinates
- Uses 8-direction movement vectors from DS tables at `0x328A`/`0x329A`/`0x32AA`/`0x32BA`/`0x32CA`
- **Bresenham-style stepping**: tracks diagonal parity and sub-pixel flags for tile index advancement
- **Skill gate check** at each step: tile property at `seg5588->data[index+0x7AD]` compared against threshold `seg558A->t0150` — if tile_prop >= gate, LoS blocked
- Returns 0 (blocked) or non-zero (LoS clear)
- Special case: training dummy (ID 0xD) always targetable in combat

### Critical Hit Propagation — `unknown_19EF_1886_1B776` + `unknown_19EF_11BB_1B0AB`

**NOT a fire/weapon loop.** The 9 body-part pairs are processed as a cellular-automaton grid adjacency propagator:

| Iteration | SI | DI | Label |
|-----------|-----|-----|-------|
| 1 | 0x564 | 0x324 | RA |
| 2 | 0x5A4 | 0x364 | RL |
| 3 | 0x5E4 | 0x3A4 | RT |
| 4 | 0x624 | 0x3E4 | HD |
| 5 | 0x664 | 0x424 | CT |
| 6 | 0x6A4 | 0x464 | LA |
| 7 | 0x6E4 | 0x4A4 | LL |
| 8 | 0x724 | 0x4E4 | LT |
| 9 | 0x764 | 0x524 | CTR |

Per-pair algorithm:
- Reads byte at `[SI]`, compares with neighbors `[SI±1]`, `[SI±8]` (stride 8 → 8-wide grid)
- Writes 4-direction bitmask to `[DI]`: bit 0x8=left, 0x4=down, 0x2=right, 0x1=up
- This is a cellular automaton pattern: dead/undamaged cells propagate their status to adjacent cells

**The game has NO facing/firing arc enforcement.** See TECHNICAL_ANALYSIS.md §7.15 for complete evidence.

### Damage Application (`unknown_19EF_18EF_1B7DF`)
- RNG call for hit location → cursor coords → video memory address conversion
- 13-iteration loop for impact/damage (splash radius?)
- VGA hardware programming (Set/Reset + Bit Mask at 0x3CE) for impact VFX
- Registers damage in unit state arrays

### Mech Destruction / Kill Chain (Fully Mapped — §7.14 of TECHNICAL_ANALYSIS.md)

The destruction sequence is a 4-phase pipeline:

**Phase 1 — Critical Handler `ghidra_guess_1000_0BBB_10BBB` (1000:0BBB):**
- Checks if structure byte at `ES:[0x558E→BX+0xC724]` is already 0 (overkill)
- Rolls 2D6 for ammo explosion: multiplier = `(roll-8)/2+1` for rolls ≥ 8 (range 1-3)
- If `[0x2E38]` ≠ 0 AND multiplier > 0: triggers explosion VFX + "ammo explosion" text, sets `ES:[0x4586]=1`
- **Overkill path** (when byte already 0): marks combat segment slots with bit 7 (0x80 = destroyed) at `0x2A02`, clears actuator nibbles at `0xC748`/`0xC749` for CT (0x1C), Head (0x1E), and offsets 0x21/0x23

**Phase 2 — Post-Damage Processing (GeneratedCode13.cs:5140-5268):**
- If story state properties (0x1F/0x20) zeroed: calls `ghidra_guess_0000_F565_0F565` special handler, clears `ES:[0x4586]`
- If target is combat slot 0 AND frame condition met: **calls `ghidra_guess_0000_EAEE_0EAEE`** which clears the entire 24×24 fog grid (`ES:[0x5542→0x40B4]` = 0) via a double loop
- Zeroes the structure byte, sets `ES:[0x3986]=1` for CT destruction (offsets 0x1C/0x21)
- Calls critical handler a second time for overkill marking

**Phase 3 — Slot Advance:**
- `ghidra_guess_1000_0B32_10B32` returns the next body part offset in the damage traversal sequence

**Phase 4 — Unit Kill Handler `ghidra_guess_0000_EB34_0EB34` (0000:EB34):**
- Called from combat phase dispatch when unit type matches (enemy mech type 2, player type 6, etc.)
- Snapshots AI target preferences (offsets 0x33-0x56) into local buffer
- Checks story state `b0057` (`0xC79B`) for death text variant selection
- Computes death animation parameters, plays explosion VFX
- Displays death message + "destroyed by [weapon]" text
- Marks unit combat slot as `0xFF` at `ES:[0x554A→0x3800+slot]`
- Death animation type controlled by `ES:[0x37FE]` (1/2/8), influenced by `w4FBA`

### RNG (`unknown_19EF_0BC0_1AAB0`)
- 3-byte state at `384B:4FC0-4FC2`, LFSR variant
- Operations: SHR, RCL, RCL, CMC, SBB, SHR, RCR, XOR on state bytes
- Returns random byte in AL per call

### To-Hit Formula (2D6 System)
- **Roll generation** (`ghidra_guess_0000_30DD_030DD` @ segment 0000:30DD): Two D6 (1-6 each) via rejection-sampled RNG (AND 0x7, retry if >5, then INC), summed → range 2-12
- **Base TN** = `action_code * 2 + 4` where action_code from targeting: 1=short(TN6), 2=medium(TN8), 3=long(TN10). Weapon type 0x20 (kick) overrides TN=3
- **Skill modifier**: `ghidra_guess_1000_1554_11554(0x24, unit_id)` returns popcount of low 3 bits cleared (0-3) from story state byte at slot offset 0x24. Same for offset 0x25
- **Terrain modifier**: Tile property at `ES:[unit_id*0x30 + 0x32C6]`, sign-extended +1. Additional modifier from table at `0x2D1A`
- **Heat penalty**: Player units check `ES:[BX+0x6E]`, enemy check `ES:[BX+0x66]`. Thresholds at 8/13/17/24 → +1 each (up to +4)
- **Story state penalty**: +2 if unit's story state byte at `[SI+0xC79B]` != 0 (citadel attacked)
- **Heat generation**: Weapon instance byte `ES:[SI+0x2EE5] & 0x0F` added to `ES:[BX+0x92]` (player) or `0x8A` (enemy) heat pool each shot
- **Heat dissipation** (`ghidra_guess_1000_0673_10673`): At end of each combat round, player heat pool (0x92) is copied to penalty accumulator (0x6E) then reset to zero. Enemy heat pool (0x8A) is never cleared. Penalty capped at 30.
- **UI screen layout**: 320×200 EGA, left panel 80px (location graphic + action menu), right panel 240px (main viewport). `0x50` hardcoded as left panel width across 7+ source files.
- **Global UI mode `w4FBA`**: 4 modes (0=WorldMap, 1=LocalTiles, 2=Text, 3=BuildingName). Checks at 60+ code paths across 8 segments. Set at startup from keys 1-4: raw ASCII (0x31-0x34) stored at pseudocode line 5922, normalized to 0-3 at line 5961 (`-= 0x31`) after protection screen. During main render loop (lines 6110-6132): if w4FBA==0, temporarily toggled to 1 during rendering pass then restored to 0 (render-in-progress toggle). Values 0 and 1 produce same border variant. No BLD opcode or function changes w4FBA to a different mode during gameplay.
- **`w4FBC` viewport flag** (selector `0x53E8`, offset `0x4FBC`): Binary flag (0/1) controlling left-panel width narrowing. When set, left panel shrinks from 80px to 4px. This is the ACTUAL mechanism for combat/building-entry/menu viewport changes — NOT w4FBA. Set during combat start, building entry, action menus. Cleared on combat end, building exit, mode transitions. Verified by r2 (9+ write sites in pseudocode, all toggling between 0x00 and 0x01).
- **`tB764` rendering sub-mode** (seg `0x246C`, offset `0xB764`): Parallels w4FBA but controls font stride/blitter selection. Set by `fn207F_2CE1`. Values: 0=CGA (×2), 1=EGA planar (×4), 2=VGA text (×1 byte), 3=VGA mode X (×8 pixel doubling).
- **Border drawing**: 3 variants dispatched by `fn1F3D_06C3` — full border (`fn207F_1CB8`), narrow text border (`fn207F_1D3A`), text overlay (`fn207F_245C`). Based on w4FBA mode (which is static after startup normalization).
- **World map random encounter system**: Flat probability check every frame at `fn0800_0000` line 195. If `(RNG() & bD330) == 0` AND `bD310 != 0` (world map active) AND `bD346 == 0` (not star map), calls `fn183B_000A(0)` to initialize combat encounter. Probability mask `bD330` set to `0x1F` (1/32 frames) by `fn11B8_0D58` (room handler, segment 11B8) when `bD332==0 && (RNG&1)` triggers; reduced to `0x7F` (1/128) after a unit dies in combat. Cooldown timer `bD335` (0x3F=63 frames) prevents immediate re-encounter. Timer cascade at lines 167-227: `bD335` (movement cooldown), `bD343`-`bD345` (compound, citadel attack trigger at position 0x0800-0x0D00 × 0x6000-0xB000), `bD329`/`bD320`-`bD322` (generic decrement), `bD323` (economy ticker → stock update).

**NO dynamic balancing**: The enemy mech pool for random encounters is **3 fixed templates** (light mechs, likely Locust/Wasp/Stinger at 20t each), selected via `RNG % 3` from a read-only table at segment `[DS:0x5436]:0x2DF8`. Enemy infantry (slots 8-15) gets random equipment from a 4-option table via `RNG & 0x03`. There is NO code that reads the player's lance to calibrate enemy spawns. Heavier units (Jenner 35t, Chameleon 50t) are story-only and never appear in random encounters. See `fn0DAB_0D3D` in `UNBTECH_0DAB.c:972-1105`.
- **Main game loop (`fn0800_0000`)**: 6-phase architecture — Input → Key Dispatch → Timer → Economy → Animation+Render+Border → BLD. Runs while `w0152==0`. Screen refresh driven by `w014A` flag.
- **Rendering pipeline**: 3-pass compositing — Pass 1 = right panel content (`fn207F_18EF`, 13×12 tile grid centered on cursor), Pass 2 = left panel border (`fn1F3D_06C3`), Pass 3 = menu/text overlay (`fn1E56_03F5` in BLD phase).
- **Viewport system**: `fn207F_24D7` blitter handles planar EGA framebuffer. Case 0x00 clips to 80px left panel width. Case 0x02 clips to 40-column text width.
- **Animation system (seg135D)**: Tile-animation dispatch for left-panel/animated tiles. NOT called on building entry — triggered from arrow key handler (`fn0800_218F` → `fn0800_1C12`) when cursor moves over tiles with `+0x7AD` property values `0x7E`/`0x7F`/`0x80` and `bD346==0`.
- **`fn135D_0AB6` (animation dispatch, linear `0xD786`)**: Searches a 12-entry table at `DGROUP:0x247A` for a match against `(arg2 & 0x7E)` (Field0, X coordinate even part) and `arg3` (Field2, Y coordinate). On match, returns `Field4-1`, `Field6-1`, `Field8-1` as animation frame/page parameters. When `wArg08 >= 0`, accesses table entry directly by index instead of searching. Table layout (5 × 12 bytes, offset from DGROUP base):
  - `0x247A`: Field0 (12 bytes, X-coordinate even parts, matched as `arg2 & 0x7E`)
  - `0x2486`: Field2 (12 bytes, Y-coordinates, matched directly against `arg3`)
  - `0x2492`: Field4 (12 bytes, animation parameter 1)
  - `0x249E`: Field6 (12 bytes, animation parameter 2)
  - `0x24AA`: Field8 (12 bytes, animation parameter 3)
- **Dispatch table population**: Table memory at `DGROUP:0x247A` is dynamically written at runtime and overlaid with other data structures (shared memory region). Contents change based on game mode/map context. `fn135D_0004` iterates entries 0-10 and processes active animations. The EXE image does not contain table-initializer data, confirming runtime population.
- **`fn135D_0004` (init function)**: Called during game/building initialization. Saves story slot data, clears equipment slots, sets up rendering context (viewport cursor at `0x0C06:0xC07E`), loads tile data, draws border, then calls `fn0FDC_0008(0x17)` to load BLD file 23. After BLD load, iterates dispatch entries 0-10: for each entry where flag at `[DGROUP:0x54FA segment + entry + 0xD34F]` is non-zero, calls `fn135D_0AB6(wArg04=0, wArg06=0, wArg08=entry_index)` to process animation.
- **`fn135D_01E9` / `fn135D_0913` / `fn135D_0980` / `fn135D_03AA` / `fn135D_0288` / `fn135D_02A8` / `fn135D_04AB` / `fn135D_02D2` / `fn135D_055A`**: Other segment 135D functions handling different tile property values (0x94 for `fn135D_079C`, 0x8C/0x8D for `fn135D_0980`, 0xB6/0xB7 for `fn135D_03AA`, 0xF5 for `fn135D_01E9`, ≥0xF6 for `fn135D_0288`, 131/0xA5-0xA7 for `fn135D_02A8`, 77 for `fn135D_04AB`, 0x3A/0x3D for `fn135D_02D2`, 0x28 for `fn135D_055A`) — dispatched from `fn0800_1C12` based on tile property at `+0x7AD[tile_index]`.
- **EGA planar layout**: 4 bit-planes, 40 bytes/plane/scanline, odd/even row interleaving with 0x2000 plane stride, row-pair stride 0x50 (80 bytes).
- **Ammo**: Weapon instance byte `ES:[SI+0x2EE4]` (stride 0x11, read-only during combat) — bit 7 = infinite ammo flag; low 7 bits = initial remaining shots. Out-of-ammo check when count <= 1. **Actual decrement** on mech struct ammo bins at offset `+0x29` (struct-relative, code-base `C724+0x27`) in combat segment `0x2A02`: players (combat units 0-3, story slots 0-3) `DEC [0x2A02:C74B + unit_id*125 + stage_counter]`, enemy mechs (combat units 12-15, story slots 4-7) `DEC [0x2A02:C363 + unit_id*125 + stage_counter]`, where stage_counter = [BP-0x42] (0..0xA). Enemies (units 4-11) use burst counter `INC [0x2A02:C5D4 + unit_id*0x11]` capped at 4. 0xFF sentinel = empty slot.
- **Combat fog of war**: Twin 12×24 grids at `DS:[0x55D8]→0x40B4` (Grid A) / `0x41D4` (Grid B), each 288 bytes. Init `0x02`=fogged. `0x00`=clear. Set by `fn183B_000A` in 12×24 double loop. Per-unit fog column reset on unit death. Movement-based fog clearing in `fn183B_193B`: resets unit's row to 0x02, then `fn1631_0006` steps along movement path, clearing cells. Fog check at `GridA[unit*0x18] == 0x02` — still-fogged units rendered (fog overlay masks).
- **fn1631_0006 (LoS stepping)**: Core pathfinding tile-step. Uses 8-direction delta tables at `0x311A`-`0x313A`. Skill gate: if tile property at `+0x7AD[tile_index] >= t0150` (seg 0x558A), tile is blocking. Also checks neighbor tile for edge cases. Writes X/Y deltas to `t458E`/`t4590`.
- **Two tile property tables**:
  - `+0x7AD` (seg 0x246C, 1 byte/tile): LoS blocking, terrain visibility check, movement cost factor. Read in `fn207F_18EF` for tile rendering, `fn1631_0006` for LoS stepping.
  - `0x32C6` (seg 0x55DC, stride 0x30): Movement cost/terrain modifier (0xFF=impassable), packed X/Y coords. Read for terrain TN modifier: `TN += sign_extend(property) + 1`.
- **fn0800_051B (main unit processing)**: Called from main loop, 5 phases: (1) Player units slots 0-7 — compute visibility from tile property, store to `0x32B2[unit_id]`; (2) NPC units slots 16-23 — same pattern; (3) Story slots 0-3 — mech visibility (`0x08`/`0x10` values) stored to `0x32AE[unit_id]`; (4) Position array updates (`0x4004`, `0x4036`, `0x406A`); (5) World map mech rendering (when `w398E != 0`) at hardcoded cursor offsets.
- **SPACE menu (fn0800_2C50)**: 7-option menu dispatched from main loop. 1=fn0800_3BD0 (party/equip), 2=fn0800_378D (tech), 3=fn1431_000A (star map?), 4=fn0800_32B3 (enter building?), 5=fn0800_35D3 (stock market), 6=fn0800_3D40 (stat/inventory screen — interactive modal with own input loop via fn0800_3FAE), 7=fn0800_4D57 (special). After handler returns: `fn1F3D_06C3` redraws border. `fn0800_2A93` is NOT part of this chain — it is the world map tile renderer called from `fn0800_051B`.
- **fn1E56_0D1D**: Confirmed a pure scancode remapper (WASD→arrows, numpad→diagonals) with NO side effects on w4FBA. Called from main loop key dispatch phase.
- **Hit**: 2D6 roll >= TN → hit. Roll < TN → miss
- Confirmed: Segment 0000:30DD in `GeneratedCode1.cs`, comparison at `GeneratedCode13.cs:4697-4708`

### Skill Modifier Function (`ghidra_guess_1000_1554_11555`)
- Story state property `0x24`: byte at `0xC724 + unit_id * 0x7D + 0x24`, popcount of low 3 bits cleared → 0-3
- Story state property `0x25`: same pattern → 0-3
- Combined range 0-6 added to target number

### Weapon Data (33 weapons defined)
Types: Cludgel, Knife, Sword, Vibroblade, Shortbow, Longbow, Crossbow, Pistol, Rifle, MachineGun, SRMissile, Inferno, LaserPistol, LaserRifle, Flamer, Small/Medium/Large Laser, PPC, AC/2/5/10/20, LRM5/10/15/20, SRM2/4/6, Kick
Fields per weapon (17 bytes): Name(10), Damage, Shots?, Heat, SoundEffect?, Range(16-bit), Skill
- **Cluster weapons** (LRM/SRM): fires as single salvo. Weapon instance byte at `0x2EE3` = per-missile damage (LRM=1, SRM=2). Low 7 bits of `0x2EE4` = cluster table column index. 2D6 roll × 7 + column → cluster hits table at `DS:[0x566C]→0x2E5E` → total damage = per-missile × hits.

### Known 'Mech Definitions (mech ID at offset 0x7B in 125-byte struct)
| ID | Name | Tonnage | Walk | Jump | Armament | Notes |
|----|------|---------|------|------|----------|-------|
| 0x00 | LOCUST | 20t | 8 | 0 | 2×MG RA/LA, ML CT | Random encounter pool |
| 0x01 | WASP | 20t | 6 | 6 | ML RA, SRM2 | Random encounter pool |
| 0x02 | STINGER | 20t | 6 | 6 | MG + ML | Random encounter pool |
| 0x03 | COMMANDO | 25t | 6 | 0 | ML + SRM4/6 | Random encounter pool |
| 0x06 | URBANMECH | 30t | 2 | 2 | AC/10, SL | Story encounter only |
| 0x09 | JENNER | 35t | 7 | 5 | 4×ML, SRM4 | Story-only (Kuritan) |
| 0xC8 | CHAMELEON | 50t | 6 | 6 | LL, ML, SL, MG | Player's starting mech, story-only |
| — | Spectator | 20t | — | — | — | Decoy/non-combatant, not in EXE binary |

---

## 6. WORLD MAP SYSTEM

The game has **two distinct map layers**: the **overworld map** (Pacifica island) and **local maps** (indoor/city areas).

### 6a. Overworld Map (Pacifica)

- **Grid**: 64×64 tiles (4096 bytes at `0x246C:0x244B`), 1 byte per tile, each indexing MAP.ICN tileset.
- **Terrain**: Hand-crafted template of Pacifica island (~17.7% water, ~49.5% land, ~26.4% urban, ~6.4% roads).
- **Source**: Data is **embedded in the EXE** at the tile buffer address — no separate world map file exists. The EXE pre-initializes 76 unique tile values forming the base terrain; at runtime ~82% are modified by game state.
- **Dynamic modifications**: Visibility (128×128 bit-packed grid), story progression (e.g., Citadel destruction swaps tiles), encounter placement writes to viewport arrays.
- **Identified POIs**: Training Center/Citadel at ~(26,5), Main City at ~(28,10), large southern city at ~(33,49), island cache at ~(55,8), plus 8+ other settlements.
- **Visibility**: 128×128 bit-packed grid (2048 bytes at `DS:[0x538Ah]→0xCB0C`, also persisted in save games at `0x3092:0x04F9`). Each world map tile (64×64) has 2×2 visibility bits.
- **Render flow**: `fn0800_48B7` clears and sets up the tile buffer → `fn0800_1AFD` copies source template from `0x246C:0x42F6` → game state overrides → `fn0800_051B` calls `fn0800_2A93` to render an 8×8 tile viewport on screen.
- **Tileset**: MAP.ICN (~94 tiles). Tile IDs 0-93 index directly into this tileset; values > 93 may load from ANIMATE.ICN, BTTLTECH.ICN, or palette variants.

### 6b. Local Maps (MAP1-15.MTP)

These are separate files for city interiors, special areas, and the star map. They are loaded when entering a location from the overworld.

| File | Location | Format | Notes |
|------|----------|--------|-------|
| MAP1.MTP | Training Center / Citadel | BlockFormat | Player start |
| MAP2.MTP | Main City | BlockFormat | Chameleon training, Arena |
| MAP3.MTP | Small outpost/village | LinearFormat | |
| MAP4.MTP | Large industrial city | LinearFormat | |
| MAP5-8.MTP | Medium settlements | LinearFormat | |
| MAP9.MTP | Outpost | LinearFormat | |
| MAP10.MTP | Medium settlement | LinearFormat | |
| MAP11.MTP | Destroyed Training Center | BlockFormat | Post-attack state |
| MAP12.MTP | Large city/base | BlockFormat | |
| MAP13.MTP | Medium settlement | BlockFormat | |
| MAP14.MTP | Cave / Underground complex | BlockFormat | |
| MAP15.MTP | Star Map | LinearFormat | 32×24 special format |

### 6c. World Map Coordinate System

```
Tile X = (wA44B & 0x7F) >> 1   → 0-63
Tile Y = (wA44D & 0x7F) >> 1   → 0-63
Tile index = Y * 64 + X         → offset in tile buffer
```

Save game coordinates at offsets `0x0F45`/`0x0F47` encode sub-tile position in the low 7 bits.

### 6d. Key World Map Functions

| Function | Address | Role |
|----------|---------|------|
| `fn0800_2A93` | `0800:2A93` | World map tile renderer — reads 64 tiles, positions on screen |
| `fn0800_48B7` | `0800:48B7` | State machine init — clears tile buffer, sets up source pointers |
| `fn0800_1AFD` | `0800:1AFD` | Copies tile data from source (`0x246C:0x42F6`) to display buffer |
| `fn0800_051B` | `0800:051B` | Main unit processing — calls tile renderer, initializes unit data |
| `fn183B_27C9` | `183B:27C9` | Writes encounter placement to viewport arrays |
| `fn207F:28EB` | `207F:28EB` | Tile blit to framebuffer |
| `fn207F:23EC` | `207F:23EC` | Block memory copy (used by fn0800_1AFD) |

---

## 7. RENDERING & GRAPHICS PIPELINE

- **Resolution**: 320x200 (standard DOS VGA/EGA Mode 13h-like)
- **Palette**: 16-color EGA (with per-asset swaps for title/Infocom/endgame screens)
- **EGA planar**: 4 bit-planes per pixel (Blue=0, Green=1, Red=2, Intensity=3)
- **Decompression path**: CMP/ICN → RLE decompress (Format01/02) → nibble-to-pixel → planar convert → bitmap
- **Sprite extraction**: From MECHSHAP.CMP (sub-rectangle coordinates in 8-pixel tile units)
- **Map rendering**: 16x16 tiles from tile sets, drawn to 320-wide bitmap
- **Animation**: XOR-based delta frames via EGA animation bit-shifting (4 left-shift-and-rotate operations per pixel)

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

## 9. GODOT 4 + C# ENGINE REBUILD

The old Java/Swing prototype has been **deleted** — it was a hardcoded dead end. The official rebuild is in `BattleTechCHI/`, a Godot 4 C# project.

**File structure:**
```
BattleTechCHI/
├── project.godot              # Godot 4 config, 320x200 viewport
├── BattleTechCHI.csproj       # .NET 8.0
├── BattleTechCHI.sln
├── .gitignore
├── Assets/                    # (empty — linked from parent Assets/) 
├── Data/                      # BLD JSON pre-converted
├── Scripts/
│   ├── Main.cs                # Entry: Node2D → GameLoop
│   ├── Core/
│   │   ├── GameLoop.cs        # Init → input → update → render, coordina tutti i subsystems
│   │   ├── StateManager.cs     # w4FBA mode, 3-layer state machine
│   │   ├── InputHandler.cs     # WASD/frecce, SPACE, F1-F10, 1-4
│   │   └── SaveManager.cs      # Save/Load formato GAME1-6
│   ├── Data/
│   │   ├── GameEnums.cs        # GameMode, MapFormat, BldOpcode, NarrativeMode
│   │   ├── GameState.cs        # Stato globale + StorySlot
│   │   ├── DataModels.cs       # BldScript, MapData, MechDef, WeaponSlot
│   │   ├── WeaponData.cs       # 33 armi tabellate
│   │   └── CipherDecoder.cs    # Traduzione cipher BLD → testo
│   ├── Maps/
│   │   ├── MapLoader.cs        # Carica .MTP (BlockFormat/LinearFormat)
│   │   ├── RleDecompressor.cs  # Decompressione .CMP/.ICN/.ANM (Format 01/02)
│   │   ├── TileManager.cs      # Carica tileset BMP, fornisce texture per tile ID
│   │   ├── WorldMapData.cs     # Dati world map 64×64, visibilità 128×128, POI
│   │   ├── WorldMapView.cs     # TileMap viewport 8×8 con fog of war
│   │   └── LocalMapView.cs     # TileMap viewport per MAP1-14.MTP
│   ├── BLD/
│   │   └── BldLoader.cs        # Carica e decripta .BLD
│   ├── Combat/
│   │   ├── CombatManager.cs    # Loop 12-fasi: movimento, to-hit, danno, kill chain
│   │   ├── CombatView.cs       # TileMap 15×12 + sprite2D unità (ricreati ogni frame)
│   │   ├── CombatHUD.cs        # Overlay sinistro 80px in combattimento
│   │   ├── CombatState.cs      # Stato combattimento, griglie fog 12×24
│   │   ├── CombatResolver.cs   # RNG (LFSR 24-bit), LoS (Bresenham), danno
│   │   └── CombatTypes.cs      # MechState, HitLocation, ActionCode enum
│   ├── BLD/
│   │   └── BldLoader.cs        # Carica e decripta .BLD
│   └── UI/
│       ├── EgaPalette.cs       # Palette EGA 16 colori + custom asset
│       ├── AnmPlayer.cs        # Player animazioni ANM (88×88, timer-based, FPS configurabile)
│       ├── BorderPanel.cs      # Pannello sinistro 80px + bordo EGA + AnmPlayer
│       ├── StartupSequence.cs  # INFOCOM → BTTITLE → gioco
│       ├── DialogueBox.cs      # Testo BLD, sprite, menu interattivo
│       └── ShopScreen.cs       # Interfaccia compra/vendita
├── Scenes/
│   └── Main.tscn
├── Assets/
│   └── Animations/             # Spritesheet ANM O0–O16 (88×88 px, 321 PNG, 1.4MB)
└── docs/
    └── reference/
        └── ANM_FORMAT.md       # Specifica formato ANM (XOR-delta RLE)
```

**Status**: Phase 5 in progress (~7,800 lines C#). Phases 0-4 done: core systems, tile rendering, world/local maps, BLD interpreter (26 opcodes) + 47-case dispatcher, shops/dialogue, full combat system. Phase 5 shipped: AnmPlayer, ViewportManager, BldAnmMap, runtime ANM decompress, animation dispatch on hover. Remaining: stock market, tech screen, combat mech panel ANM, end-to-end playtesting.

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

### House Kurita — In-Game Depiction

The full decoded story reveals details about Kurita's role beyond the basic invasion:

- **Joint Marik-Kurita operation**: The invasion involves both Houses. House Marik agents infiltrated the Citadel and held Katrina hostage, while Kurita forces provided the military assault. NPCs shout "Marik and Kurita invaders!" — suggesting a coordinated strike.
- **Occupation government**: Kurita establishes a puppet government on Pacifica with an inauguration ceremony. A Kurita ambassador speaks at the podium. Posters across the city proclaim the new Kuritan government.
- **Kuritan double agents**: Rex warns that some Crescent Hawk agents may actually be Kuritan double agents. A specific guard at the jail is revealed to have been a Kuritan agent assigned after the assassination attempt on Jason at the training center.
- **Kuritan collaborator**: The weapon shopkeeper collaborates with the occupation forces.
- **Kuritan jail**: The Pacifica Internment Center is staffed by Kuritan guards. A Kuritan soldier is assigned there after the assassination attempt.
- **Code of honor**: The ending reveals that Kurita's code of honor and ritual may have led the Draconians to capture (rather than kill) the Kell Hounds, holding a trial instead — suggesting Jeremiah may still be alive.
- **Mechs**: The Kuritans field Jenner Mechs (confirmed in text). Other Kuritan military assets include standard infantry and battle armor.

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
- **Shop/inventory data structures** → `aC618[0..2]` (3 shop item slots), `aD374[]` (per-item-type player qty, ui32 stride 4), `aD376[]` (per-item-type data, word16 stride 2), `tD370`/`tD372` (32-bit credits). Documented at TECHNICAL_ANALYSIS.md §17.11.
- **Story arc progression** → 7 phases: NewGame→Training→CitadelAttack→FreeRoam→EventTriggers→MultiStep→Endgame
- **Map→BLD event mapping** → BLD index determined by tile properties at 0x32C6 + translation table at segment `[0x5460]:0x4602` (16-byte table loaded from MTP header, maps tile property→BLD file index)
- **Screen layout mapped**: 320×200 EGA. Left panel = **80px** (`0x50` constant, confirmed by `fn207F_24D7` clipping to `0x50`), right panel = 240px.
- **Global UI mode `w4FBA`** (seg `0x569E`+0x00FD): 4 modes — 0=WorldMap, 1=LocalTiles, 2=Text, 3=BuildingName. Modes 4-6 do not exist. Checked at 60+ code paths across 8 segments. Set at startup from keys 1-4: raw ASCII (0x31-0x34) stored at pseudocode line 5922, normalized to 0-3 at line 5961 (`-= 0x31`) after protection screen. During main render loop (lines 6110-6132): if w4FBA==0, temporarily toggled to 1 during rendering then restored to 0. Values 0 and 1 produce same border variant. No BLD opcode or function changes w4FBA to a different mode during gameplay.
- **`w4FBC` viewport flag** (selector `0x53E8`, offset `0x4FBC`): Binary flag (0/1) for left-panel width narrowing (80px→4px). The actual mechanism for combat, building, and menu viewport changes. Set/cleared across 9+ pseudocode sites.
- **`tB764` rendering sub-mode** (seg `0x246C`, offset `0xB764`): Font stride/blitter selection. 0=CGA, 1=EGA planar, 2=VGA text, 3=VGA mode X. Set by `fn207F_2CE1`.
- **Border system**: 3 variants dispatched by `fn1F3D_06C3()`. Full border (`fn207F_1CB8`) for w4FBA 0/1; narrow text border (`fn207F_1D3A`, 27 word writes per row) for w4FBA 2; text overlay (`fn207F_245C`, wrapper calling `fn207F_24D7`) for w4FBA 3.
- **Main game loop (`fn0800_0000`)**: 6-phase architecture — Input → Key Dispatch → Timer → Economy → Animation+Render → BLD. Runs while `w0152==0`. Screen refresh driven by `w014A` flag.
- **Rendering pipeline**: 3-pass compositing. Pass 1 = right panel via `fn207F_18EF` (13×12 tile grid centered on cursor). Pass 2 = left panel border via `fn1F3D_06C3`. Pass 3 = text overlay via `fn1E56_03F5`.
- **EGA planar framebuffer**: 4 bit-planes, 40 bytes/plane/scanline. Odd/even row interleaving with `0x2000` plane stride. Row-pair stride = 80 bytes (`0x50`). `fn207F_24D7` has 4 cases: 0x00 (80px left, planar interleave), 0x02 (40px text, linear), 0x01 (160px, 4-way planar), default (320px full, linear).
- **`tB764` pixel format flag**: At seg 246C. 0x00=CGA (0xB800), 0x02=VGA text (0xAC00), 0x03=VGA mode X (0xA000, stride 0x0A00), default=EGA planar (0xA000).
- **Tile animation**: `fn0800_240B` implements 3-frame page swap via `w5800` counter (0→1→2→0). Source offset = `(w5800 << 7) + 54658`. Copies 4100 tiles × 128 bytes each frame via `fn207F_28A8`. Guarded by `w3988` flag. `fn0800_24C2` handles unit position updates on every 3rd frame.
- **NPC world-map movement engine (`fn0800_24C2`)**: 8 story NPCs with waypoint-based wandering. Per-NPC movement delay timer `bD399[slot]` counts down each frame. On arrival at waypoint, picks random direction via `RNG() & 0x1F`, looks up new destination from table `0x4564`/`0x57D6`. Step-toward uses `fn0800_191B` + `fn1631_0006` (LoS tile-step). Direction/state packed nibble in `0xD398[slot]`. See TECHNICAL_ANALYSIS.md §18.
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
- **Mech/Unit inventory system**: Two-tier (story slots aC724→unit slots aC614). 4 characters × 2 mechs each = 8 owned units. Garage/swap UI at `fn0FDC_15E6`. See TECHNICAL_ANALYSIS.md §17.10.
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

1. **Complete function labeling**: Map all ~1400 Ghidra/Reko functions to game actions using Spice86 trace data
2. **Full memory map**: Cross-reference Spice86 dumps with Reko struct definitions to build complete variable map
3. **Animation format**: Fully document the .ANM XOR-delta format and EGA animation bit-shift algorithm
4. **AI logic**: Trace AI decision trees in combat (target selection, movement priorities)
5. ~~**Sound**: Investigate SoundBlaster/PC Speaker interrupt handler at segment 204B~~ **WONT_DO**: Not needed for reconstruction — replaceable with modern sounds
6. **HEAT DISSIPATION** → **RESOLVED**: Pool → penalty accumulator → cleared each round. See TECHNICAL_ANALYSIS.md §16.
3. ~~**Data-driven recreation**~~ **IN PROGRESS**: Godot 4 + C# engine. Phases 0-4 done (core, maps, BLD interpreter, combat). Phase 5: economy + ANM. Next: stock market, combat ANM panel, end-to-end playtest.
4. ~~**World Map unknown origin**~~ **RESOLVED**: 64×64 tile grid embedded in EXE at `0x246C:0x244B`. See Section 6.
5. ~~**Phase 2 (tile rendering)**~~ **DONE**: WorldMapView, LocalMapView, TileManager, WorldMapData, BorderPanel, ViewportManager.
6. **Play through and trace**: Use Spice86 with targeted breakpoints to map story progression for all missions
7. ~~**fn183B_28DB analysis**~~ **RESOLVED**: Enemies at random offsets from (26,12).
8. ~~**AI stage counter phase dispatch**~~ **RESOLVED**: Counter 0-11 selects nth target.
9. ~~**Facing / firing arcs**~~ **RESOLVED**: No arc enforcement.
10. **Item-to-unit ammo bridge**: How `aD374` connects to ammo bins.
11. **fn1CD3_0004 case 0x05 C618[bD314]++ anomaly**: Packed type vs count.
12. ~~**Screen composition pipeline**~~ **RESOLVED**: 3-pass compositing.
13. ~~**Tile buffer layout**~~ **RESOLVED**: 64×64 world map tile buffer.
14. ~~**Segment 135D animation dispatch**~~ **RESOLVED**. .ANM→dispatch mapping still pending.
15. **w3988 animation guard flag**: What sets it?
16. ~~**Combat/stat screen layout**~~ **RESOLVED**.
17. ~~**BLD shop `e7` block merge**~~ **RESOLVED**.
18. ~~**w4FBA mode transitions**~~ **RESOLVED**.
19. ~~**fn0800_051B phases**~~ **RESOLVED**.
20. ~~**Two tile property tables**~~ **RESOLVED**.
21. ~~**fn1E56_0D1D**~~ **RESOLVED**.
22. ~~**BLD bytecode 0xC0 prefix semantics**~~ **RESOLVED**.
23. ~~**World Map data source**~~ **RESOLVED**.
