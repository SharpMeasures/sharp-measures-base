namespace SharpMeasures.Unhandled4Cases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
public sealed class Dataset : ATestDataset<Unhandled4>
{
    protected override IEnumerable<Unhandled4> GetSamples() => new Unhandled4[]
    {
        Unhandled4.Zero,
        new(1, 1, 1, 1),
        new(1.19, 0.217, 2.314, 3.33),
        new(-0.007, -789, -12.3, -29.45),
        new(789, -98765.007, 123456789, -123456789),
        new(double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon),
        new(double.MinValue, double.MinValue, double.MinValue, double.MinValue),
        new(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue),
        new(double.NaN, -1.5, 1.5, 4.5),
        new(-1.5, double.NaN, 1.5, 4.5),
        new(-1.5, 1.5, double.NaN, 4.5),
        new(-1.5, 1.5, 4.5, double.NaN),
        new(double.PositiveInfinity, -1.5, 1.5, 4.5),
        new(-1.5, double.PositiveInfinity, 1.5, 4.5),
        new(-1.5, 1.5, double.PositiveInfinity, 4.5),
        new(-1.5, 1.5, 4.5, double.PositiveInfinity),
        new(double.NegativeInfinity, -1.5, 1.5, 4.5),
        new(-1.5, double.NegativeInfinity, 1.5, 4.5),
        new(-1.5, 1.5, double.NegativeInfinity, 4.5),
        new(-1.5, 1.5, 4.5, double.NegativeInfinity)
    };
}
