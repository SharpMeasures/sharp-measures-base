namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Remainder_Vector2_Scalar
{
    private static Vector2 Target(Vector2 a, Scalar b) => Vector2.Remainder(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, -1.5);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector2 a, Scalar b)
    {
        var expected = a.Remainder(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
