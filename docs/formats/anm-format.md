# ANM Animation File Format

## Overview

22 files: O0.ANM through O21.ANM in `original/anm/`. 88×88 pixel EGA animations
using XOR-delta RLE compression. Only O0.ANM-O15.ANM (16 files) are referenced
by the game binary — O16-O21 are beyond the expected range (cut content / unused).

## Header Structure (0x00-0x32 = 51 bytes)

| Offset | Size | Field | Description |
|--------|------|-------|-------------|
| 0x00   | 1    | Type  | ASCII identifier byte (0x41='A' most common, also 0x42-0x47) |
| 0x01-0x1F | 31 | Padding | Zeros for O17-O20, ASCII alphabet sequence for active files |
| 0x20-0x31 | 18 | Filler | 0x01 bytes |
| 0x32   | 1    | Flag  | **0x01** = active animation, **0x00** = unused/placeholder |

Data always starts at offset 0x33 regardless of type.

## File Status by Index

| Index | File | Frames | 0x32 | Status |
|-------|------|--------|------|--------|
| 0-15  | O0-O15.ANM | 2-56 | ≥0x06 | **Active** — used by game |
| 16    | O16.ANM    | 20    | 0x08 | Active but beyond game table |
| 17-20 | O17-O20.ANM | 0*   | 0x00 | **Unused** — partial frames |
| 21    | O21.ANM    | 0     | —    | Corrupted (hex dump text) |

\* O17-O20 contain valid XOR-delta RLE data but files are too small for a full
frame (78-95% decompressed). Non-zero content visible at top with black bottom.

## Compression: XOR-Delta RLE

### Command Format

| Condition | Encoding | Meaning |
|-----------|----------|---------|
| `byte > 0` | `count` then N distinct bytes | Copy `count` literal bytes |
| `byte < 0` | `-count` then 1 repeated byte | Repeat byte `count` times |
| `byte == 0` | `0x00` then `WORD` (LE) then 1 byte | Repeat byte `WORD` times |

### Decompression

Buffer size: `0x0F20` (3872 bytes) = 88×88 pixels / 2 nibbles per byte.

Each decompressed byte is **XORed** against the running decoded buffer
(`buffer[i] ^= byte`). This is a delta encoding — frame N+1 stores only the
difference from frame N.

### Pixel Conversion (Write2Mode)

Each byte of decompressed data → 2 pixels:
- High nibble = pixel at position `i*2`
- Low nibble = pixel at position `i*2+1`

Result: 3872 bytes → 7744 pixels = 88×88 pixels.

## EGA Palette

Standard 16-color EGA palette (see `EGA.cs` or `Palette.cs`).

## Game Binary References

| Location | Content | Description |
|----------|---------|-------------|
| `3EDB:0AC0` | `"ANM\0" 03 00 0F 00 3F 00 "BDC\0"` | File type table — ANM max index = 15 |
| `3EDB:1E90` | `03 03 "O0.ANM\0"` | Weapon shop ammo buy UI |
