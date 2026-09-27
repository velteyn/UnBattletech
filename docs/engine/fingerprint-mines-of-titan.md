# Engine Fingerprint: BattleTech CHI vs Mines of Titan

> First cross-binary fingerprint of the shared Westwood engine
> (see `docs/engine/README.md`). Both are Westwood Associates titles:
> BattleTech: The Crescent Hawk's Inception (1988) and Mines of Titan (1989).

## Inputs

| Binary | Source | Size | SHA-256 |
|--------|--------|------|---------|
| `UNBTECH.exe` | BattleTech CHI (unpacked from `BTECH.EXE` via `exepack.exe`) | 260528 | `e29007761fadd8679521d1fb1dc6b488f87c718ed8a4636cb4ffbe4bc4ed5306` |
| `TITAN.EXE` | Mines of Titan 1989 (authentic DOS, PLINK86 overlays) | 108192 | `603e7bab65dd29772d51e95715e156ffc8e662685d26764c867fb0a0939b37a5` |

Sibling binaries are kept locally under `original/siblings/` (gitignored).

## Packing status (checked before trusting the fingerprint)

Archive.org DOS releases are often EXEPACK-packed, so each binary was checked:

| Binary | Packed? | Evidence |
|--------|---------|----------|
| `BTECH.EXE` (BattleTech) | **Yes (EXEPACK)** | `exepack.exe -d BTECH.EXE out.exe` reproduces `UNBTECH.exe` byte-for-byte (sha256 `e2900776…`) |
| `TITAN.EXE` (Mines of Titan) | **No** | `exepack.exe` refuses it ("relocations before decompression are not supported"); readable strings; data tables byte-identical to BattleTech's |

