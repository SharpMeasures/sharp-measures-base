namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Vector4
{
    private static Vector4 Target(Scalar scalar, Vector4 factor) => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsIndividualComponentsMultiplied(Scalar scalar, Vector4 factor)
    {
        Vector4 expected = (scalar * factor.X, scalar * factor.Y, scalar * factor.Z, scalar * factor.W);
        var actual = Target(scalar, factor);

        Assert.Equal(expected, actual);
    }
}
