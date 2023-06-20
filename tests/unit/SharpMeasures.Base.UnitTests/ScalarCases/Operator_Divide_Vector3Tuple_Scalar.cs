namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Divide_Vector3Tuple_Scalar
{
    private static Vector3 Target((Scalar, Scalar, Scalar) a, Scalar b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector3DivideMethod(Scalar b) => EqualsVector3DivideMethod(Vector3.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector3DivideMethod(Scalar b) => EqualsVector3DivideMethod(Scalar.NaN * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector3DivideMethod(Scalar b) => EqualsVector3DivideMethod(Scalar.PositiveInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector3DivideMethod(Scalar b) => EqualsVector3DivideMethod(Scalar.NegativeInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector3DivideMethod(Scalar b) => EqualsVector3DivideMethod((1.5, 4.5, 7.5) * Scalar.One, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector3DivideMethod(Scalar b) => EqualsVector3DivideMethod((1.5, 4.5, 7.5) * Scalar.NegativeOne, b);

    [AssertionMethod]
    private static void EqualsVector3DivideMethod((Scalar, Scalar, Scalar) a, Scalar b)
    {
        var expected = Vector3.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
