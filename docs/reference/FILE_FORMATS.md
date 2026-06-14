# File Formats — BattleTech: CHI

Single authoritative reference for all game file formats.

## Contents

- [RLE Compression](#rle-compression)
- [.CMP (Compressed Images)](#cmp-compressed-images)
- [.ICN (Icon/Tile Files)](#icn-icon-tile-files)
- [.MTP (Map Files)](#mtp-map-files)
- [.BLD (Building Data / Scripts)](#bld-building-data--scripts)
- [.ANM (Animation Files)](#anm-animation-files)
- [Save Files](#save-files)
- [Mech Data Format](#mech-data-format)

---

## RLE Compression

Two formats used across CMP, ICN, and ANM files.

**Format 0x01** (row-major): Non-zero byte = literal run length; zero byte = extended run (next 2 bytes = 16-bit run length + 1 data byte). Used for full-screen images (BTTITLE, INFOCOM, ENDMECH).

**Format 0x02** (column-major): Same RLE scheme but column-oriented. Used for sprite sheets (MECHSHAP) and tile sets (BTBORDER).

RLE output = 32000 bytes (320x200, 4-bit nibbles) → converted to 1 byte/pixel.

**ANM format**: XOR-based delta decompression with accumulative frames.

---

## .CMP (Compressed Images)

- **Header**: 3 bytes (2-byte little-endian size + 1-byte format)
- **Output**: EGA planar, 4 bit-planes (B/G/R/I), scanline-interleaved or full-plane modes

Files: BTTITLE, INFOCOM, ENDMECH, BTSTATS, MECHSHAP, BTBORDER.

---

## .ICN (Icon/Tile Files)

- Same header structure as .CMP but 16-pixel-wide strips
- Contains 16x16 pixel tiles for maps
- Tilesets: MAP.ICN (~94 tiles), BTTLTECH.ICN, ANIMATE.ICN, STARLEAG.ICN, DESTRUCT.ICN

---

## .MTP (Map Files)

### MAP1-MAP14 (Standard)
- **Header**: 3 bytes header + MapSizeX/Y + 0x80 bytes NPC names + 0x100 bytes building names + variable blocks
- **BlockFormat** (maps 1-2): 8x8 block-encoded tile data
- **LinearFormat** (maps 3-10): Linear block-encoded tile data

### MAP15 (STARMAP)
- Special 32x24 map, linear format

### Identified Maps
| File | Location | Format |
|------|----------|--------|
| MAP1.MTP | Training Center / Citadel | BlockFormat |
| MAP2.MTP | Main City / Arena | BlockFormat |
| MAP3-10.MTP | Various settlements | LinearFormat |
| MAP11.MTP | Destroyed Training Center | BlockFormat |
| MAP14.MTP | Cave / Underground | BlockFormat |
| MAP15.MTP | Star Map | LinearFormat |

---

## .BLD (Building Data / Scripts)

For complete BLD bytecode opcode reference, see [BLD_BYTECODE.md](BLD_BYTECODE.md).

### File List
26 files at `../../../*.BLD`: TRAINING, CITADEL, BARRACKS, BARRACK2, COMSTAR, FINDIT, FROB, GARAGE, HOSPITAL, HUT, INSTRUCT, JAIL, LOUNGE, MAYOR, PARTY, REPAIR, THEATER, VIEWDISK, WEAPON, WEAPON2, WINSCENE, CLOTHES, ARMOR, ENTRANCE, ARENA, ENDMECH.

### File Layout
```
0x00-0x07: Header (8 bytes)
  [0] file_type  [1] paragraph_count  [2-5] signature (ee c6 eb ea)  [6-7] content_type
0x08-0x9F: Raw (unencrypted) metadata / cipher text — NOT bytecode
0xA0+:     Encrypted data — decrypted via ((b+41)&0xFF)^233, then processed as bytecode + cipher text
```

### Content Types
- `c0 ec` = dialogue/story
- `c0 f5` = shop/service
- `c0 f4` = special
- `c0 da` = endgame

### Cipher Table
All dialogue text uses a substitution cipher:

| Range | Bytes | Maps To |
|-------|-------|---------|
| 0x57-0x5F | 57 58 59 5A 5B 5C 5D 5E 5F | i h k j m l o n a |
| 0x60 | 60 | q |
| 0x61-0x76 | 61 62 63 64 65 66 67 68 69 6A 6C 6D 6E 6F 70 71 72 73 74 75 76 | c b e d g f y x i z l m n o p s r u t w v |
| 0x77-0x7F | 77 78 79 7A 7B 7C 7D 7E 7F | I H K J M L O N A |
| 0x80-0x96 | 81 82 83 84 85 86 87 90 91 92 93 94 95 96 | C B E D G F Y P S R U T W V |

Note: 0x6B is a control byte (not text). 0xA0 is space. Original 1988 typos like "eouipment" for "equipment" are game typos, not cipher errors.

### Narrative Mode Markers
- `0x9E` = ThirdPerson
- `0x9C` = CharacterSpeech
- `0x9B` = PlayerThought
- `0x9F` = PlayerAction
- `0xA5` = Continuation

### Decryption
```
decrypted[0xA0 + bx] = ((raw[0xA0 + bx] + 41) & 0xFF) ^ 233
```

### Interpreter Architecture
```
Layer 1: fn0FDC_0008  — Loads BLD data by index, prepares buffer
Layer 2: fn0FDC_01C0  — Bytecode interpreter (opcodes 0xE4-0xFF)
Layer 3: fn1CD3_0004  — Room/building interaction dispatcher (47 cases)
Layer 4: fn1E56_03F5  — Text renderer with word-wrapping
```

---

## .ANM (Animation Files)

- 22 files: O0.ANM - O21.ANM
- Fixed width: 88 pixels
- Start position at 0x33
- Size from first 2 bytes
- XOR-based delta decompression (accumulative frames)

---

## Save Files (No Extension)

Binary save format structure:
- 8 player infantry characters + 8 enemy infantry (17 bytes each)
- 4 lance mech slots + 4 enemy mech slots (125 bytes each)
- Map visibility (2048 bytes, bit-packed 128x128)
- Mission flags (CitadelMission, CitadelKatrinaVisit)
- Finance: C-Bills + stock values (DasHas, Nasdiv, BakPhar)
- Position: map X/Y coordinates

---

## Mech Data Format

125 bytes per 'Mech, stride 0x7D:

| Offset | Size | Field | Description |
|--------|------|-------|-------------|
| +0x00 | 16 | Name | ASCIIZ, null-padded |
| +0x10 | 1 | Tonnage | uint8 |
| +0x11 | 11 | CurrentArmour[11] | Per location |
| +0x1C | 8 | CurrentStructure[8] | Per location |
| +0x24 | 4 | CurrentActuators[4] | Per location |
| +0x28 | 1 | EngineHeatSinks | Count |
| +0x29 | 10 | CurrentAmmo[10] | Ammo bins |
| +0x33 | 1 | WalkMove | Walk MP |
| +0x34 | 1 | JumpMove | Jump MP |
| +0x35-0x57 | - | Criticals[8 locations] | Slot damage tracking |
| +0x58 | 11 | MaxArmour[11] | Template maximums |
| +0x63 | 8 | MaxStructure[8] | Template maximums |
| +0x6B | 4 | MaxActuators[4] | Template maximums |
| +0x6F | 10 | MaxAmmo[10] | Template maximums |
| +0x79 | 4 | Unknown[4] | Padding |
