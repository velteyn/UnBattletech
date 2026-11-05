# Story System — Reverse-Engineering Specification

> Canonical story-system reference (state model, BLD script arc, NPC movement).
> Consolidated from the former `TECHNICAL_ANALYSIS.md` (§17 + §17.13).
> For the narrative summary see `docs/story/story-arc.md`; full prose in `STORY_TEXT.txt`.

## 17. STORY ARC & PROGRESSION SYSTEM

The game uses a **three-layer state system** to drive the narrative. These layers work independently but interact through BLD scripts.

### 17.1 Three-Layer State Architecture

**Layer 1: Generic State Array at `D30C` (256 bytes)**
- Modified by BLD opcodes: `0xF1` (ADD_TO_STATE) and `0xF4` (SET_STATE_VALUE)
- Checked by opcodes: `0xF7` (STATE_COND_CHECK) and `0xF3` (SHOP_INTERACTION)
- Handles day-to-day state: shop inventories, visited flags, quest progress, party status
- Persists across BLD script invocations — changes in one building affect conditionals in another

**Layer 2: Story Properties (`fn1631_11AB`, segment `1631:11AB`)**
- Properties `0x1F` and `0x20` drive major story milestones
- Called from `fn1AE8_000C` (combat narrative handler) during encounter resolution
- Stores state in the per-story-slot structure `Eq_107947` (0x7D bytes each, array `aC744[]`)
- Key fields: `b0057` (citadel attack state 0→1→2), `b0055`/`b0056` (multi-step counters)

**Layer 3: BLD Flag System**
- Flag `bD450` (at `0xD450`): training complete marker. Set by `fn1CD3_0004` case `0x19` (FLAG_D450)
- Flag `bD451` (at `0xD451`): milestone marker. Set by `fn1CD3_0004` case `0x1A` (FLAG_D451)
- Checked by opcodes `0xEB` (CHECK_FLAG_EB → checks `bD451`) and `0xEC` (CHECK_FLAG_EC → checks `bD450`)

### 17.2 BLD Script Interpreter Architecture

The .BLD file system is a **four-layer interpreter**:

```
Layer 1: fn0FDC_0008 (0FDC:0008)
  Entry point. Loads BLD data by index, calls fn0FDC_1D30 to prepare buffer.

Layer 2: fn0FDC_01C0 (0FDC:01C0)
  Bytecode interpreter. Handles opcodes 0xE4-0xFF (see §17.3).
  Bytes 0x00-0x7F are transparent (cipher text passes through).
  Bytes 0x80-0xC3 enter switch but match no cases (structural markers/no-ops).

Layer 3: fn1CD3_0004 (1CD3:0004)
  Room/building interaction dispatcher. 47-case switch (cases 0x01-0x2F).
  Handles: building entry/exit, shop buy/sell, combat, healing, flags, party.

Layer 4: fn1E56_03F5 (1E56:03F5)
  Text renderer. Formats cipher-encoded text with word-wrapping, margins.
  Special chars: 0x0D=CR, 0x02/0x06=soft break, 0x20=space, 0x09=indent.
```

### 17.3 BLD Opcode Dispatch (fn0FDC_01C0)

Opcodes 0xE4-0xFF are handled in a switch at `UNBTECH_0FDC.c:197-535`:

| Opcode | Reko Case | Name | Operand | Description |
|--------|-----------|------|---------|-------------|
| `0xE4` | `~0x1B` | WRITE_CHAR | 1 byte | Read byte, write as character via `fn0800_19BF` |
| `0xE5` | `~0x1A` | ADD_CREDITS | 2 bytes LE | Add signed value to `tD370` (C-Bills) |
| `0xE6` | `~0x19` | SET_CURSOR_XY | 4 bytes LE | Set cursor X (`A44B`) and Y (`A44D`) |
| `0xE7` | `65511` | CMP_CURSOR_X | 2 bytes LE | Compare with `A44B`. If NOT equal, skip next opcode |
| `0xE8` | `~0x17` | RNG_CHECK | 1 byte | If `(RNG() & operand) == 0`, skip next opcode |
| `0xE9` | `~0x16` | CALL_ROOM_HANDLER | 1 byte | Call `fn11B8_0D58(operand)` |
| `0xEA` | `~0x15` | COND_STATE_ACTION | 2 bytes (cond+action) | If `w3938==0`, call `fn0800_48B7(cond, action)` |
| `0xEB` | `65515` | CHECK_FLAG_EB | 0 bytes | Skip if `bD451 == 0` |
| `0xEC` | `65516` | CHECK_FLAG_EC | 0 bytes | Skip if `bD450 == 0` |
| `0xED` | `~0x12` | UNIT_CHECK_LOOP | 4 bytes (idx, thresh, LE target) | Loop 8 unit slots (stride `0x11`); match if `C618[slot·0x11+idx] ≥ thresh` (record `+4+idx`: 5→Tech, 6→Medical). Match → jump target, else continue. Thresholds ≥244 = NOP. See `formats/bld-bytecode.md` + §17.11j |
| `0xEE` | `~0x11` | SPEND_CREDITS | 2 bytes LE | Deduct from `tD370` (with zero-floor) |
| `0xEF` | `~0x10` | CHECK_CREDITS | 2 bytes LE | Skip if insufficient funds |
| `0xF0` | `~0x0F` | SET_TEXT_MARGINS | 2 bytes | Set left/right text margins |
| `0xF1` | `~0x0E` | ADD_TO_STATE | 2 bytes | `D30C[index] += value` |
| `0xF2` | `~0x0D` | ROOM_DESCRIPTION | 0 bytes | Call `fn1F3D_086A` to render room description |
| `0xF3` | `~0x0C` | SHOP_INTERACTION | 1 byte | Index into `D30C` state array, indirect dispatch |
| `0xF4` | `~0x0B` | SET_STATE_VALUE | 2 bytes | `D30C[index] = value` |
| `0xF5` | `~0x0A` | SHOP_DISPATCH | 1 byte | Call `fn1CD3_0004(operand)` — dispatches to room handler |
| `0xF6` | `~0x09` | CHECK_CONDITION | 0 bytes | Call `fn0800_1A13(1)`, skip if returns 0 |
| `0xF7` | `~0x08` | STATE_COND_CHECK | 1 byte | Skip if `D30C[index] == 0` |
| `0xF8` | `~0x07` | JUMP_FORWARD | 2 bytes LE | Read 2-byte WORD → absolute jump target (new IP = word value) |
| `0xF9` | `~0x06` | JUMP_INDEXED | 1 byte | Read 1 byte menuId, calls `fn1E56_0B5E(menuId)` → returns index, reads WORD at `base + _ip + index*2` as new IP (absolute jump table) |
| `0xFA` | `~0x05` | DRAW_SPRITE | 1 byte | Draw sprite via `fn1E56_0004(operand)` |
| `0xFB` | `~0x04` | ADVANCE_INPUT | 0 bytes | Wait for key via `fn1F3D_0259` |
| `0xFC` | `~0x03` | RENDER_TEXT | N bytes | Display cipher text via `fn1E56_03F5`. Advance past string |
| `0xFD` | `~0x02` | SET_FONT2 | 0 bytes | Call `fn1E56_0388` for font/display params |
| `0xFE` | `~0x01` | SET_FONT | 1 byte | Call `fn1E56_0281(operand)` to set font |
| `0xFF` | `~0x00` | EXIT | 0 bytes | Set exit flag, stop interpreter |

### 17.4 fn1CD3_0004 Case Dispatch (47 Cases, 0x01-0x2F)

**File:** `UNBTECH.reko/UNBTECH_1CD3.c` (segment `1CD3:0004`)

Called from BLD opcode `0xF5` and various game functions. All 47 cases present.

