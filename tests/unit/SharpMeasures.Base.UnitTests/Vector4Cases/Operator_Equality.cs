namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Vector4 lhs, Vector4 rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Vector4 lhs) => EqualsEqualsMethod(lhs, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Vector4 rhs) => EqualsEqualsMethod(Vector4.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Vector4 lhs) => EqualsEqualsMethod(lhs, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Vector4 rhs) => EqualsEqualsMethod(Scalar.NaN * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Vector4 lhs) => EqualsEqualsMethod(lhs, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Vector4 rhs) => EqualsEqualsMethod(Scalar.PositiveInfinity * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Vector4 lhs) => EqualsEqualsMethod(lhs, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Vector4 rhs) => EqualsEqualsMethod(Scalar.NegativeInfinity * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Vector4 lhs) => EqualsEqualsMethod(lhs, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Vector4 rhs) => EqualsEqualsMethod((1.5, 4.5, 7.5, 10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Vector4 lhs) => EqualsEqualsMethod(lhs, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Vector4 rhs) => EqualsEqualsMethod((-1.5, -4.5, -7.5, -10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector4s_EqualsEqualsMethod(Vector4 vector) => EqualsEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Vector4 lhs, Vector4 rhs)
    {
        var expected = Vector4.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
