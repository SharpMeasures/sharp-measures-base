namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Deca
{
    private static MetricPrefix Target() => MetricPrefix.Deca;

    [Fact]
    public void FactorIsTen()
    {
        var actual = Target().Factor;

        Assert.Equal(10, actual);
    }
}
