# Work In Progress — open gaps & next actions

> **Living document.** Update on every work session so nothing is lost across network/session
> interruptions. Newest section first. Mark items `✅ done` when closed (with the commit/file).
> Last updated: 2026-09-28.

---

## Current focus — Combat depth (single doc: [`combat-system.md`](combat-system.md))

Combat is now consolidated into one document (§1–§20 mech, §21 weapon system, §22 encounter flow,
§23 infantry, §24 heat, §25 turn structure). The following are **known gaps** in it:

| # | Gap | Where | Next action |
|---|-----|-------|-------------|
| C1 | **Round/activation semantics** — is `[BP-0x42]` incremented *per round* (each round uses the next AI-preference slot)? Increment sites `1000:535A` (INC, CMP 0xC), `5310` (set 0xC = exit), `547B` (reset 0). | §25.1, §25.4(a) | Trace one live round: emulator breakpoint on `1000:535A`, log `[BP-0x42]` / `[BP-0x28]`. |
| C2 | **Damage-overflow loop internals** — `1000:0B32` jump-table tail and how excess damage chains body parts. | §7.8, §25.4(b) | Read `0B32` fully + the `1000:50xx` overflow sites in the decompilation. |
| C3 | **Post-fire / message path** — the `1000:5847…` sequence (messages, cleanup). | §25.2 #11 | Enumerate the calls after `521D` in GC12. |
| C4 | **Heat `[0x5624]:0x4592`** — `penalty/5` is written there; its consumer is unknown (overheat flag? movement gate?). | §24.5 | Find readers of `[0x5624]:0x4592` (`1000:399C`/`39C6`) and their effect. |
| C5 | **Weapon-definition field offsets** — `+0x0A`, `+0x0D`, `+0x0E` (range packing) unresolved; `+0x0B`=damage, `+0x0C`=cluster column, `+0x10`=skill are safe. | §21 §3–§4 | Find code that reads `+0x0A/+0x0D/+0x0E` off a weapon record. |
| C6 | **Infantry armour types** — `+0x0D` (`0xC621`) compared to `1`; the type→item (FlakVest…) map is unknown. | §23.2b | Cross-ref the Armor-shop item ids with the record's armour-type byte. |
| C7 | **Infantry AI / weapon selection** — how an infantry unit picks its target/weapon each turn. | §23 | Trace the unit 4-11 branch of the combat loop. |

## Post-combat & party (to uncover)

| # | Gap | Known hooks | Next action |
|---|-----|-------------|-------------|
| P1 | **Salvage management** — after a battle, which enemy mechs/equipment are recoverable, where stored, and how they enter the roster | mech bay (`fn0FDC_15E6`), unit slots `aC614`/story slots `aC724`, REPAIR/GARAGE | Find the post-combat outcome path (combat exit) and the salvage→roster code. |
| P2 | **Party injuries** — how pilots/party take injuries from combat and how they heal | hospital "Heal Characters" (`fn1CD3` cases 0x09/0x29, 50 cr), combat health fields | Link combat damage → per-character health; find the injury/recovery code. |
| P3 | **New pilots joining** — recruitment of new party members | `fn1CD3` case 0xE9 `CALL_ROOM_HANDLER` (creates a hireling in an empty slot; `fn11B8_0D58`), BARRACKS/BARRACK2/BARRACKS recruit NPCs, PARTY (Rex), story joins | Trace each recruitment path + the roster/slot update it performs. |

> These are **currently undocumented** (no canonical section yet). Once traced, fold them into
> [`combat-system.md`](combat-system.md) (post-combat resolution) and/or
> [`story/story-system.md`](story/story-system.md) (party/roster).

## Track 1 blockers (from [`rebuild/roadmap.md`](rebuild/roadmap.md))

| # | Blocker | Status |
|---|---------|--------|
| B1 | Combat/movement decompilation (`19EF`/`1000`) | ✅ done (`reko/gencode/`, `reko/gencode-current/`, `engine/segments-19ef-1000.md`) |
| B2 | Combat formulas diffed | ◐ core formulas **code-verified**; **differential test vs emulator (Track 3) still missing** |
| B3 | Map→BLD trigger table | ✅ done (`formats/map-bld-triggers.md`) |
| B4 | Story-state semantics | ✅ done (`story/story-system.md` §17.5) |
| B5 | Viewport struct / `w4FBC` push-pop | ⬜ open |
| B6 | Tile properties / passability | ✅ done (`world-map.md` §7a) |
| B7 | Save round-trip verification | ⬜ open |
| B8 | BLD opcode coverage | ✅ done (`formats/bld-opcode-coverage.md`) |
| B9 | Sound/music format | ⬜ open (maybe out of scope) |
| B10 | Cadet economy / day-cycle code | ⬜ open |
| B11 | Design intent (archaeology: manual/clue book) | ⬜ open |
| T3 | **Differential-validation harness (emulator vs rebuild)** | ⬜ open — the keystone |

## Verified recently (context, so we don't redo it)

- Combat formulas all re-verified against the decompilation (to-hit, heat, ammo, RNG LFSR, hit
  location, cluster, slot-advance, AI, heat dissipation) — `combat-system.md` "B2 verification".
- Infantry combat: 17-byte record, burst cap 4, armour→health damage pipeline (`1000:4DF0-4E8A`).
- Heat: gen → pool → penalty, clamp 30, to-hit thresholds 8/13/17/24; **heat sinks not modelled**.
- BLD: 28 opcode slots (27 used), operand sizes corrected (EB/EC/F6/F7).
- Spice86 synced to `cf595c3d` (PR #2246 merged); AIATTEMPT rebuilds clean.

## Housekeeping / environment

- Emulator must be **shut down after each session** (saves restored, ports 8086/20000/2159 freed).
- The old `spice86-mcp-fix` branch is **deleted** (local + fork); Spice86 checkout on `master`.
- Docs honesty baseline: `README.md` §2, `docs/SOURCES.md`, `docs/INDEX.md`.
