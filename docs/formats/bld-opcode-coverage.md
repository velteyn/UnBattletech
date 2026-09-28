# BLD Opcode Coverage

> Audit (2026-09-28) of which `.BLD` bytecode opcodes the **26 shipped scripts actually contain**,
> versus what the docs specify and what the Godot interpreter implements.
> Generator: `tools/bld/opcode_coverage.py`.

## Method

1. **Decrypt** the buffer from offset `0xA0` (`((b + 0x29) & 0xFF) ^ 0xE9`). The original game
   decrypts the whole `.BLD` buffer in place at load time — Reko `fn0FDC_1D94`:
   `loop i < 0x2328 { buffer[0xA0+i] += 0x29; ^= 0xE9 }`. The interpreter base is `0xA0`.
2. **Linear walk** from `0xA0`: bytes `< 0x80` = ASCII text; `0x80–0xE3` = structural marker (skip);
   `0xE4–0xFF` = opcode (+ operand bytes, table below).
3. Count each opcode slot and the files it appears in.

Because it is a linear walk (no jump/conditional following), counts are a **superset** of what a given
playthrough executes; the *presence* per file is what matters here.

## Opcode table (0xE4–0xFF = 28 slots)

Operand sizes verified against Reko `fn0FDC_01C0` (+ r2 machine code); see
[`bld-bytecode.md`](bld-bytecode.md) for the dispatch table.

| Op | Name | Operand | Seen | #Files | C# `ExecuteOpcode` |
|----|------|---------|-----:|-------:|--------------------|
| `0xE4` | WRITE_CHAR | 1 | 33 | 3 | impl |
| `0xE5` | ADD_CREDITS | 2 | 3 | 2 | impl |
| `0xE6` | SET_CURSOR_XY | 4 | 4 | 3 | impl |
| `0xE7` | CMP_CURSOR_X | 4 | **0** | **0** | impl |
| `0xE8` | RNG_CHECK | 3 | 7 | 4 | impl |
| `0xE9` | CALL_ROOM_HANDLER | 1 | 4 | 4 | impl |
| `0xEA` | COND_STATE_ACTION | 2 | 20 | 9 | impl |
| `0xEB` | CHECK_FLAG_EB | 2 | 1 | 1 | impl |
| `0xEC` | CHECK_FLAG_EC | 2 | 1 | 1 | impl |
| `0xED` | UNIT_CHECK_LOOP | 2 | 7 | 3 | impl |
| `0xEE` | SPEND_CREDITS | 2 | 8 | 5 | impl |
| `0xEF` | CHECK_CREDITS | 2 | 9 | 6 | impl |
| `0xF0` | SET_TEXT_MARGINS | 2 | 16 | 6 | impl |
| `0xF1` | ADD_TO_STATE | 2 | 7 | 4 | impl |
| `0xF2` | ROOM_DESCRIPTION | 0 | 201 | 26 | impl (`FlushText`) |
| `0xF3` | SHOP_INTERACTION | 1 | 10 | 4 | impl |
| `0xF4` | SET_STATE_VALUE | 2 | 73 | 18 | impl |
| `0xF5` | SHOP_DISPATCH | 1 | 89 | 19 | impl |
| `0xF6` | CHECK_CONDITION | **2** | 16 | 10 | impl (predicate TODO) |
| `0xF7` | STATE_COND_CHECK | **3** | 64 | 18 | impl |
| `0xF8` | JUMP_FORWARD | 2 | 164 | 17 | impl |
| `0xF9` | JUMP_INDEXED | 1 | 26 | 13 | impl |
| `0xFA` | DRAW_SPRITE | 1 | 6 | 5 | impl |
| `0xFB` | ADVANCE_INPUT | 0 | 234 | 26 | impl |
| `0xFC` | RENDER_TEXT | variable | 389 | 26 | impl |
| `0xFD` | SET_FONT2 | 0 | 208 | 25 | **no-op** |
| `0xFE` | SET_FONT | 1 | 16 | 6 | **no-op** |
| `0xFF` | STOP_INTERPRETER | 0 | 75 | 26 | impl |

**Distinct seen: 27 / 28.** Only `0xE7` (CMP_CURSOR_X) was not observed. It is implemented in the
original (`l0FDC_0504`) and in the C# interpreter, but the shipped scripts do not appear to use it
(menu/cursor dispatch is done via `0xF3`/`0xF9` instead). Treat as "unused in corpus", not "removed".

## Findings

1. **Doc bug fixed — `0xEB`/`0xEC` operand size.** `bld-bytecode.md` said "0 bytes" (skip forward).
   Both take a **2-byte WORD absolute jump target**: Reko `l0FDC_047A`/`l0FDC_0487` →
   `jmp l0FDC_02CB` → on flag==0 `l0FDC_0567` does `add word [bp-0Ah], 2` (skip 2), else reads the
   WORD as the new ip. Confirmed in r2 machine code (skip path `0000:8327: add word [bp-0xa], 2`).
   The C# interpreter and `AGENTS.md` already had this right.

2. **"26 opcodes" is wrong.** The opcode range is `0xE4–0xFF` = **28 slots**; **27 appear** in the
   corpus. Earlier docs conflated "slots" with "opcodes used".

3. **`0xF6`/`0xF7` operand sizes + C# bodies fixed.** Reko `fn0FDC_01C0`:
   - `0xF6` CHECK_CONDITION (`case ~0x09`) takes a **2-byte WORD target only** (no index byte); jump
     when `fn0800_1A13(1) != 0`, else skip. `bld-bytecode.md` said "0 bytes"; the C# read a phantom
     index byte first (misaligning the stream after every `0xF6`). Fixed to a 2-byte operand.
     The `fn0800_1A13(1)` predicate itself is **not yet modelled** (consumed, no jump) — flagged.
   - `0xF7` STATE_COND_CHECK (`case ~0x08`) takes **1 byte (D30C index) + 2-byte WORD target**; jump
     when `D30C[index] != 0`, else skip. `bld-bytecode.md` said "1 byte"; the C# read the index but
     **never consumed the target word** on the true branch (misalignment). Fixed.

4. **`tools/bld/decode_bld_interp.py` is stale for opcodes/control-flow.** It walks the **raw** file
   from **offset 8** (the pre-`0xA0` metadata region) *without decrypting*, so it treats metadata as
   bytecode and dispatches on **encrypted** opcode bytes. Its extracted **text is still fine** (the
   `CIPHER` table applied to raw bytes equals the decrypted ASCII), but its opcode counts, jump
   targets and `CHECK_FLAG`/`RNG` traces are **false positives** (e.g. it reported jump targets like
   `0xEBD1`, far beyond the file). Use `opcode_coverage.py` for opcode/control-flow analysis; do not
   trust the old tool's trace for control flow.

5. **The Godot interpreter's `default` branch is unreachable** for `0xE4–0xFF` (all 28 are
   `BldOpcode` members), so the README's "unknown opcodes are silently skipped" is imprecise: the
   silent skips are unmapped bytes `< 0xE4` (structural markers, by design). Nothing in the opcode
   range is dropped.

## Recommendations

- Keep `bld-bytecode.md` as the operand/semantics source of truth; it now matches Reko+r2.
- Add a C# unit test that asserts every opcode byte present in the corpus is handled (guards future
  `default` hits) and, ideally, that the interpreter's operand sizes match this table.
- Port the tooling note: deprecate `decode_bld_interp.py`'s trace for control-flow claims.
