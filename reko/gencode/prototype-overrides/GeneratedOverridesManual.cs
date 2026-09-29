namespace generated;

using Spice86.Core.CLI;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public partial class GeneratedOverrides
{
    public void RegisterOneFunction()
    {
        // Registering MainGameLoop (1000:1ABA)
        // Correct segment calculation is handled in MyOverrideSupplier
        // cs7 is defined as entrySegment + 0x1000
        DefineFunction(cs7, 0x1ABA, ghidra_guess_1000_1ABA_11ABA, false);
    }
}
