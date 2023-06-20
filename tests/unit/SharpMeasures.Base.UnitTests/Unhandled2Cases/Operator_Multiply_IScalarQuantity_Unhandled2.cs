namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class Operator_Multiply_IScalarQuantity_Unhandled2
{
    private static Unhandled2 Target(IScalarQuantity a, Unhandled2 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 b) => ThrowsException<ArgumentNullException>(null!, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled2 b) => EqualsMethod(Scalar.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled2 b) => EqualsMethod(Scalar.NaN, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled2 b) => EqualsMethod(Scalar.PositiveInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled2 b) => EqualsMethod(Scalar.NegativeInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled2 b) => EqualsMethod(1.5 * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled2 b) => EqualsMethod(1.5 * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsMethod(IScalarQuantity a, Unhandled2 b)
    {
        var expected = Unhandled2.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(IScalarQuantity a, Unhandled2 b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
