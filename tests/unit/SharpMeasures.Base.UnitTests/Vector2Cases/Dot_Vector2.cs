namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Dot_Vector2
{
    private static Scalar Target(Vector2 vector, Vector2 factor) => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsArithmeticDotProduct(Vector2 vector) => EqualsArithmeticDotProduct(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsArithmeticDotProduct(Vector2 vector) => EqualsArithmeticDotProduct(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsArithmeticDotProduct(Vector2 vector) => EqualsArithmeticDotProduct(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsArithmeticDotProduct(Vector2 vector) => EqualsArithmeticDotProduct(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsArithmeticDotProduct(Vector2 vector) => EqualsArithmeticDotProduct(vector, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsArithmeticDotProduct(Vector2 vector) => EqualsArithmeticDotProduct(vector, (-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsArithmeticDotProduct(Vector2 vector, Vector2 factor)
    {
        var expected = (vector.X * factor.X) + (vector.Y * factor.Y);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
