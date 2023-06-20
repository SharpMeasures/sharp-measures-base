namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Operator_Subtract_IScalarQuantity_Unhandled
{
    private static Unhandled Target(IScalarQuantity x, Unhandled y) => x - y;
    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled y) => ThrowsException<ArgumentNullException>(null!, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsSubtractionOfMagnitudes(Unhandled y) => EqualsSubtractionOfMagnitudes(Scalar.Zero, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsSubtractionOfMagnitudes(Unhandled y) => EqualsSubtractionOfMagnitudes(Scalar.NaN, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsSubtractionOfMagnitudes(Unhandled y) => EqualsSubtractionOfMagnitudes(Scalar.PositiveInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsSubtractionOfMagnitudes(Unhandled y) => EqualsSubtractionOfMagnitudes(Scalar.NegativeInfinity, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsSubtractionOfMagnitudes(Unhandled y) => EqualsSubtractionOfMagnitudes(1.5 * Scalar.One, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsSubtractionOfMagnitudes(Unhandled y) => EqualsSubtractionOfMagnitudes(1.5 * Scalar.NegativeOne, y);

    [AssertionMethod]
    private static void EqualsSubtractionOfMagnitudes(IScalarQuantity x, Unhandled y)
    {
        Unhandled expected = new(x.Magnitude - y.Magnitude);
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
