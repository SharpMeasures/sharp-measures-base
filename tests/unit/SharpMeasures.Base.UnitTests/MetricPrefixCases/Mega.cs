namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Mega
{
    private static MetricPrefix Target() => MetricPrefix.Mega;

    [Fact]
    public void FactorIsTenRaisedToSix()
    {
        Scalar expected = Math.Pow(10, 6);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
