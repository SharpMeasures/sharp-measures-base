namespace SharpMeasures.BinaryPrefixCases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString_String
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString(string).")]
    private static string Target(BinaryPrefix prefix, string? format) => prefix.ToString(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => G_EqualsToStringWithCurrentCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => G_EqualsToStringWithCurrentCulture(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => F4_EqualsToStringWithCurrentCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => F4_EqualsToStringWithCurrentCulture(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => Null_EqualsToStringWithCurrentCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => Null_EqualsToStringWithCurrentCulture(prefix);

    [AssertionMethod]
    private static void G_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => EqualsToStringWithCurrentCulture(prefix, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => EqualsToStringWithCurrentCulture(prefix, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => EqualsToStringWithCurrentCulture(prefix, null);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(BinaryPrefix prefix, string? format)
    {
        var expected = prefix.ToString(format, CultureInfo.CurrentCulture);
        var actual = Target(prefix, format);

        Assert.Equal(expected, actual);
    }
}
