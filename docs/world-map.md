# World Map & Navigation — Reverse-Engineering Specification

> Canonical world-map reference. Consolidated from `WORLD_MAP_FINDINGS.md` plus the
> world-map/navigation sections of the former `TECHNICAL_ANALYSIS.md`
> (local-map destinations, §17 random encounters, §18 NPC movement).
> The old `TECHNICAL_ANALYSIS.md` §20 was a condensed subset and is merged here.
> See `docs/INDEX.md` for the documentation map.

## Local map destinations (MAP1–MAP14)

## Identified Destination Maps

- **MAP1.MTP**: Training Center (Start location).
- **MAP2.MTP**: Main City (Chameleon training, Arena).
- **MAP3.MTP**: Small outpost/village.
- **MAP4.MTP**: Large industrial complex / city.
- **MAP5.MTP**: Medium settlement.
- **MAP6.MTP**: Medium settlement.
- **MAP7.MTP**: Medium settlement.
- **MAP8.MTP**: Medium settlement.
- **MAP9.MTP**: Outpost.
- **MAP10.MTP**: Medium settlement.
- **MAP11.MTP**: Destroyed Training Center (Post-attack).
- **MAP12.MTP**: Large city/base.
- **MAP13.MTP**: Medium settlement.
- **MAP14.MTP**: Cave / Underground complex.


---


## Summary

The world map tile data has been located and decoded. It is a **64x64 grid of tile IDs** stored in the game's code segment, rendered on-screen as the Pacifica island continent with cities, roads, and varied terrain.

---

## 1. Tile Buffer Location

### Primary Tile Buffer

| Field | Value |
|-------|-------|
| Segment:Offset | `0x246C:0x244B` |
| Linear address | `0x26B0B` (in Spice86 memory dump) |
| Size | 4096 bytes |
| Grid dimensions | 64 x 64 tiles (1 byte per tile) |
| Unique tile IDs | 93 (at runtime) |
| Value range | 0x00 - 0xFF (255) |

### Dynamic Segment Allocation

At runtime, the tile buffer segment is loaded from the pointer at `DS:[0x53C6h]`. In the captured memory dump this resolves to segment `0xF187` (linear `0xF3CBB`) -- which is **empty** (all zeros), because the pointer tables in the dump reflect a non-world-map game state.

However, the tile buffer data at `0x26B0B` (segment `0x246C:0x244B`) **is populated and contains the world map**. Since segment `0x246C` is a sub-segment of physical segment `0x0000`, the tile buffer resides in the main code/data load area and gets overwritten with tile data when the world map is active.

### EXE Pre-initialized Data

The EXE file at file offset `0x29F0B` (header_size + linear `0x26B0B`) contains **76 unique values** -- pre-initialized placeholder/initial state data. At runtime, **only 718/4096 bytes remain unchanged** (17.5%), confirming the game modifies this buffer extensively based on game state, visibility, story progression, and encounter placement.

---

## 2. World Map Structure

### What the Map Shows

The 64x64 grid depicts the **island continent of Pacifica** (where the game begins), surrounded by ocean:

| Terrain Type | Tile Count | Percentage |
|---|---|---|
| Water (tile 0x00) | 727 | 17.7% |
| Land and Ground | 2,027 | 49.5% |
| City/Building | 1,080 | 26.4% |
| Roads | 262 | 6.4% |

### Common Tile ID Reference (Runtime)

| Tile ID | Count | Category | Visual |
|---|---|---|---|
| 0x00 | 727 | Ocean/Water | Water |
| 0x22 (34) | 593 | Dark ground | Land |
| 0x87 (135) | 514 | City building (most common urban tile) | City |
| 0xf7 (247) | 501 | Grass/ground variant | Land |
| 0x77 (119) | 157 | City/building | City |
| 0x88 (136) | 134 | Building | City |
| 0xff (255) | 131 | Ground | Land |
| 0x99 (153) | 111 | Road tile | Road |
| 0x2a (42) | 103 | Medium ground | Land |
| 0xbb (187) | 79 | Building | City |
| 0xa2 (162) | 71 | Wall/barrier | Structure |
| 0xaa (170) | 66 | Road variant | Road |
| 0x07 (7) | 61 | Structure/wall | Structure |
| 0x55 (85) | 60 | Structure | Structure |
| 0xf5 (245) | 53 | Light grass | Land |
| 0x39 (57) | 45 | Transition tile | Land |

---

## 3. Identified City / POI Locations

Cities and points-of-interest form distinct clusters. Detected via connected-component analysis of city-tile tiles `{0x07, 0x55, 0x77, 0x78, 0x85, 0x87, 0x88, 0x89, 0x8a, 0xb0-0xbf}`:

