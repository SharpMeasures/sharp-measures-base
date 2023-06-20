namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Kilo
{
    private static MetricPrefix Target() => MetricPrefix.Kilo;

    [Fact]
    public void FactorIsTenRaisedToThree()
    {
        Scalar expected = Math.Pow(10, 3);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
