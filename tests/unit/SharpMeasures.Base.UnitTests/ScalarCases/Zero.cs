namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Zero
{
    public static Scalar Target() => Scalar.Zero;

    [Fact]
    public void ToDoubleIsZero()
    {
        var actual = Target().ToDouble();

        Assert.Equal(0, actual);
    }
}
