namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Scalar scalar) => scalar.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsEqualityWithZero(Scalar scalar)
    {
        var expected = scalar == Scalar.Zero;
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
