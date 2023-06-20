namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Negate
{
    private static Vector4 Target(Vector4 vector) => vector.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNegation(Vector4 vector)
    {
        Vector4 expected = (-vector.X, -vector.Y, -vector.Z, -vector.W);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
