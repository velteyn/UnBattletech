# Rebuild Roadmap: BattleTech — The Crescent Hawk's Inception

**Last updated:** 2026-09-27  
**Engine:** Godot 4.4 + C# (`BattleTechCHI/`)  
**RE status:** ~95% complete  
**Rebuild status:** Phase 6 — integration & end-to-end playtest (phases 0–6 implemented)

---

## Current Assessment

The reverse engineering effort is **~95% complete** — BLD bytecode, combat, maps, story, economy data structures, and memory layout are documented and verified against decompiled C / Spice86 traces.

The Godot rebuild has moved well past scaffolding: **Phases 0–4 are implemented**, and **Phase 5 (economy + ANM integration) is underway**. The abandoned Java prototype is no longer relevant; all active work lives in `BattleTechCHI/`.

### What exists in the rebuild

| System | Implementation | Key files |
|--------|----------------|-----------|
| Core engine | Game loop, state manager, input, EGA palette | `Core/GameLoop.cs`, `StateManager.cs`, `InputHandler.cs` |
| Save/load | Partial — original 4096-byte format parser | `Core/SaveManager.cs` |
| Maps | MTP loader, ICN tiles, world + local views, fog | `Maps/MapLoader.cs`, `WorldMapView.cs`, `LocalMapView.cs` |
| BLD runtime | Loader, cipher, 26 opcodes, 47-case dispatcher | `BLD/BldInterpreter.cs`, `Fn1CD3Dispatcher.cs` |
| Shops/dialogue | ShopScreen, dialogue box, LocationMapper | `UI/ShopScreen.cs`, `DialogueBox.cs` |
| Combat | Full 12-phase loop, AI, 2D6, LoS, fog, HUD, mech portrait ANM | `Combat/*.cs` (7 files) |
| Viewport layout | ViewportManager, regions, EGA borders | `UI/ViewportManager.cs`, `ViewportRegion.cs` |
| ANM animations | Runtime decompress + PNG fallback, BldAnmMap | `UI/AnmPlayer.cs`, `Maps/RleDecompressor.cs` |
| Startup | INFOCOM + BTTITLE splash sequence | `UI/StartupSequence.cs` |
| Test runner | Standalone console harness (not Godot build) | `Runner/Program.cs` |

### What remains

| System | Status | Effort |
|--------|--------|--------|
| Stock market (DefHes, NasDiv, BakPhar) | ◐ RE + dispatcher cases 0x2A/0x2B done; Godot UI pending | Medium |
| Tech screen / component repair | ❌ Not implemented | Medium |
| Full equipment management UI | ⚠️ Dispatcher cases exist, UI thin | Medium |
| Save/load round-trip verification | ⚠️ Parser exists, not fully verified | Small |
| Combat mech panel ANM | ✅ MechPortrait + CombatHUD integration | — |
| Map cursor ANM (replace blink) | ✅ Implemented | — |
| 135D dispatch tables (full) | ⚠️ Partial via DispatchTables | Medium |
| End-to-end story playtesting | ❌ Not validated | Large |
| Sound/music | ❌ Format undecoded | Unknown |
| Combat VFX, BTSTATS, TINYLAND | ❌ Not implemented | Medium |

---

## Engine Choice (Resolved)

**Godot 4 + C#** — chosen and in production use. Godot 4.4, .NET SDK 4.4.0, net8.0. Mono build requires a display server (`xvfb-run` on headless systems).

---

## Rebuild Phases

