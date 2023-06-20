namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Divide_Unhandled3_TScalar
{
    private static Unhandled3 Target<TScalar>(Unhandled3 a, TScalar b) where TScalar : IScalarQuantity => Unhandled3.Divide(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 a) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TScalar>(Unhandled3 a, TScalar b) where TScalar : IScalarQuantity
    {
        var expected = a.DivideBy(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled3 a, TScalar b) where TException : Exception where TScalar : IScalarQuantity
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