| # | Location | Center (X,Y) | Bounding Box | Likely Identity |
|---|---|---|---|---|
| 1 | Training Center area | (26, 5) | (22,3)-(32,7) | Citadel + Training buildings (MAP1) |
| 2 | Main city hub | (28, 10) | (22,8)-(33,13) | Barracks, shops, ComStar (MAP2) |
| 3 | East-central settlement | (32, 18) | (24,15)-(35,20) | Town cluster (MAP3-4 type) |
| 4 | Northwest settlement | (10, 10) | (8,8)-(13,11) | Small outpost |
| 5 | Southeast island outpost | (55, 8) | (52,7)-(57,10) | Island town |
| 6 | West coast town | (9, 21) | (8,19)-(12,23) | Outpost (MAP5-8 type) |
| 7 | Central village | (42, 25) | (40,23)-(45,28) | Outpost |
| 8-10 | Southern settlements (3x) | (5,49),(5,54),(5,59) | (0,48)-(12,60) | Row of coastal towns |
| 11 | Large southern city | (33, 49) | (24,46)-(44,53) | Major southern settlement |

---

## 4. Coordinate System

### Tile Buffer Access

```
Tile X = (wA44B & 0x7F) >> 1   -> 0-63
Tile Y = (wA44D & 0x7F) >> 1   -> 0-63
Tile index = Y * 64 + X         -> offset within 4096-byte buffer
```

### Display Viewport

The game displays an **8x8 tile viewport** (64 tiles) of the world map at a time. The rendering function `fn0800_2A93` reads tile coordinates from three parallel arrays at offsets 0xD4D7 (X) and 0xD517 (Y) within the segment pointed to by `DS:[0x538Ah]`.

### Save Game Coordinates

Save game positions (at offsets `0x0F45` and `0x0F47` in the save buffer) encode the player's world map location. Values like 57582, 45168 appear large because they encode sub-tile or pixel-level positioning:
- Low 7 bits encode sub-tile position (0-127 -> 0-63 after shift)
- High bits may encode map page/region flags

### Visibility Grid

The visibility system uses a **128x128 bit-packed grid** (2048 bytes), saved at save game offset `0x04F9`. Each world map tile (64x64) corresponds to a 2x2 block of visibility bits:

```
world_tile_visible(x, y) = visibility_bit(x*2, y*2) | visibility_bit(x*2+1, y*2) | ... etc.
```

---

## 5. How the Tile Buffer Gets Populated

### Architecture

The world map data flow is:

1. **Data source**: Embedded in the EXE at the tile buffer location (`0x246C:0x244B`). 76 unique initial tile values form a template.

2. **Runtime buffer relocation**: The code uses segment pointers from `DS:[0x53C6h]` -> `0xF187` at runtime. However, the actual world map tile buffer lives in the `0x246C` sub-segment (within physical segment `0x0000`) because the game reuses that address space.

3. **Source copy**: `fn0800_48B7` (at `0x0800:0x48B7`) orchestrates world map initialization:
   - Copies `0x3F00` bytes from segment `0x3092` (save game/game state) to a work area
   - Clears `0x1E78` bytes starting at `0x244B` (the tile buffer area)
   - Calls `fn0800_1AFD` which copies from `(0x246C:0x42F6)` to `(0x246C:0x244B)`

4. **Game state overrides**: The tile buffer is then modified based on:
   - **Visibility** (`0xCB0C` bitmask in segment `[0x538Ah]`) -- explored/unexplored areas differ
   - **Story progression** -- buildings change (e.g., Citadel destruction in MAP11)
   - **Encounter placement** -- `fn183B_27C9` writes to the 0xD457/0xD497/0xD4D7/0xD517 arrays

5. **Rendering pipe**: `fn0800_051B` (called on every frame from main loop) calls `fn0800_2A93` which reads the tile buffer and renders it to screen.

### Key Functions

| Function | Address | Role |
|---|---|---|
| `fn0800_2A93` | `0800:2A93` | World map tile renderer -- reads 64 tiles, positions them on screen |
| `fn0800_1AFD` | `0800:1AFD` | Copies tile data from source buffer to display buffer |
| `fn0800_48B7` | `0800:48B7` | State machine init -- clears buffer, sets up source pointers |
| `fn0800_051B` | `0800:051B` | Main unit processing -- calls tile renderer, initializes unit data |
| `fn183B_27C9` | `183B:27C9` | Writes to tile data arrays (0xD457, 0xD497, 0xD4D7, 0xD517) |
| `fn207F:28EB` | `207F:28EB` | Tile blit to framebuffer |
| `fn207F:23EC` | `207F:23EC` | Block memory copy (used by fn0800_1AFD) |

### Array Layout (segment pointed by `DS:[0x538Ah]`)

| Offset | Size | Content |
|---|---|---|
| `0xD457` | 64 | Per-viewport-tile data (tile IDs, packed with flags) |
| `0xD497` | 64 | Packed position/screen X data (viewport tile X + cursor offset) |
| `0xD4D7` | 64 | Y-component of world coordinates per tile |
| `0xD517` | 64 | X-component of world coordinates per tile |
| `0xD557` | 2 | Pointer/counter into the above arrays (next slot index) |
| `0xCB0C` | 2048 | Visibility bitmask (128x128 bit-packed?) |

---

