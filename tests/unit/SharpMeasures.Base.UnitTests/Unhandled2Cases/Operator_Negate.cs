namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Operator_Negate
{
    private static Unhandled2 Target(Unhandled2 a) => -a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Unhandled2 a)
    {
        var expected = a.Negate();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
