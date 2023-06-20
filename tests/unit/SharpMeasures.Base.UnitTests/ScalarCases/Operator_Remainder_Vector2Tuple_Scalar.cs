namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Remainder_Vector2Tuple_Scalar
{
    private static Vector2 Target((Scalar, Scalar) a, Scalar b) => a % b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector2RemainderMethod(Scalar b) => EqualsVector2RemainderMethod(Vector2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector2RemainderMethod(Scalar b) => EqualsVector2RemainderMethod(Scalar.NaN * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector2RemainderMethod(Scalar b) => EqualsVector2RemainderMethod(Scalar.PositiveInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector2RemainderMethod(Scalar b) => EqualsVector2RemainderMethod(Scalar.NegativeInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector2RemainderMethod(Scalar b) => EqualsVector2RemainderMethod((1.5, 4.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector2RemainderMethod(Scalar b) => EqualsVector2RemainderMethod((1.5, 4.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsVector2RemainderMethod((Scalar, Scalar) a, Scalar b)
    {
        var expected = Vector2.Remainder(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
