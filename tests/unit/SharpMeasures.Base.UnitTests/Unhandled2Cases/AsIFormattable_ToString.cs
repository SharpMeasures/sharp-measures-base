namespace SharpMeasures.Unhandled2Cases;

using System;
using System.Globalization;

using Xunit;

public sealed class AsIFormattable_ToString
{
    private static string Target(Unhandled2 vector, string? format, IFormatProvider? formatProvider)
    {
        return execute(vector);

        string execute(IFormattable formattable) => formattable.ToString(format, formatProvider);
    }

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsUnhandled2ToString(Unhandled2 vector) => G_CurrentCulture_EqualsUnhandled2ToString(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsUnhandled2ToString(Unhandled2 vector) => G_CurrentCulture_EqualsUnhandled2ToString(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsUnhandled2ToString(Unhandled2 vector) => F4_CurrentCulture_EqualsUnhandled2ToString(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsUnhandled2ToString(Unhandled2 vector) => F4_CurrentCulture_EqualsUnhandled2ToString(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsUnhandled2ToString(Unhandled2 vector) => EqualsUnhandled2ToString(vector, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsUnhandled2ToString(Unhandled2 vector) => EqualsUnhandled2ToString(vector, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsUnhandled2ToString(Unhandled2 vector) => EqualsUnhandled2ToString(vector, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsUnhandled2ToString(Unhandled2 vector) => EqualsUnhandled2ToString(vector, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsUnhandled2ToString(Unhandled2 vector) => EqualsUnhandled2ToString(vector, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsUnhandled2ToString(Unhandled2 vector) => EqualsUnhandled2ToString(vector, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsUnhandled2ToString(Unhandled2 vector) => EqualsUnhandled2ToString(vector, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsUnhandled2ToString(Unhandled2 vector) => CurrentCulture_EqualsUnhandled2ToString(vector, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsUnhandled2ToString(Unhandled2 vector) => CurrentCulture_EqualsUnhandled2ToString(vector, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsUnhandled2ToString(Unhandled2 vector, string? format) => EqualsUnhandled2ToString(vector, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsUnhandled2ToString(Unhandled2 vector, string? format, IFormatProvider? formatProvider)
    {
        var expected = vector.ToString(format, formatProvider);
        var actual = Target(vector, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
