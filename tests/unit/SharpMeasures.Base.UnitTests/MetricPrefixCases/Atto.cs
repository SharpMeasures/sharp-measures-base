namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Atto
{
    private static MetricPrefix Target() => MetricPrefix.Atto;

    [Fact]
    public void FactorIsTenRaisedToNegativeEighteen()
    {
        Scalar expected = Math.Pow(10, -18);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
