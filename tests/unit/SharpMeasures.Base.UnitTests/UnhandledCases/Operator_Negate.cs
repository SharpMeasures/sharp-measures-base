namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Negate
{
    private static Unhandled Target(Unhandled x) => -x;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Unhandled x)
    {
        var expected = x.Negate();
        var actual = Target(x);

        Assert.Equal(expected, actual);
    }
}
