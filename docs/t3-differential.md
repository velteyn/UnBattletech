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

| Site | Call | Likely purpose | Rebuild counterpart |
|---|---|---|---|
| `1465:07DE` | 19DD (2D6) | to-hit (targeting) | ComputeTargetNumber + Roll2D6 |
| `1465:0976` | 19DD | post-fire roll #1 | — open |
| `1465:09D9` | raw 0BC0, `and BX,8`, table `[ES:BX+0x2E43]` → `[BP-96]` | binary pick (front/rear?) | — open; rebuild `RollHitLocation` (`& 0x0A` + 6-table) is SUSPECT, review |
| `1465:09C0` | `idiv 5` | mod-5 (rear loc? cluster?) → `[ES:0x3103]` | — open |
| `1465:0A1F/0A47` | 19DD ×2 | crit check (2D6≥8?) / cluster | CheckCritical / RollClusterHits |
| `19FC:0971` | geometry (coords→octant, `DS:0x238–0x23E`) | hitloc component → `[BP-96]` elsewhere | RollHitLocation review |

Non-combat 0BC0 callers exist (017D system ×8 incl. die roller, c3 menu/BLD ×11,
0FAE ×1, 11B8 ×3) — encounter/elude/shop draws interleave BEFORE battle start.
Phase 1 controls this by snapshotting state AT battle start and scripting from
there; full-boot determinism is Phase 2.
**Known second stream (P2):** `BldInterpreter.RollD6` uses `GD.Randi()`, but the
original funnels BLD/menu draws through the same single `0BC0` state — rebuild
currently runs two independent streams. Route BLD through `CombatRng` in P2.

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

## Experiment queue (live, needs reboot — deferred)

- E1: fresh-boot read of `0x3858:0x4FC0` before any battle → reseed? (no
  writer found statically; expect image `04 03 02` until first draw).
- E2: GAME5 save coverage — does a save file store the 3 state bytes?
  (determines reload-determinism).
- E3: per-round snapshot loop on a scripted battle (validates v1 tooling).

## Why Phase 1 got easier (2026-11-07/08 findings)

No-copy verdict → comparison points are plain story reads (no snapshot
reconstruction). 12C7 signature → probe columns are context; CX mirrors
damage; draw sites identified. Full 11-location armor map → damage assertions
are amount-exact.
