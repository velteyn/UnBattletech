# Rebuild Roadmap: BattleTech — The Crescent Hawk's Inception

## Current Assessment

The reverse engineering effort is **~90% complete** — we understand the game's code, data formats, combat system, story, and memory layout. But the **actual reimplementation is at ~0%**. The Java prototype is an abandoned tech demo with hardcoded placeholders, no build system, and zero integration of the reversed data.

**What exists that's useful:**
| Asset | Format | Ready for rebuild? |
|-------|--------|--------------------|
| All 15 maps | BMP from InceptionTools | Yes — drop-in sprite/texture |
| 376 mech sprites | BMP from MECHSHAP.CMP | Yes — ready for sprite atlases |
| 22 animations | BMP sequences | Yes — frame-by-frame |
| All tile sets | BMP from ICN files | Yes — ready for tilemaps |
| Full-screen images | BMP | Yes |
| 33 weapon stats | C# struct | Needs porting to target engine |
| 8 mech definitions | C# struct | Needs porting to target engine |
| Save file format | Fully documented | Ready to implement |
| BLD bytecode spec | Fully documented | Ready to implement interpreter |
| BLD↔JSON converter | Python | Can generate JSON data files |
| Cipher text decoder | Python | Ready to port |
| Full story text | TXT | Reference only (drive BLD runtime) |
| Memory map | MD doc | Reference for state layout |
| Combat system | MD doc + Spice86 | Reference for implementation |

**What needs original work:**
| System | Status | Effort |
|--------|--------|--------|
| Game engine selection | ❌ Nothing chosen | Small |
| BLD bytecode runtime | ⚠️ Full spec exists, no runtime | Medium |
| Game loop | ⚠️ Architecture known, no implementation | Medium |
| Tile rendering from real data | ⚠️ Format known, no renderer | Medium |
| Map loading + viewport | ⚠️ Full map data available | Medium |
| Combat system | ⚠️ Fully documented, no implementation | Large |
| AI system | ⚠️ Data-driven spec known | Medium |
| 3-layer story state machine | ⚠️ Fully documented | Medium |
| Shop/economy/inventory | ⚠️ All data structures known | Medium |
| Save/Load | ⚠️ Format fully documented | Small |
| Animation playback | ⚠️ Frames extracted, no player | Small |
| Sound/music | ❌ Unknown format | Unknown |

## Recommended Approach: Engine Selection

### Option A: Godot 4 (Recommended)
- **Pros**: Best for 2D tile-based games, C# + GDScript support, built-in tilemap, animation player, dialogue system possible via plugins, export to all platforms, free/libre
- **Cons**: Learning curve for new users
- **Fit**: Perfect for this game (2D, tile-based, turn-based combat, menu-driven UI)

### Option B: Unity
- **Pros**: C# native (matches InceptionTools), huge ecosystem, 2D tools mature
- **Cons**: Heavier than needed, ongoing licensing changes, overkill for 2D turn-based
- **Fit**: Good, but heavier than necessary

### Option C: Custom Java/SDL
- **Pros**: Matches existing prototype language, full control
- **Cons**: No tooling, no built-in tilemap/animation/UI, more work for worse result
- **Fit**: Poor — the existing Java prototype proves this doesn't scale

### Option D: Pygame/Python
- **Pros**: Matches existing Python analysis scripts, quick prototyping
- **Cons**: Poor performance, no mobile/web export, no tooling
- **Fit**: OK for prototyping, bad for final product

**Recommendation: Godot 4 with C#** — the tilemap node alone saves weeks of rendering work, the animation system handles ANM playback trivially, and C# means the InceptionTools data models can be ported directly.

## Rebuild Phases

