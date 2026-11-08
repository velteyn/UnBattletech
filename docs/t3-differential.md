# T3 Combat Differential — Phase 1 design

> Status 2026-11-08: RNG recovered statically (no live work needed). Rebuild RNG
> fix specified; trace/comparator v1 scoped. **Deterministic staging is solved:**
> the shipped record/replay engine is the universal key-wait, proven live
> (`[0x3938]=1` + a key script = full scripted play, mid-game). Emulator paused.

## Goal (Phase 1)

One scripted 3-round battle, fixed setup, scripted orders both sides (no AI).
Per-round JSON trace each side (unit pos/armor/hit-miss/kill + RNG state).
Comparator replays the original's draws from recorded pre-state and flags
divergences. Done = one battle traced end-to-end with draw counts aligned.

Non-goals: AI-vs-AI (Phase 2), menus/shop/story draws, sound, graphics.

## Original RNG (verified static, `reko/gencode-combat`)

- Single source: `19FC:0BC0` — the ONLY byte roller. No `0x1021`, no LFSR, no
  INT 1Ah per-roll in any dumped caller (26 call sites, all funnel here).
- State: 3 bytes at `ES:0x4FC0` with `ES=0x3858` (main DS). **Correction 2026-11-08
  (was: "no other writer")**: a seed **writer exists in the shipped image** — the
  attract-demo path writes `[0x4FC0]=0x1325` and `[0x4FC2]=0x0090` right after
  `fread("DEMOFILE")` (see [`tools/staging-triggers.md`](tools/staging-triggers.md)).
  Normal play never takes that path, so for a normal-play session the state is
  still a pure function of draw count since boot; the old "no writer in either
  dump" was a **dump-coverage artifact** (the demo path never executed).
- Image default (file `0x3F170`): `04 03 02`. Live 2026-11-08: `91 b8 9b`.
- Step (order matters; `rcl/rcr` single-bit through CF):
  ```
  carry = (s0 >> 1) & 1; al = s0 >> 2
  s2 = rotl1(s2, carry); carry = old bit7(s2)
  s1 = rotl1(s1, carry); carry = old bit7(s1)
  carry = ~carry
  al = (al - s0_old - carry) & 0xFF
  c = al & 1; al >>= 1
  s0 = (s0_old >> 1) | (c << 7)
  return (s0 ^ s1) & 0xFF        # AH = 0
  ```
  Preserves BX/CX/DX/DI/SI (only AX + flags clobbered) — so caller leftovers
  (e.g. CX≈damage at 12C7 entry) survive RNG calls. This CONFIRMS the "regs are
  caller leftovers" verdict by mechanism.
- Single die `017D:19F3`: `0BC0(); v = AX & 7; if (v > 5) re-roll; return v+1`
  (rejection — rejected draws still advance state). Rebuild `RngDie` shape was
  already correct; only the byte source was wrong.
- 2D6 `017D:19DD`: die()+die(). Rebuild `Roll2D6` shape correct.

## Draw-order table (combat path, `1465:000C` region)

