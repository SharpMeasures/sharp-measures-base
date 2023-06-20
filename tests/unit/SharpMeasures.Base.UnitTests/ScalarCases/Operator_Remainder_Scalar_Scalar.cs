namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Remainder_Scalar_Scalar
{
    private static Scalar Target(Scalar x, Scalar y) => x % y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Zero_EqualsRemainderMethod(Scalar x) => EqualsRemainderMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Zero_EqualsRemainderMethod(Scalar y) => EqualsRemainderMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NaN_EqualsRemainderMethod(Scalar x) => EqualsRemainderMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NaN_EqualsRemainderMethod(Scalar y) => EqualsRemainderMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_PositiveInfinity_EqualsRemainderMethod(Scalar x) => EqualsRemainderMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_PositiveInfinity_EqualsRemainderMethod(Scalar y) => EqualsRemainderMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NegativeInfinity_EqualsRemainderMethod(Scalar x) => EqualsRemainderMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NegativeInfinity_EqualsRemainderMethod(Scalar y) => EqualsRemainderMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Positive_EqualsRemainderMethod(Scalar x) => EqualsRemainderMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Positive_EqualsRemainderMethod(Scalar y) => EqualsRemainderMethod(1.5, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Negative_EqualsRemainderMethod(Scalar x) => EqualsRemainderMethod(x, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Negative_EqualsRemainderMethod(Scalar y) => EqualsRemainderMethod(-1.5, y);

    [AssertionMethod]
    private static void EqualsRemainderMethod(Scalar x, Scalar y)
    {
        var expected = Scalar.Remainder(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
