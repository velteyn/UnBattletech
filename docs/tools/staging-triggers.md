# Staging triggers — our testbench (2026-11-08)

> The authors tested via state, not playthroughs: everything in this game is a
> flag or a byte away (`D330–D333`, `w374A`, story slots, weapon records, RNG state).
> No shipped debug menu exists (919 EXE strings contain zero DEBUG/TEST/CHEAT
> artifacts; no public cheats exist for the 1988 game; all 28 BLD opcodes
> `0xE4–0xFF` are mapped, no gaps).
>
> **Update (2026-11-08): they did ship a testbench — it just isn't a menu.** Three
> author artifacts are on the game disk: an **input record/replay macro**
> (`DEMOFILE`, used by the attract demo), a **data-integrity QA utility**
> (`$VERIFY.EXE`), and **startup config selectors** (adapter 1–4, drive 1–3). See
> §"The authors' own bench" below. Everything else here is still the manual we use.

## The authors' own bench (discovered 2026-11-08, static — byte-verified)

### 1. `DEMOFILE` — a recorded keystroke macro (the attract demo)

The game ships an input **recorder and player**. One routine branches on the demo
flag `[0x3938]`:

| `[0x3938]` | Behaviour |
|---|---|
| `0` (normal play) | read a key → **store** it at `ES:[bx+0xA0]` → `[0x39F8]++`. Key `'h'` (`0x68`) is rewritten to `0x48` and another key is read immediately. |
| `≠0` (demo) | `bx=[0x39F8]`, `[0x39F8]++`, then **load** the next key from `ES:[bx+0xA0]`. A `0x48` byte means "wait, then read the next key". The key-wait is skipped entirely (no blocking). |

`ES` is `[0x56F6]`; the macro cursor `[0x39F8]` is seeded to **`0x2710`**, and the
key array is at `+0xA0` — i.e. **`0x2710 + 0xA0 = 0x27B0`, exactly the address the
attract-demo loader `fread`s `DEMOFILE` into (`0x2892:0x27B0`, `1 × 0x3FF` = the
file's 1023 bytes).** The macro lives where `DEMOFILE` is loaded. That is the
whole chain, and the arithmetic is exact.

The loader runs from the intro when the "any key?" check returns **0** (no key):

```
[0x39F8] = 0x2710          ; macro cursor
[0x4FC0] = 0x1325          ; ─┐ RNG state, seeded by the demo
[0x4FC2] = 0x0090          ; ─┘ (this is a real writer to the RNG!)
[0x3988] = 0xFFFF          ; animation page-swap guard
[0x3938] = 1               ; demo / auto-advance flag
```

**Corroboration from the data itself.** `DEMOFILE` has only **10 distinct byte
values**, all valid key codes under the game's convention (the keyboard routine
returns `-scanCode` for extended keys, so `Up=0xB8, Down=0xB0, Left=0xB5,
Right=0xB3`):

| byte | key | count |
|---|---|---|
| `0xB5` | Left | 235 |
| `0x00` | padding | 233 |
| `0xB0` | Down | 180 |
| `0xB3` | Right | 164 |
| `0xB8` | Up | 107 |
| `0x48` | delay marker | 64 |
| `0x0D` | ENTER | 18 |
| `0xAF` | PgDn | 15 |
| `0x20` | SPACE | 6 |
| `0x50` | `'P'` | 1 |

It decodes as a coherent session — walk right 19, up 11, enter a menu, travel,
open menus, `PgDn` paging, `SPACE` confirmations — i.e. a recorded playthrough,
not a map. A 33×31 tile map would not be 90% arrow keys.

**Why this matters for T3:** the binary proves that (a) RNG state injection is a
first-class, in-image operation (the demo seeds `0x1325/0x0090`), and (b) there is
an engine that replays a key script deterministically at test time.

#### The replay wrapper **is** the universal key-wait — proven 2026-11-08

