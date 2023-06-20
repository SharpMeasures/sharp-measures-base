namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Multiply_Vector4_Scalar
{
    private static Vector4 Target(Vector4 a, Scalar b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Vector4 a) => EqualsMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Vector4 a) => EqualsMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Vector4 a) => EqualsMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Vector4 a) => EqualsMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Vector4 a) => EqualsMethod(a, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Vector4 a) => EqualsMethod(a, -1.5);

    [AssertionMethod]
    private static void EqualsMethod(Vector4 a, Scalar b)
    {
        var expected = Vector4.Multiply(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
