namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Plus
{
    private static Unhandled4 Target(Unhandled4 a) => +a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Unhandled4 a)
    {
        var expected = a.Plus();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
