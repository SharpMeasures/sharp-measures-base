namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class CompareTo
{
    private static int Target(MetricPrefix prefix, MetricPrefix? other) => prefix.CompareTo(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_GreaterThanZero(MetricPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.True(actual > 0);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsFactorCompareTo(MetricPrefix prefix) => SameSignAsFactorCompareTo(prefix, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_SameSignAsFactorCompareTo(MetricPrefix prefix) => SameSignAsFactorCompareTo(prefix, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_SameSignAsFactorCompareTo(MetricPrefix prefix) => SameSignAsFactorCompareTo(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_SameSignAsFactorCompareTo() => SameSignAsFactorCompareTo(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void SameSignAsFactorCompareTo(MetricPrefix prefix, MetricPrefix other)
    {
        var expected = Math.Sign(prefix.Factor.CompareTo(other.Factor));
        var actual = Math.Sign(Target(prefix, other));

        Assert.Equal(expected, actual);
    }
}
