namespace SharpMeasures.BinaryPrefixCases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant_String
{
    private static string Target(BinaryPrefix prefix, string? format) => prefix.ToStringInvariant(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => G_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => G_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => F4_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => F4_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => Null_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => Null_EqualsToStringWithInvariantCulture(prefix);

    [AssertionMethod]
    private static void G_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => EqualsToStringWithInvariantCulture(prefix, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => EqualsToStringWithInvariantCulture(prefix, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => EqualsToStringWithInvariantCulture(prefix, null);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(BinaryPrefix prefix, string? format)
    {
        var expected = prefix.ToString(format, CultureInfo.InvariantCulture);
        var actual = Target(prefix, format);

        Assert.Equal(expected, actual);
    }
}
