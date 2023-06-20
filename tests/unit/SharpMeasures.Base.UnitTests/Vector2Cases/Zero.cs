namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Zero
{
    private static Vector2 Target() => Vector2.Zero;

    [Fact]
    public void BothComponentsAreZero()
    {
        Vector2 expected = (0, 0);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
