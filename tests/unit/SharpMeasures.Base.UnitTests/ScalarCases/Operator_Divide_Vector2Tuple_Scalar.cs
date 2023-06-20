namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Divide_Vector2Tuple_Scalar
{
    private static Vector2 Target((Scalar, Scalar) a, Scalar b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector2DivideMethod(Scalar b) => EqualsVector2DivideMethod(Vector2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector2DivideMethod(Scalar b) => EqualsVector2DivideMethod(Scalar.NaN * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector2DivideMethod(Scalar b) => EqualsVector2DivideMethod(Scalar.PositiveInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector2DivideMethod(Scalar b) => EqualsVector2DivideMethod(Scalar.NegativeInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector2DivideMethod(Scalar b) => EqualsVector2DivideMethod((1.5, 4.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector2DivideMethod(Scalar b) => EqualsVector2DivideMethod((1.5, 4.5) * Scalar.One, b);

    [AssertionMethod]
    private static void EqualsVector2DivideMethod((Scalar, Scalar) a, Scalar b)
    {
        var expected = Vector2.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