| Site | Call | Purpose (static, verified) | Rebuild counterpart |
|---|---|---|---|
| `1465:07DE` | 19DD (2D6) | roll in targeting region (open: TN build vs confirm) | ComputeTargetNumber + Roll2D6 |
| `1465:093F–098D` | link + 19DD + 2 tables | hitloc: `[BP-70]`=link (`2A0F:[BX+0x396C]`, `FF`→fallback `0x45B6`); row=`[0x2D11]`[link−[BP-96]]; **hitloc=`[0x2E40]`[row×11+2D6]** (roll 2..12 = 11 cols directly); `AX≥0x0C→−8` slot normalize | RollHitLocation — SUSPECT, structurally wrong (`& 0x0A`+6-table vs 2D6+2-level table) |
| `1465:0990–09EE` | mod-5 + raw 0BC0 | gated on `[BP-72]==0x20`: mech-check, `idiv 5` quotient→`[0x3103]`, bit-3 pick `[0x2E43]`[0/8]→`[BP-96]` (override) | — open |
| `1465:09F1–0A0F` | — | **SI=`[BP-72]`×`0x11` (stride live+static ✓)**; dmg=`[SI+0x2EE3]`, flags/count=`[SI+0x2EE4]` (bit7=tested: set→destroyed-path, open) | GetWeaponDamage — verify per-record |
| `1465:0A1A–0A3C` | 19DD (2D6) | cluster (skipped if count≤1): `7×2D6+count` → shared table `[0x2E5E]` → hits; `[BP-124]`=hits×dmg | RollClusterHits — SUSPECT (shared stride-7 table vs 4 size classes) |
| `1465:0BC2` | `sub ES:[BX-14556],CL` | **THE story-armor write (watchpoint-proven ×4 live 2026-11-08)**: BX=`0x7D`×slot+hitloc (hitloc = story offset `0x11..0x1B` directly), −14556≡+0xC724. CX=damage=record-byte0 (MG 2, SRM 2, ML 5). Text/stats skew: text name = stats[idx−1] (×3). DI = attacker combat X | ApplyLocationDamage — target formula exact; add text-skew map + halve step |
| `1465:085B–08FE` | per-shot loop (`[BP-52]`=count byte) | **halve-if-armored** (`sar` dmg when armor>0), armor→0, structure overflow, `sub` per iteration; `[BP-86]`=`[BP-6]`=1 per shot | ApplyLocationDamage — SHAPE ✓ (halving is new) |
| `1465:0CD3` | 12C7 setup | 10-word frame order: `[BP-86],[BP-12],[BP-58],[BP-44],[BP-6],[BP-88],[BP-72],[BP-40],[BP-2]`+`DX:AX` | probe context decoded |
| flags | — | `[BP-86]`=hit(1)/miss(0), `[BP-44]`=bypass(structure-0 precheck), `[BP-58]`=kill (via `0EC0:0A35`, uncovered by dumps), `[BP-88]`=geometry copy of `[BP-96]`, `[BP-40]`=defender/`FFFF`, `[BP-2]`=counter | — |
| `1465:0A42–0A4F` | 19DD vs `[BP-48]` | **to-hit: 2D6 < TN → `0x3EDE` Missed**; TN = `[BP-92]`×2+4 (action×2+4 ✓ rebuild shape), kick (`[BP-72]`==`0x20`)→3 ✓, + table addends (`1B44` skill ×2; `[0x5654]` terrain+1; `[0x5656]` table; `>>3` term) | ComputeTargetNumber — shape ✓, sources → tables |

Non-combat 0BC0 callers exist (017D system ×8 incl. die roller, c3 menu/BLD ×11,
0FAE ×1, 11B8 ×3) — encounter/elude/shop draws interleave BEFORE battle start.
Phase 1 controls this by snapshotting state AT battle start and scripting from
there; full-boot determinism is Phase 2.
**Known second stream (P2):** `BldInterpreter.RollD6` uses `GD.Randi()`, but the
original funnels BLD/menu draws through the same single `0BC0` state — rebuild
currently runs two independent streams. Route BLD through `CombatRng` in P2.

## Static data map (all segs live-verified; tables = `0x3858`)

- Hitloc row table `0x2D11`, hitloc table `0x2E40`, bit-3 table `0x2E43`,
  cluster table `0x2E5E` — **byte-identical in EXE image** (`file = 0x3A1B0+off`
  verified live-vs-file) → verifiable offline, zero heat.
- Weapon records `0x2EE3`, stride `0x11`, layout stats[6]+name[11]
  (byte0=dmg, byte1=count/flags; idx0=Knife, idx0x10=LargeLaser dmg 5,
  idx0x17=Flamer dmg 2) — **NOT in image** (file shows pointers there) →
  runtime-initialized, read live only. Weapon-source hunt open. Live
  name↔idx correlations (MedLaser/MG/SRM) now SUSPECT (idx0x10 reads
  LargeLaser; enemy text↔SI mapping needs re-pairing per round).
