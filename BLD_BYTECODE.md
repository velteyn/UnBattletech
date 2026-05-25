# .BLD Bytecode Specification

## File Header (8-12 bytes)

| Offset | Size | Description |
|--------|------|-------------|
| 0 | 1 | File type/ID (varies: 0x18, 0x33, 0x68, 0xb1, 0xc8, 0xd0, 0xd6, 0xd8...) |
| 1 | 1 | Interaction/paragraph count (0x01-0x21, 1-33 observed) |
| 2-5 | 4 | Signature `ee c6 eb ea` (0xEAEBC6EE) |
| 6-7 | 2 | Content type code |
| 8+ | varies | Subtype/data (content-dependent) |

### Content Type Codes

| Bytes | Type | Files |
|-------|------|-------|
| `c0 ec` | Dialogue/Story | TRAINING, CITADEL, BARRACKS, BARRACK2, COMSTAR, FINDIT, FROB, HUT, INSTRUCT, JAIL, LOUNGE, MAYOR, PARTY, THEATER, VIEWDISK, WINSCENE, ENDMECH, CLOTHES |
| `c0 f5` | Shop/Service | ARMOR, ENTRANCE, GARAGE, HOSPITAL, REPAIR, WEAPON, WEAPON2, ARENA |
| `c0 f4` | Special | menu/special action sequences |
| `c0 da` | Endgame | WINSCENE |

## Core Architecture

The .BLD file is processed by a **three-layer interpreter system**:

```
Layer 1: fn0FDC_0008 (0FDC:0008)
  Entry point. Loads BLD data, calls fn0FDC_1D30 to prepare data buffer,
  then calls fn0FDC_01C0 and fn1CD3_0004.

Layer 2: fn0FDC_01C0 (0FDC:01C0)
  Game-logic bytecode interpreter. Handles opcodes 0xE4-0xFF.
  Bytes 0x00-0x7F are transparent (cipher text, ignored).
  Bytes 0x80-0xC3 enter switch but match no cases (no-ops: includes
  narrative markers 0x9E/0x9C/0x9B/0xBB/0xAA and prefix 0xC0).

Layer 3: fn1CD3_0004 (1CD3:0004)
  Room/building interaction dispatcher. 47-case switch (cases 0x01-0x2F).
  Handles building entry/exit, shop buy/sell, inventory, combat,
  healing, story flags, party management.

Layer 4: fn1E56_03F5 (1E56:03F5)
  Text renderer. Formats text with word-wrapping, line breaks, margins.
  Handles special characters: 0x0D=CR, 0x02/0x06=soft break, 0x20=space,
  0x09=indent, 0x13=padding. BIT7 flag for inverted text.
```

### Execution Flow

```
1. fn0FDC_0008 is called with a BLD file index
2. fn0FDC_1D30 prepares a bytecode buffer from the BLD data
3. fn0FDC_01C0 reads through the buffer byte-by-byte - the loop at
   0FDC:01D1 reads one byte at a time, checking each byte:
   a. If byte < 0x80: transparent, continues loop (cipher text passes through)
   b. If byte >= 0x80: enters switch statement
      - 0x80-0xC3: no matching case, falls through (no-op, bytes like
        0x9E/0x9C/0xBB/0xAA/0xC0 are STRUCTURAL MARKERS at this layer)
      - 0xE4-0xFF: actual opcodes with handlers
   c. When opcode 0xFC is hit, calls fn1E56_03F5 to render text
   d. When opcode 0xFF is hit, exits the interpreter loop
4. After fn0FDC_01C0 returns, fn1CD3_0004 is called with a dispatch
   value (usually bD30C, the room/building type index) to handle
   higher-level room interaction logic
```

## The `c0` Prefix is a Structural No-Op

`0xC0` enters the switch at `fn0FDC_01C0` but matches NO case. It is
a **pass-through structural marker** that separates narrative text from
control bytecodes. The actual control opcode is the byte AFTER `c0`
(e.g., `e8`, `f3`, `e7`, `f2`), which IS handled by the interpreter.

