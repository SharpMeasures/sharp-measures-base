namespace SharpMeasures.BinaryPrefixCases;

using System;

using Xunit;

public sealed class TwoToThePower
{
    private static BinaryPrefix Target(int exponent) => BinaryPrefix.TwoToThePower(exponent);

    [Fact]
    public void Int32MaxValue_ArgumentOutOfRangeException() => ThrowsException<ArgumentOutOfRangeException>(int.MaxValue);

    [Fact]
    public void Zero_FactorIsTwoRaisedToZero() => FactorIsTwoRaisedToExponent(0);

    [Fact]
    public void One_FactorIsTwoRaisedToOne() => FactorIsTwoRaisedToExponent(1);

    [Fact]
    public void NegativeOne_FactorIsTwoRaisedToNegativeOne() => FactorIsTwoRaisedToExponent(-1);

    [Fact]
    public void OneHundred_FactorIsTwoRaisedToOneHundred() => FactorIsTwoRaisedToExponent(100);

    [Fact]
    public void Int32MinValue_FactorIsTwoRaisedToInt32MinValue() => FactorIsTwoRaisedToExponent(int.MinValue);

    [AssertionMethod]
    private static void FactorIsTwoRaisedToExponent(int exponent)
    {
        Scalar expected = Math.Pow(2, exponent);
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
