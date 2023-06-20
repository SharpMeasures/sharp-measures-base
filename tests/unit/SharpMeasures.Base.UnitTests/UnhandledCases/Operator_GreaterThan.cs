namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_GreaterThan
{
    private static bool Target(Unhandled lhs, Unhandled rhs) => lhs > rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsMagnitudeGreaterThan(Unhandled lhs) => EqualsMagnitudeGreaterThan(lhs, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsMagnitudeGreaterThan(Unhandled rhs) => EqualsMagnitudeGreaterThan(Unhandled.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsMagnitudeGreaterThan(Unhandled lhs) => EqualsMagnitudeGreaterThan(lhs, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsMagnitudeGreaterThan(Unhandled rhs) => EqualsMagnitudeGreaterThan(Unhandled.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsMagnitudeGreaterThan(Unhandled lhs) => EqualsMagnitudeGreaterThan(lhs, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsMagnitudeGreaterThan(Unhandled rhs) => EqualsMagnitudeGreaterThan(Unhandled.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsMagnitudeGreaterThan(Unhandled lhs) => EqualsMagnitudeGreaterThan(lhs, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsMagnitudeGreaterThan(Unhandled rhs) => EqualsMagnitudeGreaterThan(Unhandled.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsMagnitudeGreaterThan(Unhandled lhs) => EqualsMagnitudeGreaterThan(lhs, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsMagnitudeGreaterThan(Unhandled rhs) => EqualsMagnitudeGreaterThan(new(1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsMagnitudeGreaterThan(Unhandled lhs) => EqualsMagnitudeGreaterThan(lhs, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsMagnitudeGreaterThan(Unhandled rhs) => EqualsMagnitudeGreaterThan(new(-1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandleds_EqualsMagnitudeGreaterThan(Unhandled scalar) => EqualsMagnitudeGreaterThan(scalar, scalar);

    [AssertionMethod]
    private static void EqualsMagnitudeGreaterThan(Unhandled lhs, Unhandled rhs)
    {
        var expected = lhs.Magnitude > rhs.Magnitude;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
