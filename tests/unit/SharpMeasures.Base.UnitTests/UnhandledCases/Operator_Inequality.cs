namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Unhandled lhs, Unhandled rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Unhandled lhs) => EqualsNegationOfEqualsMethod(lhs, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Unhandled rhs) => EqualsNegationOfEqualsMethod(Unhandled.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Unhandled lhs) => EqualsNegationOfEqualsMethod(lhs, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Unhandled rhs) => EqualsNegationOfEqualsMethod(Unhandled.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled lhs) => EqualsNegationOfEqualsMethod(lhs, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Unhandled rhs) => EqualsNegationOfEqualsMethod(Unhandled.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled lhs) => EqualsNegationOfEqualsMethod(lhs, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Unhandled rhs) => EqualsNegationOfEqualsMethod(Unhandled.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Unhandled lhs) => EqualsNegationOfEqualsMethod(lhs, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Unhandled rhs) => EqualsNegationOfEqualsMethod(new(1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Unhandled lhs) => EqualsNegationOfEqualsMethod(lhs, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Unhandled rhs) => EqualsNegationOfEqualsMethod(new(-1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandleds_EqualsNegationOfEqualsMethod(Unhandled scalar) => EqualsNegationOfEqualsMethod(scalar, scalar);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Unhandled lhs, Unhandled rhs)
    {
        var expected = Unhandled.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
