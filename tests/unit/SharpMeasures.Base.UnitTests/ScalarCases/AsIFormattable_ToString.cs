namespace SharpMeasures.ScalarCases;

using System;
using System.Globalization;

using Xunit;

public sealed class AsIFormattable_ToString
{
    private static string Target(Scalar scalar, string? format, IFormatProvider? formatProvider)
    {
        return execute(scalar);

        string execute(IFormattable formattable) => formattable.ToString(format, formatProvider);
    }

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_En_EqualsScalarToString(Scalar scalar) => G_CurrentCulture_EqualsScalarToString(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_CurrentCulture_De_EqualsScalarToString(Scalar scalar) => G_CurrentCulture_EqualsScalarToString(scalar);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_En_EqualsScalarToString(Scalar scalar) => F4_CurrentCulture_EqualsScalarToString(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_CurrentCulture_De_EqualsScalarToString(Scalar scalar) => F4_CurrentCulture_EqualsScalarToString(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_InvariantCulture_De_EqualsScalarToString(Scalar scalar) => EqualsScalarToString(scalar, "F4", CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_En_EqualsScalarToString(Scalar scalar) => EqualsScalarToString(scalar, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_CurrentCulture_De_EqualsScalarToString(Scalar scalar) => EqualsScalarToString(scalar, null, CultureInfo.CurrentCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_En_EqualsScalarToString(Scalar scalar) => EqualsScalarToString(scalar, "G", null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_NullProvider_De_EqualsScalarToString(Scalar scalar) => EqualsScalarToString(scalar, "G", null);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_En_EqualsScalarToString(Scalar scalar) => EqualsScalarToString(scalar, null, null);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void NullFormat_NullProvider_De_EqualsScalarToString(Scalar scalar) => EqualsScalarToString(scalar, null, null);

    [AssertionMethod]
    private static void G_CurrentCulture_EqualsScalarToString(Scalar scalar) => CurrentCulture_EqualsScalarToString(scalar, "G");

    [AssertionMethod]
    private static void F4_CurrentCulture_EqualsScalarToString(Scalar scalar) => CurrentCulture_EqualsScalarToString(scalar, "F4");

    [AssertionMethod]
    private static void CurrentCulture_EqualsScalarToString(Scalar scalar, string? format) => EqualsScalarToString(scalar, format, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void EqualsScalarToString(Scalar scalar, string? format, IFormatProvider? formatProvider)
    {
        var expected = scalar.ToString(format, formatProvider);
        var actual = Target(scalar, format, formatProvider);

        Assert.Equal(expected, actual);
    }
}
