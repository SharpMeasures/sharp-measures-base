namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Equals_BinaryPrefix_BinaryPrefix
{
    private static bool Target(BinaryPrefix? lhs, BinaryPrefix? rhs) => BinaryPrefix.Equals(lhs, rhs);

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
    public void LHS_Zero_EqualsInstanceMethod(BinaryPrefix lhs) => EqualsInstanceMethod(lhs, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_Zero_EqualsInstanceMethod(BinaryPrefix rhs) => EqualsInstanceMethod(BinaryPrefix.Zero, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void LHS_NonZero_EqualsInstanceMethod(BinaryPrefix lhs) => EqualsInstanceMethod(lhs, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void RHS_NonZero_EqualsInstanceMethod(BinaryPrefix rhs) => EqualsInstanceMethod(BinaryPrefix.Tebi, rhs);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameInstance_EqualsInstanceMethod(BinaryPrefix prefix) => EqualsInstanceMethod(prefix, prefix);

    [Fact]
    public void EqualButDifferentInstance_EqualsInstanceMethod() => EqualsInstanceMethod(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsInstanceMethod(BinaryPrefix lhs, BinaryPrefix rhs)
    {
        var expected = lhs.Equals(rhs);
        var actual = Target(lhs, rhs);

        Assert.Equal(expected, actual);
    }
}
