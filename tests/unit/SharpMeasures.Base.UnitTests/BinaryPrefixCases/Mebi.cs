namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Mebi
{
    private static BinaryPrefix Target() => BinaryPrefix.Mebi;

    [Fact]
    public void FactorIsTwoRaisedToTwenty()
    {
        Scalar expected = Math.Pow(2, 20);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
