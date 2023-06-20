namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Multiply2_TVector
{
    private static TVector Target<TVector>(Scalar scalar, TVector factor) where TVector : IVector2Quantity<TVector> => scalar.Multiply2(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Scalar scalar) => ThrowsException<ArgumentNullException, ReferenceVector2Quantity>(scalar, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiply<TVector>(Scalar scalar, TVector factor) where TVector : IVector2Quantity<TVector>
    {
        var expected = scalar.Multiply(factor);
        var actual = Target(scalar, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Scalar scalar, TVector factor) where TException : Exception where TVector : IVector2Quantity<TVector>
    {
        var exception = Record.Exception(() => Target(scalar, factor));

        Assert.IsType<TException>(exception);
    }
}
