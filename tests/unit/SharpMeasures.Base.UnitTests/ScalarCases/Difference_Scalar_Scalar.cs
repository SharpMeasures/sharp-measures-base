namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Difference_Scalar_Scalar
{
    private static Scalar Target(Scalar x, Scalar y) => Scalar.Difference(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Zero_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Zero_EqualsInstanceMethod(Scalar y) => EqualsInstanceMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NaN_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NaN_EqualsInstanceMethod(Scalar y) => EqualsInstanceMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_PositiveInfinity_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_PositiveInfinity_EqualsInstanceMethod(Scalar y) => EqualsInstanceMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NegativeInfinity_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NegativeInfinity_EqualsInstanceMethod(Scalar y) => EqualsInstanceMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Positive_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Positive_EqualsInstanceMethod(Scalar y) => EqualsInstanceMethod(1.5, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Negative_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Negative_EqualsInstanceMethod(Scalar y) => EqualsInstanceMethod(-1.5, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameValue_EqualsInstanceMethod(Scalar scalar) => EqualsInstanceMethod(scalar, scalar);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NegatedScalar_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, -x);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NegatedScalar_EqualsInstanceMethod(Scalar y) => EqualsInstanceMethod(-y, y);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Scalar x, Scalar y)
    {
        var expected = x.Difference(y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