So in the BLD data, a sequence like:
```
9c [text] c0 e8 2f bf ec [more text]
```
Works as:
1. `9c` = narrative mode marker (no-op at this layer, handled higher up)
2. `[text]` = cipher text (transparent to interpreter)
3. `c0` = structural marker (no-op at this layer)
4. `e8` = conditional check opcode (HANDLED by interpreter)
5. `2f bf` = operand (state ID to check)
6. `ec` = block terminator (checks flag bD450)
7. `[more text]` = conditional text (displayed if condition matches)

## Game-Logic Bytecode: `fn0FDC_01C0` Opcodes (0xE4-0xFF)

### Opcode Dispatch Table

| Byte | Signed | Reko Case | Name | Operand | Description |
|------|--------|-----------|------|---------|-------------|
| `e4` | -28 | `~0x1B` | WRITE_CHAR | 1 byte | Read byte from buffer, write as character via `fn0800_19BF` |
| `e5` | -27 | `~0x1A` | ADD_CREDITS | 2 bytes (LE) | Add signed value to `tD370` (C-Bill credit counter). Uses `fn0FDC_19F6` for sign-extension. Calls `fn1631_1FDF` (state update). |
| `e6` | -26 | `~0x19` | SET_CURSOR_XY | 2×2 bytes (LE) | Set cursor X (`tA44B`) and Y (`tA44D`). Each is a 2-byte signed value from buffer. Uses `fn0FDC_19F6` for sign-extension. |
| `e7` | -25 | `65511` | CMP_CURSOR_X | 2 bytes (LE) | Read 2-byte value from buffer, compare with `tA44B` (current X coordinate). If NOT equal, skip next opcode. Conditional skip. |
| `e8` | -24 | `~0x17` | RNG_CHECK | 1 byte | Call `fn207F_0BC0` (RNG). Mask result with operand byte. If `(RNG() & operand) == 0`, skip next opcode. Random conditional. |
| `e9` | -23 | `~0x16` | CALL_ROOM_HANDLER | 1 byte | Read 1-byte operand, call `fn11B8_0D58` with it. Room/unit interaction handler. |
| `ea` | -22 | `~0x15` | COND_STATE_ACTION | 1 byte | Read byte operand, store in `bp-4`. If `w3938 == 0`, call `fn0800_48B7` (conditional state action, e.g., item purchase). |
| `eb` | -21 | `65515` | CHECK_FLAG_EB | 0 bytes | Check if `bD451 != 0`. If flag is 0, skip forward. |
| `ec` | -20 | `65516` | CHECK_FLAG_EC | 0 bytes | Check if `bD450 != 0`. If flag is 0, skip forward. |
| `ed` | -19 | `~0x12` | UNIT_CHECK_LOOP | 2 bytes | Read 2 operand bytes (byte1=index, byte2=threshold). Loop through 8 units checking `aC60F` state. If any unit matches, pass (no skip). |
| `ee` | -18 | `~0x11` | SPEND_CREDITS | 2 bytes (LE) | Read 2-byte signed value. Deduct from `tD370`. If `tD372` (credit high word) < 0 or (=0 and value > tD370), set all to 0. Calls `fn1631_1FDF`. |
| `ef` | -17 | `~0x10` | CHECK_CREDITS | 2 bytes (LE) | Read 2-byte signed value. Compare with `tD370`. If `tD372 < 0` or (`tD372 == 0` and value > `tD370`), skip next opcode (insufficient funds). |
| `f0` | -16 | `~0x0F` | SET_TEXT_MARGINS | 2 bytes | Read 2 operand bytes. Set `w3748` (left margin) from byte1, `w374E` (right margin) from byte2. |
| `f1` | -15 | `~0x0E` | ADD_TO_STATE | 2 bytes | Read 2 bytes: byte1=index into state array at `D30C`, byte2=value to add. `state[index] += value`. State array is indexed by byte from `DS:0x545C->bD30C` offset. |
| `f2` | -14 | `~0x0D` | ROOM_DESCRIPTION | 0 bytes | Call `fn1F3D_086A` to render room description text. |
| `f3` | -13 | `~0x0C` | SHOP_INTERACTION | 1 byte | Read 1 byte as index into state table `bD30C[index]`. Multiply by 2, use as offset into current buffer. Indirect dispatch. |
| `f4` | -12 | `~0x0B` | SET_STATE_VALUE | 2 bytes | Read 2 bytes: byte1=index into `D30C` state array, byte2=value to set. `state[index] = value`. |
| `f5` | -11 | `~0x0A` | SHOP_DISPATCH | 1 byte | Read 1 byte operand. Call `fn1CD3_0004` with it as the case number. Dispatches to the room interaction handler. |
| `f6` | -10 | `~0x09` | CHECK_CONDITION | 0 bytes | Call `fn0800_1A13(0x01)`. If returns 0 (condition false), skip forward. |
| `f7` | -9 | `~0x08` | STATE_COND_CHECK | 1 byte | Read 1 byte as index into `D30C` state array. If `state[index] != 0`, advance to next opcode. If 0, skip next byte. |
| `f8` | -8 | `~0x07` | JUMP_FORWARD | 0 bytes | Skip forward by 2 bytes from current position (relative jump). Used as "branch always" (GOTO). |
| `f9` | -7 | `~0x06` | JUMP_INDEXED | 1 byte | Read 1 byte operand. Call `fn1E56_0B5E(operand)` which returns a table index. Skip forward by `index * 2 + 2` bytes. Used for computed GOTO (e.g., menu selection). |
| `fa` | -6 | `~0x05` | DRAW_SPRITE | 1 byte | Read 1 byte sprite ID. Call `fn1E56_0004(operand)` to draw a sprite. |
| `fb` | -5 | `~0x04` | ADVANCE_INPUT | 0 bytes | Call `fn1F3D_0259` to advance text input/wait for key. |
| `fc` | -4 | `~0x03` | RENDER_TEXT | N bytes | **RENDER TEXT**. Calculate string offset from current buffer position. Call `fn1E56_03F5(string_ptr)` to display text with word wrapping. After call, advance past the string (uses `fn207F_3B9E` to get string length). |
| `fd` | -3 | `~0x02` | SET_FONT2 | 0 bytes | Call `fn1E56_0388` for font/display parameters. |
| `fe` | -1 | `~0x01` | SET_FONT | 1 byte | Read 1 byte font ID. Call `fn1E56_0281(font_id)` to set font. |
| `ff` | 0 | `~0x00` | EXIT | 0 bytes | Set exit flag to 1. **Stops the interpreter loop.** |

