namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Constructor_Empty
{
    private static Scalar Target() => new();

    [Fact]
    public void EqualsZero()
    {
        var actual = Target();

        Assert.Equal(Scalar.Zero, actual);
    }
}
