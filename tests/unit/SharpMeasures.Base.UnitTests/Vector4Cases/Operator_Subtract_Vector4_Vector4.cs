namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Subtract_Vector4_Vector4
{
    private static Vector4 Target(Vector4 a, Vector4 b) => a - b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsMethod(Vector4 a) => EqualsMethod(a, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsMethod(Vector4 b) => EqualsMethod(Vector4.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsMethod(Vector4 a) => EqualsMethod(a, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsMethod(Vector4 b) => EqualsMethod(Scalar.NaN * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsMethod(Vector4 a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsMethod(Vector4 b) => EqualsMethod(Scalar.PositiveInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsMethod(Vector4 a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsMethod(Vector4 b) => EqualsMethod(Scalar.NegativeInfinity * Vector4.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsMethod(Vector4 a) => EqualsMethod(a, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsMethod(Vector4 b) => EqualsMethod((1.5, 4.5, 7.5, 10.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsMethod(Vector4 a) => EqualsMethod(a, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsMethod(Vector4 b) => EqualsMethod((-1.5, -4.5, -7.5, -10.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Vector4 a, Vector4 b)
    {
        var expected = Vector4.Subtract(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