| Case | Name | Description |
|------|------|-------------|
| `0x01` | ENTER_BUILDING | Load building BLD data, init viewport, check `bD30E` for variants |
| `0x02` | SHOW_GREETING | Display entry text via `fn1E56_03F5`. Checks `bC724` for variant |
| `0x03` | EXIT_BUILDING | Clear building state, restore world coordinates, reset NPCs |
| `0x04` | SHOW_SHOP_ITEMS | Render 3 shop item slots (loop 0-2). Reads `C618[n]`, computes price, calls `fn207F_3BB6`/`fn1F3D_00D5` |
| `0x05` | BUY_ITEM_SINGLE | Single item: `C618[bD314] += 1`, `tD370 -= C618[bD314] * 125 + 75` |
| `0x06` | SHOW_PLAYER_ITEMS | Display player's owned items (`aD374[n] != 0`) for potential sale |
| `0x07` | BUY_ITEM_BULK | Bulk buy at 1 cr/unit: `fn1543_0CDE`→qty, `aD374[sel] += qty`, `tD370 -= qty` |
| `0x08` | SELL_ITEM_BULK | Bulk sell at 1 cr/unit: `fn1543_0CDE`→qty, `aD374[sel] -= qty`, `tD370 += qty` |
| `0x09` | REPAIR_ARMOR (was mislabeled HOSPITAL_HEAL) | Binary `1CD3:09C7`: price check → deduct, `fn1631_1FDF` cost display, restore `C622` to `4DDB` max via `fn0FDC_13DE`. People-healing is case `0x17` → `fn1431:000A` (see §17.11b) |
| `0x0A` | SHOW_CREDITS | Display `tD370/tD372` formatted via `fn207F_3BD2` |
| `0x0B` | BUY_WITH_UNIT_SEL | Purchase + unit selection. Cost from table 0x4F44/0x4F46. Calls `fn1631_1FDF` + `fn0FDC_15E6` |
| `0x0C` | CLOSE_ACTION | Close current shop/action via `fn0FDC_17B9` |
| `0x0D` | EQUIPMENT_MENU | Equipment selection from unit slots. Lists items at `0xC61C[stride 0x11]`, calls `fn1E56_03F5` + `fn1E56_0B5E` for menu. Stores selected unit index in `bD31A` |
| `0x0E` | COUNT_UNIT_SLOTS | Count occupied units (8 slots `bC614[]`, stride 0x11). Result in `bD31A` |
| `0x0F` | EQUIP_SLOT5 | Equip item type 5: 500cr debit, `C618[5][bD31A]++`, set `bC623[].bit0`. Calls `fn1631_1FDF` |
| `0x10` | CHECK_EQUIP_SLOT5 | Query: `bD31B = bC623[bD31A] & 0x01` (slot 5 flag) |
| `0x11` | COUNT_STORY_SLOTS | Count occupied story/mech slots (4 slots `bC724[]`, stride 0x7D). Result in `bD31C` |
| `0x12` | DISPATCH_11B8_0002 | Render via `fn11B8_0002` (viewport/tile display) |
| `0x13` | DISPATCH_11B8_080A | Render overlay via `fn11B8_080A` (building name/text) |
| `0x14` | DISPATCH_11B8_0925 | Render text overlay via `fn11B8_0925` |
| `0x15` | EQUIP_SLOT6 | Equip item type 6: 500cr debit, `C618[6][bD31A]++`, set `bC623[].bit1`. Calls `fn1631_1FDF` |
| `0x16` | CHECK_EQUIP_SLOT6 | Query: `bD31B = bC623[bD31A] & 0x02` (slot 6 flag) |
| `0x17` | EQUIP_CONSISTENCY | Verify equip state vs expected: compare `aC615[n]*10` vs `bC623[n]`. Sets `bD325=1` on mismatch |
| `0x18` | GARAGE_SERVICE | Paid service dispatch. Reads cost from table 0x4F6E indexed by `bD326`. Debits credits, calls `fn1431_000A` for service. Insufficient funds: shows message + grants 25cr pity |
| `0x19` | FLAG_D450 | **Set `bD450 = 1`** — training complete marker |
| `0x1A` | FLAG_D451 | **Set `bD451 = 1`** — milestone marker |
| `0x1B` | GOTO_2E_SHARED | Shared path with case 0x2E |
| `0x1C` | CLEAR_ALL_SLOTS | Clear 4 story/mech slots: save `bC724[n]` to temp, set to 0xFF, reset `bC620[n]=8` |
| `0x1D` | COUNT_UPPERCASE | Count story slots with IDs in 'A'-'Z' range (0x41-0x5A). Result in `bD31C` |
| `0x1E` | DISPATCH_11B8_104E | Render via `fn11B8_104E` |
| `0x1F` | READ_SLOT_FLAG | Copy `bC620[1][bD31A]` → `bD32B` |
| `0x20` | COMPLEX_EQUIP | Multi-step equip interaction: reads item type from `bC620[1][bD31A]`, validates vs table 0x4DDB, handles bulk buy loops with `fn0800_1A13`, calls `fn1631_1FDF` |
| `0x21` | DISPATCH_0FDC_1C9B | Call `fn0FDC_1C9B` |
| `0x22` | DISPATCH_0FDC_1A26 | Call `fn0FDC_1A26` |
| `0x23` | ARENA/ROOM combat setup (was mislabeled NEW_GAME_INIT — verified via jump table file `0x19892`) | Binary `1CD3:1062`: cursor/stream config, `11B8_137F`, `fn0FDC_0629(8)` (arena bout), clear loop, `D334=1`, `D32F`-gated tail. New-game init is `fn0800_4DC7` (direct code path). |
| `0x24` | READ_UNIT_SLOT | Read `bC614[bD331].b0000` → display via item name lookup |
| `0x25` | CLEAR_UNIT_SLOT | Clear `w014A=0`, set `bC614[0]=0xFF` (empty first slot) |
| `0x26` | READ_D456 | Read `bD456`, look up item name in `a01CC/a01CA` tables, render via `fn1E56_03F5` |
| `0x27` | TRIGGER_ACTION | Call `fn1467_0002(0x01)` — mode trigger |
| `0x28` | DISPATCH_11B8_152F | Call `fn11B8_152F`, optionally set `bD334=1` |
| `0x29` | COMBAT_HEAL | Apply RNG damage/healing to party: `heal = (RNG&1 + 6) * unit_max`, capped at current damage |
| `0x2A` | SAVE_POSITIONS | Stock init (first COMSTAR visit): loop 8×, seed StockEntry from cursor coords, bD398=0x77, bD399=i |
| `0x2B` | RESTORE_POSITIONS | Stock refresh (subsequent): load StockEntry[0] from source tables via DS:0x53CA→seg, bD398=0x70, bD399=0xFF |
| `0x2C` | DISPATCH_11B8_1762 | Position/state management via `fn11B8_1762` |
| `0x2D` | COMBAT_ENCOUNTER | **Combat transition**: set `w4FBC = 1` (narrow left panel 80px→4px), setup viewport, template load, border draw |
| `0x2E` | RESTORE_SLOTS | Restore 4 story slots from temporary backup, update `bD55E`, call `fn1467_0002` |
| `0x2F` | DECREMENT_STATE | If `bC623 > 5`, decrement by 4 |

### 17.5 fn1631_11AB Story Property Handler (segment `1631:11AB`)

**File:** `UNBTECH.reko/UNBTECH_1631.c:1019-1317`

Called with `wArg04` (story slot index) and `wArg06` (property ID, 0x1C-0x23).

**Property byte = the struct byte at offset `wArg06`** (`struct[slot] + prop`); bit 7 (`0x80`) is set
when the property is first armed. Re-verified against the decompilation 2026-09-28 (roadmap B4).

**Property → field map** (the "t0024"/"t0025" fields are the per-slot skill/inventory arrays at struct
offsets `0x24`/`0x25`; the sub-base selects the item/skill sub-array):

| Prop | Field | Sub-base | Note |
|------|-------|----------|------|
| `0x1C` | `0x24` (`t0024`) | `0x33` | nibble mgmt (`& 0xF0`) |
| `0x1D` | — | `0x3A` | |
| `0x1E` | `0x24` (`t0024`) | `0x4F` | nibble mgmt (`& 0x0F`) |
| `0x1F` | — | — | **story flags** (see below) |
| `0x20` | — | — | **multi-step counters** (see below) |
| `0x21` | `0x25` (`t0025`) | `0x41` | nibble mgmt (`& 0xF0`) |
| `0x22` | — | `0x48` | |
| `0x23` | `0x25` (`t0025`) | `0x51` | nibble mgmt (`& 0x0F`) |

**Property 0x1F (Citadel Attack):**
- Subcode from `fn0800_19F3` (RNG-based):
  - `1`: Checks `b0058[wArg04]`. If non-zero → set to `0xFF` (latch/one-shot marker)
  - `2` or `5`: Increments `b0057[wArg04]` up to 2 (citadel attack state)
  - `3`: Clears story byte at `0xC79B + offset`
  - `4`: Calls `fn1631_163E` for counter/sequence operation
  - `6`: Same as subcode 1 (b0058 latch)

**Property 0x20 (Multi-Step Counter):**
- Calls `fn0800_19F3` twice for RNG-sampled subcode
- If first result ≤ 3: increments `b0056[wArg04]` (capped at 2)
- If second result ≤ 3: increments `b0055[wArg04]` (capped at 3)
- When cap reached: clears `b0000[wArg04]`, sets `wE484 = 1` (story action complete flag)
- Otherwise: calls `fn1631_163E` to decrement remaining step counter

### 17.6 Complete Story Arc: Phase by Phase

#### Phase 1: New Game Init
- **Call**: `fn0800_4DC7` (direct code path — **not** `fn1CD3_0004` case `0x23`;
  the old attribution was wrong: case `0x23` is arena/room combat setup,
  `1CD3:1062`. No F5 case performs new-game init.)
- **Code**: `UNBTECH_1CD3.c:156-259`
- Clears all game state, loads character templates from template table
- Sets initial party (Jason Youngblood in slot 0, potentially 0-3 others)
- Positions player at Training Center: `A44B=0x0C3C`, `A44D=0xC04F` (MAP1: Training Center/Citadel)
- `b0057 = 0` (training mode)
- `bD330 = 0` (no random encounters during training — citadel is isolated)

#### Phase 2: Training (TRAINING.BLD / MAP1)
- Player on MAP1, enters TRAINING.BLD by pressing SPACE at designated tile
- `fn0FDC_0008(0)` called with BLD index 0 (TRAINING.BLD)
- 8 training missions via dialogue choices and combat encounters:
  1. Familiarization — basic movement
  2. Rubble pickup — object interaction
  3. Weapons practice — target shooting
  4. Reactionary combat — enemy response
  5. Remote-controlled Locust duel
  6. Multi-Mech engagement
  7. Assessment — instructor evaluation
  8. **Final exam** — full combat scenario
- Each completion modifies state array at `D30C` via opcodes `0xF1`/`0xF4`
- **Training completion**: BLD script calls `0xF5` with dispatch → `fn1CD3_0004` case `0x19` (FLAG_D450) → sets `bD450 = 1`
- Rick Atlas event in LOUNGE.BLD gives Jason the mysterious device

#### Phase 3: Citadel Attack (triggered from TRAINING.BLD)
- After `bD450 = 1`, the TRAINING.BLD script transitions from training to attack narrative
- At TRAINING.BLD offset ~6018: opcode `0xF5` with operand `0xC3` (195) dispatches to `fn1CD3_0004(195)`
- The "kill-you line" at segment `3EDB:32F0`: *"They're trying to actually kill you! This is no training mission!"*
- During the encounter: `fn1AE8_000C` (combat narrative) calls `fn1631_11AB` with **property 0x1F**
- `b0057` incremented from 0→1→2 through successive property 0x1F subcode 2/5 calls
- **Side effects**:
  - MAP1 tile properties updated to point to MAP11 (Destroyed Training Center)
  - `bD330` set to `0x1F` (encounter probability 1/32 per frame — world becomes dangerous)
  - `bD310` gates world map interactions (enabled after attack)
  - Story state penalty `+2` to-hit modifier activated in combat (checked at `C79B`)

#### Phase 4: Post-Attack Free-Roam (World Map)
- Player now on the world map (MAP15, 32×24 tile grid)
- Encounter check runs **every frame**: `RNG & 0x1F == 0` → `fn183B_000A`
- Walking triggers random encounters irrespective of terrain (flat 1/32 probability)
- City tiles on map are gated by plot: most are locked during training, unlocked after attack
- SPACE at a city tile → action menu at segment `0D27:0044`:
  - Option 1: Enter building → `fn0FDC_0008(bld_index)`
  - Option 2: Leave city
  - Option 3: Fight → sets `w4FBA = 2` (combat mode)
  - Option 4: Rest

#### Phase 5: Building/Script Trigger Map

**Decoded (2026-09-28) — see [`../formats/map-bld-triggers.md`](../formats/map-bld-triggers.md).**
Each local-map building is tied to a BLD file. The chain is:

1. **Building positions**: word tables `[0x53CA]:0x4564` = X and `[0x53CC]:17814` = Y (live: segment
   `0x2A0F`), packed as the map cursor — `tile = (word & 0x7F) >> 1`.
2. **Slot → building index**: standing on a building's tile triggers the Yes/No prompt
   `fn0800_1A13(1)` ("Will you enter the <name>?"); on **Yes** `fn0FDC_0008(slot)` maps the slot via
   the 16-byte table at **`[0x5460]:0x4602`** (= segment `0x2A0F`) to a **building index**.
3. **Index → BLD**: the MTP header's per-map **building-name list** names the BLD.

*(The earlier note that this was keyed off the tile-property table `0x32C6` was wrong — `0x32C6` is
terrain/passability; the trigger uses the building-position tables above.)*

