# T3 Combat Differential — Phase 1 design

> Status 2026-11-08: RNG recovered statically (no live work needed). Rebuild RNG
> fix specified; trace/comparator v1 scoped. Emulator stays paused.

## Goal (Phase 1)

One scripted 3-round battle, fixed setup, scripted orders both sides (no AI).
Per-round JSON trace each side (unit pos/armor/hit-miss/kill + RNG state).
Comparator replays the original's draws from recorded pre-state and flags
divergences. Done = one battle traced end-to-end with draw counts aligned.

Non-goals: AI-vs-AI (Phase 2), menus/shop/story draws, sound, graphics.

## Original RNG (verified static, `reko/gencode-combat`)

- Single source: `19FC:0BC0` — the ONLY byte roller. No `0x1021`, no LFSR, no
  INT 1Ah per-roll in any dumped caller (26 call sites, all funnel here).
- State: 3 bytes at `ES:0x4FC0` with `ES=0x3858` (main DS). No other writer to
  `0x4FC0–0x4FC2` in either dump → state is a pure function of draw count
  since boot (reseed TBD live — see §5).
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
- Nibble-masked `[BP-124]` entry (`& 0x0F` at 07A8) vs full-byte at 0A08 vs MG byte0 `0x14`≠live 2 → damage-byte semantics OPEN (byte0-as-damage REFUTED for MG; two-source resolution needs CFG).
- `0EC0:0A35` (live disasm 2026-11-08): kill cleanup — fog→0, destroyed=1, roster `0xFF` scan. Called with destroyed slot; explains roster removals.
- `0728:04F9` (recovered): max-status selector + fog scan (crit path).
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

- E1 (fresh-boot reseed): CLOSED. Image `04 03 02` at boot → #272 at title → #348 post-load. Never reseeded; pure draw-count. Harness: seed image default or snapshot-and-continue.
- E2 (save coverage): open — does GAME5 store the 3 state bytes (reload-determinism)?
- E3 (per-round snapshots): tooling live-verified (`t3_trace.py`); needs scripted battle loop (v2).
- E4 (rout-restore): open — damaged-then-rout battle: does wrap-up restore without victory?
- Wrap-up loop (`0728:00C7–018D`): pool = Σ enemy slots (12–15→story 4–7, `[0x393C]`-gated) remaining armor; per-loc-descending min(need,pool) to party 0–3; net = armor:=template on victory.

## Why Phase 1 got easier (2026-11-07/08 findings)

No-copy verdict → comparison points are plain story reads (no snapshot
reconstruction). 12C7 signature → probe columns are context; CX mirrors
damage; draw sites identified. Full 11-location armor map → damage assertions
are amount-exact.