## 6. Is the World Map Procedural?

**Partially.** Our analysis shows:

- The **base terrain** (water vs land, ground types, road network) is **pre-defined** in the EXE's initial data at the tile buffer address. The map is not fully procedurally generated.
- However, **building/city tiles** and **road visibility** are **state-dependent**:
  - The `0xCB0C` visibility grid controls what tiles are "explored"
  - Story progression modifies building tiles (e.g., destroyed Citadel)
  - Encounter placement writes specific tile values into the `0xD457` array for the 8x8 viewport
- The tile differences between EXE (76 unique, 718/4096 matching) and runtime (93 unique) suggest **~17 new tile types appear at runtime** through game state modifications

**Conclusion**: The world map is a **static template modified by dynamic game state**. No separate world map file exists because the data is embedded directly in the executable and modified in-place.

---

## 7. Tile ID Mapping to MAP.ICN

The tile buffer values (0-255, with 93 unique) **directly index into the game's tile graphics**. From the tile property table at `0x246C:0x7AD` (256 entries), we can see that values > 93 appear and have property entries, meaning the game supports many tile types beyond MAP.ICN's 94 apparent tiles.

Likely explanation: **MAP.ICN contains 94 base tiles, but the EGA planar tile system allows tiles to be re-colored or variant-selected through palette manipulation or by loading additional tiles from ANIMATE.ICN, BTTLTECH.ICN, or other ICN files.** The tile IDs in the world map buffer are the actual display indices.

---

## 8. ASCII Map (64x64)

Full 64x64 ASCII World Map of Pacifica

```
Legend: ~=Water  ░=Light  ▒=Medium  ▓=Dark  █=City  ═=Road  ║=Wall  #=Structure
```

### Left Half (Columns 0-31)

```
 0|~.█═█.█═░.~█═█.█═░..█═~.█═░.#▒.░|
 1|▒░▒#█▒█▒█▒█▒█▒█▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓|
 2|█═▒═══░░░█▒║░░░░░║░║░░░░░║░║░░░░|
 3|#▒░══.▓░░═▒░══.▓░#═▒▒═══════════|
 4|═░░█▒▒░═#██#░░░░▒.══▒▒════█═▒▒══|
 5|░═.#░═.▓░▒░═.▓░░░░═.▓░#░═.▓░#░═.▓|
 6|█░░▒█▒█▒█▒█▒█▒█▒▒▒██████████████|
 7|═░▒═║═░▒░░░░░░░░░░░░░░░░░░░░░░░░|
 8|═░.░▓#▓#▓#▓#░▒░▒░▒░▒█░██████████|
 9|█░░░░░░░#██#░░░░█.▒██░▒══▒═▒█░▒═|
10|░░▓▓░░.▓░░═▓░░░▒▓░░▒▓░░═▓░░═▓░░═|
11|██░░█▒█▒█▒█▒█▒█▒▒░▒███~▒█████▒..|
12|═▒.║▒═█░░░▒░▒║░▒░░▒░▒║░▒░░▒░▒║░▒|
13|═.═.═▒═▒═▒═▒░▓░░░#░~█▒▒███████~▒|
14|██░░░║║░#██#░▒░║░█═▒░═▒▒█═══░═▒▒|
15|▓░═.═.═~▓░░▓.░░▓.░░░▒#.▓░═▓.░═▓.|
16|.██░█▒█▒█▒█▒█▒█▒▒░░▒███~▒█████▒.|
17|▒░▒▒═█║░░░░║░░░░░░░░░░░░░░░░░░░░|
18|▓═▓░#░#▒░.▓░#░#▓░▒▓░█▒█░████████|
19|███░░░░║#██#▒░░║░░░.▒▒██▒░══▒▒██|
20|.#▓═▓░#░#▒░.▓░#═░..░#░░.══~░░.░.|
21|█▒█▒█~~~█████▒█▒▒░░░░░░░▒═║░░░░░|
22|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░░▒░|
23|░.░.░#═░░#═░..░#═░═▓█▒█▒█▒█▒█▒█▒|
24|═░░░░░░░#██#░░║░░║░░█═▒.══░═█▒█▒|
25|▓░#═▒░.══░═▓.░═▓.░░═▓.░═▓..▒▓#░░|
26|█▒█▒~════.░░█▒█▒▒░░░░░░░░░║║░░░░|
27|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░░░.|
28|░░░#▒░.▓░#░#▓░▒▓░#░#█▒█▒█▒█▒█▒█▒|
29|▒░░░░║░░#██#░░░▒░░░║.══░░══██▒█▒|
30|═▓░#═~.═.▓░#▒═▒═▒▓░#═.═.▒▓░#░▓.░|
31|█▒█▒.▒###▒░.█▒█▒▒░█░░░░░░░░░║░░░|
32|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░░░.|
33|~~~~~~~~~~~~~~~~.██.█▒█▒█▒█▒█▒█▒|
34|║░░░░░░░#██#░▒░░░░░░═░══▒═▒▒█▒█▒|
35|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
36|█▒█▒.###.░░.█▒█▒▒░~█║░░░░▒░░░░░░|
37|█▒█▒█▒█▒█▒█▒█▒█▒█▒█
### Right Half (Columns 32-63)

```
 0|.═░.▒~.░~═░.~.═~═░...▓▓▓▓▓▓▓▓▓▓▓|
 1|▒░▒#▒░▒░#██#▒░█▒▒.══▒░║▒█═▒═▒░║▒|
 2|░══.▓░▓▓▒░══.░░▓▓░░░═.#░░░══.▓░▒|
 3|═░░██▒█▒█▒█▒█▒█▒▒═══════════════|
 4|══█═█═░░░║▒░░░░░═░║║░░░░═░║║░░░░|
 5|░#░═.▓░#░═.░░#░═.#░═█#██████████|
 6|█░░▒░░░░#██#░░║░▒▒░▒▒░═══░▒═▒░══|
 7|.▓~░#.░~.#░══▓.░═▓.░═▓.░═▓.░═░.░|
 8|█░░░█▒█▒█▒█▒█▒█▒▒░██████████████|
 9|═▒═▒═█▒░░░░░▒▒░░░░░░▒▒░░░░░░▒▒░░|
