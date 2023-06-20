namespace SharpMeasures.MetricPrefixCases;

using System;

using Xunit;

public sealed class ThousandToThePower
{
    private static MetricPrefix Target(int exponent) => MetricPrefix.ThousandToThePower(exponent);

    [Fact]
    public void Int32MaxValue_ArgumentOutOfRangeException() => ThrowsException<ArgumentOutOfRangeException>(int.MaxValue);

    [Fact]
    public void Zero_FactorIsThousandRaisedToZero() => FactorIsThousandRaisedToExponent(0);

    [Fact]
    public void One_FactorIsThousandRaisedToOne() => FactorIsThousandRaisedToExponent(1);

    [Fact]
    public void NegativeOne_FactorIsThousandRaisedToNegativeOne() => FactorIsThousandRaisedToExponent(-1);

    [Fact]
    public void OneHundred_FactorIsThousandRaisedToOneHundred() => FactorIsThousandRaisedToExponent(100);

    [Fact]
    public void Int32MinValue_FactorIsThousandRaisedToInt32MinValue() => FactorIsThousandRaisedToExponent(int.MinValue);

    [AssertionMethod]
    private static void FactorIsThousandRaisedToExponent(int exponent)
    {
        Scalar expected = Math.Pow(1000, exponent);
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
