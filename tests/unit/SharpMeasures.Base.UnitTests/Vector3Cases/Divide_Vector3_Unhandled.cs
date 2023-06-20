namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Divide_Vector3_Unhandled
{
    private static Unhandled3 Target(Vector3 a, Unhandled b) => Vector3.Divide(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, new(-1.5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector3 a, Unhandled b)
    {
        var expected = a.DivideBy(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