```
Phase 0: Foundation ✅
├── Godot 4 + C# project scaffold
├── Data models (GameState, WeaponData, GameEnums)
├── Asset loading from original .MTP/.BLD/.ICN/.ANM
├── BLD JSON converter output in json/
└── Version control + gitignore for Godot

Phase 1: Core Systems ✅
├── Game loop (init → input → update → render)
├── 3-layer state machine (StateArray, story flags bD450/bD451)
├── GameMode / ViewportLayout manager
├── Input handling (WASD, SPACE menu, function keys)
├── EGA palette system
├── Border/panel compositing (80px left + 240px viewport)
└── Save/Load (partial — SaveManager binary parser)

Phase 2: World Map & Navigation ✅
├── World map rendering (64×64 tile buffer, 8×8 viewport)
├── Map file loader (MTP: header, NPC/building names, tile data)
├── Tile property system (movement cost, blocking)
├── Cursor movement with collision
├── Location → BLD mapping (LocationMapper, 22-entry table)
├── World map visibility (2048-byte bit-packed 128×128)
└── Map transitions (world map ↔ local map ↔ interior)

Phase 3: BLD Script Engine & Story ✅
├── BLD loader + decryptor (((b+41)&0xFF)^233 from offset 0xA0)
├── Bytecode interpreter (26 opcodes 0xE4–0xFF)
├── Cipher text decoder (complete substitution table)
├── Narrative marker system (9E/9C/9B/9F/A5)
├── Dialogue/menu UI with word wrapping
├── fn1CD3_0004 dispatch (all 47 cases — real implementations)
├── Branching/conditional system (RNG, cursor, state, credits)
├── Shop system (display/buy/sell/heal via ShopRegistry)
├── Room handler dispatch (cases 0x21/0x22 push/pop state)
└── All 26 BLD files wired via LocationMapper + tile selection

Phase 4: Combat System ✅
├── Combat initialization (enemy populate, fog init)
├── Turn order (24 slots: 4 player + 8 infantry + 12 mech)
├── Movement phase (approach, collision, fog clearing)
├── Targeting phase (weapon range, LoS ray-cast, fog check)
├── To-hit formula (2D6 + skill + terrain + heat + story penalty)
├── Damage (hit locations, criticals, cluster weapons, ammo)
├── AI system (story-state target preference, distance action codes)
├── Fog of war (twin 12×24 grids, LoS clearing)
├── Heat system (pool → penalty → dissipation)
├── Ammo management (10 bins, per-missile LRM/SRM)
├── Combat UI (CombatView grid, CombatHUD, player input)
├── World map random encounters (RNG & EncounterMask)
└── Combat → world transition (story update, view restore)

Phase 5: Economy, Inventory & ANM 🔄
├── C-Bills tracking (32-bit Credits in GameState) ✅
├── Shop buy/sell/heal via dispatcher ✅
├── Player inventory arrays (StateArray slots) ✅
├── Hospital/garage service costs (dispatcher cases) ✅
├── ANM runtime decompression (RleDecompressor.DecompressAnimationFrames) ✅
├── AnmPlayer + ViewportManager + BorderPanel integration ✅
├── BldAnmMap (building → O0–O15 mapping) ✅
├── Animation dispatch on cursor hover (DispatchCursorMove) ✅  (building-name hover only; ANM playback is still a no-op stub)
├── Stock market (DefHes, NasDiv, BakPhar, bD323 ticker) ◐  (RE + dispatcher cases 0x2A/0x2B + StockEntry/GameState done; Godot stock UI pending)
├── Tech screen (component repair, 7 item slots) ⬜
├── Full equipment management UI ⬜
├── Combat mech panel ANM (idle/move/fire/damage) ✅
└── Map cursor ANM (replace blink timer) ✅

Phase 6: Integration & Testing ⬜
├── Wire all BLD files to correct map locations (verify in playtest)
├── Test training sequence (TRAINING.BLD → Citadel attack → bD450)
├── Test citadel attack (story property 0x1F → b0057 0→1→2)
├── Test all shops (weapon, armor, repair, hospital, garage, clothes, bar, comstar)
├── Test world map random encounters (RNG & bD330)
├── Test arena combat (ARENA.BLD)
├── Test full story walkthrough (NewGame → WINSCENE)
└── Verify save/load round-trip against original save files

Phase 7: Polish (Post-MVP) ⬜
├── Startup sequence (INFOCOM + BTTITLE) — scaffold exists
├── Sound/music (if format is decoded)
├── Combat VFX (impact, fire, explosions)
├── Mech scale/rotation sprites for battlefield
├── BTSTATS equipment screen, ENDMECH finale, TINYLAND mini-map
├── UI polish (EGA-style borders — BTBORDER tiles in use)
├── Keyboard shortcut help
└── Packaging for distribution
```

