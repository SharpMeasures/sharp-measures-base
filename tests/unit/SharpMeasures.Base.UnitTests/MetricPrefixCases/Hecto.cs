namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Hecto
{
    private static MetricPrefix Target() => MetricPrefix.Hecto;

    [Fact]
    public void FactorIsTenRaisedToTwo()
    {
        Scalar expected = Math.Pow(10, 2);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
