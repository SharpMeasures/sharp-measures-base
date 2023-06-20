namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Operator_LessThan
{
    private static bool Target(MetricPrefix? lhs, MetricPrefix? rhs) => lhs < rhs;

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
    public void Null_Null_False()
    {
        var actual = Target(null, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsFactorLessThan(MetricPrefix lhs) => EqualsFactorLessThan(lhs, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsFactorLessThan(MetricPrefix rhs) => EqualsFactorLessThan(MetricPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsFactorLessThan(MetricPrefix lhs) => EqualsFactorLessThan(lhs, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsFactorLessThan(MetricPrefix rhs) => EqualsFactorLessThan(MetricPrefix.Tera, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsFactorLessThan(MetricPrefix prefix) => EqualsFactorLessThan(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsFactorLessThan() => EqualsFactorLessThan(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsFactorLessThan(MetricPrefix lhs, MetricPrefix rhs)
    {
        var expected = lhs.Factor < rhs.Factor;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
