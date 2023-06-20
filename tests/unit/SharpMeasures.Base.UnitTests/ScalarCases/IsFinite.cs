namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsFinite
{
    private static bool Target(Scalar scalar) => scalar.IsFinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleIsFinite(Scalar scalar)
    {
        var expected = double.IsFinite(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
