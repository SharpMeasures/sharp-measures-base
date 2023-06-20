namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Centi
{
    private static MetricPrefix Target() => MetricPrefix.Centi;

    [Fact]
    public void FactorIsTenRaisedToNegativeTwo()
    {
        Scalar expected = Math.Pow(10, -2);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
