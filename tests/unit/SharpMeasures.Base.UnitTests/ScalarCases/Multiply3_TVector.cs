namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Multiply3_TVector
{
    private static TVector Target<TVector>(Scalar scalar, TVector factor) where TVector : IVector3Quantity<TVector> => scalar.Multiply3(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Scalar scalar) => ThrowsException<ArgumentNullException, ReferenceVector3Quantity>(scalar, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiply(Scalar scalar) => EqualsMultiply(scalar, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiply<TVector>(Scalar scalar, TVector factor) where TVector : IVector3Quantity<TVector>
    {
        var expected = scalar.Multiply(factor);
        var actual = Target(scalar, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Scalar scalar, TVector factor) where TException : Exception where TVector : IVector3Quantity<TVector>
    {
        var exception = Record.Exception(() => Target(scalar, factor));

        Assert.IsType<TException>(exception);
    }
}
