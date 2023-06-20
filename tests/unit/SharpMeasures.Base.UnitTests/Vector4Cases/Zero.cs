namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Zero
{
    private static Vector4 Target() => Vector4.Zero;

    [Fact]
    public void BothComponentsAreZero()
    {
        Vector4 expected = (0, 0, 0, 0);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
