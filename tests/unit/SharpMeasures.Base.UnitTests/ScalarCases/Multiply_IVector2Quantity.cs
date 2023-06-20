namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Multiply_IVector2Quantity
{
    private static TVector Target<TVector>(Scalar scalar, IVector2Quantity<TVector> factor) where TVector : IVector2Quantity<TVector> => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Scalar scalar) => ThrowsException<ArgumentNullException, Vector2>(scalar, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplyByComponents(Scalar scalar) => EqualsMultiplyByComponents(scalar, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplyByComponents(Scalar scalar) => EqualsMultiplyByComponents(scalar, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplyByComponents(Scalar scalar) => EqualsMultiplyByComponents(scalar, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplyByComponents(Scalar scalar) => EqualsMultiplyByComponents(scalar, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplyByComponents(Scalar scalar) => EqualsMultiplyByComponents(scalar, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplyByComponents(Scalar scalar) => EqualsMultiplyByComponents(scalar, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiplyByComponents<TVector>(Scalar scalar, IVector2Quantity<TVector> factor) where TVector : IVector2Quantity<TVector>
    {
        var expected = scalar.Multiply(factor.Components);
        var actual = Target(scalar, factor).Components;

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Scalar scalar, IVector2Quantity<TVector> factor) where TException : Exception where TVector : IVector2Quantity<TVector>
    {
        var exception = Record.Exception(() => Target(scalar, factor));

        Assert.IsType<TException>(exception);
    }
}
