# Piano di Rebuilding: BattleTech — The Crescent Hawk's Inception

**Engine:** Godot 4.4 (C#)  
**Repo:** `Reversing/AIATTEMPT`  
**Ultimo aggiornamento:** 2026-06-17  
**Stato RE:** 🟢 ~95% completo  
**Stato Engine:** 🟡 Phase 5 in corso (~7,800 linee C#, 42 file in `BattleTechCHI/Scripts/`)

---

## Stato Attuale

| Fase | Stato | Note |
|------|-------|------|
| 0 — Fondamenta | ✅ | Godot scaffold, data models, asset pipeline |
| 1 — Core Engine | ✅ | Game loop, state, input, palette, save parziale |
| 2 — Mappe | ✅ | MTP loader, world/local views, fog, LocationMapper |
| 3 — BLD Interpreter | ✅ | 26 opcode, 47-case dispatch, shops, dialogo |
| 4 — Combat | ✅ | Loop completo, AI, 2D6, LoS, fog, HUD |
| 5 — Economia + ANM | 🔄 | Shops ok; stock market no; ANM player shipped |
| 6 — Integrazione | ⬜ | Playtest end-to-end non validato |
| 7 — Polish | ⬜ | Startup scaffold; suoni/VFX/BTSTATS no |

---

## Perché Godot 4 + C# (scelta confermata)

1. **TileMap nativo** — mappe 16×16 via `TileMap` / `TileManager`
2. **C#** — struct weapon/mech e logica combat portata direttamente
3. **AnmPlayer custom** — decompressione runtime ANM + fallback PNG spritesheet
4. **Scenes** — GameLoop orchestra ViewportManager, BorderPanel, combat overlay
5. **Export** — Windows/Linux/macOS/Web
6. **Suoni** — ancora da implementare (formato originale non decodificato)

---

## Tabella di Marcia

### Fase 0 — Fondamenta ✅

| Step | Cosa | Stato |
|------|------|-------|
| 0.1 | Scaffolding Godot | ✅ `BattleTechCHI/`, Godot 4.4 + net8.0 |
| 0.2 | Data models | ✅ `DataModels.cs`, `GameState.cs`, `WeaponData.cs` |
| 0.3 | Asset pipeline | ✅ Caricamento .MTP/.BLD/.ICN/.ANM originali |
| 0.4 | BLD come JSON | ✅ `json/` + `bld_json_converter.py` |
| 0.5 | Git | ✅ `.gitignore` Godot, `original/` gitignored |

### Fase 1 — Core Engine ✅

| Step | Cosa | Stato |
|------|------|-------|
| 1.1 | Game loop | ✅ `GameLoop.cs` |
| 1.2 | State manager | ✅ `StateManager.cs`, `GameMode` enum |
| 1.3 | Input handler | ✅ `InputHandler.cs` (WASD, SPACE, F-keys) |
| 1.4 | Palette EGA | ✅ `EgaPalette.cs` |
| 1.5 | Border compositing | ✅ `BorderPanel.cs` + `ViewportManager.cs` |
| 1.6 | Save/Load | 🟡 `SaveManager.cs` — parser parziale, round-trip da verificare |

### Fase 2 — Mappe e Navigazione ✅

| Step | Cosa | Stato |
|------|------|-------|
| 2.1 | Tile system | ✅ `TileManager.cs`, ICN 16×16 |
| 2.2 | Map loader | ✅ `MapLoader.cs` |
| 2.3 | World map | ✅ `WorldMapView.cs`, buffer 64×64 |
| 2.4 | Local map | ✅ `LocalMapView.cs`, MAP1–14 |
| 2.5 | Cursor movement | ✅ `MapCursor.cs`, collisione tile |
| 2.6 | Location→BLD | ✅ `LocationMapper.cs` |
| 2.7 | Visibilità | ✅ Bitfield 128×128 in `GameState` |
| 2.8 | Transizioni | ✅ WorldMap ↔ LocalMap ↔ interno BLD |

### Fase 3 — BLD Interpreter ✅

| Step | Cosa | Stato |
|------|------|-------|
| 3.1 | BLD loader | ✅ `BldLoader.cs`, decrypt da offset 0xA0 |
| 3.2 | Cipher decoder | ✅ `CipherDecoder.cs` |
| 3.3 | Opcode dispatch | ✅ 26 opcode in `BldInterpreter.cs` |
| 3.4 | Narrative markers | ✅ 9E/9C/9B/9F/A5 |
| 3.5 | Dialogue UI | ✅ `DialogueBox.cs` |
| 3.6 | fn1CD3_0004 | ✅ Tutti 47 casi in `Fn1CD3Dispatcher.cs` |
| 3.7 | Condizionali | ✅ RNG, cursor, state, credits |
| 3.8 | Shop system | ✅ `ShopScreen.cs`, `ShopRegistry.cs` |
| 3.9 | Room handlers | ✅ Cases 0x21/0x22 push/pop state |
| 3.10 | 26 BLD file | ✅ Wiring via LocationMapper + tile select |

### Fase 4 — Combat System ✅

| Step | Cosa | Stato |
|------|------|-------|
| 4.1 | Combat init | ✅ `CombatManager.StartCombat()` |
| 4.2 | Turn order | ✅ 24 slot in `CombatState.cs` |
| 4.3 | Movimento | ✅ Approach + collision + fog |
| 4.4 | Targeting | ✅ LoS Bresenham in `CombatResolver.cs` |
| 4.5 | To-hit formula | ✅ 2D6 + modifiers |
| 4.6 | Damage | ✅ Hit location, crits, cluster, ammo |
| 4.7 | AI system | ✅ `AiController.cs` |
| 4.8 | Fog of War | ✅ Twin 12×24 grids |
| 4.9 | Heat system | ✅ Pool, penalty, dissipation |
| 4.10 | Ammo | ✅ 10 bins, LRM/SRM per-missile |
| 4.11 | Combat UI | ✅ `CombatView.cs`, `CombatHUD.cs` |
| 4.12 | Post-combat | ✅ Story update, mode restore |

### Fase 5 — Economia, Inventario e ANM 🔄

| Step | Cosa | Stato |
|------|------|-------|
| 5.1 | C-Bills | ✅ `GameState.Credits` (32-bit) |
| 5.2 | Shop data | ✅ C618 slots via dispatcher |
| 5.3 | Inventario | ✅ StateArray + shop strategies |
| 5.4 | Buy/sell | ✅ Single/bulk in dispatcher |
| 5.5 | Hospital | ✅ Case 0x09, costo 50cr |
| 5.6 | Garage | ✅ Case 0x18, service 100cr |
| 5.7 | Tech screen | ⬜ Non implementato |
| 5.8 | Stock Market | ⬜ DefHes/NasDiv/BakPhar non implementati |
| 5.9 | Equipment mgmt | 🟡 Cases 0x0D–0x18 nel dispatcher, UI minima |
| 5.10 | ANM decompress | ✅ `RleDecompressor.DecompressAnimationFrames` |
| 5.11 | AnmPlayer | ✅ Runtime ANM + PNG fallback |
| 5.12 | BldAnmMap | ✅ Building → O0–O15 in `GameLoop.cs` |
| 5.13 | Hover dispatch | ✅ `DispatchCursorMove()` + `AnimationDispatchTable` |
| 5.14 | Combat mech ANM | ⬜ Pannello sinistro in combattimento |
| 5.15 | Cursor ANM | ⬜ Sostituire blink timer |

### Fase 6 — Integrazione e Test ⬜

| Step | Cosa | Stato |
|------|------|-------|
| 6.1 | Training sequence | ⬜ TRAINING.BLD → attack → bD450 |
| 6.2 | Story state machine | 🟡 Implementato, non playtestato E2E |
| 6.3 | Citadel attack | ⬜ Property 0x1F → b0057 |
| 6.4 | Random encounters | 🟡 Logica in CombatManager, da validare |
| 6.5 | Arena | ⬜ ARENA.BLD |
| 6.6 | Full playthrough | ⬜ NewGame → WINSCENE |
| 6.7 | Save/Load round-trip | ⬜ Verifica contro save originali |

### Fase 7 — Polish ⬜

| Step | Cosa | Stato |
|------|------|-------|
| 7.1 | Startup sequence | 🟡 `StartupSequence.cs` scaffold |
| 7.2 | BTSTATS equipaggiamento | ⬜ |
| 7.3 | ENDMECH finale | ⬜ |
| 7.4 | TINYLAND mini-mappa | ⬜ |
| 7.5 | Suoni | ⬜ |
| 7.6 | Combat VFX | ⬜ |
| 7.7 | Keyboard help | ⬜ |
| 7.8 | Packaging / scaling 320×200 | ⬜ |

---

## Stima Rimanente

| Fase | Tempo stimato |
|------|---------------|
| 5 — Economia + ANM (restante) | 2–3 settimane |
| 6 — Integrazione | 2–3 settimane |
| 7 — Polish | 2–4 settimane |
| **Totale a MVP giocabile** | **~4–8 settimane** full-time |

Il collo di bottiglia attuale è **Phase 5** (stock market + ANM combattimento) seguito da **playtest end-to-end** (Phase 6).

---

## Struttura Progetto (attuale)

```
BattleTechCHI/
├── project.godot
├── run.sh / build.sh
├── Assets/
│   ├── Animations/       # PNG spritesheet estratti + runtime ANM
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

---

## Principi Chiave

1. **Data-driven** — mappe da .MTP, dialoghi da .BLD, animazioni da .ANM
2. **L'interprete BLD è il game engine** — implementato e funzionante
3. **File originali a runtime** — decrypt BLD e decompress ANM dal folder `original/`
4. **Prossimi focus** — stock market, ANM combattimento, playtest training → endgame
