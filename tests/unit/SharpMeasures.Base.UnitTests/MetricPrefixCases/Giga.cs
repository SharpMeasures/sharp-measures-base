namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Giga
{
    private static MetricPrefix Target() => MetricPrefix.Giga;

    [Fact]
    public void FactorIsTenRaisedToNine()
    {
        Scalar expected = Math.Pow(10, 9);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
