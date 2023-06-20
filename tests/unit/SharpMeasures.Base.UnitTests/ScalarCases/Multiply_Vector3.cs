namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Vector3
{
    private static Vector3 Target(Scalar scalar, Vector3 factor) => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsIndividualComponentsMultiplied(Scalar scalar, Vector3 factor)
    {
        Vector3 expected = (scalar * factor.X, scalar * factor.Y, scalar * factor.Z);
        var actual = Target(scalar, factor);

        Assert.Equal(expected, actual);
    }
}
