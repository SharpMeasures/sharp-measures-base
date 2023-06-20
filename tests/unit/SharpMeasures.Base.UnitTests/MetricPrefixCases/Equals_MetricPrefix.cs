namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Equals_MetricPrefix
{
    private static bool Target(MetricPrefix prefix, MetricPrefix? other) => prefix.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(MetricPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsFactorEquals(MetricPrefix prefix) => EqualsFactorEquals(prefix, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonZero_EqualsFactorEquals(MetricPrefix prefix) => EqualsFactorEquals(prefix, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsFactorEquals(MetricPrefix prefix) => EqualsFactorEquals(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsFactorEquals() => EqualsFactorEquals(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsFactorEquals(MetricPrefix prefix, MetricPrefix other)
    {
        var expected = prefix.Factor.Equals(other.Factor);
        var actual = Target(prefix, other);

        Assert.Equal(expected, actual);
    }
}
