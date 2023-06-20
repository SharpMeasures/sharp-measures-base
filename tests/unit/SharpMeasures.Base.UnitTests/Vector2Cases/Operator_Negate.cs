namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Negate
{
    private static Vector2 Target(Vector2 a) => -a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Vector2 a)
    {
        var expected = a.Negate();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
