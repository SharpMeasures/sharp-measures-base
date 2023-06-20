namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Operator_Divide_Unhandled_IScalarQuantity
{
    private static Unhandled Target(Unhandled x, IScalarQuantity y) => x / y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled y) => ThrowsException<ArgumentNullException>(y, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(y, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(y, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(y, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(y, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(y, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfMagnitudes(Unhandled y) => EqualsDivisionOfMagnitudes(y, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsDivisionOfMagnitudes(Unhandled x, IScalarQuantity y)
    {
        Unhandled expected = new(x.Magnitude / y.Magnitude);
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
