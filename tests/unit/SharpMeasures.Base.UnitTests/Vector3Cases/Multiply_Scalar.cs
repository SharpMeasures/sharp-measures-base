namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Multiply_Scalar
{
    private static Vector3 Target(Vector3 vector, Scalar factor) => vector.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfComponents(Vector3 vector) => EqualsMultiplicationOfComponents(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfComponents(Vector3 vector) => EqualsMultiplicationOfComponents(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfComponents(Vector3 vector) => EqualsMultiplicationOfComponents(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfComponents(Vector3 vector) => EqualsMultiplicationOfComponents(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfComponents(Vector3 vector) => EqualsMultiplicationOfComponents(vector, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfComponents(Vector3 vector) => EqualsMultiplicationOfComponents(vector, -1.5);

    [AssertionMethod]
    private static void EqualsMultiplicationOfComponents(Vector3 vector, Scalar factor)
    {
        Vector3 expected = (vector.X * factor, vector.Y * factor, vector.Z * factor);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
