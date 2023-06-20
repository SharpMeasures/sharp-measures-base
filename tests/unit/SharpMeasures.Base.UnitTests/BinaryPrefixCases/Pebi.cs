namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Pebi
{
    private static BinaryPrefix Target() => BinaryPrefix.Pebi;

    [Fact]
    public void FactorIsTwoRaisedToFifty()
    {
        Scalar expected = Math.Pow(2, 50);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
