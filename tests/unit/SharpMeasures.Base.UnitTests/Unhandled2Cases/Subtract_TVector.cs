namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class Subtract_TVector
{
    private static Unhandled2 Target<TVector>(Unhandled2 vector, TVector subtrahend) where TVector : IVector2Quantity => vector.Subtract(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 vector) => ThrowsException<ArgumentNullException, ReferenceVector2Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsSubtractionOfComponents(Unhandled2 vector) => EqualsSubtractionOfComponents(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsSubtractionOfComponents(Unhandled2 vector) => EqualsSubtractionOfComponents(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsSubtractionOfComponents(Unhandled2 vector) => EqualsSubtractionOfComponents(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsSubtractionOfComponents(Unhandled2 vector) => EqualsSubtractionOfComponents(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsSubtractionOfComponents(Unhandled2 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsSubtractionOfComponents(Unhandled2 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsSubtractionOfComponents<TVector>(Unhandled2 vector, TVector subtrahend) where TVector : IVector2Quantity
    {
        Unhandled2 expected = new(vector.Components - subtrahend.Components);
        var actual = Target(vector, subtrahend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled2 vector, TVector subtrahend) where TException : Exception where TVector : IVector2Quantity
    {
        var exception = Record.Exception(() => Target(vector, subtrahend));

        Assert.IsType<TException>(exception);
    }
}
