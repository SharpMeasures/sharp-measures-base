namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Unhandled2 lhs, Unhandled2 rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Unhandled2 lhs) => EqualsEqualsMethod(lhs, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Unhandled2 rhs) => EqualsEqualsMethod(Unhandled2.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Unhandled2 lhs) => EqualsEqualsMethod(lhs, Scalar.NaN * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Unhandled2 rhs) => EqualsEqualsMethod(Scalar.NaN * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Unhandled2 lhs) => EqualsEqualsMethod(lhs, Scalar.PositiveInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Unhandled2 rhs) => EqualsEqualsMethod(Scalar.PositiveInfinity * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Unhandled2 lhs) => EqualsEqualsMethod(lhs, Scalar.NegativeInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Unhandled2 rhs) => EqualsEqualsMethod(Scalar.NegativeInfinity * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Unhandled2 lhs) => EqualsEqualsMethod(lhs, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Unhandled2 rhs) => EqualsEqualsMethod(new(1.5, 4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Unhandled2 lhs) => EqualsEqualsMethod(lhs, new(-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Unhandled2 rhs) => EqualsEqualsMethod(new(-1.5, -4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled2s_EqualsEqualsMethod(Unhandled2 vector) => EqualsEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Unhandled2 lhs, Unhandled2 rhs)
    {
        var expected = Unhandled2.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
