# Staging triggers — our testbench (2026-11-08)

> The authors tested via state, not playthroughs: everything in this game is a
> flag or a byte away (`D330–D333`, `w374A`, story slots, weapon records, RNG state).
> No shipped debug menu exists (919 EXE strings contain zero DEBUG/TEST/CHEAT
> artifacts; no public cheats exist for the 1988 game; all 28 BLD opcodes
> `0xE4–0xFF` are mapped, no gaps). So instead of hunting their bench, we
> rebuilt its equivalent. This doc is the trigger manual.

## Primitives

| Tool | Use | Caveats |
|---|---|---|
| HTTP PUT `/api/memory/{phys}/byte` | Set any story/flag/RNG byte | Host PUTs don't trip emulator watchpoints; verify with readback |
| Probes (`03F5`/`12C7`/`174C`/RNG) | Observe text, damage, bars, draws | 12C7 regs are context (leftovers); `CX`≈damage; probe IP lags writes by a few insns |
| `t3_trace.py snap/diff` | Pre/post snapshots + armor deltas | Snapshot AFTER wrap-up completes, not mid-dialog |
| Deterministic RNG | Same inputs → same encounter/rolls | State = pure draw-count since boot (E1: boot 0 → title 272 → load 348); map walking draws |
| Save/reload (GAME5 `471b7840`) | Reset to canonical | RAM-only deaths unless saved; verify md5 after every session |
| Buff pattern (`+0x11→N`) | Invincibility (`3C`) or survivable (`14`) | Wiped by victory wrap-up (template restore) — re-buff per battle |
| Watchpoints (MEMORY_WRITE) | Catch writer + regs at the hit | Identical-value writes STILL trip; wrap-up causes trip storms (remove armor WPs before wrap-up); IP lags the fault |

## RNG clocking (advanced, available — not yet used end-to-end)

Since RNG state is a pure draw-count function, you can compute forward from a
snapshot to a future state with favorable rolls (crit `2D6≥8`, hits on demand),
then burn the exact number of draws (harmless `19DD` calls happen on map/menus —
count via snapshots, or just walk/pause exact steps) to land the test on it.
Requires draw-count alignment incl. map-phase draws (snapshot `0x3858:0x4FC0`
before/after each phase). The `CombatRng` port + `tools/playtest` snippets make
this a scripting exercise, not a reversing one.

## Recipes per behavior

- **Traitor events (S1):** PUT `D333=1` (+`w374A` full word) at encounter prompt;
  `C79D`/`C620` staging per prior sessions. Verified pattern, reuse as-is.
- **Damage / armor tests:** buff target slots pre-battle (`+0x11`, +0x56 untouched);
  fight; read deltas post-round (writeback lands at wrap-up — read AFTER the R-menu).
- **Encounters / SRM2:** walk south; spawner (`0728:0F10+`) is RNG-gated with
  `%3` template pick from `[0x5436]:[0x2DF8/0x2FA]` into story slots 4–7.
  WASP (SRM2) exists in the wild (scanned 11-05) — keep walking; composition varies per path.
- **E4 rout-restore — elude variant (deterministic, RECOMMENDED):** buff party to
  `~0x14` (survive, show deltas), engage mech battle, take hits (no kills needed),
  choose Elude (retry on fail — elude RNG can fail), check armor post-elude.
  Persists → elude skips wrap-up. Regressions to template → wrap-up runs anyway.
- **E4 rout-restore — passive variant (bounded):** buff to `0x3C` (invincible),
  manual battle, issue NO fire orders (move/end turn only), wait ≤10 rounds for
  the rout roll. If rout fires with damage on board → compare pre/post.
  If no rout in 10 rounds → stop, elude out (which itself runs the variant above).
- **Kills / crits:** soft target (LOCUST slot, low armor), focus fire + Kick
  (TN 3); crits need `2D6≥8` (RNG-gated — or RNG-clock it). Kill FX needs victim
  handling; expect `11AB` flag writes + `38BC` group-flee for humans.
- **Kill presentation / beam:** beams are transient (drawn in `12C7` tail /
  `1000` frame hold, erased after). Screenshot during the hold window only;
  `shot_png.py` is Mode-13h-only (adapter 4). Shape WP (`1DE9:0x2C9`) is silent
  in live battle — beams likely fixed tiles or dummy-path-only (open).
- **Wrap-up / restore:** victory → armor:=`+0x56` template (verified ×2).
  Rout/elude restore behavior = E4 (above).

## Residuals (not blocking)

- Hidden key combos: no string/menu evidence; would need key-dispatch CFG decode
  or bounded live F-key fuzz on a disposable boot. Low yield, filed.
- `Fn1CD3` out-of-range case (`>0x2F`) behavior: unchecked, marginal (BLD files are data; worst case is a crash, not a feature).
- `DI`/19FE encodings, melee byte0 meaning, kick `0x1F`-vs-`0x20`, `08xx` purpose,
  heat-pool identity (`[0x6E]` vs `[0x66]`): open micro-items, T3-irrelevant.
