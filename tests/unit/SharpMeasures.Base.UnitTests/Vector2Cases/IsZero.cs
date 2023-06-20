namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Vector2 vector) => vector.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsEqualityWithZero(Vector2 vector)
    {
        var expected = vector == Vector2.Zero;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
