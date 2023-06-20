namespace SharpMeasures.Unhandled2Cases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
public sealed class Dataset : ATestDataset<Unhandled2>
{
    protected override IEnumerable<Unhandled2> GetSamples() => new Unhandled2[]
    {
        Unhandled2.Zero,
        new(1, 1),
        new(1.19, 0.217),
        new(-0.007, -789),
        new(789, -98765.007),
        new(double.Epsilon, double.Epsilon),
        new(double.MinValue, double.MinValue),
        new(double.MaxValue, double.MaxValue),
        new(double.NaN, 1.5),
        new(1.5, double.NaN),
        new(double.PositiveInfinity, 1.5),
        new(1.5, double.PositiveInfinity),
        new(double.NegativeInfinity, 1.5),
        new(1.5, double.NegativeInfinity)
    };
}
