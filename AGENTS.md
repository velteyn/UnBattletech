# Agent Instructions — BattleTech CHI Rebuild

## Build & Run

```bash
# Build C# (fast, catches compile errors)
cd BattleTechCHI && dotnet build

# Build + Run Godot editor (headless via xvfb)
cd BattleTechCHI && bash run.sh

# Build only (via script)
cd BattleTechCHI && bash build.sh
```

## Godot Binary

Installed at `~/.local/bin/godot`. The Mono (C#) version requires a display
server — use `xvfb-run` on headless systems.

Project uses Godot 4.4 (.NET SDK 4.4.0, net8.0).

## Architecture

- **Core/** — GameLoop, StateManager, InputHandler, SaveManager
- **Data/** — GameEnums, GameState, DataModels, WeaponData, CipherDecoder
- **Maps/** — MapLoader, RleDecompressor, TileManager, WorldMapData, WorldMapView, LocalMapView
- **BLD/** — BldLoader, BldInterpreter, Fn1CD3Dispatcher
- **UI/** — EgaPalette, BorderPanel, StartupSequence, ShopScreen
- **Runner/** — Standalone test console app (not part of Godot build)

## Phase 4 Combat System (Implemented)

Combat lives in `BattleTechCHI/Scripts/Combat/` — 5 files, fully reworked from stubs:

### Files
- **CombatTypes.cs**: `MechState` (class with full 11-location armour/structure arrays, 10 ammo bins, heat, crits), `HitLocation` enum (11 body parts), `AmmoBin` struct, `ActionCode`/`CombatPhase`/`Direction8` enums
- **CombatState.cs**: Twin 12×24 fog grids, 24 unit slots, phase tracking, kill chain state. Methods: `InitFogGrids()`, `ClearFogForUnit()`, `ResetFogForUnit()`, `KillUnit()`, `AnyEnemiesAlive()`
- **CombatManager.cs**: Main loop — 12-phase state machine (Init→UnitLoop→Movement→Targeting→ToHit→Fire→PostFire→HeatDissipation→Complete). Maps to `ghidra_guess_1000_458C_1458C`. Features:
  - Movement: approach toward target if out of weapon range, 1 tile/tick, collision + bounds check, fog clearing on move
  - To-hit: full 2D6 formula (skill popcount + terrain + heat thresholds + story state penalty)
  - Damage: hit location table, armour→structure flow, critical hits, ammo decrement, kill chain
  - Cluster weapons: LRM/SRM per-missile damage via cluster hits table
  - Combat end: story state update, encounter rate reduction, world map restore
- **CombatResolver.cs**: RNG (24-bit LFSR), LoS (Bresenham ray-cast), to-hit computation, heat dissipation (pool→penalty→clear), hit location (front table via `RNG & 0x0A`), criticals (2D6≥8), ammo explosion, kill chain
- **AiController.cs**: AI targeting from story state properties (offsets 0x33-0x55), action code by distance (short≤3/medium≤6/long≤10), weapon selection by best range+damage with ammo check

### Key Combat Flows
1. **Entry**: BLD `SHOP_DISPATCH 0x2D` → `Fn1CD3Dispatcher.CombatEncounter()` → `GameMode.Combat` → `GameLoop.StartCombatEncounter()` → `CombatManager.StartCombat()`
2. **Round**: UnitLoop(0..23) → Movement → LoS check → ToHit(2D6) → Fire(damage) → next unit → HeatDissipation → stageCounter++ → next round
3. **End**: All enemies dead → victory → story state update → world map; stageCounter>20 → draw

## Fn1CD3Dispatcher Case Mapping (ALL 47 CASES IMPLEMENTED, verified vs decompiled C)

| Case | Name | Description |
|------|------|-------------|
| 0x01 | ENTER_BUILDING | Emits `BuildingEntered` event, sets up viewport |
| 0x02 | SHOW_GREETING | Entry text displayed via BLD text opcodes |
| 0x03 | EXIT_BUILDING | → WorldMap |
| 0x04 | SHOW_SHOP_ITEMS | Populate C618 slots (StateArray 0x18-0x1A) from shop strategy |
| 0x05 | BUY_ITEM_SINGLE | C618[sel]++ (price = old_type * 125 + 75), rotate to next type |
| 0x06 | SHOW_PLAYER_ITEMS | Find owned items, populate C618[0..2] for sale UI |
| 0x07 | BUY_ITEM_BULK | Buy via strategy (GetBuyPrice) |
| 0x08 | SELL_ITEM_BULK | Sell via strategy (GetSellPrice) |
| 0x09 | HOSPITAL_HEAL | Heal 4 units, cost 50cr |
| 0x0A | SHOW_CREDITS | Emits `CreditsDisplayed` event with credit balance |
| 0x0B | BUY_WITH_UNIT_SEL | Buy + select unit slot (bD31A) |
| 0x0C | CLOSE_ACTION | Returns null (no mode change) — BLD script continues |
| 0x0D | EQUIPMENT_MENU | Reset bD31A to 0 |
| 0x0E | COUNT_UNIT_SLOTS | Count active units → bD31A |
| 0x0F | EQUIP_SLOT5 | 500cr → equip slot 5 |
| 0x10 | CHECK_EQUIP_SLOT5 | Reads UnitSlots[bD31A].DerivedAttr & 0x01 → bD31B |
| 0x11 | COUNT_STORY_SLOTS | Count occupied story slots → bD31C |
| 0x12 | DISPATCH_11B8_0002 | Emits `RenderingRequested("11B8_0002")` for viewport |
| 0x13 | DISPATCH_11B8_080A | Emits `RenderingRequested("11B8_080A")` for name overlay |
| 0x14 | DISPATCH_11B8_0925 | Emits `RenderingRequested("11B8_0925")` for text overlay |
| 0x15 | EQUIP_SLOT6 | 500cr → equip slot 6 |
| 0x16 | CHECK_EQUIP_SLOT6 | Reads UnitSlots[bD31A].DerivedAttr & 0x02 → bD31B |
| 0x17 | EQUIP_CONSISTENCY | Verifies Attr1*10 == DerivedAttr for all slots; sets bD325=1 on mismatch |
| 0x18 | GARAGE_SERVICE | 100cr service |
| 0x19 | FLAG_D450 | TrainingComplete = true, StateArray[0x50] = 1 |
| 0x1A | FLAG_D451 | Milestone = true, StateArray[0x51] = 1 |
| 0x1B | GOTO_2E_SHARED | Shared path with 0x2E (RestoreSlots): bD55E = 0 |
| 0x1C | CLEAR_ALL_SLOTS | Clear 16 story slots (StatusByte = 0xFF) |
| 0x1D | COUNT_UPPERCASE | Count story slots with StatusByte < 0x80 → bD31C |
| 0x1E | DISPATCH_11B8_104E | Emits `RenderingRequested("11B8_104E")` for building interior |
| 0x1F | READ_SLOT_FLAG | Reads UnitSlots[bD31A].LinkedStorySlot → bD32B |
| 0x20 | COMPLEX_EQUIP | Multi-step equip: 500cr, set bD31A = success/fail |
| 0x21 | DISPATCH_0FDC_1C9B | Emits `RenderingRequested("0FDC_1C9B")` for room interaction |
| 0x22 | DISPATCH_0FDC_1A26 | Emits `RenderingRequested("0FDC_1A26")` for room interaction |
| 0x23 | NEW_GAME_INIT | Full game init: 1500cr, clear state, clear inventory |
| 0x24 | READ_UNIT_SLOT | Read UnitSlots[bD331].TypeId for display |
| 0x25 | CLEAR_UNIT_SLOT | Clear first unit slot |
| 0x26 | READ_D456 | Print UnitIdCounter value |
| 0x27 | TRIGGER_ACTION | Emits `ActionTriggered` event (mode trigger 0x01) |
| 0x28 | DISPATCH_11B8_152F | Emits `RenderingRequested("11B8_152F")`, sets bD334=1 |
| 0x29 | COMBAT_HEAL | Heal 4 party members |
| 0x2A | SAVE_POSITIONS | Emits `SaveRequested` event |
| 0x2B | RESTORE_POSITIONS | Emits `RestoreRequested` event |
| 0x2C | DISPATCH_11B8_1762 | Emits `RenderingRequested("11B8_1762")` for position/state |
| 0x2D | COMBAT_ENCOUNTER | → Combat |
| 0x2E | RESTORE_SLOTS | Restore story slots, bD55E = 0 |
| 0x2F | DECREMENT_STATE | StateArray[0x23] -= 4 if > 5 |

All 47 cases have real (non-stub) implementations as of 2026-06-14.
Previously 21 cases were log-only stubs — now they emit events, read actual
state, or perform their documented operations. Six static events on
`Fn1CD3Dispatcher` (`BuildingEntered`, `CreditsDisplayed`,
`RenderingRequested`, `ActionTriggered`, `SaveRequested`,
`RestoreRequested`) let GameLoop react to dispatcher actions.

**Critical**: Cases 0x0A-0x2F were previously misassigned by 2+ positions
(starting at 0x0A = RepairMech when it should be ShowCredits). Fixed in
session 2026-06-08.

## BLD Format Notes

### File Layout

```
0x00-0x07: Header (8 bytes)
  [0] file_type  [1] paragraph_count  [2-5] signature (ee c6 eb ea)  [6-7] content_type
0x08-0x9F: Raw (unencrypted) metadata / cipher text — NOT bytecode
0xA0+:     Encrypted data — decrypted by BldLoader via ((b+41)&0xFF)^233, then processed as bytecode + cipher text
```

**CRITICAL**: `InterpreterBase = 0xA0` (verified from Reko decompilation of `fn0FDC_01C0`
at `UNBTECH_0FDC.asm:92-98`: `mov ax,0A0h; mov dx,3092h; push dx; push ax; call 01C0h`).
The bytecode interpreter reads from base `0xA0` within the BLD buffer — bytecode
position 0 = file offset 0xA0. The pre-0xA0 region (0x08-0x9F) is metadata/cipher text
that is NEVER interpreted as bytecode by the original game. Opcode-like byte values
(e.g. 0xF5 at offset 0x0B) in this region are **false positives** — they happen to
match opcode values but are NOT part of the actual bytecode stream. See CONTEXT.md §4
for full explanation.

### Byte Ranges (AFTER decryption for 0xA0+; running from base 0xA0)

| Range (offset from base) | Type | Description |
|-------|------|-------------|
| 0x00-0x7F | Cipher text | Passed through `CipherDecoder.DecodeByte()` |
| 0x80-0xE3 | Structural markers | **Skipped** unless `CipherDecoder.IsMapped()` returns true (only `0x81-0x87`, `0x90-0x96`, `0xA0` have cipher mappings). These are formatting markers (new sentence, paragraph, punctuation, price encoding), NOT cipher text. |
| 0xE4-0xFF | Opcodes | See `BldOpcode` enum |

**Narrative markers** (subset of 0x80-0xE3, handled before decoder):
- `0x9E`=ThirdPerson, `0x9C`=CharacterSpeech, `0x9B`=PlayerThought, `0x9F`=PlayerAction, `0xA5`=Continuation

**Separators** (skipped): `0xC0`, `0xBA`, `0xBB`

**0x81-0x96 uppercase cipher bytes**: These ARE valid cipher text and decoded by `CipherDecoder` (`0x81`='C', `0x82`='B', `0x83`='E', `0x84`='D', `0x85`='G', `0x86`='F', `0x87`='Y', `0x90`='P', `0x91`='S', `0x92`='R', `0x93`='U', `0x94`='T', `0x95`='W', `0x96`='V'). All other bytes 0x80-0xE3 are structural markers and silently skipped.

**Note on original game typos**: The game text contains genuine 1988 typos where 'q' is spelled as 'o' (e.g. "eouipment" for "equipment", "ouite" for "quite", "reouest" for "request"). This is NOT a cipher error — byte 0x60 ('q') exists but is never used; byte 0x6F ('o') appears in its place in misspelled words.

### Key Opcodes

| Opcode | Name | Operands | Description |
|--------|------|----------|-------------|
| `0xF5` | SHOP_DISPATCH | 1 byte case# | Dispatches building interaction (0x01-0x2F) via Fn1CD3Dispatcher |
| `0xF9` | JUMP_INDEXED | 1 byte menuId | Calls `fn1E56_0B5E(menuId)` → returns selection index; reads WORD at `base + _ip + index*2` as new IP (absolute). Jump table entries are WORDs right after operand byte |
| `0xF8` | JUMP_FORWARD | 1 WORD target | Reads WORD operand as absolute jump target (`_ip = word`) — confirmed absolute from Reko |
| `0xF3` | SHOP_INTERACTION | 1 byte stateIdx | Reads `StateArray[stateIdx]`, sign-extends to `sbyte`, multiplies by 2, reads WORD at `base + _ip + val*2` as new IP. Computed jump keyed on game state |
| `0xEA` | COND_STATE_ACTION | 2 bytes (cond+action) | If global block flag == 0, calls `fn0800_48B7(cond, action)` |
| `0xE9` | CALL_ROOM_HANDLER | 1 byte handlerIdx | Calls `fn11B8_0D58(handlerIdx)` → creates hireling in empty slot |
| `0xEC` | CHECK_FLAG_EC | 1 WORD target | Jumps there if TrainingComplete |
| `0xEB` | CHECK_FLAG_EB | 1 WORD target | Jumps there if Milestone |

### BLD files location

`../../../*.BLD` relative to project root (i.e., repository root).

## Radare2 (r2) Tooling

r2 **6.0.7** installed at `/usr/bin/r2`. Project binary is `UNBTECH.exe` (MS-DOS MZ, 16-bit x86 real mode).

### r2 Project File

`UNBTECH.exe.bndb` (3MB SQLite) — pre-analyzed r2 project with flags, functions, etc.

### Key Commands

```bash
# Open with project (loads all analysis)
r2 -p UNBTECH.exe.bndb UNBTECH.exe

# Quick open in write mode (apply relocs)
r2 -e bin.relocs.apply=true -w UNBTECH.exe

# List segments/sections
r2 -q -c "iS" UNBTECH.exe

# Print binary info
r2 -q -c "i" UNBTECH.exe

# List supported arch plugins (MS-DOS uses x86 16-bit)
r2 -q -c "La" UNBTECH.exe
```

### MS-DOS 16-bit Analysis

```bash
# Open with 16-bit x86 arch
r2 -q -c "e asm.arch=x86; e asm.bits=16; aaa; s 0x1CC72; pd 20" UNBTECH.exe

# Seek to segment:offset (linear address = segment*16 + offset)
r2 -q -c "e asm.arch=x86; e asm.bits=16; s 0x0FDC*0x10+0x01C0; pd 50" UNBTECH.exe

# List functions (after analysis)
r2 -q -c "e asm.arch=x86; e asm.bits=16; aaa; afl" UNBTECH.exe
```

### Linear Address Calculation

MS-DOS real-mode `SEGMENT:OFFSET` → linear = `SEGMENT * 0x10 + OFFSET`.

| Segment | Offset | Linear | Description |
|---------|--------|--------|-------------|
| `0FDC` | `01C0` | `0xFDC0` | BLD bytecode interpreter |
| `1CD3` | `0004` | `0x1CD34` | fn1CD3_0004 case dispatch |
| `1E56` | `03F5` | `0x1E595` | Text renderer |
| `0800` | `0000` | `0x8000` | Main game loop |

### r2 Usage for Segment Dump / String Search

```bash
# Search strings in binary
r2 -q -c "/ some_pattern" UNBTECH.exe

# Dump raw bytes at range
r2 -q -c "s 0x8000; p8 256" UNBTECH.exe

# Analyze and print cross-references (use project file for pre-analyzed data)
r2 -q -c "e asm.arch=x86; e asm.bits=16; aaa; ax" UNBTECH.exe
```

### r2 Plugins

Installed at `/usr/lib/x86_64-linux-gnu/radare2/6.0.7/`. User plugins at `~/.local/share/radare2/plugins/`.

## Spice86 (x86 Emulator + Code Generator)

Spice86 is an open-source x86 emulator that emulates the original game and generates C# code from execution traces.

### Spice86 Directory Layout

| Path | Description |
|------|-------------|
| `spice86/GeneratedCode/` | Generated C# code for ~23 segments (GeneratedCode.cs – GeneratedCode22.cs) |
| `spice86/GeneratedCode/GeneratedOverridesManual.cs` | Manual function overrides (e.g., MainGameLoop at 1000:1ABA) |
| `spice86/spice86dumpMemoryDump.bin` | Full memory dump from emulation replay |
| `spice86/spice86dumpGhidraSymbols.txt` | 1427 Ghidra-recognized symbols |
| `spice86/spice86dumpExecutionFlow.json` | Execution flow records |
| `spice86/spice86dumpCpuRegisters.json` | CPU register trace |
| `spice86/Spice86CodeGenerator.txt` | Code generator log (355K lines) |
| `spice86/Spice86DataImport.txt` | Data import log |
| `spice86/Breakpoints.json` | Per-run breakpoints config |

### Key Files

- **Function naming pattern**: `ghidra_guess_SEGMENT_OFFSET_LINEAR` or `unknown_SEGMENT_OFFSET_LINEAR`
- **Segment layout**: Segments 0x0000–0xF100 mapped across 24 generated code files
- **cs variables**: Each segment mapped as `csN = entrySegment + SEGMENT` (e.g., `cs12 = 0x19EF` for combat code)
- **Function registration**: Via `DefineFunction(csN, offset, handler, false)` in override classes

### Typical Workflow

```
Run Spice86 emulation → execution trace → code generator → GeneratedCode/*.cs
                                                            ↓
                                          Manual overrides in GeneratedOverridesManual.cs
                                                            ↓
                                          Analysis + cross-reference with Reko + r2
```

## GDB (GNU Debugger)

GDB **17.1** installed at `/usr/bin/gdb`. While `UNBTECH.exe` is an MS-DOS MZ binary (not debuggable natively), GDB is used for:

- **Analyzing Reko-generated C code**: Step through decompiled C source in `reko/segments/` for behavior understanding
- **Debugging the Godot C# rebuild**: Attach to the .NET runtime for Godot game debugging (use `dotnet` attach or `gdbfront`)

### Key Commands

```bash
# Debug Reko C output (compile first with -g)
gdb ./reko_test_binary

# Set breakpoint on a specific function
b fn0FDC_01C0

# Examine memory/registers in the decompiled context
x/32bx $address

# Disassemble around current PC
layout asm
```

## Reko Decompiler

Full decompilation at `reko/` using Reko v0.12.2.0 (Microsoft C 5.0 detected).

### Reko Directory Layout

| Path | Description |
|------|-------------|
| `reko/UNBTECH.exe.c` | Main decompiled C output |
| `reko/UNBTECH.exe.h` | 695KB header with all struct/union equivalence classes |
| `reko/UNBTECH_pseudocode.txt` | 34K-line annotated discoveries & pseudocode |
| `reko/UNBTECH_all.asm` | Combined 59K-line disassembly |
| `reko/segments/` | Per-segment C, .dis, and .asm files |
| `reko/segments/UNBTECH.h` | Per-segment struct definitions |

### Key Structures

- **Eq_57354**: Story state array container with `aC744[]` of `Eq_107947` elements
- **Eq_107947**: Per-story-slot struct (125 bytes, stride 0x7D)
- **Globals file maps**: Segment pointers like `g_ptrFFFA0000`, `g_w046E`

## Dosbox-X (Debug)

Dosbox-X installed at `/usr/bin/dosbox`. Configurations at `dosbox_test/`.

| File | Description |
|------|-------------|
| `dosbox_test/dosbox-x.conf` | Standard run configuration (svga_s3, 16MB, normal2x) |
| `dosbox_test/dosbox-x-debug.conf` | Debug configuration with `debug=high` |
| `dosbox_test/UNBTECH.exe` | Symlink/copy of the unpacked binary |

```bash
# Run the original game
dosbox -conf dosbox_test/dosbox-x.conf

# Run with debug output
dosbox -conf dosbox_test/dosbox-x-debug.conf
```

## Python Analysis Tools (`tools/`)

### `tools/analysis/` — Binary & Memory Dump Analysis

These scripts work on raw binary data (not r2-pipe):

| Script | Purpose |
|--------|---------|
| `analyze_header.py` | MZ EXE header parsing |
| `extract_strings.py` | String extraction from binary |
| `find_strings.py` | String search patterns |
| `find_refs.py` | Reference hunting in memory dumps |
| `search_refs.py` | Cross-reference search |
| `analyze_refs.py` / `analyze_refs_v2.py` | Reference analysis from Spice86 dumps |
| `debug_refs.py` | Debug reference lookups |
| `dump_locations.py` | Dump position data from Spice86 traces |
| `dump_msgs.py` | Dump message data from Spice86 traces |
| `check_dims.py` | Dimension verification utility |

### `tools/bld/` — BLD Script Tools

| Script | Purpose |
|--------|---------|
| `decode_bld_interp.py` | Full BLD bytecode interpreter (26 opcodes 0xE4-0xFF) |
| `decode_bld.py` | BLD cipher decoder |
| `bld_json_converter.py` | Round-trip BLD ↔ JSON converter |
| `extract_bld_text.py` | Extract cipher-decoded text from BLD files |
| `extract_story.py` | Extract full narrative → `STORY_TEXT.txt` |
| `ascii_viewer.py` | ASCII viewer for BLD content |

## Tool Complement Summary

| Tool | Purpose | When to Use |
|------|---------|-------------|
| **r2** | Interactive disassembly, binary investigation, string search, byte-level analysis | Reverse engineer specific bytecode, check opcodes, dump segments |
| **Reko** | Structural decompilation, C pseudocode, struct/union definitions | Understand high-level logic, data structures, control flow |
| **Spice86** | Execution trace, memory dump, C# code generation | Verify runtime behavior, get exact register/memory state |
| **GDB** | Debugging C# rebuild (Godot) or test binaries | Runtime debugging of the Godot rewrite |
| **Dosbox-X** | Run original game, verify behavior | Playtest original for reference |
| **Python tools** | Batch analysis, format conversion, story extraction | Bulk processing, text export, format conversion |
