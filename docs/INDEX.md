# Documentation Index

Single map of the docs. **Rule: one canonical doc per topic.** Every other file
should summarise and link here rather than restate.

## Start here

| Doc | Purpose |
|-----|---------|
| [`../README.md`](../README.md) | Project intro, build & run, repo layout |
| [`../AGENTS.md`](../AGENTS.md) | Agent/ops manual: build, run, tool CLIs, gotchas, rules |
| [`context.md`](context.md) | Master overview + what's known / unknown |
| [`SOURCES.md`](SOURCES.md) | Sources & evidence policy — what each source (binary, manual, walkthroughs, personal playtesting, sibling games) is authoritative for, and how a claim becomes *verified* |

## Canonical references

| Topic | Canonical doc |
|-------|---------------|
| **Engine recovery plan (Westwood engine-first strategy)** | [`engine/README.md`](engine/README.md) |
| Engine viewport & rendering workflow | [`engine/viewport.md`](engine/viewport.md) |
| Engine combat encounter flow (runtime) | [`engine/combat-flow.md`](engine/combat-flow.md) |
| Engine input & navigation (runtime) | [`engine/input-navigation.md`](engine/input-navigation.md) |
| Engine fingerprint vs Mines of Titan (shared-function map) | [`engine/fingerprint-mines-of-titan.md`](engine/fingerprint-mines-of-titan.md) |
| File formats (.CMP/.ICN/.MTP/.BLD/.ANM/save/mech) | [`formats/file-formats.md`](formats/file-formats.md) |
| BLD bytecode, opcodes, cipher, `fn1CD3` cases | [`formats/bld-bytecode.md`](formats/bld-bytecode.md) |
| ANM animation format | [`formats/anm-format.md`](formats/anm-format.md) |
| Memory map + address reference | [`formats/memory-map.md`](formats/memory-map.md) |
| Combat system | [`combat-system.md`](combat-system.md) |
| World map & navigation | [`world-map.md`](world-map.md) |
| Story system (state, BLD arc, NPC movement) | [`story/story-system.md`](story/story-system.md) |
| Story arc (narrative summary) | [`story/story-arc.md`](story/story-arc.md) |
| Full extracted narrative text | [`story/STORY_TEXT.txt`](story/STORY_TEXT.txt) |
| Rebuild roadmap (phases, estimates, checklist) | [`rebuild/roadmap.md`](rebuild/roadmap.md) |
| Rebuild progress / status | [`rebuild/progress.md`](rebuild/progress.md) |
| Spice86 MCP runtime tools (23 `bt_*`) | [`tools/spice86-mcp.md`](tools/spice86-mcp.md) |
| Analysis tooling (Reko/Spice86/Ghidra/InceptionTools/Python) | [`tools/analysis-tools.md`](tools/analysis-tools.md) |
| Playtest harness (drive the original via MCP) | [`../tools/playtest/bt.py`](../tools/playtest/bt.py) |
| Open theories / unverified discoveries | [`UNVERIFIED_DISCOVERIES.md`](UNVERIFIED_DISCOVERIES.md) |
| Gameplay walkthroughs (reference) | [`walkthrough/`](walkthrough/) |

## Consolidation notes (2026-09-28) — misplacement pass

- **Encounter setup** (enemy population, mech/weapon tables, positioning, `fn183B_000A` init, combat
  flow) moved **out of `world-map.md` §17** into **`combat-system.md` §20**. `world-map.md` keeps only
  the encounter **trigger** (`RNG & bD330` + mode guards).
- **Engine viewport/rendering** in `story/story-system.md` §17.12 moved to
  **`engine/viewport.md`** (rendering, `w4FBA`/`w4FBC`, borders, pipeline, blitter, main game loop,
  image pipeline) and **`engine/input-navigation.md`** (cursor + keyboard). §17.12 is now a pointer.
- **`combat-system.md` §12** no longer calls `w4FBA` a "combat state machine" (it is the global
  UI/render mode — see `engine/viewport.md`).
- **`formats/bld-bytecode.md`** "Memory Map for State Variables" is now a cross-reference; the address
  map is canonical in `formats/memory-map.md`, and the wrong `w4FBA`/`w4FBC` rows were corrected.
- **Start-map building entropy/coordinates** (Citadel, ComStar) live in `world-map.md` §3;
  `engine/input-navigation.md` points there.
- **Stale `NEW_GAME_INIT = 1500 cr`** removed from `tools/spice86-mcp.md`.
- **Still to consolidate:** behavioural blocks duplicated in `formats/memory-map.md` §19–§31; economy
  portions in `combat-system.md` §19; combat/memory duplicates in `engine/combat-flow.md` and
  `tools/spice86-mcp.md`; RNG stated 3× inside `combat-system.md`.

## Consolidation notes (2026-09-27)

The docs were reorganised out of a state with heavy topical duplication:

- `TECHNICAL_ANALYSIS.md` was split into [`combat-system.md`](combat-system.md)
  (combat + ammo), [`story/story-system.md`](story/story-system.md) (§17),
  and the world-map sections folded into [`world-map.md`](world-map.md). Its
  duplicate RNG section (§10) is now a pointer to the fuller §16.
- `WORLD_MAP_FINDINGS.md` became the canonical [`world-map.md`](world-map.md);
  the old `TECHNICAL_ANALYSIS §20` was a subset and is merged there.
- `reference/ADDRESS_REFERENCE.md` was merged into
  [`formats/memory-map.md`](formats/memory-map.md) as an appendix.
- `REBUILD_PLAN.md` (Italian) was translated/merged into
  [`rebuild/roadmap.md`](rebuild/roadmap.md) as a "Detailed Step Checklist".
- `CONTEXT.md` → [`context.md`](context.md): trimmed to overview + pointers;
  its duplicate §7 was removed.
- The MCP reference moved from `AGENTS.md` to
  [`tools/spice86-mcp.md`](tools/spice86-mcp.md).

> Git history preserves the pre-reorganisation files if anything is missing.
