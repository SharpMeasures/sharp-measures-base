namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class Operator_Subtract_Unhandled2_IVector2Quantity
{
    private static Unhandled2 Target(Unhandled2 a, IVector2Quantity b) => a - b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 a) => ThrowsException<ArgumentNullException>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled2 a) => EqualsMethod(a, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled2 a) => EqualsMethod(a, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled2 a, IVector2Quantity b)
    {
        var expected = Unhandled2.Subtract(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(Unhandled2 a, IVector2Quantity b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
