namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class CompareTo
{
    private static int Target(Unhandled unhandled, Unhandled other) => unhandled.CompareTo(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsMagnitudeCompareTo(Unhandled unhandled) => SameSignAsMagnitudeCompareTo(unhandled, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_SameSignAsMagnitudeCompareTo(Unhandled unhandled) => SameSignAsMagnitudeCompareTo(unhandled, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_SameSignAsMagnitudeCompareTo(Unhandled unhandled) => SameSignAsMagnitudeCompareTo(unhandled, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_SameSignAsMagnitudeCompareTo(Unhandled unhandled) => SameSignAsMagnitudeCompareTo(unhandled, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_SameSignAsMagnitudeCompareTo(Unhandled unhandled) => SameSignAsMagnitudeCompareTo(unhandled, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_SameSignAsMagnitudeCompareTo(Unhandled unhandled) => SameSignAsMagnitudeCompareTo(unhandled, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled_SameSignAsMagnitudeCompareTo(Unhandled unhandled) => SameSignAsMagnitudeCompareTo(unhandled, unhandled);

    [AssertionMethod]
    private static void SameSignAsMagnitudeCompareTo(Unhandled unhandled, Unhandled other)
    {
        var expected = Math.Sign(unhandled.Magnitude.CompareTo(other.Magnitude));
        var actual = Math.Sign(Target(unhandled, other));

        Assert.Equal(expected, actual);
    }
}
