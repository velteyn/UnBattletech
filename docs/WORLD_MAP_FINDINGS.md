# World Map Analysis: BattleTech - The Crescent Hawk's Inception

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