### Operand Encoding

All multi-byte operands are little-endian. Signed values use `fn0FDC_19F6` for sign extension.

### Conditional Skip Pattern

Many opcodes (E7, E8, EB, EC, EF, F6, F7) use a "skip on false" pattern:
- If condition passes: execution continues to next opcode/byte
- If condition fails: skip ahead (usually by 2 bytes, which skips a `f8` JUMP_FORWARD instruction)

This implements if-else branching:
```
e8 mask       ; if (RNG() & mask) {
  ...          ;   ...true branch...
f8             ;   goto end; (skip past else)
  ...          ; } else branch (the skipped-over text/opcodes)
               ; end:
```

## High-Level Dispatcher: `fn1CD3_0004` Cases

Called from `fn0FDC_01C0` (via opcode 0xF5) and other functions.
The argument `wArg04` selects the interaction type.

| Case | Name | Description |
|------|------|-------------|
| `0x01` | ENTER_BUILDING | Load building script data (~0x3959 bytes from segment 2FE8). Initialize viewport. Check `bD30E` for story-based variant. Render interior tiles. Set `bD55E` (building active). |
| `0x02` | SHOW_GREETING | Display room entry text. Check `bC724` (building type byte) for 0x4C or 0x57 to select greeting string. Call `fn1E56_03F5` with text offset. |
| `0x03` | EXIT_BUILDING | Clear building state (`bC724=0xFFFF`, `bC620=0x08`). Restore world coordinates (X=3118, Y=0xC076). Reset NPC sprites with status 0x7C. |
| `0x04` | SHOW_SHOP_ITEMS | Display 3 shop item names. Read from `aC618[loop] * 0x7D + 0x4B`. Format via `fn207F_3BB6`/`fn1F3D_00D5`. |
| `0x05` | BUY_ITEM_BUYER | Show purchase prompt. Check price from `aC618[bD314]`. If index=4 special. Deduct `price+75` from `tD370`. Increment item count. |
| `0x06` | SHOW_SELL_ITEMS | Check `w4FBA` flag. Display credits. Loop 3 inventory slots showing name/qty. `wE482` tracks count. If empty show "nothing to sell". |
| `0x07` | SELL_ITEM | Get item selection via `fn1E56_0B5E(0x07)`. Get quantity via `fn1543_0CDE`. Remove from `aD374/aD376`, add credits to `dwD370`. |
| `0x08` | BUY_ITEM_SELLER | Get item selection. Check stock. Get quantity. Remove from stock. Deduct cost. Display result. |
| `0x09` | HOSPITAL_HEAL | Read healing price from `w0178` or `w0168`. If affordable (check `tD372`/`tD370`): deduct cost, call `fn1631_1FDF` and `fn0FDC_13DE` to heal. |
| `0x0A` | SHOW_CREDITS | Format and display `tD370`/`tD372` (32-bit credit value). Set `t37FE` flag. |
| `0x0B` | BUY_QUANTITY | Purchase with quantity tracking. Read base price. Apply modifiers for bulk (0x06 or 0x09). If affordable: deduct, call `fn0FDC_15E6` (increment count). |
| `0x0C` | CLOSE_ACTION | Single call to `fn0FDC_17B9`. Return to prior menu. |
| `0x0D` | SHOW_INVENTORY | Recursively call case 0x0E to count items. Loop 8 slots reading item names from string table. Call `fn1E56_0B5E(0x17)` for selection. |
| `0x0E` | COUNT_INVENTORY | Count non-empty inventory slots. Set `bD31A` to count. |
| `0x0F` | EQUIP_SLOT5 | Deduct 500 credits. Increment `aC618[5][bD31A]`. Set bit 0x01 in `bC623[1][bD31A]`. Equipment installation. |
| `0x10` | CHECK_EQUIP_SLOT5 | Test bit 0x01 of `bC623[1][bD31A]`. Store in `bD31B`. |
| `0x11` | COUNT_PARTY | Count active party members in `bC724[0..3]`. |
| `0x12` | DRAW_INTERIOR | Call `fn11B8_0002` to render interior map. |
| `0x13` | DRAW_INTERIOR2 | Call `fn11B8_080A` (alternate render path). |
| `0x14` | DRAW_INTERIOR3 | Call `fn11B8_0925` (alternate render path). |
| `0x15` | EQUIP_SLOT6 | Check `tD370 >= 500`. Deduct 500. Increment `aC618[6][bD31A]`. Set bit 0x02 in `bC623[1][bD31A]`. |
| `0x16` | CHECK_EQUIP_SLOT6 | Test bit 0x02 of `bC623[1][bD31A]`. |
| `0x17` | CHECK_UNEQUIPPED | Loop 8 slots. If `item_quality*10 != status_byte`, set `bD325=1`. Detect unequipped items. |
| `0x18` | REPAIR_SERVICE | If `bD326==0`: show repair screen via `fn1431_000A(0)`. Else: read cost from array, deduct, call `fn1431_000A(bD326)` to repair. |
| `0x19` | FLAG_D450 | Set `bD450 = 1`. Story progression: training complete marker. |
| `0x1A` | FLAG_D451 | Set `bD451 = 1`. Story progression: milestone marker. |
| `0x1B` | RESET_BUILDING | Jump to shared cleanup (reset building data, call `fn1467_0002`). |
| `0x1C` | STORE_PARTY | Save `bC724[i]` to backup slots. Clear active slots. Set animation states. |
| `0x1D` | COUNT_STORED | Count saved party members (char codes 0x41-0x5A). |
| `0x1E` | DRAW_INTERIOR4 | Call `fn11B8_104E` (alternate render path). |
| `0x1F` | GET_ITEM_PROP | Read `bC620[1][bD31A]`. Store in `bD32B`. |
| `0x20` | RELOAD_AMMO | Compare current vs max ammo. If full: show message. Else: calculate needed qty and price. Show confirmation. Deduct credits. Update state. |
| `0x21` | GAME_ACTION_1 | Call `fn0FDC_1C9B`. |
| `0x22` | GAME_ACTION_2 | Call `fn0FDC_1A26`. |
| `0x23` | NEW_GAME_INIT | Full game initialization. Clear state, load character templates from template table, set party, init graphics, render 3x3 character grid. |
| `0x24` | GET_ITEM_BY_INDEX | Read `bC614[bD331]` (item at character index). Fallthrough to case 0x26. |
| `0x25` | CLEAR_INVENTORY | Set `w014A=0`, `bC614=-1`. |
| `0x26` | SHOW_ITEM_NAME | Display item name/description from string table using `bD456` or `bD314` as index. |
| `0x27` | TRIGGER_ACTION | Call `fn1467_0002(0x01)`. Mode trigger. |
| `0x28` | FINALIZE_TRANSACTION | Call `fn11B8_152F` for state update. Set `bD334` flag. Post-service cleanup. |
| `0x29` | COMBAT_HEAL | If party present: apply RNG damage (12-13 HP). If solo: show recruitment message. Confirm via `fn0800_1A13`. Apply RNG healing. |
| `0x2A` | SAVE_POSITIONS | Save X to `0x4024`/`wD390`, Y to `0x4056`/`wD392`. 8 unit slots. |
| `0x2B` | RESTORE_POSITIONS | Restore X/Y from saved arrays. 8 unit slots. |
| `0x2C` | DRAW_INTERIOR5 | Call `fn11B8_1762` (alternate render path). |
| `0x2D` | COMBAT_ENCOUNTER | Init/resolve combat. Set graphics params. If `w4FBA==0`: transition to combat. If `w4FBA==2`: battle in progress. If `w4FBA==3`: victory handling. |
| `0x2E` | RESET_ROOM | Restore NPCs from backup, clean up, call `fn1467_0002(0x00)`. |
| `0x2F` | DECREMENT_COUNTER | If `bC623 > 0x05`, subtract 0x04. Timer/counter decrement. |

