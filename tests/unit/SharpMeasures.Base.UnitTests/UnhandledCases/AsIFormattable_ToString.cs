namespace SharpMeasures.UnhandledCases;

using System;
using System.Globalization;

using Xunit;

public sealed class AsIFormattable_ToString
{
    private static string Target(Unhandled unhandled, string? format, IFormatProvider? formatProvider)
    {
        return execute(unhandled);

        string execute(IFormattable formattable) => formattable.ToString(format, formatProvider);
    }

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsUnhandledToString(Unhandled unhandled) => G_CurrentCulture_EqualsUnhandledToString(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsUnhandledToString(Unhandled unhandled) => G_CurrentCulture_EqualsUnhandledToString(unhandled);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsUnhandledToString(Unhandled unhandled) => F4_CurrentCulture_EqualsUnhandledToString(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsUnhandledToString(Unhandled unhandled) => F4_CurrentCulture_EqualsUnhandledToString(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsUnhandledToString(Unhandled unhandled) => EqualsUnhandledToString(unhandled, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsUnhandledToString(Unhandled unhandled) => EqualsUnhandledToString(unhandled, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsUnhandledToString(Unhandled unhandled) => EqualsUnhandledToString(unhandled, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsUnhandledToString(Unhandled unhandled) => EqualsUnhandledToString(unhandled, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsUnhandledToString(Unhandled unhandled) => EqualsUnhandledToString(unhandled, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsUnhandledToString(Unhandled unhandled) => EqualsUnhandledToString(unhandled, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsUnhandledToString(Unhandled unhandled) => EqualsUnhandledToString(unhandled, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsUnhandledToString(Unhandled unhandled) => CurrentCulture_EqualsUnhandledToString(unhandled, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsUnhandledToString(Unhandled unhandled) => CurrentCulture_EqualsUnhandledToString(unhandled, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsUnhandledToString(Unhandled unhandled, string? format) => EqualsUnhandledToString(unhandled, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsUnhandledToString(Unhandled unhandled, string? format, IFormatProvider? formatProvider)
    {
        var expected = unhandled.ToString(format, formatProvider);
        var actual = Target(unhandled, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
