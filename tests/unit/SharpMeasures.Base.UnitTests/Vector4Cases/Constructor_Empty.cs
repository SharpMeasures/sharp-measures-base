namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Constructor_Empty
{
    private static Vector4 Target() => new();

    [Fact]
    public void EqualsZero()
    {
        var actual = Target();

        Assert.Equal(Vector4.Zero, actual);
    }
}