| Map | BLD File | Trigger | Story Purpose |
|-----|----------|---------|---------------|
| MAP1/11 | TRAINING | Default start + post-attack | Training missions + citadel attack |
| MAP1/11 | CITADEL | `b0057 ≥ 1` | Post-attack citadel exploration |
| MAP2 | BARRACKS | At barracks tile | Recruit NPCs, interact with cadets |
| MAP2 | BARRACK2 | At secondary barracks | Additional soldier interactions |
| MAP2 | LOUNGE | At lounge tile | Rick gives device, mentions Starport |
| start map (+ other cities) | COMSTAR | Entrance tile `(51,10)` on start map — road east (y=12), then north | Banking, stock market (DefHes, NasDiv, BakPhar) |
| MAP2 | PARTY | At party house | Rex rescues Jason, gives Jeremiah's box |
| MAP2 | MAYOR | At mayor's house | Read newspaper, view holodisk, escape mayor |
| MAP2 | JAIL | At jail, if state[?] ≥ threshold | Rescue agent, acquire Stinger from impound |
| MAP2 | WEAPON/WEAPON2 | At weapon shop | Buy infantry weapons (Kuritan collaborator) |
| MAP2 | ARMOR | At armor shop | Buy armor (FlakVest, FlakSuit, etc.) |
| MAP2 | CLOTHES | At clothes shop | Buy civilian clothes |
| MAP2 | HOSPITAL | At hospital | Healing services |
| MAP2 | GARAGE | At garage | Vehicle services |
| MAP2 | REPAIR | At repair center | Recruit tech, modify Mechs |
| MAP2 | ARENA | At arena | Mech combat arena |
| MAP2 | ENTRANCE | At city entrance | Story transition point |
| MAP2 | THEATER | At theater | Entertainment/plot |
| MAP3-10 | FINDIT | At specific world map tile | Search for cache clues |
| MAP14 (Cave) | HUT | At Tellhim's hut location | Face holographic tests, repair holodisk |
| MAP14 (Cave) | FROB | At puzzle entrance | Tellhim's gauntlet: answer questions about Jeremiah |
| MAP14 (Cave) | INSTRUCT | At cache entrance | Jeremiah's color-coded lock instructions |
| MAP14 (Cave) | VIEWDISK | At cache interior | Play Jeremiah's holodisk message |
| Endgame | WINSCENE | At cache completion | Hyperpulse Generator → Katrina → Crescent Hawks |
| Endgame | ENDMECH | At ending | Endgame image and credits |

#### Phase 6: Story Property 0x20 Multi-Step Counter
- After citadel attack, property `0x20` triggers during encounters to track multi-step progress:
  - `b0055` incremented (cap 3): tracking major steps
  - `b0056` incremented (cap 2): tracking minor steps
- When counters reach cap: `b0000` cleared, `wE484 = 1` signals story action complete
- This gates which conditional branches unlock in BLD scripts:
  - BLD scripts check state array values via opcode `0xF7` (STATE_COND_CHECK)
  - Server room access, jailbreak readiness, cache location clues

