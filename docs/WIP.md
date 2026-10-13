# Work In Progress — open gaps & next actions

> **Living document.** Update on every work session so nothing is lost across network/session
> interruptions. Newest section first. Mark items `✅ done` when closed (with the commit/file).
> Last updated: 2026-10-13.

---

## ▶ SESSION STATUS — pick up here next

**This session (2026-10-13) — "U1/C11 residual close-out + Spice86 update".**
Spice86 fast-forward `cf595c3d` → **`28a877fc`** (upstream master; `BattleTechCHI` +
`UNBATTLETECH` rebuild 0 errors, no API breaks; emulator booted, MCP/tools verified live).
REA (Ghidra 12.1.4 provider) used for 9 static queries — Ghidra pseudocode beat gencode on
the cue player, `0B5E`, `1AFE`, `2DA8`, `1732`. **Lesson: Reko seg labels carry a load bias
(Ghidra `FUN_2656_0b5e` = Reko `1E56:0B5E`; `FUN_1000_2da8` = Reko `0800:2DA8`) — always
resolve function addresses by byte signature, never by `seg*0x10+off` label arithmetic.**
Closed:

- **U1 residuals ✅**: `0B5E` = `u16 menu(id)`, 0-based, arrows as −scan, Enter/Space confirm +
  record `[menu+0x98]`, ESC cancels; 11-bar pairing = value `story[off1306[i]]` (0 for i≥8)
  + max-armour array, positions `0x131C/0x1332`, heat `(0x1E−heat,heat)`; loc column = prop-band
  thresholds (NOT slots `0x1C..0x23` — those are the bar offsets); `2DA8` = unit refresh/setup
  (dims `0x0A38…` are read by `3FAE`); `207F:104E` = tile-attr lookup (and `FUN_19b8_104e`
  is a different unit-init routine). **OPEN micro-item:** actuator outcome first-arg enum
  (`10`/`0x14..0x17` vs `ds:0x1269`).
- **C11 cue structure ✅**: 5 workers `27C5:02A3/02EB/0345/03A8/040B` share
  count×(inner+delay); roles: tone count=hdr/freq/delay, `0x3E9`–`0x3EC` count=p1/inner-args/delay;
  `0x3EB` vs `0x3EC` differ only in leaf (`0747` vs `07DA`). **Stream reader `1732` mechanism ✅**:
  far-ptr table `DS:[0x1F6+id*4]`, auto-advance, literal return, ops `FD` (store next byte to
  `[0x53BE]:id+0x396C`) / `FE` (rewind by next byte) / `FF` (pushback+reread — puzzling,
  see below); re-armed per presentation pass from `[0x563E]:0x25A+unit*4` (`1000:5707`).
- **Boot wall 🧱 (precise, 2026-10-13)**: from a fresh boot, the `bt.py boot()` space-mash
  path (adapter `4`, drive `3`, then 100+ Spaces + arrows/enter/esc/y/n/1/2) parks on a static
  screen in the blank state (`credits=0`, tile `(34,12)`, CPU in BIOS `F000:0011`, keys consumed
  but ineffectual) — NEW_GAME_INIT never runs that way. **Untried this session:** the §8
  Load-Game route — `GAME1`/`GAME2` are present *and enabled* in `BATTLETECH_CHI/`,
  `GAME3..6` are `.disabled` (rename `GAME5.disabled`→`GAME5` to enable slot 5); reaching the
  main menu with per-screen observation (text-mode screenshots work well) then
  SPACE → Load Game should restore the combat-capable path. Emulator shut down after session.

**Still OPEN (need live combat trace):** per-mech-type `0x1F6` stream bytes; `0xFF`-op intent;
leaf-inner (`047B/059A/0643/0747/07DA`) PIT details; actuator outcome enum.

**C10 ✅** — **Kick** damage = **attacker tonnage ÷ 5** (mech struct `+0x10`, written into the Kick
record at `1000:4F55`); **Inferno** = **0 damage + heat surge** (arms target counter `0xD576=3` →
+6 heat penalty/round ×3). See §27.1/§27.2.

**C11 ✅** — combat map art is `MECHSHAP.CMP` unit sprites (Locust/Commando 2-frame walks, wrecks,
Fire/Impact `0x7C-0x7F`), documented in `InceptionTools/{Enums/SpriteEnum,AssetExtractor}.cs`; registered
by `18AD:070A`, blitted by `1000:1983` at map tiles. **No persistent 80 px portrait**; `MechPortrait.cs`
is invented. **C11b ◐** — `O*.ANM` are a **generic 88×88 animation resource** (top-left panel) reused across
building/story/combat contexts; no "combat vs story" split. **Decoder ✅** (`1000:AC12`; big-endian,
`0xF20` frames; `O0`=19) and **player ✅** `0000:48B7 play_anm(index,mode)` (builds `"O<index>.ANM"`).
**Combat triggers:** `O16`(0x10 firing) + `O5`(0x5 pilot) in the post-fire path, `O2` at `1000:1336`;
rooms via `0FDC:1C9B/1A26`. Clips: cockpit `O0`, portraits `O2`/`O5`/`O12`/`O13`, infantry `O7`,
**stomp `O9`**, firing `O16`. Open: variable-index sites + guards. See §28.1a.

