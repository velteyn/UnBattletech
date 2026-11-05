# Work In Progress — open gaps & next actions

> **Living document.** Update on every work session so nothing is lost across network/session
> interruptions. Newest section first. Mark items `✅ done` when closed (with the commit/file).
> Last updated: 2026-11-04.

**Mini-session 2026-11-04 (S1 close-out):** docs-first, static only. Closed **S1** —
50%-per-join traitor assignment (`11B8_0D58`: `D331` slot, `D332`/`D333` latch,
`D330=0x1F` encounter side-effect; joined NPCs only); binary tell in pilot-assign
UI (`0x279D` — WT phrasings are paraphrases); interrogation vs in-battle
turn/sabotage paths + cleanup, all byte-verified with DS offsets; corrected P3's
raw-domain path list as a bonus. Filed micro-items (`374A` aliasing, sabotage
sub-branches, handler→names, single-copy builds, shop-refusal link unsupported).

**Mini-session 2026-11-05 (S8 video store):** docs-first, static (game-domain
BLD + Reko). Closed: 7000/6000 prices + `SET 0x30/0x31`, Mapper = fog reveal
(`w4FBA` refuted) + Yes/No status line, building-8 viewer gate (`0x1384`),
BARRACK2 free path. §17.11h. OPEN: `D346` identity, `D30C[0x0E]` writer (live
recipe), FROB puzzle tail (S12-adjacent).

**Mini-session 2026-11-05 (S7 garage/theft):** docs-first, static (game-domain
BLD + Reko). Closed mechanics: 150cr fee path, receipts + `F5 28` park,
`SET 18`/`D330` writes, Stinger jail theft (which/where), and the exclusion =
`D333` traitor-latch bridge (no BLD writer; S1's "unsupported" superseded for
`D333`). §17.11g. OPEN live items: F6-Yes/post-FF reachability, rampage/Kurita
text sites, theft requirements + menu-31 mapping.

**Mini-session 2026-11-05 (S3 training proper):** docs-first, static (decrypted
game-domain BLD + Reko asm + REA/Ghidra corroboration for `FUN_17dc_0629`'s
10-case switch and the `11B8_152F` caller; r2 byte-search N/A — `UNBTECH.exe` is
EXE-packed, code bytes not visible raw). Closed **S3**: dispatcher tables,
routing, `0629` grading (timer/hands/`C61B-C` gains), advance/ retry epilogues,
`3772` invasion path, tired gate, arming, F9/F3 absolute base. §25.6.12.
Remnants filed as micro-items (`C724` writer proof + T3 recipe, `C61x`
consumers/alias, `458C`, `SET 05=FA` collision, `0xD310` alias, dead `0x1BEE`).

**Mini-session 2026-11-05 (S3 quiz gate):** user flagged the pre-training written
quiz. Found + decoded it (`fn1467_08A8`, BLD-loader gate): 3 dedup'd RNG%10
mech-part questions, menu `0x25`, answer table `0x28EC` — and the crack that
neuters it (file `0x104DE`: `0xEB` where `0x74` belongs, always-pass; fail branch
+ `D320` cooldown dead code). §25.6.12. S3 grading proper (pass/fail→stat links,
timer, hands check, fail-sleep writer, invasion trigger) still open.

**Mini-session 2026-11-04 (S2 close-out):** docs-first, static only. Closed **S2** —
clothes purchase = 35cr SPEND + `D30C[0x1E]=1` + `D30C[0x24]=D330=0x7F` (fewest
encounters); jail recognition branches on uniform flag/`D336`/`D334`, PARTY uniform
gate; no central talk-refusal gate (per-BLD scripted); F9 branch targets need `_ip`
base (tooling, cf. SX1 caveat); initial `D330` default OPEN. §17.11d.

**Mini-session 2026-11-04 (S4 close-out):** docs-first, static (game-domain BLD).
Closed **S4** — apprenticeship/seminar = cases `0x0F`/`0x15`, 500cr flat each
(BLD text and code agree), +1 Tech/Medical + `C624` flags; cap is BLD-branch
text only (no code-side max; no schools anywhere). §17.11f. OPEN: cap-gate
branch mapping (interpreter `_ip`-base work).

**Mini-session 2026-11-04 (S6 close-out):** docs-first, static (+r2 spot-checks).
Closed **S6** — full repair price list byte-verified in `fn11B8_0002` (armor 4cr/pt,
structure 9cr/pt, destroyed weapons 300cr/item via bit-7 scan + `0x2FD7` names,
actuators 200cr backup-restore, heat sinks 800cr each `0xA2`→`0x22`, ammo per-bin
variable refill); **unrepairable = engine/gyro/sensors** (`+0x75..0x77` nonzero →
`DS:0x17F7` refusal). §17.11e. OPEN: ammo-price segment anomaly, cap=2 source,
garage fees (S7).

