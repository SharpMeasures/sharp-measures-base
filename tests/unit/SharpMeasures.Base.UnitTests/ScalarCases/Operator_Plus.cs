namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Plus
{
    private static Scalar Target(Scalar x) => +x;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Scalar x)
    {
        var expected = x.Plus();
        var actual = Target(x);

        Assert.Equal(expected, actual);
    }
}
