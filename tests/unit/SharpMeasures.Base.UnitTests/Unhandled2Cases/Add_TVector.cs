namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class Add_TVector
{
    private static Unhandled2 Target<TVector>(Unhandled2 vector, TVector addend) where TVector : IVector2Quantity => vector.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled2 vector) => ThrowsException<ArgumentNullException, ReferenceVector2Quantity>(vector, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAdditionOfComponents(Unhandled2 vector) => EqualsAdditionOfComponents(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAdditionOfComponents(Unhandled2 vector) => EqualsAdditionOfComponents(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAdditionOfComponents(Unhandled2 vector) => EqualsAdditionOfComponents(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAdditionOfComponents(Unhandled2 vector) => EqualsAdditionOfComponents(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAdditionOfComponents(Unhandled2 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAdditionOfComponents(Unhandled2 vector) => EqualsAdditionOfComponents(vector, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsAdditionOfComponents<TVector>(Unhandled2 vector, TVector addend) where TVector : IVector2Quantity
    {
        Unhandled2 expected = new(vector.Components + addend.Components);
        var actual = Target(vector, addend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TVector>(Unhandled2 vector, TVector addend) where TException : Exception where TVector : IVector2Quantity
    {
        var exception = Record.Exception(() => Target(vector, addend));

        Assert.IsType<TException>(exception);
    }
}
