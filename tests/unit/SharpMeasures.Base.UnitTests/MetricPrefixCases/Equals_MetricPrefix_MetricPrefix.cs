namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Equals_MetricPrefix_MetricPrefix
{
    private static bool Target(MetricPrefix? lhs, MetricPrefix? rhs) => MetricPrefix.Equals(lhs, rhs);

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
    public void LHS_Zero_EqualsInstanceMethod(MetricPrefix lhs) => EqualsInstanceMethod(lhs, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(MetricPrefix rhs) => EqualsInstanceMethod(MetricPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsInstanceMethod(MetricPrefix lhs) => EqualsInstanceMethod(lhs, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsInstanceMethod(MetricPrefix rhs) => EqualsInstanceMethod(MetricPrefix.Tera, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsInstanceMethod(MetricPrefix prefix) => EqualsInstanceMethod(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsInstanceMethod() => EqualsInstanceMethod(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(MetricPrefix lhs, MetricPrefix rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
