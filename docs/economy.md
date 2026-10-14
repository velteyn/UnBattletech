# Economy & Stock Market (ComStar) — live-verified 2026-10-14

> First end-to-end live validation (Spice86 + PNG screenshots): walked (34,12)→ComStar (51,10),
> entered, bought 25 DefHes + 5 NasDiv, viewed prospectus, changed settings, exited, re-entered.
> Memory via game-state segment `0x2A0F` (credits cross-checked with `bt_read_credits`).

## Verified live memory map (segment `0x2A0F`)

| Addr | Size | Content (observed) |
|------|------|--------------------|
| `D370` | u32 | Credits (50 → 25 → 14 → 20 across the session; purchases exact) |
| `D374` | u32 | **DefHes holdings** (25 after buying 25; buy/sell-tested) |
| `D378` | u32 | **NasDiv holdings** (5 after buying 5) |
| `D37C` | u32 | **BakPhar holdings** (0, untested — presumed by symmetry) |
| `D390` | 8×26 B | Shared per-slot table (stride `0x1A`): `Price(w+0) / PC(w+2) / DF1(w+4) / DF2(w+6) / Trend(b+8) / Flag(b+9)` + 16 zero bytes. Rows 0–2 = the three stocks; rows 3–7 = scratch/other (e3==e0 copy, e7 has live `FF FF FF FF 01 00` tail) |
| `D55D` | 12+ B | Finance block: mostly zero; byte +5 = 150 (`0x96`), byte +14 = 146 (`0x92`) — stable, meaning open |

Observed rows 0–2 (stable across 30+ min — **no tick** while inside):

| Stock | Price | PC | DF1 | DF2 | Trend | Flag |
|-------|-------|----|-----|-----|-------|------|
| DefHes | `0x0C20` | `0xC02C` | same | same | `0x63` | 0 |
| NasDiv | `0x0C45` | `0xC014` | same | same | `0x51` | 0 |
| BakPhar | `0x0C0F` | `0xC06D` | same | same | `0x35` | 0 |

## Buy/sell flow (observed UI)

ComStar → Inspect accounts → account screen (balance + `Current investments` list) →
Change investments → Buy/Sell/Cancel → stock picker (DefHes/NasDiv/BakPhar) →
`Invest how much?` (digit entry) → confirmation (`You have invested a total of N… balance… N`).
Purchases debit credits exactly (50−25=25, 19−5=14). Prospectus per stock = flavor text +
assets/liabilities ratio (DefHes 2.19) — no price shown.

## Case-code findings (corrects the rebuild model)

- **F5 `0x2A` fires ONLY in THEATER.BLD (`0x467`), `0x2B` ONLY in TRAINING.BLD (`0x1674`)**
  (decrypted-stream sweep of all 26 BLDs). COMSTAR.BLD emits `0x06/0x07/0x08/0x0C` — the stock
  buy/sell runs through the *shop* cases with a stock strategy, not through `0x2A/0x2B`.
- **Case `0x2A` code** (`1CD3:151A`, `UNBTECH_1CD3.asm:2214`): 8× loop — save cursor to
  `0x4024/0x4056` words, seed `[SI+0xD390]=cursorX`, `[SI+0xD392]=cursorY`,
  `[SI+0xD399]=i`, `[SI+0xD398]=0x77`; **single** `cursorY++` after the loop. (Shared
  position-save + scratch seed — in THEATER context, not ComStar-specific.)
- **Case `0x2B` code** (`1CD3:157E`): entry0-only refresh from source tables
  (`[4572]→D390`, `[45A4]→D392`, `[4564]→D394`, `[4596]→D396`, `0x70`→D398, `0xFF`→D399).
- **Neither ran this session** (no theater/training visits) — yet the table held structured,
  *varying* prices/trends. True seeders live in the spawn/loader flows: `0800:30E6` RNG loop
  (`[D399]=1`, trend=`(RNG&7)<<4 | table3768[RNG]`, DF1 from `[53CA]:0x4564` indexed by the
  RNG-derived value), the `2DA8`-tail source-table Price/PC/DF writes (`[53CA]:0x4564`,
  `[53CC]:0x4596`, `[4572]`-family), the `0FDC:0D49` position-copy loop. The region is
  **shared scratch**, not a stocks-only table — the stock UI just reads rows 0–2.
- Consequence: **trend bytes are RNG-seeded, not visit markers** (`0x63/0x51/0x35` observed;
  never `0x77`/`0x70` this session). DF1/DF2 are independent source-table words (row e4 proves
  it: `DF1=0x0C11 ≠ Price 0x0C66`); rows 0–2 coinciding is source-table content, not aliasing.

## Rebuild bugs filed (not fixed)

1. `SavePositions` (case `0x2A`) does `CursorY++` **per iteration** — original increments **once**
   after the loop (cursor drifts +7 in the rebuild). Also misattributes the case to ComStar.
2. `RestorePositions` (case `0x2B`) invents a PRNG fluctuation — original copies the four source
   words + `0x70`/`0xFF` markers. Also misattributed (TRAINING-only F5).
3. `StockEntry` model (Price/PC/DF1/DF2/Trend/Flag + 16 pad) matches the live 26 B layout,
   but holdings (`D374/D378/D37C`) are not modelled at all — the buy/sell strategy needs them.

## Open / next

- One-time −6 credits charge (terminal/prospectus fee?) + irregular +6 allowance tick — isolate.
- Finance block `D55D` bytes (+5 `150`, +14 `146`) meaning; price/DF source-table identities.
- Rows 3–7 roles; `0x380A`-style gaps n/a here; economy tick location/timing (B10).
- Re-entry produced **zero** table diffs — under what condition does `0x2B` (or any refresh) run?
