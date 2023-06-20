namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Yocto
{
    private static MetricPrefix Target() => MetricPrefix.Yocto;

    [Fact]
    public void FactorIsTenRaisedToNegativeTwentyFour()
    {
        Scalar expected = Math.Pow(10, -24);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
