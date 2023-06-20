namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Multiply4_TVector
{
    private static Unhandled4 Target<TVector>(Unhandled unhandled, TVector factor) where TVector : IVector4Quantity<TVector> => unhandled.Multiply4(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled unhandled) => ThrowsException<ArgumentNullException, ReferenceVector4Quantity>(unhandled, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiply(Unhandled unhandled) => EqualsMultiply(unhandled, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiply<TVector>(Unhandled unhandled, TVector factor) where TVector : IVector4Quantity<TVector>
    {
        var expected = unhandled.Multiply(factor);
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled unhandled, TVector factor) where TException : Exception where TVector : IVector4Quantity<TVector>
    {
        var exception = Record.Exception(() => Target(unhandled, factor));

        Assert.IsType<TException>(exception);
    }
}
