namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Round
{
    private static Scalar Target(Scalar scalar) => scalar.Round();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSystemRound(Scalar scalar)
    {
        Scalar expected = Math.Round(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
