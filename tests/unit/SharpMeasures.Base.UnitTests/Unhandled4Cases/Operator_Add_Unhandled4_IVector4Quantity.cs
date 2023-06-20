namespace SharpMeasures.Unhandled4Cases;

using System;

using Xunit;

public sealed class Operator_Add_Unhandled4_IVector4Quantity
{
    private static Unhandled4 Target(Unhandled4 a, IVector4Quantity b) => a + b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled4 a) => ThrowsException<ArgumentNullException>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled4 a) => EqualsMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled4 a) => EqualsMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled4 a, IVector4Quantity b)
    {
        var expected = Unhandled4.Add(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(Unhandled4 a, IVector4Quantity b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
