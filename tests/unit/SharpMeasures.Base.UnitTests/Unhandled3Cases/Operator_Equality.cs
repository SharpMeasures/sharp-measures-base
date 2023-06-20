namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Unhandled3 lhs, Unhandled3 rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Unhandled3 lhs) => EqualsEqualsMethod(lhs, Unhandled3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Unhandled3 rhs) => EqualsEqualsMethod(Unhandled3.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Unhandled3 lhs) => EqualsEqualsMethod(lhs, Scalar.NaN * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Unhandled3 rhs) => EqualsEqualsMethod(Scalar.NaN * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Unhandled3 lhs) => EqualsEqualsMethod(lhs, Scalar.PositiveInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Unhandled3 rhs) => EqualsEqualsMethod(Scalar.PositiveInfinity * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Unhandled3 lhs) => EqualsEqualsMethod(lhs, Scalar.NegativeInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Unhandled3 rhs) => EqualsEqualsMethod(Scalar.NegativeInfinity * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Unhandled3 lhs) => EqualsEqualsMethod(lhs, new(1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Unhandled3 rhs) => EqualsEqualsMethod(new(1.5, 4.5, 7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Unhandled3 lhs) => EqualsEqualsMethod(lhs, new(-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Unhandled3 rhs) => EqualsEqualsMethod(new(-1.5, -4.5, -7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled3s_EqualsEqualsMethod(Unhandled3 vector) => EqualsEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Unhandled3 lhs, Unhandled3 rhs)
    {
        var expected = Unhandled3.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
