namespace SharpMeasures.UnhandledCases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_IFormatProvider
{
    private static string Target(Unhandled unhandled, IFormatProvider? formatProvider) => unhandled.ToString(formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_En_EqualsToStringWithFormatG(Unhandled unhandled) => CurrentCulture_EqualsToStringWithFormatG(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_De_EqualsToStringWithFormatG(Unhandled unhandled) => CurrentCulture_EqualsToStringWithFormatG(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void InvariantCulture_De_EqualsToStringWithFormatG(Unhandled unhandled) => EqualsToStringWithFormatG(unhandled, CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithFormatG(Unhandled unhandled) => Null_EqualsToStringWithFormatG(unhandled);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithFormatG(Unhandled unhandled) => Null_EqualsToStringWithFormatG(unhandled);

    [AssertionMethod]
    private static void CurrentCulture_EqualsToStringWithFormatG(Unhandled unhandled) => EqualsToStringWithFormatG(unhandled, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void Null_EqualsToStringWithFormatG(Unhandled unhandled) => EqualsToStringWithFormatG(unhandled, null);

    [AssertionMethod]
    private static void EqualsToStringWithFormatG(Unhandled unhandled, IFormatProvider? formatProvider)
    {
        var expected = unhandled.ToString("G", formatProvider);
        var actual = Target(unhandled, formatProvider);

        Assert.Equal(expected, actual);
    }
}
