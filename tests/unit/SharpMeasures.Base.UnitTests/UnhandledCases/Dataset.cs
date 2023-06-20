namespace SharpMeasures.UnhandledCases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
internal sealed class Dataset : ATestDataset<Unhandled>
{
    protected override IEnumerable<Unhandled> GetSamples() => new Unhandled[]
    {
        new(0),
        new(1),
        new(-1),
        new(0.217),
        new(-0.314),
        new(double.Epsilon),
        new(double.MinValue),
        new(double.MaxValue),
        Unhandled.NaN,
        Unhandled.PositiveInfinity,
        Unhandled.NegativeInfinity
    };
}
