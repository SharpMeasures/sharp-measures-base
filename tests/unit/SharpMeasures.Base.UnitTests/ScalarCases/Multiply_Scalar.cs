namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Scalar
{
    private static Scalar Target(Scalar scalar, Scalar factor) => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDoubleMultiplication(Scalar scalar) => EqualsDoubleMultiplication(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDoubleMultiplication(Scalar scalar) => EqualsDoubleMultiplication(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDoubleMultiplication(Scalar scalar) => EqualsDoubleMultiplication(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDoubleMultiplication(Scalar scalar) => EqualsDoubleMultiplication(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDoubleMultiplication(Scalar scalar) => EqualsDoubleMultiplication(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDoubleMultiplication(Scalar scalar) => EqualsDoubleMultiplication(scalar, -1.5);

    [AssertionMethod]
    private static void EqualsDoubleMultiplication(Scalar scalar, Scalar factor)
    {
        Scalar expected = scalar.ToDouble() * factor.ToDouble();
        var actual = Target(scalar, factor);

        Assert.Equal(expected, actual);
    }
}
