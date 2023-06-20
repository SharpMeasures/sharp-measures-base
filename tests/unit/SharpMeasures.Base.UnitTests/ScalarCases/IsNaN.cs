namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Scalar scalar) => scalar.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsDoubleIsNaN(Scalar scalar)
    {
        var expected = double.IsNaN(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
