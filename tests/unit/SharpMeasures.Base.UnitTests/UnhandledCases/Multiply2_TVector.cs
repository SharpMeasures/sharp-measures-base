namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Multiply2_TVector
{
    private static Unhandled2 Target<TVector>(Unhandled unhandled, TVector factor) where TVector : IVector2Quantity<TVector> => unhandled.Multiply2(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled unhandled) => ThrowsException<ArgumentNullException, ReferenceVector2Quantity>(unhandled, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiply<TVector>(Unhandled unhandled, TVector factor) where TVector : IVector2Quantity<TVector>
    {
        var expected = unhandled.Multiply(factor);
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled unhandled, TVector factor) where TException : Exception where TVector : IVector2Quantity<TVector>
    {
        var exception = Record.Exception(() => Target(unhandled, factor));

        Assert.IsType<TException>(exception);
    }
}
