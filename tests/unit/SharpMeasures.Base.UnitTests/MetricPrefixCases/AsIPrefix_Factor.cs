namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class AsIPrefix_Factor
{
    private static Scalar Target(MetricPrefix prefix)
    {
        return execute(prefix);

        static Scalar execute(IPrefix prefix) => prefix.Factor;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Common_EqualsMetricPrefixProperty(MetricPrefix prefix)
    {
        var actual = Target(prefix);

        Assert.Equal(prefix.Factor, actual);
    }
}
