namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class DivideBy_Scalar
{
    private static Unhandled Target(Unhandled unhandled, Scalar divisor) => unhandled.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfMagnitude(Unhandled unhandled) => EqualsDivisionOfMagnitude(unhandled, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfMagnitude(Unhandled unhandled) => EqualsDivisionOfMagnitude(unhandled, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfMagnitude(Unhandled unhandled) => EqualsDivisionOfMagnitude(unhandled, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfMagnitude(Unhandled unhandled) => EqualsDivisionOfMagnitude(unhandled, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfMagnitude(Unhandled unhandled) => EqualsDivisionOfMagnitude(unhandled, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfMagnitude(Unhandled unhandled) => EqualsDivisionOfMagnitude(unhandled, -1.5);

    [AssertionMethod]
    private static void EqualsDivisionOfMagnitude(Unhandled unhandled, Scalar divisor)
    {
        Unhandled expected = new(unhandled.Magnitude / divisor);
        var actual = Target(unhandled, divisor);

        Assert.Equal(expected, actual);
    }
}
