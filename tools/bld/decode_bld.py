#!/usr/bin/env python3
"""
Decode ALL .BLD files using the empirically-derived substitution cipher.
Outputs interleaved binary/text analysis for each file with opcode classification.
"""
import os
import sys
from collections import Counter

# === SUBSTITUTION TABLE (final, verified against BattleTech lore) ===
# From CONTEXT.md section 4
subst = {
    # 0x57-0x5F: i h k j m l o n a
    0x57: 'i', 0x58: 'h', 0x59: 'k', 0x5A: 'j',
    0x5B: 'm', 0x5C: 'l', 0x5D: 'o', 0x5E: 'n', 0x5F: 'a',
    # 0x60: q
    0x60: 'q',
    # 0x61-0x76 (skip 0x6B which is control): c b e d g f y x i z (l m n o p s r u t w v)
    0x61: 'c', 0x62: 'b', 0x63: 'e', 0x64: 'd', 0x65: 'g', 0x66: 'f',
    0x67: 'y', 0x68: 'x', 0x69: 'i', 0x6A: 'z',
    # 0x6B = control byte, not text
    0x6C: 'l', 0x6D: 'm', 0x6E: 'n', 0x6F: 'o',
    0x70: 'p', 0x71: 's', 0x72: 'r', 0x73: 'u', 0x74: 't', 0x75: 'w', 0x76: 'v',
    # 0x77-0x7F: I H K J M L O N A (uppercase in "lowercase" range)
    0x77: 'I', 0x78: 'H', 0x79: 'K', 0x7A: 'J',
    0x7B: 'M', 0x7C: 'L', 0x7D: 'O', 0x7E: 'N', 0x7F: 'A',
    # 0x80-0x96 (specific bytes): C B E D G F Y P S R U T W V
    0x81: 'C', 0x82: 'B', 0x83: 'E', 0x84: 'D', 0x85: 'G', 0x86: 'F', 0x87: 'Y',
    0x90: 'P', 0x91: 'S', 0x92: 'R', 0x93: 'U', 0x94: 'T', 0x95: 'W', 0x96: 'V',
}

def decode_byte(b):
    if b in subst:
        return subst[b]
    return None

def is_text_byte(b):
    if b == 0xA0:
        return True
    if 0x57 <= b <= 0x5F:
        return True
    if b == 0x60:
        return True
    # 0x61-0x7F except 0x6B which is control
    if 0x61 <= b <= 0x7F and b != 0x6B:
        return True
    # Only specific bytes in 0x80-0x96 are text (those in subst)
    if b in subst and b >= 0x80:
        return True
    return False

def decode_text_run(data, offset, length):
    result = []
    i = 0
    while i < length and offset + i < len(data):
        b = data[offset + i]
        if b == 0xA0:
            result.append(' ')
            i += 1
        elif b in subst:
            result.append(subst[b])
            i += 1
        else:
            break
    return ''.join(result), i

def classify_binary_run(raw):
    if len(raw) == 1:
        b = raw[0]
        if b == 0x00:
            return 'padding'
        return f'single({b:02x})'
    if len(raw) == 2:
        return f'pair({raw[0]:02x} {raw[1]:02x})'
    # Multi-byte binary: show first few
    prefix = ' '.join(f'{b:02x}' for b in raw[:6])
    if len(raw) > 6:
        prefix += '...'
    return f'multi({len(raw)}b: {prefix})'

def scan_segments(data):
    segments = []
    i = 0

    # Skip initial header byte if 0x70
    if data and data[0] == 0x70:
        i = 1

    in_text = False
    while i < len(data):
        if is_text_byte(data[i]):
            start = i
            while i < len(data) and is_text_byte(data[i]):
                i += 1
            raw = data[start:i]
            decoded = []
            for b in raw:
                if b == 0xA0:
                    decoded.append(' ')
                elif b in subst:
                    decoded.append(subst[b])
                else:
                    decoded.append(f'[{b:02x}]')
            segments.append(('text', start, ''.join(decoded)))
            in_text = False
        else:
            start = i
            while i < len(data) and not is_text_byte(data[i]):
                i += 1
            raw = data[start:i]
            if set(raw) not in [{0}, {0xFF}]:
                segments.append(('binary', start, raw))
            in_text = True

    return segments

