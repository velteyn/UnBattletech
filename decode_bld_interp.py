#!/usr/bin/env python3
"""
BLD Bytecode Interpreter
========================
Interprets BattleTech BLD script files using all 26 opcodes (0xE4-0xFF).
Derived from Reko decompilation of UNBTECH.EXE segment 0FDC (fn0FDC_01C0).

The fn0FDC_01C0 interpreter processes a bytecode stream:
  - bytes 0x00-0x7F: transparent (cipher text — passes through)
  - bytes 0x80-0xC3: no-ops (narrative markers, formatting, prices)
  - bytes 0xC4-0xE3: undefined (no-ops)
  - bytes 0xE4-0xFF: opcodes with handlers
  - 0xC0 is a structural separator (no-op at this layer)
  - 0x6B is a control byte (string terminator, not text)
"""

import os
import json
import struct
import sys

# ============================================================
# SUBSTITUTION CIPHER
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
    """Decode a single cipher byte to character, or None."""
    if b in CIPHER:
        return CIPHER[b]
    if 0x57 <= b <= 0x5F: return CIPHER.get(b)
    if b == 0x60: return 'q'
    if 0x61 <= b <= 0x7F and b != 0x6B:
        return CIPHER.get(b, f'[{b:02x}]')
    return None

def is_cipher_byte(b):
    return cipher_char(b) is not None

def decode_cipher_run(data, start, max_len=500):
    """Read cipher text from start until non-cipher byte or 0x6B."""
    result = []
    i = start
    while i < len(data) and (i - start) < max_len:
        b = data[i]
        if b == 0x6B:
            break
        if b == 0x00:
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
        elif 0x30 <= b <= 0x39:  # digits 0-9
            result.append(chr(b))
            i += 1
        elif b in (0x27, 0x2C, 0x2E, 0x21, 0x3F, 0x2D, 0x28, 0x29, 0x5B, 0x5D):
            # punctuation: ' , . ! ? - ( ) [ ]
            result.append(chr(b))
            i += 1
        elif b >= 0x80:
            # No-op byte or opcode — terminates text
            break
        else:
            break
    return ''.join(result), i - start

# ============================================================
# OPCODE DEFINITIONS
# ============================================================
NARRATIVE_NAMES = {
    0x9E: '(narrative)',
    0x9C: '(dialogue)',
    0x9B: '(thought)',
    0x9F: '(directed)',
    0xA5: '(continuation)',
    0xBB: '(separator)',
    0xAA: '(option)',
    0xAD: '(transition)',
}

OPCODE_NAMES = {
    0xE4: 'WRITE_CHAR', 0xE5: 'ADD_CREDITS', 0xE6: 'SET_CURSOR_XY',
    0xE7: 'CMP_CURSOR_X', 0xE8: 'RNG_CHECK', 0xE9: 'CALL_ROOM_HANDLER',
    0xEA: 'COND_STATE_ACTION', 0xEB: 'CHECK_FLAG_EB', 0xEC: 'CHECK_FLAG_EC',
    0xED: 'UNIT_CHECK_LOOP', 0xEE: 'SPEND_CREDITS', 0xEF: 'CHECK_CREDITS',
    0xF0: 'SET_TEXT_MARGINS', 0xF1: 'ADD_TO_STATE', 0xF2: 'ROOM_DESCRIPTION',
    0xF3: 'SHOP_INTERACTION', 0xF4: 'SET_STATE_VALUE', 0xF5: 'SHOP_DISPATCH',
    0xF6: 'CHECK_CONDITION', 0xF7: 'STATE_COND_CHECK', 0xF8: 'JUMP_FORWARD',
    0xF9: 'JUMP_INDEXED', 0xFA: 'DRAW_SPRITE', 0xFB: 'ADVANCE_INPUT',
    0xFC: 'RENDER_TEXT', 0xFD: 'SET_FONT2', 0xFE: 'SET_FONT', 0xFF: 'EXIT',
}

