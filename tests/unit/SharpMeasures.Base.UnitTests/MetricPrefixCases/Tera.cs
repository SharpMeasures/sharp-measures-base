namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Tera
{
    private static MetricPrefix Target() => MetricPrefix.Tera;

    [Fact]
    public void FactorIsTenRaisedToTwelve()
    {
        Scalar expected = Math.Pow(10, 12);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
