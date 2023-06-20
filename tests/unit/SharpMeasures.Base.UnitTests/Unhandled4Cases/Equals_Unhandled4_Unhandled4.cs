namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Equals_Unhandled4_Unhandled4
{
    private static bool Target(Unhandled4 lhs, Unhandled4 rhs) => Unhandled4.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Unhandled4 lhs) => EqualsInstanceMethod(lhs, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Unhandled4 rhs) => EqualsInstanceMethod(Unhandled4.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Unhandled4 lhs) => EqualsInstanceMethod(lhs, Scalar.NaN * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Unhandled4 rhs) => EqualsInstanceMethod(Scalar.NaN * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Unhandled4 lhs) => EqualsInstanceMethod(lhs, Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Unhandled4 rhs) => EqualsInstanceMethod(Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Unhandled4 lhs) => EqualsInstanceMethod(lhs, Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Unhandled4 rhs) => EqualsInstanceMethod(Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Unhandled4 lhs) => EqualsInstanceMethod(lhs, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Unhandled4 rhs) => EqualsInstanceMethod(new(1.5, 4.5, 7.5, 10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Unhandled4 lhs) => EqualsInstanceMethod(lhs, new(-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Unhandled4 rhs) => EqualsInstanceMethod(new(-1.5, -4.5, -7.5, -10.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled4s_EqualsInstanceMethod(Unhandled4 vector) => EqualsInstanceMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled4 lhs, Unhandled4 rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