CONTENT_TYPE_NAMES = {
    0xC0EC: 'dialogue/story',
    0xC0F5: 'shop/service',
    0xC0F4: 'special',
    0xC0DA: 'endgame',
}

# ============================================================
# STATE
# ============================================================
class BldState:
    def __init__(self):
        self.credits = 0
        self.cursor_x = 0
        self.cursor_y = 0
        self.flag_d450 = 0
        self.flag_d451 = 0
        self.w3938 = 0
        self.state_array = [0] * 256
        self.left_margin = 0
        self.right_margin = 0
        self.exit_flag = 0
        self.bld_type = 0
        self.bld_content_type = 0
        self.bld_subtype = 0
        self.paragraph_count = 0
        self.opcode_counts = {}
        self.jumps_taken = 0
        self.paragraph_index = 0

    def spend_credits(self, value):
        if self.credits >= value:
            self.credits -= value
            return True
        return False

    def has_credits(self, value):
        return self.credits >= value

# ============================================================
# INTERPRETER
# ============================================================
class BldInterpreter:
    def __init__(self, data, filename):
        self.data = data
        self.filename = filename
        self.offset = 0
        self.state = BldState()
        self.trace = []
        self.narrative_stack = []
        self.current_narrative = None
        self.paragraph_started = False

    def peek(self):
        return self.data[self.offset] if self.offset < len(self.data) else None

    def read(self, n=1):
        if self.offset + n > len(self.data):
            return None
        result = self.data[self.offset:self.offset + n]
        self.offset += n
        return result

    def read_byte(self):
        if self.offset >= len(self.data):
            return None
        b = self.data[self.offset]
        self.offset += 1
        return b

    def read_word(self):
        """Read 2-byte LE unsigned word."""
        b = self.read(2)
        if b is None or len(b) < 2:
            return None
        return b[0] | (b[1] << 8)

    def read_signed_word(self):
        w = self.read_word()
        if w is None:
            return None
        if w >= 0x8000:
            w -= 0x10000
        return w

    def skip(self, n):
        self.offset += n

    def here(self):
        return self.offset

    def trace_add(self, msg):
        self.trace.append({'offset': self.offset, 'msg': msg})

    # ---- PARSING ----

    def parse_header(self):
        if len(self.data) < 8:
            return
        self.state.bld_type = self.data[0]
        self.state.paragraph_count = self.data[1]
        sig = self.data[2:6]
        ct = (self.data[6] << 8) | self.data[7]
        self.state.bld_content_type = ct
        ct_name = CONTENT_TYPE_NAMES.get(ct, f'unknown({ct:04x})')

        info = {
            'type': f'{self.data[0]:02x}',
            'paragraphs': self.data[1],
            'signature': sig.hex(),
            'content': ct_name,
        }
        if len(self.data) > 8:
            info['subtype'] = f'{self.data[8]:02x}'
            self.state.bld_subtype = self.data[8]

        self.trace_add(f'HEADER: {json.dumps(info)} | SIZE={len(self.data)}b')
        self.offset = 8

    # ---- MAIN INTERPRET LOOP ----

    def interpret(self):
        self.parse_header()

        while not self.state.exit_flag and self.offset < len(self.data):
            b = self.peek()
            if b is None:
                break

            if b < 0x80:
                self.handle_transparent()
            elif 0x80 <= b <= 0xC3:
                self.handle_noop_range()
            elif 0xC4 <= b <= 0xE3:
                self.read_byte()
                self.trace_add(f'op?({b:02x})')
            else:  # 0xE4-0xFF
                self.handle_opcode()

        if self.state.exit_flag:
            self.trace_add('EXIT (opcode FF)')
        else:
            self.trace_add('(end of data)')

    # ---- HANDLERS ----

    def handle_transparent(self):
        """Bytes 0x00-0x7F: transparent. Cipher text passes through at this layer."""
        start = self.here()
        text, length = decode_cipher_run(self.data, start)
        if length > 0:
            self.skip(length)
            # Only log significant text runs
            if len(text) > 3:
                self.trace_add(f'TEXT: "{text}"')
        else:
            # Single non-cipher byte
            b = self.read_byte()
            if b is not None:
                if b == 0x00:
                    self.trace_add('(null)')
                elif b == 0x0D:
                    self.trace_add('(cr)')
                elif b == 0x09:
                    self.trace_add('(tab)')
                elif b == 0x13:
                    self.trace_add('(pad)')
                elif b in (0x02, 0x06):
                    self.trace_add(f'(break)')
                elif b == 0x20:
                    self.trace_add('(space)')
                else:
                    self.trace_add(f'(byte_{b:02x})')

    def handle_noop_range(self):
        """Bytes 0x80-0xC3: enter switch but match no cases. No-ops at opcode layer."""
        b = self.read_byte()

        # Decode the no-op byte's meaning
        if b in NARRATIVE_NAMES:
            self.trace_add(NARRATIVE_NAMES[b])
        elif b == 0xC0:
            self.trace_add('(c0)')
        elif b == 0xA0:
            self.trace_add('(space)')
        elif b == 0x99:
            self.trace_add('(period)')
        elif b == 0x9A:
            self.trace_add('(comma)')
        elif b == 0xB9:
            self.trace_add('(lparen)')
        elif b == 0xBA:
            self.trace_add('(rparen)')
        elif b == 0xBC:
            self.trace_add('(lbracket)')
        elif b == 0xBD:
            self.trace_add('(rbracket)')
        elif b == 0x84:
            self.trace_add('(new_sentence)')
        elif b == 0x87:
            self.trace_add('(new_para)')
        elif b == 0x94:
            self.trace_add('(sentence_cont)')
        elif 0x9D <= b <= 0x9F:
            self.trace_add(f'(count:{b-0x9C})')
        elif 0xAF <= b <= 0xBF:
            # Price encoding
            if b <= 0xB3:
                val = 40 + (b - 0xAF)
            else:
                base = b - 0xB0
                if base <= 8:
                    val = 96 + base * 2
                else:
                    val = 96 + (b - 0xB0) * 2 + 1
            self.trace_add(f'(price_{val})')
        elif b == 0xD0:
            self.trace_add('(par_start)')
        elif b == 0xD7:
            self.trace_add('(interact_end)')
        else:
            self.trace_add(f'(noop_{b:02x})')

    # ---- OPCODE HANDLERS ----

    def handle_opcode(self):
        op = self.read_byte()
        name = OPCODE_NAMES.get(op, f'UNK_{op:02x}')
        self.state.opcode_counts[op] = self.state.opcode_counts.get(op, 0) + 1

        handler = getattr(self, f'x{op:02x}', None)
        if handler:
            handler(op, name)
        else:
            self.trace_add(f'{name} (NYI)')

    def xe4(self, op, name):
        """WRITE_CHAR: read 1 byte operand → write as character."""
        v = self.read_byte()
        if v is not None:
            ch = chr(v) if 0x20 <= v < 0x7F else f'\\x{v:02x}'
            self.trace_add(f'{name} {ch}')

    def xe5(self, op, name):
        """ADD_CREDITS: read 2-byte signed LE, add to credits."""
        v = self.read_signed_word()
        if v is not None:
            self.state.credits += v
            if self.state.credits < 0:
                self.state.credits = 0
            self.trace_add(f'{name} {v:+d} → {self.state.credits}')

    def xe6(self, op, name):
        """SET_CURSOR_XY: read 2×2-byte signed LE, set X and Y."""
        x = self.read_signed_word()
        y = self.read_signed_word()
        if x is not None and y is not None:
            old = (self.state.cursor_x, self.state.cursor_y)
            self.state.cursor_x = x
            self.state.cursor_y = y
            self.trace_add(f'{name} ({x},{y}) [was ({old[0]},{old[1]})]')

    def xe7(self, op, name):
        """CMP_CURSOR_X: read 2-byte LE. If == cursor_x: jump. Else skip 2."""
        v = self.read_signed_word()
        if v is None:
            return
        if self.state.cursor_x == v:
            target = self.read_word()
            self.trace_add(f'{name} X={v} == curX → jump[{target:04X}]')
            if target is not None and target < len(self.data):
                self.state.jumps_taken += 1
                self.offset = target
        else:
            self.trace_add(f'{name} X={v} != curX → skip2')
            self.skip(2)

    def xe8(self, op, name):
        """RNG_CHECK: read 1 byte mask. If RNG&mask: jump. Else skip 2."""
        mask = self.read_byte()
        if mask is None:
            return
        # Deterministic pseudo-RNG (offset-based)
        rng = (self.here() * 0x15A4E35 + 0x3B9ACA07) & 0x7FFF
        result = rng & mask
        if result:
            target = self.read_word()
            self.trace_add(f'{name} mask={mask:02x} → RNG&mask={result} jump[{target:04X}]')
            if target is not None and target < len(self.data):
                self.state.jumps_taken += 1
                self.offset = target
        else:
            self.trace_add(f'{name} mask={mask:02x} → RNG&mask=0 skip2')
            self.skip(2)

    def xe9(self, op, name):
        """CALL_ROOM_HANDLER: read 1 byte, dispatch room handler."""
        v = self.read_byte()
        if v is not None:
            labels = {0xE8: 'citadel_atk', 0xED: 'arena', 0xF3: 'shop', 0xF5: 'repair'}
            lbl = labels.get(v, f'h{v:02x}')
            self.trace_add(f'{name} {lbl}')

    def xea(self, op, name):
        """COND_STATE_ACTION: read 1 byte index. If w3938==0: action."""
        idx = self.read_byte()
        if idx is None:
            return
        if self.state.w3938 == 0:
            extra = self.read_byte()
            self.trace_add(f'{name} idx={idx:02x} extra={extra:02x}')
        else:
            self.trace_add(f'{name} idx={idx:02x} (w3938!=0)')
        self.skip(1)  # alignment skip

    def xeb(self, op, name):
        """CHECK_FLAG_EB: if flag_d451: jump. Else skip 2."""
        if self.state.flag_d451:
            target = self.read_word()
            self.trace_add(f'{name} d451=1 → jump[{target:04X}]')
            if target is not None and target < len(self.data):
                self.state.jumps_taken += 1
                self.offset = target
        else:
            self.trace_add(f'{name} d451=0 → skip2')
            self.skip(2)

    def xec(self, op, name):
        """CHECK_FLAG_EC: if flag_d450: jump. Else skip 2."""
        if self.state.flag_d450:
            target = self.read_word()
            self.trace_add(f'{name} d450=1 → jump[{target:04X}]')
            if target is not None and target < len(self.data):
                self.state.jumps_taken += 1
                self.offset = target
        else:
            self.trace_add(f'{name} d450=0 → skip2')
            self.skip(2)

    def xed(self, op, name):
        """UNIT_CHECK_LOOP: read 2 bytes (index, threshold). Check 8 units."""
        idx = self.read_byte()
        thresh = self.read_byte()
        if idx is None or thresh is None:
            return
        self.trace_add(f'{name} idx={idx:02x} thresh={thresh:02x} → pass')
        target = self.read_word()
        if target is not None and target < len(self.data):
            self.state.jumps_taken += 1
            self.offset = target

    def xee(self, op, name):
        """SPEND_CREDITS: read 2-byte signed LE, deduct."""
        v = self.read_signed_word()
        if v is not None:
            ok = self.state.spend_credits(v)
            self.trace_add(f'{name} {v} credits={self.state.credits}')

    def xef(self, op, name):
        """CHECK_CREDITS: read 2-byte LE. If have credits: jump. Else skip 2."""
        v = self.read_signed_word()
        if v is None:
            return
        if self.state.has_credits(v):
            target = self.read_word()
            self.trace_add(f'{name} {v} have={self.state.credits} → jump[{target:04X}]')
            if target is not None and target < len(self.data):
                self.state.jumps_taken += 1
                self.offset = target
        else:
            self.trace_add(f'{name} {v} need {v} have {self.state.credits} → skip2')
            self.skip(2)

    def xf0(self, op, name):
        """SET_TEXT_MARGINS: read 2 bytes (left, right)."""
        left = self.read_byte()
        right = self.read_byte()
        if left is not None and right is not None:
            self.state.left_margin = left
            self.state.right_margin = right
            self.trace_add(f'{name} L={left} R={right}')

    def xf1(self, op, name):
        """ADD_TO_STATE: read 2 bytes (index, value). state[index] += value."""
        idx = self.read_byte()
        val = self.read_byte()
        if idx is not None and val is not None:
            old = self.state.state_array[idx]
            self.state.state_array[idx] = (old + val) & 0xFF
            self.trace_add(f'{name} s[{idx:02x}] += {val:02x} ({old:02x}→{self.state.state_array[idx]:02x})')

    def xf2(self, op, name):
        """ROOM_DESCRIPTION: render room description."""
        self.trace_add(f'{name}')

    def xf3(self, op, name):
        """SHOP_INTERACTION: read 1 byte index. state_val * 2 = indirect offset."""
        idx = self.read_byte()
        if idx is not None:
            sv = self.state.state_array[idx]
            self.trace_add(f'{name} idx={idx:02x} s[{idx:02x}]={sv:02x}')

    def xf4(self, op, name):
        """SET_STATE_VALUE: read 2 bytes (index, value). state[index] = value."""
        idx = self.read_byte()
        val = self.read_byte()
        if idx is not None and val is not None:
            old = self.state.state_array[idx]
            self.state.state_array[idx] = val
            self.trace_add(f'{name} s[{idx:02x}] = {val:02x} ({old:02x}→{val:02x})')

    def xf5(self, op, name):
        """SHOP_DISPATCH: read 1 byte → call fn1CD3_0004(case)."""
        case = self.read_byte()
        if case is not None:
            self.trace_add(f'{name} case=0x{case:02x}')

    def xf6(self, op, name):
        """CHECK_CONDITION: call fn0800_1A13(1). If true: jump. Else skip 2."""
        self.trace_add(f'{name} → pass (default)')
        target = self.read_word()
        if target is not None and target < len(self.data):
            self.state.jumps_taken += 1
            self.offset = target

    def xf7(self, op, name):
        """STATE_COND_CHECK: read 1 byte index. If state[idx]!=0: jump. Else skip 2."""
        idx = self.read_byte()
        if idx is None:
            return
        if self.state.state_array[idx] != 0:
            target = self.read_word()
            self.trace_add(f'{name} s[{idx:02x}]={self.state.state_array[idx]:02x} !=0 → jump[{target:04X}]')
            if target is not None and target < len(self.data):
                self.state.jumps_taken += 1
                self.offset = target
        else:
            self.trace_add(f'{name} s[{idx:02x}]=0 → skip2')
            self.skip(2)

    def xf8(self, op, name):
        """JUMP_FORWARD: read 2-byte WORD → absolute jump target."""
        target = self.read_word()
        if target is not None:
            self.trace_add(f'{name} → [{target:04X}]')
            if target < len(self.data):
                self.state.jumps_taken += 1
                self.offset = target

    def xf9(self, op, name):
        """JUMP_INDEXED: read 1 byte. Get menu selection index. skip = index*2+2."""
        v = self.read_byte()
        if v is not None:
            # Assume menu selection 0 (default)
            skip = 2
            self.trace_add(f'{name} op={v:02x} (menu idx=0) skip={skip}')
            self.skip(skip)

    def xfa(self, op, name):
        """DRAW_SPRITE: read 1 byte sprite ID."""
        sid = self.read_byte()
        if sid is not None:
            self.trace_add(f'{name} sprite={sid:02x}')

    def xfb(self, op, name):
        """ADVANCE_INPUT: wait for key."""
        self.trace_add(f'{name}')

    def xfc(self, op, name):
        """RENDER_TEXT: read/decode cipher text at current position.
        Renders via fn1E56_03F5, then advances past string length."""
        start = self.here()
        text, length = decode_cipher_run(self.data, start)
        if length > 0:
            self.skip(length)
            # Skip terminator (0x6B or 0x00)
            term = self.peek()
            if term in (0x00, 0x6B):
                self.read_byte()
            self.trace_add(f'{name} "{text}"')
        else:
            self.trace_add(f'{name} (empty@{start:04X})')

    def xfd(self, op, name):
        """SET_FONT2: call fn1E56_0388."""
        self.trace_add(f'{name}')

    def xfe(self, op, name):
        """SET_FONT: read 1 byte font ID."""
        fid = self.read_byte()
        if fid is not None:
            self.trace_add(f'{name} font={fid:02x}')

    def xff(self, op, name):
        """EXIT: stop interpreter."""
        self.state.exit_flag = 1
        self.trace_add(f'{name}')


