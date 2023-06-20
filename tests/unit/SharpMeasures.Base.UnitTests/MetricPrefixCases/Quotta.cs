namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Quotta
{
    private static MetricPrefix Target() => MetricPrefix.Quetta;

    [Fact]
    public void FactorIsTenRaisedToThirty()
    {
        Scalar expected = Math.Pow(10, 30);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
