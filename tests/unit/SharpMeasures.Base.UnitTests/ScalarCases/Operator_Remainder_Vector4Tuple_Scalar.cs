namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Remainder_Vector4Tuple_Scalar
{
    private static Vector4 Target((Scalar, Scalar, Scalar, Scalar) a, Scalar b) => a % b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector4RemainderMethod(Scalar b) => EqualsVector4RemainderMethod(Vector4.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector4RemainderMethod(Scalar b) => EqualsVector4RemainderMethod(Scalar.NaN * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector4RemainderMethod(Scalar b) => EqualsVector4RemainderMethod(Scalar.PositiveInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector4RemainderMethod(Scalar b) => EqualsVector4RemainderMethod(Scalar.NegativeInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector4RemainderMethod(Scalar b) => EqualsVector4RemainderMethod((1.5, 4.5, 7.5, 10.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector4RemainderMethod(Scalar b) => EqualsVector4RemainderMethod((1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsVector4RemainderMethod((Scalar, Scalar, Scalar, Scalar) a, Scalar b)
    {
        var expected = Vector4.Remainder(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
