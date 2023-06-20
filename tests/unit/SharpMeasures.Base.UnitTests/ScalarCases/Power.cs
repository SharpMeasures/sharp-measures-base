namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Power
{
    private static Scalar Target(Scalar scalar, Scalar exponent) => scalar.Power(exponent);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMathPow(Scalar scalar) => EqualsMathPow(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMathPow(Scalar scalar) => EqualsMathPow(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMathPow(Scalar scalar) => EqualsMathPow(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMathPow(Scalar scalar) => EqualsMathPow(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMathPow(Scalar scalar) => EqualsMathPow(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMathPow(Scalar scalar) => EqualsMathPow(scalar, -1.5);

    [AssertionMethod]
    private static void EqualsMathPow(Scalar scalar, Scalar exponent)
    {
        Scalar expected = Math.Pow(scalar, exponent);
        var actual = Target(scalar, exponent);

        Assert.Equal(expected, actual);
    }
}
