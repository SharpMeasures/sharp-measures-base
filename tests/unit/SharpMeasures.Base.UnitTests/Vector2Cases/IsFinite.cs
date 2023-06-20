namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class IsFinite
{
    private static bool Target(Vector2 vector) => vector.IsFinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsBothComponentsAreFinite(Vector2 vector)
    {
        var expected = vector.X.IsFinite && vector.Y.IsFinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
