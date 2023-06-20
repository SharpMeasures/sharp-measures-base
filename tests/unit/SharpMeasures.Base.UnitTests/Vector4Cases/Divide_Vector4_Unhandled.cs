namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Divide_Vector4_Unhandled
{
    private static Unhandled4 Target(Vector4 a, Unhandled b) => Vector4.Divide(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, new(-1.5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector4 a, Unhandled b)
    {
        var expected = a.DivideBy(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
