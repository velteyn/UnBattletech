# UnBattletech — Reverse Engineering BattleTech: The Crescent Hawk's Inception (1988)

[![RE Status](https://img.shields.io/badge/RE-95%25-brightgreen)](docs/context.md)
[![Godot Rebuild](https://img.shields.io/badge/Rebuild-Phase_6-green)](BattleTechCHI/)

Reverse engineering analysis and Godot 4 + C# rebuild of **BattleTech: The Crescent Hawk's Inception**, the 1988 MS-DOS game by Infocom.

## Repository Structure

```
├── docs/               # RE documentation & findings
│   ├── INDEX.md        # Documentation map (canonical source per topic)
│   ├── context.md      # Master overview + known/unknown
│   ├── combat-system.md           # Canonical combat spec
│   ├── world-map.md               # Canonical world-map spec
│   ├── formats/        # file-formats, bld-bytecode, anm-format, memory-map
│   ├── story/          # story-arc, story-system, STORY_TEXT.txt
│   ├── rebuild/        # roadmap, progress
│   ├── tools/          # spice86-mcp, analysis-tools
│   ├── walkthrough/    # gameplay walkthroughs
│   └── UNVERIFIED_DISCOVERIES.md
│
├── tools/              # Python analysis tools
│   ├── bld/            # BLD script tools (decoder, converter, viewer)
│   ├── assets/         # Asset extraction & rendering tools
│   └── analysis/       # RE analysis tools
│
├── reko/               # Reko decompiler output
│   ├── UNBTECH.exe.c   # Full C decompilation (2MB)
│   ├── UNBTECH.exe.h   # Header with struct definitions
│   ├── UNBTECH_all.asm # Combined disassembly (60K lines)
│   └── segments/       # Per-segment .c/.asm/.dis files
│
├── asm/                # Assembly analysis
│   └── discoveries.asm # Manual analysis notes
│
├── json/               # BLD → JSON conversions (26 files)
│
├── spice86/            # Spice86 emulation outputs
│
├── BattleTechCHI/      # Godot 4 + C# rebuild
│
├── original/           # Original game assets (local only, not uploaded)
│   ├── bld/  cmp/  icn/  mtp/  anm/  saves/  exe/
│
├── extracted_assets/   # Rendered PPM/PNG from game assets
└── Assets/             # Converted sprite/tile sheets
```

## Key RE Achievements

- **BLD bytecode fully reverse-engineered**: 26 opcodes, substitution cipher, 4-layer interpreter
- **World map decoded**: 64×64 tile grid, 93 tile types, fog of war system
- **Combat system documented**: 2D6 to-hit, LoS ray-casting, AI targeting, heat/ammo
- **Story fully extracted**: All 26 BLD scripts decoded with narrative markers
- **Memory map complete**: 100+ addresses mapped across all segments

## Godot Rebuild Progress

The rebuild is in **Phase 6** (ANM integration + combat ANM). ~8,000 lines C# across 45+ scripts in `BattleTechCHI/Scripts/`.

- ✅ Phase 0–1: Core engine, data models, asset loaders, game loop, partial save/load
- ✅ Phase 2: Tile rendering, world map viewport, local maps, LocationMapper, fog of war
- ✅ Phase 3: BLD interpreter (26 opcodes), cipher decoder, 47-case dispatcher (all real impl.), dialogue, ShopScreen
- ✅ Phase 4: Combat — init, turn order, movement, LoS, to-hit (2D6), damage, AI, heat/ammo, fog, HUD, encounters
- ✅ Phase 5: AnmPlayer + ViewportManager + BldAnmMap, runtime ANM decompress
- ✅ Phase 6: Combat mech panel ANM (MechPortrait), map cursor ANM, stock-market RE + dispatcher cases 0x2A/0x2B, StorySlots 16→8 fix. (A:/B: drive mount now lives in `BattleTechMcpTools/BattleTechOverrideSupplier.cs`.)
- ⬜ Phase 7: End-to-end playtesting, polish (VFX, BTSTATS, sound, w4FBC refactor, TileMapLayer migration)

## Emulator & Runtime Introspection

Spice86 emulator with 23 BattleTech-specific MCP tools for runtime game state introspection:
- Read/write game state (state array, story slots, unit slots, cursor, credits, flags)
- Read combat grids, unit positions, fog of war
- Inject keyboard input (script the game through menus)
- Read CPU registers and memory
- Capture the screen as ASCII art (`bt_screenshot`: text mode 0x03 → 80×25 text from B800:0000; graphics 0x13/0x0D/0x0E → 80×50 luminance grid from A000:0000)

```bash
# Start emulator with MCP server on port 8086
dotnet exec bin/Debug/net10.0/UNBATTLETECH.dll \
  --Exe "/path/to/BTECH.EXE" \
  --CDrive "/path/to/game/" \
  --HeadlessMode Minimal --McpHttpPort 8086 --NoGui

# Read game state (POST JSON-RPC; GET returns SSE endpoint event)
curl -s -X POST http://localhost:8086/mcp/ \
  -H "Content-Type: application/json" \
  -d '{"jsonrpc":"2.0","id":1,"method":"tools/call","params":{"name":"bt_get_state","arguments":{}}}'
```

## Tools & Scripts

```bash
# Convert BLD → JSON and back
python3 tools/bld/bld_json_converter.py to-json original/bld/

# Extract full story text
python3 tools/bld/extract_story.py

# Decode all BLD files with opcode analysis
python3 tools/bld/decode_bld.py

# ASCII terminal viewer for maps
python3 tools/bld/ascii_viewer.py

# Render CMP assets to PPM
python3 tools/assets/extract_assets.py

# Build C# rebuild
cd BattleTechCHI && dotnet build

# Build emulator
dotnet build UNBATTLETECH.csproj
```

## Disclaimer

This repository contains **no original game assets** (BLD, CMP, EXE, etc.). Only reverse engineering analysis, documentation, and original source code for a clean-room rebuild are included. The original game assets remain in `original/` for local development only (gitignored).
