namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Zero
{
    private static MetricPrefix Target() => MetricPrefix.Zero;

    [Fact]
    public void FactorIsZero()
    {
        var actual = Target().Factor;

        Assert.Equal(0, actual);
    }
}
