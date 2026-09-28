# Westwood Engine Recovery Plan

> Strategy: recover the **shared Westwood engine** as a coherent, subsystem-ordered
> specification *first*, then treat BattleTech as data + game logic on top. This replaces
> the ad-hoc "clue-scattering" approach with an organic plan.

## Premise

BattleTech: The Crescent Hawk's Inception (1988) is a **Westwood Associates** game built on
the same in-house engine as **Mars Saga** (1988) and **Mines of Titan** (1989), and related
to the later Westwood titles (Eye of the Beholder, Kyrandia, Lands of Lore). Same-era
programmers: Louis Castle, Barry Green, Michael Goldberg.

Because the engine is shared, its subsystems (resource loader, renderer/viewport, input,
text, sound, timing) can be recovered once and cross-checked against sibling binaries — far
more reliable than reverse-engineering each game's quirks in isolation.

## Method

1. **Acquire sibling binaries** for cross-reference (DOS **Mars Saga**, **Mines of Titan**).
   Keep them local (not committed; same as `original/`).
2. **Fingerprint the engine**: match shared code by byte signatures, magic constants, table
   layouts, and call patterns (RLE/format routines, viewport/blit, text renderer, loader,
   input, sound driver). Produce a "shared vs game-specific" function map.
3. **Reverse in dependency order** (see subsystems below), validating each against Spice86
   execution traces + the MCP harness.
4. **Write an engine spec** under `docs/engine/`, with function maps, data structures and
   call graphs.
5. **Then** map BattleTech-specific content (story, combat, economy, maps) as a layer on the
   engine.

## Subsystems (dependency order)

| # | Subsystem | Key questions | Existing clues |
|---|-----------|---------------|----------------|
| A | **Memory model / startup** | PSP/segment layout; **which segment holds game state (DS `0x1DE9` vs ES `0x2A0F`)**; protection screen; mode selection | `context.md` §1/§3; UNVERIFIED §6 |
| B | **Resource system** | `.CMP/.ICN/.MTP/.ANM/.BLD` formats + loader; the Westwood RLE; where files are opened/read | `formats/*` |
| C | **Rendering / viewport** | viewport struct + set/clip + page; 3-pass pipeline; palette/DAC; `tB764` modes; seg `0x246C` config | `story/story-system.md` §Viewport; UNVERIFIED §7 |
| D | **Input** | keyboard/mouse, menu/cursor loop, action dispatch | `tools/spice86-mcp.md` |
| E | **Text** | font, renderer, word-wrap, markers | `formats/bld-bytecode.md` |
| F | **Sound / music** | driver + format | WONT_DO (modern replacement) |
| G | **Timing / animation** | frame counter, ANM page swap, economy tick | `context.md` §7 |
| H | **Script / event system** | BLD bytecode + `fn1CD3` dispatch (game-specific layer on engine hooks) | `formats/bld-bytecode.md`, `story/story-system.md` |

## Deliverables

- `docs/engine/README.md` — this plan + architecture overview.
- `docs/engine/viewport.md` — viewport & rendering workflow (subsystem C).
- `docs/engine/combat-flow.md` — combat encounter flow (runtime-observed).
- `docs/engine/fingerprint-mines-of-titan.md` — cross-binary fingerprint + shared-function map.
- `docs/engine/memory-model.md` — segment layout, DS/ES roles, startup/protection flow.
- `docs/engine/resources.md` — file formats + loader (shared engine routines).
- `docs/engine/viewport.md` — **the viewport workflow** (priority).
- `docs/engine/renderer.md`, `input.md`, `text.md`, `sound.md`.
- A **function-map index** (`segment:offset` → engine role → shared/game-specific).
- Cross-game fingerprint notes (which functions are shared with Mars Saga / Mines of Titan).

## Immediate first steps

1. **Resolve the memory model (subsystem A)** — the ES-vs-DS game-state segment
   (UNVERIFIED §6). Every subsystem depends on knowing where the engine keeps state, and it
   currently blocks state-driven playtesting.
2. **Recover the viewport workflow (subsystem C)** — trace `fn207F_24D7` callers and the
   seg-`0x246C` rendering-config struct; determine whether a canonical viewport
   struct/set-clip exists.
3. Acquire Mars Saga / Mines of Titan and begin fingerprinting.

**Progress (2026-09-27)**:
- Mines of Titan (`TITAN.EXE`, authentic DOS) acquired and stashed under `original/siblings/`
  (gitignored). Fingerprint + shared-function map in
  [`fingerprint-mines-of-titan.md`](fingerprint-mines-of-titan.md): **25 shared engine functions**,
  concentrated in the graphics/text core (segments `207F`, `1E56`, `1F3D`).
- **Mars Saga (1988) DOS is not available**: the archive.org `msdos_Mars_Saga_1988` item is
  mislabeled (contains Mines of Titan), and the `MarsSaga_449` ISO is a DOSBox bundle that also
  only ships Mines of Titan. Genuine Mars Saga is **C64 / Apple II** (6502) — not byte-fingerprintable
  against x86. So Mines of Titan is our only x86 sibling.
- **Shared scope**: loader / RLE / input are **not** shared (Mines of Titan packs resources into
  `DISK*.DAT`). The reusable engine surface is rendering + text + drawing primitives.

> Until A and C are settled, further content-level spelunking (story/combat tuning) risks
> building on an unverified foundation.
