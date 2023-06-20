namespace SharpMeasures.BinaryPrefixCases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant
{
    private static string Target(BinaryPrefix prefix) => prefix.ToStringInvariant();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => EqualsToStringWithInvariantCulture(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithInvariantCulture(BinaryPrefix prefix) => EqualsToStringWithInvariantCulture(prefix);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(BinaryPrefix prefix)
    {
        var expected = prefix.ToString(CultureInfo.InvariantCulture);
        var actual = Target(prefix);

        Assert.Equal(expected, actual);
    }
}
