#!/usr/bin/env python3
"""
BLD ↔ JSON Converter
=====================
BLD_to_JSON: Parse BLD files into structured JSON with annotations.
JSON_to_BLD: Reassemble JSON back into exact binary BLD format (round-trip safe).

The JSON format preserves every original byte while adding annotations
for opcodes, decoded text, narrative markers, and structural elements.
"""

import os
import json
import sys
import re

# ============================================================
# CIPHER TABLE
# ============================================================
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

def cipher_char(b):
    if b in CIPHER: return CIPHER[b]
    if 0x57 <= b <= 0x5F: return CIPHER.get(b)
    if b == 0x60: return 'q'
    if 0x61 <= b <= 0x7F and b != 0x6B: return CIPHER.get(b, f'[{b:02x}]')
    return None

def is_cipher_byte(b):
    return cipher_char(b) is not None

def decode_cipher_text(data, start, maxlen=9999):
    """Decode cipher text from position start."""
    result = []
    i = start
    while i < len(data) and (i - start) < maxlen:
        b = data[i]
        if b == 0x6B or b == 0x00:
            break
        ch = cipher_char(b)
        if ch is not None:
            result.append(ch)
            i += 1
        elif b == 0xA0:
            result.append(' ')
            i += 1
        elif b == 0x20:
            result.append(' ')
            i += 1
        elif 0x30 <= b <= 0x39:  # digits
            result.append(chr(b))
            i += 1
        elif b in (0x27, 0x2C, 0x2E, 0x21, 0x3F, 0x2D, 0x28, 0x29, 0x5B, 0x5D, 0x22, 0x3A, 0x3B):
            result.append(chr(b))
            i += 1
        elif b >= 0x80:
            break
        else:
            break
    return ''.join(result), i - start


# ============================================================
# OPCODE DEFINITIONS
# ============================================================
OPCODES = {
    0xE4: ('WRITE_CHAR', 1, 'Read 1 byte operand, write as char'),
    0xE5: ('ADD_CREDITS', 2, 'Read 2-byte signed LE, add to credits'),
    0xE6: ('SET_CURSOR_XY', 4, 'Read 2x2-byte signed LE, set X and Y'),
    0xE7: ('CMP_CURSOR_X', 2, 'Read 2-byte LE. If == cursor_x: jump. Else skip 2'),
    0xE8: ('RNG_CHECK', 1, 'Read 1 byte mask. If RNG&mask: jump. Else skip 2'),
    0xE9: ('CALL_ROOM_HANDLER', 1, 'Read 1 byte, dispatch room handler'),
    0xEA: ('COND_STATE_ACTION', 3, 'Read 1 byte index + optional byte + alignment'),
    0xEB: ('CHECK_FLAG_EB', 0, 'If flag_d451: jump (read 2). Else skip 2'),
    0xEC: ('CHECK_FLAG_EC', 0, 'If flag_d450: jump (read 2). Else skip 2'),
    0xED: ('UNIT_CHECK_LOOP', 2, 'Read 2 bytes (index, threshold). If match: jump'),
    0xEE: ('SPEND_CREDITS', 2, 'Read 2-byte signed LE, deduct from credits'),
    0xEF: ('CHECK_CREDITS', 2, 'Read 2-byte LE. If affordable: jump. Else skip 2'),
    0xF0: ('SET_TEXT_MARGINS', 2, 'Read 2 bytes: left, right margin'),
    0xF1: ('ADD_TO_STATE', 2, 'Read 2 bytes (index, value). state[index] += value'),
    0xF2: ('ROOM_DESCRIPTION', 0, 'Render room description text'),
    0xF3: ('SHOP_INTERACTION', 1, 'Read 1 byte index, indirect dispatch'),
    0xF4: ('SET_STATE_VALUE', 2, 'Read 2 bytes (index, value). state[index] = value'),
    0xF5: ('SHOP_DISPATCH', 1, 'Read 1 byte case → call fn1CD3_0004(case)'),
    0xF6: ('CHECK_CONDITION', 0, 'Check condition. If true: jump. Else skip 2'),
    0xF7: ('STATE_COND_CHECK', 1, 'Read 1 byte index. If state[idx]!=0: jump. Else skip 2'),
    0xF8: ('JUMP_FORWARD', 0, 'Read 2-byte WORD → absolute jump target'),
    0xF9: ('JUMP_INDEXED', 1, 'Read 1 byte. skip = index*2+2 (computed goto)'),
    0xFA: ('DRAW_SPRITE', 1, 'Read 1 byte sprite ID'),
    0xFB: ('ADVANCE_INPUT', 0, 'Wait for keypress'),
    0xFC: ('RENDER_TEXT', 0, 'Read/decode text at current position, render'),
    0xFD: ('SET_FONT2', 0, 'Set font/display parameters'),
    0xFE: ('SET_FONT', 1, 'Read 1 byte font ID'),
    0xFF: ('EXIT', 0, 'Stop interpreter'),
}

