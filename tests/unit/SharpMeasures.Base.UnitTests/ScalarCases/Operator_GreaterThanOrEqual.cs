namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_GreaterThanOrEqual
{
    private static bool Target(Scalar lhs, Scalar rhs) => lhs >= rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsDoubleGreaterThanOrEqual(Scalar lhs) => EqualsDoubleGreaterThanOrEqual(lhs, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsDoubleGreaterThanOrEqual(Scalar rhs) => EqualsDoubleGreaterThanOrEqual(Scalar.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsDoubleGreaterThanOrEqual(Scalar lhs) => EqualsDoubleGreaterThanOrEqual(lhs, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsDoubleGreaterThanOrEqual(Scalar rhs) => EqualsDoubleGreaterThanOrEqual(Scalar.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsDoubleGreaterThanOrEqual(Scalar lhs) => EqualsDoubleGreaterThanOrEqual(lhs, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsDoubleGreaterThanOrEqual(Scalar rhs) => EqualsDoubleGreaterThanOrEqual(Scalar.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsDoubleGreaterThanOrEqual(Scalar lhs) => EqualsDoubleGreaterThanOrEqual(lhs, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsDoubleGreaterThanOrEqual(Scalar rhs) => EqualsDoubleGreaterThanOrEqual(Scalar.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsDoubleGreaterThanOrEqual(Scalar lhs) => EqualsDoubleGreaterThanOrEqual(lhs, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsDoubleGreaterThanOrEqual(Scalar rhs) => EqualsDoubleGreaterThanOrEqual(1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsDoubleGreaterThanOrEqual(Scalar lhs) => EqualsDoubleGreaterThanOrEqual(lhs, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsDoubleGreaterThanOrEqual(Scalar rhs) => EqualsDoubleGreaterThanOrEqual(-1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalars_EqualsDoubleGreaterThanOrEqual(Scalar scalar) => EqualsDoubleGreaterThanOrEqual(scalar, scalar);

    [AssertionMethod]
    private static void EqualsDoubleGreaterThanOrEqual(Scalar lhs, Scalar rhs)
    {
        var expected = lhs.ToDouble() >= rhs.ToDouble();
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
