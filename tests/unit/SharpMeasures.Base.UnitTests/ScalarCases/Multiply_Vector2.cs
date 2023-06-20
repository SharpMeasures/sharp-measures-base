namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Vector2
{
    private static Vector2 Target(Scalar scalar, Vector2 factor) => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsIndividualComponentsMultiplied(Scalar scalar) => EqualsIndividualComponentsMultiplied(scalar, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsIndividualComponentsMultiplied(Scalar scalar, Vector2 factor)
    {
        Vector2 expected = (scalar * factor.X, scalar * factor.Y);
        var actual = Target(scalar, factor);

        Assert.Equal(expected, actual);
    }
}
