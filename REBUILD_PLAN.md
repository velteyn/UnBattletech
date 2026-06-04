# Piano di Rebuilding: BattleTech — The Crescent Hawk's Inception

**Engine:** Godot 4 (C#)
**Repo:** `Reversing/AIATTEMPT`
**Stato RE:** 🟢 95% completo
**Stato Engine:** 🟡 Phase 0-1 (~1150 linee C#): scaffold, data models, loader, palette, game loop, input, save

---

## Perché Godot 4 + C#

1. **TileMap nativo** — le mappe del gioco sono tile-based 16×16, Godot le gestisce con 10 righe di codice
2. **AnimationPlayer** — le 22 animazioni ANM girano senza dover scrivere un player custom
3. **C#** — il tool di reverse (InceptionTools) è già in C#, porti le struct weapon/mech/mappa direttamente
4. **Scenes** — ogni edificio/location diventa una Godot Scene, wi-fi con BLD interpreter
5. **Dialog system** — Godot ha `DialogueManager`, ma per la fedeltà conviene l'interprete BLD custom
6. **Export** — Windows/Linux/macOS/Web gratis
7. **Suoni** — basta `AudioStreamPlayer` + qualche beep sintetizzato

---

## Tabella di Marcia

### Fase 0 — Fondamenta (1-2 settimane)

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 0.1 | Scaffolding Godot | `Godot 4` + `C#` + `.godotignore` |
| 0.2 | Data models | Portare da InceptionTools: Weapon, Mech, Item, MapHeader |
| 0.3 | Asset pipeline | Script C# che carica gli .MTP/.BLD originali (non i BMP) |
| 0.4 | Emettere i BLD come JSON | Usare `bld_json_converter.py` esistente |
| 0.5 | Git | `.gitignore` per Godot (`.godot/`, `*.csproj.user`, `mono_crash.*`) |

### Fase 1 — Core Engine (2-3 settimane)

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 1.1 | Game loop | Init → Input → Update → Render (match originale 6-fase) |
| 1.2 | State manager | `w4FBA` mode: 0=WorldMap, 1=LocalTiles, 2=Combat, 3=Text, 4=BuildingName |
| 1.3 | Input handler | WASD (ri-mappato dai tasti freccia originali), SPACE=menu, F1-F10 |
| 1.4 | Palette EGA | 16-colori, swap per asset (BTTITLE palette ≠ INFOCOM palette) |
| 1.5 | Border compositing | Pannello sinistro 80px + viewport centrale + informativa (simile al layout originale) |
| 1.6 | Save/Load | Formato binario del gioco originale, scrittura/lettura round-trip |

### Fase 2 — Mappe e Navigazione (2-3 settimane)

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 2.1 | Tile system | Caricare tileset da .ICN, tile ID 16×16, palette EGA |
| 2.2 | Map loader | Reader MTP: header 3 byte + MapSizeX/Y + 128 byte NPC names + 256 byte building names + tile data |
| 2.3 | World map | Mappa 1024×1024 (generata o compressa?), tile grid 13×12 visibile |
| 2.4 | Local map | MAP1-14 con viewport scrollabile |
| 2.5 | Cursor movement | `fn207F_18EF`: collisione tile, costo movimento |
| 2.6 | Location→BLD mapping | Tabella a 22 entry a `0x4602` |
| 2.7 | Visibilità | Bitfield 128×128 (2048 byte) per world map fog of war |
| 2.8 | Transizioni | WorldMap ↔ LocalMap ↔ Interno (cambio BLD) |

### Fase 3 — BLD Interpreter (4-6 settimane) ← IL PEZZO GROSSO

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 3.1 | BLD loader | Legge file .BLD, decripta (XOR 0xE9, add 0x29) da offset 0xA0 |
| 3.2 | Cipher decoder | Tabella di sostituzione completa (0x57-0x96 → lettere) |
| 3.3 | Opcode dispatch | 26 opcode: 0xE4 (WRITE_CHAR) a 0xFF (STOP_INTERPRETER) |
| 3.4 | Narrative markers | `9E`=terza persona, `9C`=dialogo, `9B`=pensiero, `9F`=azione player, `A5`=continuazione |
| 3.5 | Dialogue UI | Box testo con word-wrapping, margini, attesa input |
| 3.6 | `fn1CD3_0004` dispatch | 47 casi: ENTER_BUILDING, SHOW_GREETING, BUY, SELL, COMBAT, HEAL, FLAG, PARTY... |
| 3.7 | Condizionali | RNG check, cursor compare, state compare, credit check |
| 3.8 | Shop system | 4 modalità: display/buy/sell/heal |
| 3.9 | Room handlers | `fn11B8_0D58` dispatch |
| 3.10 | 26 BLD file | Training → Citadel → Barracks → ComStar → Garage → ... fino a WINSCENE |

### Fase 4 — Combat System (3-4 settimane)

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 4.1 | Combat init | `fn183B_000A`: popola nemici, azzera fog grid |
| 4.2 | Turn order | 24 slot: 4 player mech + 8 fanteria nemica + 12 mech nemici |
| 4.3 | Movimento | 8 direzioni, tile cost, skill-gated LoS |
| 4.4 | Targeting | Weapon range, LoS ray-cast (8-dir vettori), fog check |
| 4.5 | To-hit formula | 2D6 + skill + terrain + heat + story state modifiers |
| 4.6 | Damage | Hit location, criticals, heat generation |
| 4.7 | AI system | Tabella preferenze target, stage counter dispatch |
| 4.8 | Fog of War | Twin 12×24 grid, LoS clearing |
| 4.9 | Heat system | Weapon heat → pool → penalty → cap 30 |
| 4.10 | Ammo | 10 bins per mech, per-missile per LRM/SRM |
| 4.11 | VFX | Impatto EGA (sprite explosion, fire small/big, wreck) |
| 4.12 | Post-combat | cleanup, story state update, w4FBA=3 |

### Fase 5 — Economia e Inventario (1-2 settimane)

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 5.1 | C-Bills | 32-bit `dwD370` |
| 5.2 | Shop data | `C618[3]` display slots, `bD314` selection |
| 5.3 | Player inventory | `aD374[]` quantità (uint32), `aD376[]` data (uint16) |
| 5.4 | Buy/sell | Single = type×125+75, bulk = 1 cr/unit |
| 5.5 | Hospital | Cost table a `0x4F26`/`0x4F28` |
| 5.6 | Garage | Cost table a `0x4F6E` |
| 5.7 | Tech screen | 7 slot component repair |
| 5.8 | Stock Market | DefHes, NasDiv, BakPhar tickers, `bD323` economy tick |
| 5.9 | Equipment mgmt | `fn1CD3_0004` cases 0x0D-0x18 |

### Fase 6 — Animazioni (1-2 settimane)

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 6.1 | ANM format | Header 0x33 byte, RLE decompress, EGA planar → frames |
| 6.2 | AnimationPlayer | Caricare frame BMP come sprite sheet, definire animation clip |
| 6.3 | ANM index | o0-o21 mappate a contesti: idle mech, camminata, combattimento |
| 6.4 | Left panel anim | Animazione corrente nel pannello laterale |
| 6.5 | Combat VFX | Frame di fuoco/explosion sovrapposti al campo |

### Fase 7 — Storia e Integrazione (2-3 settimane)

| Step | Cosa | Dettaglio |
|------|------|-----------|
| 7.1 | Training sequence | TRAINING.BLD end-to-end → citadel attack → bD450 |
| 7.2 | Story state machine | 3-layer: D30C[256] + story properties + bD450/bD451 |
| 7.3 | Citadel attack | Property 0x1F → b0057 0→1→2, world changes |
| 7.4 | Random encounters | RNG + bD330 mask, 3 mech templates |
| 7.5 | Arena | ARENA.BLD |
| 7.6 | Full playthrough | NewGame → WINSCENE |
| 7.7 | Save/Load round-trip | Verifica contro save originali |

### Fase 8 — Polish (2-3 settimane)

| Step | Cosa |
|------|------|
| 8.1 | Startup sequence (INFOCOM + BTTITLE splash) |
| 8.2 | Schermo equipaggiamento (BTSTATS) |
| 8.3 | Schermata finale (ENDMECH) |
| 8.4 | Mini-mappa (TINYLAND) |
| 8.5 | Suoni (beep PC speaker sintetizzati) |
| 8.6 | Keyboard shortcut help |
| 8.7 | Packaging per distribuzione |
| 8.8 | Window scaling (viewport EGA 320×200 → finestra moderna) |

---

## Stima Totale

| Fase | Tempo |
|------|-------|
| 0 — Fondamenta | 1-2 settimane |
| 1 — Core Engine | 2-3 settimane |
| 2 — Mappe | 2-3 settimane |
| 3 — BLD Interpreter | 4-6 settimane |
| 4 — Combat | 3-4 settimane |
| 5 — Economia | 1-2 settimane |
| 6 — Animazioni | 1-2 settimane |
| 7 — Integrazione Storia | 2-3 settimane |
| 8 — Polish | 2-3 settimane |
| **Totale** | **~18-28 settimane** |

Il collo di bottiglia è la **Fase 3 (BLD Interpreter)** — da iniziare il prima possibile.

---

## Struttura Progetto Godot Suggerita

```
BattleTechCHI/
├── project.godot
├── .godotignore
├── Assets/
│   ├── Animations/       # BMP frame estratti
│   ├── Maps/              # BMP mappe renderizzate
│   ├── Sprites/           # 376 sprite BMP
│   ├── Tilesets/          # tileset BMP
│   └── Fonts/             # font EGA-style
├── Data/
│   ├── Weapons.json       # dati armi dal C#
│   ├── Mechs.json         # dati mech dal C#
│   └── BLD/               # 26 BLD convertiti in JSON
├── Scripts/
│   ├── Core/              # GameLoop, StateManager, InputHandler
│   ├── Maps/              # MapLoader, TileRenderer, Viewport
│   ├── BLD/               # BldInterpreter, fn1CD3_dispatch
│   ├── Combat/            # CombatSystem, AI, Targeting
│   ├── UI/                # DialogueBox, ShopScreen, TechScreen
│   └── Data/              # WeaponDb, MechDb, SaveManager
└── Scenes/
    ├── Main.tscn
    ├── WorldMap.tscn
    ├── LocalMap.tscn
    ├── Combat.tscn
    └── UI/
        ├── DialogueBox.tscn
        ├── ShopScreen.tscn
        ├── TechScreen.tscn
        └── StartupSequence.tscn
```

---

## Principi Chiave

1. **Data-driven** — niente hardcode. Mappe da .MTP, dialoghi da .BLD, armi/mech da tabelle dati
2. **L'interprete BLD è il game engine** — 60% del gioco gira lì dentro. Fallo bene.
3. **Usa i JSON pre-convertiti** — non serve ricaricare i file .BLD originali e decriptarli a runtime (ma tieni la possibilità per fedeltà)
4. **Prima la Fase 3** — appena hai il core engine funzionante, attacca l'interprete BLD. Tutto il resto (combat, economia, story) è guidato dai BLD