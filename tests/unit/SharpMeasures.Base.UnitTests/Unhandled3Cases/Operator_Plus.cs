namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Plus
{
    private static Unhandled3 Target(Unhandled3 a) => +a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Unhandled3 a)
    {
        var expected = a.Plus();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
