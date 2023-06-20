namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class DivideBy_TScalar
{
    private static Unhandled3 Target<TScalar>(Unhandled3 vector, TScalar divisor) where TScalar : IScalarQuantity => vector.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 vector) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisonOfComponentsByMagnitude(Unhandled3 vector) => EqualsDivisonOfComponentsByMagnitude(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisonOfComponentsByMagnitude(Unhandled3 vector) => EqualsDivisonOfComponentsByMagnitude(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisonOfComponentsByMagnitude(Unhandled3 vector) => EqualsDivisonOfComponentsByMagnitude(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisonOfComponentsByMagnitude(Unhandled3 vector) => EqualsDivisonOfComponentsByMagnitude(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisonOfComponentsByMagnitude(Unhandled3 vector) => EqualsDivisonOfComponentsByMagnitude(vector, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisonOfComponentsByMagnitude(Unhandled3 vector) => EqualsDivisonOfComponentsByMagnitude(vector, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsDivisonOfComponentsByMagnitude<TScalar>(Unhandled3 vector, TScalar divisor) where TScalar : IScalarQuantity
    {
        Unhandled3 expected = new(vector.Components / divisor.Magnitude);
        var actual = Target(vector, divisor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled3 vector, TScalar divisor) where TException : Exception where TScalar : IScalarQuantity
    {
        var exception = Record.Exception(() => Target(vector, divisor));

        Assert.IsType<TException>(exception);
    }
}
