namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Subtract_Vector2_Vector2
{
    private static Vector2 Target(Vector2 a, Vector2 b) => Vector2.Subtract(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsInstanceMethod(Vector2 b) => EqualsInstanceMethod(Vector2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsInstanceMethod(Vector2 b) => EqualsInstanceMethod(Scalar.NaN * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsInstanceMethod(Vector2 b) => EqualsInstanceMethod(Scalar.PositiveInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsInstanceMethod(Vector2 b) => EqualsInstanceMethod(Scalar.NegativeInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsInstanceMethod(Vector2 b) => EqualsInstanceMethod((1.5, 4.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsInstanceMethod(Vector2 a) => EqualsInstanceMethod(a, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsInstanceMethod(Vector2 b) => EqualsInstanceMethod((-1.5, -4.5), b);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector2 a, Vector2 b)
    {
        var expected = a.Subtract(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
