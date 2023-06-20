namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Scalar lhs, Scalar rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Scalar lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Scalar rhs) => EqualsNegationOfEqualsMethod(Scalar.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Scalar lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Scalar rhs) => EqualsNegationOfEqualsMethod(Scalar.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Scalar lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Scalar rhs) => EqualsNegationOfEqualsMethod(Scalar.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Scalar lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Scalar rhs) => EqualsNegationOfEqualsMethod(Scalar.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Scalar lhs) => EqualsNegationOfEqualsMethod(lhs, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Scalar rhs) => EqualsNegationOfEqualsMethod(1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Scalar lhs) => EqualsNegationOfEqualsMethod(lhs, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Scalar rhs) => EqualsNegationOfEqualsMethod(-1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalars_EqualsNegationOfEqualsMethod(Scalar scalar) => EqualsNegationOfEqualsMethod(scalar, scalar);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Scalar lhs, Scalar rhs)
    {
        var expected = Scalar.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
