namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Constructor_Empty
{
    private static Unhandled Target() => new();

    [Fact]
    public void EqualsZero()
    {
        var actual = Target();

        Assert.Equal(Unhandled.Zero, actual);
    }
}
