namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Plus
{
    private static Unhandled Target(Unhandled x) => +x;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Unhandled x)
    {
        var expected = x.Plus();
        var actual = Target(x);

        Assert.Equal(expected, actual);
    }
}
