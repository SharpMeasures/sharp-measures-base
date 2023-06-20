namespace SharpMeasures.Unhandled4Cases;

using System;

using Xunit;

public sealed class Add_TVector
{
    private static Unhandled4 Target<TVector>(Unhandled4 vector, TVector addend) where TVector : IVector4Quantity => vector.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled4 vector) => ThrowsException<ArgumentNullException, ReferenceVector4Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAdditionOfComponents(Unhandled4 vector) => EqualsAdditionOfComponents(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAdditionOfComponents(Unhandled4 vector) => EqualsAdditionOfComponents(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAdditionOfComponents(Unhandled4 vector) => EqualsAdditionOfComponents(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAdditionOfComponents(Unhandled4 vector) => EqualsAdditionOfComponents(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAdditionOfComponents(Unhandled4 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAdditionOfComponents(Unhandled4 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsAdditionOfComponents<TVector>(Unhandled4 vector, TVector addend) where TVector : IVector4Quantity
    {
        Unhandled4 expected = new(vector.Components + addend.Components);
        var actual = Target(vector, addend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled4 vector, TVector addend) where TException : Exception where TVector : IVector4Quantity
    {
        var exception = Record.Exception(() => Target(vector, addend));

        Assert.IsType<TException>(exception);
    }
}
