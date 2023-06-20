namespace SharpMeasures.ScalarCases;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Performance", "CA1812: Avoid uninstantiated internal classes", Justification = "Used as test input.")]
internal sealed class Dataset : ATestDataset<Scalar>
{
    protected override IEnumerable<Scalar> GetSamples() => new Scalar[]
    {
        0,
        1,
        -1,
        0.217,
        -0.314,
        double.Epsilon,
        double.MinValue,
        double.MaxValue,
        Scalar.NaN,
        Scalar.PositiveInfinity,
        Scalar.NegativeInfinity
    };
}
