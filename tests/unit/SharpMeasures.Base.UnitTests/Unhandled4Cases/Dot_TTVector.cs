namespace SharpMeasures.Unhandled4Cases;

using System;

using Xunit;

public sealed class Dot_TTVector
{
    private static Unhandled Target<TVector>(Unhandled4 vector, TVector factor) where TVector : IVector4Quantity => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled4 vector) => ThrowsException<ArgumentNullException, ReferenceVector4Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMagnitudeOfDotProductOfComponents<TVector>(Unhandled4 vector, TVector factor) where TVector : IVector4Quantity
    {
        Unhandled expected = new(vector.Components.Dot(factor.Components));
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled4 vector, TVector factor) where TException : Exception where TVector : IVector4Quantity
    {
        var exception = Record.Exception(() => Target(vector, factor));

        Assert.IsType<TException>(exception);
    }
}
