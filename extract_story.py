#!/usr/bin/env python3
"""
Extract clean story text from all .BLD files.
Filters out bytecode noise and shows only narrative text
in story order, organized by building/script file.
"""

import os
import re

# Cipher table
CIPHER = {
    0x57: 'i', 0x58: 'h', 0x59: 'k', 0x5A: 'j',
    0x5B: 'm', 0x5C: 'l', 0x5D: 'o', 0x5E: 'n', 0x5F: 'a',
    0x60: 'q',
    0x61: 'c', 0x62: 'b', 0x63: 'e', 0x64: 'd', 0x65: 'g', 0x66: 'f',
    0x67: 'y', 0x68: 'x', 0x69: 'i', 0x6A: 'z',
    0x6C: 'l', 0x6D: 'm', 0x6E: 'n', 0x6F: 'o',
    0x70: 'p', 0x71: 's', 0x72: 'r', 0x73: 'u', 0x74: 't', 0x75: 'w', 0x76: 'v',
    0x77: 'I', 0x78: 'H', 0x79: 'K', 0x7A: 'J',
    0x7B: 'M', 0x7C: 'L', 0x7D: 'O', 0x7E: 'N', 0x7F: 'A',
    0x81: 'C', 0x82: 'B', 0x83: 'E', 0x84: 'D', 0x85: 'G', 0x86: 'F', 0x87: 'Y',
    0x90: 'P', 0x91: 'S', 0x92: 'R', 0x93: 'U', 0x94: 'T', 0x95: 'W', 0x96: 'V',
}

NARRATIVE_MODE = {
    0x9E: 'NARRATIVE',
    0x9C: 'DIALOGUE',
    0x9B: 'THOUGHT',
    0x9F: 'DIRECTED',
    0xA5: 'CONTINUATION',
}

CONTENT_TYPE = {
    0xC0EC: 'dialogue/story',
    0xC0F5: 'shop/service',
    0xC0F4: 'special',
    0xC0DA: 'endgame',
}

def cipher(b):
    return CIPHER.get(b)

def decode_text(data, start, maxlen=9999):
    """Decode text from data starting at start, until non-text byte."""
    result = []
    for i in range(start, min(len(data), start + maxlen)):
        b = data[i]
        if b == 0x6B or b == 0x00:
            break
        ch = cipher(b)
        if ch:
            result.append(ch)
        elif b == 0xA0:
            result.append(' ')
        elif 0x30 <= b <= 0x39:
            result.append(chr(b))
        elif b == 0x27: result.append("'")
        elif b == 0x2C: result.append(',')
        elif b == 0x2E: result.append('.')
        elif b == 0x21: result.append('!')
        elif b == 0x3F: result.append('?')
        elif b == 0x2D: result.append('-')
        elif b == 0x28: result.append('(')
        elif b == 0x29: result.append(')')
        elif b == 0x5B: result.append('[')
        elif b == 0x5D: result.append(']')
        elif b == 0x20: result.append(' ')
        elif b >= 0x80:
            break
        else:
            break
    return ''.join(result)

def is_text_byte(b):
    """Check if byte is part of cipher text stream."""
    if b in (0x6B, 0x00):
        return False
    if cipher(b) is not None:
        return True
    if 0x57 <= b <= 0x7F:
        return True
    if b == 0xA0 or b == 0x20:
        return True
    if 0x30 <= b <= 0x39:  # digits
        return True
    if b in (0x27, 0x2C, 0x2E, 0x21, 0x3F, 0x2D, 0x28, 0x29, 0x5B, 0x5D, 0x22, 0x3A, 0x3B):
        # punctuation: ' , . ! ? - ( ) [ ] " : ;
        return True
    return False

def is_structural_byte(b):
    """Bytecode structural bytes to skip."""
    if b in (0xC0, 0xAA, 0xBB, 0xAD, 0xD0, 0xD7, 0x9E, 0x9C, 0x9B, 0x9F, 0xA5):
        return True
    if b in (0x84, 0x87, 0x94):
        return True
    if 0xAF <= b <= 0xBF:
        return True  # price encoding
    if b in (0x9D, 0x9E, 0x9F):  # item counts
        return True
    if b in (0x99, 0x9A, 0xB9, 0xBA, 0xBC, 0xBD):
        return True  # punctuation in bytecode (handled differently than text)
    if 0xC4 <= b <= 0xFF:
        return True  # opcodes
    return False

def extract_dialogue(data):
    """Extract dialogue in order from a BLD file."""
    segments = []
    i = 8  # skip header
    current_mode = None
    while i < len(data):
        b = data[i]

        # Narrative mode markers
        if b in NARRATIVE_MODE:
            current_mode = NARRATIVE_MODE[b]
            i += 1
            continue

        # Skip structural/opcode bytes
        if is_structural_byte(b):
            i += 1
            continue

        # Cipher text or raw text
        if is_text_byte(b):
            text = decode_text(data, i)
            if len(text) >= 2:
                segments.append((i, current_mode, text))
            i += max(len(text), 1) if text else 1
            continue

        # Anything else: skip
        i += 1
    return segments

