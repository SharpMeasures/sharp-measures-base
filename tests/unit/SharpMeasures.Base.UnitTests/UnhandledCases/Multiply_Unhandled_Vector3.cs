namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Unhandled_Vector3
{
    private static Unhandled3 Target(Unhandled a, Vector3 b) => Unhandled.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, (-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled a, Vector3 b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
