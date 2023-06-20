namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Equals_Unhandled
{
    private static bool Target(Unhandled unhandled, Unhandled other) => unhandled.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudeEquals(Unhandled unhandled) => EqualsMagnitudeEquals(unhandled, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudeEquals(Unhandled unhandled) => EqualsMagnitudeEquals(unhandled, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudeEquals(Unhandled unhandled) => EqualsMagnitudeEquals(unhandled, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudeEquals(Unhandled unhandled) => EqualsMagnitudeEquals(unhandled, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudeEquals(Unhandled unhandled) => EqualsMagnitudeEquals(unhandled, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudeEquals(Unhandled unhandled) => EqualsMagnitudeEquals(unhandled, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled_EqualsMagnitudeEquals(Unhandled unhandled) => EqualsMagnitudeEquals(unhandled, unhandled);

    [AssertionMethod]
    private static void EqualsMagnitudeEquals(Unhandled unhandled, Unhandled other)
    {
        var expected = unhandled.Magnitude.Equals(other.Magnitude);
        var actual = Target(unhandled, other);

        Assert.Equal(expected, actual);
    }
}