#### Phase 7: Endgame
- Cache entry requires: holodisk repaired (HUT.BLD) + password learned (HUT sets `D30C[0x36]`, tested once at ENTRANCE.BLD stream `0x239`: `F7 36 → 0x02BA` success render) + three code flags `D30C[0x30/0x31/0x32]` (FROB quiz + VIEWDISK `F4 32 01`) + cache location known (FINDIT.BLD). Verified at the decrypted-byte level 2026-10-13 (the old wording credited the password to FROB — the door-tested flag is HUT's `0x36`; FROB owns the `0x30/0x31` quiz flags). `D30C[0x35]` (set alongside `0x36` in HUT) has **no `F7 35` consumer in any BLD** — orphan flag, purpose open.
- INSTRUCT.BLD at cave entrance: color-coded lock puzzle (Jeremiah's note) — pure dialogue (`F2/FB/FD/FF` only), no checks; the R/B/Y/no-reuse rules are narrative, the mechanism is the flags above.
- Inside cache: VIEWDISK.BLD shows Jeremiah's holodisk message
- WINSCENE.BLD (type `c0 da`): activates Hyperpulse Generator → signals Katrina Steiner
- DropShip arrives, Katrina offers commission as Lyran Lieutenant
- Jason declines to search for his father
- The Crescent Hawks are formed as an independent unit
- ENDMECH.CMP renders the endgame image: *"Press any key to end the game"*

- Inside cache: VIEWDISK.BLD shows Jeremiah's holodisk message
#### Cache interior & Map Room (S12 — closed 2026-11-05, static; BLD + EXE strings + Reko)

All cache-interior mechanics live in segment-`135D` position handlers (called
from `fn0800_1C12`), driven by EXE strings at file `0x3C2FD–0x3C60A`
(`DS:0x2068–0x2457`, base file `0x3A1B0`) — no BLD opcodes involved (INSTRUCT
is pure text; the "7 touch-panels" are floor tiles, and the planet names
appear **nowhere** in the binary — the check is tile indices, the manual's
page 14 is the key, i.e. the copy protection is structural):

- **Terminals (33 = 11 doors × 3 colors)** — `fn135D_03AA` (from `0800:1C12`):
  scans 33 slot entries, position-matches cursor against tables `[0x21F0]`
  (x) / `[0x21CE]+3` (y); per-terminal color+number prompt assembled as
  `0x2187` (*"Security Terminal."*) + far-ptr color name (`[0x2234]` table:
  RED/BLUE/YELLOW) + `0x21B2`/`number`/`0x21B9`
  (*"Do you want to imprint [color] code [N] on your code key?"*); Yes
  (`0800:1A13`) imprints into the key-card triple `D347/D348/D349`
  (one per color — matches INSTRUCT's one-code-per-color rule); used
  terminals refuse with `0x215D` (*"You've already used this terminal's
  code."*, flag `[0x45DE]`).
- **Power** — `fn135D_02D2`: the `(0x4E, 0x0C–0x11)` switch sets `D34C=1`
  (*"You have turned on the power to the Hyperpulse Generator."* `0x2113`).
- **Doors** — `fn135D_0AB6`: 12 position entries (WT says eleven — door index
  `0x0B` is skipped in-code; discrepancy noted, not resolved), tables
  `[0x2486]`(y)/`[0x247A]`(x)/`[0x2492/9E/AA]`(−1 triples); compares the
  key-card `D347/D348/D349` per color, printing `Incorrect RED/BLUE/YELLOW`
  (`0x242C/0x2441/0x2457`) for each wrong one, else the door opens.
- **Map-room descent** — `fn135D_055A` at `(0x48,0x38)`: `0x22E8`
  (*"You peer down the hole…"*) + `0x2328` (*"You climb down the ladder…"*)
  (or `0x22C7` *"You already have the WHITE code."* if `D34A==1`), cursor
  teleport, ICN/MTP swap (`1F3D:063B/049Dh`, `w4FBC=1` narrow), floor-tile
  save (`0x101D→0x4614`, `0x300` entries), `D34E=1`, panel-state init
  (`[0x664]`, 12 bytes `0x90–0x9B`); ladder-up restore in `fn135D_079C`
  (`0x2367`, `D34E=0`). `(0x7C,0x04)` loads BLD `0x18` + `D34D=1`.
- **Touch-panels** — `fn135D_0913` (from `0800:1CF1`): bumping a floor tile
  flips its low bit (`inc; xor 1; dec`) + blip (`0800:19BF(0x0F)`).
- **7-check** — `fn135D_0980` (from `0800:1D07`) over the 7-WORD table
  `[0x241E]`: success → `0x23B2` (*"Password accepted. WHITE code
  installed. You can trigger the HyperPulse Generator now."*) + **`D34A=1`
  (the WHITE code)**; fail → `0x2409` (*"Incorrect password."*) + tile-reset
  loop. **Polarity reading flagged VERIFY-live**: as-read, loop 1 fails on
  any SET bit among the 7 (i.e. all-7-clear passes), which contradicts WT's
  "turn on the seven" — table contents + floor init bits unknown statically;
  recipe: set panels per manual, dump floor bits + outcome.
- **West-wall computer** — `fn135D_04AB`: `D34C==0` → `0x2240` (*"power…
  turned off"*); `D34A!=1` → `0x2275` (*"Incorrect WHITE code."*);
  `D34D==0` → `0x228B` (*"want to radio Katrina, but you haven't found the
  cache"*); else loads **BLD `0x19`** (transmitter chain → Katrina →
  WINSCENE) + flags. BLD `0x18`/`0x19` file identities OPEN (live: watch
  which BLD loads at the map-room/west-computer).
- WINSCENE.BLD (type `c0 da`): activates Hyperpulse Generator → signals Katrina Steiner
- DropShip arrives, Katrina offers commission as Lyran Lieutenant
- Jason declines to search for his father
- The Crescent Hawks are formed as an independent unit
- ENDMECH.CMP renders the endgame image: *"Press any key to end the game"*

### 17.7 Story State Data Structure (Eq_107947)

Per-story-slot structure at `aC744[]` (stride 0x7D = 125 bytes), segment pointed by `DS:0x558E`:

| Offset | Field | Purpose |
|--------|-------|---------|
| `0x00` | `b0000` | Generic per-story status byte (cleared by property 0x20 completion) |
| `0x04`-`0x05` | `b0004`/`b0005` | Nibble-packed flag fields for inventory/equipment |
| `0x06` | `b0006` | Timing/counter nibble |
| `0x24` | Skill property byte | Skill tracking (popcount of low 3 bits → 0-3) |
| `0x25` | Skill property byte | Skill tracking (popcount of low 3 bits → 0-3) |
| `0x33`-`0x55` | Target preference table | Encoded AI target preferences |
| `0x55` | `b0055` | Counter for property 0x20 major steps (capped at 3) |
| `0x56` | `b0056` | Counter for property 0x20 minor steps (capped at 2) |
| `0x57` | `b0057` | Story state byte: 0=Training, 1=Citadel Attacked, 2=Post-Attack |
| `0x58` | `b0058` | One-shot latch/marker for property 0x1F |

### 17.8 How the Map-Event System Drives the Story

The game is NOT driven by a linear script or trigger table. The story is **emergent** from:

1. **World map state controls availability**: `bD330` (encounter probability), `bD310` (world map active), `bD346` (star map mode) gate what happens
2. **Citadel attack state gates the world**: `b0057 = 0` means training mode (locked city tiles, no encounters); `b0057 ≥ 1` opens the world
3. **BLD scripts contain their own logic**: Each building's script has conditionals (`0xEB`/`0xEC`/`0xF7`) that check flags and state array values, producing different dialogue/outcomes based on story progress
4. **State array persists across visits**: Modifications through `0xF1`/`0xF4` in one building affect condition checks in another — creating the illusion of a persistent world
5. **Combat encounters advance plot**: `fn1AE8_000C` during combat calls `fn1631_11AB` for story property updates, tying narrative progression to combat resolution

### 17.9 The citadel attack chain in detail (TRAINING.BLD offset ~5900-6200)

At the point of attack in TRAINING.BLD:
```
[... training complete ...]
→ Third-person narrative: "Kuritan Mechs have made a lightning raid on Pacifica"
→ "They have destroyed the citadel"
→ opcode 0xF5 operand 0xC3: dispatches combat encounter (the Jenner attack)
→ "One of the Kuritan Jenner tries to crush you in your Mech's cockpit"
→ "but you barely escape before the deadly blow can cut you down"
→ Third-person: "You manage to hide in the trees"
→ "Some of the remnant of the Lyran Guard engage the Mechs"
→ Third-person: "Your comrades are wiped out"
→ opcode 0xF5: SHOP_DISPATCH to case handler → triggers property 0x1F → b0057++
→ Encounter probability enabled globally
```

> **Animation note (C11b):** the *"Jenner tries to crush you in your cockpit"* beat is shown as an
> **`O*.ANM` animation** (a mech **stomping** a downed pilot) in the left panel. It plays through the
> BLD/location-graphics ANM path (`fn135D`), which is why it appears when the training-center encounter
> ends (the player escaping the wreck) and why the combat code has no direct xref. ANMs are a **generic
> animation resource** reused across story and combat contexts — this is just one example. See
> [`../combat-system.md`](../combat-system.md) §28.1.

### 17.10 Mech/Unit Inventory System

The game uses a **two-tier architecture** for tracking the player's owned units (Mechs and infantry): story slots represent characters, and unit slots represent the actual combat units those characters pilot/operate.

#### Architecture Overview

```
Story Slots (aC724, 4×125 bytes)         Unit Slots (aC614, 8×17 bytes)
┌──────────────────────┐                ┌──────────────────────┐
│ Slot 0: Jason        │───b0079───────►│ Slot 0: Primary Mech │
│       b0079 = prim.  │                │  b0000 = type ID     │
│       b007A = sec.   │───b007A───────►│ Slot 4: Secondary    │
├──────────────────────┤                ├──────────────────────┤
│ Slot 1: Rex          │───b0079───────►│ Slot 1: Primary Mech │
│       b0079 = prim.  │                │  b0000 = type ID     │
│       b007A = sec.   │───b007A───────►│ Slot 5: Secondary    │
├──────────────────────┤                ├──────────────────────┤
│ Slot 2: Character 2  │───b0079───────►│ Slot 2: Primary Mech │
│       b0079 = prim.  │                │                       │
│       b007A = sec.   │───b007A───────►│ Slot 6: Secondary    │
├──────────────────────┤                ├──────────────────────┤
│ Slot 3: Character 3  │───b0079───────►│ Slot 3: Primary Mech │
│       b0079 = prim.  │                │                       │
│       b007A = sec.   │───b007A───────►│ Slot 7: Secondary    │
└──────────────────────┘                └──────────────────────┘

Mech Data (125 bytes each, in story slot array at segment 0x3092)
┌────────────────────────────────────────────────────┐
│ Story slots 0-3 (player) → combat units 0-3        │
│  Ammo at C74B + id×125 (= C724 + id×125 + 0x27)    │
├────────────────────────────────────────────────────┤
│ Story slots 4-7 (enemy templates) → combat 12-15    │
│  Ammo at C363 + id×125 (= C724 + (id-8)×125 + 0x27)│
├────────────────────────────────────────────────────┤
│ Enemies 4-11 use burst counter at C5D4 + id×17      │
│ (not full mech structs)                              │
└────────────────────────────────────────────────────┘
```

#### Data Structures

**Story Slot (`aC724[]`, 4 entries, stride 125/0x7D)**

Segment structure reference: `Eq_49571` (UNBTECH.h:54256), `Eq_107547` (UNBTECH.h:685747)

| Offset | Field | Purpose |
|--------|-------|---------|
| `+0x00` | `b0000` | Occupancy (`0xFF` = empty, no character in slot) |
| `+0x1F` | `b001F` | Story state / property gate |
| `+0x20` | `b0020` | Story state / property gate |
| `+0x24` | `b0024` | Nibble-packed skill/flag field (popcount → skill mod 0-3) |
| `+0x25` | `b0025` | Nibble-packed skill/flag field (popcount → skill mod 0-3) |
| `+0x69` | `b0069` | Upper nibble comparison target for `b0024` |
| `+0x6A` | `b006A` | Upper nibble comparison target for `b0025` |
| `+0x75` | `b0075` | Encounter/combat state for character |
| `+0x76` | `b0076` | Encounter/combat state for character |
| **`+0x79`** | **`b0079`** | **Primary unit slot index** (`0xFF` = unassigned) |
| **`+0x7A`** | **`b007A`** | **Secondary unit slot index** (`0xFF` = unassigned) |

Fields `+0x79` and `+0x7A` link the story character to the unit slots they own. Each character can own up to **two** units — a primary (used in combat lance) and a secondary (garage/backup).

**Unit Slot (`aC614[]`, 8 entries, stride 17/0x11)**

Segment structure reference: `Eq_107577` (UNBTECH.h:685781), `Eq_106563` (UNBTECH.h:684673)

| Offset | Field | Purpose |
|--------|-------|---------|
| **`+0x00`** | **`b0000`** | **Unit type ID** (`0xFF` = empty slot). Determines mech/infantry template |
| `+0x01` | `b0001` | Generated attribute (from `fn0800_19DD`) |
| `+0x08` | `b0008` | Derived attribute (`= b0001 * 10`, modified if slot ≥ 4) |
| `+0x09` | `b0009` | Another generated attribute |
| **`+0x0C`** | **`b000C`** | **Linked story slot index** (`0x08` = unassigned). Back-reference to owner |
| `+0x0D` | `b000D` | Supplementary attribute |
| `+0x0E` | `b000E` | Supplementary attribute |
| `+0x0F` | `b000F` | Supplementary attribute |

The unit type ID at `+0x00` determines which mech/infantry template is used. Templates are defined at segment `0x54C8` in arrays `a01CC[]` and `a01CA[]` (name strings at `es_238->a01CC[0].w0000[ax_233]` and type strings at `es_238->a01CA[0].u5[ax_233]`).

#### Unit Slot Organization

Unit slots 0-3 serve as the **primary lance** (one per character). Slots 4-7 serve as **secondary/garage** slots (one backup per character). The layout is:

| Character (Story Slot) | Primary Unit Slot | Secondary Unit Slot |
|------------------------|------------------|-------------------|
| 0 (Jason) | 0 | 4 |
| 1 (Rex) | 1 | 5 |
| 2 | 2 | 6 |
| 3 | 3 | 7 |

This is not enforced by the code — the `b0079`/`b007A` fields can point to any slot — but this is the natural assignment when units are created.

#### Mech Data Pools

The actual mech state (armor, structure, ammo, components) is stored as **125-byte structs** within the story slot array `aC724[]` (segment `0x3092`). The ammo field is at offset `+0x27` within each 125-byte slot:

| Combat unit | Address formula | Story slot | Ammo at | Contents |
|-------------|-----------------|------------|---------|----------|
| 0-3 | `C74B + id × 125` | slots 0-3 | `C724 + id×125 + 0x27` | Player lance mechs |
| 4-11 | `C5D4 + id × 17` | (separate) | `C5D4 + id×17 + stage` | Enemy infantry (burst counter, 17B stride) |
| 12-15 | `C363 + id × 125` | slots 4-7 | `C724 + (id-8)×125 + 0x27` | Enemy mech templates |

The **same story slot array** (`aC724[0..7]`) holds both player and enemy mech data. Combat units 0-3 access story slots 0-3 directly via `C74B`. Combat units 12-15 access story slots 4-7 via `C363`, using a shifted base to compensate for the index remapping (`C363 = C724 - 8×125 + 0x27`). There are no separate "pools" — it's one contiguous array with two access patterns.

The mech data format (per `InceptionTools/Data/SaveGame.cs`): Name(15), Tonnage, CurrentArmour[11], CurrentStructure[8], CurrentActuators[4], EngineHeatSinks, CurrentAmmo[10], WalkMove, JumpMove, CritSlotData[47], MaxArmour[11], MaxStructure[8], MaxActuators[4], MaxAmmo[10], Unknown[4].

#### Combat Slot Mapping

The combat system uses a **different 24-slot array** that is populated from the story/unit system:

| Combat Slot | Source | Description |
|-------------|--------|-------------|
| 0-3 | Story primary units (aC724[0..3].b0079 → aC614[N]) | Player lance mechs |
| 4-11 | Generated enemies | Enemy mechs + infantry (8 slots) |
| 12-15 | Extended pool (garage/secondary) | Backup/garage mechs in combat |
| 16-23 | Unused/pool | Extended pool |

The ammo decrement logic reflects the remapping:
- Player units (combat slots 0-3, story slots 0-3): `DEC [0x2A02:C74B + unit_id × 125 + stage_counter]`
- Enemy mechs (combat slots 12-15, story slots 4-7): `DEC [0x2A02:C363 + unit_id × 125 + stage_counter]`
- Enemy infantry (combat slots 4-11): burst counter `INC [0x2A02:C5D4 + unit_id × 17]` capped at 4

#### Unit Creation and Assignment (`fn11B8_0D58`)

When a new unit is created (via BLD opcode `0xE9` CALL_ROOM_HANDLER → `fn11B8_0D58`):

1. Iterates unit slots 0-7 looking for an empty slot (`aC614[slot].b0000 == 0xFF`)
2. Assigns a new unit ID from incrementing counter `bD456`
3. Generates random attributes via `fn0800_19DD` (3 calls for b0001, b0005, b0007)
4. Derived attribute at offset +0x08 = `b0001 * 10` (halved if slot is 4+, i.e. secondary)
5. Initializes inventory bytes (`aC618[slot][0..6]`) with random bit values
6. Sets the linked-story-slot field (`aC614[slot].b000C`) to `0x08` (unassigned initially)
7. **Finds the first occupied story slot that has no unit assignment** (`aC724[story].b0079 == 0xFF`) and links them: `aC724[story].b0079 = unit_slot` and `aC614[unit].b000C = story_slot`

This means new units are automatically assigned to the first character without a primary unit.

#### REBUILD Mode (`fn1467_0002` with `wArg04 == 0`)

Called from `fn1CD3_0004` case `0x2E` (RESET_ROOM). Re-establishes all story→unit links:
1. For each occupied story slot, reads `b0079` and `b007A`
2. Sets the unit slot's `b000C` to point back to the story slot index
3. This ensures consistency after save/load or state transitions

When `wArg04 != 0` (CLEAR mode, case `0x27` TRIGGER_ACTION):
1. Sets all unit slot `b000C` fields to `0x08` (unassigned)
2. Sets all story slot `b0079` and `b007A` fields to `0xFF` (unassigned)
3. Effectively wipes all character→mech assignments for a fresh rebuild

#### Garage/Swap UI (`fn0FDC_15E6`)

This is the **mech bay/repair center UI** where the player can swap which mech is in which slot:

1. Collects all non-empty unit slots into a selection list (up to 8)
2. If 0 or 1 unit available: auto-selects (no UI needed)
3. If 2+ units: renders a scrollable list with unit names from `a01CC[]` template table
4. Player selects which unit slot to swap with the "incoming" type (passed as `wArg04`)
5. On selection: **exchanges unit type IDs** between the selected slot and the incoming type
6. If the selected unit was linked to a character (`b000C != 0x08`), clears old links
7. If incoming type was already owned by a character, updates the story slot's `b007A` (secondary) field
8. Returns the selected unit slot index

The `wArg04` parameter acts as both a filter and a swap source:
- If non-zero, `bC61F` is set to its value (filtering which type of unit to display)
- On swap, the selected unit's old type becomes the new "incoming" for continued swapping
- When the user exits (no swap made), the UI concludes and returns the current selection

#### Save File Layout

From `InceptionTools/Data/SaveGame.cs`, the save file stores:
- **8 infantry characters** (17 bytes each, offsets 0x01-0x88): party members 01-08
- **4 enemy infantry characters** (17 bytes each, offsets 0x89-0x110)
- **4 lance mechs** (125 bytes each, offsets 0x111-0x304): Lance01-Lance04
- **4 enemy mechs** (125 bytes each, offsets 0x305-0x4F8): EnemyMech01-EnemyMech04
- **Map visibility** (2048 bytes, offset 0x4F9)
- **Finance** (offset 0xD5D): C-Bills + 3 stock values
- **Flags** (offset 0xCF9): CitadelMissionFlag, etc.
- **Position** (offset 0xF45): PartyMapPositionX/Y

The 4 lance mechs (save offsets 0x111-0x288) load into story slots 0-3 (player characters). The 4 enemy mechs (save offsets 0x305-0x4F8) load into story slots 4-7 (enemy templates). Both are in the same `aC724[]` array at segment `0x3092`, stride 125. During combat, player mechs use story slots 0-3 via `C74B`, and enemy mechs use story slots 4-7 via `C363`. The save format does not persist secondary/garage mechs (unit slots 4-7 in `aC614[]`), suggesting those are transient and need to be re-acquired.

#### Key Design Insights

1. **Characters own mechs, not the reverse**: The story slot points to unit slots. A character can have 0, 1, or 2 units.
2. **Max player garage**: 8 unit slots total (4 characters × 2 each). No larger pool exists.
3. **Secondary mechs are a swap buffer**: The `fn0FDC_15E6` garage UI swaps type IDs between slots. Secondary slots (4-7) are essentially a holding area for mechs not currently in the primary lance.
4. **Single story slot array holds all mech data**: `aC724[0..7]` (segment `0x3092`, stride 125) stores both player (slots 0-3) and enemy template (slots 4-7) mech structs. Combat maps: units 0-3 → story slots 0-3 via `C74B`, units 12-15 → story slots 4-7 via `C363`. Enemy infantry (combat units 4-11) use a burst counter at `C5D4 + id×17` instead of full mech data.
5. **No mech bay building in code**: The REPAIR.BLD and GARAGE.BLD scripts call through to `fn0FDC_15E6` for mech swapping. There is no separate "mech storage" screen — the mech bay IS the unit slot selection UI.

### 17.11 Shop and Inventory System

The shop/purchase system routes through `fn1CD3_0004` dispatch cases 0x04-0x0C, called from BLD opcode 0xF5 (SHOP_DISPATCH).

#### Data Structures

```
struct Eq_80552 at segment 0x569E:
  C618[0..2]: 3 item type numbers currently displayed in shop window
  D314 (bD314): Selection cursor (0-2), selects which C618 slot
  D315 (bD315): Purchase success flag
  D316 (bD316): Discount/insurance flag for hospital
  D317 (bD317): Repair success flag
  D318 (bD318): Bulk quantity threshold (6 or 9, used in case 0x0B)
  D31A (bD31A): State variable (story slot index for unit operations)
  D370 (tD370): Credits low word (uint16)
  D372 (tD372): Credits high word (uint16)
  D374[]: Per-item-type player quantity array (uint32 stride 4)
  D376[]: Per-item-type player data array (uint16 stride 2)
```

**Per-unit equip slots (System B):** `C61D[slot]` = equip slot 5 (case 0x0F, 500 cr); `C61E[slot]` =
equip slot 6 (case 0x15, 500 cr); flag bits at `C624[slot]` (bit 0 = slot 5 populated, bit 1 = slot 6
populated). These are purchased upgrades tracking which equipment slots a unit has — **not** connected
to ammo bins or `aD374`.

#### Purchase Cases

**Case 0x05 — Single item buy (formula pricing)**
```
item_type = C618[bD314]
price = item_type * 125 + 75
if (tD372 >= 0 && (tD372 > 0 || price <= tD370)) {  // 32-bit credit check
    bD315 = 1
    C618[bD314] += 1        // increment "shop stock counter"? Or item type id slot?
    tD370 -= price
}
```
Line 384: `C618[bD314] += 1` — this increments the value in C618. If C618 stores item type numbers, incrementing would change the item type to the next one. This is unusual — might be a purchase count, or C618 might encode (type_id << N) | count.

**Case 0x07 — Bulk buy at 1 credit/unit**
```
quantity = fn1543_0CDE()  // digit input → uint32
if (quantity > tD370) quantity = tD370  // cap to credits
aD374[sel] += quantity    // player receives items
tD370 -= quantity          // player pays quantity credits
```

**Case 0x08 — Bulk sell at 1 credit/unit**
```
quantity = fn1543_0CDE()  // digit input → uint32
if (quantity > aD374[sel]) quantity = aD374[sel]  // cap to owned
aD374[sel] -= quantity     // player loses items
tD370 += quantity           // player receives quantity credits
```

#### fn1543_0CDE — Numeric Input Function

At segment `1543:0CDE`. Reads keypad input in a loop:
- Digits `'0'-'9'` (0x30-0x39): stored in an array at `es:0x0012` (max 7 digits)
- Backspace (0x08): deletes last digit from array
- Escape (0x1B): clears the entire array
- Enter (0x0D): exits input loop
- On exit: converts digit array to uint32 via `value = sum(digit[n] * 10^(n))`
- Returns 32-bit value in `ax` (low) / `dx` (high)

#### Price Sources by Case

| Case | Price Source | Unit Price |
|------|-------------|------------|
| 0x05 | `C618[bD314] * 125 + 75` | Variable by item type |
| 0x07 | User-entered value = quantity | 1 credit/unit |
| 0x08 | User-entered value = quantity | 1 credit/unit |
| 0x09 | Table at `ds:0x4F26/0x4F28` | Fixed per index |
| 0x0B | Table at `ds:0x4F44/0x4F46` | Fixed per index |

#### BLD Price Display Encoding

Prices in BLD narrative text use byte range `0xAF-0xBF` to encode numeric digits for display:
- `0xAF-0xB3`: encode values 40-44 (left column of numpad font)
- `0xB4-0xB8`: encode values 105-113 (right column, odd numbers)
- `0xBE`: 125, `0xBF`: 127
- Consecutive markers concatenate their rendered text (e.g., `[40][41]` = "4041")
- These are purely for DISPLAY in dialogue text; the actual purchase price uses formula/table

#### fn1631_1FDF — Repair/Heal Display Function

At segment `1631:1FDF`. Called from cases 0x09 and 0x0B after cost is checked. This is a UI display function only — it shows the repair/heal cost and current credits. The actual cost is pre-computed from tables before this function is called. Internally:
1. Sets up text rendering parameters
2. Renders cost header string
3. Calls `fn0800_28A2` (display helper, sets render mode to 0x0A/0x01)
4. Reads and displays credits (`tD370`/`tD372`)
5. Fills a 10-char buffer with spaces (formatting)
6. Returns

#### fn0FDC_13DE — Hospital/Unit Selection UI

At segment `0FDC:13DE`. Called from case 0x09 after cost is paid. Handles player unit selection for healing/repair:
1. Initializes 8 unit slot indices to 0xFFFF (invalid)
2. Iterates 8 unit slots (stride 0x11) checking `bC614[slot] == 0xFFFF` (non-empty)
3. Collects non-empty unit indices into a selection array
4. If only 1 unit: auto-selects it (writes to `bC621`/`bC622`)
5. If multiple: renders unit selection UI via `fn1E56_03F5`, reads choice from string table
6. Returns selected unit index

#### fn0FDC_15E6 — Garage/Swap Unit Selection UI

At segment `0FDC:15E6`. Called from case 0x0B for mech component purchase and from BLD scripts (GARAGE.BLD, REPAIR.BLD) for mech bay operations:
1. Collects all non-empty unit slots (0-7, stride 0x11)
2. Renders scrollable list of owned units
3. Allows player to select source and destination slots
4. Swaps unit type IDs between slots (effectively reassigning which mech is in which slot)
5. Acts as the mech bay interface — no separate "garage" screen exists

#### §17.11b Hospital people-heal — binary cases `0x17` + `0x18` (closed 2026-11-04, P2)

> Corrects the case table: `0x09` (`1CD3:09C7`) is **armour repair** (restores `C622`
> to the `4DDB` max, price from `w0178`/`w0168` → `fn1631_1FDF` display → `fn0FDC_13DE`
> swap) — not people-healing. People-healing is two dispatches: `0x17` = wounded scan
> (`1CD3:0CF8`, was mislabeled EQUIP_CONSISTENCY), `0x18` = price + heal (`1CD3:0D44`,
> was mislabeled GARAGE_SERVICE).

Flow: `0x17` clears `bD325`, scans 8 slots, sets `bD325=1` if any occupied slot has
`C623 ≠ 10×C615` (the wounded test). `0x18`: if `bD326==0`, free `fn1431:000A(0)`
(self-heal); else price `DS:0x4F6E[D326]` = 0/50/100/150/200/400/600/750 (Trainee…
Neurosurgeon), dword-check vs `D370/D372`, deduct, `fn1431:000A(D326)`; insufficient
funds → message + `D370 += 0x19` (purpose OPEN). Full mechanic (wound source, dice
table `DS:0x2601` at `caliber + 4·tier`, caps, entry paths, flags
`D325/D326/D335/D450/D451`): [`combat-system.md` §23.7/§23.8](../combat-system.md).
Rebuild note (Track 2): `Fn1CD3Dispatcher` maps `0x09`→HOSPITAL_HEAL /
`0x17`→EQUIP_CONSISTENCY / `0x18`→GARAGE_SERVICE — all three need review against the
binary cases above (the `F5`-operand question is solved — raw-byte artifact, see
`formats/bld-bytecode.md` domain note; game-domain cases re-derived by decrypt-scan).

#### §17.11c Mechit-Lube speed-shop mods — REPAIR.BLD (S5, purchase path closed 2026-11-04)

Offer catalog (flavor, per current mech): Locust→rip MGs+ammo, weld 2× Martell medium
lasers; Wasp→drop SRM launcher +1 ML +1 ton armor; Stinger→stack small lasers (up to
"that" total); Commando→drop SRM pack +2 MLs +1 ton armor; engine swap (slower +2
small lasers); Wasp jump-jet→MLs kit; Stinger jump-jet→armor+2 MLs kit; "Blazing
Inferno" (6 tubes→small lasers, ammo bay→ML, crush a  ton Jenner); plus
apprenticeship ("taught by experience", fee + ComStar check), repairs ("What Mech do
you want repaired first"), ammo sales (too-heavy-to-carry gating), tech recruit
(Rex handshake → joins).

**Purchase path (game-domain, via decrypted-`F5` scan):** REPAIR.BLD dispatches
`10,12-20,29,44` — the paid mods are cases **`0x0F`** (500cr, `C61D[D31A]++`,
`C624|=1`) and, from HOSPITAL.BLD, **`0x15`** (500cr, `C61E[D31A]++`, `C624|=2`);
checks `0x10/0x16` read the flag bits back. **No loadout-structure writes exist**
anywhere in `1CD3`/`0FDC` (byte-verified search of all 125-byte-stride writes);
**no cap check** in `0x0F/0x15` (credit check only).
**Reading:** `C61D/C61E`++ = personnel record +9/+10 (Tech/Medical) on the `D31A`
slot — hospital (best-Medical doctor) and salvage (max-Tech actor, P1) consumers
read them as skills, and the apprenticeship/seminar flavor is skill training; the
per-mech offer texts are flavor for an abstract +1 whose payoff is salvage tiers
(P1), heal dice (P2), and the TN skill deduction (`1000:4C9B`). **Alternative**
(dedicated equip counters) requires segment-`0x569E` ≢ record segment or a live
buy-and-dump to decide. **OPEN:** cap=2 source (BLD-side gating? walkthrough
imprecise?); loadout-effect proof — T3 recipe: buy a mod, dump mech bytes +
record bytes before/after; "stack small lasers" vs flavor (walkthrough insists).

#### §17.11d Civilian clothes, uniform & wanted tracking (S2 — closed 2026-11-04)

All game-domain (decrypted) bytes.

**Purchase** (CLOTHES.BLD): menu `F9 29` (Buy/Leave) → `SPEND 35cr` (`EE 2300`)
→ `F4 SET D30C[0x1E]=1` (uniform flag: civilian clothes owned) + dressing-room
text → `F4 SET D30C[0x24]=0x7F`, i.e. **`D330 = 0x7F`** (encounter mask 1/128 =
fewest random Kuritan attacks — the "don't stand out in the crowd" mechanic).
Default/initial `D330` value unconfirmed in statics (traitor assign forces
`0x1F`, resolve restores `0x7F`).

**Recognition branches** (JAIL.BLD, in order): apprehended → `F7 D30C[0x1E]`
(uniform? → *"Because he recognized [your Lyran Special Forces uniform], he knew
you were an enemy agent"*) → `F7 D30C[0x2A]` (=`D336`, *"films of the raid"* →
*"important"*) → *"jailbreak"* → *"wanted"* + `F5` calls + `F4 SET D30C[0x2A]=1`
(jailbreak marker; no code writers — BLD-local) → impound-yard Stinger theft +
escape. `D336` has no code readers/writers (report-only marker). `D30C[0x28]`
(=`D334`, post-dispatch flag) gates the arena/improvised branch (`F7` at `0x701`).
PARTY.BLD also tests `D30C[0x1E]` at `0x169` (Rex-rescue uniform gate).

**Not found in code:** a central NPC talk-refusal gate (uniform is only tested in
JAIL/PARTY; lounge/shop refusals are per-BLD scripted text — the bark directory
exists per H1 but no engine willingness flag); "services closed while an agent
is aboard" (see S1 — `D332` never read); the exact `F9`-menu branch targets
(interpreter `_ip` base question — same tooling class as SX1). BARRACKS'
Marik-uniform swap is a scripted story beat (covered as text).

#### §17.11e Mech repair economy — REPAIR.BLD + `fn11B8_0002` (S6 — closed 2026-11-04)

Entry: `fn1CD3` case `0x12` → `fn11B8_0002` (damage assessment → menu). Byte-verified
price list (all deduct from `D370/D372`, quote via `fn1631_1FDF`):
- **Armor points: 4cr each** (`11B8:0282`–`02D5`; quote `0x1899/0x18BF/0x1902` =
  points + points×4 via SHL 2; Yes/No `0800:1A13`; loop `INC C724+0x11..0x1B`
  per paid point; `D325`-style gate at `0D09` for the flow entry).
- **Structure points: 9cr each** (`[BP-0x3A]=0x1C` loop at `03AC`, `SUB 9` at
  `03B3`–`03C7`).
- **Destroyed weapons: 300cr each** — scan story armament bytes `0x33..0x55` for
  bit-7-set entries (`11B8:00CA`–`0116`; `0x80|0x22` = destroyed heat sink counted
  separately into `[BP-0x30]`; `0x80|0x10..0x20` = destroyed mech weapons counted
  per-id); menu lists them by name (`DS:0x2FD7+id·0x11` = weapon table names);
  on pay, `AND 0x7F` the matching story byte (`11B8:068D`–`06E6`).
- **Actuators: 200cr** — restore `C748/C749` from backups `C78D/C78E`
  (`11B8_07xx`→`18900` region; *"don't have the 200 C-bills"* `DS:0x1CCE`).
- **Heat sinks: 800cr each** (`"special... only 800 C-bills each!"`) — the scan
  counts `0xA2` bytes (`0x80|0x22`, destroyed heat sink); pay writes back `0x22`
  (`11B8:04DD`–`0522`).
- **Ammo bins: per-bin refill at per-type price** (`fn11B8_1762`: `INC C74B+bin`,
  deduct `[BP-0x0E]`; price table read `DS:[type+0x2046]`, default 2cr if type
  `==0x18`; quantity via `1543:0CDE` numeric input; *"too heavy to carry"* is BLD
  flavor — the code gates on credits/quantity and requires owning a mech).
- **Unrepairable (walkthrough's "certain repairs"):** story bytes `+0x75/+0x76/+0x77`
  nonzero → *"Our facility doesn't have the equipment to fix your damaged
  [engine|gyro|sensors]"* (`DS:0x17F7` + far-ptr name table `DS:0x1B3E+idx·4`,
  `11B8:017F`–`01CA`) — no code path restores those three components.
- Personal armor is separate (case `0x09`, 4DDB restore — P2); skill buys are
separate (`0x0F/0x15`, 500cr — S5). OPEN micro-items: exact ammo-price table
segment (`DS:0x2046` read lands in text bytes under the DS-base assumption —
verify at runtime); cap=2 source (no code counter found; BLD-side offer gating
or walkthrough-imprecise); garage parking fees (S7).

#### §17.11f Skill training economy — apprenticeship + seminar (S4 — closed 2026-11-04, game-domain BLD bytes)

- **Apprenticeship** (REPAIR.BLD): *"to the tune of 500 C-bills"* (BLD text markers
  decode to `500`, matching code) → Yes/No (`F6`) → case **`0x0F`**: check
  `tD372/tD370 ≥ 500`, deduct, `C61D[D31A]++` (**+1 Tech**), set `C624` bit 0
  (`1CD3:0C11`–`0C23`; checked by `0x10`).
- **Hospital seminar** (HOSPITAL.BLD): *"astronomical [fee]"* (flavor — code
  charges the same flat **500cr** via case **`0x15`**: `C61E[D31A]++` (**+1 Medical**),
  `C624` bit 1; checks `0x16`). "Trained in first aid" gating is flavor text —
  no skill prerequisite in code.
- **Cap text exists in both flows** (*"already trained you as high as we can…
  tech school"* / *"already know all… medical college"*), but the gate is a BLD
  branch (F7/F6 + `0x10`/`0x16` flag checks around unit-select `0x0D`), not a
  code-side value check — **`0x0F`/`0x15` have no max** (credit check only), so
  repeats are mechanically allowed where the BLD offers them.
- **No schools exist** (verified absence: no BLD/case implements training beyond
  these two purchases; matches the walkthrough's "medical schools don't exist").
- OPEN micro-items (all need the BLD jump-target base resolved — same interpreter
  `_ip` question as SX1-caveat): exact cap-gate branch mapping; which menu options
  re-offer vs one-shot; the `F8 [00 00]` restart targets; `F9` table base.

#### §17.11g Starport garage + jail theft (S7 — mechanics closed 2026-11-05, game-domain BLD)

- **Impound rule** (GARAGE.BLD entry): *"'Mechs are not allowed in the Starport,
  anyone with a 'Mech… must park his 'Mech here."* On-foot entry passes through
  (`F5 17` count + `F7 10→0x03EB` → *"pass through to the rear exit"* +
  `SET 18 01`); entry with mechs gets the park prompt (`F6→0x04B5`).
  Parking: *"take the receipts… expected to pay when you leave"* +
  `F5 28` (case `0x1C` CLEAR_ALL_SLOTS — parked = mech slots cleared, on foot)
  + `SET 18 01`.
- **Fee = 150 C-bills** (`CHKCR 150` + `F5 10` SHOW_CREDITS + `SPEND 150`):
  *"hands you the bill… Will you pay the fee of 150"* → *"You pay the leech
  in full"* + `SET 18 00` + `F5 46` (case `0x2E` restore). `SET 24`
  (`D330` mask) writes: `0` on park-entry path, `1` on exit path.
- **Kurita refusal text**: *"they don't park Kurita 'Mechs here"* (two thugs) —
  present but linearly post-jump (reachability OPEN, see anomaly below).
- **Exclusion = `F7 0x27→0x061A`** (silent `FB FF` block, no text, no entry).
  `D30C[0x27]` is **`D333`, the S1 traitor latch** — no BLD `SET 0x27` exists
  anywhere; the only code writer is the traitor roll (`fn11B8_0D58`, 50%/join);
  cleared post-combat (`fn183B_000A`: `D333=0, D330=0x7F`). So the "theft-flag"
  is the traitor flag: while the traitor is aboard, the garage silently refuses
  entry, covered in-fiction by the *"rampage… stole a 'Mech… not wise to
  reenter"* text (itself linearly post-`F8`, i.e. shown nowhere statically —
  same anomaly). This **confirms the walkthrough's shop-refusal correlation**
  (S1 §25.6.11's "unsupported" is superseded for `D333`; `D332` remains
  write-only). HOSPITAL has the parallel branch `F7 27→0x0414` (`F8→0x04AB`),
  but both paths converge — the *"doctors look at you scornfully… rely on
  your own skills"* text is linearly dead (unreachable FC).
- **Code readers of `D333`** (all `cmp byte …0D333h,0`): pilot-assign tell
  `fn1467_0002` (the `0x279D` unease line, S1), status path `fn0DAB_18E8`
  (display effect OPEN), shop path `fn0800_378D` (effect OPEN), AI targeting
  `fn1631_03AB` ×2 (second site writes the combat `0x3800` table — enemies
  spare the traitor's slot, matching *"the Dracos didn't shoot at him"*),
  post-combat gate `fn183B_000A` (S1 resolution).
- **Theft (JAIL impound yard → Stinger)**: jailbreak branch *"slip out back to
  the impound yard"* → `E4`-bullets → `F5 40` (case `0x28` FINALIZE) →
  `F7 28→0x10C4` → *"You use the newly-acquired **Stinger**… medium laser…
  group escapes"* → `F5 39` (case `0x27` TRIGGER) → jailkeeper/brother thread
  (`SET 2A=01` jailbreak marker, `E9 4` recruit). **Which mech: Stinger**
  (medium laser). **Requirements OPEN (live)**: menu-31 (`F9m 31` @`0x273`,
  *"Ask about Rex's friend / Leave the jail"*) table entries
  (`0x07DC`/`0x10C4`) don't resolve to the theft block cleanly statically
  (0x07DC lands mid-`F5`), and the execution→Stinger adjacency (`F8→0x01F6`
  before the Stinger `FD`) needs a live trace to sequence; walkthrough gates
  it on mechlessness (*"If you don't have your own Mech, steal one"* — WT3).
- **Structural anomaly (filed, same family as S3/S4 notes)**: both GARAGE
  `F6`-Yes branches land on silent `FB FF` with the effect blocks (pay
  `SPEND`, park `F5 28`) sitting post-`FF`; whether fee/park effects are dead
  or reached via loader re-entry (`fn0FDC_0008` recursion from `1CD3` cases)
  needs a live trace — no behavior claimed beyond the bytes above.

#### §17.11h Video store — Mapper + holodisc player (S8 — closed 2026-11-05, game-domain BLD + code)

FROB.BLD is the electronics/video store (*"rows of electronic items… cheap
monaural radios"*), menu `0x25`-style `F9m 36` (*"Ask about: Holodisk players /
Terrain Mappers"*):

- **Holodisk player = 7000cr** (*"harmonic inversion ratio… signal to vector
  impulse tangent"*, *"nicer than the holoviewer you had back at the
  barracks"*): `F6→0x0695` Yes; No → miffed + `F8→0000` restart;
  `CHKCR 0x1B58` (7000) → laughs-you-out + exit; else sale (*"gladly rings up
  the sale… portable holoviewer… AS-IS. ALL SALES FINAL"*) + `SPEND 7000` +
  **`SET 0x30=01`** (`D33C` = player owned; sole writer in any BLD).
- **Terrain Mapper = 6000cr** (*"tie into orbiting satellites and give you a
  snapshot view of the area you are standing on"* — the walkthrough's
  "larger map area" is a loose paraphrase; the game text says snapshot):
  `F6→0x0ABD` Yes (*"NEW and IMPROVED models that claim to completely obsolete
  your mapper. You don't agree, since your mapper functions perfectly well"*);
  `CHKCR 0x1770` (6000); sale + `SPEND 6000` + **`SET 0x31=01`** (`D33D`).
  Post-purchase funnel: holoviewers *"sold out… six months"* +
  `F7 32→0x0DD4` → *"need to view your father's holodisk… unless your
  holodisk player back at the barracks is still functional."*
- **Mapper effect = fog reveal, NOT `w4FBA`** (hypothesis refuted):
  `fn0800_0000` `0800:0107–01B1` — without mapper, single-bit ORs of the
  cursor tile into seen-arrays `0xCB0C`/`0xCAFC`/`0xCB1C` (per `A44D`
  conditions); with mapper (`D33D≠0`, gated on `D346==0`) it mass-marks
  **`0xCB0C` with 8× `0xFF` row writes** — an area snapshot. `w4FBA` is
  untouched (E2: UI render mode 0–3, separate system). Ownership also shows as
  a **Mapper Yes/No status line** in the `fn0800_378D` roster
  (`2867(0x888…)` vs `2867(0x88C…)` at `(0x14,0x15)`, after the `D450`
  training line). OPEN: `D346` identity (set in `fn0800_2DA8` refresh,
  `=1` iff refresh arg `==0x0E`; why the reveal is gated off during it).
- **Player gating for viewer use**: `fn0FDC_0008` post-dispatch
  (`0FDC:00DB`): building index `==8` **and** `D33C≠0` **and** `D31A≠0` →
  plays `DS:0x1384` *"When you get outside, you decide to use your new
  holoviewer to watch your father's holodisk."* then reloads `0008(0x12)`.
  Free alternative = **BARRACK2** wreckage: `F5 14` + `F7 0E→0x012B` —
  flag clear → *"all your holodisks were destroyed in the raid… turn to
  leave"*; flag set → *"Rex waits outside so you can view the disk in
  privacy."* **OPEN (live): `D30C[0x0E]` has NO writer anywhere** (no BLD
  `SET`/`ADD`, no code `mov` — only `cmp` readers in case-`0x01` variant
  select) — the disk-acquisition write is unmapped (segment alias or
  missed site); recipe: play to the Inaugural-Hall handoff, dump `D30C[0x0E]`.
  VIEWDISK confirms the damaged-disk fiction (*"tries repeatedly to recover…
  damage too extensive. Without the password"* — the S12 password).
  MAYOR `0x22C`/`JAIL 0x448` player/video lines are flavor (mayor viewer,
  *"message and video to his superiors"*).
- FROB.BLD continues past the store (`0xE00+`, face-puzzle content) —
  unexamined here; likely S12-adjacent, out of S8 scope.

#### §17.11i Mayor lockpick entry (S9 — closed 2026-11-05, game-domain BLD; "skill check" refuted)

- **No skill check exists.** MAYOR.BLD entry (`0xD4`): `F5 14` then a
  degenerate `F7 0E→0x00DB` / `F8→0x0106` pair — **both land on `0x0106`**
  (*"Rex agrees that you should go in alone… You slip inside"*), so entry is
  unconditional: no RNG, no skill read, no gate. The walkthrough's "pick the
  lock and enter" is flavor for walking in; the S12 cache maze uses key-card
  color numbers, not lockpick skill (WT3 computer terminals — different
  system, no skill involved either).
- The *"fancy new security system that your meager lockpicking skill can't
  defeat"* text is **linearly dead**: it sits post-`F9m 32`-table with no
  entry targeting it (menu maps `0x0302` newspaper / `0x0797` viewer /
  `0x0A11` chow→sandwich→`0x0CED`; `F9` never falls through). Flavor for a
  gate that isn't implemented (same dead-text family as S7's scorn/rampage).
- Menu-32 mapping resolved: newspaper has **pre/post-raid editions** (`F7 0E`:
  clear → *"Tonight at the Chara…"*, set → `0x0550` *"new Kuritan governor…"*
  via mid-`F8` residue); viewer has **documentary vs father's disk** (`F7 0E`:
  clear → *"Steiner offensive actions…"*, set → `0x094A` *"You open the box
  your father gave you, and take out the holodisk"*); chow → sandwich gag.
  `F5 47` (case `0x2F` DECREMENT) at `0x1384`.
- **All three `F7 0E` key on `D30C[0x0E]` = post-raid phase flag** (0 pre /
  2 post — same values the case-`0x01` variant select at `1CD3:0145`
  branches on; BARRACK2 wreckage-viewing keys on it too: pre-raid the
  wreckage doesn't exist). **OPEN (live): the flag has no writer anywhere**
  (no BLD `SET`/`ADD`, no code `mov` — only `cmp` readers), so all three
  consumers are stuck on their pre-raid branches statically; recipe: raid
  the citadel live, dump `D30C[0x0E]` (suspect aliased-segment writer or
  missed site). S11 (hut-appears gating) depends on the viewer flow.

#### §17.11j Hut quiz grading (S10 — closed 2026-11-05, game-domain BLD; gauntlet unpassable statically)

HUT.BLD is almost code-free (one `F8`, two `ED`s, two `SET`s) — the quiz is two
`ED` gates over party skills plus scripted beats:

- **Q1 mechanics** @`0x940`: `ED idx=5 thresh=4 → 0x0946` — any unit with
  record `+9` (**Tech**) `≥ 4` → jump `0x0946` (mid-`F8` residue `h<1E>` +
  *"Your technician rises to the occasion…"* → falls through to Q2);
  else `F8→0x1E68` = `FB FF` **silent eject** (wait + stop, no text).
- **Q2 biochemistry** @`0xC90`: `ED idx=6 thresh=4 → 0x0DBE` — any unit with
  record `+10` (**Medical**) `≥ 4` → jump `0x0DBE`, which is **`FB FF`**
  (the Q2-fail page's end): **silent eject — the *"Your doctor stands
  boldly…"* success text and everything after it is unreachable**;
  else the *"desperation… none of you know the answer… you are outside"*
  fail text (the walkthrough's "stumped" signal) + eject. **Load-bearing:
  Q3 (Mallory's World, Rex auto-answers), Q4, and the `SET 0x35/0x36`
  win flags @`0x1E61/64` are statically unreachable — the gauntlet cannot
  be passed in this binary.** Either a shipped-data bug (target off by two:
  `0x0DBE` should be `0x0DC0`, cf. Q1's working overlap) or the model is
  wrong — **T3 live recipe: train Tech + Medical to 4+, attempt Q2, watch**.
- **"Stumped"→training loop is player-driven** (no code loop): eject → train
  (S4 apprenticeship/seminar) → re-enter from `0xA0`. Q1-fail is silent, so
  the only visible stump signal is Q2-fail.
- **WT discrepancy**: code passes on **ANY** unit meeting threshold (first
  match wins); WT2 says *every* member must be fully trained — overstated.
  Threshold 4 = "excellent skills" (train from 0/1 base, +1 per S4 session).
- Cross-confirmation: REPAIR `ED 5,3 → 0x0ED9` (*"Who w…"*) is a genuine
  Tech≥3 gate (same `idx=5`); HOSPITAL `ED 6,1/6,3` genuine (Medical≥1/3);
  high-threshold `ED`s (`thresh` 244–253, targets OOB) are effectively NOPs /
  disabled checks (HOSPITAL `ED 4,252`, MAYOR `ED 12,252/253`).

#### §17.11k Arena mechanics (S13 — closed 2026-11-05, game-domain BLD + code)

- **Entry/try**: *"winner gets 500"* → `F6→0x027B` (try); No → `SET 0D=0A` + `F5 12` close + exit.
- **Rental (250 = 50 + 200)**: rent? → `F6→0x03A0` Yes → waiver texts (*"lose it forever. The scraps become Arena property"* — own-mech forfeit) → `CHKCR 250` / *"don't have enough cash… deposit"* + exit, else `SPEND 250` (*"50 for renting… 200 deposit… repairs"*); No → `F5 34` (pop `0FDC:1A26`) + `SET 22=00` (own mech). Then `F5 33` (push `0FDC:1C9B`, party shelved) + `SET 22=01` + **`F5 35` = case `0x23` = the arena bout** (`1CD3:1062` → `fn0FDC_0629(8)` on the training-mission engine — **not** new-game init; mislabel fixed in 4 docs).
- **Win/loss**: post-combat `fn183B_000A` (`183B:13AD`) writes the verdict into `D30C[0x21]` (`D32D`): survivors → *"Congratulations! You have won!"* (`0x39AA`, flag stays 1); empty slot → *"The crowd boos resoundingly. You have lost."* (`0x39CA`, flag cleared) — **boos reachable, byte-verified**. BLD: `F7 21→0x08D2` → **`E5 +500`** (*"hands you five hundred"*) + `SET 01=FC`; loss → *"lost combat… lost your 'Mech"* + deposit-confiscated branch (`0x0E2F` — shown to renters; own-mech losers also fall into it: flavor bug, no state effect). **WT3's "250-credit payoff" is wrong: 250 is the rental cost, 500 the award** (net +250 for renters after deposit forfeit).
- **Western-stands exploit (complete chain)**: destroying arena tiles in combat prints *"Your 'Mech has destroyed part of the Arena!"* (`0x4209`) + *"Some Kurita UrbanMechs have been dispatched to kill you!"* (`0x4235`, `1AE8_12C7` tail: E48E-gated tile loop) → sets **`D32F=1`**; post-fight `F7 23→0x09E9` plays the escape (*"waltz a 1.5M Locust out… outmaneuver pursuing UrbanMechs… own a Locust, free and clear!"* — **UrbanMech confirmed as pursuers**; the obtainable mech is the **Locust**, not an UrbanMech) → group regroups outside Starport → parking-garage fee dodge + *"price on your head"* + `SET 23/37/38/39` (`D32F/D343/D344/D345` = 0/0/1/20: main-loop timer cascade; exact effect OPEN, B10-adjacent) → `F5 27`. **No Starport ban exists** (no `ban` string in the EXE — the `ban` hit is *"bandages"*; exclusion = flavor + the pre-existing uniform/encounter systems).
- Rental pool / UrbanMech chance: no RNG in ARENA.BLD — grant site unmapped (live: rent repeatedly, dump roster). Flee-arena outcome (D32D untouched on *"eluded"* path → possible free-500) needs a live test. Arena-salvage suppression (waiver vs P1 wrap-up) OPEN.
- **Road-to-the-arena-city twists (user question — tracked)**: the walk itself = random encounters (Kuritan density near Starport is WT flavor; rate is flat/global `D330`, S1; suppression on local maps verified live, `world-map.md` §17.2); the *"assassination attempt at the training center"* = JAIL.BLD backstory for the jailkeeper (no mechanic); the citadel raid = visit-counted (S3), not travel-triggered. Same-city twists all covered: uniform (S2), stocks/ComStar, Rex/PARTY, jail theft (S7), hospital recruit, Mechit-Lube (S5), video store (S8), mayor (S9), lounge/Rick, theater (flavor), garage (S7), weapon/armor shops, arena (here).

#### Stock Market (COMSTAR)

The stock market simulation handles 3 tickers (DefHes, NasDiv, BakPhar) via a struct array at `DS:0xD390` (stride 0x1A = 26 bytes per stock), accessed via selector at `DS:0x538A`:

```
StockEntry (26 bytes, stride 0x1A):
+0x00: wD390  (uint16) — Stock price / primary value
+0x02: wD392  (uint16) — Price component / secondary value (from 0x45A4)
+0x04: wD394  (uint16) — First data field (from 0x4564)
+0x06: wD396  (uint16) — Second data field (from 0x4596)
+0x08: bD398  (byte)   — Trend/type byte: 0x77 on first visit, 0x70 on subsequent visits
+0x09: bD399  (byte)   — Active flag: loop index (0-7) on first visit, 0xFF on subsequent visits
+0x0A-0x19: (20 bytes) — Unknown/unused padding
```

**Economy timer bD323** at `DS:0xD323`: Decremented each game tick (approximately 3 in-game days per wrap). When wrapping from 0 to 0xFF, triggers the economy display update in the main loop. This update does NOT modify stock values — it only formats and displays the current values using generic math utilities. Stock values only change on COMSTAR entry/refresh (see cases below).

**Case 0x2A (42) — Stock init (first COMSTAR visit)**: Called from COMSTAR BLD. Verified via Reko pseudocode (line 24435). Iterates 8 entries:
1. For each stock `i` (0..7):
   - Copies **raw cursor X** (full uint16 at `A44B`, NOT masked/tile-converted) to `wD390[i]` (StockEntry stride 0x1A) and `0x4024[i*2]` (separate WORD array)
   - Copies **raw cursor Y** (full uint16 at `A44D`) to `wD392[i]` and `0x4056[i*2]`
   - Sets `bD398[i] = 0x77` (constant trend byte — NOT from table_3768)
   - Sets `bD399[i] = i` (active flag = loop index, NOT 0x01)
   - Increments `A44D` by 1 (cursor Y + 1, positions for next entry)
2. After loop exits, cursor is at (start_X, start_Y + 8)

**Case 0x2B (43) — Stock refresh (subsequent COMSTAR visits)**: Verified via Reko pseudocode (line 24457). Sets only **StockEntry[0]** (not a loop):
1. Reads segment selector from `DS:0x53CA` (at runtime → seg 0x0D00)
2. Copies `w4572` (from that segment) → `wD390[0]` and `0x4024[0]`
3. Copies `w45A4` (from that segment) → `wD392[0]` and `0x4056[0]`
4. Copies `w4564` (from that segment) → `wD394[0]`
5. Copies `w4596` (from that segment) → `wD396[0]`
6. Sets `bD398[0] = 0x70` (constant, not 0x77)
7. Sets `bD399[0] = 0xFF` (~0x00, all flags set)

Source tables at `0x4564`, `0x4572`, `0x4596`, `0x45A4` are NOT in the COMSTAR BLD file (BLD is only ~2267 bytes, too small for these offsets). They are accessed via indirection through `DS:0x53CA → segment 0x0D00`, which is populated at runtime by code in segment 0x0D00. The EXE binary at physical address 0x11564 (seg 0x0D00:0x4564) contains x86 code bytes, not pre-populated data — confirming runtime population.

**The market "fluctuation" has two modes**: (1) First visit seeds all 8 stock entries from cursor coordinates as pseudo-random values; (2) Subsequent visits load only entry[0] from source tables populated by code in segment 0x0D00. The bD323 timer only controls when stock VALUES ARE DISPLAYED on screen, not when they change. There is no continuous price simulation tick.

**Correction**: `fn207F_3D1C`/`3D44`/`3D6C` are **not** stock-specific update functions — they are generic 32-bit math wrappers (`fn207F_3E2E`=multiply, `fn207F_3E62`=divide, `fn207F_3EC4`=shift-right) used during the economy display phase to format numeric values for on-screen rendering.

#### Cadet economy & the day cycle (Pacifica Training Center)

While Jason is a **cadet at the Pacifica Training Center**, time passing earns a **minimal salary /
allowance**: the account ticks up by **+15 cr**. **Mechanism decoded 2026-10-14**
(`UNBTECH_0800.asm:296`–`044A`, byte-verified):

- **Countdown**: `D323` free-runs `256→0` (DEC each main-loop pass, never reloaded); the economy
  block fires when it hits 0. (`D329/D320/D321/D322` decrement alongside — same free-counter
  family; cf. the 3-day-cycle note in `engine/viewport.md`.)
- **Wealth-cap gate** (this is the "finite" mechanism — not a day count): wealth =
  `D370+D374+D378+D37C` dword sum (credits + 3 stock holdings); `fn0800_29F5` builds threshold
  `DX:AX = ([0xD340]<<8)|[0xD33F]`; **+15 fires iff wealth < threshold** (`ADD [0xD370],15`
  with carry at `0800:0343`). Live threshold: `D33F/D340 = 32 00` → **cap = 50**
  (observed: 35→50 fires once, then stops; 55-wealth never fires).
- **Arena latch**: `D310≠0` (set once in `0FDC:0CFA` when `[3772]≠0`, never cleared in static
  code) suppresses the allowance and forces the growth path below.
- **Stock growth** (same block, `0800:037A` loop over 3 stocks): `RNG & mask[0x2A2+i*2]`; zero →
  base path, else `holdings×100 ÷ divisor[0x2A8+i*2]` via the `3D1C/3D44` math wrappers, plus a
  BakPhar clamp (`÷4` if `>18000` or `D37E≠0`). Mask/divisor segment TBD (not `0x2A0F`).
- Walkthrough corroboration: *"every five minutes or so… fifteen credits"* (≈256 loop passes),
  *"you may not even be earning any more allowance"* (cap reached).

To earn more money you must advance the day by **sleeping at the barracks**. Sleeping is **gated**:
you must first **go to the training center and complete that day's mission** (one mission per day).
So the core early-game loop is:

> training-center mission (1/day) → **sleep at the barracks** → new day → allowance/salary accrues again → repeat

- Allowance tick: **+15 cr** iff wealth < 50 (threshold bytes `D33F/D340`), every 256 loop passes.
- Day advance: **sleep at the barracks**.
- Sleep gate: **one training-center mission per day** must be completed first.
- Live anomalies under isolation (2026-10-14, 10-min no-input sampler running): one-time **−6**
  charge and **+6/+1** micro-ticks — fee source unisolated (no SUB 6 on `D370` in any segment;
  11B8 fees are 4/9/320/12C/C8).

*(Prior note "exact tick period / stop threshold / mission counter still to be located" is now
resolved except the mission counter + fee source.)*

### 17.12 Player Interface System

> **Moved (2026-09-28).** This section described the **engine** viewport / rendering / input system,
> not the story system. It is now in its canonical docs:
>
> - Rendering, `w4FBA`/`w4FBC`, borders, 3-pass pipeline, blitter, main game loop, image pipeline →
>   [`../engine/viewport.md`](../engine/viewport.md)
> - Cursor system + keyboard/menu input →
>   [`../engine/input-navigation.md`](../engine/input-navigation.md)
>
> Story-system interface facts (story-slot-driven menus, building/BLD text flow) remain in §17.10/§17.11.

### 17.13 Known Gaps

1. Exact BLD index translation table at `0x4602` — not fully decoded
2. How MAP1 terrain tiles update to MAP11 after attack — likely a second tile property table gated by `b0057`
3. ~~The `0xC0` prefix combined with specific sub-bytes (`c0 e8`, `c0 da`, etc.) — exact semantic at bytecode level needs further investigation~~ **RESOLVED**: `0xC0` is a pure no-op/structural separator. The byte following `0xC0` is the actual opcode (0xE4-0xFF). All `c0 xx` patterns are simply `C0` (skipped) + actual opcode. See docs/formats/bld-bytecode.md for details.
4. Animation tile selection in seg 135D — how individual animation frames map to specific CMP/ICN tiles
5. `tB764 mode 0x03` (VGA mode X) — used in combat/stat screens? Stride 0x0A00 is unusual and only referenced in `fn207F_275C`
6. `w3988` animation guard — what sets this flag and when does animation pause?
7. `w37FE` text mode flag — read in many places but exact semantics not fully traced
8. Combat/stat screen rendering — confirmed to use w4FBA 0+2+3 combos rather than modes 4-6, but exact screen layout for stats/combat UI not mapped

---

