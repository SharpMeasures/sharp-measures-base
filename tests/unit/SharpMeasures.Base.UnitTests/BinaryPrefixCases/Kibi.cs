namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class Kibi
{
    private static BinaryPrefix Target() => BinaryPrefix.Kibi;

    [Fact]
    public void FactorIsTwoRaisedToTen()
    {
        Scalar expected = Math.Pow(2, 10);
        var actual = Target().Factor;

        Assert.Equal(expected, actual);
    }
}
