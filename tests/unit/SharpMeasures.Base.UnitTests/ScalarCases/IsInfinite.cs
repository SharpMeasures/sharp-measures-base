namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsInfinite
{
    private static bool Target(Scalar scalar) => scalar.IsInfinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleIsInfinity(Scalar scalar)
    {
        var expected = double.IsInfinity(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
