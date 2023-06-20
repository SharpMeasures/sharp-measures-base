namespace SharpMeasures.Vector2Cases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
public sealed class Dataset : ATestDataset<Vector2>
{
    protected override IEnumerable<Vector2> GetSamples() => new Vector2[]
    {
        Vector2.Zero,
        Vector2.Ones,
        (1.19, 0.217),
        (-0.007, -789),
        (789, -98765.007),
        (double.Epsilon, double.Epsilon),
        (double.MinValue, double.MinValue),
        (double.MaxValue, double.MaxValue),
        (double.NaN, 1.5),
        (1.5, double.NaN),
        (double.PositiveInfinity, 1.5),
        (1.5, double.PositiveInfinity),
        (double.NegativeInfinity, 1.5),
        (1.5, double.NegativeInfinity)
    };
}
