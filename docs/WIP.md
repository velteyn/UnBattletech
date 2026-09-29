# Work In Progress — open gaps & next actions

> **Living document.** Update on every work session so nothing is lost across network/session
> interruptions. Newest section first. Mark items `✅ done` when closed (with the commit/file).
> Last updated: 2026-09-28.

---

## Current focus — Combat depth (single doc: [`combat-system.md`](combat-system.md))

Combat is now consolidated into one document (§1–§20 mech, §21 weapon system, §22 encounter flow,
§23 infantry, §24 heat, §25 turn structure). The following are **known gaps** in it:

| # | Gap | Status |
|---|-----|--------|
| C1 | Round/activation semantics | ✅ **resolved**: `[BP-0x42]` = per-unit **attack sub-phase** (0..0xB), outer `[BP-0x4]` (0..0xB), unit `[BP-0x28]` — §25.1 |
| C2 | Damage-overflow internals | ✅ **resolved**: jump table at `CS:0x118E` (`1000:0B62`); armour→structure `+0xB` — §25.4 |
| C3 | Post-fire / message path (`1000:5847…`) | ⬜ open (needs enumerating after `521D`) |
| C4 | Heat `[0x5624]:0x4592` (`penalty/5`) | ✅ **resolved**: read as a non-zero **flag** (`1000:399C`/`39C6`) — §24.5 |
| C5 | Weapon-definition field offsets `+0x0A/+0x0D/+0x0E` | ⬜ open (find the def-table reader; the code uses the *instance* table `0x2EE3-0x2EE8`) |
| C6 | Infantry armour types (`+0x0D`↔FlakVest…) | ◐ partial: type written by equip code (`0000:501B`, `0170:4F07`); value↔item map still unknown |
| C7 | Infantry AI / weapon selection | ◐ partial: unit-class split at `1000:5028` (`[BP-0x28]` vs 4/0xC); target logic not isolated |
| C9 | **Terrain movement-cost** — no per-terrain MP cost found; confirm the docs' "movement cost" label on `0x32C6` is wrong (only to-hit + passability exist) | ⬜ see [`combat-system.md`](combat-system.md) §26 |
| C8 | **Enemy AI beyond targeting** — weapon pick (`[BP-0x48]` from `[BP-0x2]`, specials `0x20`=Kick / `0x80`), movement/approach decision, **flee**, and the "computer fights for you" auto-pilot | ◐/⬜ see [`combat-system.md`](combat-system.md) §3 "AI — coverage & gaps" |

## Post-combat & party (to uncover)

| # | Gap | Status / findings |
|---|-----|-------------------|
| P1 | **Salvage management** | ⬜ open. **No "salvage"/"scavenge" wording exists in any BLD text** — so there may be no generic post-battle salvage (mechs are acquired via story/jail/impound: *"recover your 'Mechs without paying the parking fee"*). Needs the **combat-exit path** traced to confirm. |
| P2 | **Party injuries** | ◐ partial. The hospital has a per-character **"wounded"** state (*"(Nobody is wounded)"*) + *"Get healed"*; health lives in the 17-byte record `+0x0F`. Still to link: what sets "wounded" (combat) and the heal cost/effect. |
| P3 | **New pilots joining** | ✅ **mechanism decoded**: BLD opcode `0xE9 CALL_ROOM_HANDLER` → `fn11B8_0D58` (`11B8:0D58`): finds an empty slot (0-7), assigns a unit id, rolls attributes with 2D6 (`fn0800_19DD`), sets health `0xC623` = attr×10, `0xC620 = 0x08` (unlinked), fills inventory `0xC618[0..6] = RNG&1`, links the unit to a free **story slot** (`0xC724`, stride 0x7D), then renders the name (`fn1E56_03F5`). Recruitment *paths* are the BLD scripts that call `0xE9` (barracks/party/story). |

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
