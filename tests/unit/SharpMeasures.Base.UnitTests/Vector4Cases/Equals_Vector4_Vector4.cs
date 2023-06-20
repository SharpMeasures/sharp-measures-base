namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Equals_Vector4_Vector4
{
    private static bool Target(Vector4 lhs, Vector4 rhs) => Vector4.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Vector4 lhs) => EqualsInstanceMethod(lhs, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Vector4 rhs) => EqualsInstanceMethod(Vector4.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Vector4 lhs) => EqualsInstanceMethod(lhs, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Vector4 rhs) => EqualsInstanceMethod(Scalar.NaN * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Vector4 lhs) => EqualsInstanceMethod(lhs, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Vector4 rhs) => EqualsInstanceMethod(Scalar.PositiveInfinity * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Vector4 lhs) => EqualsInstanceMethod(lhs, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Vector4 rhs) => EqualsInstanceMethod(Scalar.NegativeInfinity * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Vector4 lhs) => EqualsInstanceMethod(lhs, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Vector4 rhs) => EqualsInstanceMethod((1.5, 4.5, 7.5, 10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Vector4 lhs) => EqualsInstanceMethod(lhs, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Vector4 rhs) => EqualsInstanceMethod((-1.5, -4.5, -7.5, -10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector4s_EqualsInstanceMethod(Vector4 vector) => EqualsInstanceMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector4 lhs, Vector4 rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
