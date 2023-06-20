namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Negate
{
    private static Scalar Target(Scalar x) => -x;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Scalar x)
    {
        var expected = x.Negate();
        var actual = Target(x);

        Assert.Equal(expected, actual);
    }
}
