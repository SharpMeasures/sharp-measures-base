namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Multiply_Vector2Tuple_Scalar
{
    private static Vector2 Target((Scalar, Scalar) a, Scalar b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector2MultiplyMethod(Scalar b) => EqualsVector2MultiplyMethod(Vector2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector2MultiplyMethod(Scalar b) => EqualsVector2MultiplyMethod(Scalar.NaN * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector2MultiplyMethod(Scalar b) => EqualsVector2MultiplyMethod(Scalar.PositiveInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector2MultiplyMethod(Scalar b) => EqualsVector2MultiplyMethod(Scalar.NegativeInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector2MultiplyMethod(Scalar b) => EqualsVector2MultiplyMethod((1.5, 4.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector2MultiplyMethod(Scalar b) => EqualsVector2MultiplyMethod((1.5, 4.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsVector2MultiplyMethod((Scalar, Scalar) a, Scalar b)
    {
        var expected = Vector2.Multiply(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