**Unpack procedure**: `wine BATTLETECH_CHI/exepack.exe -d IN.EXE OUT.EXE` (the tool both packs and unpacks;
it errors out on non-EXEPACK files). BattleTech was unpacked this way; Mines of Titan needs no unpacking.
(Archive note: item `msdos_Mars_Saga_1988` is mislabeled — it contains Mines of Titan; the `0MHz` `.vhd`
holds the same files under `\MARSSAGA\`.)

## First shared run is engine DATA, not code

The largest run (`UNBTECH 0x1FBB5` / `TITAN 0xEF7B`, 299 bytes) is a repeating lookup table —
`00 00 00 00 01 01 01 01 … 0f 0f 0f 0f` (each colour value repeated 4×), preceded by
`08 09 0a 0b`/`0c 0d 0e 0f` runs and followed by `00 01 02 03`. This is an **EGA planar
expansion / colour-index table** in the renderer — shared engine data, confirming the engine
hypothesis independent of any code match.

## Identified shared engine routines (rendering segment 207F)

Relocation-normalised matching plus a Reko cross-reference identified the first shared
engine **code** (all in the rendering segment **207F**):

| Routine | Evidence | Role |
|---------|----------|------|
| VGA write-mode-2 blitter — `UNBTECH 0x1BF0C` ↔ `TITAN 0x37EA` (Reko `fn207F_0313` family) | `mov dx,0x3CE; mov ax,0x0205; out dx,ax` (GC mode 5 = **write mode 2**), `mov ax,8; out dx,ax` (bit-mask 0), stride `0x140`=320, `DS=0xA800` | Mode-13h sprite/tile blitter |
| 2-bit mask expansion — `UNBTECH 0x1C633` ↔ `TITAN 0x36C8` (Reko `207F:0A49`) | `mov dx,0xF00F`, masks `0xC0/0x30/0x0C/0x03`, `not al; stosb` | Write-mode-2 pixel plot |
| Framebuffer scroll — `UNBTECH 0x1BDD0` ↔ `TITAN 0x3778` | `add si,0x3E40; add di,0x7C80; rep movsw; sub si,0x80; sub di,0xC0` | Video page scroll |

**Conclusion**: the shared Westwood renderer is **VGA mode-13h (320×200) with write-mode-2
pixel plotting**, implemented in segment `207F`. This is the first confirmed shared engine
subsystem (subsystem C, "Rendering/viewport") and a concrete anchor for the function map.

## Function map (first pass)

File↔runtime mapping for BattleTech (verified against Reko `fn207F_0313`):

```
runtime_linear = 0x8000 + (file_offset - 0x3400)      # program loads at segment 0x800
```

| BattleTech runtime | Content | Shared with TITAN |
|--------------------|---------|-------------------|
| `207F:0313` (`fn207F_0313`) | VGA write-mode-2 blitter | ✓ |
| `207F:0A47` | 2-bit mask expansion (`0xF00F`) | ✓ |
| ~`207F` | framebuffer scroll (`rep movsw`) | ✓ |
| ~`2385` region (~4 KB) | **text tokenizer** (`cmp al,20h/09h/0Dh/22h/5Ch`) + EGA expansion tables + string tables | ✓ |
| ~`3ED9–0x444D` | further shared code/data | ✓ |

So the shared engine module bundles the **VGA mode-13h renderer** and the
**text/tokenizer + colour-table** code, all in/around segment `207F`. The largest single
shared block is data (tables), the code matches are the renderer and text routines.

## Method

Find maximal common byte runs between the two executables (rolling 32-byte
windows, skipping low-diversity windows), reported as `length, UNBTECH offset,
TITAN offset`. File offsets, not runtime segments.

## Result

**39 shared runs ≥ 48 bytes, 3451 bytes total.** The two games share
substantial engine code — a solid basis for cross-referencing subsystems.

| Length | UNBTECH offset | TITAN offset |
|--------|----------------|--------------|
| 299 | `0x1fbb5` | `0xef7b` |
| 200 | `0x1f00a` | `0xc788` |
| 166 | `0x1ed15` | `0xcf0d` |
| 160 | `0x1f981` | `0xca0b` |
| 145 | `0x1aaf7` | `0x9727` |
| 138 | `0x3f8d4` | `0x1a5ba` |
| 128 | `0x1ec5a` | `0xce52` |
| 105 | `0x1f0d4` | `0xc852` |
| 103 | `0x1ef53` | `0xc6d1` |
| 100 | `0x1f7f8` | `0xe20c` |
| 98 | `0x1bf0c` | `0x37ea` |
| 95 | `0x1fa55` | `0xc5b7` |
| 93 | `0x3af81` | `0xeb84` |
| 92 | `0x1f201` | `0xc97f` |
| 86 | `0x1f5e5` | `0xe6f7` |
| 85 | `0x1f4ea` | `0xe5fc` |
| 85 | `0x1df8a` | `0x91c0` |
| 84 | `0x1f2b8` | `0xcb06` |
| 81 | `0x3a1a1` | `0x18e11` |
| 74 | `0x1f712` | `0xc63c` |
| 70 | `0x3f488` | `0x19636` |
| 60 | `0x1f4a1` | `0xe56f` |
| 58 | `0x1c633` | `0x36c8` |
| 58 | `0x1bdd0` | `0x3778` |
| 57 | `0x1f54a` | `0xe65c` |
| 56 | `0x1bd0b` | `0x367a` |
| 55 | `0x3b027` | `0xec2e` |
| 55 | `0x1f75c` | `0xc242` |
| 55 | `0x19b60` | `0xabc8` |
| 54 | `0x3af43` | `0xeb3c` |
| 53 | `0x1edc6` | `0xcfbe` |
| 53 | `0x1a3d3` | `0xb596` |
| 52 | `0x1fa21` | `0xc9db` |
| 52 | `0x1be23` | `0x37b4` |
| 50 | `0x3aed7` | `0xea9e` |
| 50 | `0x1f30e` | `0xcb5c` |
| 49 | `0x1f594` | `0xe6a6` |
| 49 | `0x1c739` | `0x33f3` |
| 48 | `0x1e015` | `0x4f36` |

### Clusters

- **`UNBTECH ~0x1EC..–0x1FC..` ↔ `TITAN ~0x0C5..–0x0EF..`**: the largest cluster
  (16+ runs) — a core engine module (candidate: text renderer / resource tables /
  palette). Map with r2/Reko next.
- **`UNBTECH ~0x3A..–0x3F..` ↔ `TITAN ~0x18..–0x1A..`**: a second module
  (candidate: RLE/format or map routines).

## Next steps

1. Disassemble the shared runs (r2, 16-bit) and identify each engine routine.
2. Build the **shared vs game-specific function map** (the plan's key deliverable).
3. Obtain the DOS **Mars Saga (1988)** build too (closer in time to BattleTech than
   Mines of Titan) for a second cross-reference.
