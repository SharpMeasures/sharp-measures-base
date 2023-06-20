namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Vector4 lhs, Vector4 rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Vector4 lhs) => EqualsNegationOfEqualsMethod(lhs, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Vector4 rhs) => EqualsNegationOfEqualsMethod(Vector4.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Vector4 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Vector4 rhs) => EqualsNegationOfEqualsMethod(Scalar.NaN * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Vector4 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Vector4 rhs) => EqualsNegationOfEqualsMethod(Scalar.PositiveInfinity * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Vector4 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Vector4 rhs) => EqualsNegationOfEqualsMethod(Scalar.NegativeInfinity * Vector4.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Vector4 lhs) => EqualsNegationOfEqualsMethod(lhs, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Vector4 rhs) => EqualsNegationOfEqualsMethod((1.5, 4.5, 7.5, 10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Vector4 lhs) => EqualsNegationOfEqualsMethod(lhs, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Vector4 rhs) => EqualsNegationOfEqualsMethod((-1.5, -4.5, -7.5, -10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector4s_EqualsNegationOfEqualsMethod(Vector4 vector) => EqualsNegationOfEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Vector4 lhs, Vector4 rhs)
    {
        var expected = Vector4.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
