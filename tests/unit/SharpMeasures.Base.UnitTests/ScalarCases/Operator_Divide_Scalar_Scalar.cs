namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Divide_Scalar_Scalar
{
    private static Scalar Target(Scalar x, Scalar y) => x / y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Zero_EqualsDivideMethod(Scalar x) => EqualsDivideMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Zero_EqualsDivideMethod(Scalar y) => EqualsDivideMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NaN_EqualsDivideMethod(Scalar x) => EqualsDivideMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NaN_EqualsDivideMethod(Scalar y) => EqualsDivideMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_PositiveInfinity_EqualsDivideMethod(Scalar x) => EqualsDivideMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_PositiveInfinity_EqualsDivideMethod(Scalar y) => EqualsDivideMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NegativeInfinity_EqualsDivideMethod(Scalar x) => EqualsDivideMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NegativeInfinity_EqualsDivideMethod(Scalar y) => EqualsDivideMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Positive_EqualsDivideMethod(Scalar x) => EqualsDivideMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Positive_EqualsDivideMethod(Scalar y) => EqualsDivideMethod(1.5, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Negative_EqualsDivideMethod(Scalar x) => EqualsDivideMethod(x, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Negative_EqualsDivideMethod(Scalar y) => EqualsDivideMethod(-1.5, y);

    [AssertionMethod]
    private static void EqualsDivideMethod(Scalar x, Scalar y)
    {
        var expected = Scalar.Divide(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
