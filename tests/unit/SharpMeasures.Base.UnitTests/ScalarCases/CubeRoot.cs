namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class CubeRoot
{
    private static Scalar Target(Scalar scalar) => scalar.CubeRoot();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSystemCbrt(Scalar scalar)
    {
        Scalar expected = Math.Cbrt(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
