namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(MetricPrefix? lhs, MetricPrefix? rhs) => lhs == rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Null_False(MetricPrefix lhs)
    {
        var actual = Target(lhs, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Null_False(MetricPrefix rhs)
    {
        var actual = Target(null, rhs);

        Assert.False(actual);
    }

    [Fact]
    public void Null_Null_True()
    {
        var actual = Target(null, null);

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(MetricPrefix lhs) => EqualsEqualsMethod(lhs, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(MetricPrefix rhs) => EqualsEqualsMethod(MetricPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsEqualsMethod(MetricPrefix lhs) => EqualsEqualsMethod(lhs, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsEqualsMethod(MetricPrefix rhs) => EqualsEqualsMethod(MetricPrefix.Tera, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsEqualsMethod(MetricPrefix prefix) => EqualsEqualsMethod(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsEqualsMethod() => EqualsEqualsMethod(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsEqualsMethod(MetricPrefix lhs, MetricPrefix rhs)
    {
        var expected = MetricPrefix.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
