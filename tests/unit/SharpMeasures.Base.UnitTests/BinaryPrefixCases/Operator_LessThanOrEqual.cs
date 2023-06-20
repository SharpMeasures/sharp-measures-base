namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Operator_LessThanOrEqual
{
    private static bool Target(BinaryPrefix? lhs, BinaryPrefix? rhs) => lhs <= rhs;

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
    public void LHS_Zero_EqualsFactorLessThanOrEqual(BinaryPrefix lhs) => EqualsFactorLessThanOrEqual(lhs, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsFactorLessThanOrEqual(BinaryPrefix rhs) => EqualsFactorLessThanOrEqual(BinaryPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsFactorLessThanOrEqual(BinaryPrefix lhs) => EqualsFactorLessThanOrEqual(lhs, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsFactorLessThanOrEqual(BinaryPrefix rhs) => EqualsFactorLessThanOrEqual(BinaryPrefix.Tebi, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsFactorLessThanOrEqual(BinaryPrefix prefix) => EqualsFactorLessThanOrEqual(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsFactorLessThanOrEqual() => EqualsFactorLessThanOrEqual(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsFactorLessThanOrEqual(BinaryPrefix lhs, BinaryPrefix rhs)
    {
        var expected = lhs.Factor <= rhs.Factor;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
