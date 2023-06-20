namespace SharpMeasures.UnhandledCases;

using System;
using System.Diagnostics.CodeAnalysis;

using Xunit;

public sealed class Operator_Multiply_IScalarQuantity_Unhandled
{
    private static Unhandled Target(IScalarQuantity x, Unhandled y) => x * y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled y) => ThrowsException<ArgumentNullException>(null!, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled y) => EqualsMethod(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled y) => EqualsMethod(1.5 * Scalar.One, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled y) => EqualsMethod(1.5 * Scalar.NegativeOne, y);

    [AssertionMethod]
    [SuppressMessage("Major Code Smell", "S2234: Parameters should be passed in the correct order", Justification = "Multiplication is commutative.")]
    private static void EqualsMethod(IScalarQuantity x, Unhandled y)
    {
        var expected = Unhandled.Multiply(y, x);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(IScalarQuantity x, Unhandled y) where TException : Exception
    {
        var exception = Record.Exception(() => Target(x, y));

        Assert.IsType<TException>(exception);
    }
}
