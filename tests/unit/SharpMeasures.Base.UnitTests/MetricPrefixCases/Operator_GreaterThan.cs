﻿namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Operator_GreaterThan
{
    private static bool Target(MetricPrefix? lhs, MetricPrefix? rhs) => lhs > rhs;

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
    public void LHS_Zero_EqualsFactorGreaterThan(MetricPrefix lhs) => EqualsFactorGreaterThan(lhs, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsFactorGreaterThan(MetricPrefix rhs) => EqualsFactorGreaterThan(MetricPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsFactorGreaterThan(MetricPrefix lhs) => EqualsFactorGreaterThan(lhs, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsFactorGreaterThan(MetricPrefix rhs) => EqualsFactorGreaterThan(MetricPrefix.Tera, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsFactorGreaterThan(MetricPrefix prefix) => EqualsFactorGreaterThan(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsFactorGreaterThan() => EqualsFactorGreaterThan(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsFactorGreaterThan(MetricPrefix lhs, MetricPrefix rhs)
    {
        var expected = lhs.Factor > rhs.Factor;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
