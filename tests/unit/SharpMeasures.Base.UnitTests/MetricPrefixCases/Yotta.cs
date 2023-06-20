namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Yotta
{
    private static MetricPrefix Target() => MetricPrefix.Yotta;

    [Fact]
    public void FactorIsTenRaisedToTwentyFour()
    {
        Scalar expected = Math.Pow(10, 24);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
