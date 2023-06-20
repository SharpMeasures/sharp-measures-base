namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Equals_Scalar_Scalar
{
    private static bool Target(Scalar lhs, Scalar rhs) => Scalar.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Scalar lhs) => EqualsInstanceMethod(lhs, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Scalar rhs) => EqualsInstanceMethod(Scalar.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Scalar lhs) => EqualsInstanceMethod(lhs, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Scalar rhs) => EqualsInstanceMethod(Scalar.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Scalar lhs) => EqualsInstanceMethod(lhs, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Scalar rhs) => EqualsInstanceMethod(Scalar.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Scalar lhs) => EqualsInstanceMethod(lhs, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Scalar rhs) => EqualsInstanceMethod(Scalar.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Scalar lhs) => EqualsInstanceMethod(lhs, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Scalar rhs) => EqualsInstanceMethod(1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Scalar lhs) => EqualsInstanceMethod(lhs, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Scalar rhs) => EqualsInstanceMethod(-1.5, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalars_EqualsInstanceMethod(Scalar scalar) => EqualsInstanceMethod(scalar, scalar);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Scalar lhs, Scalar rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
