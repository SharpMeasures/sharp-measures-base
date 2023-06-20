namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(MetricPrefix? lhs, MetricPrefix? rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Null_True(MetricPrefix lhs)
    {
        var actual = Target(lhs, null);

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Null_True(MetricPrefix rhs)
    {
        var actual = Target(null, rhs);

        Assert.True(actual);
    }

    [Fact]
    public void Null_Null_False()
    {
        var actual = Target(null, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsNegationOfEqualsMethod(MetricPrefix lhs) => EqualsNegationOfEqualsMethod(lhs, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(MetricPrefix rhs) => EqualsNegationOfEqualsMethod(MetricPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsNegationOfEqualsMethod(MetricPrefix lhs) => EqualsNegationOfEqualsMethod(lhs, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsNegationOfEqualsMethod(MetricPrefix rhs) => EqualsNegationOfEqualsMethod(MetricPrefix.Tera, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsNegationOfEqualsMethod(MetricPrefix prefix) => EqualsNegationOfEqualsMethod(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsNegationOfEqualsMethod() => EqualsNegationOfEqualsMethod(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(MetricPrefix lhs, MetricPrefix rhs)
    {
        var expected = MetricPrefix.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
