namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Sign
{
    private static int Target(Unhandled unhandled) => unhandled.Sign();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonNaN_EqualsMagnitudeSign(Unhandled unhandled)
    {
        if (unhandled.IsNaN)
        {
            return;
        }

        var expected = unhandled.Magnitude.Sign();
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NaN_ArithmeticException() => ThrowsException<ArithmeticException>(Unhandled.NaN);

    [AssertionMethod]
    private static void ThrowsException<TException>(Unhandled unhandled) where TException : Exception
    {
        var exception = Record.Exception(() => Target(unhandled));

        Assert.IsType<TException>(exception);
    }
}
