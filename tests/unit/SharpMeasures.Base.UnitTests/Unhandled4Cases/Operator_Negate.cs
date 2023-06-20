namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Negate
{
    private static Unhandled4 Target(Unhandled4 a) => -a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Unhandled4 a)
    {
        var expected = a.Negate();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