def format_segments(segments, file_type_name):
    """Format extracted segments as a readable script."""
    lines = []
    parts = []
    for offset, mode, text in segments:
        if mode == 'NARRATIVE':
            prefix = '\n'
            text = text[0].upper() + text[1:] if text else text
        elif mode == 'DIALOGUE':
            prefix = '  "'
            text = text + '"'
        elif mode == 'THOUGHT':
            prefix = '  (' 
            text = text + ')'
        elif mode == 'DIRECTED':
            prefix = '  *'
        elif mode == 'CONTINUATION':
            prefix = ' '
        else:
            prefix = ' '
        parts.append((prefix, text))

    # Merge
    result = ''
    for prefix, text in parts:
        if prefix == '\n':
            if result and not result.endswith('\n'):
                result += '\n'
            result += text[0].upper() + text[1:] if text else text
        elif prefix == ' ':
            result += text
        elif prefix == '  "':
            result += '\n' + prefix + text
        elif prefix == '  (':
            result += '\n' + prefix + text
        elif prefix == '  *':
            result += '\n' + prefix + text
        else:
            result += prefix + text

    return result


def main():
    bld_dir = os.path.dirname(os.path.abspath(__file__))
    output = []

    files_order = [
        'TRAINING.BLD', 'BARRACKS.BLD', 'BARRACK2.BLD', 'LOUNGE.BLD',
        'CITADEL.BLD', 'COMSTAR.BLD', 'WEAPON.BLD', 'WEAPON2.BLD',
        'ARMOR.BLD', 'CLOTHES.BLD', 'HOSPITAL.BLD', 'GARAGE.BLD',
        'REPAIR.BLD', 'THEATER.BLD', 'PARTY.BLD', 'MAYOR.BLD',
        'FROB.BLD', 'HUT.BLD', 'FINDIT.BLD', 'INSTRUCT.BLD',
        'VIEWDISK.BLD', 'JAIL.BLD', 'ARENA.BLD', 'ENTRANCE.BLD',
        'ENDMECH.BLD', 'WINSCENE.BLD',
    ]

    file_descriptions = {
        'TRAINING.BLD': 'Training Center — Main story hub',
        'BARRACKS.BLD': 'Cadet barracks',
        'BARRACK2.BLD': 'Destroyed barracks scene',
        'LOUNGE.BLD': 'Lounge — Rick Atlas meeting',
        'CITADEL.BLD': 'Citadel — Attack sequence',
        'COMSTAR.BLD': 'ComStar — Banking/stock market',
        'WEAPON.BLD': 'Weapon Shop',
        'WEAPON2.BLD': 'Weapon Shop (post-attack variant)',
        'ARMOR.BLD': 'Armor Shop',
        'CLOTHES.BLD': 'Clothes Shop',
        'HOSPITAL.BLD': 'Hospital — Medical services',
        'GARAGE.BLD': 'Garage — Mech parking',
        'REPAIR.BLD': 'Repair Center — Tech recruitment',
        'THEATER.BLD': 'Theater entertainment',
        'PARTY.BLD': "Kuritan party — Rex's rescue",
        'MAYOR.BLD': "Mayor's house — Newspaper, holodisk",
        'FROB.BLD': 'Frob — Holographic face puzzle',
        'HUT.BLD': "Tellhim's hut — Puzzle gauntlet",
        'FINDIT.BLD': 'World map clue search',
        'INSTRUCT.BLD': "Jeremiah's cache instruction note",
        'VIEWDISK.BLD': 'Jeremiah\'s holodisk (damaged)',
        'JAIL.BLD': 'Internment center jailbreak',
        'ARENA.BLD': 'Mech combat arena',
        'ENTRANCE.BLD': 'Star League cache entrance',
        'ENDMECH.BLD': 'Endgame — Phoenix Hawk LAM',
        'WINSCENE.BLD': 'Endgame — Hyperpulse Generator',
    }

    for fname in files_order:
        fpath = os.path.join(bld_dir, fname)
        if not os.path.exists(fpath):
            continue
        with open(fpath, 'rb') as f:
            data = f.read()

        ct = (data[6] << 8) | data[7] if len(data) > 7 else 0
        ct_name = CONTENT_TYPE.get(ct, f'type_{ct:04x}')
        desc = file_descriptions.get(fname, '')

        segments = extract_dialogue(data)
        text = format_segments(segments, ct_name)

        output.append(f"{'='*72}")
        output.append(f"  {fname}  ({len(data)} bytes) — {ct_name}")
        if desc:
            output.append(f"  {desc}")
        output.append(f"{'='*72}")
        output.append('')
        output.append(text)
        output.append('')
        output.append('')

    story_path = os.path.join(bld_dir, 'STORY_TEXT.txt')
    with open(story_path, 'w') as f:
        f.write('\n'.join(output))
    print(f"Story text extracted to: {story_path}")
    print(f"Total files: {len([f for f in files_order if os.path.exists(os.path.join(bld_dir, f))])}")


if __name__ == '__main__':
    main()