This was previously filed as an open caveat ("the `18BA` wrapper is distinct from
the universal `173D:0x259` key-wait"). **It is not distinct — they are the same
routine.** Fixing the code/data load-bias arithmetic settles it:

- `runtime segment = link segment + 0x17D` (the paragraph the EXE loader adds;
  the documented `L=0x017D`), and `file = link_phys + 0x3400`
  (= `runtime_phys + 0x1C30`).
- The 84 far calls in the image are encoded with the **link** segment
  `lcall 173D:0259`. At runtime that is segment `0x173D+0x17D = 0x18BA`,
  offset `0x259` — **the record/playback wrapper at file `0x1AA29`**
  (bytes `55 8b ec b8 04 00 9a dc 2f 7f 18 8e …`, matching the gencode label
  `18BA:0259` byte-for-byte).
- Cross-check: the RNG is `19FC:0BC0`; link `187F:0BC0` → file
  `0x187F0+0xBC0+0x3400 = 0x1C7B0`, which disassembles to exactly the
  `shr/shr/rcl/rcl/cmc/sbb` rotation already ported to `CombatRng`. Its
  `mov ax,0x36db; mov es,ax … mov si,0x4fc0` proves `ES` link `0x36DB` = runtime
  `0x3858` (main DS) and the 3-byte state at `0x3858:0x4FC0`.

The **kbhit** companion is `173D:002F` (file `0x1A7FF`): it returns **1
unconditionally when `[0x3938]≠0`** (`or ax,ax` from the DOS check, then
`cmp es:[0x3938],0; je 0`). So every `if kbhit() then getkey()` in the game
proceeds to the wrapper in demo mode.

**Live proof (2026-11-08):** on a paused world-map session, set
`[0x2A0F:0x3938]=1`, `[0x2A0F:0x39F8]=0x2710`, wrote `Left,Left` at
`0x2A0F:0x27B0`, injected one real key to unblock the wrapper (it had already
entered the BIOS `INT 16h` before the flag was armed), and resumed 0.6 s.
`[0x39F8]` advanced **`0x2710 → 0x2729` = 25 script bytes consumed**, CPU back at
the key-read (`19FC:0B57`). The same key codes the callers compare —
`0xFFB3` Right, `0xFFB5` Left, `0x0D` Enter — are exactly the sign-extended
script bytes. **Scripted replay is real, universal, and mid-game.**

Also settled: the recorder is dead in the shipped build. The only writer of the
"`[0x458C]` recording enabled" gate sets it to **0** (`mov es:[0x458c],ax`,
`ax=0`, at `0x69C0`/file `0x85F0`), so normal play never records — but replay
(`[0x3938]`) does not consult `[0x458C]`. Do not expect a `DEMOFILE` writer path.

**Side effects of `[0x3938]=1` are input-only.** All four non-wrapper branches are
auto-advance gates — `0728:22C5` (skip `kbhit`, use a counter), `11B8:100D`
(skip an input poll), `17D3:0BA6` (skip a cursor-counter clear), `017D:2A36`
(return without reading). **None touch combat math**, so arming replay for a
battle changes only input timing, not dice/damage — exactly what a differential
harness wants.

**Operational caveats for scripting:**
- The player consumes one script byte per key-wait, as fast as the loop runs
  (`0x00` padding counts as a key, so a short script runs into whatever follows).
  The byte `0x48` is a **delay marker**, not a key: the player loops on it and
  calls the near delay routine `18BA:0006` (runtime; file `0x1A7D6`) with arg
  `0x1E` instead of returning a key. Every normal key also costs one delay unit
  (arg `1`). So pad with `0x48`, and/or clear `[0x3938]` after the script.
- The playback path calls the raw DOS input check (`187F:3BDC`, `int 21h AH=0x0B`);
  if a **real** key is pending it aborts (sets `[0x152]=1`) and consumes it. Do not
  press keys while a script runs.
- A wrapper already blocked in BIOS `INT 16h` will not see a newly armed
  `[0x3938]`; one real key "primes" it, then the next call replays.

### 2. `$VERIFY.EXE` — the disk-integrity QA tool

16 KB Microsoft C 5.0 program, dated **1988-10-25**, shipped but never referenced by
the game. Strings show its job: it enumerates `BTECH.EXE`, `O0–O21.ANM`, `MAP1–15.MTP`,
every `*.CMP`/`*.ICN`, `WWOODBT.SIF`, `DEMOFILE`, and all 26 `*.BLD`, printing a
`%d%%` progress and **`GOOD` / `NO GOOD`** per file, with `Please insert the
BattleTech Game Disk 2 in the drive.` prompts. It is a floppy-verification harness —
directly reusable as an **asset regression check** for our extracted/repacked data.

Note it also names assets the *game* never loads: **`O16–O21.ANM`** and
`STARLEAG.ICN` (all present on disk). So `O17–O21` are shipped-but-unused/extra
animations, not a gap in our table.

### 3. Startup selectors (config bench)

At boot the game asks **adapter `1–4`** (stored raw, then normalized `-0x31` into
`w4FBA`, the global UI/render mode) and **drive `1–3`** (`[0x3FFE]`, with the
`'2'` → "Disk 2" extra prompt). These are the authors' video/disk test switches and
are why a padded `4 / 3` boot sequence reaches Mode 13h reliably.

### What is *not* there

- **No function-key handlers at all.** Every `cmp al,<neg scan>` candidate for
  `F1–F10` (`0xC5…0xBC`) is data or an unrelated `cmp` — the only match was a
  glyph/font `cmp al,0x40`. There is **exactly one `int 16h`** in the whole EXE
  (`19FC:0B97`), and the only key-normalizer found (`18A4D`) just folds the
  numeric-keypad to arrows.
- No DEBUG/TEST/CHEAT strings; no menu; no command-line parse.

> **Address-referencing gotcha — exact formulas (pinned 2026-11-08):**
> there is **one** load bias, applied everywhere; previous "different biases for
> code vs DS data" notes were arithmetic slips.
>
> - **`runtime segment = link segment + 0x17D`** (the linker/loader paragraph,
>   `L=0x017D`). All `segment:offset` operands *encoded in the EXE* are **link**
>   values; gencode/Reko labels, runtime dumps and r2 live addresses are
>   **runtime** values. E.g. the image's `lcall 173D:0259` executes as
>   `18BA:0259`.
> - **`file = link_phys + 0x3400`** = **`runtime_phys + 0x1C30`**
>   (`0x3400 − 0x17D0 = 0x1C30`).
> - **DS data:** `file = DS*16 + offset + 0x1C30` *when `DS` is the runtime
>   segment*, or `file = DS_link*16 + offset + 0x3400` when `DS` is a link value.
>   Verified: `DEMOFILE` name at `file 0x3AE48` = `DS:0x0C98` (runtime DS
>   `0x3858`); RNG `19FC:0BC0` → `file 0x1C7B0`; wrapper `18BA:0259` →
>   `file 0x1AA29`; ANM decoder `mov dx,0xF20` → `file 0x1E012`.
>
> Consequence: **instruction bytes are always trustworthy; printed
> `segment:offset` labels need the `+0x17D` (runtime) or nothing (link) applied
> before converting to a file offset.** Fixed offsets within one routine are
> safe. When a label disagrees with a byte signature, trust the signature.


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
