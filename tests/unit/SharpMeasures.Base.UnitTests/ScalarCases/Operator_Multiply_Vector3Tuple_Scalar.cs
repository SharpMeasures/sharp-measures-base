namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Multiply_Vector3Tuple_Scalar
{
    private static Vector3 Target((Scalar, Scalar, Scalar) a, Scalar b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector3MultiplyMethod(Scalar b) => EqualsVector3MultiplyMethod(Vector3.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector3MultiplyMethod(Scalar b) => EqualsVector3MultiplyMethod(Scalar.NaN * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector3MultiplyMethod(Scalar b) => EqualsVector3MultiplyMethod(Scalar.PositiveInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector3MultiplyMethod(Scalar b) => EqualsVector3MultiplyMethod(Scalar.NegativeInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector3MultiplyMethod(Scalar b) => EqualsVector3MultiplyMethod((1.5, 4.5, 7.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector3MultiplyMethod(Scalar b) => EqualsVector3MultiplyMethod((1.5, 4.5, 7.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsVector3MultiplyMethod((Scalar, Scalar, Scalar) a, Scalar b)
    {
        var expected = Vector3.Multiply(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