NARRATIVE_MARKERS = {
    0x9E: 'narrative',
    0x9C: 'dialogue',
    0x9B: 'thought',
    0x9F: 'directed',
    0xA5: 'continuation',
    0xBB: 'separator',
    0xAA: 'option',
    0xAD: 'transition',
}

CONTENT_TYPES = {
    0xC0EC: 'dialogue/story',
    0xC0F5: 'shop/service',
    0xC0F4: 'special',
    0xC0DA: 'endgame',
}

# ============================================================
# BLD PARSER → JSON
# ============================================================
class BldParser:
    def __init__(self, data):
        self.data = data
        self.blocks = []
        self.offset = 0

    def here(self):
        return self.offset

    def read_byte(self):
        if self.offset >= len(self.data):
            return None
        b = self.data[self.offset]
        self.offset += 1
        return b

    def read_bytes(self, n):
        if self.offset + n > len(self.data):
            return None
        result = bytes(self.data[self.offset:self.offset + n])
        self.offset += n
        return result

    def peek(self):
        return self.data[self.offset] if self.offset < len(self.data) else None

    def skip(self, n):
        self.offset += n

    def add_block(self, size, btype, annotation='', decoded='', opcode=None, operands=None):
        if size == 0:
            return
        raw = self.data[self.offset - size:self.offset]
        block = {
            'offset': self.offset - size,
            'size': size,
            'bytes': raw.hex(),
            'type': btype,
        }
        if annotation:
            block['annotation'] = annotation
        if decoded:
            block['decoded'] = decoded
        if opcode is not None:
            block['opcode'] = opcode
            block['opcode_name'] = OPCODES.get(opcode, ('UNK', 0, ''))[0]
        if operands:
            block['operands'] = operands
        self.blocks.append(block)

    def is_text_byte(self, b):
        if b == 0x6B or b == 0x00:
            return False
        if is_cipher_byte(b):
            return True
        if 0x57 <= b <= 0x7F:
            return True
        if b == 0xA0 or b == 0x20:
            return True
        if 0x30 <= b <= 0x39:
            return True
        if b in (0x27, 0x2C, 0x2E, 0x21, 0x3F, 0x2D, 0x28, 0x29, 0x5B, 0x5D, 0x22, 0x3A, 0x3B):
            return True
        return False

    def parse_text_run(self):
        """Parse continuous cipher text."""
        start = self.here()
        text, length = decode_cipher_text(self.data, start)
        if length > 0:
            self.skip(length)
            self.add_block(length, 'text', decoded=text)
            return True
        return False

    def parse_single_byte(self, b):
        """Parse a single byte in the 0x80-0xC3 range."""
        size = 1
        annotation = ''

        if b in NARRATIVE_MARKERS:
            annotation = NARRATIVE_MARKERS[b]
        elif b == 0xC0:
            annotation = 'control_prefix'
        elif b == 0x99:
            annotation = 'period'
        elif b == 0x9A:
            annotation = 'comma'
        elif b == 0xB9:
            annotation = 'lparen'
        elif b == 0xBA:
            annotation = 'rparen'
        elif b == 0xBC:
            annotation = 'lbracket'
        elif b == 0xBD:
            annotation = 'rbracket'
        elif b == 0x84:
            annotation = 'new_sentence'
        elif b == 0x87:
            annotation = 'new_para'
        elif b == 0x94:
            annotation = 'sentence_cont'
        elif b == 0xD0:
            annotation = 'par_start'
        elif b == 0xD7:
            annotation = 'interact_end'
        elif 0x9D <= b <= 0x9F:
            annotation = f'count:{b-0x9C}'
        elif 0xAF <= b <= 0xBF:
            if b <= 0xB3:
                val = 40 + (b - 0xAF)
            else:
                val = 96 + (b - 0xB0) * 2 + 1
            annotation = f'price:{val}'
        elif is_cipher_byte(b):
            # Cipher letter in 0x80-0x96 range - treat as text
            self.parse_text_run()
            return
        elif b == 0xA0:
            annotation = 'space'
        else:
            annotation = f'noop_{b:02x}'

        self.read_byte()
        self.add_block(size, 'marker', annotation=annotation)

    def parse_opcode(self, op):
        """Parse an opcode (0xE4-0xFF) and its operands."""
        start = self.here()
        info = OPCODES.get(op)
        if info is None:
            self.read_byte()
            self.add_block(1, 'opcode', annotation=f'unknown_opcode_{op:02x}', opcode=op)
            return

        name, base_opsize, desc = info
        operands = []
        annotation = name

        # Consume the opcode byte
        self.read_byte()

        # Opcodes with no fixed operands but use inline jump targets
        if op in (0xEB, 0xEC, 0xF6, 0xF8):
            if self.here() + 2 <= len(self.data):
                target = self.data[self.here()] | (self.data[self.here() + 1] << 8)
                self.skip(2)
                operands = [target]
                annotation = f'{name} → [{target:04X}]'
                self.add_block(3, 'opcode', annotation=annotation, opcode=op, operands=operands)
            else:
                self.add_block(1, 'opcode', annotation=annotation, opcode=op)
            return

        if op == 0xE7:
            # CMP_CURSOR_X: 2-byte operand + 2-byte jump target
            if self.here() + 4 <= len(self.data):
                val = self.data[self.here()] | (self.data[self.here() + 1] << 8)
                if val >= 0x8000:
                    val -= 0x10000
                self.skip(2)
                target = self.data[self.here()] | (self.data[self.here() + 1] << 8)
                self.skip(2)
                operands = [val, target]
                annotation = f'{name} X={val} jump→[{target:04X}]'
                self.add_block(5, 'opcode', annotation=annotation, opcode=op, operands=operands)
            else:
                self.add_block(1, 'opcode', annotation=annotation, opcode=op)
            return

        if op == 0xEF:
            # CHECK_CREDITS: 2-byte operand + 2-byte jump target
            if self.here() + 4 <= len(self.data):
                val = self.data[self.here()] | (self.data[self.here() + 1] << 8)
                if val >= 0x8000:
                    val -= 0x10000
                self.skip(2)
                target = self.data[self.here()] | (self.data[self.here() + 1] << 8)
                self.skip(2)
                operands = [val, target]
                annotation = f'{name} {val} jump→[{target:04X}]'
                self.add_block(5, 'opcode', annotation=annotation, opcode=op, operands=operands)
            else:
                self.add_block(1, 'opcode', annotation=annotation, opcode=op)
            return

        if op == 0xE8:
            # RNG_CHECK: 1-byte mask + 2-byte jump target
            if self.here() + 3 <= len(self.data):
                mask = self.read_byte()
                target = self.data[self.here()] | (self.data[self.here() + 1] << 8)
                self.skip(2)
                operands = [mask, target]
                annotation = f'{name} mask={mask:02x} jump→[{target:04X}]'
                self.add_block(4, 'opcode', annotation=annotation, opcode=op, operands=operands)
            else:
                self.add_block(1, 'opcode', annotation=annotation, opcode=op)
            return

        if op == 0xED:
            # UNIT_CHECK_LOOP: 2 bytes + 2-byte jump target
            if self.here() + 4 <= len(self.data):
                idx = self.read_byte()
                thresh = self.read_byte()
                target = self.data[self.here()] | (self.data[self.here() + 1] << 8)
                self.skip(2)
                operands = [idx, thresh, target]
                annotation = f'{name} idx={idx:02x} thresh={thresh:02x} jump→[{target:04X}]'
                self.add_block(5, 'opcode', annotation=annotation, opcode=op, operands=operands)
            else:
                self.add_block(1, 'opcode', annotation=annotation, opcode=op)
            return

        if op == 0xE6:
            # SET_CURSOR_XY: 4 bytes (2x2-byte signed)
            if self.here() + 4 <= len(self.data):
                x = self.data[self.here()] | (self.data[self.here()+1] << 8)
                y = self.data[self.here()+2] | (self.data[self.here()+3] << 8)
                if x >= 0x8000: x -= 0x10000
                if y >= 0x8000: y -= 0x10000
                self.skip(4)
                annotation = f'{name} ({x},{y})'
                self.add_block(5, 'opcode', annotation=annotation, opcode=op, operands=[x, y])
            else:
                self.add_block(1, 'opcode', annotation=annotation, opcode=op)
            return

        if op == 0xEA:
            # COND_STATE_ACTION: 1 byte + 1 byte + 1 byte alignment = 3
            if self.here() + 3 <= len(self.data):
                idx = self.read_byte()
                extra = self.read_byte()
                align = self.read_byte()
                annotation = f'{name} idx={idx:02x} extra={extra:02x} align={align:02x}'
                self.add_block(4, 'opcode', annotation=annotation, opcode=op, operands=[idx, extra, align])
            else:
                self.add_block(1, 'opcode', annotation=annotation, opcode=op)
            return

        # Standard fixed-size operand opcodes
        if base_opsize > 0:
            ops = self.read_bytes(base_opsize)
            if ops is None:
                self.add_block(1, 'opcode', annotation=name, opcode=op)
                return
            operands = list(ops)
            if base_opsize == 1:
                annotation = f'{name} op={ops[0]:02x}'
            elif base_opsize == 2:
                annotation = f'{name} {ops[0]:02x} {ops[1]:02x}'
            elif base_opsize == 4:
                annotation = f'{name} ops={ops.hex()}'
            else:
                annotation = f'{name} ops={ops.hex()}'
            self.add_block(1 + base_opsize, 'opcode', annotation=annotation, opcode=op, operands=operands)
        else:
            # Zero-operand opcode
            self.add_block(1, 'opcode', annotation=name, opcode=op)

    def parse(self):
        if len(self.data) < 8:
            return

        # Parse header
        file_type = self.data[0]
        paragraphs = self.data[1]
        sig = bytes(self.data[2:6])
        ct = (self.data[6] << 8) | self.data[7]
        ct_name = CONTENT_TYPES.get(ct, f'unknown_{ct:04x}')
        subtype = self.data[8] if len(self.data) > 8 else 0

        self.offset = 8
        self.add_block(8, 'header', annotation=f'type={file_type:02x} paragraphs={paragraphs} sig={sig.hex()} content={ct_name} subtype={subtype:02x}')

        # Parse body
        while self.offset < len(self.data):
            b = self.peek()
            if b is None:
                break

            if b < 0x80:
                # Transparent range: cipher text or control chars
                if b == 0x00:
                    self.read_byte()
                    self.add_block(1, 'null')
                elif b == 0x0D:
                    self.read_byte()
                    self.add_block(1, 'control', annotation='cr')
                elif b == 0x0A:
                    self.read_byte()
                    self.add_block(1, 'control', annotation='lf')
                elif b == 0x09:
                    self.read_byte()
                    self.add_block(1, 'control', annotation='tab')
                elif b == 0x13:
                    self.read_byte()
                    self.add_block(1, 'control', annotation='pad')
                elif b in (0x02, 0x06):
                    self.read_byte()
                    self.add_block(1, 'control', annotation=f'break_{b:02x}')
                elif b == 0x20:
                    self.read_byte()
                    self.add_block(1, 'control', annotation='space')
                elif b == 0x6B:
                    self.read_byte()
                    self.add_block(1, 'control', annotation='ctrl_6b')
                elif is_cipher_byte(b) or (0x57 <= b <= 0x7F):
                    self.parse_text_run()
                else:
                    self.read_byte()
                    self.add_block(1, 'transparent', annotation=f'byte_{b:02x}')
            elif 0x80 <= b <= 0xC3:
                # No-op range: narrative markers, structural, cipher uppercase
                if is_cipher_byte(b):
                    self.parse_text_run()
                else:
                    self.parse_single_byte(b)
            elif 0xC4 <= b <= 0xE3:
                # Undefined no-op range
                self.read_byte()
                self.add_block(1, 'unknown', annotation=f'u_{b:02x}')
            else:
                # Opcodes 0xE4-0xFF
                self.parse_opcode(b)

    def to_dict(self):
        ct = (self.data[6] << 8) | self.data[7] if len(self.data) > 7 else 0
        return {
            'filename': '',
            'size': len(self.data),
            'header': {
                'file_type': self.data[0],
                'paragraphs': self.data[1],
                'signature': bytes(self.data[2:6]).hex(),
                'content_type': f'{ct:04x}',
                'content_type_name': CONTENT_TYPES.get(ct, f'unknown_{ct:04x}'),
                'subtype': self.data[8] if len(self.data) > 8 else 0,
            },
            'blocks': self.blocks,
        }


