namespace SharpMeasures.BinaryPrefixCases;

using Xunit;

public sealed class Equals_Object
{
    private static bool Target(BinaryPrefix prefix, object? other) => prefix.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(BinaryPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void String_False(BinaryPrefix prefix)
    {
        var actual = Target(prefix, string.Empty);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Zero_EqualsSpecificEqualsMethod(BinaryPrefix prefix) => EqualsSpecificEqualsMethod(prefix, BinaryPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NonZero_EqualsSpecificEqualsMethod(BinaryPrefix prefix) => EqualsSpecificEqualsMethod(prefix, BinaryPrefix.Tebi);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_SameInstance_EqualsSpecificEqualsMethod(BinaryPrefix prefix) => EqualsSpecificEqualsMethod(prefix, prefix);

    [Fact]
    public void SameType_EqualButDifferentInstance_EqualsSpecificEqualsMethod() => EqualsSpecificEqualsMethod(BinaryPrefix.TwoToThePower(5), BinaryPrefix.TwoToThePower(5));

    [AssertionMethod]
    private static void EqualsSpecificEqualsMethod(BinaryPrefix prefix, BinaryPrefix other)
    {
        var expected = prefix.Equals(other);
        var actual = Target(prefix, other);

        Assert.Equal(expected, actual);
    }
}
