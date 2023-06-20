namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Cross_Unhandled3_TVector
{
    private static Unhandled3 Target<TVector>(Unhandled3 a, TVector b) where TVector : IVector3Quantity => Unhandled3.Cross(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 a) => ThrowsException<ArgumentNullException, ReferenceVector3Quantity>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TVector>(Unhandled3 a, TVector b) where TVector : IVector3Quantity
    {
        var expected = a.Cross(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled3 a, TVector b) where TException : Exception where TVector : IVector3Quantity
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
