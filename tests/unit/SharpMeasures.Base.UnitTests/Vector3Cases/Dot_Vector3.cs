namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Dot_Vector3
{
    private static Scalar Target(Vector3 vector, Vector3 factor) => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsArithmeticDotProduct(Vector3 vector) => EqualsArithmeticDotProduct(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsArithmeticDotProduct(Vector3 vector) => EqualsArithmeticDotProduct(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsArithmeticDotProduct(Vector3 vector) => EqualsArithmeticDotProduct(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsArithmeticDotProduct(Vector3 vector) => EqualsArithmeticDotProduct(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsArithmeticDotProduct(Vector3 vector) => EqualsArithmeticDotProduct(vector, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsArithmeticDotProduct(Vector3 vector) => EqualsArithmeticDotProduct(vector, (-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsArithmeticDotProduct(Vector3 vector, Vector3 factor)
    {
        var expected = (vector.X * factor.X) + (vector.Y * factor.Y) + (vector.Z * factor.Z);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
