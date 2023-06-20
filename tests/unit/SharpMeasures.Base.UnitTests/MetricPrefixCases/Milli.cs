namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Milli
{
    private static MetricPrefix Target() => MetricPrefix.Milli;

    [Fact]
    public void FactorIsTenRaisedToNegativeThree()
    {
        Scalar expected = Math.Pow(10, -3);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
