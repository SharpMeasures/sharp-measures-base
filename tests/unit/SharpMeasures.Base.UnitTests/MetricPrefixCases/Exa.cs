namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Exa
{
    private static MetricPrefix Target() => MetricPrefix.Exa;

    [Fact]
    public void FactorIsTenRaisedToEighteen()
    {
        Scalar expected = Math.Pow(10, 18);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
