namespace generated;

using Spice86.Core.CLI;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides
{
    public void RegisterOneFunction()
    {
        // Registering a single function as a starting point.
        // 0xC is likely a small helper function.
        DefineFunction(cs1, 0xC, ghidra_guess_0000_000C_0000C, false);
    }
}
