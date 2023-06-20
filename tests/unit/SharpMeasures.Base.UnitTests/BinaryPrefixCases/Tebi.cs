namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Tebi
{
    private static BinaryPrefix Target() => BinaryPrefix.Tebi;

    [Fact]
    public void FactorIsTwoRaisedToForty()
    {
        Scalar expected = Math.Pow(2, 40);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
