namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class IsInfinite
{
    private static bool Target(Vector2 vector) => vector.IsInfinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsEitherComponentIsInfinite(Vector2 vector)
    {
        var expected = vector.X.IsInfinite || vector.Y.IsInfinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
