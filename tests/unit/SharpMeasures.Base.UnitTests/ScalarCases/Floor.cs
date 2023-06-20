namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Floor
{
    private static Scalar Target(Scalar scalar) => scalar.Floor();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSystemFloor(Scalar scalar)
    {
        Scalar expected = Math.Floor(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
