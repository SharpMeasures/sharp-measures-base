namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Ones
{
    private static Vector2 Target() => Vector2.Ones;

    [Fact]
    public void BothComponentsAreOne()
    {
        Vector2 expected = (1, 1);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
