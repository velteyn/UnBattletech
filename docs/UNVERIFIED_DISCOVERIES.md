# Unverified Discoveries & Working Theories

## 1. World Map Data Location
- **Hypothesis**: Map data (125x125 tiles) should be in Segment `2A02`.
- **Status (UPDATED)**: The `2A02:C724` address was originally hypothesized as "Fog of War data" but has been **corrected** — `C724` is a per-story-slot data array (stride `0x7D`) located `0x20` bytes before the `aC744[]` story state array at `0xC744`. The combat fog of war is at `DS:[0x55D8]→0x40B4`/`0x41D4` (twin 12×24 grids). World map visibility (2048 bytes, bit-packed 128×128) is persisted in save files at segment `0x3092`.
- **Investigation Needed**: 
  - Trace `19EF:0BC0` deeper to see if other bits of `384B:4FC0` relate to map tiles.
  - Locate where `TRAINING.BLD` or `MAP.DAT` is loaded into memory.
  - Tile data may be loaded dynamically into `384B` (Heap) or exist in `2A02`.

## 2. Tile Attributes & Terrain Collision
- **Hypothesis**: `3000:32C6` contains tile properties (Movement cost, blocking).
- **Observation**: Pattern `4C 04 C0` repeats.
- **To Verify**:
  - Which bit corresponds to "Water" (needs boat/hover)?
  - Which bit corresponds to "Wall" (impassable)?
  - Find the function that reads `3000:32C6` during movement (distinct from the Unit Damage check at `13DDC`).

## 3. .BLD File Internals (Scripting)
- **Hypothesis**: `.BLD` files contain bytecode/triggers for room interactions.
- **Status (RESOLVED)**: Fully documented — 26 BLD files, substitution cipher text encoding, 26 opcodes (0xE4-0xFF), 4-layer interpreter. Full round-trip JSON conversion verified byte-identical. Story complete extracted. See `BLD_BYTECODE.md`, `decode_bld_interp.py`, `bld_json_converter.py`.

## 4. "Palace" Dialogue
- **Hypothesis**: The "Palace" mentioned by the user is the "Citadel".
- **Status (RESOLVED)**: Story fully extracted — the "Citadel" is the training center. "Palace" may refer to a location in the game's world that was never implemented or is accessible via different context. No "Palace" text found in any of the 26 decoded BLD files or the story output.

## 5. Story State Byte at C79B / Eq_57354::aC744[].b0057
- **Hypothesis (now mostly confirmed)**:
  - The byte previously observed at `ES:[BX+0C79B]` in the `INC` instruction is field `b0057` inside struct `Eq_107947`, which is an element of the `aC744` array inside `Eq_57354`.
  - `Eq_107947` has size `0x7D` bytes, and the per-entry index is `wArg04`, matching the `wArg04 *s 0x7D` addressing seen in the disassembly.
- **Current Evidence**:
  - `UNBTECH_1631.dis` shows:
    - Addressing pattern `es:[wArg04 *s 0x7D + 0xC79B]` for comparisons and increments of this byte.
  - `UNBTECH_1631.c` (`fn1631_11AB`) accesses:
    - `es_357->aC744[0].b0057[wArg04]` with an upper bound check `< 2`, then increments it.
  - `Eq_57354` definition in `UNBTECH.h` contains:
    - `Eq_107947 aC744[]; // C744`
  - `Eq_107947` definition shows:
    - A byte at offset `0x57` (`b0057`) inside a 0x7D-sized struct, lining up with `0xC744 + 0x57 = 0xC79B`.
- **Unverified / To Clarify**:
  - Exact semantic meaning of `b0057` (we treat it as the "Citadel attack" story state flag, with values 0,1,2 based on behaviour around the plot twist, but this is still inferred).
  - Whether other values (beyond 0–2) are ever possible or meaningful.
  - Precise meaning of the neighbouring fields `b0055`, `b0056`, and `b0058`, which are also manipulated in `fn1631_11AB` under different `wArg06` cases.
- **Investigation Needed**:
  - Trace all cases of `fn1631_11AB` (especially property IDs `0x1C–0x23`) during live gameplay to map each property ID to a narrative concept.
  - Correlate changes in `b0057` with visible in-game events across multiple playthroughs to fully confirm the 0/1/2 meanings.
  - Analyse other functions that read from `0xC79B` / `aC744[].b0057` to see if there are additional branches or side effects beyond the initial plot twist.
