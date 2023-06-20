namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Unhandled3 lhs, Unhandled3 rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Unhandled3 lhs) => EqualsNegationOfEqualsMethod(lhs, Unhandled3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Unhandled3 rhs) => EqualsNegationOfEqualsMethod(Unhandled3.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Unhandled3 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NaN * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Unhandled3 rhs) => EqualsNegationOfEqualsMethod(Scalar.NaN * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled3 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.PositiveInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled3 rhs) => EqualsNegationOfEqualsMethod(Scalar.PositiveInfinity * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled3 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NegativeInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled3 rhs) => EqualsNegationOfEqualsMethod(Scalar.NegativeInfinity * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Unhandled3 lhs) => EqualsNegationOfEqualsMethod(lhs, new(1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Unhandled3 rhs) => EqualsNegationOfEqualsMethod(new(1.5, 4.5, 7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Unhandled3 lhs) => EqualsNegationOfEqualsMethod(lhs, new(-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Unhandled3 rhs) => EqualsNegationOfEqualsMethod(new(-1.5, -4.5, -7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled3s_EqualsNegationOfEqualsMethod(Unhandled3 vector) => EqualsNegationOfEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Unhandled3 lhs, Unhandled3 rhs)
    {
        var expected = Unhandled3.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
