namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Unhandled2 lhs, Unhandled2 rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Unhandled2 lhs) => EqualsNegationOfEqualsMethod(lhs, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Unhandled2 rhs) => EqualsNegationOfEqualsMethod(Unhandled2.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Unhandled2 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NaN * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Unhandled2 rhs) => EqualsNegationOfEqualsMethod(Scalar.NaN * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled2 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.PositiveInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled2 rhs) => EqualsNegationOfEqualsMethod(Scalar.PositiveInfinity * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled2 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NegativeInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled2 rhs) => EqualsNegationOfEqualsMethod(Scalar.NegativeInfinity * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Unhandled2 lhs) => EqualsNegationOfEqualsMethod(lhs, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Unhandled2 rhs) => EqualsNegationOfEqualsMethod(new(1.5, 4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Unhandled2 lhs) => EqualsNegationOfEqualsMethod(lhs, new(-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Unhandled2 rhs) => EqualsNegationOfEqualsMethod(new(-1.5, -4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled2s_EqualsNegationOfEqualsMethod(Unhandled2 vector) => EqualsNegationOfEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Unhandled2 lhs, Unhandled2 rhs)
    {
        var expected = Unhandled2.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
