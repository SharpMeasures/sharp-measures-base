namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class CompareTo
{
    private static int Target(BinaryPrefix prefix, BinaryPrefix? other) => prefix.CompareTo(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_GreaterThanZero(BinaryPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.True(actual > 0);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsFactorCompareTo(BinaryPrefix prefix) => SameSignAsFactorCompareTo(prefix, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_SameSignAsFactorCompareTo(BinaryPrefix prefix) => SameSignAsFactorCompareTo(prefix, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_SameSignAsFactorCompareTo(BinaryPrefix prefix) => SameSignAsFactorCompareTo(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_SameSignAsFactorCompareTo() => SameSignAsFactorCompareTo(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void SameSignAsFactorCompareTo(BinaryPrefix prefix, BinaryPrefix other)
    {
        var expected = Math.Sign(prefix.Factor.CompareTo(other.Factor));
        var actual = Math.Sign(Target(prefix, other));

        Assert.Equal(expected, actual);
    }
}
