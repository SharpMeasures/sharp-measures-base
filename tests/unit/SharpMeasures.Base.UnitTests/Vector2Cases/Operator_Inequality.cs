namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(Vector2 lhs, Vector2 rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(Vector2 lhs) => EqualsNegationOfEqualsMethod(lhs, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(Vector2 rhs) => EqualsNegationOfEqualsMethod(Vector2.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsNegationOfEqualsMethod(Vector2 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsNegationOfEqualsMethod(Vector2 rhs) => EqualsNegationOfEqualsMethod(Scalar.NaN * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Vector2 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsNegationOfEqualsMethod(Vector2 rhs) => EqualsNegationOfEqualsMethod(Scalar.PositiveInfinity * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Vector2 lhs) => EqualsNegationOfEqualsMethod(lhs, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsNegationOfEqualsMethod(Vector2 rhs) => EqualsNegationOfEqualsMethod(Scalar.NegativeInfinity * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsNegationOfEqualsMethod(Vector2 lhs) => EqualsNegationOfEqualsMethod(lhs, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsNegationOfEqualsMethod(Vector2 rhs) => EqualsNegationOfEqualsMethod((1.5, 4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsNegationOfEqualsMethod(Vector2 lhs) => EqualsNegationOfEqualsMethod(lhs, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsNegationOfEqualsMethod(Vector2 rhs) => EqualsNegationOfEqualsMethod((-1.5, -4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector2s_EqualsNegationOfEqualsMethod(Vector2 vector) => EqualsNegationOfEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(Vector2 lhs, Vector2 rhs)
    {
        var expected = Vector2.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
