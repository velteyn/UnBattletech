# Rebuild Roadmap: BattleTech — The Crescent Hawk's Inception

**Last updated:** 2026-06-17  
**Engine:** Godot 4.4 + C# (`BattleTechCHI/`)  
**RE status:** ~95% complete  
**Rebuild status:** Phase 5 in progress (~7,800 lines C# across 42 script files)

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
| Combat | Full 12-phase loop, AI, 2D6, LoS, fog, HUD | `Combat/*.cs` (6 files) |
| Viewport layout | ViewportManager, regions, EGA borders | `UI/ViewportManager.cs`, `ViewportRegion.cs` |
| ANM animations | Runtime decompress + PNG fallback, BldAnmMap | `UI/AnmPlayer.cs`, `Maps/RleDecompressor.cs` |
| Startup | INFOCOM + BTTITLE splash sequence | `UI/StartupSequence.cs` |
| Test runner | Standalone console harness (not Godot build) | `Runner/Program.cs` |

### What remains

| System | Status | Effort |
|--------|--------|--------|
| Stock market (DefHes, NasDiv, BakPhar) | ❌ Not implemented | Medium |
| Tech screen / component repair | ❌ Not implemented | Medium |
| Full equipment management UI | ⚠️ Dispatcher cases exist, UI thin | Medium |
| Save/load round-trip verification | ⚠️ Parser exists, not fully verified | Small |
| Combat mech panel ANM | ❌ Not wired | Medium |
| Map cursor ANM (replace blink) | ❌ Not wired | Small |
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
├── Animation dispatch on cursor hover (DispatchCursorMove) ✅
├── Stock market (DefHes, NasDiv, BakPhar, bD323 ticker) ⬜
├── Tech screen (component repair, 7 item slots) ⬜
├── Full equipment management UI ⬜
├── Combat mech panel ANM (idle/move/fire/damage) ⬜
└── Map cursor ANM (replace blink timer) ⬜

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
| Economy / shops | 🟢 100% documented | 🟡 Shops work; stock market missing |
| Save format | 🟢 100% | 🟡 Parser exists; round-trip unverified |
| Animations (ANM) | 🟢 100% format | 🟡 Player + building ANM; combat cursor pending |
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