## Text Encoding

Text bytes use a substitution cipher (see CONTEXT.md section 4 for the complete table):
- Ranges: 0x57-0x5F, 0x60, 0x61-0x7F (except 0x6B), specific 0x80-0x96 values
- 0xA0 = space separator
- 0x6B = control byte (not text)

## Memory Map for State Variables

| Address | Name | Type | Description |
|---------|------|------|-------------|
| `DS:0x3748` | `w3748` | word | Text left margin (set by opcode F0) |
| `DS:0x374E` | `w374E` | word | Text right margin (set by opcode F0) |
| `DS:0x3938` | `w3938` | word | General state flag |
| `DS:0x4024` | `a4024` | 8 words | Unit X position saves (case 0x2A) |
| `DS:0x4056` | `a4056` | 8 words | Unit Y position saves (case 0x2A) |
| `DS:0x4584` | `t4584` | word | BLD file index/selector |
| `DS:0x545C` | main state | struct | Main game state structure |
| `DS:0x545C->bD30C` | `bD30C` | byte | Room/building type index |
| `DS:0x545C->bD30E` | `bD30E` | byte | Story state variant (0=normal, 2=post-attack) |
| `DS:0x545C->bD310` | `bD310` | byte | Special mode flag |
| `DS:0x545C->bD314` | `bD314` | byte | Selected item index |
| `DS:0x545C->bD315` | `bD315` | byte | Item purchase in progress |
| `DS:0x545C->bD316` | `bD316` | byte | Hospital healing tier |
| `DS:0x545C->bD317` | `bD317` | byte | Healing applied flag |
| `DS:0x545C->bD318` | `bD318` | byte | Bulk purchase modifier |
| `DS:0x545C->bD31A` | `bD31A` | byte | Selected inventory slot |
| `DS:0x545C->bD31B` | `bD31B` | byte | Equip status result |
| `DS:0x545C->bD31C` | `bD31C` | byte | Party member count |
| `DS:0x545C->bD325` | `bD325` | byte | Unequipped items flag |
| `DS:0x545C->bD326` | `bD326` | byte | Repair target index |
| `DS:0x545C->bD32B` | `bD32B` | byte | Item property byte |
| `DS:0x545C->bD32F` | `bD32F` | byte | New game vs loaded flag |
| `DS:0x545C->bD334` | `bD334` | byte | Post-service flag |
| `DS:0x545C->bD33C` | `bD33C` | byte | Building state flag |
| `DS:0x545C->bD33E` | `bD33E` | byte | Building exit flag |
| `DS:0x545C->bD342` | `bD342` | byte | Special action flag |
| `DS:0x545C->bD450` | `bD450` | byte | Story flag 1 (training complete) |
| `DS:0x545C->bD451` | `bD451` | byte | Story flag 2 |
| `DS:0x545C->bD452` | `bD452` | byte | Party member assignment |
| `DS:0x545C->bD456` | `bD456` | byte | Item display index |
| `DS:0x545C->bD55E` | `bD55E` | byte | Building active flag |
| `DS:0x545C->tD370` | `tD370` | dword | C-Bill credits (low word) |
| `DS:0x545C->wD372` | `wD372` | word | C-Bill credits (high word, signed) |
| `DS:0x545C->wD390` | `wD390` | 8 words | Unit X save array |
| `DS:0x545C->wD392` | `wD392` | 8 words | Unit Y save array |
| `DS:0x545C->aD374` | `aD374` | array | Shop inventory item IDs |
| `DS:0x545C->aD376` | `aD376` | array | Shop inventory quantities |
| `DS:0x545C->wD394` | `wD394` | word | Saved position backup |
| `DS:0x545C->wD396` | `wD396` | word | Saved position backup |
| `DS:0x545C->bD398` | `bD398` | byte | Unit status byte (0x77=active, 0x70=stored) |
| `DS:0x545C->bD399` | `bD399` | byte | Unit ID assignment |
| `DS:0x545C->aC60F` | `aC60F` | 8 bytes | Character type/skill array |
| `DS:0x545C->aC614` | `aC614` | 8×17 bytes | Inventory slots (17 bytes each) |
| `DS:0x545C->aC618` | `aC618` | array | Shop item price/stock array |
| `DS:0x545C->bC61F` | `bC61F` | byte | Item recruit flag |
| `DS:0x545C->bC620` | `bC620` | 8 bytes | Item state array |
| `DS:0x545C->bC623` | `bC623` | array | Item equip status bytes |
| `DS:0x545C->bC664` | `bC664` | 4 bytes | NPC animation state |
| `DS:0x545C->bC724` | `bC724` | 4 bytes | Active party member IDs |
| `DS:0x545C->bC79D` | `bC79D` | byte | Building init flag |
| `DS:0x545C->bC79F` | `bC79F` | byte | Building variant flag |
| `DS:0x5460` | `_5460` | word | BLD file type table base |
| `DS:0x5464` | `_5464` | word | State flag |
| `DS:0x5466` | `_5466` | byte | Sub-action flag |
| `DS:0x5468` | `w3748` | word | Text left margin (also at 0x3748) |
| `DS:0xA44B` | `tA44B` | word | Cursor/unit X coordinate |
| `DS:0xA44D` | `tA44D` | word | Cursor/unit Y coordinate |
| `DS:0xD30C` | `bD30C[]` | byte[] | State array base (indexed by opcodes F1, F4, F7) |
| `DS:0xD370` | `tD370` | dword | Credit counter (also at 545C->tD370) |
| `DS:0xE482` | `wE482` | word | Shop item count |
| `DS:0xE484` | `wE484` | word | Story progression flag |
| `DS:0xE48E` | `wE48E` | word | New game init flag |
| `DS:0x4FBA` | `w4FBA` | word | Combat mode (0=peaceful, 2=battle, 3=victory) |
| `DS:0x4FBC` | `w4FBC` | word | Combat state flag |

