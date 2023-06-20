namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_LessThan
{
    private static bool Target(Scalar lhs, Scalar rhs) => lhs < rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsDoubleLessThan(Scalar lhs) => EqualsDoubleLessThan(lhs, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsDoubleLessThan(Scalar rhs) => EqualsDoubleLessThan(Scalar.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsDoubleLessThan(Scalar lhs) => EqualsDoubleLessThan(lhs, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsDoubleLessThan(Scalar rhs) => EqualsDoubleLessThan(Scalar.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsDoubleLessThan(Scalar lhs) => EqualsDoubleLessThan(lhs, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsDoubleLessThan(Scalar rhs) => EqualsDoubleLessThan(Scalar.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsDoubleLessThan(Scalar lhs) => EqualsDoubleLessThan(lhs, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsDoubleLessThan(Scalar rhs) => EqualsDoubleLessThan(Scalar.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsDoubleLessThan(Scalar lhs) => EqualsDoubleLessThan(lhs, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsDoubleLessThan(Scalar rhs) => EqualsDoubleLessThan(1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsDoubleLessThan(Scalar lhs) => EqualsDoubleLessThan(lhs, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsDoubleLessThan(Scalar rhs) => EqualsDoubleLessThan(-1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalars_EqualsDoubleLessThan(Scalar scalar) => EqualsDoubleLessThan(scalar, scalar);

    [AssertionMethod]
    private static void EqualsDoubleLessThan(Scalar lhs, Scalar rhs)
    {
        var expected = lhs.ToDouble() < rhs.ToDouble();
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
