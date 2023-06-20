namespace SharpMeasures.Unhandled4Cases;

using System;
using System.Globalization;

using Xunit;

public sealed class AsIFormattable_ToString
{
    private static string Target(Unhandled4 vector, string? format, IFormatProvider? formatProvider)
    {
        return execute(vector);

        string execute(IFormattable formattable) => formattable.ToString(format, formatProvider);
    }

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsUnhandled4ToString(Unhandled4 vector) => G_CurrentCulture_EqualsUnhandled4ToString(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsUnhandled4ToString(Unhandled4 vector) => G_CurrentCulture_EqualsUnhandled4ToString(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsUnhandled4ToString(Unhandled4 vector) => F4_CurrentCulture_EqualsUnhandled4ToString(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsUnhandled4ToString(Unhandled4 vector) => F4_CurrentCulture_EqualsUnhandled4ToString(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsUnhandled4ToString(Unhandled4 vector) => EqualsUnhandled4ToString(vector, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsUnhandled4ToString(Unhandled4 vector) => EqualsUnhandled4ToString(vector, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsUnhandled4ToString(Unhandled4 vector) => EqualsUnhandled4ToString(vector, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsUnhandled4ToString(Unhandled4 vector) => EqualsUnhandled4ToString(vector, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsUnhandled4ToString(Unhandled4 vector) => EqualsUnhandled4ToString(vector, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsUnhandled4ToString(Unhandled4 vector) => EqualsUnhandled4ToString(vector, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsUnhandled4ToString(Unhandled4 vector) => EqualsUnhandled4ToString(vector, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsUnhandled4ToString(Unhandled4 vector) => CurrentCulture_EqualsUnhandled4ToString(vector, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsUnhandled4ToString(Unhandled4 vector) => CurrentCulture_EqualsUnhandled4ToString(vector, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsUnhandled4ToString(Unhandled4 vector, string? format) => EqualsUnhandled4ToString(vector, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsUnhandled4ToString(Unhandled4 vector, string? format, IFormatProvider? formatProvider)
    {
        var expected = vector.ToString(format, formatProvider);
        var actual = Target(vector, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
