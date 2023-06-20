namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Unhandled
{
    private static Unhandled Target(Scalar x, Unhandled y) => x * y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled y) => EqualsMethod(1.5 * Scalar.One, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled y) => EqualsMethod(1.5 * Scalar.NegativeOne, y);

    [AssertionMethod]
    private static void EqualsMethod(Scalar x, Unhandled y)
    {
        var expected = Unhandled.Multiply(y, x);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
