namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Equals_BinaryPrefix
{
    private static bool Target(BinaryPrefix prefix, BinaryPrefix? other) => prefix.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(BinaryPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsFactorEquals(BinaryPrefix prefix) => EqualsFactorEquals(prefix, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_EqualsFactorEquals(BinaryPrefix prefix) => EqualsFactorEquals(prefix, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsFactorEquals(BinaryPrefix prefix) => EqualsFactorEquals(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsFactorEquals() => EqualsFactorEquals(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsFactorEquals(BinaryPrefix prefix, BinaryPrefix other)
    {
        var expected = prefix.Factor.Equals(other.Factor);
        var actual = Target(prefix, other);

        Assert.Equal(expected, actual);
    }
}
