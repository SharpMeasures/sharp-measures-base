namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Plus
{
    private static Vector4 Target(Vector4 a) => +a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Vector4 a)
    {
        var expected = a.Plus();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
