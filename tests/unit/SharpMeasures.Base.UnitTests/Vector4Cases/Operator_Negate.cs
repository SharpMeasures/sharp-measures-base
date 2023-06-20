namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Negate
{
    private static Vector4 Target(Vector4 a) => -a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Vector4 a)
    {
        var expected = a.Negate();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
