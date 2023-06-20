namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Zero
{
    private static Unhandled3 Target() => Unhandled3.Zero;

    [Fact]
    public void AllComponentsAreZero()
    {
        Unhandled3 expected = new(0, 0, 0);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
