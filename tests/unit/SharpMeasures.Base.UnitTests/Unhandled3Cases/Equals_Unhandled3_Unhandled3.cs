namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Equals_Unhandled3_Unhandled3
{
    private static bool Target(Unhandled3 lhs, Unhandled3 rhs) => Unhandled3.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Unhandled3 lhs) => EqualsInstanceMethod(lhs, Unhandled3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Unhandled3 rhs) => EqualsInstanceMethod(Unhandled3.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Unhandled3 lhs) => EqualsInstanceMethod(lhs, Scalar.NaN * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Unhandled3 rhs) => EqualsInstanceMethod(Scalar.NaN * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Unhandled3 lhs) => EqualsInstanceMethod(lhs, Scalar.PositiveInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Unhandled3 rhs) => EqualsInstanceMethod(Scalar.PositiveInfinity * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Unhandled3 lhs) => EqualsInstanceMethod(lhs, Scalar.NegativeInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Unhandled3 rhs) => EqualsInstanceMethod(Scalar.NegativeInfinity * new Unhandled3(1, 1, 1), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Unhandled3 lhs) => EqualsInstanceMethod(lhs, new(1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Unhandled3 rhs) => EqualsInstanceMethod(new(1.5, 4.5, 7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Unhandled3 lhs) => EqualsInstanceMethod(lhs, new(-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Unhandled3 rhs) => EqualsInstanceMethod(new(-1.5, -4.5, -7.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled3s_EqualsInstanceMethod(Unhandled3 vector) => EqualsInstanceMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled3 lhs, Unhandled3 rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
