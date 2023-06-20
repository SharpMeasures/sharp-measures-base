namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class Multiply_IVector3Quantity
{
    private static Unhandled3 Target(Unhandled unhandled, IVector3Quantity factor) => unhandled.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled unhandled) => ThrowsException<ArgumentNullException>(unhandled, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMultiplicationByComponents(Unhandled unhandled, IVector3Quantity factor)
    {
        var expected = unhandled.Multiply(factor.Components);
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(Unhandled unhandled, IVector3Quantity factor) where TException : Exception
    {
        var exception = Record.Exception(() => Target(unhandled, factor));

        Assert.IsType<TException>(exception);
    }
}
