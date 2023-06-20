namespace SharpMeasures.Unhandled2Cases;

using System;
using System.Diagnostics.CodeAnalysis;

using Xunit;

public sealed class Operator_Subtract_IVector2Quantity_Unhandled2
{
    private static Unhandled2 Target(IVector2Quantity a, Unhandled2 b) => a - b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 b) => ThrowsException<ArgumentNullException>(null!, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsNegatedMethod(Unhandled2 b) => EqualsNegatedMethod(Vector2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsNegatedMethod(Unhandled2 b) => EqualsNegatedMethod(Scalar.NaN * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsNegatedMethod(Unhandled2 b) => EqualsNegatedMethod(Scalar.PositiveInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsNegatedMethod(Unhandled2 b) => EqualsNegatedMethod(Scalar.NegativeInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsNegatedMethod(Unhandled2 b) => EqualsNegatedMethod((1.5, 4.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsNegatedMethod(Unhandled2 b) => EqualsNegatedMethod((1.5, 4.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    [SuppressMessage("Major Code Smell", "S2234: Parameters should be passed in the correct order", Justification = "Subtraction is anti-commutative.")]
    private static void EqualsNegatedMethod(IVector2Quantity a, Unhandled2 b)
    {
        var expected = -Unhandled2.Subtract(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(IVector2Quantity a, Unhandled2 b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
