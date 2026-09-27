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
| `0xED` | `~0x12` | UNIT_CHECK_LOOP | 2 bytes | Loop 8 units checking `aC60F` state |
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
| `0x09` | HOSPITAL_HEAL | Deduct healing cost from table 0x4F26/0x4F28, call `fn1631_1FDF` + `fn0FDC_13DE` |
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
| `0x23` | NEW_GAME_INIT | **Full game init**: clear state, load char templates, set party, init graphics, init viewport |
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

**Property 0x1C-0x23** are nibble-packed flag management for slot 0x24/0x25 (skill) and slot 0x3A/0x48/0x4F/0x51 (inventory/equipment).

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
- **Call**: `fn1CD3_0004` case `0x23` (NEW_GAME_INIT)
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

Each world map location is tied to a BLD file. The BLD index is determined by:
1. The map tile property at the player's position (from tile property table at `DS:[0x55DC]→0x32C6`)
2. A translation table at `segment [0x5460]:0x4602` (16-byte signed array loaded from MTP file header at `0x3092:4602`): remaps tile property value → BLD file index, handled by segment 094C functions `unknown_094C_0008_094C8` and `unknown_094C_17B9_0AC79`

| Map | BLD File | Trigger | Story Purpose |
|-----|----------|---------|---------------|
| MAP1/11 | TRAINING | Default start + post-attack | Training missions + citadel attack |
| MAP1/11 | CITADEL | `b0057 ≥ 1` | Post-attack citadel exploration |
| MAP2 | BARRACKS | At barracks tile | Recruit NPCs, interact with cadets |
| MAP2 | BARRACK2 | At secondary barracks | Additional soldier interactions |
| MAP2 | LOUNGE | At lounge tile | Rick gives device, mentions Starport |
| MAP2 | COMSTAR | At ComStar building | Banking, stock market (DefHes, NasDiv, BakPhar) |
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
- Cache entry requires: holodisk repaired (HUT.BLD) + password learned (FROB.BLD) + cache location known (FINDIT.BLD)
- INSTRUCT.BLD at cave entrance: color-coded lock puzzle (Jeremiah's note)
- Inside cache: VIEWDISK.BLD shows Jeremiah's holodisk message
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

### 17.12 Player Interface System

#### Screen Layout

The game renders at **320×200 EGA** (VGA compatible mode 0x0E, 16 colors). The screen is divided vertically into two panels:

| Panel | Width | Description |
|-------|-------|-------------|
| Left panel | **80px** (`0x50`) | Location graphic + action menu |
| Right area | **240px** (320-80) | Main viewport (world map, local tiles, or text) |

The 80px left panel width is a hardcoded constant (`0x50`) used across 7+ source files for viewport clipping (`fn207F_24D7`), text layout (`fn1E56_0388`), sprite rendering (`fn1F3D_0086`), and screen buffer addressing (`fn207F_245C`/`fn207F_24D7`).

The EGA framebuffer uses a planar layout:
- **4 bit-planes** (Blue=0, Green=1, Red=2, Intensity=3)
- **40 bytes per plane per scanline** (320px / 8)
- **Odd/even row interleaving**: even scanlines in bank 0, odd scanlines in bank 1, offset by `0x2000` (8192 bytes)
- **Row-pair stride**: 80 bytes (0x50) per plane for two interleaved rows
- **Total framebuffer**: ~32768 bytes (0x8000) for 4 planes, used via VGA ports `0x3C4`/`0x3CE` for plane selection

#### Global UI Mode: `w4FBA` (at segment `0x569E` offset `0x00FD`, via selector at `0x53A0`)

Controls which rendering mode is active. Checked by 60+ code paths across 8 code segments. Modes 4-6 **do not exist** — only 0-3 are used.

| Value | Mode | Right Panel | Border Style | Char Stride | Font Blitter | Framebuffer |
|-------|------|-------------|--------------|-------------|--------------|-------------|
| `0` | World Map | Hex/overhead map | Full border (`fn207F_1CB8`) | 1× (2-byte) | `fn207F_2209` | `0x246C:0x244B` |
| `1` | Local Tiles | Building interior tiles | Full border | 2× (4-byte) | `fn207F_21A8` | `0x246C:0x244B` |
| `2` | Text Only | Cipher-decoded text | Text border (`fn207F_245C`) | 1× direct | `fn207F_2251` | `0xA000:0xAC00` |
| `3` | Building Name | Overlay text | Narrow border (`fn207F_1D3A`) | 8× (8-byte) | `fn207F_22A5` | `0x246C:0x244B` |

**Set at startup, with render-in-progress toggle**: w4FBA is written from user keyboard input (keys 1-4). The user presses `1`/`2`/`3`/`4` (ASCII 0x31-0x34) in the `main` function (pseudocode lines 5921-5922), stored as raw keycode. After the protection screen (lines 5929-5958), it is normalized at line 5961 via `-= 0x31` to yield 0-3. During the main render loop (lines 6110-6132): if w4FBA==0, it is temporarily set to 1 during the rendering pass and restored to 0 after. Values 0 and 1 produce the same border variant. **No BLD opcode or game function changes w4FBA to a different mode during gameplay.** All dynamic viewport changes (combat mode, building entry, action menus) are handled by `w4FBC` and `tB764` instead.

- **Initial set**: `main` reads key 1-4, stores raw ASCII (0x31-0x34) at line 5922
- **Normalization**: line 5961: `t4FBA -= 0x31` (0x31→0, 0x32→1, 0x33→2, 0x34→3)
- **Render toggle** (lines 6110-6132): if w4FBA==0, set to 1 during render pass, call `fn207F_2CE1(1)` → tB764=1; after render, reset to 0, call `fn207F_2CE1(0)` → tB764=0
- **Protection screen** (lines 5929-5958): runs between keyboard input and normalization — a custom text I/O screen using `fn1F3D_0259`, NOT part of the w4FBA viewport system. Renders prompts and reads answers (keys 1-3) before main game loop starts.

**Mode-specific rendering parameters** (from `fn1F3D_03EB` lookup tables at `a4FC4[][w4FBA]`, `a4FCC[][w4FBA]`, `a4FD4[][w4FBA]`):
- Mode 0: left panel width = 80px, row stride = 0x0140 (320 bytes), line advance by 320
- Mode 1: left panel width = 80px, double pixel width
- Mode 2: no left panel (fullscreen text), VGA buffer at 0xAC00, row stride = 40 text columns
- Mode 3: overlay with 0x0A00 stride (2560 = character row * 320 * 8), 8× pixel font

#### w4FBC — Secondary Viewport Flag (Combat/Building Panel Narrowing)

**Location**: Selector `0x53E8` (adjacent to `0x53A0` which holds w4FBA), offset `0x4FBC`. Stored as `uint16` but used as boolean (only values 0x00 and 0x01).

**Purpose**: Controls left-panel width narrowing. When `w4FBC != 0`, the left panel narrows from 80px (`0x50`) to 4px (`0x04`) in rendering functions like `fn1F3D_049D` (line 568). This is the MECHANISM used for combat mode, building interiors, and interactive menus — NOT a w4FBA change.

**Set to 1 (`w4FBC = 0x01`)**:
- Combat encounter start (`fn183B_000A`, pseudocode lines 2997, 3276)
- Combat flow (`fn0800` lines 4790, 5658)
- Combat dispatch (`fn1CD3` lines 12867, 13366)
- Building entry (`fn135D` lines 84, 583, 713)
- Action menu (`fn1CD3` line 1718)

**Cleared to 0 (`w4FBC = 0x00`)**:
- Combat cleanup/end (`fn0800` lines 4853, 5653, 8233)
- Action menu exit (`fn0DAB` line 1832)
- Building exit (`fn135D`)
- Game mode transitions (`fn0800` lines 4798, 5598; `fn1CD3` line 1674)

**Key insight**: The original TECHNICAL_ANALYSIS.md incorrectly attributed combat/text transitions to w4FBA changes. Those were actually w4FBC toggles. w4FBA stays at whatever startup value the user chose (typically 0 for World Map). When combat starts, w4FBC=1 narrows the left panel to 4px (hiding the animation graphic), and the combat HUD text is drawn there alongside the expanded right-panel viewport.

#### Border Drawing System

Dispatched by `fn1F3D_06C3()` (segment `1F3D:06C3`), called from 16+ locations across all major rendering paths. Uses `BTBORDER.TIL` tileset loaded into segment 1A58's tile cache.

**Three border variants:**

1. **Full border** (`fn207F_1CB8`, default for w4FBA=0,1): Draws a decorative frame around the entire 320×200 screen. Two sub-variants based on `tB764` flag:
   - `tB764 == 0`: Standard frame using 0x1A offset, 54-byte tiles at 100-row loop
   - `tB764 != 0`: Wide frame using 0x34 offset, 108-byte tiles at 50-row loop, with 4 side-panel sections

2. **Narrow border** (`fn207F_1D3A`, w4FBA=2): Draws only the left side border for text-only mode. Loops 200 rows:
   - Each row: writes 27 words (54 bytes) to VGA memory via `SEQ(al, al) & 0x0FF0` nibble expansion
   - Creates a narrower text area (approximately 27 character columns)

3. **Text overlay border** (`fn207F_245C`, w4FBA=3): Called with params `(0x00, 0xAC00, 0x00, 0xA000, 0x0D, 0x00, 0x1B, 200)` — renders a 13-column-wide text strip in the left panel at Y offset 0 for building name display

#### Main Game Loop (`fn0800_0000`, segment `0800:0000`)

The core rendering loop runs continuously while `w0152` (offset `0x0152`) is zero. The actual code order is: **Input → Key Dispatch → Timer → Economy → Animation+Render+Border → BLD**.

```
fn0800_0000(wArg04):
    fn207F_2FDC(0x30)         // Save segment context
    fn0800_48B7(0x0F)         // Init state machine (fn0800_1B8E sub-dispatch)
    
    while (w0152 == 0):
    
        // ══════════ PHASE 1: INPUT ══════════
        if (fn1F3D_002F() == 0):        // No key pending
            fn1F3D_0006(1)               // Software timer decrement
            continue                     // Skip to timer phase
        else:
            fn1F3D_0259()                // Read scancode → wLoc28
            
        // ══════════ PHASE 2: KEY DISPATCH ══════════
        fn0800_2A2B()                    // Wait-for-key loop (busy-wait if w3938==0)
        fn1E56_0D1D(scancode)            // Echo character to echo buffer
        fn1E56_0281(4)                   // Text mode init (set w4FBA mode)
        
        // Character processing loop (runs for all bytes in buffer up to 0x015A)
        for (i = 0; i < 0x015A; i++):
            if (key != 0x20):            // Not space
                fn0800_218F(key)          // Arrow key / char handler
                    └─ fn0800_1C12 → check disabled
                    └─ fn207F_158C/163B (vertical scroll)
                    └─ Loop 3 tiles: fn0800_2DA8 → fn207F_1DA8
                    └─ fn207F_17C5/16E3 (horizontal scroll)
                    └─ fn207F_1314(cursor) + fn207F_1DF8(tile index)
            fn0800_051B()                // Unit/map processing
                └─ fn0800_2A93 (world map tile render, 64 tiles)
                └─ fn207F_28EB (tile blit to framebuffer)
            if (wD55C != 0): break
        
        fn0800_231D(key)                 // Post-key handler
        if (key == 0x20):                // Space key = action menu
            fn0800_2C50()                // Action dispatch (long, 3000+ lines)
        
        // Visibility/fog update
        if (bD33D != 0 && bD346 == 0):
            Update fog grid at 0xCB0C/0xCAFC/0xCB1C (column-based iteration)
        else:
            Update world map visibility bits at 0xCB0C (fog of war)
        
        // ══════════ PHASE 3: TIMER ══════════
        Decrement: bD335 (encounter movement timer)
        Decrement: bD343/bD344/bD345 (encounter spawn cooldown, 3-byte cascade)
        Decrement: bD329 (UI timer), bD320/bD321/bD322 (various timers)
        Decrement: bD323 (economy/production timer, 3-day cycle)
        
        // ══════════ PHASE 4: ECONOMY ══════════
        When bD323 wraps (0→0xFF):
            Calculate (credits + inventory_value) threshold
            if (bD310 == 0):                 // Building NOT active
                fn0800_29F5()                // Threshold check → add 15 credits
                fn1631_1FDF()                // Credit amount display update
            if (bD310 == 0):                 // World map NOT active (2nd check)
                fn0800_29F5()                // Different threshold check
                For 3 stock tickers (0-2):
                    Check player-owns-stock flag at segment[D30C+0x2A2][i]
                    if owned:  fn207F_3D1C/3D44 → format actual stock value for display
                    if !owned: fn207F_3D1C/3D44 → format default value 110
                    // fn207F_3D1C/3D44/3D6C are generic 32-bit math wrappers
                    // (mul at 3E2E, div at 3E62, shr at 3EC4), NOT stock-specific
            Decrement economy timers
        
        // ══════════ PHASE 5: ANIMATION + RENDER + BORDER ══════════
        fn0800_240B()                       // Tile animation page swap
            └─ w3988 guard (enabled when != 0)
            └─ w5800 cycles 0→1→2→0 (3 frames)
            └─ Source: (w5800 << 7) + 54658 (tile buffer page)
            └─ Copies 4100×3 tiles via fn207F_28A8 (128-byte memcpy per tile)
            └─ w4FBA==2: uses fn207F_0A9F instead (text-mode addressing)
        
        Counter 0x57FE += 1; wrap at 3:
        if (0x57FE wraps):  fn0800_24C2()    // Next animation frame
            └─ Iterates 8 unit slots (stride 0x1A)
            └─ Decrements bD399[n].counter
            └─ On expiry: copies coords from templates 0x4564/17814
            └─ On despawn (slot empty): cursor snap via fn0800_191B
        
        if (w014A != 0):                     // Screen refresh needed
            fn207F_1314(tA44D, tA44B)        // Set cursor position
            fn207F_18EF()                    // Screen refresh (tile grid render)
                └─ tB764 == 0x02: VGA text mode (3CE:0205+08)
                └─ tB764 == 0x00: halved dimensions
                └─ Default: full planar EGA
                └─ Draws 13×12 tile grid centered on cursor
                └─ fn207F_1AA8/1ACE/1AF4 (partial/full tile writes)
            fn1F3D_06C3()                    // Draw border (w4FBA dispatch)
                └─ w4FBA==2: fn207F_245C (text overlay)
                └─ w4FBA==3: fn207F_1D3A (narrow border)
                └─ Default: fn207F_1CB8 (full border, 0x32 rows × 0x6C bytes)
        
        // ══════════ PHASE 6: BLD/BUILDING ══════════
        if (w014A == 0 || w01A8 != 0):
            fn1CD3_17C6()                    // BLD processing (building text)
            if (w014A == 0):
                fn1E56_03F5(text_id, ds)      // Display cipher-decoded text
                fn1F3D_0259()                  // Wait for keypress
                fn1E56_0388()                  // Text cleanup (clear wD55C)
            
            fn0800_1A13(1)                    // State check (fn0800_2A2B inside)
            if (continue): fn0800_4DC7()      // Continue main menu
            else: w0152 = 1                   // Exit game loop
```

#### Screen Composition Pipeline

Rendering follows a **3-pass compositing model**, not a unified draw call. The passes occur in sequence each frame, but from different call sites:

1. **Pass 1 — Right panel content** (from `fn207F_18EF`, Phase 5 of main loop):
   - World map tiles (seg 1431, mode 0): `fn0800_2A93` renders 64 tiles (0x40) centered on cursor
   - Local tiles (seg 0FDC, mode 1): building interior tile map via BLD interpreter
   - Text (seg 1E56, mode 2): dialogue text via `fn1E56_03F5` to 0xAC00 buffer
   - `fn207F_18EF` reads tile properties from seg 246C `+0x7AD[tile_index]`, renders 13×12 tile grid
   - Tile rendering uses `fn207F_1AA8` (partial tile), `fn207F_1ACE` (full tile + left edge), `fn207F_1AF4` (full tile)
   - For w4FBA=0: world map visibility fog applied at 0xCB0C/0xCAFC/0xCB1C

2. **Pass 2 — Left panel border + graphic** (from `fn1F3D_06C3`, Phase 5):
   - Full border: `fn207F_1CB8` copies 0x32 rows × 0x6C bytes from tile buffer. 4-plane variant:
     - tB764==0: 100 rows × 54 bytes (0x36)
     - tB764!=0: 50 rows × 108 bytes (0x6C), 4 side-panel sections (8084/16276/24468 plane strides)
   - Narrow border: `fn207F_1D3A` writes 200 rows × 27 words via `SEQ(al,al) & 0x0FF0`
   - Text overlay: `fn207F_245C` calls `fn207F_24D7` case 0x02 (40-column text clip)
   - Location graphic/animation in upper-left rendered via segment 135D DISP function

3. **Pass 3 — Text/menu overlay** (from `fn1E56_03F5` via Phase 6 BLD processing):
   - Action menu items and dialogue text rendered on top of existing content
   - Uses VGA write mode 2 for pixel writing (out 0x03CE/0x03C4 register pairs)
   - Character widths depend on w4FBA mode (1×, 2×, or 8× pixel stride)
   - Positioned relative to left panel's character grid (10 character columns = 80px)

#### Viewport Clipping System

Two functions in segment 207F manage rendering bounds:

- **`fn207F_18EF`**: Screen refresh pass. Via `fn207F_1AA8`/`1ACE`/`1AF4` renders the 13×12 tile grid centered on cursor `(A44B, A44D)`. Reads tile property from seg 246C `+0x7AD[tile_index]`. No standalone viewport-dimension-config function (`fn207F_1B80` does not exist in decompiled code — earlier documentation references to it were incorrect).
- **`fn207F_24D7`**: Core EGA framebuffer blitter that handles all viewport clipping with 4 cases based on `tB764`. Case 0x00 clips to 80px left panel width (0x50), case 0x02 clips to 40-column text width.

The core blitter `fn207F_24D7()` handles EGA framebuffer copying with 4 cases based on the `tB764` **pixel format flag** at seg 246C's rendering config struct:

| `tB764` | Mode | Width | Framebuffer | Stride | Details |
|---------|------|-------|-------------|--------|---------|
| `0x00` | CGA/Herc | 0x50 (80) | `0xB800` | 0x28 (40) | 2-bit pixels, odd/even 0x2000 plan shift, parity interleave |
| `0x02` | VGA text | 0x28 (40) | `0xAC00`→`0xA000` | 0x28 (40) | Linear, `out 0x03CE, 0x0105` write mode 2, no planar |
| `0x01` | EGA planar | 0xA0 (160) | `0xA000` | 0x28 (40) | 4-bit planar interleave (bx = row & 0x03), plane shift |
| default | Full frame | 0x140 (320) | `0xA000` | 0x0140 | Linear full-width copy, no planar interleave |

**Case 0x00 (left panel, 80px):** Clips width to max 0x50. Uses odd/even row interleaving: if `(row & 1) != 0`, address += 0x2000 (plane offset). Copies `clip_width/2` words per row via `memcpy`. Row-pair stride = 0x50 (80 bytes).

**Case 0x02 (text mode, 40 columns):** Clips width to max 0x28. Uses VGA write mode 2 (`out 0x03CE, 0x0105`). Copies `clip_width` bytes per row linearly via `memcpy`. Row stride = 0x28. No planar interleave.

**Case 0x01 (EGAP, 160px):** Clips width to max 0xA0. Uses 4-bit planar interleave where `bx = row & 0x03` selects plane. Same parity-based odd-row offset as case 0x00 but with 4-way (not 2-way) plane cycling.

**Default (320px full):** Clips width to max 0x140. Linear copy, `clip_width/2` words per row. Row stride = 0x0140. No planar interleave.

**VGA Pixel Writer (`fn207F_275C`):** Writes pixel data with 4 sub-modes based on `tB764`:
- `tB764==0x00`: CGA mode, writes to `0xB800`. 2-byte stride.
- `tB764==0x02`: VGA planar, writes to `0xA000`. 4-pass bit plane sequencing via `0x03C4` (ports 0x0102/0x0202/0x0402/0x0802). 8 pixels/byte, 1 bit/plane.
- `tB764==0x03`: VGA mode X, writes to `0xA000` with stride `0x0A00`. Nibble-packed (4-bit pixel replication `SEQ(al,al) & 0x0FF0`).
- default: `0xB800` text mode, 2-pass with 4-attribute bytes per character cell.

**`fn207F_245C` (text overlay wrapper):** Sets up blitter context registers (`tB78A-B79C`) with pixel-format-dependent scaling:
- `tB764==0x02`: direct params (no shift)
- `tB764==0x00`: params ×2
- `tB764==0x01`: params ×4
- `tB764==0x03`: params ×8
- Then calls `fn207F_24D7(0x246C)` to execute the blit.

#### Cursor System (`tA44B`/`tA44D`)

- **`tA44B`** (at segment `0x569E` offset `+0x0131`): Cursor X coordinate. Low byte = pixel column (0-39 in 8px character units), high byte = sub-pixel / grid flags.
- **`tA44D`** (at offset `+0x012F`): Cursor Y coordinate. Same format: low byte = row (0-24), high byte = flags.
- **Page flip**: `fn1E56_021D()` resets cursor position after page transitions.
- **Coordinate packing** (used in combat targeting): X = `(val & 0xF00) >> 1 | (val & 0x7F)`, Y = `(val & 0xF000) >> 5 | (val & 0x7F)`. Masking with `0xF7F`/`0xF07F` for grid/sub-pixel precision.

#### Keyboard/Menu Input (`fn1F3D_0259`)

Key scanning at segment `1F3D:0259`. Returns extended scan codes for arrow keys (combined with `~` bitwise NOT in the decompiled code):

| Key | Code | Handler |
|-----|------|---------|
| Up/Home/PgUp | `~0x47/48/49` | `fn207F_158C()` — cursor up/world scroll |
| Down/End/PgDn | `~0x4F/50/4E` | `fn207F_163B()` — cursor down/world scroll |
| Left | `~0x4C` | `fn207F_16E3()` — cursor left |
| Right | `~0x4D` | `fn207F_17C5()` — cursor right |
| Space | `0x20` | `fn0800_2C50()` — action/select menu |
| Enter | `0x0D` | Confirms selection |

The arrow key handler (`fn0800_218F`) loops 3 times over world tile entries at offset 0x09F3, rendering tiles beneath the cursor via `fn0800_2DA8()` and `fn207F_1DA8()`.

#### Animation System (segment 135D)

4-function dispatch for left panel location graphics:

| Function | Offset | Purpose |
|----------|--------|---------|
| DISP | `fn135D_0004+0x0000` | Display animation frame in left panel |
| LOAD | `+0x0010` | Load animation data from ANM file |
| INIT | `+0x0020` | Initialize animation sequence |
| CLEAR | `+0x0030` | Clear animation state |

Called from BLD building entry (`fn0FDC_0008`) to render the location portrait/building image in the upper-left panel area. The animation frame renders into the 80px wide clip region at the top of the left panel.

#### Building Interior Tiles (w4FBA=1)

When entering a building:
1. `fn0FDC_0008` loads BLD data by index from segment `3000:CC30` filename list
2. `fn0FDC_01C0` bytecode interpreter runs, starting with room description
3. Tile map renders into the right 240px panel via `fn0800_13F4()` / segment 0FDC
4. Left panel shows building image (via segment 135D) and action menu

#### World Map (w4FBA=0)

1. `fn1431_0091()` renders map tiles into the right panel
2. Scroll/viewport operations compensate by `-0x50` to align pixel X=80 with tile offset 0
3. `fn207F_1DF8()` calculates cursor tile position from `tA44B`/`tA44D`:
   - Tile X = `(tA44B >> 1 & 0x07) + 2`
   - Tile Y = `(tA44D >> 1 & 0x07) + 2`
   - Tile index = `tileX + tileY * 24` (map grid is 24 tiles wide)
4. 3 tiles beneath cursor rendered each frame via the arrow key handler

#### Image Rendering Pipeline

The game uses two image formats:

**1. Nibble-packed format (internal working buffer)**
```
[byte 0] = [pixel0(4bit) | pixel1(4bit)]
[byte 1] = [pixel2(4bit) | pixel3(4bit)]
...
```
Each byte stores 2 pixels (4-bit EGA color index 0-15). For a full 320×200 screen: 32000 bytes.

**2. EGA Planar format (VGA framebuffer)**
```
Scanline Y (even) at A000:0000 + (Y/2)*40 + plane*0x2000  (40 bytes)
Scanline Y (odd)  at A000:2000 + (Y/2)*40 + plane*0x2000   (40 bytes)
```
4 bit-planes × 40 bytes/scanline = 160 bytes per row-pair. Plane stride = 0x2000 (8192).

**Conversion path** (on-the-fly via VGA write mode 2):
```
Nibble-packed (32KB) → VGA write mode 2 → EGA planar framebuffer
  fn207F_24D7 case 0x00: writes to 80px left panel clip region (planar interleave)
  fn207F_24D7 case 0x02: writes to 40-column text region (linear, no planar)
```

**The C# extractor `Write2ModeConverter`** (in `InceptionTools/Graphics/EGA.cs`) converts nibble-packed (2px/byte) to byte-per-pixel (1px/byte, 64000 bytes). This is for modern display only — the game operates on the nibble-packed format internally and uses VGA hardware registers (`0x03C4`/`0x03CE`) to expand to planar.

**Asset loading pipeline:**
```
CMP/ICN file (header: 2-byte LE size + 1-byte format)
  → RLE decompress (Format01 row-major / Format02 column-major)
    → nibble-packed (32KB for 320×200, 2px/byte)
      → fn207F_28A8 (128-byte memcpy for tile animation)
      → fn207F_24D7 case 0x00/0x02/0x01/default (viewport blit to A000/B800)
      → fn207F_275C (VGA pixel writer with plane sequencing)
```

---

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

