namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(BinaryPrefix prefix) => prefix.GetHashCode();

    [Fact]
    public void SameInstance_Zero_SameHashCode() => EqualInstances_SameHashCode(BinaryPrefix.Zero, BinaryPrefix.Zero);

    [Fact]
    public void SameInstance_NonZero_SameHashCode() => EqualInstances_SameHashCode(BinaryPrefix.Tebi, BinaryPrefix.Tebi);

    [Fact]
    public void EqualButDifferentInstances_SameHashCode() => EqualInstances_SameHashCode(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(BinaryPrefix firstPrefix, BinaryPrefix secondPrefix)
    {
        var firstHashCode = Target(firstPrefix);
        var secondHashCode = Target(secondPrefix);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