**U1 ✅ (closed 2026-10-13, docs-first, no game code touched).** Two separate views, verified
byte-for-byte in `reko/segments/UNBTECH_{0800,0DAB,183B}.asm` (DS base file `0x3A1B0`):
`fn0800_3D40`→`0800:3FAE` is a map-strip + 3-column `2DA8` unit-cell overview (**no BTSTATS** —
the old "`5 columns × 48 rows of 3×3 subtiles`" claim is corrected in AGENTS.md +
`engine/viewport.md`); the **detail view** `fn0DAB_1467`→`fn0DAB_1AFE` loads `BTSTATS.CMP`
(`1F3D:063B`→`3092:00A0`, sites `0DAB:1B58` with `ds:0x1272` and `1467:08A8` with `ds:0x27E6`)
and renders Type/Tons/Pilot/Rider, the `0x33..0x55` Armament table + Loc column (prop-band
thresholds → `LA LT RA RT LL RL CT H`; the `0x1C..0x23` are the location-bar value offsets,
`ds:0x1306`), actuator nibble rows (outcome enum `10`/`0x14..0x17` OPEN), 11
location bars (value/max pairing resolved 2026-10-13) and the `[0x6E]` heat bar. Combat **Scan Unit** =
`fn183B_14C3` (player sel 6 / enemy sel 4) → `fn183B_2591` (Friends/Enemies/Cancel submenu
`ds:0x3D73`, sensor guard `[C79B]==2` → `ds:0x3DCD`, no-enemy guard → `ds:0x3E19`) →
`call far 0DAB:1467` (`183B:2704`, the browser's only Reko caller). Full tables in
[`engine/viewport.md`](engine/viewport.md) "Stats / status screen". Residual: actuator outcome
enum; `0B5E`/bars/`2DA8` closed 2026-10-13 (see session status above).

**▶ Next:** live-combat trace items (`0x1F6` stream bytes, `0xFF`-op, leaf PIT details,
actuator enum) — blocked on the boot wall (NEW_GAME_INIT unreachable by space-mash; needs
menu-observed navigation or memory-write init) — then C6/C7/C8, P1/P2, keystone T3.

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
| U1 | **Stats/status page + combat "Scan Unit"** | ✅ **closed** (2026-10-13): two views — `fn0800_3D40`/`3FAE` overview (dims `0x0A38…` read by `3FAE` itself; `2DA8` = unit refresh/setup, no BTSTATS) vs `fn0DAB_1467`/`1AFE` detail (BTSTATS load sites `0DAB:1B58` + `1467:08A8`; field table decoded). Combat Scan = `183B:14C3` (sel 6/4) → `183B:2591` (submenu `ds:0x3D73`, guards `ds:0x3DCD`/`0x3E19`) → `0DAB:1467`. Residuals closed: `0B5E` convention (0-based, −scan arrows, Enter/Space/ESC), 11-bar pairing, loc bands, heat args. OPEN micro-item: actuator outcome enum. See [`engine/viewport.md`](engine/viewport.md) "Stats / status screen" |
| C11 | **Combat sprites + cue stream** | ✅ **resolved** (2026-09-29, follow-ups closed 2026-10-13): `MECHSHAP.CMP` unit sprites (Locust/Commando 2-frame walks, wrecks, Fire/Impact `0x7C-0x7F`), documented in `InceptionTools/{Enums/SpriteEnum,AssetExtractor}.cs`. Registered by `18AD:070A`, blitted by `1000:1983` (true off `1000:0283`) at map tiles into main-`DS:0x244B`. **No persistent 80 px portrait** — `MechPortrait.cs` is an invented panel UI. **Cue stream ✅**: `0000:30BF`→player decodes 18 `00 00`-terminated entries at `DS:0x5008` into the `187F` **PC-speaker** API (PIT `0x42/0x43` + gate `0x61` — sound, not display); cue ids `0x1/0x2/0x3/0x4/0x5/0x6/0x7/0x8/0x9/0xB/0xD/0x12` mapped to call sites (kill = `0x8`). **Sprite-id** = `fn1732(0x18)` stream byte + `0x68`/`0xFA`; **timing** = blit every 4th pass (`TEST [BP-0x4],3`). **Cue workers ✅** (2026-10-13): `27C5:02A3/02EB/0345/03A8/040B` = count×(inner+delay); `0x3EB` vs `0x3EC` = leaf `0747` vs `07DA`. **Stream reader ✅**: far-ptr table `DS:[0x1F6+id*4]`, ops `FD/FE/FF`, re-armed per pass from `[0x563E]:0x25A+unit*4`. Open (need live combat trace): per-mech-type stream bytes, `0xFF`-op intent, leaf PIT details. Boot wall: NEW_GAME_INIT unreachable by space-mash. See [`combat-system.md`](combat-system.md) §28.1 |
| C11b | **ANM usage / left-panel animations** | ◐ **decoder + player + combat triggers found** — `O*.ANM` = generic 88×88 resource (top-left panel), no "combat vs story" split. **Decoder ✅** (`1000:AC12`, big-endian, `0xF20` frames; `O0`=19 ✓). **Player ✅** = `0000:48B7 play_anm(index,mode)` builds `"O<index>.ANM"`. **Combat triggers:** `O16`(0x10, firing) + `O5`(0x5, pilot) in the post-fire path (`1000:52B9`/`52EE`), `O2` at `1000:1336`; rooms via `0FDC:1C9B/1A26`. Combat clips: post-fire `O16`(firing)+`O5`(pilot); attack-selector `O1`/`O3`/`O4`/`O7`; training `O2`; default `O0`. Still open: the cutscene byte-script (site 9) → e.g. **stomp `O9`**; and site 8's scene table. See §28.1a |
| C8 | **Enemy AI beyond targeting** | ✅ **closed** (2026-10-13): weapon pick = stage-`0xB` direct/Kick rule + `0AB2`-head nth-weapon/ammo-guard other stages (`§3.1`); movement = `0971` direction-8 + `2EBB` stepper + snapshot/commit + heat/LoS/range gates (`§3.2`); auto-pilot = `[0x55F2]:0x90` → `1763` → `1631:03AB` fills `0x3800`/`0x32C6` (`§3.3`); flee = player-only, no enemy-flee logic (`§3.4`). OPEN micro-items: `469F`/`5344` fork semantics, manual-fill (`1543:0004`) corroboration, Flee-handler isolation. See [`combat-system.md`](combat-system.md) `§3` |

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
- **Canonical working tree = `Reversing/AIATTEMPT`.** Companion trees consolidated away
  2026-10-13 (`UNBATTLETECH`, `UNBATTLETECHPROVA`, `GHIDRAMCP`, `BTECH_IDA` deleted, ~1 GB freed;
  uniques harvested first — see session status). Remaining siblings are **unrelated, leave alone**:
  `ELIMAN` (C64 RE), `GAMETOOLS` (3rd-party DOS utils), `Jhora` (OpenJyotish astrology),
  `BATTLETECH_CHI` (live emulator C: mount), one 7z archive.
- Canonical data inside this repo: `game/` (full working set: BLD/CMP/MTP/O0–O21/EXE/GAME1-6) +
  `original/` (`anm/bld/cmp/exe/icn/mtp/saves` archives + `original/saves/GAME1_ghidramcp`).
  ⚠️ Found 2026-10-13: `game/` + `original/anm/` held a corrupt 259-byte `O21.ANM`; restored the
  genuine 3328-byte 1988 file (md5 `ec8f73f3…`) from the deleted trees.
- Imported from the old clones: `tools/pack/exepack.exe` (2026-09-29) and
  `reko/gencode/prototype-overrides/*.cs` (the "register one function at a time" prototype —
  kept for reference, excluded from compilation by `reko/**/*.cs`). Import verified 2026-10-13:
  content-identical modulo CRLF→LF, plus 2 deliberate registration tweaks in `GC0.cs`
  (`DefineGeneratedCodeOverrides()` off, `DefineFunction(…,0xCEC6,…)` on).
- **Generated code contains duplicated routines** (segment aliasing/overlays) — a `ghidra_guess_*`
  name is not unique. Resolve the true copy by **physical address** (`seg*16+off`) and confirm against
  the raw `UNBTECH.exe` bytes. See [`engine/segments-19ef-1000.md`](engine/segments-19ef-1000.md)
  "Duplicated functions".
- **Origin of the generated code:** produced by Spice86 during a **combat
  session** (load `GAME5` → walk into a random encounter → fight a few rounds) — `reko/gencode/GC*.cs`
  preserves it (CRLF→LF + 2 registration tweaks, verified 2026-10-13); the fresh run is `reko/gencode-current/`.