**Mini-session 2026-11-04 (C9 + BLD-domain fix + S5 purchase path):** docs-first, static
only. Closed **C9** (all `0x32C6` readers enumerated — TN modifier, `0xFF` passability
gates, pathfinding tile scan; MP decrements are fixed step costs/heat/armour-halving,
never terrain-derived; "movement cost" labels fixed). **BLD breakthrough:** the JSON
tools never decrypt — game opcodes are `dec(raw)` (`fn0FDC_1D30` loop verified +
interpreter jump table at file `0xB771` confirms F5→`1CD3_0004`, F9→menu). This
**resolves** the F5-operand mystery, retires SX1 as a tool issue (rebuild was right),
corrects P3's recruit path list (game-`E9`: ARENA/HOSPITAL/JAIL/REPAIR/CLOTHES),
and re-derives all BLD→case linkages by decrypt-scan. **S5 purchase path closed**:
REPAIR.BLD → game-cases incl `0x0F`, HOSPITAL.BLD → `0x15` (both 500cr,
`C61D`/`C61E`++ with `C624` flags); no loadout writes in `1CD3`/`0FDC`, no cap check;
reading = skill points (hospital/P1 consumers), walkthrough loadout language vs
flavor still open (T3 recipe filed). §17.11c + domain note + label fixes landed.

**Mini-session 2026-11-04 (C7 close-out):** docs-first, static only (no emulator).
Closed **C7** — infantry weapon selection (equipped-weapon alias windows `C5DB`/`C597`,
`0AB2`-bypass at `5416/5422`, skill-keyed burst accounting) + target logic (shared
`0x3800` table, no infantry-specific path; roster `[BP-0x26]` → own-skill TN deduction;
miss-path fork `5028`); reconciled combat slot map (0-3/4-11/12-15/16-23). Corrected
§23.2 (weapon→skill keying), the Initiative slot row, and the ammo-burst line.
Five live-trace micro-items filed (cap consumer, burst asymmetry, `1554` reads,
`63C6`, placement remap).

**Mini-session 2026-11-04 (P2 close-out):** docs-first, static only. Closed **P2** —
wounded = derived (`C623≠10×C615`, set by combat, dead at 0); heal = binary cases
`0x17` (scan) + `0x18` (price table `0x4F6E`, dice table `0x2601` at `caliber+4·tier`,
asm-verified N-dice loop — Reko misrendered both index and loop); corrected `0x09`
→ REPAIR_ARMOR, `0x17` → HOSPITAL_SCAN, `0x18` → HOSPITAL_HEAL mislabels in AGENTS +
3 docs (rebuild `Fn1CD3Dispatcher` mapping flagged for Track 2, no code touched).
Filed micro-items (+25cr refund, idx-32 over-read, marker decode, MedKit→B10 bridge,
`183B:124C` phase, rebuild mapping).

**Mini-session 2026-11-04 (E1–E4):** docs-first, static only. **E2/E3/E4 closed**:
settings menu `fn0800_3BD0` (SPACE-1) with all options + effects (`[0x15A]` steps,
`[0x15E]` combat pacing, `[0x15C]` sound gate, `D35B` outtake rows);
ICN loader `fn1F3D_063B` with DESTRUCT←`2DA8` / ANIMATE←`320B` / BTTLTECH←`4621`
(title chain), MAP15←`135D_055A` via `1F3D:0814`; fixed `3BD0`/`0x09`/`0x17`/`0x18`
mislabels in `memory-map.md`/AGENTS + 3 docs. **E1 partial**: Spectator noun-gate
shut (slot 13 + `E48E`), record + save evidence filed; spawner copy-path needs a
live trace (recipe in §25.5e).

**Mini-session 2026-11-04 (walkthrough × BLD sweep):** read all 3 walkthroughs cover-to-cover + all 26 BLD texts; filed **S1–S13 + SX1** story gaps above (traitor, uniform/wanted, training grading, skill-training economy, speed-shop mods, repair pricing/unrepairable, garage parking + theft, video-store items, lockpick, quiz grading, hut-map gating, map-room activation, arena mechanics). Verified covered: economy, missions/invasion, Rex/holocard, shops, P2 heal, jail rescue, quiz flags, sleep gate, ComStar, arena flow, keycard/doors, LAM/endgame, NPC movement, P1 salvage, party cap. THEATER.BLD is pure flavor (no mechanic). FROB.BLD block holds the video-store thread (check BLD→building mapping).

