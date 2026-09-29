# Work In Progress — open gaps & next actions

> **Living document.** Update on every work session so nothing is lost across network/session
> interruptions. Newest section first. Mark items `✅ done` when closed (with the commit/file).
> Last updated: 2026-09-29.

---

## ▶ SESSION STATUS — pick up here next

**This session (2026-09-29) — "C5 + C10 close-out".** Docs-first, decompilation only. **C5 ✅** and
**C10 ✅** resolved. **C5** — the weapon-**definition** table reader and all seven trailing fields are
decoded and verified in [`combat-system.md`](combat-system.md) **§21 §4** (and §13/§6/§7/§19
corrected). Key results:

- The table is at **`DS:0x2ED8`** (file offset `0x3D088`); the old "instance table at
  `DS:[0x5652]:0x2EE4`" is the **same table** (`[0x5652]` = the data segment itself).
- **`+0x0A`** = unused (always 0); **`+0x0B`** = damage; **`+0x0C`** = bit7 personal-weapon flag +
  cluster column (**not** "infinite ammo"); **`+0x0D`** = min-range (high nibble) / **heat** (low
  nibble); **`+0x0E`** = packed short (bits7-5) / medium (bits4-0) range; **`+0x0F`** = long range;
  **`+0x10`** = skill class.
- Reader = the range-band classifier `ghidra_guess_1000_0934_10934` (`1000:0934`); it scales
  short/medium by ×3 and compares to the cursor distance from `1000:05C5`.

**C10 ✅** — **Kick** damage = **attacker tonnage ÷ 5** (mech struct `+0x10`, written into the Kick
record at `1000:4F55`); **Inferno** = **0 damage + heat surge** (arms target counter `0xD576=3` →
+6 heat penalty/round ×3). See §27.1/§27.2.

**C11 ✅** — combat map art is `MECHSHAP.CMP` unit sprites (Locust/Commando 2-frame walks, wrecks,
Fire/Impact `0x7C-0x7F`), documented in `InceptionTools/{Enums/SpriteEnum,AssetExtractor}.cs`; registered
by `18AD:070A`, blitted by `1000:1983` at map tiles. **No persistent 80 px portrait**; `MechPortrait.cs`
is invented. **C11b ◐** — `O*.ANM` are a **generic 88×88 animation resource** (top-left panel), reused for building
interiors, story beats, and **combat dramatisation** (mech firing, mech stomping a downed pilot) — no
"combat vs story" split. Seen e.g. at the post-training Kurita raid (`TRAINING.BLD` §17.9). Best-effort
render: cockpit `O0`, stomp `O1`, pilot portrait `O5`/`O13`, infantry `O7`, explosion `O9`. Open: a
verified ANM decoder + the full trigger→clip map. (The 1988 ad is an artist's collage of real game
pieces, not a literal screenshot.) See §28.1.

**U1 ◐ (partial)** — `fn0800_3D40` control flow decoded (suspend flag, cursor save, arrow-key unit
cycling, SPACE exit, `0800:3FAE` draws `BTSTATS.CMP`); its only Reko caller is the world-map SPACE
menu, so combat **"Scan Unit"** reaches the status view by another — still unisolated — path. Open:
the `3FAE` column/field layout + the Scan Unit handler.

**▶ Next:** finish **U1** (`0800:3FAE` layout + combat "Scan Unit") and **C11**'s cue table
(`DS:0x5008`). Full living list: [`WIP.md`](WIP.md).

---

**Earlier this session (2026-09-29) — "C3 close-out".** Docs-first, decompilation only (no RE tooling
left running). **C3 ✅ resolved** — the post-fire message path after `1000:521D` is fully enumerated in
[`combat-system.md`](combat-system.md) **§25.5**:

- the three fixed combat messages and their `DS` pointers — `0x3EDE` **"Missed!"**,
  `0x3EE7` **"Hit!"**, `0x41FC` **"Killed him!"** (all emitted through `1000:17BB` when `DS:[0x2E38]≠0`);
- the **11-arg call** into `1000:5847` (acting/target slots, weapon slot, destroyed/dummy/hit flags,
  the `0x2A02:0x4314` text buffer);
- `1000:5847`'s structure: name/panel updates via `0170:1732`, **weapon-class cue dispatch**
  (`0000:30BF` → `1000:9352`), hit/miss presentation, the **kill** bookkeeping
  (`0xC623==0` → `[BP-0x2c]=1` → mark dead, `0x7E` display byte), and the training-dummy FX chain;
