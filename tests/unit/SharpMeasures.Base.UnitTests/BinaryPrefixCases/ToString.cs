namespace SharpMeasures.BinaryPrefixCases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString().")]
    private static string Target(BinaryPrefix prefix) => prefix.ToString();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => EqualsToStringWithCurrentCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithCurrentCulture(BinaryPrefix prefix) => EqualsToStringWithCurrentCulture(prefix);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(BinaryPrefix prefix)
    {
        var expected = prefix.ToString(CultureInfo.CurrentCulture);
        var actual = Target(prefix);

        Assert.Equal(expected, actual);
    }
}
