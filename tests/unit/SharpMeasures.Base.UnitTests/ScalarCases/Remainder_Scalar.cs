namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Remainder_Scalar
{
    private static Scalar Target(Scalar scalar, Scalar divisor) => scalar.Remainder(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameValue_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, scalar);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegatedScalar_EqualsDoubleRemainder(Scalar scalar) => EqualsDoubleRemainder(scalar, -scalar);

    [AssertionMethod]
    private static void EqualsDoubleRemainder(Scalar scalar, Scalar divisor)
    {
        Scalar expected = scalar.ToDouble() % divisor.ToDouble();
        var actual = Target(scalar, divisor);

        Assert.Equal(expected, actual);
    }
}
