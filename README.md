# UnBattletech

Reverse engineering of **BattleTech: The Crescent Hawk's Inception** (1988, MS-DOS; published by
Infocom, engine by **Westwood Associates**) — and an in-progress **Godot 4 / C# recreation** of it.

> **Read this section before trusting anything else in this repo.**
> The project is two efforts with very different maturity, and the word "phase" elsewhere in the
> docs means *code written*, **not** *behaviour proven*.

---

## 1. Two deliverables, built in parallel

This project produces **two artifacts at the same time**, and the second one *poses on* the first:

**(1) The documented reverse engineering.** The `reko/` decompilation, `docs/` specifications, the
Spice86 emulator with BattleTech-specific MCP tools, and the Python tooling. This is the real RE work:
file formats, story text, memory map, and a large part of engine logic are documented and
cross-checked against decompiler output and live emulator traces. It is a deliverable **in its own
right**, and it is also the **specification** for (2).

**(2) The recreation (`BattleTechCHI/`).** A Godot 4 C# program that **derives from (1)**: it reads
original data files (`.BLD`, `.MTP`, `.ANM`, `GAME*` saves) and re-implements the engine behaviour
*as documented by (1)*. It is **data-faithful, not behaviour-faithful**, and has **never been
validated end-to-end** against the original.

They run **in parallel**, but the dependency direction is fixed:

> **(2) can only be as faithful as (1) is complete and verified.**
> Where (1) says *inferred* or *open*, (2) is a guess.

That is why the roadmap puts closing the RE gaps (Track 1) and **differential validation of (2)
against the emulator (Track 3)** ahead of feature work. A recreation is only as good as the
reverse engineering that poses it.

If you are looking for a bit-exact port, it does not exist yet. If you are looking for a tool-assisted
RE environment plus a data-driven reconstruction that runs on original assets, that is what is here.

---

## 2. Honest status matrix

Legend: **✅** true / done · **⚠️** partial, approximate, or with silent gaps · **❓** unknown / unverified · **❌** absent

| System | Reads original files at runtime | Behaviour matches the original | Validation |
|---|---|---|---|
| BLD decrypt + cipher text | ✅ `BldLoader.cs` | ✅ (text) | ✅ round-trip BLD↔JSON byte-identical (`tools/bld`) |
| BLD opcode interpreter (26 ops) | ✅ | ⚠️ partial | ❓ never played end-to-end; **unknown opcodes are logged and skipped** |
| `Fn1CD3` dispatch (47 cases) | ✅ | ⚠️ partial | ❓ implemented from decomp; several cases are approximations |
| MTP map header/tiles | ✅ `MapLoader.cs` / `LocalMapView.cs` | ✅ (structure) | ⚠️ layout decoded, not diffed frame-by-frame |
| ANM animation (XOR-delta RLE) | ✅ runtime, PNG fallback | ⚠️ | ❓; **repo has no ANM spritesheets** (`Assets/Animations/` empty) |
| ICN/CMP tiles | ❌ (pre-converted) | — | `TileManager` loads BMP; **`Assets/Tilesets/` empty** |
| Save files `GAME1–6` (4096 B) | ✅ parser `SaveManager.cs` | ❓ | ❌ round-trip **not** verified against original saves |
| Story state (`b0057`, props) | ✅ (reads) | ❓ meaning **inferred** | ❓ semantics not confirmed in play |
| Combat (to-hit, damage, AI, heat, ammo, fog) | — (own logic) | ❌ approximate | ❌ RNG/formulas **never diffed** against the original |
| Viewport / screen layout | — | ⚠️ approximate | ❓ no canonical viewport struct located |
| Sound / music | ❌ | ❌ | ❌ format undecoded |
| Map→BLD trigger mapping | ⚠️ partial | ❓ | tile-property table + `[0x5460]:0x4602` translation **not decoded** |

### What the rebuild can do today
- Boot the title/startup sequence and the local-map + world-map views.
- Load and decrypt the real `.BLD` scripts and interpret them (dialogue, menus, shops, many dispatch
  cases) — with silent gaps on unimplemented opcodes.
- Parse the real `.MTP` maps, and read/write the real 4096-byte save layout.
- Run a from-scratch tactical combat loop (own RNG/LoS/to-hit/damage/AI).

### What it cannot do honestly claim
- That it reproduces the original's behaviour. Combat, viewport rendering, and parts of the story
  state machine are reconstructions, not verified ports.
- That it is self-contained visually: **tilesets, animations and fonts are not in the repo**
  (only 15 converted map PNGs and 44 mech-sprite PNGs are).

