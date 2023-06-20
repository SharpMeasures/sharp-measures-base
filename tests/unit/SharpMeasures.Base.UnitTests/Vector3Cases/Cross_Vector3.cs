namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Cross_Vector3
{
    private static Vector3 Target(Vector3 vector, Vector3 factor) => vector.Cross(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsArithmeticCrossProduct(Vector3 vector) => EqualsArithmeticCrossProduct(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsArithmeticCrossProduct(Vector3 vector) => EqualsArithmeticCrossProduct(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsArithmeticCrossProduct(Vector3 vector) => EqualsArithmeticCrossProduct(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsArithmeticCrossProduct(Vector3 vector) => EqualsArithmeticCrossProduct(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsArithmeticCrossProduct(Vector3 vector) => EqualsArithmeticCrossProduct(vector, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsArithmeticCrossProduct(Vector3 vector) => EqualsArithmeticCrossProduct(vector, (-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsArithmeticCrossProduct(Vector3 vector, Vector3 factor)
    {
        Vector3 expected =
        (
            (vector.Y * factor.Z) - (vector.Z * factor.Y),
            (vector.Z * factor.X) - (vector.X * factor.Z),
            (vector.X * factor.Y) - (vector.Y * factor.X)
        );

        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
