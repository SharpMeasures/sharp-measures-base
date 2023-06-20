namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Multiply_Scalar
{
    private static Vector4 Target(Vector4 vector, Scalar factor) => vector.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, -1.5);

    [AssertionMethod]
    private static void EqualsMultiplicationOfComponents(Vector4 vector, Scalar factor)
    {
        Vector4 expected = (vector.X * factor, vector.Y * factor, vector.Z * factor, vector.W * factor);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
