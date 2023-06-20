namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class DivideBy_Scalar
{
    private static Scalar Target(Scalar scalar, Scalar divisor) => scalar.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameValue_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, scalar);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegatedScalar_EqualsDoubleDivision(Scalar scalar) => EqualsDoubleDivision(scalar, -scalar);

    [AssertionMethod]
    private static void EqualsDoubleDivision(Scalar scalar, Scalar divisor)
    {
        Scalar expected = scalar.ToDouble() / divisor.ToDouble();
        var actual = Target(scalar, divisor);

        Assert.Equal(expected, actual);
    }
}
