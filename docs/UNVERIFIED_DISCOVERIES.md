# Unverified Discoveries & Working Theories

## 1. World Map Data Location
- **Hypothesis**: Map data (125x125 tiles) should be in Segment `2A02`.
- **Status (UPDATED)**: The `2A02:C724` address was originally hypothesized as "Fog of War data" but has been **corrected** — `C724` is a per-story-slot data array (stride `0x7D`) located `0x20` bytes before the `aC744[]` story state array at `0xC744`. The combat fog of war is at `DS:[0x55D8]→0x40B4`/`0x41D4` (twin 12×24 grids). World map visibility (2048 bytes, bit-packed 128×128) is persisted in save files at segment `0x3092`.
- **Investigation Needed**: 
  - Trace `19EF:0BC0` deeper to see if other bits of `384B:4FC0` relate to map tiles.
  - Locate where `TRAINING.BLD` or `MAP.DAT` is loaded into memory.
  - Tile data may be loaded dynamically into `384B` (Heap) or exist in `2A02`.

## 2. Tile Attributes & Terrain Collision
- **Note (2026-09-28)**: the **map→BLD building-trigger** is now **decoded** — it does *not* use `0x32C6`
  but the building-position tables + `[0x5460]:0x4602`; see
  [`formats/map-bld-triggers.md`](formats/map-bld-triggers.md). The **terrain/passability** bits of
  `0x32C6` (`+0x7AD`) remain open below.
- **Hypothesis**: `3000:32C6` contains tile properties (Movement cost, blocking).
- **Observation**: Pattern `4C 04 C0` repeats.
- **To Verify**:
  - Which bit corresponds to "Water" (needs boat/hover)?
  - Which bit corresponds to "Wall" (impassable)?
  - Find the function that reads `3000:32C6` during movement (distinct from the Unit Damage check at `13DDC`).

## 3. .BLD File Internals (Scripting)
- **Hypothesis**: `.BLD` files contain bytecode/triggers for room interactions.
- **Status (RESOLVED)**: Fully documented — 26 BLD files, substitution cipher text encoding, **28 opcode slots (0xE4-0xFF; 27 present in the corpus)**, 4-layer interpreter. Full round-trip JSON conversion verified byte-identical. Story complete extracted. See `formats/bld-bytecode.md`, `formats/bld-opcode-coverage.md`, `bld_json_converter.py`.

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

## 6. Game-state segment: ES (0x2A0F) vs DS (0x1DE9) — RESOLVED

**Status (2026-09-28): RESOLVED.** BattleTech switches data segments at runtime; the
`bt_*` tools had read everything from a single fixed segment (`0x1DE9`). Corrected mapping:

| Segment | Role | Structures |
|---------|------|------------|
| `0x1DE9` | world-map / render data | cursor `0xA44B/0xA44D`, tile buffer `0x0F00` |
| `0x2A0F` | **game state** | state array `0xD30C`, credits `0xD370`, story slots `0xC724`, unit slots `0xC614`, flags `0xD450` |
| `0x3858` | UI/viewport struct (+ stack) | `w4FBA 0x4FBA`, `w4FBC 0x4FBC`, `a4FC4/a4FCC/a4FD4` |

Evidence: on the world map, `0x2A0F:0xD370` = 20 (matched the on-screen C-Bills) and
`0x2A0F` story/unit slots were populated, while `0x1DE9` held zeros there; the cursor
matched at `0x1DE9:0xA44B`.

**Fix applied**: `BattleTechMcpTools` now uses `GameStateSegment = 0x2A0F` for state/credits/
story/units/flags and `MapDataSegment = 0x1DE9` for the cursor. Verified live (`bt_read_credits`
→ 20, `bt_read_unit_slot` → populated). Constants assume the standard Spice86 load base `0x17D`.

Combat grids/units (`0x40B4/0x4004/…`) are **inferred** to also live in `0x2A0F`: the documented
fog pointer `DS:[0x55D8]→0x40B4` resolves to `[0x3858:0x55D8] = 0x2A0F`. The tools were updated
accordingly, but a **live in-combat capture is still pending** — the current game state (degraded
"continue", state array all zero) does not spawn random encounters, so reach combat first (proper
NEW_GAME training mission, or the arena).

**UPDATE 2026-09-28 — LIVE-CONFIRMED.** Found a **save pack** already in the game folder
(`GAME1`–`GAME6`, dated 2002–2004; GAME5/6 are late-game with 3 mechs). Loading slot **Five** in
game (system menu → Load Game → Five) lands Jason/Rex/Russ directly in a **combat encounter**, and
`0x2A0F` then holds: unit arrays `0x4004/0x4036/0x406A` with active units, and the fog grids
`0x40B4/0x41D4` **288/288 fogged (0x02)**. The `bt_*` combat tools (reading `0x2A0F`) return this
data. Combat segment **confirmed at `0x2A0F`** — no longer inferred.

## 7. Westwood engine viewport abstraction — how complete is our coverage?

