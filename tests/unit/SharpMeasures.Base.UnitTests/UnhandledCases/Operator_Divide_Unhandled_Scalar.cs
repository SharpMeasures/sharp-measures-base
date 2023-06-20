namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Divide_Unhandled_Scalar
{
    private static Unhandled Target(Unhandled x, Scalar y) => x / y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled y) => EqualsMethod(y, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled y) => EqualsMethod(y, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled y) => EqualsMethod(y, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled y) => EqualsMethod(y, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled y) => EqualsMethod(y, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled y) => EqualsMethod(y, -1.5);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled x, Scalar y)
    {
        var expected = Unhandled.Divide(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
