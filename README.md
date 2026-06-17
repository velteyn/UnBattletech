# UnBattletech — Reverse Engineering BattleTech: The Crescent Hawk's Inception (1988)

[![RE Status](https://img.shields.io/badge/RE-95%25-brightgreen)](docs/CONTEXT.md)
[![Godot Rebuild](https://img.shields.io/badge/Rebuild-Phase_5-yellow)](BattleTechCHI/)

Reverse engineering analysis and Godot 4 + C# rebuild of **BattleTech: The Crescent Hawk's Inception**, the 1988 MS-DOS game by Infocom.

## Repository Structure

```
├── docs/               # RE documentation & findings
│   ├── CONTEXT.md      # Master context (851 lines)
│   ├── TECHNICAL_ANALYSIS.md  # Comprehensive technical analysis (3193 lines)
│   ├── MEMORY_MAP.md   # Full memory map (603 lines)
│   ├── ADDRESS_REFERENCE.md   # Address reference (1035 lines)
│   ├── BLD_BYTECODE.md # BLD bytecode specification (342 lines)
│   ├── WORLD_MAP_FINDINGS.md  # World map analysis (321 lines)
│   ├── REBUILD_PLAN.md # Godot rebuild plan
│   ├── REBUILD_ROADMAP.md     # Rebuild roadmap
│   └── STORY_TEXT.txt  # Extracted full story text
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

The rebuild is in **Phase 5** (economy + ANM integration). ~7,800 lines C# across 42 scripts in `BattleTechCHI/Scripts/`.

- ✅ Phase 0–1: Core engine, data models, asset loaders, game loop, partial save/load
- ✅ Phase 2: Tile rendering, world map viewport, local maps, LocationMapper, fog of war
- ✅ Phase 3: BLD interpreter (26 opcodes), cipher decoder, 47-case dispatcher (all real impl.), dialogue, ShopScreen
- ✅ Phase 4: Combat — init, turn order, movement, LoS, to-hit (2D6), damage, AI, heat/ammo, fog, HUD, encounters
- 🔄 Phase 5: Shops/economy (partial — stock market pending), AnmPlayer + ViewportManager + BldAnmMap, runtime ANM decompress
- ⬜ Phase 6–7: End-to-end playtesting, polish (VFX, BTSTATS, sound)

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
```

## Disclaimer

This repository contains **no original game assets** (BLD, CMP, EXE, etc.). Only reverse engineering analysis, documentation, and original source code for a clean-room rebuild are included. The original game assets remain in `original/` for local development only (gitignored).
