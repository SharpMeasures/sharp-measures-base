namespace SharpMeasures.UnhandledCases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString().")]
    private static string Target(Unhandled unhandled) => unhandled.ToString();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithCurrentCulture(Unhandled unhandled) => EqualsToStringWithCurrentCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithCurrentCulture(Unhandled unhandled) => EqualsToStringWithCurrentCulture(unhandled);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(Unhandled unhandled)
    {
        var expected = unhandled.ToString(CultureInfo.CurrentCulture);
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
