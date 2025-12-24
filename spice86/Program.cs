// Debug your project with "-e path/to/exe" in your launch settings.
// Use "-a "some string"" to pass arguments to the emulated program.
// See https://github.com/OpenRakis/Spice86 for more information

using GHIDRAMCP;

// Put the SHA256 checksum of your target DOS program here.
Spice86.Program.RunWithOverrides<MyOverrideSupplier>(args, "SUPPORTED_EXE_CHECKSUM");

public partial class Program
{
}