namespace SharpMeasures.MetricPrefixCases;

using System;
using System.Globalization;

using Xunit;

public sealed class AsIFormattable_ToString
{
    private static string Target(MetricPrefix prefix, string? format, IFormatProvider? formatProvider)
    {
        return execute(prefix);

        string execute(IFormattable formattable) => formattable.ToString(format, formatProvider);
    }

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsMetricPrefixToString(MetricPrefix prefix) => G_CurrentCulture_EqualsMetricPrefixToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsMetricPrefixToString(MetricPrefix prefix) => G_CurrentCulture_EqualsMetricPrefixToString(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsMetricPrefixToString(MetricPrefix prefix) => F4_CurrentCulture_EqualsMetricPrefixToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsMetricPrefixToString(MetricPrefix prefix) => F4_CurrentCulture_EqualsMetricPrefixToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsMetricPrefixToString(MetricPrefix prefix) => EqualsMetricPrefixToString(prefix, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsMetricPrefixToString(MetricPrefix prefix) => EqualsMetricPrefixToString(prefix, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsMetricPrefixToString(MetricPrefix prefix) => EqualsMetricPrefixToString(prefix, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsMetricPrefixToString(MetricPrefix prefix) => EqualsMetricPrefixToString(prefix, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsMetricPrefixToString(MetricPrefix prefix) => EqualsMetricPrefixToString(prefix, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsMetricPrefixToString(MetricPrefix prefix) => EqualsMetricPrefixToString(prefix, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsMetricPrefixToString(MetricPrefix prefix) => EqualsMetricPrefixToString(prefix, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsMetricPrefixToString(MetricPrefix prefix) => CurrentCulture_EqualsMetricPrefixToString(prefix, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsMetricPrefixToString(MetricPrefix prefix) => CurrentCulture_EqualsMetricPrefixToString(prefix, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsMetricPrefixToString(MetricPrefix prefix, string? format) => EqualsMetricPrefixToString(prefix, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsMetricPrefixToString(MetricPrefix prefix, string? format, IFormatProvider? formatProvider)
    {
        var expected = prefix.ToString(format, formatProvider);
        var actual = Target(prefix, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
