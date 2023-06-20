namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Operator_GreaterThan
{
    private static bool Target(BinaryPrefix? lhs, BinaryPrefix? rhs) => lhs > rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Null_False(BinaryPrefix lhs)
    {
        var actual = Target(lhs, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Null_False(BinaryPrefix rhs)
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
    public void LHS_Zero_EqualsFactorGreaterThan(BinaryPrefix lhs) => EqualsFactorGreaterThan(lhs, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsFactorGreaterThan(BinaryPrefix rhs) => EqualsFactorGreaterThan(BinaryPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsFactorGreaterThan(BinaryPrefix lhs) => EqualsFactorGreaterThan(lhs, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsFactorGreaterThan(BinaryPrefix rhs) => EqualsFactorGreaterThan(BinaryPrefix.Tebi, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsFactorGreaterThan(BinaryPrefix prefix) => EqualsFactorGreaterThan(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstances_EqualsFactorGreaterThan() => EqualsFactorGreaterThan(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsFactorGreaterThan(BinaryPrefix lhs, BinaryPrefix rhs)
    {
        var expected = lhs.Factor > rhs.Factor;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
