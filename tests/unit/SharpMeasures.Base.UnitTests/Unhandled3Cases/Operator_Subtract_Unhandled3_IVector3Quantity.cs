namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class Operator_Subtract_Unhandled3_IVector3Quantity
{
    private static Unhandled3 Target(Unhandled3 a, IVector3Quantity b) => a - b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_ArgumentNullException(Unhandled3 a) => ThrowsException<ArgumentNullException>(a, null!);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled3 a) => EqualsMethod(a, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled3 a) => EqualsMethod(a, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled3 a, IVector3Quantity b)
    {
        var expected = Unhandled3.Subtract(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }

    [AssertionMethod]
    private static void ThrowsException<TException>(Unhandled3 a, IVector3Quantity b) where TException : Exception
    {
        var exception = Record.Exception(() => Target(a, b));

        Assert.IsType<TException>(exception);
    }
}
