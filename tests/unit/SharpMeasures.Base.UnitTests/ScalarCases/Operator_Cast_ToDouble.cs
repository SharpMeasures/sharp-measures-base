namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Cast_ToDouble
{
    private static double Target(Scalar scalar) => (double)scalar;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToDouble(Scalar scalar)
    {
        var expected = scalar.ToDouble();
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