---

## 3. What is genuinely RE'd (and where)

| Area | State | Canonical doc |
|---|---|---|
| BLD format, cipher, opcodes | 🟢 solid | `docs/formats/bld-bytecode.md` |
| Story text (all 26 BLD) | 🟢 extracted | `docs/story/STORY_TEXT.txt` |
| Memory map (100+ addresses, segments) | 🟢 solid | `docs/formats/memory-map.md` |
| World map / local maps | 🟢 solid | `docs/world-map.md` |
| Combat model | 🟡 ~90%, some inferred | `docs/combat-system.md` |
| Economy / shops / stock | 🟡 UI flow now observed live | `docs/story/story-system.md` |
| ANM format | 🟢 documented | `docs/formats/anm-format.md` |
| Viewport abstraction | 🔴 incomplete | `docs/engine/viewport.md` |
| Sound | 🔴 0% | — |

---

## 4. Known unknowns (the RE still to do)

These are the *real* blockers; the roadmap in §6 is gated on them.

1. **Byte-exact combat.** RNG, initiative/turn order, to-hit modifiers, hit-location table, cluster
   resolution, heat, ammo explosion, AI target selection — currently *inspired by* the disassembly,
   never diffed. (`docs/combat-system.md`)
2. **Not-decompiled segments.** Combat/movement code in segments `19EF` / `1000` is missing from the
   Reko output; those routines must be recovered. (`docs/UNVERIFIED_DISCOVERIES.md` §7)
3. **Story-state semantics.** `b0057` (0/1/2) and neighbours `b0055/b0056/b0058` are *inferred*;
   property IDs `0x1C–0x23` unmapped. (§5)
4. **Map→BLD trigger mapping.** Tile property table (`0x32C6`) + translation table
   (`[0x5460]:0x4602`) not decoded; entrances are currently found by hand-walking the map
   (Citadel `(34,10)`, ComStar `(51,10)` on the start map). (`docs/context.md`)
5. **Viewport model.** No canonical viewport struct found; the seg-`0x246C` config struct is only
   partly mapped; push/pop semantics unknown. (`docs/engine/viewport.md`)
6. **Tile properties / collision.** Which bits mean water/wall; which routine reads `0x32C6` for
   movement. (§2)
7. **Save format round-trip.** Parser exists; a real `GAME*` load→save→compare has not been done.
8. **Cadet economy & day cycle.** Allowance tick, stop threshold, barracks sleep, daily-mission gate
   — mechanic observed, **code not located**. (`docs/story/story-system.md`)
9. **BLD opcode gaps.** Which opcodes actually occur across the 26 files, and which the interpreter
   silently skips. (`BldInterpreter.cs` default branch)
10. **Sound/music format.** Entirely undecoded.
11. **World-map data location.** Where tile/map data is loaded from (segment `2A02` vs elsewhere). (§1)

---

## 5. Retro archaeology (outside the binary)

RE from the executable alone has limits (compiler-optimised code, absent segments, inferred
semantics). To understand *what is actually in the game* we cross-check several kinds of source —
none can *replace* the binary, but together they resolve intent and fill gaps:

- **Original documents** — the **manual**, the **clue/hint book**, and 1988–89 **magazine reviews**
  (design intent, terminology, intended UI). *Not yet acquired — an archaeology task.*
- **Personal playtesting** — the author's own sessions: what a player actually observes, and the best
  generator of hypotheses to verify in the emulator.
- **Published walkthroughs** — already used: `docs/walkthrough/bt-walkthrough-1..3.md` (navigation and
  event sequence).
- **Sibling Westwood engine titles** — *Mines of Titan* (1989, x86, already fingerprinted: 25 shared
  functions in graphics/text) and the later viewport engines (*Eye of the Beholder*, *Kyrandia*,
  *Lands of Lore*) for the viewport model.
- **Other BattleTech CHI ports/releases** — C64 / Apple II / Amiga (if any) and the later "Gold"
  editions; different compilers expose different structure.
- **Emulator tooling as ground truth** — Spice86 traces + the 23 `bt_*` MCP tools give exact
  runtime register/memory state to diff against.

**Precedence:** for *behaviour*, the binary/emulator wins; documents are authoritative for *intent*.
Every claim recovered from a document or from memory is **marked as sourced and re-verified against
the binary** before it enters the recreation. The full policy (source classes, evidence tags ✅/🟡/❓,
and the source→verified workflow) is in [`docs/SOURCES.md`](docs/SOURCES.md).

