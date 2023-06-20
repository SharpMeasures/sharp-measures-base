namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Operator_Divide_IScalarQuantity_Unhandled
{
    private static Unhandled Target(IScalarQuantity x, Unhandled y) => x / y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled y) => ThrowsException<ArgumentNullException>(null!, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(1.5 * Scalar.One, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(1.5 * Scalar.NegativeOne, y);

    [AssertionMethod]
    private static void EqualsDivisionOfMagnitudes(IScalarQuantity x, Unhandled y)
    {
        Unhandled expected = new(x.Magnitude / y.Magnitude);
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