**Mini-session 2026-11-04 (C6 close-out):** docs-first, static only (no emulator).
Closed **C6** — infantry armour `+0x0D` type↔item map + max table, verified against
raw `UNBTECH.exe` bytes (`DS:0x4DDB` = file `0x3EF8B` = `[0,25,40,30,50,50]`, names file
`0x3E852`) and `GAME1`/`GAME5` save bytes; corrected the old `(0000:501B, 0170:4F07)`
write attribution (read vs init-zeroing; real writes are `fn0DAB_0C8F` enemy gen,
`fn1CD3:0x09→fn0FDC_13DE` shop buy, `fn11B8_0D58` recruit). Details in
[`combat-system.md`](combat-system.md) §23. (Superseded note: the "F5 `0xBA`=186"
puzzle filed here was a **raw-byte artifact** — resolved 2026-11-04, see BLD-domain
note in `formats/bld-bytecode.md`. The game decrypts BLDs at load
(`fn0FDC_1D30`: `((b+0x29)&0xFF)^0xE9` over `0xA0+`, 0x2328 bytes); raw `F3 BA` =
game `F5 0A` (SHOP_DISPATCH case 10), raw `F5 BA` = game `F7 0A`. The rebuild's
`BldLoader` decrypts identically, so its opcode model was right all along.)

**Mini-session 2026-10-14 (economy → combat):** resumed after a poisoned session
(bt_read_ds arg confusion); recovered live state, banked it to GAME5, ran the
per-keystroke watch (ESC/Up/Space clean). Parked screen was a Game6 load-fail
dialog (slot 6 has no file). Per user steer: restored original GAME5, loaded it
(training field, bD310=1), walked ~10 tiles south → full auto-pilot battle
(2 Mechs + 6 humans, Kuritans) → victory → salvage. Filed in combat-system
(setup/auto-pilot/transcript/rout×3/kick-kill/ANM/+0-pockets) + world-map
(city suppression, slot-5 route). City economy state preserved at
`/tmp/opencode/GAME5.city-rescue`. Emulator left running, post-victory on map.

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

**Still OPEN (need live combat trace):** per-mech-type `0x1F6` stream bytes; leaf PIT details;
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
[`engine/viewport.md`](engine/viewport.md) "Stats / status screen". Residuals all closed (see session status above).

