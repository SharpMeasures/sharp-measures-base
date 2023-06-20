namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class ToScalar
{
    private static Scalar Target(MetricPrefix prefix) => prefix.ToScalar();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Common_EqualsFactor(MetricPrefix prefix)
    {
        var actual = Target(prefix);

        Assert.Equal(prefix.Factor, actual);
    }
}
