namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_LessThanOrEqual
{
    private static bool Target(Scalar lhs, Scalar rhs) => lhs <= rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsDoubleLessThanOrEqual(Scalar lhs) => EqualsDoubleLessThanOrEqual(lhs, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsDoubleLessThanOrEqual(Scalar rhs) => EqualsDoubleLessThanOrEqual(Scalar.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsDoubleLessThanOrEqual(Scalar lhs) => EqualsDoubleLessThanOrEqual(lhs, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsDoubleLessThanOrEqual(Scalar rhs) => EqualsDoubleLessThanOrEqual(Scalar.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsDoubleLessThanOrEqual(Scalar lhs) => EqualsDoubleLessThanOrEqual(lhs, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsDoubleLessThanOrEqual(Scalar rhs) => EqualsDoubleLessThanOrEqual(Scalar.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsDoubleLessThanOrEqual(Scalar lhs) => EqualsDoubleLessThanOrEqual(lhs, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsDoubleLessThanOrEqual(Scalar rhs) => EqualsDoubleLessThanOrEqual(Scalar.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsDoubleLessThanOrEqual(Scalar lhs) => EqualsDoubleLessThanOrEqual(lhs, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsDoubleLessThanOrEqual(Scalar rhs) => EqualsDoubleLessThanOrEqual(1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsDoubleLessThanOrEqual(Scalar lhs) => EqualsDoubleLessThanOrEqual(lhs, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsDoubleLessThanOrEqual(Scalar rhs) => EqualsDoubleLessThanOrEqual(-1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalars_EqualsDoubleLessThanOrEqual(Scalar scalar) => EqualsDoubleLessThanOrEqual(scalar, scalar);

    [AssertionMethod]
    private static void EqualsDoubleLessThanOrEqual(Scalar lhs, Scalar rhs)
    {
        var expected = lhs.ToDouble() <= rhs.ToDouble();
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
