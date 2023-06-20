namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Ronto
{
    private static MetricPrefix Target() => MetricPrefix.Ronto;

    [Fact]
    public void FactorIsTenRaisedToNegativeTwentySeven()
    {
        Scalar expected = Math.Pow(10, -27);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
