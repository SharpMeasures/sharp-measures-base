namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Divide_Vector4Tuple_Scalar
{
    private static Vector4 Target((Scalar, Scalar, Scalar, Scalar) a, Scalar b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector4DivideMethod(Scalar b) => EqualsVector4DivideMethod(Vector4.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector4DivideMethod(Scalar b) => EqualsVector4DivideMethod(Scalar.NaN * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector4DivideMethod(Scalar b) => EqualsVector4DivideMethod(Scalar.PositiveInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector4DivideMethod(Scalar b) => EqualsVector4DivideMethod(Scalar.NegativeInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector4DivideMethod(Scalar b) => EqualsVector4DivideMethod((1.5, 4.5, 7.5, 10.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector4DivideMethod(Scalar b) => EqualsVector4DivideMethod((1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsVector4DivideMethod((Scalar, Scalar, Scalar, Scalar) a, Scalar b)
    {
        var expected = Vector4.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
