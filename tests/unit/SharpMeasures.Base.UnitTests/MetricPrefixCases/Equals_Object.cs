namespace SharpMeasures.MetricPrefixCases;

using Xunit;

public sealed class Equals_Object
{
    private static bool Target(MetricPrefix prefix, object? other) => prefix.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(MetricPrefix prefix)
    {
        var actual = Target(prefix, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void String_False(MetricPrefix prefix)
    {
        var actual = Target(prefix, string.Empty);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Zero_EqualsSpecificEqualsMethod(MetricPrefix prefix) => EqualsSpecificEqualsMethod(prefix, MetricPrefix.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NonZero_EqualsSpecificEqualsMethod(MetricPrefix prefix) => EqualsSpecificEqualsMethod(prefix, MetricPrefix.Tera);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_SameInstance_EqualsSpecificEqualsMethod(MetricPrefix prefix) => EqualsSpecificEqualsMethod(prefix, prefix);

    [Fact]
    public void SameType_EqualButDifferentInstance_EqualsSpecificEqualsMethod() => EqualsSpecificEqualsMethod(MetricPrefix.TenToThePower(5), MetricPrefix.TenToThePower(5));

    [AssertionMethod]
    private static void EqualsSpecificEqualsMethod(MetricPrefix prefix, MetricPrefix other)
    {
        var expected = prefix.Equals(other);
        var actual = Target(prefix, other);

        Assert.Equal(expected, actual);
    }
}
