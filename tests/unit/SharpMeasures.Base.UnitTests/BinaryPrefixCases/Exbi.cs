namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Exbi
{
    private static BinaryPrefix Target() => BinaryPrefix.Exbi;

    [Fact]
    public void FactorIsTwoRaisedToSixty()
    {
        Scalar expected = Math.Pow(2, 60);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
