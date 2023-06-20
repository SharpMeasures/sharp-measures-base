namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Vector2 lhs, Vector2 rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Vector2 lhs) => EqualsEqualsMethod(lhs, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Vector2 rhs) => EqualsEqualsMethod(Vector2.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Vector2 lhs) => EqualsEqualsMethod(lhs, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Vector2 rhs) => EqualsEqualsMethod(Scalar.NaN * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Vector2 lhs) => EqualsEqualsMethod(lhs, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Vector2 rhs) => EqualsEqualsMethod(Scalar.PositiveInfinity * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Vector2 lhs) => EqualsEqualsMethod(lhs, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Vector2 rhs) => EqualsEqualsMethod(Scalar.NegativeInfinity * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Vector2 lhs) => EqualsEqualsMethod(lhs, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Vector2 rhs) => EqualsEqualsMethod((1.5, 4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Vector2 lhs) => EqualsEqualsMethod(lhs, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Vector2 rhs) => EqualsEqualsMethod((-1.5, -4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector2s_EqualsEqualsMethod(Vector2 vector) => EqualsEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Vector2 lhs, Vector2 rhs)
    {
        var expected = Vector2.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
