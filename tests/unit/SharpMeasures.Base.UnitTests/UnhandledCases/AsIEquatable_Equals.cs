namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Unhandled unhandled, Unhandled other)
    {
        return execute(unhandled);

        bool execute(IEquatable<Unhandled> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsUnhandledEquals(Unhandled unhandled) => EqualsUnhandledEquals(unhandled, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsUnhandledEquals(Unhandled unhandled) => EqualsUnhandledEquals(unhandled, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsUnhandledEquals(Unhandled unhandled) => EqualsUnhandledEquals(unhandled, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsUnhandledEquals(Unhandled unhandled) => EqualsUnhandledEquals(unhandled, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsUnhandledEquals(Unhandled unhandled) => EqualsUnhandledEquals(unhandled, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsUnhandledEquals(Unhandled unhandled) => EqualsUnhandledEquals(unhandled, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled_EqualsUnhandledEquals(Unhandled unhandled) => EqualsUnhandledEquals(unhandled, unhandled);

    [AssertionMethod]
    private static void EqualsUnhandledEquals(Unhandled unhandled, Unhandled other)
    {
        var expected = unhandled.Equals(other);
        var actual = Target(unhandled, other);

        Assert.Equal(expected, actual);
    }
}
