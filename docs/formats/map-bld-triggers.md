# Map → BLD Trigger Map

> How a **local-map tile** resolves to a **building BLD**, and the decoded tables (2026-09-28).
> Closes roadmap blocker **B3**. Companion: [`bld-bytecode.md`](bld-bytecode.md),
> [`../story/story-system.md`](../story/story-system.md) §17.8.

## The chain

```
local-map tile  ──(building-position tables)──►  building slot (0..11)
     │                                                  │
     │  player stands on the slot's tile               │
     ▼                                                  ▼
Yes/No prompt  "Will you enter the <name>?"      slot ──► table[0x4602] ──► building-name index
   fn0800_1A13(1)                                        ([0x5460] → seg 0x2A0F, 16 bytes)
     │ Yes                                                    │
     ▼                                                        ▼
fn0FDC_0008(building_index) ──► BLD file (MTP building-name list → .BLD)
```

1. **Building positions.** Two word tables hold each building's tile position:
   `[0x53CA]:0x4564` = **X**, and `[0x53CC]:17814 (=0x4596)` = **Y** (live: both resolve to
   segment **`0x2A0F`**). Position is the packed cursor format — `tile = (word & 0x7F) >> 1`
   (same as the map cursor `A44B/A44D`).
2. **Slot → building index.** When the player is on a building's tile, the game shows the
   `fn0800_1A13(1)` **Yes/No** prompt (the same routine as BLD opcode `0xF6`). On **Yes** it calls
   `fn0FDC_0008(slot)`. That function maps the slot through the table at **`[0x5460]:0x4602`**
   (`fn0FDC_0008`: `if (arg != 0x12 && arg < 22) arg = table[arg]`), yielding the **building index**
   into the map's building-name list.
3. **Building index → BLD.** The MTP header carries the per-map **building-name list**
   (`docs/formats/file-formats.md`, `.MTP`); each name corresponds to a `.BLD` file.

## Live-decoded tables (start map = **MAP1**)

`[0x5460]:0x4602` (16 bytes, loaded map): `00 01 02 03 04 05 06 07 04 02 07 05 06 01 03 00`
→ for MAP1 (8 buildings) slots 0–7 map **identity** to building indices 0–7.

Building positions (`0x2A0F:0x4564` X, `0x2A0F:0x4596` Y) and names (MAP1):

| Slot | Building | X raw | Y raw | Entrance tile `(x,y)` | Verified |
|-----:|----------|-------|-------|-----------------------|----------|
| 0 | Training Center | `0x0C2E` | `0xC072` | `(23, 57)` | table |
| 1 | **Citadel** | `0x0C45` | `0xC014` | **`(34, 10)`** | ✅ walked |
| 2 | **ComStar Station** | `0x0C66` | `0xC014` | **`(51, 10)`** | ✅ walked |
| 3 | Weapons Shop | `0x0C20` | `0xC02C` | `(16, 22)` | table |
| 4 | Armor Shop | `0x0C32` | `0xC07C` | `(25, 62)` | table |
| 5 | Mechit-Lube | `0x0C0F` | `0xC06D` | `(7, 54)` | table |
| 6 | Barracks | `0x0C11` | `0xC00D` | `(8, 6)` | table |
| 7 | Lounge | `0x0C11` | `0xC059` | `(8, 44)` | table |

Slots **1** and **2** reproduce the entrance tiles found by walking the live game exactly
(`Will you enter the Citadel?` at `(34,10)`; `Will you enter the ComStar Station?` at `(51,10)`),
which validates the position tables + ordering. The remaining rows are read from the tables
(low-byte packing) but not yet walked tile-by-tile.

## Per-map building-name lists (from the MTP headers)

The building list is per-map; decoded from the `.MTP` headers (repeated prefix characters are a
storage quirk — the meaningful name is the trailing full form):

- **MAP1** (start map, 8): Training Center · Citadel · ComStar Station · Weapons Shop · Armor Shop ·
  Mechit-Lube · Barracks · Lounge
- **MAP2** (main city, 12): Mech Garage · Arena · ComStar Station · Mechit-Lube · Hospital ·
  Weapons Shop · Armor Shop · Lounge · Inaugural Hall · Clothes Shop · Mech Garage · Video Hut
- (MAP11 has the same 8 as MAP1 — the post-attack variant; MAP14 = cave.)

## Consequences / corrections

- **The start map is MAP1** (Training Center). This matches the live ComStar/Citadel entrances and the
  building-name list, and **confirms the earlier docs' "COMSTAR at `(27,9)` MAP2" was a different
  city** — MAP2 is the *main city* (Arena, Hospital, Inaugural Hall, …).
- The position tables are **data-driven**: the rebuild's `LocationMapper` should consume
  `[0x53CA]:0x4564` / `[0x53CC]:0x4596` + `[0x5460]:0x4602` + the MTP name list rather than a
  hand-maintained table.

## Remaining

- Walk the other six MAP1 tiles to mark them verified.
- Confirm whether the `0x4602` table is per-map (copied from the map buffer at load) or global — check
  after loading MAP2.
- The `+0x7AD` tile-property table (used for passability, `>= t0150` = blocked) is separate; see
  [`../UNVERIFIED_DISCOVERIES.md`](../UNVERIFIED_DISCOVERIES.md) §2.
