namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Divide_Scalar_Unhandled
{
    private static Unhandled Target(Scalar x, Unhandled y) => Scalar.Divide(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, new(-1.5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(Scalar x, Unhandled y)
    {
        var expected = x.DivideBy(y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
