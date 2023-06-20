namespace SharpMeasures.UnhandledCases;
using System;

using Xunit;

public sealed class Operator_Multiply_Unhandled_IScalarQuantity
{
    private static Unhandled Target(Unhandled x, IScalarQuantity y) => x * y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled x) => ThrowsException<ArgumentNullException>(x, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled x) => EqualsMethod(x, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled x) => EqualsMethod(x, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled x, IScalarQuantity y)
    {
        var expected = Unhandled.Multiply(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(Unhandled x, IScalarQuantity y) where TException : Exception
    {
        var exception = Record.Exception(() => Target(x, y));

        Assert.IsType<TException>(exception);
    }
}
