namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed partial class AsIComparable_CompareTo
{
    private static int Target(BinaryPrefix prefix, BinaryPrefix? other)
    {
        return execute(prefix);

        int execute(IComparable<BinaryPrefix> comparable) => comparable.CompareTo(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_GreaterThanZero(BinaryPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.True(actual > 0);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsBinaryPrefixCompareTo(BinaryPrefix prefix) => SameSignAsBinaryPrefixCompareTo(prefix, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_SameSignAsBinaryPrefixCompareTo(BinaryPrefix prefix) => SameSignAsBinaryPrefixCompareTo(prefix, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_SameSignAsBinaryPrefixCompareTo(BinaryPrefix prefix) => SameSignAsBinaryPrefixCompareTo(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_SameSignAsBinaryPrefixCompareTo() => SameSignAsBinaryPrefixCompareTo(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void SameSignAsBinaryPrefixCompareTo(BinaryPrefix prefix, BinaryPrefix other)
    {
        var expected = Math.Sign(prefix.CompareTo(other));
        var actual = Math.Sign(Target(prefix, other));

        Assert.Equal(expected, actual);
    }
}
