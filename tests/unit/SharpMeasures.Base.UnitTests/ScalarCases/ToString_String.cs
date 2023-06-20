namespace SharpMeasures.ScalarCases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString_String
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString(string).")]
    private static string Target(Scalar scalar, string? format) => scalar.ToString(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithCurrentCulture(Scalar scalar) => G_EqualsToStringWithCurrentCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithCurrentCulture(Scalar scalar) => G_EqualsToStringWithCurrentCulture(scalar);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithCurrentCulture(Scalar scalar) => F4_EqualsToStringWithCurrentCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithCurrentCulture(Scalar scalar) => F4_EqualsToStringWithCurrentCulture(scalar);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithCurrentCulture(Scalar scalar) => Null_EqualsToStringWithCurrentCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithCurrentCulture(Scalar scalar) => Null_EqualsToStringWithCurrentCulture(scalar);

    [AssertionMethod]
    private static void G_EqualsToStringWithCurrentCulture(Scalar scalar) => EqualsToStringWithCurrentCulture(scalar, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithCurrentCulture(Scalar scalar) => EqualsToStringWithCurrentCulture(scalar, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithCurrentCulture(Scalar scalar) => EqualsToStringWithCurrentCulture(scalar, null);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(Scalar scalar, string? format)
    {
        var expected = scalar.ToString(format, CultureInfo.CurrentCulture);
        var actual = Target(scalar, format);

        Assert.Equal(expected, actual);
    }
}
