namespace SharpMeasures.Unhandled4Cases;

using System;
using System.Diagnostics.CodeAnalysis;

using Xunit;

public sealed class Operator_Add_IVector4Quantity_Unhandled4
{
    private static Unhandled4 Target(IVector4Quantity a, Unhandled4 b) => a + b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled4 b) => ThrowsException<ArgumentNullException>(null!, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled4 b) => EqualsMethod(Vector4.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.NaN * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.PositiveInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.NegativeInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled4 b) => EqualsMethod((1.5, 4.5, 7.5, 10.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled4 b) => EqualsMethod((1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    [SuppressMessage("Major Code Smell", "S2234: Parameters should be passed in the correct order", Justification = "Addition is commutative.")]
    private static void EqualsMethod(IVector4Quantity a, Unhandled4 b)
    {
        var expected = Unhandled4.Add(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(IVector4Quantity a, Unhandled4 b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