```
Phase 0: Foundation
├── Choose engine (Godot 4 + C# recommended)
├── Set up project structure
├── Port data models from InceptionTools (weapons, mechs, items, maps)
├── Implement asset loading pipeline (BMP tilemaps, sprite atlases)
├── Port BLD JSON converter output as data files
└── Set up version control

Phase 1: Core Systems
├── Game loop (init → input → update → render, matching 6-phase architecture)
├── 3-layer state machine (D30C array, story properties, bD450/bD451 flags)
├── Global UI mode manager (w4FBA: WorldMap/LocalTiles/Text/BuildingName)
├── Input handling (WASD remapping, SPACE menu, function keys)
├── EGA palette system (16-color, per-asset swaps)
├── Border/panel compositing (80px left panel, 240px right panel)
└── Save/Load (save file binary format)

Phase 2: World Map & Navigation
├── World map rendering (w4FBA=0: 13×12 tile grid, 1024×1024 world)
├── Map file loader (MTP format: header, NPC names, building names, tile data)
├── Tile property system (movement cost, LoS blocking, terrain modifier)
├── Cursor movement with collision (fn207F_18EF tile grid)
├── Location → BLD mapping (index translation table at 0x4602)
├── World map visibility (2048 byte bit-packed 128×128)
└── Map transitions (world map ↔ local map ↔ interior)

Phase 3: BLD Script Engine & Story
├── BLD file loader + decryptor (XOR 0xE9, add 0x29 decryption)
├── Bytecode interpreter (26 opcodes 0xE4-0xFF)
├── Cipher text decoder (complete substitution table)
├── Narrative marker system (9E/9C/9B/9F/A5 mode switches)
├── Dialogue/menu UI renderer with word wrapping
├── fn1CD3_0004 dispatch (47 cases: ENTER_BUILDING through COMBAT_ENCOUNTER)
├── Branching/conditional system (RNG checks, cursor compares, state checks)
├── Shop system (4 modes: display/buy/sell/heal with C618, aD374, tD370)
├── Room handler system (fn11B8_0D58 dispatch)
└── All 26 BLD files wired to their maps/locations

Phase 4: Combat System ✅
├── Combat initialization (fn183B_000A: populate enemies, init fog)
├── Turn order (24 slots: 4 player mechs + 8 enemy infantry + 12 enemy mechs)
├── Movement phase (8-direction, tile cost, skill-gated LoS stepping)
├── Targeting phase (weapon range, LoS ray-cast, fog check)
├── To-hit formula (2D6 + skill + terrain + heat + story state modifiers)
├── Damage application (hit location, criticals, heat generation)
├── AI system (data-driven target preference table, stage counter dispatch)
├── Fog of war (twin 12×24 grids, LoS clearing)
├── Heat system (weapon heat → pool → penalty accumulator → cap 30)
├── Ammo management (10 bins per mech, per-missile for LRM/SRM)
├── Combat UI: CombatView (TileMap 24×12 grid, sprites, fog, cursor, reticle)
├── Combat HUD: left panel overlay (unit stats, weapons, message log, prompts)
├── Player input: arrow/WASD move cursor, Space confirm, Esc cancel, 1-9 weapons
├── Two-step confirm flow: target select → weapon select → fire
└── Combat → world transition (cleanup, story state updates)

Phase 5: Economy & Inventory
├── C-Bills tracking (32-bit dwD370)
├── Shop data: C618[3] display slots, bD314 selection
├── Player inventory: aD374[] quantities (uint32), aD376[] data (uint16)
├── Buy/sell formulas (single: type×125+75, bulk: 1 cr/unit)
├── Hospital healing (cost tables at 0x4F26/0x4F28)
├── Garage/repair service (cost table at 0x4F6E)
├── Tech screen (component repair, 7 item slots)
├── Equipment management (fn1CD3_0004 cases 0x0D-0x18)
└── Stock market (DefHes, NasDiv, BakPhar tickers, economy ticker bD323)

Phase 6: Integration & Testing
├── Wire all BLD files to correct map locations
├── Test training sequence end-to-end (TRAINING.BLD → Citadel attack → bD450)
├── Test citadel attack sequence (story property 0x1F → b0057 0→1→2)
├── Test all 8 shops (weapon, armor, repair, hospital, garage, clothes, bar, comstar)
├── Test world map random encounters (RNG & bD330, 3 mech templates)
├── Test combat vs training dummy (special case ID 0xD)
├── Test arena combat (ARENA.BLD)
├── Test full story walkthrough (NewGame → Endgame)
└── Verify save/load round-trip against original save files

Phase 7: Polish (Post-MVP)
├── Startup sequence (INFOCOM + BTTITLE splash)
├── Sound/music (if format is decoded)
├── Animations (ANM playback in left panel)
├── Combat VFX (impact, fire, explosions)
├── Mech scale/rotation sprites for battlefield
├── UI polish (EGA-style borders, fonts)
├── Keyboard shortcut help
└── Packaging for distribution
```

## Completeness by System (Traffic Light)

