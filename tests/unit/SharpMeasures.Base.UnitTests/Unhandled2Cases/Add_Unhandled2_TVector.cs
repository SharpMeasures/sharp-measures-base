namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class Add_Unhandled2_TVector
{
    private static Unhandled2 Target<TVector>(Unhandled2 a, TVector b) where TVector : IVector2Quantity => Unhandled2.Add(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 a) => ThrowsException<ArgumentNullException, ReferenceVector2Quantity>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled2 a) => EqualsInstanceMethod(a, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled2 a) => EqualsInstanceMethod(a, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled2 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled2 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled2 a) => EqualsInstanceMethod(a, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled2 a) => EqualsInstanceMethod(a, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod<TVector>(Unhandled2 a, TVector b) where TVector : IVector2Quantity
    {
        var expected = a.Add(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled2 a, TVector b) where TException : Exception where TVector : IVector2Quantity
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
