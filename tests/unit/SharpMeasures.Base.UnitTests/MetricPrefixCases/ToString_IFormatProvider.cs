namespace SharpMeasures.MetricPrefixCases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_IFormatProvider
{
    private static string Target(MetricPrefix prefix, IFormatProvider? formatProvider) => prefix.ToString(formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_En_EqualsToStringWithFormatG(MetricPrefix prefix) => CurrentCulture_EqualsToStringWithFormatG(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_De_EqualsToStringWithFormatG(MetricPrefix prefix) => CurrentCulture_EqualsToStringWithFormatG(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void InvariantCulture_De_EqualsToStringWithFormatG(MetricPrefix prefix) => EqualsToStringWithFormatG(prefix, CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithFormatG(MetricPrefix prefix) => Null_EqualsToStringWithFormatG(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithFormatG(MetricPrefix prefix) => Null_EqualsToStringWithFormatG(prefix);

    [AssertionMethod]
    private static void CurrentCulture_EqualsToStringWithFormatG(MetricPrefix prefix) => EqualsToStringWithFormatG(prefix, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void Null_EqualsToStringWithFormatG(MetricPrefix prefix) => EqualsToStringWithFormatG(prefix, null);

    [AssertionMethod]
    private static void EqualsToStringWithFormatG(MetricPrefix prefix, IFormatProvider? formatProvider)
    {
        var expected = prefix.ToString("G", formatProvider);
        var actual = Target(prefix, formatProvider);

        Assert.Equal(expected, actual);
    }
}
