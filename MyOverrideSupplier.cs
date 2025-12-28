namespace UNBATTLETECH;

using System.Collections.Generic;
using generated;
using Spice86.Core.CLI;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

/// <summary>
/// Provides functions overrides for the DOS program.
/// </summary>
public class MyOverrideSupplier : IOverrideSupplier {
    public IDictionary<SegmentedAddress, FunctionInformation> GenerateFunctionInformations(ILoggerService loggserService, Configuration configuration, ushort programStartAddress, Machine machine) {
        // We use the generated class but we control the registration manually.
        Dictionary<SegmentedAddress, FunctionInformation> functionInformations = new();
        // The Entry Point is at cs2 (entrySegment + 0x170).
        // So entrySegment = programStartAddress - 0x170.
        ushort entrySegment = (ushort)(programStartAddress - 0x170);
        GeneratedOverrides generatedOverrides = new GeneratedOverrides(configuration, functionInformations, machine, loggserService, entrySegment);
        
        // Register just one function for testing
        generatedOverrides.RegisterOneFunction();
        
        return functionInformations;
    }
}