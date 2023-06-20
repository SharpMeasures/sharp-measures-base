namespace SharpMeasures.MetricPrefixCases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant_String
{
    private static string Target(MetricPrefix prefix, string? format) => prefix.ToStringInvariant(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => G_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => G_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => F4_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => F4_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => Null_EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => Null_EqualsToStringWithInvariantCulture(prefix);

    [AssertionMethod]
    private static void G_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => EqualsToStringWithInvariantCulture(prefix, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => EqualsToStringWithInvariantCulture(prefix, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithInvariantCulture(MetricPrefix prefix) => EqualsToStringWithInvariantCulture(prefix, null);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(MetricPrefix prefix, string? format)
    {
        var expected = prefix.ToString(format, CultureInfo.InvariantCulture);
        var actual = Target(prefix, format);

        Assert.Equal(expected, actual);
    }
}
