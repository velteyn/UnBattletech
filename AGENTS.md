# Agent Instructions — BattleTech CHI Rebuild

## Build & Run

```bash
# Build C# (fast, catches compile errors)
cd BattleTechCHI && dotnet build

# Build + Run Godot editor (headless via xvfb)
cd BattleTechCHI && bash run.sh

# Build only (via script)
cd BattleTechCHI && bash build.sh
```

## Godot Binary

Installed at `~/.local/bin/godot`. The Mono (C#) version requires a display
server — use `xvfb-run` on headless systems.

Project uses Godot 4.4 (.NET SDK 4.4.0, net8.0).

## Architecture

- **Core/** — GameLoop, StateManager, InputHandler, SaveManager
- **Data/** — GameEnums, GameState, DataModels, WeaponData, CipherDecoder
- **Maps/** — MapLoader, RleDecompressor, TileManager, WorldMapData, WorldMapView, LocalMapView
- **BLD/** — BldLoader, BldInterpreter, Fn1CD3Dispatcher
- **UI/** — EgaPalette, BorderPanel, StartupSequence, ShopScreen
- **Runner/** — Standalone test console app (not part of Godot build)

## Fn1CD3Dispatcher Case Mapping (CORRECT, verified vs decompiled C)

| Case | Name | Description |
|------|------|-------------|
| 0x01 | ENTER_BUILDING | Load building BLD, init viewport |
| 0x02 | SHOW_GREETING | Display entry text |
| 0x03 | EXIT_BUILDING | → WorldMap |
| 0x04 | SHOW_SHOP_ITEMS | Populate C618 slots (StateArray 0x18-0x1A) from shop strategy |
| 0x05 | BUY_ITEM_SINGLE | C618[sel]++ (price = old_type * 125 + 75), rotate to next type |
| 0x06 | SHOW_PLAYER_ITEMS | Find owned items, populate C618[0..2] for sale UI |
| 0x07 | BUY_ITEM_BULK | Buy via strategy (GetBuyPrice) |
| 0x08 | SELL_ITEM_BULK | Sell via strategy (GetSellPrice) |
| 0x09 | HOSPITAL_HEAL | Heal 4 units, cost 50cr |
| 0x0A | SHOW_CREDITS | Print credit balance (UI handles display) |
| 0x0B | BUY_WITH_UNIT_SEL | Buy + select unit slot (bD31A) |
| 0x0C | CLOSE_ACTION | Returns null (no mode change) — BLD script continues |
| 0x0D | EQUIPMENT_MENU | Reset bD31A to 0 |
| 0x0E | COUNT_UNIT_SLOTS | Count active units → bD31A |
| 0x0F | EQUIP_SLOT5 | 500cr → equip slot 5 |
| 0x10 | CHECK_EQUIP_SLOT5 | Query slot 5 flag → bD31B |
| 0x11 | COUNT_STORY_SLOTS | Count stories → bD31C |
| 0x12-14 | DISPATCH_11B8_* | Rendering stubs (handled by Godot) |
| 0x15-16 | EQUIP/CHECK_SLOT6 | Same as 5 but slot 6 |
| 0x17 | EQUIP_CONSISTENCY | Verify equip state |
| 0x18 | GARAGE_SERVICE | 100cr service |
| 0x19-1A | FLAG_D450/D451 | Set training/milestone flags |
| 0x2D | COMBAT_ENCOUNTER | → Combat |
| 0x2F | DECREMENT_STATE | StateArray[0x23] -= 4 if > 5 |

**Critical**: Cases 0x0A-0x2F were previously misassigned by 2+ positions
(starting at 0x0A = RepairMech when it should be ShowCredits). Fixed in
this session (2026-06-08).

## BLD Format Notes

### File Layout

```
0x00-0x07: Header (8 bytes)
  [0] file_type  [1] paragraph_count  [2-5] signature (ee c6 eb ea)  [6-7] content_type
0x08-0x9F: Raw (unencrypted) bytecode — processed directly with CipherDecoder
0xA0+:     Encrypted bytecode — decrypted by BldLoader via ((b+41)&0xFF)^233
```

**CRITICAL**: `InterpreterBase = 8` (not 0xA0). The BLD script starts right after the
8-byte header. The pre-0xA0 region contains valid opcodes (e.g. CHECK_FLAG_EC at
offset 0x0B in many shop BLDs) and cipher text. Setting base to 0xA0 skips ALL
content in 0x08-0x9F, breaking every BLD script.

### Byte Ranges (AFTER decryption for 0xA0+; raw cipher text for 0x08-0x9F)

| Range | Type | Description |
|-------|------|-------------|
| 0x00-0x7F | Cipher text | Passed through `CipherDecoder.DecodeByte()` |
| 0x80-0xC3 | Narrative markers | `0x9E`=ThirdPerson, `0x9C`=CharacterSpeech, `0x9B`=PlayerThought, `0x9F`=PlayerAction, `0xA5`=Continuation, `0xA0`=Space, `0xBA`=RParen |
| 0xC0 | Separator | Structural separator, skipped |
| 0xE4-0xFF | Opcodes | See `BldOpcode` enum |

### Key Opcodes

- `0xF5` = SHOP_DISPATCH — next byte = case number (0x01-0x2F)
- `0xF9` = JUMP_INDEXED — computed GOTO via fn1E56_0B5E
- `0xEC` = CHECK_FLAG_EC — reads word target; jumps there if TrainingComplete
- `0xEB` = CHECK_FLAG_EB — reads word target; jumps there if Milestone

### BLD files location

`../../../*.BLD` relative to project root (i.e., repository root).
