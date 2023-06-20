namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Equals_Vector2_Vector2
{
    private static bool Target(Vector2 lhs, Vector2 rhs) => Vector2.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Vector2 lhs) => EqualsInstanceMethod(lhs, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Vector2 rhs) => EqualsInstanceMethod(Vector2.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Vector2 lhs) => EqualsInstanceMethod(lhs, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Vector2 rhs) => EqualsInstanceMethod(Scalar.NaN * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Vector2 lhs) => EqualsInstanceMethod(lhs, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Vector2 rhs) => EqualsInstanceMethod(Scalar.PositiveInfinity * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Vector2 lhs) => EqualsInstanceMethod(lhs, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Vector2 rhs) => EqualsInstanceMethod(Scalar.NegativeInfinity * Vector2.Ones, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Vector2 lhs) => EqualsInstanceMethod(lhs, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Vector2 rhs) => EqualsInstanceMethod((1.5, 4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Vector2 lhs) => EqualsInstanceMethod(lhs, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Vector2 rhs) => EqualsInstanceMethod((-1.5, -4.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector2s_EqualsInstanceMethod(Vector2 vector) => EqualsInstanceMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector2 lhs, Vector2 rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
