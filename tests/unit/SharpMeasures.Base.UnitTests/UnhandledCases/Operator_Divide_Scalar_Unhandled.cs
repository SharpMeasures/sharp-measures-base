namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Divide_Scalar_Unhandled
{
    private static Unhandled Target(Scalar x, Unhandled y) => x / y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionByMagnitude(Unhandled y) => EqualsDivisionByMagnitude(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionByMagnitude(Unhandled y) => EqualsDivisionByMagnitude(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionByMagnitude(Unhandled y) => EqualsDivisionByMagnitude(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionByMagnitude(Unhandled y) => EqualsDivisionByMagnitude(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionByMagnitude(Unhandled y) => EqualsDivisionByMagnitude(1.5 * Scalar.One, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionByMagnitude(Unhandled y) => EqualsDivisionByMagnitude(1.5 * Scalar.NegativeOne, y);

    [AssertionMethod]
    private static void EqualsDivisionByMagnitude(Scalar x, Unhandled y)
    {
        Unhandled expected = new(x / y.Magnitude);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
