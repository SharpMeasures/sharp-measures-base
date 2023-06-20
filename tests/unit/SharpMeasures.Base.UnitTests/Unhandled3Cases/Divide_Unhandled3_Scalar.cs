namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Divide_Unhandled3_Scalar
{
    private static Unhandled3 Target(Unhandled3 a, Scalar b) => Unhandled3.Divide(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, -1.5);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled3 a, Scalar b)
    {
        var expected = a.DivideBy(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