# ============================================================
# OUTPUT
# ============================================================
def format_trace(trace):
    lines = []
    i = 0
    while i < len(trace):
        t = trace[i]
        off = t['offset']
        msg = t['msg']
        lines.append(f'  [{off:04X}] {msg}')
        i += 1
    return '\n'.join(lines)


def format_summary(state, trace):
    ops_total = sum(state.opcode_counts.values())
    ops_types = len(state.opcode_counts)
    ct_name = CONTENT_TYPE_NAMES.get(state.bld_content_type, f'type_{state.bld_content_type:04x}')

    lines = [
        f'  Content: {ct_name} | Paragraphs: {state.paragraph_count}',
        f'  Opcodes: {ops_total} ({ops_types} types) | Jumps: {state.jumps_taken}',
        f'  Credits: {state.credits} | (Cursor: {state.cursor_x},{state.cursor_y})',
        f'  Flags: d450={state.flag_d450} d451={state.flag_d451}',
    ]

    if state.opcode_counts:
        lines.append(f'  Opcode breakdown:')
        for op in sorted(state.opcode_counts):
            name = OPCODE_NAMES.get(op, f'UNK_{op:02x}')
            cnt = state.opcode_counts[op]
            bar = '#' * min(cnt, 40)
            lines.append(f'    {op:02x} {name:20s} {cnt:4d} {bar}')

    return '\n'.join(lines)


