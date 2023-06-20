namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Identity
{
    private static MetricPrefix Target() => MetricPrefix.Identity;

    [Fact]
    public void FactorIsOne()
    {
        var actual = Target().Factor;

        Assert.Equal(Scalar.One, actual);
    }
}
