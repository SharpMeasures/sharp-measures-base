namespace SharpMeasures.ScalarCases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_IFormatProvider
{
    private static string Target(Scalar scalar, IFormatProvider? formatProvider) => scalar.ToString(formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_En_EqualsToStringWithFormatG(Scalar scalar) => CurrentCulture_EqualsToStringWithFormatG(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_De_EqualsToStringWithFormatG(Scalar scalar) => CurrentCulture_EqualsToStringWithFormatG(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void InvariantCulture_De_EqualsToStringWithFormatG(Scalar scalar) => EqualsToStringWithFormatG(scalar, CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithFormatG(Scalar scalar) => Null_EqualsToStringWithFormatG(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithFormatG(Scalar scalar) => Null_EqualsToStringWithFormatG(scalar);

    [AssertionMethod]
    private static void CurrentCulture_EqualsToStringWithFormatG(Scalar scalar) => EqualsToStringWithFormatG(scalar, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void Null_EqualsToStringWithFormatG(Scalar scalar) => EqualsToStringWithFormatG(scalar, null);

    [AssertionMethod]
    private static void EqualsToStringWithFormatG(Scalar scalar, IFormatProvider? formatProvider)
    {
        var expected = scalar.ToString("G", formatProvider);
        var actual = Target(scalar, formatProvider);

        Assert.Equal(expected, actual);
    }
}
