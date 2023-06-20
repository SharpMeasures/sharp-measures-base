namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Sign
{
    private static int Target(Scalar scalar) => scalar.Sign();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NonNaN_EqualsSystemSign(Scalar scalar)
    {
        if (scalar.IsNaN)
        {
            return;
        }

        var expected = Math.Sign(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void NaN_ArithmeticException() => ThrowsException<ArithmeticException>(Scalar.NaN);

    [AssertionMethod]
    private static void ThrowsException<TException>(Scalar scalar) where TException : Exception
    {
        var exception = Record.Exception(() => Target(scalar));

        Assert.IsType<TException>(exception);
    }
}
