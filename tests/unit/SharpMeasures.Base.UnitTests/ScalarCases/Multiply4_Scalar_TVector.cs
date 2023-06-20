namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Multiply4_Scalar_TVector
{
    private static TVector Target<TVector>(Scalar a, TVector b) where TVector : IVector4Quantity<TVector> => Scalar.Multiply4(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Scalar a) => ThrowsException<ArgumentNullException, ReferenceVector4Quantity>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Scalar a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TVector>(Scalar a, TVector b) where TVector : IVector4Quantity<TVector>
    {
        var expected = a.Multiply4(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Scalar a, TVector b) where TException : Exception where TVector : IVector4Quantity<TVector>
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
