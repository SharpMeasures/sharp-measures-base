namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Absolute
{
    private static Scalar Target(Scalar scalar) => scalar.Absolute();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSystemAbs(Scalar scalar)
    {
        Scalar expected = Math.Abs(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
