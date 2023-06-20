namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Scalar_Vector3
{
    private static Vector3 Target(Scalar a, Vector3 b) => Scalar.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Scalar a, Vector3 b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
