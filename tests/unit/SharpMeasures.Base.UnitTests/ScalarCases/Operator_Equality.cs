namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Scalar lhs, Scalar rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Scalar lhs) => EqualsEqualsMethod(lhs, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Scalar rhs) => EqualsEqualsMethod(Scalar.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Scalar lhs) => EqualsEqualsMethod(lhs, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Scalar rhs) => EqualsEqualsMethod(Scalar.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Scalar lhs) => EqualsEqualsMethod(lhs, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Scalar rhs) => EqualsEqualsMethod(Scalar.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Scalar lhs) => EqualsEqualsMethod(lhs, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Scalar rhs) => EqualsEqualsMethod(Scalar.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Scalar lhs) => EqualsEqualsMethod(lhs, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Scalar rhs) => EqualsEqualsMethod(1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Scalar lhs) => EqualsEqualsMethod(lhs, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Scalar rhs) => EqualsEqualsMethod(-1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalars_EqualsEqualsMethod(Scalar scalar) => EqualsEqualsMethod(scalar, scalar);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Scalar lhs, Scalar rhs)
    {
        var expected = Scalar.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