10|▓░░.▓░░.▓░░▒▓░░▒▓░░═█▒#██████▒..|
11|██░░░║░░#██#▒░░░.═.═▒═▒║═▒.║▒═▒║|
12|═▓░░.▓░░.▓░░▒▓░░▒▓░░═▓░░#░~.═.═.|
13|██░░█▒█▒█▒█▒█▒█▒▒░░███▒..█████~▒|
14|█═════█░░░░░░░▒░░▒▒░░░▒░░▒▒░░░▒░|
15|░═▓.░═▓.░░═░.░═░.#░═█▒█#██████▒.|
16|.██░░░░░#██#░░░░░.═▒══▒═▒░▒▒══▒═|
17|═▓░.░▓▒░.▓░.░▓▓░▒▓░~░░░▒═▓░░══.#|
18|███░█▒█▒█▒█▒█▒█▒▒░░░████████████|
19|▒░══██▒░▒░░░░║░░▒░░░░║░░▒░░░░║░░|
20|═.░░.░~═▒░░.░═▓░░.░═█▒█▒█▒█▒█▒█▒|
21|░░░░░░░║#██#░▒░░░░░░██▒▒═░║═█▒█▒|
22|▓░~..▓░═▒═▒═.▓░.═.═..░▓.░░░▓.░░░|
23|█▒█▒▒.══▒████▒█▒▒░░░░║║║▒░░░░░▒░|
24|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░║░.|
25|═░..░░░#░═#.▓▓▒═#.▒#█▒█▒█▒█▒█▒█▒|
26|░░═░░║║░#██#▒░░░░░░░║▒═░░║══█▒█▒|
27|░▓▒░░░═░.▒▓▓░░▓░░▒░░═░▓░░══.#▓═▓|
28|█▒█▒.═##░▒░~█▒█▒▒░░░░▒░░▒░░░║░░░|
29|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░░║█|
30|#░▓.▓═#░░.░#░░#.░░#.█▒█▒█▒█▒█▒█▒|
31|░░▒░░░░░#██#░░░░░░░░.░.═.║═░█▒█▒|
32|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
33|█▒█▒.###.▒░.█▒█▒▒░.░▒░░║░░░░║▒░║|
34|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░░░═|
35|~~~~~~~~~~~~~~~~.▒.▒█▒█▒█▒█▒█▒█▒|
36|▒░░▒▒▒░═#██#░░░░░░░░░░▒═══░░█▒█▒|
37|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
38|█▒█▒.░#░▓░░.█▒█▒▒░▒#░▒▒░░░░║░░░░|
39|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░.█═|
40|~~~~~~~~~~~~~~~~~~~~█▒█▒█▒█▒█▒█▒|
41|░░░░░░░░#██#░░░░░▒░░▒▒══█▒░░█▒█▒|
42|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
43|█▒█▒█▒.░▓.░.█▒█▒▒░░█░░░░~~~~~~~~|
44|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░█═█|
45|~~~~~~~~~~~~~~~~~~~~█▒█▒█▒█▒█▒█▒|
46|███████████#░░▒░░░░░.█░▒▒.▒░█▒█▒|
47|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
48|█▒█▒██████░.█▒█▒▒░░█▒▒░░#███████|
49|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░║█▒║|
50|~~~~~~~~~~~~~~~~~~~~█▒█▒█▒█▒█▒█▒|
51|███████████#░░░░░░░░▒░.█░▒░░█▒█▒|
52|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
53|█▒█▒█░░░░░░██▒█▒▒░░░░░▒░#███████|
54|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░.══░|
55|~~~~~~~~~~~~~~~~~~~~█▒█▒█▒█▒█▒█▒|
56|~~~~~~~~~~~#░▒░░░░║░▒▒▒░█░.║█▒█▒|
57|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
58|█▒█▒█░.....░█▒█▒▒░░░░║░░#██#████|
59|█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒█▒▒░░░█═▒░|
60|~~~~~~~~~~~~~~~~~~~~█▒█▒█▒█▒█▒█▒|
61|█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░░░░░░║░█▒█▒|
62|~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~|
63|█▒█▒█▒█▒█▒█▒█▒█▒▒░░░░░░░#██#█▒█▒|
```

---

## 9. Key Findings for Godot Reconstruction

1. **World map tile data is at `0x246C:0x244B`** as a 64x64 byte array with 93 unique tile IDs
2. **No separate world map file exists** - the data is embedded in the EXE and modified at runtime
3. **The map is a hand-crafted template** (not purely procedural), with terrain, cities, roads, and water pre-placed
4. **Game state modifies the map** - visibility, story events, and encounters write to specific tiles
5. **MAP.ICN provides the tile graphics** - tile IDs 0-93 correspond to MAP.ICN tiles, extended beyond 93 through additional graphics files
6. **The 14 local maps (MAP1-14) overlay the world map** - each is a separate 64x64 or 32x32 tile grid inside an MTP file, loaded when entering that location
7. **Visibility is 128x128 bit-packed** - 2x2 visibility bits per world map tile, persisted in save files
8. **Coordinates use 16-bit world-space values** - cursor formula `(wA44B & 0x7F) >> 1` extracts 0-63 tile coordinates
9. **Three parallel arrays** at `(DS:[0x538Ah]):0xD457/0xD497/0xD4D7/0xD517` govern the 64-tile viewport display
10. **fn0800_2A93 is the world map renderer** - called each frame when `bD310 != 0` (world map active flag)

For reconstruction in Godot: replicate the 64x64 tile grid as a `TileMap` (or 2D array), load MAP.ICN tiles as atlas/subresources, implement the same cursor-to-tile coordinate mapping, and add the visibility 2D bit-grid as a Fog of War layer.


---

## Random encounter system (formerly TECHNICAL_ANALYSIS §17)

### 17. WORLD MAP RANDOM ENCOUNTER SYSTEM

**RESOLVED:** Full encounter mechanics documented below.

The random encounter system is triggered by **walking on the world map** (not by entering buildings or the action menu). It is checked **every frame** in the main game loop at segment `0800`.

#### 17.1 Core Check

**File:** `UNBTECH.reko/UNBTECH_0800.c:192-201` (segment `0800`)
**Spice86:** generated code (segment `0170:0287`) — the old `spice86/GeneratedCode*.cs` tree was removed as stale (regenerate with a current Spice86).

```c
int16 ax_540 = fn207F_0BC0();          // RNG → random byte (0-255)
selector es_547 = ...;
if ((ax_540 & es_547->bD330) == 0x00   // Probability mask check
    && es_547->bD310 != 0x00           // On world map
    && es_547->bD346 == 0x00)          // NOT on star map / alternate view
{
    fn183B_000A(..., 0, ...);          // Initiate encounter → combat setup
}
```

#### 17.2 Probability Mask (`bD330` at segment offset `0xD330`)

The check is: **`RNG_byte & bD330 == 0`**. Since RNG returns 0-255 uniformly, the mask determines probability:

| Value | Binary | Match Condition | Probability | Context |
|-------|--------|----------------|-------------|---------|
| `0x1F` | `00011111` | 8/256 values match (0x00, 0x20, 0x40, 0x60, 0x80, 0xA0, 0xC0, 0xE0) | **1/32 ≈ 3.125% per frame** | World map walking (set at `UNBTECH_11B8.c:1120`) |
| `0x7F` | `01111111` | 2/256 values match (0x00, 0x80) | **1/128 ≈ 0.78% per frame** | After encounter/combat (set at `UNBTECH_183B.c:804`) |

**There is NO terrain/tile modifier**: the probability is flat regardless of which tile the player is on. No encounter rate table per tile type exists.

#### 17.3 Encounter Population (`fn0DAB_0D3D`, segment 0DAB:0D3D)

**File:** `UNBTECH.reko/UNBTECH_0DAB.c:972-1105`

When `fn183B_000A` is called, it invokes `fn0DAB_0D3D` to populate the enemy encounter group:

1. **Random position**: Units placed at (±10-17 from 26, ±10-17 from 12) on the 32×24 world map grid, independent of terrain type. Generated via `RNG & 0x07 + 0x0A`, with 50% sign negation.
2. **Clear all slots**: Slots 0-23 cleared (status=0, coords=0xFFFF) first
3. **Enemy infantry slots 8-15** (50% chance per slot):
   - Random equipment from table via 7-round loop: each round `RNG & 0x03` indexes 1 of 4 weapon types at `DS:[0x5434] + 0x2CF4` (weapon instance data, stride 0x11)
   - `bC61F[1][slot]` set to 0x08 (some type/weapon class)
   - `C618[slot][0..6]` each filled with `RNG & 0x03` (random item types 0-3)
   - HP/weapon state initialized via `fn0800_19DD` calls, combining 2D6 results
4. **Enemy mech slots 4-7** (50% chance per slot):
   - Guard check at `0xC530[slot * 0x7D] != ~0x00` — only populates if a valid template exists
   - Template selection: `RNG() % 3` indexes a table of **3 fixed word entries** (near offsets) at segment `[DS:0x5436]:0x2DF8`
   - Full 125-byte mech data copy from template to story slot
   - Post-copy: `D566[slot]` = 0x00 if template 0 selected, 0x92 if template 1 or 2 (∼67% chance of 0x92)
5. **Secondary weapon/position setup** (slots 8-15, if populated): terrain validation loop places each infantry unit on valid tiles, skipping if terrain property at `+0x7AD[tile] >= t0150` (blocked)

**IMPORTANT: No dynamic balancing** — There is NO code that reads the player's lance composition to calibrate enemy spawns. The 3 mech templates at `[DS:0x5436]:0x2DF8` are **read-only** (never written to after init). The template pointers are allocated at runtime (segment beyond EXE load image) and populated during game init from the static mech definitions in segment 1A00.

**Known mech definitions** (125-byte structs, stride 0x7D, mech ID at offset 0x7B):

| Mech ID | Name | Tonnage | Walk | Jump | Notes |
|---------|------|---------|------|------|-------|
| 0x00 | LOCUST | 20t | 8 | 0 | Fast scout |
| 0x01 | WASP | 20t | 6 | 6 | Jump-capable |
| 0x02 | STINGER | 20t | 6 | 6 | Jump-capable |
| 0x03 | COMMANDO | 25t | 6 | 0 | SRM-armed |
| 0x06 | URBANMECH | 30t | 2 | 2 | Slow heavy armor |
| 0x09 | JENNER | 35t | 7 | 5 | Story-only, Kuritan |
| 0xC8 | CHAMELEON | 50t | 6 | 6 | Player starting mech, story-only |

**Melee-only enemies:** The Spectator (decoy/non-combatant, mech ID 0x00 same as Locust) exists in the codebase but was not found in the EXE binary data.

**Known weapons** (17-byte stride, table at `DS:+0x2EE4`): 33 weapons total, range includes: Cludgel, Knife, Sword, Vibroblade, Shortbow, Longbow, Crossbow, Pistol, Rifle, MachineGun, SRMissile, Inferno, LaserPistol, LaserRifle, Flamer, Small/Medium/Large Laser, PPC, AC/2/5/10/20, LRM5/10/15/20, SRM2/4/6, Kick.

**Key insight**: The encounter system generates up to 4 random mechs from a **fixed pool of 3 light mech templates** (likely Locust, Wasp, Stinger — the 20t lights), plus up to 8 random infantry. Heavier units like the Jenner (35t), UrbanMech (30t), and Chameleon (50t) are **story-controlled only** and never appear in random walking encounters. The game has zero assault or heavy mechs — the 50t Chameleon is the maximum weight. The player's perception of "not encountering heavy mechs when piloting lights" is a consequence of the fixed light-mech template pool, not any dynamic balancing algorithm.

#### 17.4 Encounter Positioning (`fn183B_28DB`, segment 183B:28DB)

After population, `fn183B_28DB` positions the encounter on the world map:

1. Reads cursor position (`A44B`/`A44D`) and location offsets (`t400C`/`t403E`)
2. Checks special encounter flag at `DS:55D4→bC620` — if `!= 0x08`, overrides position with unit 0's coordinates from `0x4004`/`0x4036`
3. Moves cursor to calculated position via `fn0800_17BB`
4. Scans extended pool (slots 12-23) for active units, records first found
5. Sets `t3770 = 0x1E` (30-step search range)
6. Iteratively adds `t458E`/`t4590` offsets toward target position, decrementing step counter until position match or 30 steps exhausted
7. Returns 1 (success) if a valid position was found, 0 otherwise
8. On success, `fn183B_000A` loads and displays the encounter BLD narrative text (index 13314)

**Key insight**: Enemies are placed relative to center (26, 12) regardless of terrain. The encounter system has no terrain-type modifiers for probability or composition. Story-progression gating happens through the bD330 probability mask changes (0x7F post-combat) and bD310/bD346 guards.

#### 17.5 Mode Guards

**`bD310`** (at `0xD310`) — **World map active flag**:
- Set to `0x01` when entering the world map view (`UNBTECH_0FDC.c:1075` / `GeneratedCode7.cs:2754`)
- Must be non-zero for encounters (player must be on world map, not in a building/menu)

**`bD346`** (at `0xD346`) — **Star map / alternate view flag**:
- Set to `0x01` by `fn0800_2DA8` when `wArg06 == 0x0E` (`UNBTECH_0800.c:2913-2917`)
- Must be zero for encounters (player must not be on the star map or in combat view)

#### 17.6 Encounter Initiation: `fn183B_000A` (segment `183B:000A`)

**File:** `UNBTECH.reko/UNBTECH_183B.c:7-303`

Called with `wArg04 = 0` when encounter triggers. Steps:

1. **Lines 104-117**: Saves current unit state into encounter save buffers
2. **Lines 118-153**: Initializes combat arrays:
   - Clears position data (`0x4004`/`0x4036` = -1 for all 24 slots)
   - Sets all unit slots to inactive/dead (`w406A = 0`)
   - Initializes visibility maps (24 rows × 24 columns for fog of war)
3. **Lines 154-166**: Initializes unit flags and counters (8 iterations for various flag arrays)
4. **Lines 167-224**: Positions units based on current `A44B`/`A44D` coordinates, applying offset via `fn0800_191B`/`fn0800_186F`
5. **Lines 230-251**: Calls `fn0DAB_0D3D` for unit population, sets `w37FE = 0x0F`, counts active units
6. **Lines 252-253**: Calls `fn183B_28DB` for encounter-specific enemy/environment setup
7. **Lines 254-303**: Loads and executes BLD script `0x33FC` for encounter narration, displays enemy count UI, and transitions into combat
8. **Line 804**: Sets `bD330 = 0x7F` to reduce re-encounter probability during/after combat

#### 17.7 World Map Movement System (How Walking Happens)

**File:** `UNBTECH.reko/UNBTECH_207F.c:1920-2074`

| Function | Description |
|----------|-------------|
| `fn207F_158C` | Move cursor **up** (decrement Y, with scroll wrap) |
| `fn207F_163B` | Move cursor **down** (increment Y, with scroll wrap) |
| `fn207F_16E3` | Move cursor **left** (decrement X, with scroll wrap) |
| `fn207F_17C5` | Move cursor **right** (increment X, with scroll wrap) |

High-level movement dispatch at `fn0800_17BB`/`fn0800_186F`/`fn0800_191B` in `UNBTECH_0800.c:1142-1219`. Keyboard input handled by `fn0800_231D` at `UNBTECH_0800.c:2004-2078`.

All direction functions handle screen scrolling by copying video memory when cursor crosses tile boundaries (wrapping at 0x00/0xF0 for coordinate high byte).

#### 17.8 World Map Coordinate System

From `UNBTECH_0FDC.c:868-869`:
```c
tile_x = (A44B & 0x7F) >> 1;   // 0-63 range
tile_y = (A44D & 0x7F) >> 1;   // 0-63 range
```

- Low byte: sub-tile position within a 16×16 grid (step size 2 pixels)
- High byte: tile column/row index
- Star map (MAP15) tiles accessed as `tile[y * 32 + x]` where x=0..31, y=0..23 (768 bytes, linear format)

#### 17.9 Relationship to Segment 0D27 (Action Menu)

Segment `0D27:0044` is **NOT** the random encounter handler. It is the **action menu handler** triggered by pressing SPACE at a location. It presents options 1-4 (actions like enter building, leave city, etc.) and processes the player's choice. The `w4FBA = 2` transition seen there is from the menu choice going into combat (e.g., selecting "fight" at a location), not from random walking encounters.

#### 17.10 Encounter Flow Summary

```
Main Game Loop (fn0800_0000)
  │
  ├─ Read keyboard → fn0800_231D (key dispatch)
  │   └─ Arrow keys → movement functions (update A44B/A44D)
  │
  ├─ Space bar → fn0800_2C50 (action menu at 0D27)
  │
  ├─ ENCOUNTER CHECK (0800:192-201 every frame):
  │   RNG & bD330 == 0  AND  bD310 != 0  AND  bD346 == 0
  │   │
  │   └─ True → fn183B_000A
  │       ├─ Save current positions
  │       ├─ Initialize combat arrays (clear all units)
  │       ├─ Populate enemies via fn0DAB_0D3D + fn183B_28DB
  │       ├─ Execute BLD script 0x33FC for encounter narration
  │       ├─ Set bD330 = 0x7F (reduce re-encounter probability)
  │       └─ Transition to combat mode (w4FBA → 2)
  │
  ├─ Decrement timers (bD320-bD323)
  │
  └─ fn0800_240B/fn0800_24C2 (refresh cycle)
