namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Cross_TTVector
{
    private static Unhandled3 Target<TVector>(Unhandled3 vector, TVector factor) where TVector : IVector3Quantity => vector.Cross(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 vector) => ThrowsException<ArgumentNullException, ReferenceVector3Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsOfCrossProductOfComponents(Unhandled3 vector) => EqualsComponentsOfCrossProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsComponentsOfCrossProductOfComponents<TVector>(Unhandled3 vector, TVector factor) where TVector : IVector3Quantity
    {
        Unhandled3 expected = new(vector.Components.Cross(factor.Components));
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
