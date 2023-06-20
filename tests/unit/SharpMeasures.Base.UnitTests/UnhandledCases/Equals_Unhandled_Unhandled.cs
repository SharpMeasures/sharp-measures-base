namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Equals_Unhandled_Unhandled
{
    private static bool Target(Unhandled lhs, Unhandled rhs) => Unhandled.Equals(lhs, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsInstanceMethod(Unhandled lhs) => EqualsInstanceMethod(lhs, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(Unhandled rhs) => EqualsInstanceMethod(Unhandled.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsInstanceMethod(Unhandled lhs) => EqualsInstanceMethod(lhs, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsInstanceMethod(Unhandled rhs) => EqualsInstanceMethod(Unhandled.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsInstanceMethod(Unhandled lhs) => EqualsInstanceMethod(lhs, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsInstanceMethod(Unhandled rhs) => EqualsInstanceMethod(Unhandled.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsInstanceMethod(Unhandled lhs) => EqualsInstanceMethod(lhs, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsInstanceMethod(Unhandled rhs) => EqualsInstanceMethod(Unhandled.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsInstanceMethod(Unhandled lhs) => EqualsInstanceMethod(lhs, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsInstanceMethod(Unhandled rhs) => EqualsInstanceMethod(new(1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsInstanceMethod(Unhandled lhs) => EqualsInstanceMethod(lhs, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsInstanceMethod(Unhandled rhs) => EqualsInstanceMethod(new(-1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandleds_EqualsInstanceMethod(Unhandled scalar) => EqualsInstanceMethod(scalar, scalar);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled lhs, Unhandled rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