The game was written by **Westwood Associates** (in-game copyright: "Computer program by
Westwood Associates"). Westwood's engine is viewport-centric: later titles (Eye of the
Beholder, Kyrandia, Lands of Lore) use an explicit viewport/page system (set-viewport,
clipped blit, page flip). It is **unclear whether BattleTech (1988) uses the same primitive
and whether we have fully mapped its workflow**.

**What we have** (see `story/story-system.md` §"Viewport Clipping System", `context.md`):
- 3-pass render pipeline: Pass 1 right panel tiles (`fn207F_18EF`, 13×12 grid); Pass 2 left
  panel border (`fn1F3D_06C3` → `fn207F_1CB8` full / `fn207F_1D3A` narrow / `fn207F_245C`
  text); Pass 3 text overlay (`fn1E56_03F5`).
- Mode flags: `w4FBA` (4 modes, startup only), `w4FBC` (narrow-panel binary flag — the real
  dynamic mechanism), `tB764` (pixel-format/blitter selector at seg `246C`).
- Clipping: `fn207F_24D7`, 4 cases by `tB764` (CGA 80px / VGA-text 40-col / EGA 160px / full 320px).
- Left panel width hardcoded `0x50` (80px).
- Corrected earlier error: `fn207F_1B80` ("configure viewport dimensions") does **not** exist.

**Unverified / gaps**:
- Is there a canonical **viewport struct** (`x, y, w, h, buffer, page`) plus a set/clip
  function, or is the viewport implicit in the fixed panel widths?
- The **rendering-config struct at segment `0x246C`** (holding `tB764` + border/source
  pointers) is only partially mapped — is this the Westwood viewport/config table?
- How viewports are **pushed/popped** per screen (modal screens, combat, stat screen): we know
  `w4FBC`/`w014A`, but not a general save/restore of viewport state.
- Relationship to the later Westwood engine (Beholder/Kyrandia) viewport model.
- Whether a viewport primitive lives in the **not-decompiled segments** (the docs note the
  combat/movement code at segments `19EF`/`1000` is absent from the Reko output).

**Investigation needed**: trace `fn207F_24D7` callers and the seg-`0x246C` config struct;
check whether a viewport struct is passed to the blit routines.

## 8. New-game start state & reaching combat (open, 2026-09-28)

Attempts to reach combat for a **live** confirmation of the combat segment (see §6) revealed:

- **No separate main menu is observed.** Boot goes title → copyright + "Is this your first time
  playing BattleTech? Yes/No" → gameplay. The game starts (or continues) automatically.
- **A fresh boot (all `GAME*` saves removed) starts in the Pacifica Training School city** with
  character `Jason` and a **small starting balance (~20) that ticks up by +15 periodically** — the
  walkthrough confirms this: *"Every five minutes or so your account is boosted by fifteen credits as
  your parents send you more allowance."* So the docs' **`NEW_GAME_INIT` = 1500 cr is WRONG**; the real
  new-game start is a low balance + allowance ticks. (Docs corrected.)
- **Combat was not reachable this session**: random encounters did not fire (state array all zero →
  encounter mask unset), and entering the training building was not achieved (world-map `(26,5)` is a
  *local-map* coordinate; the world-map building tile for the training center wasn't located).

**Update (2026-09-28)**: a **save pack already exists in the game folder** (`GAME1`–`GAME6`; GAME5/6
are late-game with 3 mechs, 66k credits). Loading slot 5 in-game drops straight into **combat**, which
resolved the §6 verification — see above. Using these saves is now the fast way to reach late-game
states (combat, cities, COMSTAR) without a full playthrough: enable a slot (`GAME5.disabled` →
`GAME5`), then system menu → **Load Game** → pick the slot.

## 9. COMSTAR (stock market) location (from walkthrough)

Per `docs/walkthrough/bt-walkthrough-1.md`: at the start you are in the **Pacifica Training School**,
*"opposite the Citadel"*, with **Comstar next door** (the stock market) and the **barracks to your far
left**; southeast of the barracks is the Mech training center. Other buildings: Weapons, Armor, Lounge,
Mechit-Lube. The stock market is also active in the other cities.
`fn1CD3` case 0x05 is the SPACE-menu stock-market handler (`fn0800_35D3`).

**Reaching it live (VERIFIED 2026-09-28)**: COMSTAR is entered on the **start map** (a city/local map,
not the world map). The buildings are joined by a road: walk **east along y=12** to the road's east end
(x≈51), then **north** up the vertical road — the entrance is at ≈ `(51,10)`, the gap between the
building's two red wings (flanked by blue domes) → *"Will you enter the ComStar Station? Yes/No"*.
Inside: *"You are standing in the entry hall of an official ComStar hyperpulse generator station…
Will you: Inspect your accounts / Talk to others / Leave."*

> COMSTAR is present in **multiple cities**, so the earlier `(27,9) map 2` note may describe a *different*
> city. On the **start map** it is far east along the road at ≈ `(51,10)` (the `(27,9)` tile there gives no
> popup). Stock UI still to be walked through in detail.
