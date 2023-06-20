namespace SharpMeasures.Vector4Cases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
public sealed class Dataset : ATestDataset<Vector4>
{
    protected override IEnumerable<Vector4> GetSamples() => new Vector4[]
    {
        Vector4.Zero,
        Vector4.Ones,
        (1.19, 0.217, 2.314, 3.33),
        (-0.007, -789, -12.3, -29.45),
        (789, -98765.007, 123456789, -123456789),
        (double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon),
        (double.MinValue, double.MinValue, double.MinValue, double.MinValue),
        (double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue),
        (double.NaN, -1.5, 1.5, 4.5),
        (-1.5, double.NaN, 1.5, 4.5),
        (-1.5, 1.5, double.NaN, 4.5),
        (-1.5, 1.5, 4.5, double.NaN),
        (double.PositiveInfinity, -1.5, 1.5, 4.5),
        (-1.5, double.PositiveInfinity, 1.5, 4.5),
        (-1.5, 1.5, double.PositiveInfinity, 4.5),
        (-1.5, 1.5, 4.5, double.PositiveInfinity),
        (double.NegativeInfinity, -1.5, 1.5, 4.5),
        (-1.5, double.NegativeInfinity, 1.5, 4.5),
        (-1.5, 1.5, double.NegativeInfinity, 4.5),
        (-1.5, 1.5, 4.5, double.NegativeInfinity)
    };
}