def analyze_bld(data, filename):
    lines = []
    lines.append(f"{'='*70}")
    lines.append(f"FILE: {filename}  ({len(data)} bytes)")
    lines.append(f"{'='*70}")

    # Header analysis
    if len(data) >= 8:
        h = [f'{b:02x}' for b in data[:8]]
        lines.append(f"  HEADER: {' '.join(h)}")
        lines.append(f"    byte0 (type/ID): {data[0]:02x}")
        if len(data) > 1:
            lines.append(f"    byte1 (para count): {data[1]} (0x{data[1]:02x})")
        if len(data) > 5:
            sig = data[2:6]
            sig_str = ' '.join(f'{b:02x}' for b in sig)
            lines.append(f"    bytes 2-5 (signature): {sig_str}")
        if len(data) > 7:
            ct = data[6:8]
            ct_str = ' '.join(f'{b:02x}' for b in ct)
            type_names = {0xc0ec: 'dialogue/story', 0xc0f5: 'shop/service',
                          0xc0f4: 'special', 0xc0da: 'endgame'}
            tn = type_names.get((ct[0] << 8) | ct[1], 'unknown')
            lines.append(f"    bytes 6-7 (type): {ct_str} ({tn})")
        if len(data) > 8:
            lines.append(f"    byte8 (subtype): {data[8]:02x}")

    # Segment analysis
    segments = scan_segments(data)
    lines.append(f"\n  SEGMENTS: {len(segments)} total")
    lines.append(f"  {'='*60}")

    # Statistics
    binary_count = sum(1 for s in segments if s[0] == 'binary')
    text_count = sum(1 for s in segments if s[0] == 'text')
    lines.append(f"  Binary segments: {binary_count}, Text segments: {text_count}")

    # Analyze opcode patterns in binary segments
    opcode_counter = Counter()
    for seg_type, offset, raw in segments:
        if seg_type == 'binary':
            if len(raw) >= 1:
                opcode_counter[raw[0]] += 1
            if len(raw) >= 2:
                opcode_counter[(raw[0], raw[1])] += 1
            if len(raw) >= 3:
                opcode_counter[(raw[0], raw[1], raw[2])] += 1

    if opcode_counter:
        lines.append(f"\n  TOP SINGLE-BYTE OPCODES:")
        for (op, count) in opcode_counter.most_common(30):
            if isinstance(op, int):
                name = known_singles.get(op, '')
                tag = f'  // {name}' if name else ''
                lines.append(f"    {op:02x}: {count:4d}{tag}")

        lines.append(f"\n  TOP TWO-BYTE OPCODES:")
        for (op, count) in [(k, v) for k, v in opcode_counter.items() if isinstance(k, tuple) and len(k) == 2][:30]:
            name = known_pairs.get(op, '')
            tag = f'  // {name}' if name else ''
            lines.append(f"    {' '.join(f'{b:02x}' for b in op)}: {count:4d}{tag}")

        lines.append(f"\n  TOP THREE-BYTE OPCODES:")
        for (op, count) in [(k, v) for k, v in opcode_counter.items() if isinstance(k, tuple) and len(k) == 3][:30]:
            name = known_triples.get(op, '')
            tag = f'  // {name}' if name else ''
            lines.append(f"    {' '.join(f'{b:02x}' for b in op)}: {count:4d}{tag}")

    # Detailed segment listing
    lines.append(f"\n  {'='*60}")
    lines.append(f"  DETAILED SEGMENT DUMP:")
    lines.append(f"  {'='*60}")

    for idx, (seg_type, offset, data_or_text) in enumerate(segments):
        if seg_type == 'text':
            lines.append(f"  [{idx:3d}] TEXT @{offset:04X}: {data_or_text}")
        else:
            raw = data_or_text
            if len(raw) <= 1:
                label = known_singles.get(raw[0], '')
                tag = f'  // {label}' if label else ''
                lines.append(f"  [{idx:3d}] BIN  @{offset:04X}: {raw.hex()} [{len(raw)}b]{tag}")
            elif len(raw) == 2:
                label = known_pairs.get((raw[0], raw[1]), '')
                tag = f'  // {label}' if label else ''
                lines.append(f"  [{idx:3d}] BIN  @{offset:04X}: {raw.hex()} [{len(raw)}b]{tag}")
            elif len(raw) <= 8:
                label = known_multibyte.get(bytes(raw[:4]), '')
                tag = f'  // {label}' if label else ''
                lines.append(f"  [{idx:3d}] BIN  @{offset:04X}: {raw.hex()} [{len(raw)}b]{tag}")
            else:
                label = known_multibyte.get(bytes(raw[:4]), '')
                tag = f'  // {label}' if label else ''
                hex_preview = raw[:8].hex() + '...'
                lines.append(f"  [{idx:3d}] BIN  @{offset:04X}: {hex_preview} [{len(raw)}b]{tag}")

    return '\n'.join(lines)

