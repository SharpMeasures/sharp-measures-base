namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Cube
{
    private static Scalar Target(Scalar scalar) => scalar.Cube();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticCube(Scalar scalar)
    {
        var expected = scalar * scalar * scalar;
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
