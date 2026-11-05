# Engine: Input & Navigation (runtime, observed)

> How to actually drive the original in the emulator: movement keys, building entry, and the
> trigger-spot quirk. Observed live 2026-09-28. Combat is documented in
> [`../combat-system.md`](../combat-system.md) (§22 encounter flow).

## Movement = ARROW KEYS
Despite the old docs' WASD/`QWEA...` tables, the game moves with the **arrow keys**:
`Up 0x48, Down 0x50, Left 0x4B, Right 0x4D`. The handler `fn0800_218F` compares the returned key
against **negated** scancodes (`0xB8`, `0xB0`, `0xB5`, `0xB3` = −0x48/−0x50/−0x4B/−0x4D), i.e. the
BIOS getkey wrapper returns negative scancodes for extended keys. Home/End/PgUp/PgDn are handled too.

This is an old DOS game — **WASD was not used**. In the MCP harness use `bt.py`'s `up/down/left/right`.

## Building entry = walk onto the entrance tile
You do **not** press an "enter" key. Walking onto a building's **entrance tile** triggers a popup:
`Will you enter the <building>?  Yes No`. Confirming enters the interior (loads that BLD).
- Example (start map, Pacifica Training School): stepping onto ~`(34,10)` → `Will you enter the
  Citadel? Yes/No` → interior: *"You are standing in the House Steiner citadel, the center of Lyran
  Commonwealth operations on Pacifica. Will you: Request to see Katrina / Visit Hall of Legends /
  Enroll in combat class / Talk to others / Leave the citadel."*
- Movement is blocked by building walls except at these entrance gaps.

## Trigger-spot quirk
An entrance tile stays "armed": after leaving a building, **walk DOWN (south)** to step off the
trigger, otherwise moving sideways/up re-fires the same `Will you enter ...?` popup.

## Start-map entrances (navigation)

Building entrances are just trigger tiles (§above). Live-verified on the start map:
**Citadel ≈ `(34,10)`**; **ComStar ≈ `(51,10)`** (road **east along y=12** to the end, then **north**
between the two red wings). The **barracks is to your far left**; southeast of the barracks is the Mech
training-center entrance. Other buildings: Weapons, Armor, Lounge, Mechit-Lube.

> The building/POI layout and entrance coordinates are **world-map content** — canonical list in
> [`../world-map.md`](../world-map.md) §3; the ComStar interior flow is in
> [`../story/story-system.md`](../story/story-system.md).

## Cursor system (`tA44B` / `tA44D`)

*(moved from `story/story-system.md` §17.12)*

- **`tA44B`** (segment `0x569E` offset `+0x0131`): cursor X. Low byte = pixel column (0–39 in 8px
  character units), high byte = sub-pixel / grid flags.
- **`tA44D`** (offset `+0x012F`): cursor Y. Same format.
- **Page flip**: `fn1E56_021D()` resets the cursor after page transitions.
- **Coordinate packing** (used in combat targeting): X = `(val & 0xF00) >> 1 | (val & 0x7F)`,
  Y = `(val & 0xF000) >> 5 | (val & 0x7F)`; masks `0xF7F`/`0xF07F` for grid/sub-pixel precision.

## Keyboard / menu input (`fn1F3D_0259`)

*(moved from `story/story-system.md` §17.12)*

Key scanning at segment `1F3D:0259`. Returns extended scan codes (combined with `~` bitwise NOT in
the decompiled code):

| Key | Code | Handler |
|-----|------|---------|
| Up/Home/PgUp | `~0x47/48/49` | `fn207F_158C()` — cursor up/world scroll |
| Down/End/PgDn | `~0x4F/50/4E` | `fn207F_163B()` — cursor down/world scroll |
| Left | `~0x4C` | `fn207F_16E3()` — cursor left |
| Right | `~0x4D` | `fn207F_17C5()` — cursor right |
| Space | `0x20` | `fn0800_2C50()` — action/select menu |
| Enter | `0x0D` | Confirms selection |

The arrow-key handler (`fn0800_218F`) loops 3 times over world tile entries at offset `0x09F3`,
refreshing units via `fn0800_2DA8()` (encounter-unit refresh/setup) and rendering tiles
beneath the cursor via `fn207F_1DA8()`.

## Data notes
- World/local map cursor: `0x1DE9:0xA44B` (X) / `0xA44D` (Y); tile = `(raw>>1)&0x7F`.
- `fn0800_218F` = arrow-key movement; building entry is tile-triggered (not key-triggered).

## SPACE menu (`fn0800_2C50`) + settings (`fn0800_3BD0`) — closed 2026-11-04 (E2)

SPACE opens `fn0800_2C50`, dispatching `1E56:0B5E` menu results. The on-screen menu (verified visually 2026-11-05, 8 rows with party) is: 0 Return to game (exit), 1 Change game settings → `3BD0`, 2 Allocate men in 'Mechs → `4D57` (body unread, slot-inferred), 3 Inspect Character → `378D` (roster/status incl. Mapper Yes/No line and traitor tell), 4 Heal Characters → `1431:000A(0)` (field heal, free), 5 Load Game → `32B3` (shows "Load Game:\rOne..." at `DS:0x5C7`), 6 Save Game → `35D3` (shows "Save Game:\rOne..." at `DS:0x673`; save-fail + map-room-refusal), 7 Show Overhead Map → `3D40` (map strips + unit overview). **Corrects the old E2 mapping** (2 as tech, 4 as enter-building, 5 as stock, 6 as stats, 7 as special): the true stock handler is `fn1CD3` case `0x07` (COMSTAR `F5 07`). Without party members the menu shrinks to 7 rows (Allocate row dropped).
`fn0800_3BD0` prints `DS:0x896` (settings list) with a dynamic sound line (`"Turn Sound
O"` + `"ff"` if `[0x15C]≠0` else `"n"` → Off/On), plus `DS:0x8CE` (outtakes/quit/cancel),
then menu `0x21`:
- 0 → movement-rate submenu (`0x8F9`: One/Two/Four steps) → `[0x15A]` = 1/2/4 (skips 3;
  the main-loop repeat count at `0800:009A`; reset to 1 on init).
- 1 → combat-speed submenu (`0x92F`: Fastest…Slowest/Keypress) → `[0x15E]` = 0–5,
  then `0800:4CAC(1)`. Effect: gated delays — `1543:0C50`, `1631:1A27`, `1631:1DCC`
  (`0xC·[0x15E]` ticks via `1F3D:0006`, instant `1F3D:0259` when `==5`/Keypress).
  Tick-unit semantics OPEN.
- 2 → `XOR [0x15C],1` (sound on/off — gates the `0000:30BF` PC-speaker cue player,
  §28.1). Verified display + toggle; audible effect is WONT_DO with sound.
- 3 → outtake submenu (`0x95D`) → `D35B` = result, then `4CAC(1)`. Effect:
  `0800:33FE` copies `D35B→[53E6]:0x2F8`; `0800:491A` tests bit `D35B·2` of table
  `DS:0xAC4` against an RNG roll — outtake occurrence gate. Row probabilities OPEN.
- 4 → quit confirm (`0x993`, `0x9CF`, `1A13(0)` → `[0x152]`).
- Else → exit (`3D3F`).
