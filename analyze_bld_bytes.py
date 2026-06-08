#!/usr/bin/env python3
"""Analyze byte values in .BLD files across both raw (0x08-0x9F) and decrypted (0xA0+) regions."""

import os
import glob

BLD_DIR = "/home/velteyn/projects/Reversing/AIATTEMPT"
FILES = sorted(glob.glob(os.path.join(BLD_DIR, "*.BLD")))

def decrypt_byte(b):
    return ((b ^ 233) - 41) & 0xFF

def is_mapped(b):
    """Check if byte is already mapped by CipherDecoder or is ASCII printable."""
    if 0x20 <= b <= 0x7E:
        return True
    if b == 0xA0:
        return True
    if 0x57 <= b <= 0x5F:
        return True
    if b == 0x60:
        return True
    if 0x61 <= b <= 0x76 and b != 0x6B:
        return True
    if 0x77 <= b <= 0x7F:
        return True
    if 0x81 <= b <= 0x87:
        return True
    if 0x90 <= b <= 0x96:
        return True
    return False

decrypted_all = set()
raw_all = set()
file_decrypted = {}  # byte -> set of filenames
file_raw = {}

for fpath in FILES:
    fname = os.path.basename(fpath)
    with open(fpath, "rb") as f:
        data = f.read()

    header = data[:8]
    content_type = data[6] | (data[7] << 8)

    # Raw region 0x08-0x9F
    raw_region = data[8:0xA0]
    raw_bytes = set(raw_region)
    raw_all.update(raw_bytes)
    for b in raw_bytes:
        file_raw.setdefault(b, set()).add(fname)

    # Decrypted region 0xA0+
    encrypted = data[0xA0:]
    decrypted = [decrypt_byte(b) for b in encrypted]
    dec_bytes = set(decrypted)
    decrypted_all.update(dec_bytes)
    for b in dec_bytes:
        file_decrypted.setdefault(b, set()).add(fname)

print("=" * 80)
print("BLD FILE ANALYSIS: UNIQUE BYTE VALUES")
print("=" * 80)

print(f"\n{'='*80}")
print("DECRYPTED 0xA0+ REGION — ALL UNIQUE BYTES")
print(f"{'='*80}")
for b in sorted(decrypted_all):
    files = file_decrypted.get(b, set())
    mapped = is_mapped(b)
    mapped_str = "MAPPED" if mapped else "UNMAPPED"
    print(f"  0x{b:02X} ({b:3d})  chr={chr(b) if 0x20 <= b <= 0x7E else '?'}  [{mapped_str}]  files={len(files)}  {', '.join(sorted(files))}")

print(f"\n{'='*80}")
print("RAW 0x08-0x9F REGION — ALL UNIQUE BYTES")
print(f"{'='*80}")
for b in sorted(raw_all):
    files = file_raw.get(b, set())
    print(f"  0x{b:02X} ({b:3d})  files={len(files)}  {', '.join(sorted(files))}")

print(f"\n{'='*80}")
print("SUMMARY")
print(f"{'='*80}")
print(f"Files analyzed: {len(FILES)}")
print(f"Unique bytes in decrypted 0xA0+: {len(decrypted_all)}")
print(f"Unique bytes in raw 0x08-0x9F:   {len(raw_all)}")

print(f"\n{'='*80}")
print("UNMAPPED BYTES IN DECRYPTED 0xA0+ REGION")
print(f"(Not ASCII printable 0x20-0x7E, not in known cipher table)")
print(f"{'='*80}")
unmapped = sorted(b for b in decrypted_all if not is_mapped(b))
for b in unmapped:
    files = file_decrypted.get(b, set())
    print(f"  0x{b:02X} ({b:3d})  files={len(files)}  {', '.join(sorted(files))}")

if unmapped:
    hex_list = ", ".join(f"0x{b:02X}" for b in unmapped)
    print(f"\nHEX LIST: [{hex_list}]")
else:
    print("  (none — all bytes are mapped or ASCII printable)")

print()
