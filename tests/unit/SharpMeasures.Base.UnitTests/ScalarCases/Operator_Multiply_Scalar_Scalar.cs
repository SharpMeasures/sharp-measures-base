namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Scalar
{
    private static Scalar Target(Scalar x, Scalar y) => x * y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Zero_EqualsMultiplyMethod(Scalar x) => EqualsMultiplyMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Zero_EqualsMultiplyMethod(Scalar y) => EqualsMultiplyMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NaN_EqualsMultiplyMethod(Scalar x) => EqualsMultiplyMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NaN_EqualsMultiplyMethod(Scalar y) => EqualsMultiplyMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_PositiveInfinity_EqualsMultiplyMethod(Scalar x) => EqualsMultiplyMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_PositiveInfinity_EqualsMultiplyMethod(Scalar y) => EqualsMultiplyMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NegativeInfinity_EqualsMultiplyMethod(Scalar x) => EqualsMultiplyMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NegativeInfinity_EqualsMultiplyMethod(Scalar y) => EqualsMultiplyMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Positive_EqualsMultiplyMethod(Scalar x) => EqualsMultiplyMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Positive_EqualsMultiplyMethod(Scalar y) => EqualsMultiplyMethod(1.5, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Negative_EqualsMultiplyMethod(Scalar x) => EqualsMultiplyMethod(x, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Negative_EqualsMultiplyMethod(Scalar y) => EqualsMultiplyMethod(-1.5, y);

    [AssertionMethod]
    private static void EqualsMultiplyMethod(Scalar x, Scalar y)
    {
        var expected = Scalar.Multiply(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
