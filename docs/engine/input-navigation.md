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

## Layout (start map, per walkthrough)
You start in the **Pacifica Training School** opposite the **Citadel**; **Comstar** (stock market)
is the building **next door (east/right of the Citadel)**; the **barracks is to your far left**;
southeast of the barracks is the Mech training-center entrance. Other buildings: Weapons, Armor,
Lounge, Mechit-Lube.

## Data notes
- World/local map cursor: `0x1DE9:0xA44B` (X) / `0xA44D` (Y); tile = `(raw>>1)&0x7F`.
- `fn0800_218F` = arrow-key movement; building entry is tile-triggered (not key-triggered).
