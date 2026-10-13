#!/usr/bin/env python3
"""
BLD opcode coverage — CORRECT enumerator.

Supersedes the opcode/trace part of `decode_bld_interp.py`, which reads the file from
offset 8 WITHOUT decrypting. The original game decrypts the whole `.BLD` buffer in place
from offset 0xA0 at load time (Reko `fn0FDC_1D94`: loop `i < 0x2328`,
`add al,0x29 ; xor al,0xE9`), and the interpreter base is 0xA0. So the authoritative
bytecode view is:  decrypt(file[0xA0:])  then walk.

Opcode operand sizes come from `docs/formats/bld-bytecode.md` (EB/EC corrected to a 2-byte
WORD jump target — verified against Reko + r2 machine code).

This is a *linear* walk: it does not follow jumps / conditional skips, so it counts every
opcode slot present in the stream (a superset of what a given playthrough executes).
Report is by opcode, with the files it appears in.
"""
import glob
import os
import sys
import collections

# operand bytes following the opcode (0xE4-0xFF)
OPLEN = {
    0xE4: 1, 0xE5: 2, 0xE6: 4, 0xE7: 4, 0xE8: 3, 0xE9: 1, 0xEA: 2, 0xEB: 2, 0xEC: 2,
    0xED: 2, 0xEE: 2, 0xEF: 2, 0xF0: 2, 0xF1: 2, 0xF2: 0, 0xF3: 1, 0xF4: 2, 0xF5: 1,
    0xF6: 2, 0xF7: 3, 0xF8: 2, 0xF9: 1, 0xFA: 1, 0xFB: 0, 0xFC: -1, 0xFD: 0, 0xFE: 1,
    0xFF: 0,
}
NAMES = {
    0xE4: "WRITE_CHAR", 0xE5: "ADD_CREDITS", 0xE6: "SET_CURSOR_XY", 0xE7: "CMP_CURSOR_X",
    0xE8: "RNG_CHECK", 0xE9: "CALL_ROOM_HANDLER", 0xEA: "COND_STATE_ACTION",
    0xEB: "CHECK_FLAG_EB", 0xEC: "CHECK_FLAG_EC", 0xED: "UNIT_CHECK_LOOP",
    0xEE: "SPEND_CREDITS", 0xEF: "CHECK_CREDITS", 0xF0: "SET_TEXT_MARGINS",
    0xF1: "ADD_TO_STATE", 0xF2: "ROOM_DESCRIPTION", 0xF3: "SHOP_INTERACTION",
    0xF4: "SET_STATE_VALUE", 0xF5: "SHOP_DISPATCH", 0xF6: "CHECK_CONDITION",
    0xF7: "STATE_COND_CHECK", 0xF8: "JUMP_FORWARD", 0xF9: "JUMP_INDEXED",
    0xFA: "DRAW_SPRITE", 0xFB: "ADVANCE_INPUT", 0xFC: "RENDER_TEXT", 0xFD: "SET_FONT2",
    0xFE: "SET_FONT", 0xFF: "STOP_INTERPRETER",
}

# bytes 0x80-0xE3 that are *text* (uppercase cipher / space); everything else there is structural
TEXTISH_EXTRA = {0x9B, 0x9C, 0x9E, 0x9F, 0xA5, 0xC0, 0xBA, 0xBB}


def decrypt_buffer(data: bytearray) -> bytearray:
    out = bytearray(data)
    for i in range(0xA0, len(out)):
        out[i] = ((out[i] + 0x29) & 0xFF) ^ 0xE9
    return out


def walk(path):
    data = decrypt_buffer(bytearray(open(path, "rb").read()))
    buf = data[0xA0:]
    ip = 0
    counts = collections.Counter()
    text = []
    while ip < len(buf):
        b = buf[ip]
        if b < 0x80:                      # decrypted ASCII text
            text.append(chr(b) if 32 <= b < 127 else " ")
            ip += 1
            continue
        if b >= 0xE4:                     # opcode
            counts[b] += 1
            length = OPLEN[b]
            if length < 0:               # 0xFC RENDER_TEXT: consume a cipher/text run
                ip += 1
                while ip < len(buf) and (
                    buf[ip] < 0x80 or buf[ip] == 0xA0 or 0x80 < buf[ip] <= 0x96
                    or buf[ip] in TEXTISH_EXTRA
                ):
                    if 32 <= buf[ip] < 127:
                        text.append(chr(buf[ip]))
                    ip += 1
                continue
            ip += 1 + length
            continue
        ip += 1                            # structural marker (0x80-0xE3)
    return counts, "".join(text)


def main():
    root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))
    files = sorted(glob.glob(os.path.join(root, "original", "bld", "*.BLD")))
    if not files:
        print("no BLD files found under original/bld/", file=sys.stderr)
        return 1
    total = collections.Counter()
    per_op_files = collections.defaultdict(set)
    per_file = {}
    for f in files:
        name = os.path.basename(f)[:-4]
        counts, _ = walk(f)
        per_file[name] = sum(counts.values())
        for op, n in counts.items():
            total[op] += n
            per_op_files[op].add(name)

    print(f"files={len(files)}  total opcode slots={sum(total.values())}")
    print(f"{'op':>4} {'name':<20} {'count':>6} {'#files':>6}")
    for op in range(0xE4, 0x100):
        mark = "" if op in total else "  <-- NOT SEEN"
        print(f" 0x{op:02X} {NAMES.get(op,'?'):<20} {total.get(op,0):>6} {len(per_op_files[op]):>6}{mark}")
    print(f"distinct seen: {len(total)}/28")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
