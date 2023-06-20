namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_GreaterThanOrEqual
{
    private static bool Target(Unhandled lhs, Unhandled rhs) => lhs >= rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsMagnitudeGreaterThanOrEqual(Unhandled lhs) => EqualsMagnitudeGreaterThanOrEqual(lhs, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsMagnitudeGreaterThanOrEqual(Unhandled rhs) => EqualsMagnitudeGreaterThanOrEqual(Unhandled.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsMagnitudeGreaterThanOrEqual(Unhandled lhs) => EqualsMagnitudeGreaterThanOrEqual(lhs, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsMagnitudeGreaterThanOrEqual(Unhandled rhs) => EqualsMagnitudeGreaterThanOrEqual(Unhandled.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsMagnitudeGreaterThanOrEqual(Unhandled lhs) => EqualsMagnitudeGreaterThanOrEqual(lhs, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsMagnitudeGreaterThanOrEqual(Unhandled rhs) => EqualsMagnitudeGreaterThanOrEqual(Unhandled.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsMagnitudeGreaterThanOrEqual(Unhandled lhs) => EqualsMagnitudeGreaterThanOrEqual(lhs, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsMagnitudeGreaterThanOrEqual(Unhandled rhs) => EqualsMagnitudeGreaterThanOrEqual(Unhandled.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsMagnitudeGreaterThanOrEqual(Unhandled lhs) => EqualsMagnitudeGreaterThanOrEqual(lhs, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsMagnitudeGreaterThanOrEqual(Unhandled rhs) => EqualsMagnitudeGreaterThanOrEqual(new(1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsMagnitudeGreaterThanOrEqual(Unhandled lhs) => EqualsMagnitudeGreaterThanOrEqual(lhs, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsMagnitudeGreaterThanOrEqual(Unhandled rhs) => EqualsMagnitudeGreaterThanOrEqual(new(-1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandleds_EqualsMagnitudeGreaterThanOrEqual(Unhandled scalar) => EqualsMagnitudeGreaterThanOrEqual(scalar, scalar);

    [AssertionMethod]
    private static void EqualsMagnitudeGreaterThanOrEqual(Unhandled lhs, Unhandled rhs)
    {
        var expected = lhs.Magnitude >= rhs.Magnitude;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
