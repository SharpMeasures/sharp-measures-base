namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Negate
{
    private static Scalar Target(Scalar scalar) => scalar.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleNegation(Scalar scalar)
    {
        Scalar expected = -scalar.ToDouble();
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
