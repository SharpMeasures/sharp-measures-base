namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Dot_Vector4_Vector4
{
    private static Scalar Target(Vector4 a, Vector4 b) => Vector4.Dot(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsInstanceMethod(Vector4 b) => EqualsInstanceMethod(Vector4.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsInstanceMethod(Vector4 b) => EqualsInstanceMethod(Scalar.NaN * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsInstanceMethod(Vector4 b) => EqualsInstanceMethod(Scalar.PositiveInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsInstanceMethod(Vector4 b) => EqualsInstanceMethod(Scalar.NegativeInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsInstanceMethod(Vector4 b) => EqualsInstanceMethod((1.5, 4.5, 7.5, 10.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsInstanceMethod(Vector4 a) => EqualsInstanceMethod(a, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsInstanceMethod(Vector4 b) => EqualsInstanceMethod((-1.5, -4.5, -7.5, -10.5), b);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector4 a, Vector4 b)
    {
        var expected = a.Dot(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
