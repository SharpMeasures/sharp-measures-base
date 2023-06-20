namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Power
{
    private static Unhandled Target(Unhandled unhandled, Scalar exponent) => unhandled.Power(exponent);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudePower(Unhandled unhandled) => EqualsMagnitudePower(unhandled, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudePower(Unhandled unhandled) => EqualsMagnitudePower(unhandled, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudePower(Unhandled unhandled) => EqualsMagnitudePower(unhandled, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudePower(Unhandled unhandled) => EqualsMagnitudePower(unhandled, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudePower(Unhandled unhandled) => EqualsMagnitudePower(unhandled, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudePower(Unhandled unhandled) => EqualsMagnitudePower(unhandled, -1.5);

    [AssertionMethod]
    private static void EqualsMagnitudePower(Unhandled unhandled, Scalar exponent)
    {
        Unhandled expected = new(unhandled.Magnitude.Power(exponent));
        var actual = Target(unhandled, exponent);

        Assert.Equal(expected, actual);
    }
}
