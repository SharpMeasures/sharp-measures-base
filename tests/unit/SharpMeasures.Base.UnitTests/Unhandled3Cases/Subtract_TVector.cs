namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Subtract_TVector
{
    private static Unhandled3 Target<TVector>(Unhandled3 vector, TVector subtrahend) where TVector : IVector3Quantity => vector.Subtract(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 vector) => ThrowsException<ArgumentNullException, ReferenceVector3Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsSubtractionOfComponents(Unhandled3 vector) => EqualsSubtractionOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsSubtractionOfComponents(Unhandled3 vector) => EqualsSubtractionOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsSubtractionOfComponents(Unhandled3 vector) => EqualsSubtractionOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsSubtractionOfComponents(Unhandled3 vector) => EqualsSubtractionOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsSubtractionOfComponents(Unhandled3 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsSubtractionOfComponents(Unhandled3 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsSubtractionOfComponents<TVector>(Unhandled3 vector, TVector subtrahend) where TVector : IVector3Quantity
    {
        Unhandled3 expected = new(vector.Components - subtrahend.Components);
        var actual = Target(vector, subtrahend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled3 vector, TVector subtrahend) where TException : Exception where TVector : IVector3Quantity
    {
        var exception = Record.Exception(() => Target(vector, subtrahend));

        Assert.IsType<TException>(exception);
    }
}
