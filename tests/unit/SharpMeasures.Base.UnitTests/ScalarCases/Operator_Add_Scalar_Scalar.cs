namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Add_Scalar_Scalar
{
    private static Scalar Target(Scalar x, Scalar y) => x + y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Zero_EqualsAddMethod(Scalar x) => EqualsAddMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Zero_EqualsAddMethod(Scalar y) => EqualsAddMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NaN_EqualsAddMethod(Scalar x) => EqualsAddMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NaN_EqualsAddMethod(Scalar y) => EqualsAddMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_PositiveInfinity_EqualsAddMethod(Scalar x) => EqualsAddMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_PositiveInfinity_EqualsAddMethod(Scalar y) => EqualsAddMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_NegativeInfinity_EqualsAddMethod(Scalar x) => EqualsAddMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_NegativeInfinity_EqualsAddMethod(Scalar y) => EqualsAddMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Positive_EqualsAddMethod(Scalar x) => EqualsAddMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Positive_EqualsAddMethod(Scalar y) => EqualsAddMethod(1.5, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void X_Negative_EqualsAddMethod(Scalar x) => EqualsAddMethod(x, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Y_Negative_EqualsAddMethod(Scalar y) => EqualsAddMethod(-1.5, y);

    [AssertionMethod]
    private static void EqualsAddMethod(Scalar x, Scalar y)
    {
        var expected = Scalar.Add(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
