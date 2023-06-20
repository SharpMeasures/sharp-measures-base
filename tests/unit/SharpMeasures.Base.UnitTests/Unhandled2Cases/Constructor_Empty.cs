namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Constructor_Empty
{
    private static Unhandled2 Target() => new();

    [Fact]
    public void EqualsZero()
    {
        var actual = Target();

        Assert.Equal(Unhandled2.Zero, actual);
    }
}
