namespace UNBATTLETECH;

using System.Collections.Generic;
using generated;
using Microsoft.Extensions.Logging;
using Spice86.Core.CLI;
using Spice86.Core.Emulator.Function;
using Spice86.Core.Emulator.VM;
using Spice86.Shared.Emulator.Memory;

/// <summary>
/// Legacy template override supplier. Excluded from the build (see UNBATTLETECH.csproj).
/// The live supplier is <c>BattleTechMcpTools.BattleTechOverrideSupplier</c>.
/// Kept only as a reference for the generated-code registration pattern; the
/// <c>generated</c> namespace it depends on is stale (old Spice86) and also excluded.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier {
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(
        ILogger loggerService, Configuration configuration, ushort programStartAddress, Machine machine) {
        // We use the generated class but we control the registration manually.
        Dictionary<SegmentedAddress, FunctionInformation> functionInformations = new();
        // The Entry Point is at cs2 (entrySegment + 0x170).
        // So entrySegment = programStartAddress - 0x170.
        ushort entrySegment = (ushort)(programStartAddress - 0x170);
        GeneratedOverrides generatedOverrides = new(
            configuration, functionInformations, machine, loggerService, entrySegment);

        // Register just one function for testing
        generatedOverrides.RegisterOneFunction();

        return functionInformations;
    }
}
