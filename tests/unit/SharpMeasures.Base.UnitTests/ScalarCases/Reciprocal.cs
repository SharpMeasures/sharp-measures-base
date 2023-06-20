namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Reciprocal
{
    private static Scalar Target(Scalar scalar) => scalar.Reciprocal();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleReciprocal(Scalar scalar)
    {
        Scalar expected = 1 / scalar.ToDouble();
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
