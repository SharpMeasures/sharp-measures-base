namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Vector4Tuple
{
    private static Vector4 Target(Scalar a, (Scalar, Scalar, Scalar, Scalar) b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector4MultiplyMethod(Scalar a) => EqualsVector4MultiplyMethod(a, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector4MultiplyMethod(Scalar a) => EqualsVector4MultiplyMethod(a, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector4MultiplyMethod(Scalar a) => EqualsVector4MultiplyMethod(a, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector4MultiplyMethod(Scalar a) => EqualsVector4MultiplyMethod(a, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector4MultiplyMethod(Scalar a) => EqualsVector4MultiplyMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector4MultiplyMethod(Scalar a) => EqualsVector4MultiplyMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsVector4MultiplyMethod(Scalar a, (Scalar, Scalar, Scalar, Scalar) b)
    {
        var expected = Vector4.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
