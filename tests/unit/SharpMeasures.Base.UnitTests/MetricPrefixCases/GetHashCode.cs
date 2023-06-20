namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(MetricPrefix prefix) => prefix.GetHashCode();

    [Fact]
    public void SameInstance_Zero_SameHashCode() => EqualInstances_SameHashCode(MetricPrefix.Zero, MetricPrefix.Zero);

    [Fact]
    public void SameInstance_NonZero_SameHashCode() => EqualInstances_SameHashCode(MetricPrefix.Tera, MetricPrefix.Tera);

    [Fact]
    public void EqualButDifferentInstances_SameHashCode() => EqualInstances_SameHashCode(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(MetricPrefix firstPrefix, MetricPrefix secondPrefix)
    {
        var firstHashCode = Target(firstPrefix);
        var secondHashCode = Target(secondPrefix);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
