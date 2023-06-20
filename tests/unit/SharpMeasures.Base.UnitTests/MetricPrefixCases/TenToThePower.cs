namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class TenToThePower
{
    private static MetricPrefix Target(int exponent) => MetricPrefix.TenToThePower(exponent);

    [Fact]
    public void Int32MaxValue_ArgumentOutOfRangeException() => ThrowsException<ArgumentOutOfRangeException>(int.MaxValue);

    [Fact]
    public void Zero_FactorIsTenRaisedToZero() => FactorIsTenRaisedToExponent(0);

    [Fact]
    public void One_FactorIsTenRaisedToOne() => FactorIsTenRaisedToExponent(1);

    [Fact]
    public void NegativeOne_FactorIsTenRaisedToNegativeOne() => FactorIsTenRaisedToExponent(-1);

    [Fact]
    public void OneHundred_FactorIsTenRaisedToOneHundred() => FactorIsTenRaisedToExponent(100);

    [Fact]
    public void Int32MinValue_FactorIsTenRaisedToInt32MinValue() => FactorIsTenRaisedToExponent(int.MinValue);

    [AssertionMethod]
    private static void FactorIsTenRaisedToExponent(int exponent)
    {
        Scalar expected = Math.Pow(10, exponent);
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
