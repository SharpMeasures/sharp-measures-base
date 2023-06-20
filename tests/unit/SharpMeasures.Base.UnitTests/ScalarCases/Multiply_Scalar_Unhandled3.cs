namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Scalar_Unhandled3
{
    private static Unhandled3 Target(Scalar a, Unhandled3 b) => Scalar.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Unhandled3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NaN * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, new Unhandled3(1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, new Unhandled3(-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(Scalar a, Unhandled3 b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
