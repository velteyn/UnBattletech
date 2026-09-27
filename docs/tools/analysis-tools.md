# Analysis Tooling

> Canonical inventory of analysis tooling used on this project. For the
> BattleTech MCP runtime tools see `docs/tools/spice86-mcp.md`. For CLI command
> recipes (r2/Reko/GDB/Spice86) see `AGENTS.md`.

## Decompilation & analysis tools


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


## .NET asset extraction toolkit (InceptionTools)


A C# console application (`.NET Core 3.1`) at `InceptionTools/` provides:

- **Asset extraction**: Full pipeline for all game assets (images, sprites, maps, animations)
- **Compression**: 3 RLE variants (Format01 row-major, Format02 column-major, Animation XOR-delta)
- **File format parsers**: CMP, ICN, MTP, ANM, Save files
- **Graphics**: EGA planar decoder, 16-color palette management, sprite sheet extraction, map tile rendering
- **Data definitions**: Weapon database (33 weapons), 8 mech definitions, infantry character parser, save game binary parser
- **Sprite enum**: Named constants for Locust, Commando, Character, Fire/Impact/Wreck sprites

---


## Python analysis scripts


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

