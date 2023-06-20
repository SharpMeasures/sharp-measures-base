namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Vector3Tuple
{
    private static Vector3 Target(Scalar a, (Scalar, Scalar, Scalar) b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector3MultiplyMethod(Scalar a) => EqualsVector3MultiplyMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector3MultiplyMethod(Scalar a) => EqualsVector3MultiplyMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector3MultiplyMethod(Scalar a) => EqualsVector3MultiplyMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector3MultiplyMethod(Scalar a) => EqualsVector3MultiplyMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector3MultiplyMethod(Scalar a) => EqualsVector3MultiplyMethod(a, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector3MultiplyMethod(Scalar a) => EqualsVector3MultiplyMethod(a, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsVector3MultiplyMethod(Scalar a, (Scalar, Scalar, Scalar) b)
    {
        var expected = Vector3.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
