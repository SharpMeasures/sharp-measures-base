namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Multiply_TScalar
{
    private static TScalar Target<TScalar>(Scalar scalar, TScalar factor) where TScalar : IScalarQuantity<TScalar> => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Scalar scalar) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(scalar, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationByMagnitude(Scalar scalar) => EqualsMultiplicationByMagnitude(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationByMagnitude(Scalar scalar) => EqualsMultiplicationByMagnitude(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationByMagnitude(Scalar scalar) => EqualsMultiplicationByMagnitude(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationByMagnitude(Scalar scalar) => EqualsMultiplicationByMagnitude(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationByMagnitude(Scalar scalar) => EqualsMultiplicationByMagnitude(scalar, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationByMagnitude(Scalar scalar) => EqualsMultiplicationByMagnitude(scalar, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiplicationByMagnitude<TScalar>(Scalar scalar, TScalar factor) where TScalar : IScalarQuantity<TScalar>
    {
        var expected = scalar.Multiply(factor.Magnitude);
        var actual = Target(scalar, factor).Magnitude;

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Scalar scalar, TScalar factor) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(scalar, factor));

        Assert.IsType<TException>(exception);
    }
}
