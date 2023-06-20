namespace SharpMeasures.Unhandled4Cases;

using System;

using Xunit;

public sealed class Divide_Unhandled4_TScalar
{
    private static Unhandled4 Target<TScalar>(Unhandled4 a, TScalar b) where TScalar : IScalarQuantity => Unhandled4.Divide(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled4 a) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TScalar>(Unhandled4 a, TScalar b) where TScalar : IScalarQuantity
    {
        var expected = a.DivideBy(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled4 a, TScalar b) where TException : Exception where TScalar : IScalarQuantity
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