# ============================================================
# JSON → BLD ASSEMBLER
# ============================================================
def json_to_bld(json_data):
    """Reassemble BLD binary from JSON data. Round-trip safe."""
    raw_bytes = bytearray()

    for block in json_data['blocks']:
        hex_str = block['bytes']
        raw_bytes.extend(bytes.fromhex(hex_str))

    return bytes(raw_bytes)


# ============================================================
# MAIN
# ============================================================
def main():
    repo_root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
    bld_dir = os.path.join(repo_root, "original", "bld")

    if len(sys.argv) > 1:
        cmd = sys.argv[1]

        if cmd == 'to-json':
            target = sys.argv[2] if len(sys.argv) > 2 else bld_dir
            if os.path.isdir(target):
                for fname in sorted(os.listdir(target)):
                    if not fname.upper().endswith('.BLD'):
                        continue
                    fpath = os.path.join(target, fname)
                    _bld_to_json(fpath)
            else:
                _bld_to_json(target)
            return

        if cmd == 'to-bld':
            src = sys.argv[2]
            _json_to_bld_file(src)
            return

        if cmd == 'roundtrip':
            target = sys.argv[2] if len(sys.argv) > 2 else bld_dir
            _test_roundtrip(target)
            return

        if cmd == 'help':
            print("Usage:")
            print("  python3 bld_to_json.py to-json [file|dir]  — Convert BLD to JSON")
            print("  python3 bld_to_json.py to-bld file.json     — Convert JSON to BLD")
            print("  python3 bld_to_json.py roundtrip [dir]      — Test round-trip conversion")
            return

    # Default: convert all BLD files in current directory
    print(f"BLD ↔ JSON Converter")
    print(f"{'='*60}")
    for fname in sorted(os.listdir(bld_dir)):
        if not fname.upper().endswith('.BLD'):
            continue
        fpath = os.path.join(bld_dir, fname)
        _bld_to_json(fpath)
    print(f"\nDone. JSON files written alongside source BLD files.")


