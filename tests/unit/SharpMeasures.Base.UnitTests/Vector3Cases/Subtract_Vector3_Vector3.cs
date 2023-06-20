namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Subtract_Vector3_Vector3
{
    private static Vector3 Target(Vector3 a, Vector3 b) => Vector3.Subtract(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsInstanceMethod(Vector3 b) => EqualsInstanceMethod(Vector3.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsInstanceMethod(Vector3 b) => EqualsInstanceMethod(Scalar.NaN * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsInstanceMethod(Vector3 b) => EqualsInstanceMethod(Scalar.PositiveInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsInstanceMethod(Vector3 b) => EqualsInstanceMethod(Scalar.NegativeInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsInstanceMethod(Vector3 b) => EqualsInstanceMethod((1.5, 4.5, 7.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, (-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsInstanceMethod(Vector3 b) => EqualsInstanceMethod((-1.5, -4.5, -7.5), b);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector3 a, Vector3 b)
    {
        var expected = a.Subtract(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
