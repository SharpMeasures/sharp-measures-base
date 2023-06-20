namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Multiply3_Unhandled_TVector
{
    private static Unhandled3 Target<TVector>(Unhandled a, TVector b) where TVector : IVector3Quantity<TVector> => Unhandled.Multiply3(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled a) => ThrowsException<ArgumentNullException, ReferenceVector3Quantity>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Unhandled.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Unhandled.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Unhandled.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TVector>(Unhandled a, TVector b) where TVector : IVector3Quantity<TVector>
    {
        var expected = a.Multiply3(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled a, TVector b) where TException : Exception where TVector : IVector3Quantity<TVector>
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
