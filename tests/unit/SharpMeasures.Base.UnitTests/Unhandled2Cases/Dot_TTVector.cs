namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class Dot_TTVector
{
    private static Unhandled Target<TVector>(Unhandled2 vector, TVector factor) where TVector : IVector2Quantity => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 vector) => ThrowsException<ArgumentNullException, ReferenceVector2Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMagnitudeOfDotProductOfComponents<TVector>(Unhandled2 vector, TVector factor) where TVector : IVector2Quantity
    {
        Unhandled expected = new(vector.Components.Dot(factor.Components));
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled2 vector, TVector factor) where TException : Exception where TVector : IVector2Quantity
    {
        var exception = Record.Exception(() => Target(vector, factor));

        Assert.IsType<TException>(exception);
    }
}
