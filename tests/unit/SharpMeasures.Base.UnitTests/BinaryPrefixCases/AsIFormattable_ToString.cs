namespace SharpMeasures.BinaryPrefixCases;

using System;
using System.Globalization;

using Xunit;

public sealed class AsIFormattable_ToString
{
    private static string Target(BinaryPrefix prefix, string? format, IFormatProvider? formatProvider)
    {
        return execute(prefix);

        string execute(IFormattable formattable) => formattable.ToString(format, formatProvider);
    }

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsBinaryPrefixToString(BinaryPrefix prefix) => G_CurrentCulture_EqualsBinaryPrefixToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsBinaryPrefixToString(BinaryPrefix prefix) => G_CurrentCulture_EqualsBinaryPrefixToString(prefix);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsBinaryPrefixToString(BinaryPrefix prefix) => F4_CurrentCulture_EqualsBinaryPrefixToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsBinaryPrefixToString(BinaryPrefix prefix) => F4_CurrentCulture_EqualsBinaryPrefixToString(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsBinaryPrefixToString(BinaryPrefix prefix) => EqualsBinaryPrefixToString(prefix, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsBinaryPrefixToString(BinaryPrefix prefix) => EqualsBinaryPrefixToString(prefix, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsBinaryPrefixToString(BinaryPrefix prefix) => EqualsBinaryPrefixToString(prefix, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsBinaryPrefixToString(BinaryPrefix prefix) => EqualsBinaryPrefixToString(prefix, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsBinaryPrefixToString(BinaryPrefix prefix) => EqualsBinaryPrefixToString(prefix, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsBinaryPrefixToString(BinaryPrefix prefix) => EqualsBinaryPrefixToString(prefix, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsBinaryPrefixToString(BinaryPrefix prefix) => EqualsBinaryPrefixToString(prefix, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsBinaryPrefixToString(BinaryPrefix prefix) => CurrentCulture_EqualsBinaryPrefixToString(prefix, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsBinaryPrefixToString(BinaryPrefix prefix) => CurrentCulture_EqualsBinaryPrefixToString(prefix, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsBinaryPrefixToString(BinaryPrefix prefix, string? format) => EqualsBinaryPrefixToString(prefix, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsBinaryPrefixToString(BinaryPrefix prefix, string? format, IFormatProvider? formatProvider)
    {
        var expected = prefix.ToString(format, formatProvider);
        var actual = Target(prefix, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
