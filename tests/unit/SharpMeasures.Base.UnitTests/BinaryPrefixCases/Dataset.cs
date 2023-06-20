namespace SharpMeasures.BinaryPrefixCases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
internal sealed class Dataset : ATestDataset<BinaryPrefix>
{
    protected override IEnumerable<BinaryPrefix> GetSamples() => new[]
    {
        BinaryPrefix.Zero,
        BinaryPrefix.TwoToThePower(0),
        BinaryPrefix.TwoToThePower(1),
        BinaryPrefix.TwoToThePower(-1),
        BinaryPrefix.TwoToThePower(100),
        BinaryPrefix.TwoToThePower(int.MinValue)
    };
}
