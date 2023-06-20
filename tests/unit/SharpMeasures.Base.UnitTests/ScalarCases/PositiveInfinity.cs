namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class PositiveInfinity
{
    public static Scalar Target() => Scalar.PositiveInfinity;

    [Fact]
    public void ToDoubleIsPositiveInfinity()
    {
        var actual = Target().ToDouble();

        Assert.Equal(double.PositiveInfinity, actual);
    }
}