- **Full 33-record table captured live 2026-11-08** (see WIP mini-session):
  melee rows 00–0E all byte1=`0x81`, idx9 "SR Missile" `0x84`, idx0B
  "LaserPistl" dmg `0xFF` (empty-marker?), idx20 empty, Inferno/Kick clear.
- Cluster mechanism: single-shot iff byte1≤1 (LRM5 correctly skips);
  else hits=`[0x2E5E]`[byte1+7×2D6], total=hits×dmg. Decoded windows:
  SRM4 1..2, SRM6 1..4 (≠ tabletop 6 — original stands), LRM10 1..5,
  LRM15 3..10, LRM20 5..15. **SRM2 (base 8) anomaly: window reads 6..20 —
  impossible for a 2-rack; record possibly stale/unused. DO NOT "fix".**
  Needs live firing test (E3).
- Melee/odd branch: byte1 bit7 set → `0A05 jmp 0CD3` = straight to the 12C7
  call, bypassing ALL damage/to-hit/cluster computation. `0CD3` pushes the
  full 10-word frame: `[BP-86],[BP-12],[BP-58],[BP-44],[BP-6],[BP-88],`
  `[BP-72],[BP-40],[BP-2]` + `DX:AX` (+CS = 12 words ✓) — caller-frame
  Rosetta stone (local-by-local mapping now trivially next).
- Segments: tables/`0x5656`/`0x5652`/`0x5668`/`0x566A`/`0x566C` = `0x3858` (static);
  **correction (live 2026-11-08):** `0x5654`/`0x5662`/`0x5416`/`0x563C`/`0x5666`/`0x5648`/`0x5412` = `0x2A0F` (story/live; terrain/heat/fog are map-state, zeros at field).
- TN formula (all shapes verified vs rebuild `ComputeTargetNumber`): base action×2+4, kick→3,
  + skill (`[0x5656]` table: `00 00 00 01 01 02 02 03 03 03 04 04 04…`, or `1B44`×2 for kick),
  + terrain (story `[0x5654]`+1), + heat (`[0x32AE]`>>3 hypothesis), + story (+2 on nonzero byte).
- Wrap-up callers (both in `11B8:000A` scan): per-unit restore `0728:0002` (link≠FF + status≠0;
  NO rout-gate — rout restores too, presumably; E4 optional); crit path `0728:04F9` UNRECOVERED.
- E2: saves don't store RNG (no writer in dumps + load draws exactly 76; caveat: dumps = executed paths only).

- `[0x5648]` NEVER rewritten in either dump → story seg throughout; 08xx (`0x11`×idx−14814) target is NOT story-armor for any integer idx (watchpoint queued → answered below: 0BC2 is the armor write; 08xx target still open, ammo suspect).
- Post-victory wrap-up (0728 loop, live 2026-11-08): restores armor FROM `+0x56` template (direction proven — template bytes unchanged; mid-loop transient observed via watchpoint re-trips). Battle armor damage is TRANSIENT; scavenge text = the repair. Rout can pay (13cr observed). Enemy slots (4,5) zeroed.
- Nibble-masked `[BP-124]` entry (`& 0x0F` at 07A8) vs full-byte at 0A08: RESOLVED via text/stats skew — MG-enemy uses idx `0x17` (dmg byte0=2 ✓), ML-enemy uses idx `0x10` (dmg 5 ✓). damage=byte0 stands in all verified cases; `0x14` record (idx `0x16`) is simply not the fired record.
- `0EC0:0A35` (live disasm 2026-11-08): kill cleanup — fog→0, destroyed=1, roster `0xFF` scan. Called with destroyed slot; explains roster removals.
- `0728:04F9` (recovered): max-status selector + fog scan (crit path).
- Draw census (live disasm 2026-11-08): per-shot draws ALL in `1465` — `000C`: `07DE,0976,09D9(raw),0A1F,0A47` + `12C7`: tail `19DD` at `1E52` (+10× cue `19BF` sound, no dice). `1000`: ZERO dice (`4889–4C3F` = TN/messages/strings). Order fixed → T3 replays deterministically. `0728` (×4) + `0FAE` (×1) draws are wrap-up-phase.
- Heat EXACT: thresholds `8/0xD/0x11/0x18` on `[0x6E]` and `[0x66]` pools (= rebuild 8/13/17/24 ✓).
- Beam window: `12C7:1CDB–1D11`, class-invariant per call; shape id varies via `13D9`; E5 (per-shot shape log) + SRM streak count open.
- 08xx branches complete; halve does NOT reach story (0A08 resets full; 0BC2 writes full). 08xx = pre-slot scratch loop, purpose open.
- Caller-frame decode: 7 of 9 locals closed (open: `[BP-6]` beyond loop-flag, `[BP-58]` trigger conditions).

