namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Multiply_Vector2_Unhandled
{
    private static Unhandled2 Target(Vector2 a, Unhandled b) => Vector2.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, new(-1.5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector2 a, Unhandled b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
