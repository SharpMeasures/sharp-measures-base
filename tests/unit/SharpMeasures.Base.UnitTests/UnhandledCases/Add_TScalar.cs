namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Add_TScalar
{
    private static Unhandled Target<TScalar>(Unhandled unhandled, TScalar addend) where TScalar : IScalarQuantity<TScalar> => unhandled.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled unhandled) => ThrowsException<ArgumentNullException, ReferenceScalarQuantity>(unhandled, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAdditionOfMagnitudes(Unhandled unhandled) => EqualsAdditionOfMagnitudes(unhandled, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAdditionOfMagnitudes(Unhandled unhandled) => EqualsAdditionOfMagnitudes(unhandled, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAdditionOfMagnitudes(Unhandled unhandled) => EqualsAdditionOfMagnitudes(unhandled, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAdditionOfMagnitudes(Unhandled unhandled) => EqualsAdditionOfMagnitudes(unhandled, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAdditionOfMagnitudes(Unhandled unhandled) => EqualsAdditionOfMagnitudes(unhandled, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAdditionOfMagnitudes(Unhandled unhandled) => EqualsAdditionOfMagnitudes(unhandled, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsAdditionOfMagnitudes<TScalar>(Unhandled unhandled, TScalar addend) where TScalar : IScalarQuantity<TScalar>
    {
        Unhandled expected = new(unhandled.Magnitude + addend.Magnitude);
        var actual = Target(unhandled, addend);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException, TScalar>(Unhandled unhandled, TScalar addend) where TException : Exception where TScalar : IScalarQuantity<TScalar>
    {
        var exception = Record.Exception(() => Target(unhandled, addend));

        Assert.IsType<TException>(exception);
    }
}
