namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Vector4
{
    private static Vector4 Target(Scalar a, Vector4 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Vector4 b) => EqualsMethod(Scalar.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Vector4 b) => EqualsMethod(Scalar.NaN, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Vector4 b) => EqualsMethod(Scalar.PositiveInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Vector4 b) => EqualsMethod(Scalar.NegativeInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Vector4 b) => EqualsMethod(1.5, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Vector4 b) => EqualsMethod(-1.5, b);

    [AssertionMethod]
    private static void EqualsMethod(Scalar a, Vector4 b)
    {
        var expected = Vector4.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
