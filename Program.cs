// Debug your project with "-e path/to/exe" in your launch settings.
// Use "-a "some string"" to pass arguments to the emulated program.
// See https://github.com/OpenRakis/Spice86 for more information

using BattleTechMcpTools;

// Put the SHA256 checksum of your target DOS program here. (BTECH.EXE)
Spice86.Program.RunWithOverrides<BattleTechOverrideSupplier>(
    args, "e29007761fadd8679521d1fb1dc6b488f87c718ed8a4636cb4ffbe4bc4ed5306");

public partial class Program
{
}