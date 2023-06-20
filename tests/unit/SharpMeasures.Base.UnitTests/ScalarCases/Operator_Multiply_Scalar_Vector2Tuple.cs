namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Vector2Tuple
{
    private static Vector2 Target(Scalar a, (Scalar, Scalar) b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector2MultiplyMethod(Scalar a) => EqualsVector2MultiplyMethod(a, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector2MultiplyMethod(Scalar a) => EqualsVector2MultiplyMethod(a, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector2MultiplyMethod(Scalar a) => EqualsVector2MultiplyMethod(a, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector2MultiplyMethod(Scalar a) => EqualsVector2MultiplyMethod(a, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector2MultiplyMethod(Scalar a) => EqualsVector2MultiplyMethod(a, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector2MultiplyMethod(Scalar a) => EqualsVector2MultiplyMethod(a, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsVector2MultiplyMethod(Scalar a, (Scalar, Scalar) b)
    {
        var expected = Vector2.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
