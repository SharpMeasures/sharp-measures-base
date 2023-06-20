namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Multiply_Unhandled3_TScalar
{
    private static Unhandled3 Target<TScalar>(Unhandled3 a, TScalar b) where TScalar : IScalarQuantity => Unhandled3.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 vector) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(vector, null!);

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
    public void Positive_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod<Scalar>(a, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod<Scalar>(a, -1.5);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TScalar>(Unhandled3 a, TScalar b) where TScalar : IScalarQuantity
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled3 vector, TScalar factor) where TException : Exception where TScalar : IScalarQuantity
    {
        var exception = Record.Exception(() => Target(vector, factor));

        Assert.IsType<TException>(exception);
    }
}
