namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Vector2 vector) => vector.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsEitherComponentIsNaN(Vector2 vector)
    {
        var expected = vector.X.IsNaN || vector.Y.IsNaN;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