# ============================================================
# MAIN
# ============================================================
def main():
    bld_dir = os.path.dirname(os.path.abspath(__file__))
    output_all = []
    summary_rows = []

    for fname in sorted(os.listdir(bld_dir)):
        if not fname.upper().endswith('.BLD'):
            continue
        fpath = os.path.join(bld_dir, fname)
        with open(fpath, 'rb') as f:
            data = f.read()

        print(f"\n{'='*70}")
        print(f"FILE: {fname}  ({len(data)} bytes)")
        print(f"{'='*70}")

        interp = BldInterpreter(data, fname)
        interp.interpret()

        trace_text = format_trace(interp.trace)
        summary = format_summary(interp.state, interp.trace)

        print(trace_text)
        print(f"\n{'='*50}")
        print(summary)

        output_all.append(f"{'='*70}")
        output_all.append(f"FILE: {fname} ({len(data)} bytes)")
        output_all.append(f"{'='*70}")
        output_all.append(trace_text)
        output_all.append(f"\n{'='*50}")
        output_all.append(summary)
        output_all.append('')

        ops = sum(interp.state.opcode_counts.values())
        jmp = interp.state.jumps_taken
        summary_rows.append(f"  {fname:20s} | para={interp.state.paragraph_count:2d} | ops={ops:4d} | jumps={jmp:4d}")

    out_path = os.path.join(bld_dir, 'decode_bld_interp_output.txt')
    with open(out_path, 'w') as f:
        f.write('\n'.join(output_all))
    print(f"\nFull output: {out_path}")

    print(f"\n{'='*70}")
    print(f"SUMMARY")
    print(f"{'='*70}")
    for r in summary_rows:
        print(r)


if __name__ == '__main__':
    main()
