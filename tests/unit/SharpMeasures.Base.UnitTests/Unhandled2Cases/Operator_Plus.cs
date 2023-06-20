namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Operator_Plus
{
    private static Unhandled2 Target(Unhandled2 a) => +a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Unhandled2 a)
    {
        var expected = a.Plus();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
