namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Negate
{
    private static Vector2 Target(Vector2 vector) => vector.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNegation(Vector2 vector)
    {
        Vector2 expected = (-vector.X, -vector.Y);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
