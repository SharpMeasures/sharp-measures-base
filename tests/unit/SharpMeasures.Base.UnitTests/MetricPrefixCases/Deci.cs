namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Deci
{
    private static MetricPrefix Target() => MetricPrefix.Deci;

    [Fact]
    public void FactorIsTenRaisedToNegativeOne()
    {
        Scalar expected = Math.Pow(10, -1);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
