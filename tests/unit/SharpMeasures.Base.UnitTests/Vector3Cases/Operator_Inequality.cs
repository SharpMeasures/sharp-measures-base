namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Vector3 lhs, Vector3 rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Vector3 lhs) => EqualsNegationOfEqualsMethod(lhs, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Vector3 rhs) => EqualsNegationOfEqualsMethod(Vector3.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Vector3 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Vector3 rhs) => EqualsNegationOfEqualsMethod(Scalar.NaN * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Vector3 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Vector3 rhs) => EqualsNegationOfEqualsMethod(Scalar.PositiveInfinity * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Vector3 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Vector3 rhs) => EqualsNegationOfEqualsMethod(Scalar.NegativeInfinity * Vector3.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Vector3 lhs) => EqualsNegationOfEqualsMethod(lhs, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Vector3 rhs) => EqualsNegationOfEqualsMethod((1.5, 4.5, 7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Vector3 lhs) => EqualsNegationOfEqualsMethod(lhs, (-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Vector3 rhs) => EqualsNegationOfEqualsMethod((-1.5, -4.5, -7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector3s_EqualsNegationOfEqualsMethod(Vector3 vector) => EqualsNegationOfEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Vector3 lhs, Vector3 rhs)
    {
        var expected = Vector3.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
