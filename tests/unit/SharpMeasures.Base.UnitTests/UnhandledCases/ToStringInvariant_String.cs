namespace SharpMeasures.UnhandledCases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant_String
{
    private static string Target(Unhandled unhandled, string? format) => unhandled.ToStringInvariant(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithInvariantCulture(Unhandled unhandled) => G_EqualsToStringWithInvariantCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithInvariantCulture(Unhandled unhandled) => G_EqualsToStringWithInvariantCulture(unhandled);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithInvariantCulture(Unhandled unhandled) => F4_EqualsToStringWithInvariantCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithInvariantCulture(Unhandled unhandled) => F4_EqualsToStringWithInvariantCulture(unhandled);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithInvariantCulture(Unhandled unhandled) => Null_EqualsToStringWithInvariantCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithInvariantCulture(Unhandled unhandled) => Null_EqualsToStringWithInvariantCulture(unhandled);

    [AssertionMethod]
    private static void G_EqualsToStringWithInvariantCulture(Unhandled unhandled) => EqualsToStringWithInvariantCulture(unhandled, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithInvariantCulture(Unhandled unhandled) => EqualsToStringWithInvariantCulture(unhandled, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithInvariantCulture(Unhandled unhandled) => EqualsToStringWithInvariantCulture(unhandled, null);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Unhandled unhandled, string? format)
    {
        var expected = unhandled.ToString(format, CultureInfo.InvariantCulture);
        var actual = Target(unhandled, format);

        Assert.Equal(expected, actual);
    }
}
