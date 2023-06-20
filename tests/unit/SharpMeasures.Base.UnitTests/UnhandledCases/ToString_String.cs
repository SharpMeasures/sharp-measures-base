namespace SharpMeasures.UnhandledCases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString_String
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString(string).")]
    private static string Target(Unhandled unhandled, string? format) => unhandled.ToString(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithCurrentCulture(Unhandled unhandled) => G_EqualsToStringWithCurrentCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithCurrentCulture(Unhandled unhandled) => G_EqualsToStringWithCurrentCulture(unhandled);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithCurrentCulture(Unhandled unhandled) => F4_EqualsToStringWithCurrentCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithCurrentCulture(Unhandled unhandled) => F4_EqualsToStringWithCurrentCulture(unhandled);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithCurrentCulture(Unhandled unhandled) => Null_EqualsToStringWithCurrentCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithCurrentCulture(Unhandled unhandled) => Null_EqualsToStringWithCurrentCulture(unhandled);

    [AssertionMethod]
    private static void G_EqualsToStringWithCurrentCulture(Unhandled unhandled) => EqualsToStringWithCurrentCulture(unhandled, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithCurrentCulture(Unhandled unhandled) => EqualsToStringWithCurrentCulture(unhandled, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithCurrentCulture(Unhandled unhandled) => EqualsToStringWithCurrentCulture(unhandled, null);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(Unhandled unhandled, string? format)
    {
        var expected = unhandled.ToString(format, CultureInfo.CurrentCulture);
        var actual = Target(unhandled, format);

        Assert.Equal(expected, actual);
    }
}
