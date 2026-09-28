# Engine: Input & Navigation (runtime, observed)

> How to actually drive the original in the emulator: movement keys, building entry, and the
> trigger-spot quirk. Observed live 2026-09-28. Also see [`combat-flow.md`](combat-flow.md).

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
rendering tiles beneath the cursor via `fn0800_2DA8()` and `fn207F_1DA8()`.

## Data notes
- World/local map cursor: `0x1DE9:0xA44B` (X) / `0xA44D` (Y); tile = `(raw>>1)&0x7F`.
- `fn0800_218F` = arrow-key movement; building entry is tile-triggered (not key-triggered).
