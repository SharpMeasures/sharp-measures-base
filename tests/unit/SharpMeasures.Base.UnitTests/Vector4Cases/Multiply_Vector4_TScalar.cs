namespace SharpMeasures.Vector4Cases;
using System;

using Xunit;

public sealed class Multiply_Vector4_TScalar
{
    private static (TScalar, TScalar, TScalar, TScalar) Target<TScalar>(Vector4 a, TScalar b) where TScalar : IScalarQuantity<TScalar> => Vector4.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Vector4 vector) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod<Scalar>(a, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod<Scalar>(a, -1.5);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TScalar>(Vector4 a, TScalar b) where TScalar : IScalarQuantity<TScalar>
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Vector4 vector, TScalar factor) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(vector, factor));

        Assert.IsType<TException>(exception);
    }
}
