namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Add_TVector
{
    private static Unhandled3 Target<TVector>(Unhandled3 vector, TVector addend) where TVector : IVector3Quantity => vector.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 vector) => ThrowsException<ArgumentNullException, ReferenceVector3Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAdditionOfComponents(Unhandled3 vector) => EqualsAdditionOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAdditionOfComponents(Unhandled3 vector) => EqualsAdditionOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAdditionOfComponents(Unhandled3 vector) => EqualsAdditionOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAdditionOfComponents(Unhandled3 vector) => EqualsAdditionOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAdditionOfComponents(Unhandled3 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAdditionOfComponents(Unhandled3 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsAdditionOfComponents<TVector>(Unhandled3 vector, TVector addend) where TVector : IVector3Quantity
    {
        Unhandled3 expected = new(vector.Components + addend.Components);
        var actual = Target(vector, addend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled3 vector, TVector addend) where TException : Exception where TVector : IVector3Quantity
    {
        var exception = Record.Exception(() => Target(vector, addend));

        Assert.IsType<TException>(exception);
    }
}
