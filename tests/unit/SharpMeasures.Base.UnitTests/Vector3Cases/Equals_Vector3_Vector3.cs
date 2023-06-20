namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Equals_Vector3_Vector3
{
    private static bool Target(Vector3 lhs, Vector3 rhs) => Vector3.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Vector3 lhs) => EqualsInstanceMethod(lhs, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Vector3 rhs) => EqualsInstanceMethod(Vector3.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Vector3 lhs) => EqualsInstanceMethod(lhs, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Vector3 rhs) => EqualsInstanceMethod(Scalar.NaN * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Vector3 lhs) => EqualsInstanceMethod(lhs, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Vector3 rhs) => EqualsInstanceMethod(Scalar.PositiveInfinity * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Vector3 lhs) => EqualsInstanceMethod(lhs, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Vector3 rhs) => EqualsInstanceMethod(Scalar.NegativeInfinity * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Vector3 lhs) => EqualsInstanceMethod(lhs, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Vector3 rhs) => EqualsInstanceMethod((1.5, 4.5, 7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Vector3 lhs) => EqualsInstanceMethod(lhs, (-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Vector3 rhs) => EqualsInstanceMethod((-1.5, -4.5, -7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector3s_EqualsInstanceMethod(Vector3 vector) => EqualsInstanceMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector3 lhs, Vector3 rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
