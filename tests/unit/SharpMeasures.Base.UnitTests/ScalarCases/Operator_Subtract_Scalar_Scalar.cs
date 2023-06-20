namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Subtract_Scalar_Scalar
{
    private static Scalar Target(Scalar x, Scalar y) => x - y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Zero_EqualsSubtractMethod(Scalar x) => EqualsSubtractMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Zero_EqualsSubtractMethod(Scalar y) => EqualsSubtractMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NaN_EqualsSubtractMethod(Scalar x) => EqualsSubtractMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NaN_EqualsSubtractMethod(Scalar y) => EqualsSubtractMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_PositiveInfinity_EqualsSubtractMethod(Scalar x) => EqualsSubtractMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_PositiveInfinity_EqualsSubtractMethod(Scalar y) => EqualsSubtractMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NegativeInfinity_EqualsSubtractMethod(Scalar x) => EqualsSubtractMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NegativeInfinity_EqualsSubtractMethod(Scalar y) => EqualsSubtractMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Positive_EqualsSubtractMethod(Scalar x) => EqualsSubtractMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Positive_EqualsSubtractMethod(Scalar y) => EqualsSubtractMethod(1.5, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Negative_EqualsSubtractMethod(Scalar x) => EqualsSubtractMethod(x, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Negative_EqualsSubtractMethod(Scalar y) => EqualsSubtractMethod(-1.5, y);

    [AssertionMethod]
    private static void EqualsSubtractMethod(Scalar x, Scalar y)
    {
        var expected = Scalar.Subtract(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