**▶ Next:** (superseded — see session status above; live-trace route = Load Game, then C6/C7, P2, E1–E4, keystone T3).

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
| C6 | Infantry armour types (`+0x0D`↔FlakVest…) | ✅ **resolved** (2026-11-04, static + saves, no game code touched): `0=None,1=Flak Vest,2=Flak Suit,3=Lt Env Suit,4=Hv Env Suit,5=Ablative`; max table `DS:0x4DDB` (file `0x3EF8B`) = `[0,25,40,30,50,50]`; names file `0x3E852` (`DS:0x46A2`+). Writes: enemy gen `fn0DAB_0C8F` (`C621=RNG&3`, `C622=2×19DD`), shop buy `fn1CD3:0x09→fn0FDC_13DE` (`value=4DDB[type]`), recruit/init zero. Reads: damage halve `1000:4DF0`, move halve-if->1 `1000:3F24/183B:2474`, display `0000:501B`. Saves confirm (GAME1/5 P1 type 2/val 40). Corrects old attribution (`0000:501B` is a read, `0170:4F07` is init-zeroing). See §23 |
| C7 | Infantry AI / weapon selection | ✅ **resolved** (2026-11-04, static, no game code touched): infantry **always fire the equipped weapon** — never enter the `0AB2` recompute (`5416/5422` route actors 4-11/≥0x10 to the `542B` shortcut; only mechs 0-3/12-15 recompute). Shortcut reads `C5DB`/`C597` windows = arithmetically identical to equipped-weapon `+0x0B` (player recs 0-7, enemy recs 8-15). Burst block `4744-47B9` is actors-4-11-only, **skill-class**-keyed (`D360/D358`, `C5D4+slot·0x11+skill`; corrects §23.2's weapon-keyed text); no ammo decrement for infantry. **No separate infantry target logic exists** — shared `0x3800` table + TN path with roster `[BP-0x26]` (actor−4/−8, story `C79D`, record `C3B5`) feeding own-skill deduction `4C9B`; miss-path fork `5028` (old WIP attribution corrected — it is NOT weapon selection). Slot map reconciled: 0-3 P-mech, 4-11 P-infantry, 12-15 E-mech, 16-23 E-infantry. OPEN micro-items: `C5D4`-cap consumer, enemy-infantry single-shot asymmetry, `1554` story reads for infantry actors, `63C6` return-fire semantics, `183B` placement remap proof. See §23.2/§23.4 |
| C9 | **Terrain movement-cost** | ✅ **resolved** (2026-11-04): the label was wrong — all `0x32C6` readers enumerated (TN `+1` at `1631:0D01`/`1AE8:02E0`, `0xFF` passability gates, pathfinding tile scan at `183B:19B6`); MP decrements are fixed step costs, heat, armour-halving — never terrain-derived. See §26 |
| C10 | **Kick damage + Inferno effect** | ✅ **resolved** (2026-09-29): Kick damage = **attacker tonnage ÷ 5**, read from the mech struct `+0x10` and written into the Kick record's damage byte (`1000:4F55`, `ES:[0x3103]`). Inferno forces **0 damage** and arms the target's heat-surge counter `0xD576=3` (**+6 heat penalty/round ×3**) — `1000:50E7`. See [`combat-system.md`](combat-system.md) §27.1/§27.2 |
| U1 | **Stats/status page + combat "Scan Unit"** | ✅ **closed** (2026-10-13): two views — `fn0800_3D40`/`3FAE` overview (dims `0x0A38…` read by `3FAE` itself; `2DA8` = unit refresh/setup, no BTSTATS) vs `fn0DAB_1467`/`1AFE` detail (BTSTATS load sites `0DAB:1B58` + `1467:08A8`; field table decoded). Combat Scan = `183B:14C3` (sel 6/4) → `183B:2591` (submenu `ds:0x3D73`, guards `ds:0x3DCD`/`0x3E19`) → `0DAB:1467`. Residuals closed: `0B5E` convention (0-based, −scan arrows, Enter/Space/ESC), 11-bar pairing, loc bands, heat args, actuator mapping (`ds:0x1265/0x1269/0x126D`). See [`engine/viewport.md`](engine/viewport.md) "Stats / status screen" |
| C11 | **Combat sprites + cue stream** | ✅ **resolved** (2026-09-29, follow-ups closed 2026-10-13): `MECHSHAP.CMP` unit sprites (Locust/Commando 2-frame walks, wrecks, Fire/Impact `0x7C-0x7F`), documented in `InceptionTools/{Enums/SpriteEnum,AssetExtractor}.cs`. Registered by `18AD:070A`, blitted by `1000:1983` (true off `1000:0283`) at map tiles into main-`DS:0x244B`. **No persistent 80 px portrait** — `MechPortrait.cs` is an invented panel UI. **Cue stream ✅**: `0000:30BF`→player decodes 18 `00 00`-terminated entries at `DS:0x5008` into the `187F` **PC-speaker** API (PIT `0x42/0x43` + gate `0x61` — sound, not display); cue ids `0x1/0x2/0x3/0x4/0x5/0x6/0x7/0x8/0x9/0xB/0xD/0x12` mapped to call sites (kill = `0x8`). **Sprite-id** = `fn1732(0x18)` stream byte + `0x68`/`0xFA`; **timing** = blit every 4th pass (`TEST [BP-0x4],3`). **Cue workers ✅** (2026-10-13): `27C5:02A3/02EB/0345/03A8/040B` = count×(inner+delay); `0x3EB` vs `0x3EC` = leaf `0747` vs `07DA`. **Stream reader ✅**: far-ptr table `DS:[0x1F6+id*4]`, ops `FD/FE/FF`, re-armed per pass from `[0x563E]:0x25A+unit*4`. `0xFF` = caller-peek-guarded dead branch (resolved 2026-10-13). Open (need live combat trace): per-mech-type stream bytes, leaf PIT details. Boot wall: NEW_GAME_INIT unreachable by space-mash. See [`combat-system.md`](combat-system.md) §28.1 |
| C11b | **ANM usage / left-panel animations** | ◐ **decoder + player + combat triggers found** — `O*.ANM` = generic 88×88 resource (top-left panel), no "combat vs story" split. **Decoder ✅** (`1000:AC12`, big-endian, `0xF20` frames; `O0`=19 ✓). **Player ✅** = `0000:48B7 play_anm(index,mode)` builds `"O<index>.ANM"`. **Combat triggers:** `O16`(0x10, firing) + `O5`(0x5, pilot) in the post-fire path (`1000:52B9`/`52EE`), `O2` at `1000:1336`; rooms via `0FDC:1C9B/1A26`. Combat clips: post-fire `O16`(firing)+`O5`(pilot); attack-selector `O1`/`O3`/`O4`/`O7`; training `O2`; default `O0`. Still open: the cutscene byte-script (site 9) → e.g. **stomp `O9`**; and site 8's scene table. See §28.1a |
| C8 | **Enemy AI beyond targeting** | ✅ **closed** (2026-10-13): weapon pick = stage-`0xB` direct/Kick rule + `0AB2`-head nth-weapon/ammo-guard other stages (`§3.1`); movement = `0971` direction-8 + `2EBB` stepper + snapshot/commit + heat/LoS/range gates (`§3.2`); auto-pilot = `[0x55F2]:0x90` → `1763` → `1631:03AB` fills `0x3800`/`0x32C6` (`§3.3`); flee handler isolated (25% roll, Jenners/arena gates, two `eluded` exits) + enemy infantry rout (straggler `>0x19`, 50% remainder) (`§3.4`); `0x3800` writers/readers enumerated (no `5650` reads — heat alias); actuator mapping closed; `0xFF`-op = caller-peek-guarded dead branch. OPEN micro-items: `469F`/`5344` fork semantics, `3772`/`[bp+6]` enums, rows-12–23/`0x380A`/`0x3890` details. See [`combat-system.md`](combat-system.md) `§3` |

## Post-combat & party (to uncover)

| # | Gap | Status / findings |
|---|-----|-------------------|
| P1 | **Salvage phase (post-combat)** | ✅ **mechanics decoded** (2026-10-13, decompilation only — `reko/gencode/GC5.cs` + `GC10.cs`, no game code touched): three routines on the `1000:1ABA` victory path — **`0000:71B2`** per-unit armor scavenge + scrap (actor = max-`C61D` unit; `C61D` = equip-slot-5 purchase count; tier suffix via 3-entry far-ptr table `DS:0xFA2` → `2/3/4` upgrades = heat sinks / +weapons / +structure; armor top-up from wreck `C33C` sums with min-cap; scrap = Σ(`RNG&0x7F`+90)×actor-slot → dword `D370/D372`), **`0000:76A9`** wreck→mech grant (pilot loop slots 1-7, Y/N `0000:3113`, `0x7D`-byte wreck copy + `C620` link + `D55E`/`C799`/`C79A`/`C743` writes; effective gate `C743≠0 ∨ maxC61D≥4` — the `C799/C79A` bar compares are outcome-redundant), **`0000:7AFB`** pockets (Σ(`RNG&0xF`+3), floor 2 → `D370/D372`) + swap (`0x10E5`, `AAA6`). Y/N = `Yes\0No\0` menus (file `0x3AA30`), no ASCII compares. OPEN: bar↔Tech identity, `C743/C744/C620`-band/`3954` semantics, `maxC61D>4` overrun, scrap ×slot intent, `AAA6` writes + runtime differential. See [`combat-system.md`](combat-system.md) `§25.6` |
| H1–H3 | **Hidden-mechanics hunt** (user-prompted 2026-10-13) | **H1 ✅** (string/data sweep, 919 strings): all five named files REFERENCED (DEMOFILE/TINYLAND/WWOODBT/ENDMECH/INFOCOM×3 load sites in file-formats.md); **Spectator record + kill-noun found** (false "not in EXE" claim fixed); settings cluster (`Change movement rate`, `Fastest`, `Show Outtakes`, `Turn Sound On/Off`, combat-speed steps — menu fn ~vaddr `0x3BC0`, effects open); lounge bark directory (file `0x1EE0`); kill-noun/health-tier cluster inventoried; post-combat outcome strings in §25.6; map-room/dismount strings noted. No debug menus/easter eggs (only credits + Baker joke). **E1 ◐** (2026-11-04): Spectator
kill-noun gate shut (`1AE8:06C5` — slot 13 + `E48E` from room entry `0FDC_1C9B`; static
record index 6/8 file `0x2B85E`; dead one persists in GAME1 story slot 5) — copy path
(`[0x5436]:0x2DF8` 3-pointer table, `C530` gating) needs a live trace. **E2 ✅**
(settings = `fn0800_3BD0`, SPACE option 1; movement `[0x15A]`, combat speed `[0x15E]`,
sound `[0x15C]`, outtakes `D35B` — cases + effects mapped, `input-navigation.md`).
**E3 ✅** (loader `fn1F3D_063B`: DESTRUCT←`fn0800_2DA8`, ANIMATE←`fn0800_320B`).
**E4 ✅** (BTTLTECH←`fn0800_4621` title chain; MAP15←`fn135D_055A` via `1F3D:0814` —
`file-formats.md`). **H2 ✅**: O17–O21 scene clips etc. **H3 ✅**: Flee isolated (25% roll, Jenners/arena gates, two `eluded` exits, evade gate), `0xFF`-op = peek-guarded dead branch, actuator mapping closed, `0x3800` enumerated (no `5650` reads), enemy rout ×2 (§3.4). P1 trace done (see P1 row) |
| P2 | **Party injuries** | ✅ **closed** (2026-11-04, static + saves-adjacent, no game code touched): **wounded = derived state** (occupied + `C623 ≠ 10×C615`; set by combat damage `1AE8_08BC`, dead at 0). Report branch (`D335≠0`): `0x25A4` "need more time" vs `0x25CF`/`0x2591` "Nobody is wounded". **Heal = binary cases `0x17` (scan `1CD3:0CF8` → `D325`) + `0x18` (price `DS:0x4F6E[D326]` = 0/50/…/750 → deduct → `fn1431:000A`)**: per wounded slot `heal = (N×d6 19F3) × M` capped at max, `(N,M)` from `DS:0x2601` at idx `caliber + 4·tier` (asm-verified; Reko's flat-sum/index rendering wrong on both counts); tier = `D326`/best-Medical, caliber = 1+`D450`+(+1 if med≥3 & `D451`)/hired 2-or-4; e.g. Trainee 2d6≈7, self post-training ≈4d6. Paths: hospital, SPACE-menu free field heal (`0800:2D72`), encounter flow (`183B:124C`, phase OPEN). Corrects `0x09`→REPAIR_ARMOR, `0x17`→HOSPITAL_SCAN, `0x18`→HOSPITAL_HEAL mislabels (AGENTS + 3 docs fixed). OPEN: +25cr fail refund, idx-32 text over-read (harmless, capped), BLD marker→digit decode, MedKit/FieldSurgery mechanical role (→B10 day-cycle), rebuild case mapping (Track 2). See §23.7/§23.8 |
| P3 | **New pilots joining** | ✅ **mechanism decoded**: BLD opcode `0xE9 CALL_ROOM_HANDLER` → `fn11B8_0D58` (`11B8:0D58`): finds an empty slot (0-7), assigns a unit id, rolls attributes with 2D6 (`fn0800_19DD`), sets health `0xC623` = attr×10, `0xC620 = 0x08` (unlinked), fills inventory `0xC618[0..6] = RNG&1`, links the unit to a free **story slot** (`0xC724`, stride 0x7D), then renders the name (`fn1E56_03F5`). Recruitment *paths* (corrected 2026-11-04 — old "(barracks/party/story)" list was raw-byte domain): game-`E9` sites are ARENA(9), CLOTHES(2), HOSPITAL(6), JAIL(4), REPAIR(5) (operands = handler tags; verify against decrypted streams, not the JSON's raw-domain `E9` labels). |

> These are **currently undocumented** (no canonical section yet). Once traced, fold them into
> [`combat-system.md`](combat-system.md) (post-combat resolution) and/or
> [`story/story-system.md`](story/story-system.md) (party/roster).

## Story gaps (walkthrough × BLD sweep 2026-11-04)

Every claim in `docs/walkthrough/bt-walkthrough-{1,2,3}.md` and every thread in the
26 BLD texts (`docs/story/STORY_TEXT.txt`) checked against the docs. Covered already:
allowance/stocks/save-gambit (B10), 8 missions + invasion + escape routes, Rex/box/
damaged-holocard, weapon/armor shops, hospital heal (P2), jail rescue + Stinger,
Tellhim + quiz flags (`D30C` 0x30/0x31/0x36), mayor viewer, barracks sleep gate,
ComStar, arena *flow*, keycard/doors (INSTRUCT), LAM + endgame, NPC movement (§18),
salvage incl. weapon confiscation (P1), MedKit sold, party cap. **Missing:**

| # | Gap (walkthrough + BLD source) | Status |
|---|--------------------------------|--------|
| S1 | **Traitor system** — ✅ **closed** (2026-11-04, static): 50%-per-join assignment in `11B8_0D58` (`D331`=slot, `D332`/`D333` latch, `D330=0x1F` encounter side-effect; joined NPCs only — never Rex); game-`E9` sites ARENA/HOSPITAL/JAIL/REPAIR/CLOTHES (hospital/jail match WT); binary tell in pilot-assign UI (`0x279D` unease line — WT "nervous"/"not right" are paraphrases, not game strings); two resolution paths (interrogation if `C620==8` vs in-battle turn/sabotage); cleanup clears slot + disarms. OPEN: `[0x55FE]:0x374A` gate aliasing, sabotage sub-branch conditions, E9-handler→specialty semantics (byte-verified write, live-verify values), single-copy builds, shop-refusal link (D332 never read — WT claim unsupported in code). See §25.6.11 |
| S2 | **Uniform + wanted tracking** — ✅ **closed** (2026-11-04, game-domain bytes): clothes purchase = 35cr SPEND + `D30C[0x1E]=1` (uniform flag) + `D30C[0x24]=D330=0x7F` (min encounters — the "don't stand out" mechanic). JAIL recognition branches on `D30C[0x1E]` (uniform) / `[0x2A]` (=`D336`, BLD-local jailbreak marker) / `[0x28]` (=`D334`); PARTY also tests `0x1E`. No central talk-refusal gate (BLD-scripted per building); services-closed-while-agent unsupported; F9 branch targets need `_ip` base (tooling, cf. SX1). BARRACKS swap is scripted story. Initial `D330` default OPEN. See `story-system.md` §17.11d |
| S3 | **Training grading + entry quiz** — ✅ **closed** (2026-11-05, static): quiz gate + crack as before (§25.6.12); **training proper closed**: `F3 idx=0` mission dispatcher (entry/fail/pass tables + Chameleon sub-table), `D30C[0..5]` roles, `F7 04/01` routing, grading engine `fn0FDC_0629` (Ghidra-corroborated; timed ticks<0xD7, rubble `C724≠0x4C` hands gate, combat wins `C61B/C61C+=RNG&1`), pass→`D30C[0]++`/fail→retry, invasion via `[3772]` (arg6 50%/arg7 always → `D310/D311`) = 6th/7th-visit variability, tired gate (`F7 13`, BARRACKS sleep one-time), arming (`4DC7` zeroing, `3938=1` new-game; `458C` never nonzero statically), F9/F3 absolute-base closed. OPEN micro-items: `C724=='L'` writer proof (T3 recipe filed), `C61B/C61C` consumers + strided alias, `458C` purpose, HOSPITAL `SET 05=FA` collision, `0xD310` alias audit, dead `0x1BEE` text. See §25.6.12 |
| S4 | **Skill-training economy** — ✅ **closed** (2026-11-04, game-domain): apprenticeship = case `0x0F` (500cr per BLD text + code, +1 Tech, `C624` bit 0); seminar = case `0x15` (500cr despite "astronomical" flavor, +1 Medical, `C624` bit 1); checks `0x10/0x16`. Cap *text* exists both sides ("tech school" / "medical college" — no such schools anywhere, verified absence) but the gate is a BLD branch, and `0x0F`/`0x15` have **no code-side cap** (repeats allowed where offered). OPEN: exact cap-gate branch mapping (needs interpreter `_ip`-base resolution — SX1-caveat family). See §17.11f |
| S5 | **Speed-shop mods** — offers cataloged (REPAIR.BLD: Locust→MLs, Wasp→drop SRM+armor, Stinger stacks, Commando→drop pack+MLs+armor, engine swap, Wasp-kit, Stinger-kit, Blazing Inferno; +apprenticeship/repairs/ammo/tech recruit). **Purchase path confirmed** 2026-11-04 via decrypted-`F5` scan: REPAIR.BLD → game-cases incl `0x0F` (500cr, `C61D++`) + HOSPITAL.BLD → `0x15` (500cr, `C61E++`); checks `0x10/0x16`; **no loadout-structure writes exist** in `1CD3`/`0FDC` (byte-verified) and no cap check in `0x0F/0x15`. Reading: `C61D/C61E`++ = personnel +9/+10 (Tech/Medical — hospital/P1 consumers read them as skills); per-mech texts are flavor for an abstract upgrade paying off via salvage tiers (P1) + heal table (P2) + TN deduction. Alternative (dedicated counters) needs segment-`0x569E` identity or live buy-and-dump. OPEN: cap=2 source, loadout-effect proof (T3 recipe), "stack small lasers" vs flavor (WT1/2/3) | ◐ purchase path closed, effect open |
| S6 | **Repair pricing + ammo purchase + unrepairable class** — ✅ **closed** (2026-11-04, static): armor 4cr/pt (`11B8:0282`, quote points×4 via SHL 2), structure 9cr/pt (`0x1C` loop), destroyed weapons 300cr/item (bit-7 scan `0x33..0x55`, names via `0x2FD7` table, `AND 0x7F` restore), actuators 200cr (backup restore), heat sinks 800cr each (`0xA2`→`0x22`), ammo per-bin refill (variable `[BP-0x0E]`, `INC C74B`, qty via `1543:0CDE`; "too heavy" is flavor). **Unrepairable = engine/gyro/sensors** (nonzero `+0x75/+0x76/+0x77` → `DS:0x17F7` refusal). Personal armor separate (case `0x09`); skills separate (`0x0F/0x15`). OPEN: ammo-price segment anomaly, cap=2 source, garage fees (S7). See §17.11e |
| S7 | **Garage parking + jail theft** — ◐ **mechanics closed** (2026-11-05, static): fee **150cr** (`CHKCR/SPEND/SHOW_CREDITS` + bill/"leech" texts), receipts flavor + `F5 28` slot-clear on park, `SET 18` flag, `D330` 0/1 writes, impound rule, Kurita-refusal text; theft = JAIL impound yard → **Stinger** (medium-laser cover, `F5 40`/`F5 39` flank, `SET 2A` + `E9 4` nearby); **exclusion = `F7 0x27` = `D333` (S1 traitor latch — no BLD writer; only `11B8_0D58` roll; WT refusal correlation now supported via `D333`, superseding S1's "unsupported")** + 6 code readers enumerated (shop `0800_378D`, status `0DAB_18E8`, AI `1631_03AB`×2 spare-the-traitor, pilot tell, post-combat gate); HOSPITAL `F7 27` scorn text linearly dead. OPEN (live): fee/park effect reachability (F6-Yes silences + post-FF blocks — dead or re-entry?), rampage/Kurita text sites, theft requirements + menu-31 mapping (WT: mechless-gated). See §17.11g |
| S8 | **Video-store items** — ✅ **closed** (2026-11-05, static): FROB.BLD electronics store (`F9m 36`): player **7000cr** (`SET 0x30`), Mapper **6000cr** (`SET 0x31`, "snapshot view" — WT "larger map" is paraphrase); **Mapper effect = fog reveal** (`0800:0107–01B1`: 8×`0xFF` into `0xCB0C` vs single-bit ORs) — **`w4FBA`-mode hypothesis refuted** (E2: separate UI system); Mapper Yes/No status line in `0800_378D` roster; viewer gate = building-8 + `D33C` + `D31A` → `0x1384` auto-play + `0008(0x12)`; free path = BARRACK2 wreckage (`F7 0E`, Rex lookout). OPEN: `D346` gate identity, `D30C[0x0E]` disk-flag writer (none found anywhere — live recipe filed), FROB `0xE00+` puzzle remainder (S12-adjacent). See §17.11h |
| S9 | **Mayor lockpick entry** — pick-the-lock skill check (WT3 + MAYOR.BLD) | ⬜ micro-item |
| S10 | **Hut quiz grading** — per-question skill checks, pass/fail routing, "stumped"→training loop (WT2/3; flags `D30C` covered, grading not) | ⬜ micro-item |
| S11 | **Hut-appears-on-map gating** — holocard view → hut tile unlock flag (WT3) | ⬜ micro-item (world-map) |
| S12 | **Map Room planet activation** — 7 touch-panels → password → white-code check (copy-protection external); E4 closed the load only (WT1/2/3) | ⬜ micro-item |
| S13 | **Arena mechanics** — rental implementation + deposit/fee code + forfeiture ("scraps become Arena property"); 500cr award site (WT3 says 250 — discrepancy); western-stands exploit + Starport-ban flag (no "ban" strings in EXE); UrbanMech chance; crowd-boos reachability (WT1/2/3 + ARENA.BLD; flow covered 2026-11-04) | ⬜ open |
| SX1 | BLD byte domains — **clarified, not a bug** (2026-11-04): the `F5`-range "mystery" was a raw-byte artifact. The game decrypts BLDs at load (`((b+0x29)&0xFF)^0xE9` over `0xA0+`, `fn0FDC_1D30`); the JSON tools show **raw** bytes (text layer correct via composite cipher, opcode layer mislabeled: raw-`F3`→game-`F5`, raw-`E7`→game-`F9`, raw-`E9`→game-`FB`, raw-`F5`→game-`F7`, raw-`F7..FF`→markers). Game-domain `F5` cases re-derived by decrypt-scan (ARMOR 9,10,12-14,31,32; HOSPITAL 10,12-26; REPAIR 10,12-20,29,44 — all ≤47; rebuild correct). Caveat stands for JSON consumers: never cite JSON opcode names/operands/targets; decrypt first (see `formats/bld-bytecode.md` domain note). Game-`E9` recruit sites re-derived: ARENA(9), CLOTHES(2), HOSPITAL(6), JAIL(4), REPAIR(5). |

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
| B10 | Cadet economy / day-cycle code | ◐ live-validated 2026-10-14 (`docs/economy.md`): holdings `D374/D378/D37C`, 26 B table stride, buy/sell exact, allowance ticks observed; open: fee/tick isolation, finance block, price source tables, refresh conditions |
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
