# Rebuild Progress — Godot 4 + C#

> Canonical rebuild progress/status. For the plan and gates see `docs/rebuild/roadmap.md`.

> ⚠️ **HONESTY BANNER (2026-09-28).** The status below describes **code present in the tree**, not
> **verified behaviour**. The rebuild *reads original data files* but *re-implements* engine logic
> (BLD interpreter, dispatch, combat); it has **never been validated end-to-end** against the
> original. Combat, viewport and parts of the story state are approximations; unknown BLD opcodes are
> silently skipped; `Assets/Tilesets|Animations|Fonts` are empty. `README.md` §2 (status matrix) and
> §4 (known unknowns) are the authoritative honesty baseline. A "✅" here means **implemented,
> unverified**, unless a verification artifact is linked.

The old Java/Swing prototype was **deleted** — it was a hardcoded dead end. The active rebuild is
`BattleTechCHI/`, a Godot 4 + C# project (~4.9k lines, ~45 scripts under `Scripts/`).

---

## Honest status matrix

Legend: **✅** verified · **⚠️** partial/approximate/silent gaps · **❓** unknown/unverified · **❌** absent

| System | Reads originals | Behaviour matches original | Validation |
|---|---|---|---|
| BLD decrypt + cipher text | ✅ | ✅ (text) | ✅ BLD↔JSON round-trip byte-identical |
| BLD opcode interpreter (26 ops) | ✅ | ⚠️ unknown opcodes skipped | ❓ no E2E playthrough |
| `Fn1CD3` dispatch (47 cases) | ✅ | ⚠️ some cases approximate | ❓ |
| MTP map parse | ✅ | ✅ structure | ⚠️ not frame-diffed |
| ANM animation decode | ✅ runtime (PNG fallback) | ⚠️ | ❓; repo has **no ANM sheets** |
| ICN/CMP tiles | ❌ pre-converted BMP | — | `Assets/Tilesets/` empty |
| Save `GAME1–6` (4096 B) | ✅ parser | ❓ | ❌ round-trip not verified |
| Story state (`b0057` et al.) | ✅ reads | ❓ inferred | ❓ |
| Combat (to-hit, damage, AI, heat, ammo, fog) | — own logic | ❌ approximate | ❌ never diffed |
| Viewport / screen layout | — | ⚠️ approximate | ❓ no canonical struct |
| Sound / music | ❌ | ❌ | ❌ format undecoded |
| Map→BLD trigger mapping | ⚠️ partial | ❓ | trigger table not decoded |

---

## Implemented but unverified (do not over-claim)

- **Core**: game loop, 3-layer state machine, input, EGA palette, `StateManager`.
- **Maps**: `MapLoader` (MTP), `WorldMapView`/`LocalMapView`, `MapCursor`, `LocationMapper`,
  `DispatchTables`, fog/visibility — load real `.MTP`.
- **BLD**: `BldLoader` (runtime decrypt from 0xA0), `BldInterpreter` (26 opcodes),
  `Fn1CD3Dispatcher` (47 cases), `CipherDecoder`, `DialogueBox`, `ShopScreen`, `ShopRegistry`.
- **Combat**: `CombatManager` (12-phase loop), `CombatResolver`, `AiController`, `CombatState`,
  `CombatView`, `CombatHUD`, `MechPortrait` — **re-implementation, not a verified port**.
- **UI**: `ViewportManager`/`ViewportRegion`, `AnmPlayer` (runtime ANM + PNG fallback), `BorderPanel`,
  `StartupSequence`, `StatsScreen`.
- **Data**: `GameState`, `WeaponData`, `ShopRegistry`, `SaveManager` (4096-byte parser).

## Verified so far

- BLD ↔ JSON round-trip is byte-identical (`tools/bld/bld_json_converter.py`).
- Live emulator traces confirmed: game-state segment `0x2A0F`, combat segment `0x2A0F`,
  viewport tables at `0x3858`, input model (arrow keys; tile-triggered building entry), ComStar
  location/flow, cadet allowance behaviour.
- (These are **RE/runtime** verifications; they do **not** yet verify the Godot implementation.)

## Not implemented / not present

- Stock-market Godot UI (dispatcher cases 0x2A/0x2B exist).
- Tech / `BTSTATS` screen; full equipment management UI.
- Endgame `WINSCENE` / `ENDMECH` / `TINYLAND`.
- Sound/music; combat VFX.
- Tilesets, animations and fonts as assets (`Assets/Tilesets|Animations|Fonts` empty).
- End-to-end playtest and differential parity harness (`track 3`).

## Current focus

Close the RE blockers B1–B11 (`docs/rebuild/roadmap.md` §2), then build the **differential-validation
harness** (Track 3) before any feature polish.

---

## Project structure (current)

```
BattleTechCHI/
├── project.godot
├── run.sh / build.sh
├── Assets/                  # 15 map PNGs, 44 mech sprites, 9 screens; tilesets/ANM/fonts EMPTY
├── Scripts/
│   ├── Core/                # GameLoop, StateManager, InputHandler, SaveManager
│   ├── Data/                # GameState, CipherDecoder, WeaponData, ShopRegistry, DataModels
│   ├── Maps/                # MapLoader, TileManager, WorldMapView, LocalMapView,
│   │                        # LocationMapper, DispatchTables, RleDecompressor, MapCursor
│   ├── BLD/                 # BldLoader, BldInterpreter, Fn1CD3Dispatcher
│   ├── Combat/              # CombatManager, CombatResolver, AiController, views, MechPortrait
│   └── UI/                  # ViewportManager, BorderPanel, AnmPlayer, ShopScreen,
│                            # DialogueBox, StartupSequence, EgaPalette, StatsScreen
├── Runner/                  # Console test harness (standalone)
└── Scenes/                  # Main.tscn
```

Data-driven principle (intended): maps from `.MTP`, dialogue from `.BLD`, animations from `.ANM`,
saves from `GAME*` — all decrypted/decompressed from `original/` at runtime. **Status: partially true**
(BLD/MTP yes; ICN/CMP pre-converted; ANM falls back to missing PNGs).
