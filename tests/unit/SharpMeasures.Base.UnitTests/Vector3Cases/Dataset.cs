namespace SharpMeasures.Vector3Cases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
public sealed class Dataset : ATestDataset<Vector3>
{
    protected override IEnumerable<Vector3> GetSamples() => new Vector3[]
    {
        Vector3.Zero,
        Vector3.Ones,
        (1.19, 0.217, 2.314),
        (-0.007, -789, -12.3),
        (789, -98765.007, 123456789),
        (double.Epsilon, double.Epsilon, double.Epsilon),
        (double.MinValue, double.MinValue, double.MinValue),
        (double.MaxValue, double.MaxValue, double.MaxValue),
        (double.NaN, -1.5, 1.5),
        (-1.5, double.NaN, 1.5),
        (-1.5, 1.5, double.NaN),
        (double.PositiveInfinity, -1.5, 1.5),
        (-1.5, double.PositiveInfinity, 1.5),
        (-1.5, 1.5, double.PositiveInfinity),
        (double.NegativeInfinity, -1.5, 1.5),
        (-1.5, double.NegativeInfinity, 1.5),
        (-1.5, 1.5, double.NegativeInfinity)
    };
}