## Trace format v1 (per round)

```json
{"round":1,"rng_pre":"91b89b","rng_post":"…",
 "units":[{"slot":0,"x":..,"y":..,"armor":[..11..],"alive":true}],
 "rolls":{"to_hit":[..],"hitloc":[..],"crit":[..]},
 "msgs":["…Hit…","…Missed!…"]}
```

Sources: HTTP range reads (armor `0x2A0F0+0xC724+slot*0x7D+0x11`,
rng `0x38580+0x4FC0`), `03F5`/`12C7` probe log lines, screenshots.
`tools/playtest/t3_trace.py` implements snapshot + diff (manual drive in v1;
scripted orders = v2).

## Comparator v1

Input: pre-round rng state + scripted orders. Replay: run `CombatRng` draws in
rebuild order, compare vs recorded original post-state + outcomes. Divergence
classes: D1 draw-count mismatch (order bug), D2 value mismatch (algo bug),
D3 outcome mismatch with draws aligned (rules bug). D1 is expected first —
that IS the diagnostic.

## Rebuild fix checklist

1. ✅ New `CombatRng` (Godot-free): exact 0BC0 step, 3-byte state, image
   default `04 03 02`, `SetState` for harness. `CombatResolver` delegates.
   `RngDie`/`Roll2D6` keep shape (verified vs `19F3`/`19DD`).
2. Runner vectors from image seed: bytes `04 8d 58 90 …`, dice `5,6 / 1,1 …`.
3. OPEN (not Phase 1): `RollHitLocation` vs `09D9` bit-3 table + `0971`
   geometry + mod-5 `09C0` — needs caller-frame decode first.
4. OPEN: `19FE` (inner die-call offset seen once as CX) — mechanism unknown.

## Experiment queue (all closed or moved live — updated 2026-11-08)

