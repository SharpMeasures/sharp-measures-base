namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Operator_Multiply_IVector2Quantity_Unhandled
{
    private static Unhandled2 Target(IVector2Quantity a, Unhandled b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled b) => ThrowsException<ArgumentNullException>(null!, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationByComponents(Unhandled b) => EqualsMultiplicationByComponents(Vector2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationByComponents(Unhandled b) => EqualsMultiplicationByComponents(Scalar.NaN * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationByComponents(Unhandled b) => EqualsMultiplicationByComponents(Scalar.PositiveInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationByComponents(Unhandled b) => EqualsMultiplicationByComponents(Scalar.NegativeInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationByComponents(Unhandled b) => EqualsMultiplicationByComponents((1.5, 4.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationByComponents(Unhandled b) => EqualsMultiplicationByComponents((1.5, 4.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsMultiplicationByComponents(IVector2Quantity a, Unhandled b)
    {
        var expected = Unhandled.Multiply(b, a.Components);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(IVector2Quantity a, Unhandled b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
