namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Unhandled4 lhs, Unhandled4 rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Unhandled4 lhs) => EqualsNegationOfEqualsMethod(lhs, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Unhandled4 rhs) => EqualsNegationOfEqualsMethod(Unhandled4.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Unhandled4 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NaN * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Unhandled4 rhs) => EqualsNegationOfEqualsMethod(Scalar.NaN * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled4 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled4 rhs) => EqualsNegationOfEqualsMethod(Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled4 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled4 rhs) => EqualsNegationOfEqualsMethod(Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Unhandled4 lhs) => EqualsNegationOfEqualsMethod(lhs, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Unhandled4 rhs) => EqualsNegationOfEqualsMethod(new(1.5, 4.5, 7.5, 10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Unhandled4 lhs) => EqualsNegationOfEqualsMethod(lhs, new(-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Unhandled4 rhs) => EqualsNegationOfEqualsMethod(new(-1.5, -4.5, -7.5, -10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled4s_EqualsNegationOfEqualsMethod(Unhandled4 vector) => EqualsNegationOfEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Unhandled4 lhs, Unhandled4 rhs)
    {
        var expected = Unhandled4.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
