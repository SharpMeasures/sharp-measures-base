namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsNegative
{
    private static bool Target(Scalar scalar) => scalar.IsNegative;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleIsNegative(Scalar scalar)
    {
        var expected = double.IsNegative(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
