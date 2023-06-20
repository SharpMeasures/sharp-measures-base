namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Operator_Negate
{
    private static Vector3 Target(Vector3 a) => -a;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsNegateMethod(Vector3 a)
    {
        var expected = a.Negate();
        var actual = Target(a);

        Assert.Equal(expected, actual);
    }
}
