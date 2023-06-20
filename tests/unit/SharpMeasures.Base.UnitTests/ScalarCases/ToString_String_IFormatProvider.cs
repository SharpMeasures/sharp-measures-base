namespace SharpMeasures.ScalarCases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_String_IFormatProvider
{
    private static string Target(Scalar scalar, string? format, IFormatProvider? formatProvider) => scalar.ToString(format, formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsDoubleToString(Scalar scalar) => G_CurrentCulture_EqualsDoubleToString(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsDoubleToString(Scalar scalar) => G_CurrentCulture_EqualsDoubleToString(scalar);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsDoubleToString(Scalar scalar) => F4_CurrentCulture_EqualsDoubleToString(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsDoubleToString(Scalar scalar) => F4_CurrentCulture_EqualsDoubleToString(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsDoubleToString(Scalar scalar) => EqualsDoubleToString(scalar, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsDoubleToString(Scalar scalar) => EqualsDoubleToString(scalar, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsDoubleToString(Scalar scalar) => EqualsDoubleToString(scalar, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsDoubleToString(Scalar scalar) => EqualsDoubleToString(scalar, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsDoubleToString(Scalar scalar) => EqualsDoubleToString(scalar, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsDoubleToString(Scalar scalar) => EqualsDoubleToString(scalar, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsDoubleToString(Scalar scalar) => EqualsDoubleToString(scalar, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsDoubleToString(Scalar scalar) => CurrentCulture_EqualsDoubleToString(scalar, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsDoubleToString(Scalar scalar) => CurrentCulture_EqualsDoubleToString(scalar, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsDoubleToString(Scalar scalar, string? format) => EqualsDoubleToString(scalar, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsDoubleToString(Scalar scalar, string? format, IFormatProvider? formatProvider)
    {
        var expected = scalar.ToDouble().ToString(format, formatProvider);
        var actual = Target(scalar, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
