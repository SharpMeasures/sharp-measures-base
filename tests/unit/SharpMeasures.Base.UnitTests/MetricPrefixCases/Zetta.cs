namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Zetta
{
    private static MetricPrefix Target() => MetricPrefix.Zetta;

    [Fact]
    public void FactorIsTenRaisedToTwentyOne()
    {
        Scalar expected = Math.Pow(10, 21);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
