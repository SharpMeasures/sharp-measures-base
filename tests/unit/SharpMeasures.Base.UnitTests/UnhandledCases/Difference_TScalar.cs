namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Difference_TScalar
{
    private static Unhandled Target<TScalar>(Unhandled unhandled, TScalar subtrahend) where TScalar : IScalarQuantity<TScalar> => unhandled.Difference(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled unhandled) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(unhandled, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDifferenceOfMagnitudes(Unhandled unhandled) => EqualsDifferenceOfMagnitudes(unhandled, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDifferenceOfMagnitudes(Unhandled unhandled) => EqualsDifferenceOfMagnitudes(unhandled, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDifferenceOfMagnitudes(Unhandled unhandled) => EqualsDifferenceOfMagnitudes(unhandled, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDifferenceOfMagnitudes(Unhandled unhandled) => EqualsDifferenceOfMagnitudes(unhandled, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDifferenceOfMagnitudes(Unhandled unhandled) => EqualsDifferenceOfMagnitudes(unhandled, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDifferenceOfMagnitudes(Unhandled unhandled) => EqualsDifferenceOfMagnitudes(unhandled, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsDifferenceOfMagnitudes<TScalar>(Unhandled unhandled, TScalar subtrahend) where TScalar : IScalarQuantity<TScalar>
    {
        Unhandled expected = new(unhandled.Magnitude.Difference(subtrahend.Magnitude));
        var actual = Target(unhandled, subtrahend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled unhandled, TScalar subtrahend) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(unhandled, subtrahend));

        Assert.IsType<TException>(exception);
    }
}
