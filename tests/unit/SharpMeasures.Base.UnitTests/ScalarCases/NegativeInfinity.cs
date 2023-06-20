namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class NegativeInfinity
{
    public static Scalar Target() => Scalar.NegativeInfinity;

    [Fact]
    public void ToDoubleIsNegativeInfinity()
    {
        var actual = Target().ToDouble();

        Assert.Equal(double.NegativeInfinity, actual);
    }
}
