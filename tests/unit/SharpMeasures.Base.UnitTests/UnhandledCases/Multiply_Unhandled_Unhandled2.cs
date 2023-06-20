namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Unhandled_Unhandled2
{
    private static Unhandled2 Target(Unhandled a, Unhandled2 b) => Unhandled.Multiply(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Unhandled.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Unhandled.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, Unhandled.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled a) => EqualsInstanceMethod(a, new(-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled a, Unhandled2 b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