---

## Completeness by System

| System | Reverse Engineering | Engine Implementation |
|--------|--------------------|----------------------|
| Asset extraction | 🟢 100% | 🟢 Loaders for MTP/ICN/BLD/ANM |
| BLD bytecode | 🟢 100% | 🟢 Full interpreter + dispatcher |
| Story text | 🟢 100% decoded | 🟢 Runtime via BLD interpreter |
| Map format | 🟢 100% | 🟢 World + local map views |
| Combat system | 🟢 90% | 🟢 Full combat loop + UI |
| AI system | 🟢 90% | 🟢 AiController implemented |
| Economy / shops | 🟢 100% documented | 🟡 Shops work; stock RE + dispatcher cases 0x2A/0x2B done, Godot UI pending |
| Save format | 🟢 100% | 🟡 Parser exists; round-trip unverified |
| Animations (ANM) | 🟢 100% format | 🟢 Player + building + combat mech-panel + map-cursor ANM |
| Sound/music | 🔴 0% | 🔴 Unknown effort |
| Game loop | 🟢 100% documented | 🟢 GameLoop.cs |
| Memory map | 🟢 90% | 🟢 GameState mirrors key addresses |
| Viewport system | 🟢 Documented | 🟡 ViewportManager (w4FBC narrow panel TODO) |

---

## Key Technical Decisions

### Data-Driven Architecture
The rebuild loads original game files at runtime where possible:
- **Maps** → `.MTP` via `MapLoader`
- **Scripts** → `.BLD` via `BldLoader` + `BldInterpreter`
- **Tiles** → `.ICN` via `TileManager`
- **Animations** → `.ANM` via `AnmPlayer.LoadRaw()` (PNG spritesheet fallback)

### The BLD Interpreter Is the Game Engine
Combat entry, shops, dialogue, flags, and story progression are all driven by BLD scripts and `Fn1CD3Dispatcher`. This is implemented and is the backbone of non-combat gameplay.

### BLD JSON as Development Aid
`bld_json_converter.py` produces `json/` files for analysis and diffing. The runtime loads original `.BLD` files from `original/bld/` for fidelity.

---

## Effort Remaining (Estimate)

| Phase | Status | Remaining effort |
|-------|--------|------------------|
| Phase 0–4 | ✅ Done | — |
| Phase 5: Economy + ANM | 🔄 ~60% | 2–3 weeks |
| Phase 6: Integration & Testing | ⬜ | 2–3 weeks |
| Phase 7: Polish | ⬜ | 2–4 weeks |
| **To playable MVP** | | **~4–8 weeks** full-time |
| **To polished release** | | **~6–10 weeks** full-time |

---

## Critical Path (Updated)

```
Phase 0–4 ✅
  └─► Phase 5 (Economy + ANM) 🔄
       ├─► Stock market + tech screen
       ├─► Combat mech panel ANM + cursor ANM
       └─► Phase 6 (Integration & Testing)
            └─► Phase 7 (Polish)
```

Current focus: finish Phase 5 ANM integration (combat panel, cursor), then stock market for training-school economy loop, then end-to-end playtesting.

---

## Conclusion

The hard part (reverse engineering) is done. The rebuild has crossed the midpoint: core engine, maps, BLD interpreter, shops, and combat are working in Godot. Remaining work is **integration, economy completeness, animation polish, and playtest-driven tuning** — not fundamental architecture.

---

## Detailed Step Checklist

> Consolidated from the former Italian `REBUILD_PLAN.md` (translated). Granular
> per-step status with the files involved; the phase summaries above stay authoritative.

