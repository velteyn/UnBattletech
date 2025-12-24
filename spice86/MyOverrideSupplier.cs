namespace GHIDRAMCP;

using System.Collections.Generic;

using Spice86.Core.CLI;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

/// <summary>
/// Provides functions overrides for the DOS program.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier {
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(ILoggerService loggserService, Configuration configuration, ushort programStartAddress, Machine machine) {
        // You can extend / replace GeneratedOverrides with your own overrides as well.
        GeneratedOverrides generatedOverrides = new GeneratedOverrides(new(), configuration, machine, loggserService);
        return generatedOverrides.FunctionInformation;
    }
}