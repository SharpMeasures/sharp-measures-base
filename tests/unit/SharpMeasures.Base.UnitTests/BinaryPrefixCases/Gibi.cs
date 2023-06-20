namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Gibi
{
    private static BinaryPrefix Target() => BinaryPrefix.Gibi;

    [Fact]
    public void FactorIsTwoRaisedToThirty()
    {
        Scalar expected = Math.Pow(2, 30);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
