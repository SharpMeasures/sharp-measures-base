namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_GreaterThan
{
    private static bool Target(Scalar lhs, Scalar rhs) => lhs > rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsDoubleGreaterThan(Scalar lhs) => EqualsDoubleGreaterThan(lhs, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsDoubleGreaterThan(Scalar rhs) => EqualsDoubleGreaterThan(Scalar.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsDoubleGreaterThan(Scalar lhs) => EqualsDoubleGreaterThan(lhs, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsDoubleGreaterThan(Scalar rhs) => EqualsDoubleGreaterThan(Scalar.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsDoubleGreaterThan(Scalar lhs) => EqualsDoubleGreaterThan(lhs, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsDoubleGreaterThan(Scalar rhs) => EqualsDoubleGreaterThan(Scalar.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsDoubleGreaterThan(Scalar lhs) => EqualsDoubleGreaterThan(lhs, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsDoubleGreaterThan(Scalar rhs) => EqualsDoubleGreaterThan(Scalar.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsDoubleGreaterThan(Scalar lhs) => EqualsDoubleGreaterThan(lhs, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsDoubleGreaterThan(Scalar rhs) => EqualsDoubleGreaterThan(1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsDoubleGreaterThan(Scalar lhs) => EqualsDoubleGreaterThan(lhs, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsDoubleGreaterThan(Scalar rhs) => EqualsDoubleGreaterThan(-1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalars_EqualsDoubleGreaterThan(Scalar scalar) => EqualsDoubleGreaterThan(scalar, scalar);

    [AssertionMethod]
    private static void EqualsDoubleGreaterThan(Scalar lhs, Scalar rhs)
    {
        var expected = lhs.ToDouble() > rhs.ToDouble();
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
