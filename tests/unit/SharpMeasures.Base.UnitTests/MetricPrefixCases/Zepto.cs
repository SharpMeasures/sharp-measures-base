namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Zepto
{
    private static MetricPrefix Target() => MetricPrefix.Zepto;

    [Fact]
    public void FactorIsTenRaisedToNegativeTwentyOne()
    {
        Scalar expected = Math.Pow(10, -21);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
