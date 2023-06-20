namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Truncate
{
    private static Scalar Target(Scalar scalar) => scalar.Truncate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSystemTruncate(Scalar scalar)
    {
        Scalar expected = Math.Truncate(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
