namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class ThousandTwentyFourToThePower
{
    private static BinaryPrefix Target(int exponent) => BinaryPrefix.ThousandTwentyFourToThePower(exponent);

    [Fact]
    public void Int32MaxValue_ArgumentOutOfRangeException() => ThrowsException<ArgumentOutOfRangeException>(int.MaxValue);

    [Fact]
    public void Zero_FactorIsThousandTwentyFourRaisedToZero() => FactorIsThousandTwentyFourRaisedToExponent(0);

    [Fact]
    public void One_FactorIsThousandTwentyFourRaisedToOne() => FactorIsThousandTwentyFourRaisedToExponent(1);

    [Fact]
    public void NegativeOne_FactorIsThousandTwentyFourRaisedToNegativeOne() => FactorIsThousandTwentyFourRaisedToExponent(-1);

    [Fact]
    public void OneHundred_FactorIsThousandTwentyFourRaisedToOneHundred() => FactorIsThousandTwentyFourRaisedToExponent(100);

    [Fact]
    public void Int32MinValue_FactorIsThousandTwentyFourRaisedToInt32MinValue() => FactorIsThousandTwentyFourRaisedToExponent(int.MinValue);

    [AssertionMethod]
    private static void FactorIsThousandTwentyFourRaisedToExponent(int exponent)
    {
        Scalar expected = Math.Pow(1024, exponent);
        var actual = Target(exponent).Factor;

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(int exponent) where TException : Exception
    {
        var exception = Record.Exception(() => Target(exponent));

        Assert.IsType<TException>(exception);
    }
}
