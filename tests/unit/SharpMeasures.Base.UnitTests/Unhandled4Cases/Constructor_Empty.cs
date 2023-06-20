namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Constructor_Empty
{
    private static Unhandled4 Target() => new();

    [Fact]
    public void EqualsZero()
    {
        var actual = Target();

        Assert.Equal(Unhandled4.Zero, actual);
    }
}
