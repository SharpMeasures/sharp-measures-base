namespace SharpMeasures.BinaryPrefixCases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_IFormatProvider
{
    private static string Target(BinaryPrefix prefix, IFormatProvider? formatProvider) => prefix.ToString(formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_En_EqualsToStringWithFormatG(BinaryPrefix prefix) => CurrentCulture_EqualsToStringWithFormatG(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_De_EqualsToStringWithFormatG(BinaryPrefix prefix) => CurrentCulture_EqualsToStringWithFormatG(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void InvariantCulture_De_EqualsToStringWithFormatG(BinaryPrefix prefix) => EqualsToStringWithFormatG(prefix, CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithFormatG(BinaryPrefix prefix) => Null_EqualsToStringWithFormatG(prefix);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithFormatG(BinaryPrefix prefix) => Null_EqualsToStringWithFormatG(prefix);

    [AssertionMethod]
    private static void CurrentCulture_EqualsToStringWithFormatG(BinaryPrefix prefix) => EqualsToStringWithFormatG(prefix, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void Null_EqualsToStringWithFormatG(BinaryPrefix prefix) => EqualsToStringWithFormatG(prefix, null);

    [AssertionMethod]
    private static void EqualsToStringWithFormatG(BinaryPrefix prefix, IFormatProvider? formatProvider)
    {
        var expected = prefix.ToString("G", formatProvider);
        var actual = Target(prefix, formatProvider);

        Assert.Equal(expected, actual);
    }
}