- the post-call path (`1000:17DC` panel refresh, `0000:5FB7(0x10/0x5,0)`, stage reset to `0xC`).

**▶ Next:** ~~C5~~ ✅ and ~~C10~~ ✅ (both done later this session) → **C11 / U1** (80 px panel
animation + status screen / "Scan Unit").

---

**Previous session (2026-09-28/29) — "combat depth + fidelity audit".** Docs-first, no RE tooling left running;
repo `main` tip **`d5dde67`**. What landed:

- **Combat-arc gaps closed / clarified** (all in [`combat-system.md`](combat-system.md)):
  C1 ✅ (`[BP-0x42]` = **per-unit attack sub-phase**, §25.1), C2 ✅ (damage-overflow jump table **`CS:0x118E`**, §25.4),
  C4 ✅ (heat `penalty/5` read as a **non-zero flag**, §24.5).
- **New canonical sections:** **§26 terrain effects**, **§27 physical/melee/close combat**, **§28 combat animations**,
  plus an **AI coverage** table in §3.
- **UI:** documented the **stats/status screen** (`fn0800_3D40`/BTSTATS) in [`engine/viewport.md`](engine/viewport.md);
  flagged combat **"Scan Unit"** as undecoded (U1).
- **P3 ✅**: new-pilot creation decoded (`fn11B8_0D58`).

**Key fidelity findings (surprising, record-worthy):**
- Terrain affects **to-hit** + **passability** only — **no water-cooling/terrain heat**, **no per-terrain MP cost**.
- Physical attacks reduced to **Kick** (+ personal melee weapons for infantry) — **no Punch/Club/Charge/DFA**, **no area-fire**.
- The combat "hit blink" is the **impact VFX `19EF:18EF`** (13 frames), **not** an ANM; combat never calls the building-ANM dispatch.

**▶ Do this first next session (cheap, high value):**
1. ~~**C3** — enumerate the post-fire message path after `1000:521D` (decompilation only).~~
   ✅ **done this session** — [`combat-system.md`](combat-system.md) §25.5.
2. ~~**C5** — find the weapon-**definition** table reader (resolves `+0x0A/+0x0D/+0x0E` range packing)~~
   ✅ **done later this session** — §21 §4; **C10** (Kick dmg / Inferno) also ✅ — §27.1/§27.2.
3. **C11 / U1** — decode the 80 px combat panel animation + the status screen fields / "Scan Unit".
4. Then the bigger ones: **C6/C7/C8** (infantry armour map, infantry AI, enemy-AI decisions), **P1/P2** (salvage, injuries).

**▶ Keystone after that:** **T3** — build the differential-validation harness (emulator vs rebuild); everything
marked "unverified re-implementation" (combo of `CombatView`/`CombatHUD`/`MechPortrait`, viewport, sound) depends on it.

---

## Current focus — Combat depth (single doc: [`combat-system.md`](combat-system.md))

Combat is now consolidated into one document (§1–§20 mech, §21 weapon system, §22 encounter flow,
§23 infantry, §24 heat, §25 turn structure). The following are **known gaps** in it:

