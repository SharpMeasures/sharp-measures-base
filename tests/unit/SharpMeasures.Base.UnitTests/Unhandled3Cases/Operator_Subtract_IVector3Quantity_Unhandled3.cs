namespace SharpMeasures.Unhandled3Cases;

using System;
using System.Diagnostics.CodeAnalysis;

using Xunit;

public sealed class Operator_Subtract_IVector3Quantity_Unhandled3
{
    private static Unhandled3 Target(IVector3Quantity a, Unhandled3 b) => a - b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 b) => ThrowsException<ArgumentNullException>(null!, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsNegatedMethod(Unhandled3 b) => EqualsNegatedMethod(Vector3.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsNegatedMethod(Unhandled3 b) => EqualsNegatedMethod(Scalar.NaN * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsNegatedMethod(Unhandled3 b) => EqualsNegatedMethod(Scalar.PositiveInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsNegatedMethod(Unhandled3 b) => EqualsNegatedMethod(Scalar.NegativeInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsNegatedMethod(Unhandled3 b) => EqualsNegatedMethod((1.5, 4.5, 7.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsNegatedMethod(Unhandled3 b) => EqualsNegatedMethod((1.5, 4.5, 7.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    [SuppressMessage("Major Code Smell", "S2234: Parameters should be passed in the correct order", Justification = "Subtraction is anti-commutative.")]
    private static void EqualsNegatedMethod(IVector3Quantity a, Unhandled3 b)
    {
        var expected = -Unhandled3.Subtract(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(IVector3Quantity a, Unhandled3 b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
