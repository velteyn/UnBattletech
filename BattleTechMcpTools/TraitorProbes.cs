using Microsoft.Extensions.Logging;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;

namespace BattleTechMcpTools;

// Entry-hook probes (permissive: the C# body runs, then the interpreter
// continues at the untouched CS:IP — zero behavior change). Divide-and-conquer
// tracing for the S1 traitor turn (see docs/combat-system.md §25.6.11).
// Experiment-scoped: verbose by design; gate or remove before general use.
public static class TraitorProbes {
    public static void Register(
        IDictionary<SegmentedAddress, FunctionInformation> dst,
        Machine machine, ILogger log) {
        var mem = machine.Memory;
        var cpu = machine.CpuState;
        ushort u16(ushort seg, ushort off) => mem.UInt16[seg, off];
        // Stack args at function entry (far call already pushed retIP, retCS).
        ushort stk(ushort n) => mem.UInt16[cpu.SS, (ushort)(cpu.SP + n)];

        void add(ushort seg, ushort off, string name, Action body) {
            var addr = new SegmentedAddress(seg, off);
            dst[addr] = new FunctionInformation(addr, name, _ => () => {
                try {
                    body();
                } catch (Exception e) {
                    log.LogWarning(e, "PROBE {Name} failed", name);
                }
            });
        }

        // 017D:17BB cursor transit — target + caller + live cursor, plus the
        // FFFF guard (arrival wait has no timeout; rewrite FFFF to cursor).
        add(0x017D, 0x17BB, "probe_17BB_transit_guard", () => {
            ushort retIp = stk(0), retCs = stk(2), a0 = stk(4), a1 = stk(6);
            ushort curSeg = u16(cpu.DS, 0x538C);
            string cur = curSeg == 0
                ? "?"
                : $"{u16(curSeg, 0xA44B):X4},{u16(curSeg, 0xA44D):X4}";
            log.LogInformation(
                "PROBE 17BB transit target=({A:X4},{B:X4}) cursor=({C}) caller={Cs:X4}:{Ip:X4}",
                a0, a1, cur, retCs, retIp);
            ushort sp = cpu.SP, ss = cpu.SS;
            ushort cx = curSeg == 0 ? (ushort)0 : u16(curSeg, 0xA44B);
            ushort cy = curSeg == 0 ? (ushort)0 : u16(curSeg, 0xA44D);
            bool hit = false;
            if (u16(ss, (ushort)(sp + 4)) == 0xFFFF) {
                mem.UInt16[ss, (ushort)(sp + 4)] = cx;
                hit = true;
            }
            if (u16(ss, (ushort)(sp + 6)) == 0xFFFF) {
                mem.UInt16[ss, (ushort)(sp + 6)] = cy;
                hit = true;
            }
            if (hit) {
                log.LogWarning(
                    "GUARD 17BB rewrote FFFF transit target to cursor=({X:X4},{Y:X4})",
                    cx, cy);
            }
        });

        // 11B8:000A round wrap-up entry — gate inputs each round.
        add(0x11B8, 0x000A, "probe_wrapup_entry", () => {
            log.LogInformation(
                "PROBE 000A wrap-up 014A={F:X4} D333={D3} D332={D2} D331={D1} w374A={W:X4}",
                u16(0x3858, 0x014A),
                mem.UInt8[0x2A0F, 0xD333], mem.UInt8[0x2A0F, 0xD332],
                mem.UInt8[0x2A0F, 0xD331], u16(0x2A0F, 0x374A));
        });

        // 18BA:086A epilogue display/sync — proves the Gate B tail ran.
        add(0x18BA, 0x086A, "probe_epilogue_sync", () => {
            log.LogInformation("PROBE 086A epilogue-sync D333={D}",
                u16(0x2A0F, 0xD333));
        });

        // 11B8:27C9 map-FX marker — args (0x7E, X, Y).
        add(0x11B8, 0x27C9, "probe_mapfx", () => {
            ushort sp = cpu.SP, ss = cpu.SS;
            log.LogInformation("PROBE 27C9 mapfx marker={M:X4} X={X} Y={Y}",
                u16(ss, (ushort)(sp + 4)), u16(ss, (ushort)(sp + 6)),
                u16(ss, (ushort)(sp + 8)));
        });

        // 17BB transit guard: an FFFF target never converges (the arrival wait
        // has no timeout) and hangs the game with a live menu. Rewrite any FFFF
        // component to the live cursor position → instant no-op transit.
        // Zero behavior change for legitimate (bounded) targets.
        // (Folded into probe_17BB_transit_guard above — second add() on the
        // same address would overwrite the first in the dictionary.)

        // 17D3:03F5 text print — log everything (range tag marks traitor
        // strings 0x3400-0x38FF and known kill IDs); first bytes identify the
        // message. Temporarily unfiltered to discover kill-print AX values.
        // Name prints pass seg:off on the stack, so also log [SP+4]/[SP+6].
        add(0x17D3, 0x03F5, "probe_print", () => {
            // String is ALWAYS at [SP+4]:[SP+6]; AX sometimes mirrors the
            // offset (dialog calls), sometimes 0 (combat messages), and can
            // even mismatch the segment (0FAE:20A1: AX=0012 but text at
            // 2A0F:0012, 3858:0012 is CRT garbage). Always read the stack.
            ushort strOff = stk(4);
            ushort seg = stk(6);
            string tag = strOff >= 0x3400 && strOff < 0x3900 ? "TRAITOR"
                : strOff == 0x3EE7 || strOff == 0x3EDE || strOff == 0x41FC ? "KILL?"
                : "other";
            ushort ds = seg;
            var chars = new char[48];
            int n = 0;
            for (; n < chars.Length; n++) {
                byte b = mem.UInt8[ds, (ushort)(strOff + n)];
                if (b == 0) {
                    break;
                }
                chars[n] = b is >= 32 and < 127 ? (char)b : '.';
            }
            log.LogInformation("PROBE 03F5 [{K}] {Ds:X4}:{Ax:X4} \"{T}\" ax={A:X4} stk=[{S4:X4},{S6:X4}]",
                tag, ds, strOff, new string(chars, 0, n), cpu.AX, stk(4), stk(6));
        });

        // 1465:12C7 post-fire entry — where combat blow-by-blow text must live
        // (03F5 catch-all proved combat bypasses 03F5). Log regs + stack args.
        add(0x1465, 0x12C7, "probe_postfire", () => {
            log.LogInformation(
                "PROBE 12C7 postfire AX={Ax:X4} BX={Bx:X4} CX={Cx:X4} DX={Dx:X4} SI={Si:X4} DI={Di:X4} stk=[{S4:X4},{S6:X4},{S8:X4},{Sa:X4}]",
                cpu.AX, cpu.BX, cpu.CX, cpu.DX, cpu.SI, cpu.DI,
                stk(4), stk(6), stk(8), stk(10));
        });

        // 17D3:0281 dialog setup + 17D3:0388 dialog flush — heavily called
        // around prints; log AX + stack args to correlate with post-fire.
        add(0x17D3, 0x0281, "probe_dlg_setup", () => {
            log.LogInformation("PROBE 0281 AX={Ax:X4} stk=[{S4:X4},{S6:X4},{S8:X4}]",
                cpu.AX, stk(4), stk(6), stk(8));
        });
        add(0x17D3, 0x0388, "probe_dlg_flush", () => {
            log.LogInformation("PROBE 0388 AX={Ax:X4} stk=[{S4:X4},{S6:X4},{S8:X4}]",
                cpu.AX, stk(4), stk(6), stk(8));
        });
        // 0728:174C bar drawer — log (x, y, a, b) per bar + structure/heat.
        // Caller pushes: v_a(SI value), v_b(storybyte i), y, x, CS; callee
        // BP+6=x, BP+8=y, BP+10=v_b, BP+12=v_a. Definitive bar↔offset map.
        add(0x0728, 0x174C, "probe_bar", () => {
            log.LogInformation("PROBE 174C bar x={X:X4} y={Y:X4} vb={B:X4} va={A:X4}",
                stk(4), stk(6), stk(8), stk(10));
        });
    }
}
