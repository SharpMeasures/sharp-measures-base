namespace SharpMeasures.Unhandled2Cases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_String_IFormatProvider
{
    private static string Target(Unhandled2 vector, string? format, IFormatProvider? formatProvider) => vector.ToString(format, formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsCustomFormat(Unhandled2 vector) => G_CurrentCulture_EqualsCustomFormat(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsCustomFormat(Unhandled2 vector) => G_CurrentCulture_EqualsCustomFormat(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsCustomFormat(Unhandled2 vector) => F4_CurrentCulture_EqualsCustomFormat(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsCustomFormat(Unhandled2 vector) => F4_CurrentCulture_EqualsCustomFormat(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsCustomFormat(Unhandled2 vector) => EqualsCustomFormat(vector, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsCustomFormat(Unhandled2 vector) => EqualsCustomFormat(vector, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsCustomFormat(Unhandled2 vector) => EqualsCustomFormat(vector, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsCustomFormat(Unhandled2 vector) => EqualsCustomFormat(vector, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsCustomFormat(Unhandled2 vector) => EqualsCustomFormat(vector, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsCustomFormat(Unhandled2 vector) => EqualsCustomFormat(vector, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsCustomFormat(Unhandled2 vector) => EqualsCustomFormat(vector, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsCustomFormat(Unhandled2 vector) => CurrentCulture_EqualsCustomFormat(vector, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsCustomFormat(Unhandled2 vector) => CurrentCulture_EqualsCustomFormat(vector, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsCustomFormat(Unhandled2 vector, string? format) => EqualsCustomFormat(vector, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsCustomFormat(Unhandled2 vector, string? format, IFormatProvider? formatProvider)
    {
        if (format is "g" or "G" or null)
        {
            format = "({0}, {1})";
        }

        var expected = string.Format(formatProvider, format, vector.X, vector.Y);
        var actual = Target(vector, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
