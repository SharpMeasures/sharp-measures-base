namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Plus
{
    private static Vector2 Target(Vector2 a) => +a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Vector2 a)
    {
        var expected = a.Plus();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