## Narrative Opcodes

These opcodes are NOT handled by `fn0FDC_01C0` (they enter the switch but
match no cases). They are processed at the higher level in callers
(`fn0FDC_0008`, `fn1CD3_0004`, etc.) as narrative mode switches.

| Byte | Count | Description |
|------|-------|-------------|
| `9e` | 924 | Narrative/description (third-person). Mode switch for text display. |
| `9c` | 741 | Character speech continuation. Appends dialogue text. |
| `9b` | 128 | Player internal thought. |
| `9f` | 97 | Player-directed thought ("you feel/think"). |
| `a5` | 386 | Sentence continuation. Lowercase append. |
| `bb` | 424 | Menu option separator. |
| `aa` | 63 | Menu option marker. |

## File-by-File Summary

| File | Bytes | Para | Type | Description |
|------|-------|------|------|-------------|
| TRAINING.BLD | 7282 | 28 | dialogue | Main training + Citadel attack story |
| HUT.BLD | 8501 | 33 | dialogue | Tellhim's holographic puzzle gauntlet |
| WEAPON.BLD | 5850 | 22 | shop | Weapon shop with multiple categories |
| MAYOR.BLD | 5896 | - | dialogue | Mayor's house: newspaper, holodisk, escape |
| PARTY.BLD | 6207 | - | dialogue | Kuritan party, Rex rescue |
| JAIL.BLD | 4297 | - | dialogue | Internment center, Stinger rescue |
| CITADEL.BLD | 4330 | 16 | dialogue | Citadel attack + menu interactions |
| HOSPITAL.BLD | 4581 | - | shop | Medical services, MedKits, surgery |
| REPAIR.BLD | 4983 | - | shop | Mech repair, tech recruitment |
| ARMOR.BLD | 3388 | - | shop | Armor shop: vests, suits |
| FROB.BLD | 3548 | - | dialogue | Holographic face puzzle |
| VIEWDISK.BLD | 3544 | 13 | dialogue | Jeremiah's holodisk (damaged) |
| ARENA.BLD | 3957 | - | shop | Mech combat arena |
| WINSCENE.BLD | 2995 | 11 | endgame | Hyperpulse generator, ending |
| BARRACKS.BLD | 2990 | - | dialogue | Cadet barracks |
| LOUNGE.BLD | 1827 | - | dialogue | Rick Atlas conversation |
| WEAPON2.BLD | 1738 | 6 | shop | Weapon shop robbery |
| GARAGE.BLD | 1686 | - | shop | Mech parking |
| THEATER.BLD | 1132 | - | dialogue | Theater entertainment |
| ENDMECH.BLD | 1022 | - | dialogue | End game mech sequence |
| CLOTHES.BLD | 915 | - | shop | Clothes shop |
| ENTRANCE.BLD | 794 | 3 | shop | Star League cache entrance |
| FINDIT.BLD | 722 | 2 | dialogue | World map clue search |
| INSTRUCT.BLD | 565 | 2 | dialogue | Jeremiah's cache instruction note |
| BARRACK2.BLD | 362 | 1 | dialogue | Destroyed barracks, holodisk player |
