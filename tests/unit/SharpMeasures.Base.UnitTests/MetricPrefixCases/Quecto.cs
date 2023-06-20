namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class Quecto
{
    private static MetricPrefix Target() => MetricPrefix.Quecto;

    [Fact]
    public void FactorIsTenRaisedToNegativeThirty()
    {
        Scalar expected = Math.Pow(10, -30);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
