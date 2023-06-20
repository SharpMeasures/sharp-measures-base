namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class One
{
    public static Scalar Target() => Scalar.One;

    [Fact]
    public void ToDoubleIsOne()
    {
        var actual = Target().ToDouble();

        Assert.Equal(1, actual);
    }
}
