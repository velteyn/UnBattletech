# True Roadmap — from current state to a faithful Godot recreation

> **Honesty rule for this document.** A step is only marked done when there is a *verification
> artifact*: an emulator trace, a byte-diff, or a side-by-side render. "Code written" ≠ "done".
> Anything inferred is marked **inferred**; anything unknown is marked **open**.
>
> Companion docs: `README.md` (§2 status matrix, §4 unknowns), `docs/rebuild/progress.md`.

This roadmap drives **two parallel deliverables**: **(1) the documented RE** and **(2) the recreation
that poses on (1)**. The dependency is one-way — (2) can only be as faithful as (1) is complete and
verified — so the RE-closing tracks below come first.

---

## 0. Definition of "faithful recreation"

The target is **not** "a game that plays like BattleTech CHI". The target is a Godot program that:

1. **Consumes the original data** — `.BLD`, `.MTP`, `.ICN`/`.CMP`, `.ANM`, `GAME*` saves — as the
   single source of truth (no pre-baked stand-ins required to run).
2. **Reproduces original behaviour** — given the same inputs and starting state, it produces the same
   game state and (within rendering tolerance) the same frames as the 1988 executable.
3. **Is proven by differential testing** against the Spice86 emulator running the real `UNBTECH.exe`.

Everything below is ordered to reach (1) and (3) **before** expanding features.

---

## 1. Honest baseline (2026-09-28)

**Solid (RE + docs):** BLD format/cipher/opcodes, full story text, memory map, world/local map
formats, ANM format, shop/economy data structures, the emulator + MCP tooling.

