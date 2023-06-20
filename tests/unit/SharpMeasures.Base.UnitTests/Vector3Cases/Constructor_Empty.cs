namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Constructor_Empty
{
    private static Vector3 Target() => new();

    [Fact]
    public void EqualsZero()
    {
        var actual = Target();

        Assert.Equal(Vector3.Zero, actual);
    }
}
