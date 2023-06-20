namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(MetricPrefix prefix, MetricPrefix? other)
    {
        return execute(prefix);

        bool execute(IEquatable<MetricPrefix> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(MetricPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMetricPrefixEquals(MetricPrefix prefix) => EqualsMetricPrefixEquals(prefix, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_EqualsMetricPrefixEquals(MetricPrefix prefix) => EqualsMetricPrefixEquals(prefix, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameMetricPrefix_EqualsMetricPrefixEquals(MetricPrefix prefix) => EqualsMetricPrefixEquals(prefix, prefix);

    [Fact]
    public void EqualButDifferentMetricPrefix_EqualsMetricPrefixEquals() => EqualsMetricPrefixEquals(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsMetricPrefixEquals(MetricPrefix prefix, MetricPrefix other)
    {
        var expected = prefix.Equals(other);
        var actual = Target(prefix, other);

        Assert.Equal(expected, actual);
    }
}
