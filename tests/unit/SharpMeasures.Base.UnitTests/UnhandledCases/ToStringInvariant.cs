namespace SharpMeasures.UnhandledCases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant
{
    private static string Target(Unhandled unhandled) => unhandled.ToStringInvariant();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithInvariantCulture(Unhandled unhandled) => EqualsToStringWithInvariantCulture(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithInvariantCulture(Unhandled unhandled) => EqualsToStringWithInvariantCulture(unhandled);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Unhandled unhandled)
    {
        var expected = unhandled.ToString(CultureInfo.InvariantCulture);
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
