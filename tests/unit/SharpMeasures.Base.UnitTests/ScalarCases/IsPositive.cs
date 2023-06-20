namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsPositive
{
    private static bool Target(Scalar scalar) => scalar.IsPositive;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleIsPositive(Scalar scalar)
    {
        var expected = double.IsPositive(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
