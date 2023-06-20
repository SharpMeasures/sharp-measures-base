namespace SharpMeasures.UnhandledCases;
using System;

using Xunit;

public sealed class Multiply_Unhandled_TScalar
{
    private static Unhandled Target<TScalar>(Unhandled x, TScalar y) where TScalar : IScalarQuantity<TScalar> => Unhandled.Multiply(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled x) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(x, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled x) => EqualsInstanceMethod(x, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TScalar>(Unhandled x, TScalar y) where TScalar : IScalarQuantity<TScalar>
    {
        var expected = x.Multiply(y);
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
