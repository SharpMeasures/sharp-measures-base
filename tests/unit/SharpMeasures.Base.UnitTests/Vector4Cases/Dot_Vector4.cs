namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Dot_Vector4
{
    private static Scalar Target(Vector4 vector, Vector4 factor) => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsArithmeticDotProduct(Vector4 vector) => EqualsArithmeticDotProduct(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsArithmeticDotProduct(Vector4 vector) => EqualsArithmeticDotProduct(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsArithmeticDotProduct(Vector4 vector) => EqualsArithmeticDotProduct(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsArithmeticDotProduct(Vector4 vector) => EqualsArithmeticDotProduct(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsArithmeticDotProduct(Vector4 vector) => EqualsArithmeticDotProduct(vector, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsArithmeticDotProduct(Vector4 vector) => EqualsArithmeticDotProduct(vector, (-1.5, -4.5, -7.5, -10.5));

    [AssertionMethod]
    private static void EqualsArithmeticDotProduct(Vector4 vector, Vector4 factor)
    {
        var expected = (vector.X * factor.X) + (vector.Y * factor.Y) + (vector.Z * factor.Z) + (vector.W * factor.W);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
