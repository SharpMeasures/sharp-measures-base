namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Negate
{
    private static Unhandled3 Target(Unhandled3 a) => -a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Unhandled3 a)
    {
        var expected = a.Negate();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
