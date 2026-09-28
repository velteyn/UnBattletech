# Engine: Combat Encounter Flow (runtime, observed)

> Observed live on 2026-09-28 while playing a **late-game save** (slot 5: party
> Jason/Rex/Russ). Complements [`../combat-system.md`](../combat-system.md) (the RE spec) with
> the actual on-screen flow and the commands needed to drive it. Combat state lives in the
> **game-state segment `0x2A0F`** (see `../UNVERIFIED_DISCOVERIES.md` §6).

## Trigger
A **random encounter** while moving on the **world map** (the party's mechs are the red sprites
you move). No encounter in the starting/degraded state (state array unset); it fires normally with
a progressed save.

## Setup prompts (in the left panel)
1. `Attacking force: <N>.` / `Engage in combat?  Yes No`  (Yes highlighted)
   - **No** = avoid → back to the map.
2. `Do you want the computer to fight for you?  Yes No`  (No highlighted = manual)
3. `Combat messages:  None  Brief  Verbose`
4. `See combat graphics:  Yes No`

Observed attacking forces: `4 humans.`, `1 Mech and 6 humans.`

## Tactical combat
- **Left panel**: unit title `<Pilot>'s <MECH>` (e.g. `Jason's CHAMELEON`) over a command menu:
  `Walk / Run / Jump / Use Weapons / Kick / Computer / Scan Unit / Next Unit / Flee / Begin Fight`.
- **Right panel**: 12×24 tactical grid (grass/roads/buildings) with mech sprites; the active unit
  sits on a magenta tile highlight.
- **Begin Fight** executes the round: combat messages appear in the left panel, e.g.
  - `An enemy Mech uses a Med Laser on Jason's Mech. Missed!`
  - `An enemy Mech uses a MachineGun on Jason's Mech. Hit Center Torso.` (hit/damage lines are magenta)
- **Kick target selection** (physical attack): header `Choose the enemy to kick:`, `Target: <MECH>`,
  `Range: IN/OUT`; options `Target here / Next enemy / Cancel`.
- **Flee** (menu option): → `You have eluded your enemies! Press a key.` → returns to the world map.

## Combat data (verified live)
This file records the **observation**; the address spec is canonical in
[`../combat-system.md`](../combat-system.md) §13 and [`../formats/memory-map.md`](../formats/memory-map.md) §3.

Observed live in segment `0x2A0F`: unit arrays `0x4004` (X) / `0x4036` (Y) / `0x406A` (status), 24 slots;
fog grids `0x40B4` / `0x41D4` (12×24), fully fogged (`0x02`) at start.
`bt_read_combat_units` / `bt_read_combat_grids` return this.

## Driving it (playtest notes)
- The encounter fires while pressing movement keys (`w`/`x` reliably) on the world map.
- The setup prompts and the command menu respond to **Space** (confirm) + **Up/Down** (navigate).
- Menu highlight can be position-sensitive; re-sample the screen between steps.
