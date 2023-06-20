namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Zero
{
    private static Unhandled2 Target() => Unhandled2.Zero;

    [Fact]
    public void BothComponentsAreZero()
    {
        Unhandled2 expected = new(0, 0);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
