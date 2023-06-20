namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Operator_LessThan
{
    private static bool Target(BinaryPrefix? lhs, BinaryPrefix? rhs) => lhs < rhs;

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
    public void LHS_Zero_EqualsFactorLessThan(BinaryPrefix lhs) => EqualsFactorLessThan(lhs, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsFactorLessThan(BinaryPrefix rhs) => EqualsFactorLessThan(BinaryPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsFactorLessThan(BinaryPrefix lhs) => EqualsFactorLessThan(lhs, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsFactorLessThan(BinaryPrefix rhs) => EqualsFactorLessThan(BinaryPrefix.Tebi, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsFactorLessThan(BinaryPrefix prefix) => EqualsFactorLessThan(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsFactorLessThan() => EqualsFactorLessThan(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsFactorLessThan(BinaryPrefix lhs, BinaryPrefix rhs)
    {
        var expected = lhs.Factor < rhs.Factor;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
