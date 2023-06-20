namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Divide_Vector2_Scalar
{
    private static Vector2 Target(Vector2 a, Scalar b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Vector2 a) => EqualsMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Vector2 a) => EqualsMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Vector2 a) => EqualsMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Vector2 a) => EqualsMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Vector2 a) => EqualsMethod(a, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Vector2 a) => EqualsMethod(a, -1.5);

    [AssertionMethod]
    private static void EqualsMethod(Vector2 a, Scalar b)
    {
        var expected = Vector2.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
