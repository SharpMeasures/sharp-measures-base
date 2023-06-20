namespace SharpMeasures.MetricPrefixCases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_String_IFormatProvider
{
    private static string Target(MetricPrefix prefix, string? format, IFormatProvider? formatProvider) => prefix.ToString(format, formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsFactorToString(MetricPrefix prefix) => G_CurrentCulture_EqualsFactorToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsFactorToString(MetricPrefix prefix) => G_CurrentCulture_EqualsFactorToString(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsFactorToString(MetricPrefix prefix) => F4_CurrentCulture_EqualsFactorToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsFactorToString(MetricPrefix prefix) => F4_CurrentCulture_EqualsFactorToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsFactorToString(MetricPrefix prefix) => EqualsFactorToString(prefix, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsFactorToString(MetricPrefix prefix) => EqualsFactorToString(prefix, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsFactorToString(MetricPrefix prefix) => EqualsFactorToString(prefix, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsFactorToString(MetricPrefix prefix) => EqualsFactorToString(prefix, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsFactorToString(MetricPrefix prefix) => EqualsFactorToString(prefix, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsFactorToString(MetricPrefix prefix) => EqualsFactorToString(prefix, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsFactorToString(MetricPrefix prefix) => EqualsFactorToString(prefix, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsFactorToString(MetricPrefix prefix) => CurrentCulture_EqualsFactorToString(prefix, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsFactorToString(MetricPrefix prefix) => CurrentCulture_EqualsFactorToString(prefix, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsFactorToString(MetricPrefix prefix, string? format) => EqualsFactorToString(prefix, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsFactorToString(MetricPrefix prefix, string? format, IFormatProvider? formatProvider)
    {
        var expected = prefix.Factor.ToString(format, formatProvider);
        var actual = Target(prefix, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
