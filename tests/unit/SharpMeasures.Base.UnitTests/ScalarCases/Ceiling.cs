namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Ceiling
{
    private static Scalar Target(Scalar scalar) => scalar.Ceiling();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSystemCeiling(Scalar scalar)
    {
        Scalar expected = Math.Ceiling(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