def _bld_to_json(fpath):
    with open(fpath, 'rb') as f:
        data = f.read()

    parser = BldParser(data)
    parser.parse()
    result = parser.to_dict()
    result['filename'] = os.path.basename(fpath)

    json_dir = os.path.join(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__)))), "json")
    os.makedirs(json_dir, exist_ok=True)
    json_path = os.path.join(json_dir, os.path.basename(fpath) + '.json')
    with open(json_path, 'w') as f:
        json.dump(result, f, indent=2)
    blocks = len(result['blocks'])
    print(f"  {os.path.basename(fpath):20s} → {os.path.basename(json_path):25s} ({blocks} blocks, {len(data)} bytes)")


def _json_to_bld_file(json_path):
    with open(json_path, 'r') as f:
        data = json.load(f)
    bld_bytes = json_to_bld(data)
    bld_path = json_path.replace('.json', '') if json_path.endswith('.json') else json_path + '.bld'
    with open(bld_path, 'wb') as f:
        f.write(bld_bytes)
    print(f"  {os.path.basename(json_path):25s} → {os.path.basename(bld_path):20s} ({len(bld_bytes)} bytes)")


def _test_roundtrip(target_dir):
    """Test round-trip: BLD → JSON → BLD, verify binary identity."""
    print(f"Round-trip test: {target_dir}")
    print(f"{'='*60}")
    all_pass = True
    for fname in sorted(os.listdir(target_dir)):
        if not fname.upper().endswith('.BLD'):
            continue
        fpath = os.path.join(target_dir, fname)
        with open(fpath, 'rb') as f:
            original = f.read()

        # BLD → JSON
        parser = BldParser(original)
        parser.parse()
        result = parser.to_dict()
        result['filename'] = fname

        # JSON → BLD
        reassembled = json_to_bld(result)

        # Compare
        if original == reassembled:
            print(f"  ✅ {fname:20s} {len(original)} bytes — IDENTICAL")
        else:
            # Find first difference
            diff_pos = -1
            for i in range(min(len(original), len(reassembled))):
                if original[i] != reassembled[i]:
                    diff_pos = i
                    break
            print(f"  ❌ {fname:20s} DIFFERS at offset {diff_pos} "
                  f"(orig={len(original)}b, recon={len(reassembled)}b)")
            all_pass = False

    if all_pass:
        print(f"\n✅ All files pass round-trip test!")
    else:
        print(f"\n❌ Some files FAILED round-trip test.")


if __name__ == '__main__':
    main()
