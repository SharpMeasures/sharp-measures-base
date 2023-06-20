namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Negate
{
    private static Vector3 Target(Vector3 vector) => vector.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNegation(Vector3 vector)
    {
        Vector3 expected = (-vector.X, -vector.Y, -vector.Z);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
