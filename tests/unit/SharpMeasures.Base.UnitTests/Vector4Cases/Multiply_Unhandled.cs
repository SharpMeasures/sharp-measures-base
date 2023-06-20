namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Multiply_Unhandled
{
    private static Unhandled4 Target(Vector4 vector, Unhandled factor) => vector.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfComponents(Vector4 vector) => EqualsMultiplicationOfComponents(vector, new(-1.5));

    [AssertionMethod]
    private static void EqualsMultiplicationOfComponents(Vector4 vector, Unhandled factor)
    {
        Unhandled4 expected = (vector.X * factor, vector.Y * factor, vector.Z * factor, vector.W * factor);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
