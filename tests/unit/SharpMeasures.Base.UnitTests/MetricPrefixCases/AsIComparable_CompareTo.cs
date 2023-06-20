namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed partial class AsIComparable_CompareTo
{
    private static int Target(MetricPrefix prefix, MetricPrefix? other)
    {
        return execute(prefix);

        int execute(IComparable<MetricPrefix> comparable) => comparable.CompareTo(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_GreaterThanZero(MetricPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.True(actual > 0);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsMetricPrefixCompareTo(MetricPrefix prefix) => SameSignAsMetricPrefixCompareTo(prefix, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_SameSignAsMetricPrefixCompareTo(MetricPrefix prefix) => SameSignAsMetricPrefixCompareTo(prefix, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameMetricPrefix_SameSignAsMetricPrefixCompareTo(MetricPrefix prefix) => SameSignAsMetricPrefixCompareTo(prefix, prefix);

    [Fact]
    public void EqualButDifferentMetricPrefix_SameSignAsMetricPrefixCompareTo() => SameSignAsMetricPrefixCompareTo(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void SameSignAsMetricPrefixCompareTo(MetricPrefix prefix, MetricPrefix other)
    {
        var expected = Math.Sign(prefix.CompareTo(other));
        var actual = Math.Sign(Target(prefix, other));

        Assert.Equal(expected, actual);
    }
}
