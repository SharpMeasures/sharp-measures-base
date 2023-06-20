namespace SharpMeasures.MetricPrefixCases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString().")]
    private static string Target(MetricPrefix prefix) => prefix.ToString();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithCurrentCulture(MetricPrefix prefix) => EqualsToStringWithCurrentCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithCurrentCulture(MetricPrefix prefix) => EqualsToStringWithCurrentCulture(prefix);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(MetricPrefix prefix)
    {
        var expected = prefix.ToString(CultureInfo.CurrentCulture);
        var actual = Target(prefix);

        Assert.Equal(expected, actual);
    }
}
