namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Femto
{
    private static MetricPrefix Target() => MetricPrefix.Femto;

    [Fact]
    public void FactorIsTenRaisedToNegativeFifteen()
    {
        Scalar expected = Math.Pow(10, -15);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
