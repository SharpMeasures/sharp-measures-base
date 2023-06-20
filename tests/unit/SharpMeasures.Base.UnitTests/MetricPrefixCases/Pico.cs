namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Pico
{
    private static MetricPrefix Target() => MetricPrefix.Pico;

    [Fact]
    public void FactorIsTenRaisedToNegativeTwelve()
    {
        Scalar expected = Math.Pow(10, -12);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
