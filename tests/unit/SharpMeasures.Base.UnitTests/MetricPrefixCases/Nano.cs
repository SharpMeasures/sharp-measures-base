namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Nano
{
    private static MetricPrefix Target() => MetricPrefix.Nano;

    [Fact]
    public void FactorIsTenRaisedToNegativeNine()
    {
        Scalar expected = Math.Pow(10, -9);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
