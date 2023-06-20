namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Operator_Plus
{
    private static Vector3 Target(Vector3 a) => +a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsPlusMethod(Vector3 a)
    {
        var expected = a.Plus();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
