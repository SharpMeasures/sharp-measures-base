namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Zebi
{
    private static BinaryPrefix Target() => BinaryPrefix.Zebi;

    [Fact]
    public void FactorIsTwoRaisedToSeventy()
    {
        Scalar expected = Math.Pow(2, 70);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