- E1 (fresh-boot reseed): CLOSED for normal play. Image `04 03 02` at boot → #272 at title → #348 post-load. Never reseeded *on the normal path*; pure draw-count. Harness: seed image default or snapshot-and-continue. **Caveat 2026-11-08:** the demo/attract path *does* write the state (`0x1325/0x0090`), so "no writer exists" is false and RNG-injection is a legal, in-binary operation (we use exactly that to stage).
- E2 (save coverage): CLOSED static — saves do not store the 3 state bytes; GAME5 load consumes exactly 76 draws. Reload determinism therefore requires the post-load draw count, not a stored seed.
- E3 (per-round snapshots): tooling live-verified (`t3_trace.py`); needs scripted battle loop (v2). **Scripted input is now solved (2026-11-08):** set `[0x2A0F:0x3938]=1` + `[0x2A0F:0x39F8]=<index>` + write key codes at `0x2A0F:0x27B0`; the universal key-wait *is* the replay player (`173D:0259` → runtime `18BA:0259`), `kbhit` returns 1 while `[0x3938]≠0`, and all four side-effect branches are input-only. Proven live mid-game (25 script bytes consumed). Use this instead of RNG-clocking for staging; pad with `0x48` delays. See [`tools/staging-triggers.md`](tools/staging-triggers.md#the-replay-wrapper-is-the-universal-key-wait--proven-2026-11-08).
- E4 (rout-restore): open — damaged-then-rout battle: does wrap-up restore without victory?
- Wrap-up loop (`0728:00C7–018D`): pool = Σ enemy slots (12–15→story 4–7, `[0x393C]`-gated) remaining armor; per-loc-descending min(need,pool) to party 0–3; net = armor:=template on victory.

## Why Phase 1 got easier (2026-11-07/08 findings)

No-copy verdict → comparison points are plain story reads (no snapshot
reconstruction). 12C7 signature → probe columns are context; CX mirrors
damage; draw sites identified. Full 11-location armor map → damage assertions
are amount-exact.

## Weapon table (live `0x3858:0x2EE3`, stride `0x11`, stats[6]+name[11], 2026-11-08)

byte0=damage (verified 2/2/5 live), byte1=count/flags (`0x80`=skip mech-fire path),
byte5 nibble→heat accumulator. **Text/stats skew ×7+**: text name = stats[idx−1]
(MG 0x16↔0x17, SRM2 0x1C↔0x1D, ML 0x0F↔0x10, LL 0x10↔0x11 (dmg 8 ✓), PPC 0x11↔0x12 (10 ✓),
AC/2 0x12↔0x13 (2 ✓), AC/5 0x13↔0x14 (5 ✓), AC/10 0x14↔0x15 (10 ✓)). Rebuild `WeaponData`
damages match THROUGH the skew (all ✓); heats mostly 3 in binary vs varied rebuild (open);
kick special-cased (`[BP-72]`==`0x20`→empty record + TN 3 + mod-5 path; `0x1F` row name-only?);
melee byte0 (17–48) never fires (meaning open — price?); `0x0B` LaserPistl dmg `0xFF` = empty marker.

```
idx name         dmg flg b2 b3 b4 ht5
00 Knife         17 81  00 21 02 00
01 Sword         16 81  00 21 02 00
02 VibroBlade    34 81  00 21 02 00
03 Shortbow      48 81  00 21 02 00
04 Longbow       17 81  00 66 09 00
05 Crossbow      19 81  00 87 0D 00
06 Pistol        35 81  00 88 0E 00
07 Rifle         35 81  00 65 09 01
08 MachineGun    48 81  00 F0 1F 02
09 SR Missile    48 84  00 88 0B 02
0A Inferno        2 01  00 FF 28 03
0B LaserPistl   255 01  00 FF 28 03
0C LaserRifle    64 81  00 87 0D 01
0D Flamer        66 81  00 F6 2B 02
0E SmallLaser    32 81  00 65 07 01
0F Med Laser      3 01  01 43 0C 03
10 LargeLaser     5 01  03 87 1E 03
11 PPC            8 01  08 CB 30 03
12 AutoCann/2    10 01  3A ED 39 03
13 AutoCann/5     2 01  41 F0 4B 03
14 AutoCann10      5 01  31 ED 39 03
15 AutoCann20     10 01  03 CB 30 03
16 MachineGun    20 01  07 87 1E 03
17 Flamer         2 01  00 43 0C 03
18 LRMissile5     2 01  03 43 0C 03
19 LRMissil10     1 04  62 EF 42 03
1A LRMissil15     1 06  64 EF 42 03
1B LRMissil20     1 07  65 EF 42 03
1C SRMissile2     1 08  66 EF 42 03
1D SRMissile4     2 02  02 87 1E 03
1E SRMissile6     2 03  03 87 1E 03
1F Kick           2 05  04 87 1E 03
20 (empty)        0 01  00 21 02 04
```

## Firing visuals (beam/missiles — mechanism closed 2026-11-08)

`1000:5847`→`5528`→`542D`→`4739` chain (see combat-system §25.5); aim `19FC:1314` +
shape-select `19FC:13D9` (attrs→`1DE9:[0x272]/[0x273]`, shape→`[0x2C9]/[0x2CA]`);
rasterizer `19FC:0DF8` (display-list walk, fixed-point `shr DX,1`, `cmp DL,0x80` decision);
blitter `19FC:18EF` (13-row); buffer `19FC:1ECE`; pacer `18BA:06C3`. Beam/missiles =
shaped sprites stepped per frame (NOT line primitives); shape tables live-captured
(`1DE9:0x424` 48B + `1DE9:0x564` masks). Open: per-frame advance loop, class→shape map
(E5: log `[0x2C9]` per shot in a firing battle).