### Phase 0 — Foundation ✅
| Step | What | Status |
|------|------|--------|
| 0.1 | Godot scaffolding | ✅ `BattleTechCHI/`, Godot 4.4 + net8.0 |
| 0.2 | Data models | ✅ `DataModels.cs`, `GameState.cs`, `WeaponData.cs` |
| 0.3 | Asset pipeline | ✅ loads original .MTP/.BLD/.ICN/.ANM |
| 0.4 | BLD as JSON | ✅ `json/` + `bld_json_converter.py` |
| 0.5 | Git | ✅ Godot `.gitignore`, `original/` ignored |

### Phase 1 — Core Engine ✅
| Step | What | Status |
|------|------|--------|
| 1.1 | Game loop | ✅ `GameLoop.cs` |
| 1.2 | State manager | ✅ `StateManager.cs`, `GameMode` enum |
| 1.3 | Input handler | ✅ `InputHandler.cs` (WASD, SPACE, F-keys) |
| 1.4 | EGA palette | ✅ `EgaPalette.cs` |
| 1.5 | Border compositing | ✅ `BorderPanel.cs` + `ViewportManager.cs` |
| 1.6 | Save/Load | 🟡 `SaveManager.cs` — partial parser, round-trip unverified |

### Phase 2 — Maps & Navigation ✅
| Step | What | Status |
|------|------|--------|
| 2.1 | Tile system | ✅ `TileManager.cs`, ICN 16×16 |
| 2.2 | Map loader | ✅ `MapLoader.cs` |
| 2.3 | World map | ✅ `WorldMapView.cs`, 64×64 buffer |
| 2.4 | Local map | ✅ `LocalMapView.cs`, MAP1–14 |
| 2.5 | Cursor movement | ✅ `MapCursor.cs`, tile collision |
| 2.6 | Location→BLD | ✅ `LocationMapper.cs` |
| 2.7 | Visibility | ✅ 128×128 bitfield in `GameState` |
| 2.8 | Transitions | ✅ WorldMap ↔ LocalMap ↔ BLD interior |

### Phase 3 — BLD Interpreter ✅
| Step | What | Status |
|------|------|--------|
| 3.1 | BLD loader | ✅ `BldLoader.cs`, decrypt from 0xA0 |
| 3.2 | Cipher decoder | ✅ `CipherDecoder.cs` |
| 3.3 | Opcode dispatch | ✅ 26 opcodes in `BldInterpreter.cs` |
| 3.4 | Narrative markers | ✅ 9E/9C/9B/9F/A5 |
| 3.5 | Dialogue UI | ✅ `DialogueBox.cs` |
| 3.6 | fn1CD3_0004 | ✅ all 47 cases in `Fn1CD3Dispatcher.cs` |
| 3.7 | Conditionals | ✅ RNG, cursor, state, credits |
| 3.8 | Shop system | ✅ `ShopScreen.cs`, `ShopRegistry.cs` |
| 3.9 | Room handlers | ✅ cases 0x21/0x22 push/pop state |
| 3.10 | 26 BLD files | ✅ wired via LocationMapper + tile select |

### Phase 4 — Combat System ✅
| Step | What | Status |
|------|------|--------|
| 4.1 | Combat init | ✅ `CombatManager.StartCombat()` |
| 4.2 | Turn order | ✅ 24 slots in `CombatState.cs` |
| 4.3 | Movement | ✅ approach + collision + fog |
| 4.4 | Targeting | ✅ Bresenham LoS in `CombatResolver.cs` |
| 4.5 | To-hit formula | ✅ 2D6 + modifiers |
| 4.6 | Damage | ✅ hit location, crits, cluster, ammo |
| 4.7 | AI system | ✅ `AiController.cs` |
| 4.8 | Fog of War | ✅ twin 12×24 grids |
| 4.9 | Heat system | ✅ pool, penalty, dissipation |
| 4.10 | Ammo | ✅ 10 bins, LRM/SRM per-missile |
| 4.11 | Combat UI | ✅ `CombatView.cs`, `CombatHUD.cs` |
| 4.12 | Post-combat | ✅ story update, mode restore |

