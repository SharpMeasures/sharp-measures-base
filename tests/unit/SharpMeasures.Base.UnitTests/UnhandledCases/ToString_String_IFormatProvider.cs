namespace SharpMeasures.UnhandledCases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_String_IFormatProvider
{
    private static string Target(Unhandled unhandled, string? format, IFormatProvider? formatProvider) => unhandled.ToString(format, formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsMagnitudeToString(Unhandled unhandled) => G_CurrentCulture_EqualsMagnitudeToString(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsMagnitudeToString(Unhandled unhandled) => G_CurrentCulture_EqualsMagnitudeToString(unhandled);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsMagnitudeToString(Unhandled unhandled) => F4_CurrentCulture_EqualsMagnitudeToString(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsMagnitudeToString(Unhandled unhandled) => F4_CurrentCulture_EqualsMagnitudeToString(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsMagnitudeToString(Unhandled unhandled) => EqualsMagnitudeToString(unhandled, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsMagnitudeToString(Unhandled unhandled) => EqualsMagnitudeToString(unhandled, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsMagnitudeToString(Unhandled unhandled) => EqualsMagnitudeToString(unhandled, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsMagnitudeToString(Unhandled unhandled) => EqualsMagnitudeToString(unhandled, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsMagnitudeToString(Unhandled unhandled) => EqualsMagnitudeToString(unhandled, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsMagnitudeToString(Unhandled unhandled) => EqualsMagnitudeToString(unhandled, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsMagnitudeToString(Unhandled unhandled) => EqualsMagnitudeToString(unhandled, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsMagnitudeToString(Unhandled unhandled) => CurrentCulture_EqualsMagnitudeToString(unhandled, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsMagnitudeToString(Unhandled unhandled) => CurrentCulture_EqualsMagnitudeToString(unhandled, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsMagnitudeToString(Unhandled unhandled, string? format) => EqualsMagnitudeToString(unhandled, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsMagnitudeToString(Unhandled unhandled, string? format, IFormatProvider? formatProvider)
    {
        var expected = unhandled.Magnitude.ToString(format, formatProvider);
        var actual = Target(unhandled, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
