namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(BinaryPrefix prefix, BinaryPrefix? other)
    {
        return execute(prefix);

        bool execute(IEquatable<BinaryPrefix> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(BinaryPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsBinaryPrefixEquals(BinaryPrefix prefix) => EqualsBinaryPrefixEquals(prefix, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_EqualsBinaryPrefixEquals(BinaryPrefix prefix) => EqualsBinaryPrefixEquals(prefix, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsBinaryPrefixEquals(BinaryPrefix prefix) => EqualsBinaryPrefixEquals(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsBinaryPrefixEquals() => EqualsBinaryPrefixEquals(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsBinaryPrefixEquals(BinaryPrefix prefix, BinaryPrefix other)
    {
        var expected = prefix.Equals(other);
        var actual = Target(prefix, other);

        Assert.Equal(expected, actual);
    }
}
