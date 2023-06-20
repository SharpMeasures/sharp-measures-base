namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsPositiveInfinity
{
    private static bool Target(Scalar scalar) => scalar.IsPositiveInfinity;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleIsPositiveInfinity(Scalar scalar)
    {
        var expected = double.IsPositiveInfinity(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
