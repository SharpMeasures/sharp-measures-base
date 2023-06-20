namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Unhandled4 lhs, Unhandled4 rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Unhandled4 lhs) => EqualsEqualsMethod(lhs, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Unhandled4 rhs) => EqualsEqualsMethod(Unhandled4.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Unhandled4 lhs) => EqualsEqualsMethod(lhs, Scalar.NaN * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Unhandled4 rhs) => EqualsEqualsMethod(Scalar.NaN * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Unhandled4 lhs) => EqualsEqualsMethod(lhs, Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Unhandled4 rhs) => EqualsEqualsMethod(Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Unhandled4 lhs) => EqualsEqualsMethod(lhs, Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Unhandled4 rhs) => EqualsEqualsMethod(Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Unhandled4 lhs) => EqualsEqualsMethod(lhs, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Unhandled4 rhs) => EqualsEqualsMethod(new(1.5, 4.5, 7.5, 10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Unhandled4 lhs) => EqualsEqualsMethod(lhs, new(-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Unhandled4 rhs) => EqualsEqualsMethod(new(-1.5, -4.5, -7.5, -10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled4s_EqualsEqualsMethod(Unhandled4 vector) => EqualsEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Unhandled4 lhs, Unhandled4 rhs)
    {
        var expected = Unhandled4.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
