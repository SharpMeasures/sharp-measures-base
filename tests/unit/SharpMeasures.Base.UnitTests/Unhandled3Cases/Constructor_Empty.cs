namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Constructor_Empty
{
    private static Unhandled3 Target() => new();

    [Fact]
    public void EqualsZero()
    {
        var actual = Target();

        Assert.Equal(Unhandled3.Zero, actual);
    }
}
