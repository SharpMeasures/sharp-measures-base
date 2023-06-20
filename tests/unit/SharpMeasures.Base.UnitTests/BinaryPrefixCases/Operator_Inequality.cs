namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Operator_Inequality
{
    private static bool Target(BinaryPrefix? lhs, BinaryPrefix? rhs) => lhs != rhs;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Null_True(BinaryPrefix lhs)
    {
        var actual = Target(lhs, null);

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Null_True(BinaryPrefix rhs)
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
    public void LHS_Zero_EqualsNegationOfEqualsMethod(BinaryPrefix lhs) => EqualsNegationOfEqualsMethod(lhs, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsNegationOfEqualsMethod(BinaryPrefix rhs) => EqualsNegationOfEqualsMethod(BinaryPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsNegationOfEqualsMethod(BinaryPrefix lhs) => EqualsNegationOfEqualsMethod(lhs, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsNegationOfEqualsMethod(BinaryPrefix rhs) => EqualsNegationOfEqualsMethod(BinaryPrefix.Tebi, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsNegationOfEqualsMethod(BinaryPrefix prefix) => EqualsNegationOfEqualsMethod(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsNegationOfEqualsMethod() => EqualsNegationOfEqualsMethod(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsNegationOfEqualsMethod(BinaryPrefix lhs, BinaryPrefix rhs)
    {
        var expected = BinaryPrefix.Equals(lhs, rhs) is false;
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