# Known opcode labels (from earlier analysis)
known_singles = {
    0x00: 'NULL/padding',
    0x01: 'UNK_01',
    0x9B: 'player-internal thought',
    0x9C: 'dialogue continuation',
    0x9D: 'UNK_9D',
    0x9E: 'narrative/description',
    0x9F: 'player-directed thought',
    0xA0: 'SPACE (not opcode, handled in text)',
    0xA5: 'sentence continuation',
    0xAA: 'menu option',
    0xAD: 'transition word',
    0xBB: 'option separator',
    0xC0: 'control/conditional prefix',
    0xD0: 'UNK_D0',
    0xD7: 'UNK_D7',
    0xE0: 'UNK_E0',
    0xE8: 'UNK_E8',
    0xE9: 'UNK_E9',
    0xEA: 'UNK_EA',
    0xEB: 'signature byte',
    0xEC: 'UNK_EC / type suffix',
    0xF0: 'UNK_F0',
    0xF2: 'UNK_F2',
    0xF3: 'UNK_F3',
    0xF4: 'UNK_F4 / type',
    0xF5: 'UNK_F5 / type',
    0xFA: 'UNK_FA',
    0xFB: 'UNK_FB',
    0xFC: 'UNK_FC',
    0xFD: 'UNK_FD',
}

known_pairs = {
    (0x9E, 0xBB): 'menu header start',
    (0xC0, 0xEC): 'dialogue type marker',
    (0xC0, 0xF5): 'shop type marker',
    (0xC0, 0xF4): 'special type marker',
    (0xC0, 0xDA): 'endgame type marker',
    (0xC0, 0xE8): 'conditional/state text block',
    (0xC0, 0xE9): 'UNK_C0_E9',
    (0xC0, 0xEA): 'UNK_C0_EA',
    (0xC0, 0xF2): 'UNK_C0_F2',
    (0xC0, 0xF3): 'UNK_C0_F3',
    (0xAA, 0xBB): 'menu option first',
    (0x9E, 0xC0): 'narrative with control',
    (0x9C, 0xC0): 'dialogue with control',
    (0x9F, 0xC0): 'player thought with control',
    (0xC0, 0xE4): 'UNK_C0_E4',
    (0x9B, 0xC0): 'internal thought with control',
}

known_triples = {
    (0x9E, 0xC0, 0xF2): 'room description intro',
    (0xC0, 0xF3, 0xBA): 'shopkeeper payment',
    (0x9F, 0xC0, 0xE9): 'theater/movie dialogue',
    (0x9E, 0xBB, 0xBB): 'menu header double',
    (0x9E, 0xC0, 0xE8): 'narrative conditional',
}

known_multibyte = {
    bytes([0x9E, 0xC0, 0xF2, 0xE9]): 'room entry description',
    bytes([0xC0, 0xE8, 0x99, 0xBF]): 'failure path conditional',
    bytes([0xC0, 0xF3, 0xBA, 0xEC]): 'shopkeeper payment dialogue',
    bytes([0x9E, 0xBB, 0xBB, 0x00]): 'menu header with null',
    bytes([0x9F, 0xC0, 0xE9, 0xDA]): 'theater dialogue cont',
}

def main():
    bld_dir = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))), "original", "bld")

    for fname in sorted(os.listdir(bld_dir)):
        if not fname.upper().endswith('.BLD'):
            continue
        fpath = os.path.join(bld_dir, fname)
        with open(fpath, 'rb') as f:
            data = f.read()

        analysis = analyze_bld(data, fname)
        out_lines.append(analysis)
        print(analysis)

    # Save to file
    out_path = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))), "tools", "bld", 'decode_bld_output.txt')
    with open(out_path, 'w') as f:
        f.write('\n'.join(out_lines))
    print(f"\n\nFull output saved to: {out_path}")

if __name__ == '__main__':
    main()