| # | Gap | Status |
|---|-----|--------|
| C1 | Round/activation semantics | ✅ **resolved**: `[BP-0x42]` = per-unit **attack sub-phase** (0..0xB), outer `[BP-0x4]` (0..0xB), unit `[BP-0x28]` — §25.1 |
| C2 | Damage-overflow internals | ✅ **resolved**: jump table at `CS:0x118E` (`1000:0B62`); armour→structure `+0xB` — §25.4 |
| C3 | Post-fire / message path (`1000:5847…`) | ✅ **resolved**: 3 fixed messages (miss/hit/kill) + the 11-arg `5847` presentation routine + post-call stage advance — **§25.5** |
| C4 | Heat `[0x5624]:0x4592` (`penalty/5`) | ✅ **resolved**: read as a non-zero **flag** (`1000:399C`/`39C6`) — §24.5 |
| C5 | Weapon-definition field offsets `+0x0A/+0x0D/+0x0E` | ✅ **resolved** (2026-09-29): table base `DS:0x2ED8` (file `0x3D088`); `+0x0A` unused; `+0x0D` = min-range (hi) / heat (lo); `+0x0E` = short(bits7-5)/medium(bits4-0); `+0x0F` = long; `+0x0C` bit7 = personal-weapon (not "infinite ammo"). Reader = range classifier `1000:0934`; full decode in §21 §4 |
| C6 | Infantry armour types (`+0x0D`↔FlakVest…) | ◐ partial: type written by equip code (`0000:501B`, `0170:4F07`); value↔item map still unknown |
| C7 | Infantry AI / weapon selection | ◐ partial: unit-class split at `1000:5028` (`[BP-0x28]` vs 4/0xC); target logic not isolated |
| C9 | **Terrain movement-cost** — no per-terrain MP cost found; confirm the docs' "movement cost" label on `0x32C6` is wrong (only to-hit + passability exist) | ⬜ see [`combat-system.md`](combat-system.md) §26 |
| C10 | **Kick damage + Inferno effect** | ✅ **resolved** (2026-09-29): Kick damage = **attacker tonnage ÷ 5**, read from the mech struct `+0x10` and written into the Kick record's damage byte (`1000:4F55`, `ES:[0x3103]`). Inferno forces **0 damage** and arms the target's heat-surge counter `0xD576=3` (**+6 heat penalty/round ×3**) — `1000:50E7`. See [`combat-system.md`](combat-system.md) §27.1/§27.2 |
| U1 | **Stats/status page + combat "Scan Unit"** | ◐ partial (2026-09-29): `fn0800_3D40` control flow decoded (`w014A=1`, cursor save, arrow-key unit cycling, SPACE exit, `0800:3FAE` draws BTSTATS.CMP); **only caller = world-map SPACE menu**, so combat "Scan Unit" uses another (unisolated) path. Still open: the `3FAE` column/field layout + the Scan Unit handler. See [`engine/viewport.md`](engine/viewport.md) "Stats / status screen" |
| C11 | **Combat sprites** | ✅ **resolved** (2026-09-29): `MECHSHAP.CMP` unit sprites (Locust/Commando 2-frame walks, wrecks, Fire/Impact `0x7C-0x7F`), documented in `InceptionTools/{Enums/SpriteEnum,AssetExtractor}.cs`. Registered by `18AD:070A`, blitted by `1000:1983` at map tile positions. **No persistent 80 px portrait** — `MechPortrait.cs` is an invented panel UI. See [`combat-system.md`](combat-system.md) §28.1 |
| C11b | **ANM usage / left-panel animations** | ◐ **system understood, clip→trigger map open** — `O*.ANM` are a **generic 88×88 animation resource** shown in the top-left panel and reused for many purposes (building interiors, story dramatisation, **combat dramatisation** like a mech firing or stomping a downed pilot). There is **no "combat ANM" vs "story ANM" split**. Best-effort render: cockpit `O0`, stomp `O1`, pilot portrait `O5`/`O13`, infantry `O7`, explosion `O9`. Open: a verified ANM decoder + the full trigger→clip map (BLD `fn135D`, story, combat callers). See §28.1 |
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
- **Canonical working tree = `Reversing/AIATTEMPT`.** The sibling `Reversing/UNBATTLETECH` clone is an
  obsolete prototype (old commit, no `docs/`; its `GeneratedCode*.cs` are already `reko/gencode/GC*.cs`).
- Imported from that clone (2026-09-29): `tools/pack/exepack.exe` (original EXE packer/unpacker;
  `.gitignore` exception added) and `reko/gencode/prototype-overrides/*.cs` (the "register one
  function at a time" prototype — kept for reference, excluded from compilation by `reko/**/*.cs`).
- **Generated code contains duplicated routines** (segment aliasing/overlays) — a `ghidra_guess_*`
  name is not unique. Resolve the true copy by **physical address** (`seg*16+off`) and confirm against
  the raw `UNBTECH.exe` bytes. See [`engine/segments-19ef-1000.md`](engine/segments-19ef-1000.md)
  "Duplicated functions".
- **Origin of the generated code:** produced by Spice86 on the `UNBATTLETECH` tree during a **combat
  session** (load `GAME5` → walk into a random encounter → fight a few rounds) — `reko/gencode/GC*.cs`
  is byte-identical to `UNBATTLETECH/GeneratedCode*.cs`; the fresh run is `reko/gencode-current/`.
