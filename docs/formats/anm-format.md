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

Frame counts below are from the **verified decoder** (2026-09-29) — decode the stream in `0xF20`-byte
frames until exhausted. (Earlier counts in `AGENTS.md` were unverified guesses.)

| Index | File | Frames | Status |
|-------|------|--------|--------|
| 0 | O0.ANM | 19 | Active (empty-cockpit view) |
| 1 | O1.ANM | 15 | Active |
| 2 | O2.ANM | 30 | Active (pilot portrait) |
| 3 | O3.ANM | 13 | Active |
| 4 | O4.ANM | 14 | Active |
| 5 | O5.ANM | 9 | Active (pilot portrait + walking figure) |
| 6 | O6.ANM | 32 | Active |
| 7 | O7.ANM | 7 | Active (infantry rifleman) |
| 8 | O8.ANM | 4 | Active (tower/mast) |
| 9 | O9.ANM | 13 | Active (**mech stomping a downed pilot/wreck**) |
| 10 | O10.ANM | 6 | Active |
| 11 | O11.ANM | 7 | Active (spacecraft / starfield) |
| 12 | O12.ANM | 12 | Active (blonde-woman portrait) |
| 13 | O13.ANM | 4 | Active (blue-haired pilot portrait) |
| 14 | O14.ANM | 10 | Active (spacecraft / starfield) |
| 15 | O15.ANM | 7 | Active (banner/emblem) |
| 16 | O16.ANM | 8 | Structurally valid; **outside the game's `0…0x0F` table** |
| 17-20 | O17-O20.ANM | 2 each | Placeholder (decode to ~1 frame) |
| 21 | O21.ANM | 1 | Corrupted (hex-dump text) |

## Compression: XOR-Delta RLE

### Command Format

| Condition | Encoding | Meaning |
|-----------|----------|---------|
| `byte > 0` | `count` then N distinct bytes | Copy `count` literal bytes |
| `byte < 0` | `-count` then 1 repeated byte | Repeat byte `count` times |
| `byte == 0` | `0x00` then `WORD` (**big-endian**) then 1 byte | Repeat byte `WORD` times |

> ⚠️ **Corrected 2026-09-29 (verified against the binary).** The extended count is **big-endian**
> (`mov ax,[si]; xchg al,ah`), *not* little-endian as previously written. Getting this wrong blows up
> run lengths (e.g. `05 FE` → 65029 instead of 1534) and desyncs the whole animation.

### Decompression

Buffer size: `0x0F20` (3872 bytes) = 88×88 pixels / 2 nibbles per byte.

Each decompressed byte is **XORed** against the running decoded buffer
(`buffer[i] ^= byte`). This is a delta encoding — frame N+1 stores only the
difference from frame N.

**Verifier:** the decoder is the routine at **`1000:AC12`** (file offset-derived phys `0x1AC12`;
Reko/Spice86 label `1000:C312`, aliased `19EF:245C`). One call decodes exactly **one frame** of
`0xF20` bytes into `ES:DI`, reading from the source pointer and returning the number of input bytes
consumed in `AX = SI+1 - [0xB78A]` — the caller advances the source pointer by that and loops for the
next frame. The exact loop (`r2` @ `0x1AC12`):

```
mov dx,0xF20                    ; AC12  output bytes per frame
AC15: xor bx,bx                 ; bx=0 → literal mode
      xor ax,ax ; mov al,[si]   ; control byte
      or al,al
      je  AC09                  ; 0x00 → extended
      jns AC24                  ; positive → literal
      neg al ; dec bx           ; negative → repeat (bx=0xFFFF)
AC24: mov cx,ax                 ; run count
AC26: inc si ; mov al,[si]      ; literal: next data byte each iter
AC29: xor es:[di],al            ; XOR delta; di++; dx--
      ... je AC3E (frame full)  ; or bx≠0 → loop AC29 (repeat same byte)
      ... loop AC26/AC29 ; inc si ; jmp AC15
AC3E: ret (AX = consumed)
AC09: inc si ; mov ax,[si] ; xchg al,ah ; inc si ; jmp AC23   ; extended: BIG-ENDIAN count
```

A frame ends the instant `DX` reaches 0 (runs are frame-aligned). Verified decoder output matches the
binary: **O0 = 19 frames**, etc.

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
| `0000:48B7` (r2 phys `0x48B7`) | `mov es,[0x53FE]; mov byte es:[0x12],'O'` | **ANM player** `play_anm(index, mode)` — builds `"O<index>.ANM"`, loads it, loops decode+blit |
| `1000:AC12` (r2 phys `0x1AC12`) | `mov dx,0xF20` … `xor es:[di],al` | per-frame decoder (see above) |

> **Triggers** (who calls `play_anm`): combat post-fire calls **`O16` (0x10)** and **`O5` (0x5)**;
> building/room interiors call it via the room push/pop path (`0FDC:1C9B`/`1A26`); intro/platform
> init calls it with other indices. See [`../combat-system.md`](../combat-system.md) §28.1a.
