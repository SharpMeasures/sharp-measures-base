namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(Unhandled lhs, Unhandled rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(Unhandled lhs) => EqualsEqualsMethod(lhs, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(Unhandled rhs) => EqualsEqualsMethod(Unhandled.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NaN_EqualsEqualsMethod(Unhandled lhs) => EqualsEqualsMethod(lhs, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NaN_EqualsEqualsMethod(Unhandled rhs) => EqualsEqualsMethod(Unhandled.NaN, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_PositiveInfinity_EqualsEqualsMethod(Unhandled lhs) => EqualsEqualsMethod(lhs, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_PositiveInfinity_EqualsEqualsMethod(Unhandled rhs) => EqualsEqualsMethod(Unhandled.PositiveInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NegativeInfinity_EqualsEqualsMethod(Unhandled lhs) => EqualsEqualsMethod(lhs, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NegativeInfinity_EqualsEqualsMethod(Unhandled rhs) => EqualsEqualsMethod(Unhandled.NegativeInfinity, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Positive_EqualsEqualsMethod(Unhandled lhs) => EqualsEqualsMethod(lhs, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Positive_EqualsEqualsMethod(Unhandled rhs) => EqualsEqualsMethod(new(1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Negative_EqualsEqualsMethod(Unhandled lhs) => EqualsEqualsMethod(lhs, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Negative_EqualsEqualsMethod(Unhandled rhs) => EqualsEqualsMethod(new(-1.5), rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandleds_EqualsEqualsMethod(Unhandled scalar) => EqualsEqualsMethod(scalar, scalar);

    [AssertionMethod]
    private static void EqualsEqualsMethod(Unhandled lhs, Unhandled rhs)
    {
        var expected = Unhandled.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
