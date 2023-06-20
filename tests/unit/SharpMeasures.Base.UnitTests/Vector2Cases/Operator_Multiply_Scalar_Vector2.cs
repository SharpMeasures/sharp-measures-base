namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Vector2
{
    private static Vector2 Target(Scalar a, Vector2 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Vector2 b) => EqualsMethod(Scalar.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Vector2 b) => EqualsMethod(Scalar.NaN, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Vector2 b) => EqualsMethod(Scalar.PositiveInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Vector2 b) => EqualsMethod(Scalar.NegativeInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Vector2 b) => EqualsMethod(1.5, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Vector2 b) => EqualsMethod(-1.5, b);

    [AssertionMethod]
    private static void EqualsMethod(Scalar a, Vector2 b)
    {
        var expected = Vector2.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
