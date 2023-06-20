namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_LessThanOrEqual
{
    private static bool Target(Unhandled lhs, Unhandled rhs) => lhs <= rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsMagnitudeLessThanOrEqual(Unhandled lhs) => EqualsMagnitudeLessThanOrEqual(lhs, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsMagnitudeLessThanOrEqual(Unhandled rhs) => EqualsMagnitudeLessThanOrEqual(Unhandled.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsMagnitudeLessThanOrEqual(Unhandled lhs) => EqualsMagnitudeLessThanOrEqual(lhs, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsMagnitudeLessThanOrEqual(Unhandled rhs) => EqualsMagnitudeLessThanOrEqual(Unhandled.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsMagnitudeLessThanOrEqual(Unhandled lhs) => EqualsMagnitudeLessThanOrEqual(lhs, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsMagnitudeLessThanOrEqual(Unhandled rhs) => EqualsMagnitudeLessThanOrEqual(Unhandled.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsMagnitudeLessThanOrEqual(Unhandled lhs) => EqualsMagnitudeLessThanOrEqual(lhs, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsMagnitudeLessThanOrEqual(Unhandled rhs) => EqualsMagnitudeLessThanOrEqual(Unhandled.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsMagnitudeLessThanOrEqual(Unhandled lhs) => EqualsMagnitudeLessThanOrEqual(lhs, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsMagnitudeLessThanOrEqual(Unhandled rhs) => EqualsMagnitudeLessThanOrEqual(new(1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsMagnitudeLessThanOrEqual(Unhandled lhs) => EqualsMagnitudeLessThanOrEqual(lhs, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsMagnitudeLessThanOrEqual(Unhandled rhs) => EqualsMagnitudeLessThanOrEqual(new(-1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandleds_EqualsMagnitudeLessThanOrEqual(Unhandled scalar) => EqualsMagnitudeLessThanOrEqual(scalar, scalar);

    [AssertionMethod]
    private static void EqualsMagnitudeLessThanOrEqual(Unhandled lhs, Unhandled rhs)
    {
        var expected = lhs.Magnitude <= rhs.Magnitude;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
