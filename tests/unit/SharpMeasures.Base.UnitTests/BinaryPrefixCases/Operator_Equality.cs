namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Operator_Equality
{
    private static bool Target(BinaryPrefix? lhs, BinaryPrefix? rhs) => lhs == rhs;

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
    public void Null_Null_True()
    {
        var actual = Target(null, null);

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_Zero_EqualsEqualsMethod(BinaryPrefix lhs) => EqualsEqualsMethod(lhs, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsEqualsMethod(BinaryPrefix rhs) => EqualsEqualsMethod(BinaryPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsEqualsMethod(BinaryPrefix lhs) => EqualsEqualsMethod(lhs, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsEqualsMethod(BinaryPrefix rhs) => EqualsEqualsMethod(BinaryPrefix.Tebi, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsEqualsMethod(BinaryPrefix prefix) => EqualsEqualsMethod(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsEqualsMethod() => EqualsEqualsMethod(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsEqualsMethod(BinaryPrefix lhs, BinaryPrefix rhs)
    {
        var expected = BinaryPrefix.Equals(lhs, rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
