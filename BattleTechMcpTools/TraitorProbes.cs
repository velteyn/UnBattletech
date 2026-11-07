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

        // 017D:17BB cursor transit — target + caller + live cursor.
        add(0x017D, 0x17BB, "probe_cursor_transit", () => {
            ushort retIp = stk(0), retCs = stk(2), a0 = stk(4), a1 = stk(6);
            ushort curSeg = u16(cpu.DS, 0x538C);
            string cur = curSeg == 0
                ? "?"
                : $"{u16(curSeg, 0xA44B):X4},{u16(curSeg, 0xA44D):X4}";
            log.LogInformation(
                "PROBE 17BB transit target=({A:X4},{B:X4}) cursor=({C}) caller={Cs:X4}:{Ip:X4}",
                a0, a1, cur, retCs, retIp);
        });

        // 11B8:000A round wrap-up entry — gate inputs each round.
        add(0x11B8, 0x000A, "probe_wrapup_entry", () => {
            log.LogInformation(
                "PROBE 000A wrap-up 014A={F:X4} D333={D3} D332={D2} D331={D1} w374A={W:X4}",
                u16(0x3858, 0x014A),
                u16(0x2A0F, 0xD333), u16(0x2A0F, 0xD332), u16(0x2A0F, 0xD331),
                u16(0x2A0F, 0x374A));
        });

        // 18BA:086A epilogue display/sync — proves the Gate B tail ran.
        add(0x18BA, 0x086A, "probe_epilogue_sync", () => {
            log.LogInformation("PROBE 086A epilogue-sync D333={D}",
                u16(0x2A0F, 0xD333));
        });

        // 11B8:27C9 map-FX marker — args (0x7E, X, Y).
        add(0x11B8, 0x27C9, "probe_mapfx", () => {
            log.LogInformation("PROBE 27C9 mapfx marker={M:X4} X={X} Y={Y}",
                stk(4), stk(6), stk(8));
        });

        // 17D3:03F5 text print — only traitor-string range (0x3400-0x38FF),
        // with the first bytes of text so outputs are distinguishable.
        add(0x17D3, 0x03F5, "probe_print", () => {
            ushort strOff = cpu.AX;
            if (strOff < 0x3400 || strOff >= 0x3900) {
                return;
            }
            ushort ds = cpu.DS;
            var chars = new char[48];
            int n = 0;
            for (; n < chars.Length; n++) {
                byte b = mem.UInt8[ds, (ushort)(strOff + n)];
                if (b == 0) {
                    break;
                }
                chars[n] = b is >= 32 and < 127 ? (char)b : '.';
            }
            log.LogInformation("PROBE 03F5 print DS:{Ds:X4}:{Ax:X4} \"{T}\"",
                ds, strOff, new string(chars, 0, n));
        });
    }
}
