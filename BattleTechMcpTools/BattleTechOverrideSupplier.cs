using Microsoft.Extensions.Logging;
using Spice86.Core.CLI;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.Mcp;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;
using System.IO;
using System.Reflection;

namespace BattleTechMcpTools;

public class BattleTechOverrideSupplier : IOverrideSupplier, IMcpToolSupplier
{
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(
        ILogger loggerService, Configuration configuration,
        ushort programStartAddress, Machine machine)
    {
        MountGameDataOnFloppyDrives(loggerService, configuration, machine);
        return new Dictionary<SegmentedAddress, FunctionInformation>();
    }

    // BattleTech resolves some overlay files (e.g. INFOCOM.CMP) against the DOS
    // boot drive, which is A:. Mount A: and B: to the C: game data folder so
    // those lookups succeed, without modifying Spice86 itself.
    private static void MountGameDataOnFloppyDrives(
        ILogger loggerService, Configuration configuration, Machine machine)
    {
        string? driveFolder = configuration.CDrive;
        if (string.IsNullOrWhiteSpace(driveFolder)) {
            return;
        }

        foreach (char driveLetter in new[] { 'A', 'B' }) {
            try {
                machine.Dos.MountFolderAsFloppy(driveLetter, driveFolder);
            } catch (DirectoryNotFoundException) {
                loggerService.LogWarning(
                    "Could not mount {Drive}: to game data folder {Path}", driveLetter, driveFolder);
            }
        }
    }

    public IEnumerable<Assembly> GetMcpToolAssemblies()
    {
        return [typeof(BattleTechMcpTools).Assembly];
    }

    public IEnumerable<object> GetMcpServices()
    {
        return [];
    }
}
