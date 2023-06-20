namespace SharpMeasures.UnhandledCases;
using System;

using Xunit;

public sealed class Multiply_TScalar
{
    private static Unhandled Target<TScalar>(Unhandled unhandled, TScalar factor) where TScalar : IScalarQuantity<TScalar> => unhandled.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled unhandled) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(unhandled, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfMagnitudes(Unhandled unhandled) => EqualsMultiplicationOfMagnitudes(unhandled, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfMagnitudes(Unhandled unhandled) => EqualsMultiplicationOfMagnitudes(unhandled, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfMagnitudes(Unhandled unhandled) => EqualsMultiplicationOfMagnitudes(unhandled, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfMagnitudes(Unhandled unhandled) => EqualsMultiplicationOfMagnitudes(unhandled, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfMagnitudes(Unhandled unhandled) => EqualsMultiplicationOfMagnitudes(unhandled, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfMagnitudes(Unhandled unhandled) => EqualsMultiplicationOfMagnitudes(unhandled, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiplicationOfMagnitudes<TScalar>(Unhandled unhandled, TScalar factor) where TScalar : IScalarQuantity<TScalar>
    {
        Unhandled expected = new(unhandled.Magnitude * factor.Magnitude);
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled unhandled, TScalar factor) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(unhandled, factor));

        Assert.IsType<TException>(exception);
    }
}
