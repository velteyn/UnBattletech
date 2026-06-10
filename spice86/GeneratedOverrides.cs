namespace GHIDRAMCP;

using Spice86.Core.CLI;
using Spice86.Shared.Emulator.Memory;
using Spice86.Shared.Interfaces;

public class GeneratedOverrides : CSharpOverrideHelper
{
    private readonly Dictionary<SegmentedAddress, FunctionInformation> _functionsInformation;
    public GeneratedOverrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations,
        Configuration configuration, Machine machine, ILoggerService logger,
        ushort entrySegment = 0xF000)
          : base(functionInformations, machine, logger, configuration)
    {
        _functionsInformation = functionInformations;
    }

    public IDictionary<SegmentedAddress, FunctionInformation> FunctionInformation => _functionsInformation;
}
