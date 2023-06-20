namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Scalar_Vector4
{
    private static Vector4 Target(Scalar a, Vector4 b) => Scalar.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Scalar a, Vector4 b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