```

---


---

## NPC world-map movement (formerly TECHNICAL_ANALYSIS §18)

## 18. NPC World-Map Movement Engine

### 18.1 Overview

The game drives autonomous NPC movement through `fn0800_24C2` (segment `0800:24C2`), called every 3rd frame from the main game loop (`fn0800_0000`). It handles **8 story character slots** (indices 0-7) — named NPCs like Rick Atlas, Rex Pearce, and other plot-relevant characters that walk around the game world.

Generic background NPCs (the ones walking around the training center compound) are part of the **tile animation system** (`fn0800_240B`) — they are drawn as animated tile sprites, not as independently moving units.

### 18.2 Data Structures

| Address | Size | Field | Description |
|---------|------|-------|-------------|
| `seg 0x538A : 0xD398[slot]` | 1 byte × 8 | Direction/state nibble | High nibble = BLD index (which building NPC is in). Low nibble = facing direction (0-7). Packed as `(bld_idx << 4) \| direction` |
| `seg 0x538A : 0xD399[slot]` | 1 byte × 8 | Movement delay timer | Counts down each frame. When 0, NPC takes a step. Initialized to specific values per slot at game start. Reset to `~0x00` (0xFF) when slot 0 (`bD339`) triggers |
| `0x4024[slot * 2]` | word × 8 | Destination X | Target X coordinate NPC is walking toward |
| `0x4056[slot * 2]` | word × 8 | Destination Y | Target Y coordinate NPC is walking toward |
| `0x4004[(slot+0x10) * 2]` | word × 8 | Current X | NPC's actual X position on the map |
| `0x4036[(slot+0x10) * 2]` | word × 8 | Current Y | NPC's actual Y position on the map |
| `seg 0x53CA : 0x4564[idx * 2]` | word × 8 | Waypoint X table | 8 destination X coordinates indexed by direction (0-7) |
| `seg 0x53CC : 0x57D6[idx * 2]` | word × 8 | Waypoint Y table | 8 destination Y coordinates indexed by direction (0-7) |

### 18.3 Movement Algorithm (`fn0800_24C2`)

```
For each NPC slot (0..7):
  1. Check if NPC is active (non-zero at slot offset `0x1A` in story state)
  2. Decrement movement timer `bD399[slot]`
  3. IF timer just reached 0:
     a. Read direction nibble from `0xD398[slot] >> 4`
     b. Use direction as index into waypoint tables:
        Destination X = `0x4564[direction * 2]`
        Destination Y = `0x57D6[direction * 2]`
        
  4. IF NPC active (slot's `~0x2C66` offset != 0):
     a. Save current cursor (A44B/A44D)
     b. Call `fn0800_191B` to adjust cursor toward destination
     c. Compare adjusted cursor X with NPC's current X (from `0x4004[(slot+0x10)*2]`)
     d. Try moving toward destination by adjusting cursor + calling `fn0800_191B`
        in each axis (X first, then Y)
     e. Call `fn1631_0006` (LoS tile-step pathfinding) to validate the move
     f. Update position arrays:
        `0x4004[(slot+0x10)*2]` = new X
        `0x4036[(slot+0x10)*2]` = new Y
     g. Update direction-relative sprite offset for rendering
        
  5. IF NPC reached destination (current X/Y == waypoint X/Y):
     a. Generate new random direction: `RNG() & 0x1F`
     b. Extract low 3 bits as new direction: `al_407 = random & 0x07`
     c. Update `0xD398[slot]`:
        high nibble = old high nibble (BLD index preserved)
        low nibble = new direction
     d. Look up new waypoint from tables at `0x4564[dir*2]` / `0x57D6[dir*2]`
     e. Reset destination in story state at `54164[slot*0x1A]`/`54166[slot*0x1A]`
     f. Clear current position to 0 (NPC vanishes until next step)
        
  6. Restore original cursor (A44B/A44D)
```

### 18.4 Building Entry / NPC Detection

When the player enters a building, code at `fn0FDC` (~line 1750) checks which NPCs are inside:

1. For each NPC slot (0..7), checks `bD399[slot] != 0` as an activity flag
2. Reads `0xD398[slot] >> 4 & 0x07` to get the NPC's BLD index
3. If BLD index matches the building being entered:
   - Marks NPC as present in this building
   - Counts total matching NPCs
4. If any NPCs present:
   - Loads NPC dialogue text from BLD strings
   - If multiple NPCs, presents selection menu
   - Renders dialogue via `fn1E56_03F5`
5. Special cases:
   - If `bD339 != 0 && current_dir == 7 && selection == 0 && some_flag != 0`:
     Sets `bD33A = 1`, resets `bD399[slot] = 0` (story trigger)
   - If world map not active (`bD310 == 0`): loads additional room-specific text

### 18.5 Key Observations

- **No follow-player AI**: NPCs do not track or follow the player. They wander between fixed waypoints.
- **No A* pathfinding**: Movement uses `fn1631_0006` (LoS tile-step, 8-direction delta tables), which only checks immediate tile blocking. NPCs can get stuck on obstacles.
- **Building warping**: When NPCs enter buildings (BLD index matches), their world-map position clears to 0 and they "appear" inside via the BLD dialogue system.
- **Movement granularity**: Position coordinates use sub-tile precision (similar to cursor at `0xA44B`/`0xA44D` with sub-pixel flags). Movement step size is controlled by `fn0800_191B` which wraps coordinates in ranges.
- **Timer granularity**: `bD399` counts game frames (every 3rd frame = ~5 FPS at 60fps). Different slots may have different initial timer values, causing desynchronized movement.

### 18.6 Known Gaps

1. How NPC initial positions and BLD indices are assigned at game start
2. Exact waypoint table contents (8 coordinate pairs × direction)
3. How `fn0800_191B` cursor adjustment maps to grid-aligned NPC positions
4. Interaction between NPC movement and combat initialization (`fn183B_000A`)

---