**Partial / approximate (do not trust as faithful):**
- Combat (RNG, turn order, to-hit, damage, AI) — reconstruction, never diffed.
- `Fn1CD3` dispatch — implemented from decomp; several cases approximate.
- BLD interpreter — 28 opcode slots (0xE4–0xFF; 27 present in corpus). All slots are handled (the
  C# `default` is unreachable in range), so there is no silent opcode drop; unmapped bytes `< 0xE4`
  are structural markers, skipped by design. See [`../formats/bld-opcode-coverage.md`](../formats/bld-opcode-coverage.md).
- Viewport/screen layout — no canonical viewport struct located.
- Story-state semantics (`b0057` et al.) — inferred.
- Save parser — exists; round-trip unverified.

**Absent:**
- Sound/music (format undecoded).
- Tilesets / animations / fonts as assets in the repo (`Assets/Tilesets|Animations|Fonts` empty).
- End-to-end playtest (never run NewGame → WINSCENE).
- Not-decompiled segments (`19EF`, `1000`) holding combat/movement code.

---

## 2. The blockers (RE mysteries + retro archaeology)

Ordered by dependency, not by ease.

| # | Blocker | Why it blocks | Kind |
|---|---------|---------------|------|
| ~~B1~~ ✅ | Segments `19EF`/`1000` — **decompiled + function-mapped**, and **freshly regenerated with current Spice86** (`reko/gencode-current/`, `dumpall` + `-u false`) (2026-09-28, [`../engine/segments-19ef-1000.md`](../engine/segments-19ef-1000.md)) | Combat/movement source available; formulas still to re-verify (feeds B2) | RE |
| ~B2~ ◐ | Combat formulas — **all core formulas re-verified against the decompilation (2026-09-28)**: to-hit, heat gen + dissipation, ammo, RNG LFSR, hit-location, cluster grouping, damage slot-advance, AI targeting (see [`../combat-system.md`](../combat-system.md) "B2 verification"). Remaining: damage-overflow internals + a full **differential** test vs the emulator | Spec is code-verified, not yet diffed | RE + validation |
| ~~B3~~ ✅ | Map→BLD trigger table — **DECODED 2026-09-28** (`[0x53CA]:0x4564`/`[0x53CC]:0x4596` building positions → slot → `[0x5460]:0x4602` → building index → MTP name → BLD); see [`../formats/map-bld-triggers.md`](../formats/map-bld-triggers.md) | Entrances are now data-driven | RE |
| ~~B4~~ ✅ | Story-state semantics — **DECODED 2026-09-28** (`fn1631_11AB`): `b0057` prop `0x1F` d6{2,5} ++cap2; `b0058` latch 0→0xFF; `b0055`/`b0056` prop `0x20` ++cap3/2; on cap `b0000=0`, `wE484=1`; props `0x1C–0x23` = nibble skill/inventory flags. See [`../story/story-system.md`](../story/story-system.md) §17.5 | Plot gating mechanics confirmed | RE |
| B5 | Viewport struct / `w4FBC` / push-pop unknown | Rendering can't be made faithful | RE |
| ~~B6~~ ✅ | Tile properties — **DECODED 2026-09-28**: no bit flags; passability = `property < per-scene gate t0150` (reader `fn1631_0006`; gate set by `fn135D` to `0x21`/`0x8B`). See [`../world-map.md`](../world-map.md) §7a | Collision/terrain understood | RE |
| B7 | Save round-trip unverified | Load/save fidelity unknown | validation |
| B8 | Unknown BLD opcodes skipped | Silent story failures | RE |
| B9 | Sound format undecoded | Missing feature | RE |
| B10 | Cadet economy / day-cycle code not located | Early-game loop wrong | RE |
| B11 | Design intent gaps (endgame gating, day counts) | Ambiguity | retro-archaeology |

**Retro archaeology (feeds B4, B11, B5):** sibling Westwood titles (*Mines of Titan* already
fingerprinted — 25 shared graphics/text functions; *Eye of the Beholder* / *Kyrandia* / *Lands of
Lore* for the viewport model), other-platform ports / "Gold" editions, the original manual, clue book,
and 1988–89 magazine coverage. All archaeology findings must be re-verified against the binary and
cited.

---

## 3. Roadmap

Each track has **gates**. A later track may not be marked done for an area until its gate passes.

### Track 0 — Truth upkeep (continuous)
- Every doc claim tagged **verified / inferred / open**, with date + evidence pointer.
- `README.md` §2 and `docs/rebuild/progress.md` updated in the same commit as any status change.
- CI (or a script) fails if a new "✅" has no linked artifact.

### Track 1 — Close RE blockers (gates T1.1 … T1.6)
- **T1.1 (B1)** Recover, decompile and annotate segments `19EF` / `1000`.
- ~~**T1.2 (B3)**~~ ✅ **DONE 2026-09-28**: decoded the building-position tables + the
  `[0x5460]:0x4602` slot→building table; MAP1's entrance tiles reproduce the live-found Citadel
  `(34,10)` / ComStar `(51,10)`. Remaining: walk the other six MAP1 tiles; check if `0x4602` is
  per-map. See [`../formats/map-bld-triggers.md`](../formats/map-bld-triggers.md).
- **T1.3 (B6)** Identify water/wall/movement bits and the routine that reads them.
- **T1.4 (B5)** Locate the canonical viewport struct + push/pop mechanism (or prove there is none);
  finish mapping seg-`0x246C`.
- **T1.5 (B4)** Map `b0055/56/57/58` and property IDs `0x1C–0x23` to narrative events by tracing
  `fn1631_11AB` live across a scripted playthrough; corroborate with walkthrough/archaeology.
- **T1.6 (B8)** Enumerate opcodes actually used across all 26 BLD files; implement or explicitly
  document each.
- **T1.7 (B10)** Locate the allowance tick, stop threshold, sleep/day-advance and daily-mission gate.
- **T1.8 (B9)** Decode the sound/music format (or mark formally out of scope for v1).

*Gate T1: every blocker above has a documented resolution or an explicit "out of scope" decision.*

### Track 2 — Faithful data path
- Runtime **ICN/CMP decode** in `TileManager`; runtime **ANM decode** as the only animation path.
- Regenerate/commit (or script-generate) the tilesets, animations and fonts so a clean checkout can
  render maps, interiors and combat without pre-baked stand-ins.
- **T2.x** save parser: load a real `GAME*`, save it, byte-compare; extend to all 6 slots.

*Gate T2: a clean checkout + `original/` renders the start map, a building interior and a combat
screen using only original data files.*

### Track 3 — Differential validation (the keystone)
Build `tools/parity/` that runs identical scripted input through **(a)** the Spice86 emulator and
**(b)** the Godot rebuild, then diffs:
`state array · story slots · credits · cursor · unit slots · combat grids · RNG draws · rendered frame`.

Scenarios, in order:
1. Boot → title → new-game start state.
2. One training day: enter training center → mission → sleep at barracks → day advance + allowance.
3. One shop transaction (weapon/armor) — credit + inventory deltas.
4. One ComStar session — buy/sell stock, portfolio screen.
5. One combat encounter — initiative, movement, to-hit, damage, kill, post-combat state.
6. One story gate (citadel attack → `b0057` transitions).

*Gate T3: each scenario produces an empty (or explicitly explained) diff.*

### Track 4 — Feature completion (per-area, only after its T3 scenario passes)
- Stock-market Godot UI (dispatcher 0x2A/0x2B already present).
- Tech / `BTSTATS` screen, full equipment management.
- Endgame: `WINSCENE`, `ENDMECH`, `TINYLAND`.
- Combat VFX, mech-panel animation, cursor animation — after T3.5 passes.
- Sound (if T1.8 succeeded).

### Track 5 — Retro archaeology (parallel, feeds Track 1)
- Collect manual / clue book / magazine scans; extract design facts → cite → verify (B4/B11).
- Extend the sibling-game function map (Mines of Titan → other Westwood titles) for B1/B5.

### Track 6 — Packaging (last)
- 320×200 scaling, input remap, deterministic build, asset-extraction step documented in README.

---

## 4. Definition of done, per area

| Area | Done means |
|------|-----------|
| BLD interpreter | Every opcode in the corpus implemented; parity scenario 1–3,6 diff-empty |
| Story state | `b005x` semantics verified live; scenario 6 diff-empty |
| Combat | Formulas/RNG match traces; scenario 5 diff-empty |
| Maps/triggers | Data-driven entrances; walking parity with emulator |
| Save | Load→save→byte-compare equal across GAME1–6 |
| Rendering | Same scene from original data, frame-compared within tolerance |
| Economy | Scenarios 2, 3, 4 diff-empty |
| Sound | Format documented + decoded, or formally dropped |

---

## 5. Risk register

- **Compiler-optimised code / missing segments** (B1) may force heavy manual disassembly — schedule
  archaeology in parallel.
- **Differential testing needs scripted inputs** — the MCP tooling makes this feasible but the
  scenarios must be written first.
- **Asset licensing** — original assets stay out of the repo; the extraction step becomes a documented
  build prerequisite.
- **Scope creep** — polish (Track 4) must not start before its parity scenario passes.
