namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class NegativeOnes
{
    private static Vector2 Target() => Vector2.NegativeOnes;

    [Fact]
    public void BothComponentsAreNegativeOne()
    {
        Vector2 expected = (-1, -1);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
