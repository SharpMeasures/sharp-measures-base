namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class NaN
{
    public static Scalar Target() => Scalar.NaN;

    [Fact]
    public void ToDoubleIsNaN()
    {
        var actual = Target().ToDouble();

        Assert.Equal(double.NaN, actual);
    }
}
