namespace SharpMeasures.Unhandled4Cases;

using System;
using System.Diagnostics.CodeAnalysis;

using Xunit;

public sealed class Operator_Subtract_IVector4Quantity_Unhandled4
{
    private static Unhandled4 Target(IVector4Quantity a, Unhandled4 b) => a - b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled4 b) => ThrowsException<ArgumentNullException>(null!, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsNegatedMethod(Unhandled4 b) => EqualsNegatedMethod(Vector4.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsNegatedMethod(Unhandled4 b) => EqualsNegatedMethod(Scalar.NaN * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsNegatedMethod(Unhandled4 b) => EqualsNegatedMethod(Scalar.PositiveInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsNegatedMethod(Unhandled4 b) => EqualsNegatedMethod(Scalar.NegativeInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsNegatedMethod(Unhandled4 b) => EqualsNegatedMethod((1.5, 4.5, 7.5, 10.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsNegatedMethod(Unhandled4 b) => EqualsNegatedMethod((1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    [SuppressMessage("Major Code Smell", "S2234: Parameters should be passed in the correct order", Justification = "Subtraction is anti-commutative.")]
    private static void EqualsNegatedMethod(IVector4Quantity a, Unhandled4 b)
    {
        var expected = -Unhandled4.Subtract(b, a);
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
