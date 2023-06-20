namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Yobi
{
    private static BinaryPrefix Target() => BinaryPrefix.Yobi;

    [Fact]
    public void FactorIsTwoRaisedToEighty()
    {
        Scalar expected = Math.Pow(2, 80);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
