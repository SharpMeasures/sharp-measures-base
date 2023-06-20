namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Operator_Divide_IVector2Quantity_Unhandled
{
    private static Unhandled2 Target(IVector2Quantity x, Unhandled y) => x / y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled y) => ThrowsException<ArgumentNullException>(null!, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfComponents(Unhandled y) => EqualsDivisionOfComponents(Vector2.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfComponents(Unhandled y) => EqualsDivisionOfComponents(Scalar.NaN * Vector2.Ones, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfComponents(Unhandled y) => EqualsDivisionOfComponents(Scalar.PositiveInfinity * Vector2.Ones, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfComponents(Unhandled y) => EqualsDivisionOfComponents(Scalar.NegativeInfinity * Vector2.Ones, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfComponents(Unhandled y) => EqualsDivisionOfComponents((1.5, 4.5) * Scalar.One, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfComponents(Unhandled y) => EqualsDivisionOfComponents((1.5, 4.5) * Scalar.NegativeOne, y);

    [AssertionMethod]
    private static void EqualsDivisionOfComponents(IVector2Quantity x, Unhandled y)
    {
        var expected = x.Components / y;
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(IVector2Quantity x, Unhandled y) where TException : Exception
    {
        var exception = Record.Exception(() => Target(x, y));

        Assert.IsType<TException>(exception);
    }
}