### Phase 5 — Economy, Inventory & ANM 🔄
| Step | What | Status |
|------|------|--------|
| 5.1 | C-Bills | ✅ `GameState.Credits` (32-bit) |
| 5.2 | Shop data | ✅ C618 slots via dispatcher |
| 5.3 | Inventory | ✅ StateArray + shop strategies |
| 5.4 | Buy/sell | ✅ single/bulk in dispatcher |
| 5.5 | Hospital | ✅ case 0x09, 50 cr |
| 5.6 | Garage | ✅ case 0x18, 100 cr service |
| 5.7 | Tech screen | ⬜ not implemented |
| 5.8 | Stock market | ◐ RE + cases 0x2A/0x2B done; Godot UI ⬜ |
| 5.9 | Equipment mgmt | 🟡 cases 0x0D–0x18 in dispatcher, minimal UI |
| 5.10 | ANM decompress | ✅ `RleDecompressor.DecompressAnimationFrames` |
| 5.11 | AnmPlayer | ✅ runtime ANM + PNG fallback |
| 5.12 | BldAnmMap | ✅ building → O0–O15 in `GameLoop.cs` |
| 5.13 | Hover dispatch | ✅ `DispatchCursorMove()` + `AnimationDispatchTable` (building-name hover; ANM playback stub) |
| 5.14 | Combat mech ANM | ✅ left panel in combat |
| 5.15 | Cursor ANM | ✅ replaces blink timer |

### Phase 6 — Integration & Testing ⬜
| Step | What | Status |
|------|------|--------|
| 6.1 | Training sequence | ⬜ TRAINING.BLD → attack → bD450 |
| 6.2 | Story state machine | 🟡 implemented, not playtested E2E |
| 6.3 | Citadel attack | ⬜ property 0x1F → b0057 |
| 6.4 | Random encounters | 🟡 logic in CombatManager, to validate |
| 6.5 | Arena | ⬜ ARENA.BLD |
| 6.6 | Full playthrough | ⬜ NewGame → WINSCENE |
| 6.7 | Save/Load round-trip | ⬜ verify against original saves |

### Phase 7 — Polish ⬜
| Step | What | Status |
|------|------|--------|
| 7.1 | Startup sequence | 🟡 `StartupSequence.cs` scaffold |
| 7.2 | BTSTATS equipment | ⬜ |
| 7.3 | ENDMECH finale | ⬜ |
| 7.4 | TINYLAND mini-map | ⬜ |
| 7.5 | Sound | ⬜ |
| 7.6 | Combat VFX | ⬜ |
| 7.7 | Keyboard help | ⬜ |
| 7.8 | Packaging / 320×200 scaling | ⬜ |

## Project structure (current)

```
BattleTechCHI/
├── project.godot
├── run.sh / build.sh
├── Assets/
│   ├── Animations/       # extracted PNG spritesheets + runtime ANM
│   └── ...
├── Scripts/
│   ├── Core/             # GameLoop, StateManager, InputHandler, SaveManager
│   ├── Maps/             # MapLoader, TileManager, WorldMapView, LocalMapView,
│   │                     # LocationMapper, DispatchTables, RleDecompressor
│   ├── BLD/              # BldLoader, BldInterpreter, Fn1CD3Dispatcher
│   ├── Combat/           # CombatManager, CombatResolver, AiController, views
│   ├── UI/               # BorderPanel, AnmPlayer, ViewportManager, ShopScreen,
│   │                     # DialogueBox, StartupSequence, EgaPalette
│   └── Data/             # GameState, CipherDecoder, WeaponData, ShopRegistry
├── Runner/               # Console test harness (standalone)
└── Scenes/               # Main.tscn, etc.
```

## Key principles

1. **Data-driven** — maps from .MTP, dialogue from .BLD, animations from .ANM
2. **The BLD interpreter is the game engine** — implemented and working
3. **Original files at runtime** — decrypt BLD and decompress ANM from `original/`
4. **Next focus** — Godot stock UI, combat ANM polish, playtest training → endgame
