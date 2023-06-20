namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_LessThan
{
    private static bool Target(Unhandled lhs, Unhandled rhs) => lhs < rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsMagnitudeLessThan(Unhandled lhs) => EqualsMagnitudeLessThan(lhs, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsMagnitudeLessThan(Unhandled rhs) => EqualsMagnitudeLessThan(Unhandled.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsMagnitudeLessThan(Unhandled lhs) => EqualsMagnitudeLessThan(lhs, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsMagnitudeLessThan(Unhandled rhs) => EqualsMagnitudeLessThan(Unhandled.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsMagnitudeLessThan(Unhandled lhs) => EqualsMagnitudeLessThan(lhs, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsMagnitudeLessThan(Unhandled rhs) => EqualsMagnitudeLessThan(Unhandled.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsMagnitudeLessThan(Unhandled lhs) => EqualsMagnitudeLessThan(lhs, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsMagnitudeLessThan(Unhandled rhs) => EqualsMagnitudeLessThan(Unhandled.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsMagnitudeLessThan(Unhandled lhs) => EqualsMagnitudeLessThan(lhs, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsMagnitudeLessThan(Unhandled rhs) => EqualsMagnitudeLessThan(new(1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsMagnitudeLessThan(Unhandled lhs) => EqualsMagnitudeLessThan(lhs, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsMagnitudeLessThan(Unhandled rhs) => EqualsMagnitudeLessThan(new(-1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandleds_EqualsMagnitudeLessThan(Unhandled scalar) => EqualsMagnitudeLessThan(scalar, scalar);

    [AssertionMethod]
    private static void EqualsMagnitudeLessThan(Unhandled lhs, Unhandled rhs)
    {
        var expected = lhs.Magnitude < rhs.Magnitude;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
