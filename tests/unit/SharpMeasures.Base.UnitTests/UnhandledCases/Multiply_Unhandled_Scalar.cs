namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Unhandled_Scalar
{
    private static Unhandled Target(Unhandled x, Scalar y) => Unhandled.Multiply(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, -1.5);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled x, Scalar y)
    {
        var expected = x.Multiply(y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
