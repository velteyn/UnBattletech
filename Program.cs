// Debug your project with "-e path/to/exe" in your launch settings.
// Use "-a "some string"" to pass arguments to the emulated program.
// See https://github.com/OpenRakis/Spice86 for more information
    
using UNBATTLETECH;

// Put the SHA256 checksum of your target DOS program here. (BTECH.EXE)
Spice86.Program.RunWithOverrides<MyOverrideSupplier>(args, "15a1712682cf1fe50ca9e6a68a4b31d3bef7912401915edf7bb6242be193562a");

public partial class Program
{
}