namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsNegativeInfinity
{
    private static bool Target(Scalar scalar) => scalar.IsNegativeInfinity;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleIsNegativeInfinity(Scalar scalar)
    {
        var expected = double.IsNegativeInfinity(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
