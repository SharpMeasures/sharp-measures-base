namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Peta
{
    private static MetricPrefix Target() => MetricPrefix.Peta;

    [Fact]
    public void FactorIsTenRaisedToFifteen()
    {
        Scalar expected = Math.Pow(10, 15);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
