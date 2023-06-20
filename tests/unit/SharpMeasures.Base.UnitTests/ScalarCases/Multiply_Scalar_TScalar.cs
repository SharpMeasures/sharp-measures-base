namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Multiply_Scalar_TScalar
{
    private static TScalar Target<TScalar>(Scalar x, TScalar y) where TScalar : IScalarQuantity<TScalar> => Scalar.Multiply(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Scalar x) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(x, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Scalar x) => EqualsInstanceMethod(x, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TScalar>(Scalar x, TScalar y) where TScalar : IScalarQuantity<TScalar>
    {
        var expected = x.Multiply(y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Scalar x, TScalar y) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(x, y));

        Assert.IsType<TException>(exception);
    }
}
