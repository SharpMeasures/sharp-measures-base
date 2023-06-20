namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class NegativeOne
{
    public static Scalar Target() => Scalar.NegativeOne;

    [Fact]
    public void ToDoubleIsNegativeOne()
    {
        var actual = Target().ToDouble();

        Assert.Equal(-1, actual);
    }
}
