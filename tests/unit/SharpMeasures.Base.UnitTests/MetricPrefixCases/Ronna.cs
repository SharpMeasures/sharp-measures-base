namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Ronna
{
    private static MetricPrefix Target() => MetricPrefix.Ronna;

    [Fact]
    public void FactorIsTenRaisedToTwentySeven()
    {
        Scalar expected = Math.Pow(10, 27);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
