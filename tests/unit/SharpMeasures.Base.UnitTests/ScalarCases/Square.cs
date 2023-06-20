namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Square
{
    private static Scalar Target(Scalar scalar) => scalar.Square();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticSquare(Scalar scalar)
    {
        var expected = scalar * scalar;
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
