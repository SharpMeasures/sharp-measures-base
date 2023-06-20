namespace SharpMeasures.UnhandledCases;
using System;

using Xunit;

public sealed class DivideBy_TScalar
{
    private static Unhandled Target<TScalar>(Unhandled x, TScalar y) where TScalar : IScalarQuantity<TScalar> => x.DivideBy(y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled x) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(x, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionByMagnitude(Unhandled x) => EqualsDivisionByMagnitude(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionByMagnitude(Unhandled x) => EqualsDivisionByMagnitude(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionByMagnitude(Unhandled x) => EqualsDivisionByMagnitude(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionByMagnitude(Unhandled x) => EqualsDivisionByMagnitude(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionByMagnitude(Unhandled x) => EqualsDivisionByMagnitude(x, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionByMagnitude(Unhandled x) => EqualsDivisionByMagnitude(x, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsDivisionByMagnitude<TScalar>(Unhandled x, TScalar y) where TScalar : IScalarQuantity<TScalar>
    {
        Unhandled expected = new(x.Magnitude / y.Magnitude);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled x, TScalar y) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(x, y));

        Assert.IsType<TException>(exception);
    }
}