---

## 6. True roadmap (from here to a faithful Godot recreation)

The order is deliberate: **prove the data path and the behaviour before building more screens.**
Each gate is a *verification*, not a feature.

### Track 0 — Truth upkeep (continuous)
- Keep this README, `docs/rebuild/progress.md` and the wiki honest; mark every claim
  **verified / inferred / unknown** and date it.
- No new "✅" without a verification artifact (trace, diff, or byte-compare).

### Track 1 — Close the RE mysteries (§4, priority order)
1. Decompile/annotate segments `19EF`/`1000` (combat/movement). ← *unblocks 2*
2. Diff combat formulas/RNG against emulator traces (byte-exact tables). ← *unblocks Track 3*
3. Decode the map→BLD trigger table so entrances are data-driven, not hand-found.
4. Locate the cadet economy / day-cycle code.
5. Resolve viewport struct + `w4FBC`/push-pop; finish tile-property bits.
6. Verify save round-trip against real `GAME*` files.

### Track 2 — Make the data path faithful
- TileManager should decode **ICN/CMP at runtime** (no pre-baked BMP requirement); commit or
  regenerate tilesets/animations/fonts, or document the exact extraction step.
- ANM: eliminate the PNG fallback dependence; the runtime decoder is the single source of truth.
- Enumerate and implement every BLD opcode that actually occurs; fail loudly on unknown ones.

### Track 3 — Differential validation (the missing keystone)
- Build a harness that runs the **same scripted input** through (a) the Spice86 emulator and
  (b) the Godot rebuild, then compares: state array, story slots, credits, cursor, unit slots,
  combat grids, and rendered frames.
- First targets: a full training day (mission → sleep), a shop transaction, one combat encounter.
- A system is "done" only when the diff is empty for its scenario.

### Track 4 — Feature completion (only after Track 3 for each area)
- Stock market UI (dispatcher 0x2A/0x2B exist; UI pending).
- Tech/BTSTATS screen, full equipment management.
- Endgame: `WINSCENE` / `ENDMECH` / `TINYLAND`.
- Sound, if Track 1 decodes the format.

### Track 5 — Retro archaeology (parallel, feeds Track 1)
- Manual / clue book / magazine scans; sibling-game function map extension.

Detailed per-step checklists live in `docs/rebuild/roadmap.md`; the phase ledger is
`docs/rebuild/progress.md`.

---

## 7. Repository layout

```
docs/                 RE documentation (canonical doc per topic: docs/INDEX.md)
reko/                 Reko decompiler output (C + asm, per segment)
tools/
  bld/                BLD decode / JSON round-trip / story extraction
  assets/             Asset extraction & rendering
  analysis/           Binary & memory-dump analysis
  playtest/           bt.py — drive the emulator via MCP + memory API
BattleTechCHI/        Godot 4 + C# recreation (~4.9k lines, ~45 scripts)
  Scripts/{Core,Data,Maps,BLD,Combat,UI}
  Assets/             15 map PNGs, 44 mech sprites, 9 screens (tilesets/ANM/fonts EMPTY)
original/             Original game files (local only, gitignored)
BattleTechMcpTools/   Spice86 override supplier + 23 bt_* MCP tools
```

---

## 8. Running the pieces

```bash
# Emulator + MCP (ground truth for traces)
fuser -k 20000/tcp 8086/tcp 2>/dev/null
: > /tmp/emu.log
dotnet exec bin/Debug/net10.0/UNBATTLETECH.dll \
  --Exe "/path/to/UNBTECH.exe" --CDrive "/path/to/game/" \
  --HeadlessMode Minimal --McpHttpPort 8086 --NoGui

# Playtest harness
python3 tools/playtest/bt.py state      # mode/cursor/credits/flags snapshot
python3 tools/playtest/bt.py png out.png # true-colour screenshot

# Godot rebuild (needs a display; use xvfb-run headless)
cd BattleTechCHI && dotnet build && bash run.sh

# BLD round-trip / story extraction
python3 tools/bld/bld_json_converter.py to-json original/bld/
python3 tools/bld/extract_story.py
```

---

## 9. Disclaimer

This repository contains **no original game assets** (EXE, BLD, CMP, ICN, MTP, ANM, saves). Only
reverse-engineering analysis, documentation, and original source for a clean-room reconstruction are
included. The 69 PNGs under `BattleTechCHI/Assets/` are converted renders used for local development.
Original assets stay in `original/` (gitignored) and are required to run the loaders.
