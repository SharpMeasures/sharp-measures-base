namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Dot_TTVector
{
    private static Unhandled Target<TVector>(Unhandled3 vector, TVector factor) where TVector : IVector3Quantity => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 vector) => ThrowsException<ArgumentNullException, ReferenceVector3Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMagnitudeOfDotProductOfComponents<TVector>(Unhandled3 vector, TVector factor) where TVector : IVector3Quantity
    {
        Unhandled expected = new(vector.Components.Dot(factor.Components));
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled3 vector, TVector factor) where TException : Exception where TVector : IVector3Quantity
    {
        var exception = Record.Exception(() => Target(vector, factor));

        Assert.IsType<TException>(exception);
    }
}
