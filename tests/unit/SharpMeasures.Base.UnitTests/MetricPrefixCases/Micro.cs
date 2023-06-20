namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Micro
{
    private static MetricPrefix Target() => MetricPrefix.Micro;

    [Fact]
    public void FactorIsTenRaisedToNegativeSix()
    {
        Scalar expected = Math.Pow(10, -6);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
