namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Equals_Unhandled2_Unhandled2
{
    private static bool Target(Unhandled2 lhs, Unhandled2 rhs) => Unhandled2.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Unhandled2 lhs) => EqualsInstanceMethod(lhs, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Unhandled2 rhs) => EqualsInstanceMethod(Unhandled2.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Unhandled2 lhs) => EqualsInstanceMethod(lhs, Scalar.NaN * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Unhandled2 rhs) => EqualsInstanceMethod(Scalar.NaN * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Unhandled2 lhs) => EqualsInstanceMethod(lhs, Scalar.PositiveInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Unhandled2 rhs) => EqualsInstanceMethod(Scalar.PositiveInfinity * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Unhandled2 lhs) => EqualsInstanceMethod(lhs, Scalar.NegativeInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Unhandled2 rhs) => EqualsInstanceMethod(Scalar.NegativeInfinity * new Unhandled2(1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Unhandled2 lhs) => EqualsInstanceMethod(lhs, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Unhandled2 rhs) => EqualsInstanceMethod(new(1.5, 4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Unhandled2 lhs) => EqualsInstanceMethod(lhs, new(-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Unhandled2 rhs) => EqualsInstanceMethod(new(-1.5, -4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled2s_EqualsInstanceMethod(Unhandled2 vector) => EqualsInstanceMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled2 lhs, Unhandled2 rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