| System | Reverse Engineering | Engine Implementation |
|--------|--------------------|----------------------|
| Asset extraction | 🟢 100% complete | 🟡 Phase 0 (port data) |
| BLD bytecode | 🟢 100% complete | 🔴 Phase 3 (full interpreter needed) |
| Story text | 🟢 100% decoded | 🔴 Phase 3 (interpreter needed) |
| Map format | 🟢 100% complete | 🔴 Phase 2 (renderer needed) |
| Combat system | 🟢 90% complete | 🟢 Phase 4 (full system built, player input + grid UI) |
| AI system | 🟢 90% complete | 🟢 Phase 4 (data-driven) |
| Economy | 🟢 100% complete | 🔴 Phase 5 (all data structures known) |
| Save format | 🟢 100% complete | 🔴 Phase 1 (binary parser) |
| Animations | 🟡 80% (frames extracted) | 🔴 Phase 7 (player needed) |
| Sound/music | 🔴 0% (undecoded) | 🔴 Unknown effort |
| Game loop | 🟢 100% documented | 🔴 Phase 1 (architecture known) |
| Memory map | 🟢 90% complete | 🟡 Phase 1 (state machine) |

## Key Technical Decisions

### Data-Driven Architecture
The entire game should be data-driven from the reversed files, NOT hardcoded:
- **Maps** → loaded from original .MTP files (or converted JSON)
- **Scripts** → loaded from original .BLD files (or converted JSON) and run via the bytecode interpreter
- **Weapons/Mechs** → loaded from data tables (NOT hardcoded in source)
- **Story state** → driven by the 3-layer system (D30C array + story properties + flags)

### What NOT to Hardcode
- Building names, NPC names, dialogue text → comes from BLD/MTP
- Map tile layouts → comes from MTP
- Shop inventories → comes from BLD bytecode
- Story triggers → comes from story properties layer
- Quest flags → comes from D30C state array

### The BLD Interpreter Is the Game Engine
The single most important piece of code is the BLD bytecode interpreter. Everything else — combat, shops, dialogue, story progression — is driven by BLD scripts. Get this right and 60% of the game "just works."

### Shortcut: Use C# BLD JSON
Rather than porting the Python BLD decoder + cipher to the target engine, use `bld_json_converter.py` to pre-convert all 26 BLD files to JSON. The engine loads JSON directly and only needs to implement the interpreter logic (not the cipher/decryption).

## Effort Estimation

| Phase | Estimated Effort | Dependencies |
|-------|-----------------|-------------|
| Phase 0: Foundation | 1-2 weeks | Engine choice |
| Phase 1: Core Systems | 2-3 weeks | Phase 0 |
| Phase 2: World & Navigation | 2-3 weeks | Phase 1 |
| Phase 3: BLD Script Engine | 4-6 weeks | Phase 1 (largest single piece) |
| Phase 4: Combat System | 3-4 weeks | Phase 1 | ✅ Done |
| Phase 5: Economy & Inventory | 1-2 weeks | Phase 3 |
| Phase 6: Integration & Testing | 2-3 weeks | Phases 2-5 |
| Phase 7: Polish | 2-4 weeks | Phase 6 |
| **Total (MVP playable game)** | **~16-24 weeks** | **Full-time** |
| **Total (polished)** | **~20-30 weeks** | |

## Critical Path

```
Phase 0 (Foundation)
  └─► Phase 1 (Core Systems)
       ├─► Phase 2 (World) ──► Phase 3 (BLD Engine) ──► Phase 5 (Economy)
       │                                                └──► Phase 6 (Integration)
       └─► Phase 4 (Combat) ───────────────────────────┘
                                        └─► Phase 7 (Polish)
```

Phase 3 (BLD interpreter) is the longest pole — start it as early as possible after Phase 1.

## What We'd Do Differently Than The Java Prototype

| Java Prototype (bad) | Rebuild (correct) |
|---------------------|-------------------|
| Hardcoded pseudo-random tile generation | Load real .MTP map data |
| `Math.random()` combat | 2D6 to-hit formula from Reko analysis |
| Hardcoded story booleans | 3-layer state machine (D30C + properties + flags) |
| "Not implemented" shops | Full fn1CD3_0004 dispatch with real inventory |
| Orphaned `Game.java` class | Integrated game loop matching original architecture |
| No build system | Godot/Unity project with proper tooling |
| Mock C-Bills (1,500,000) | Real 32-bit credit tracking |
| No save/load | Full save file binary format support |
| No BLD interpreter | Full bytecode interpreter with JSON data files |

## Conclusion

The reverse engineering work is **nearly complete** — we know how the game works at a deep level. The game logic is documented, all assets are extractable, and the bytecode script system is fully decoded. What's missing is ~6 months of focused engineering to assemble these pieces into a working game engine.

**The hard part (reverse engineering) is done. The straightforward part (implementation) remains.**
