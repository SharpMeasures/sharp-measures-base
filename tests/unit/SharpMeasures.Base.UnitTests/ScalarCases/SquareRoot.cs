namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class SquareRoot
{
    private static Scalar Target(Scalar scalar) => scalar.SquareRoot();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSystemSqrt(Scalar scalar)
    {
        Scalar expected = Math.Sqrt(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
