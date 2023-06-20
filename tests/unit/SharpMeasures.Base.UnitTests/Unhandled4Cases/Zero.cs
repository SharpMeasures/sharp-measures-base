namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Zero
{
    private static Unhandled4 Target() => Unhandled4.Zero;

    [Fact]
    public void AllComponentsAreZero()
    {
        Unhandled4 expected = new(0, 0, 0, 0);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
