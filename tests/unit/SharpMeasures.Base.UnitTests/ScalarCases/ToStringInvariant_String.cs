namespace SharpMeasures.ScalarCases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant_String
{
    private static string Target(Scalar scalar, string? format) => scalar.ToStringInvariant(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithInvariantCulture(Scalar scalar) => G_EqualsToStringWithInvariantCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithInvariantCulture(Scalar scalar) => G_EqualsToStringWithInvariantCulture(scalar);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithInvariantCulture(Scalar scalar) => F4_EqualsToStringWithInvariantCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithInvariantCulture(Scalar scalar) => F4_EqualsToStringWithInvariantCulture(scalar);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithInvariantCulture(Scalar scalar) => Null_EqualsToStringWithInvariantCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithInvariantCulture(Scalar scalar) => Null_EqualsToStringWithInvariantCulture(scalar);

    [AssertionMethod]
    private static void G_EqualsToStringWithInvariantCulture(Scalar scalar) => EqualsToStringWithInvariantCulture(scalar, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithInvariantCulture(Scalar scalar) => EqualsToStringWithInvariantCulture(scalar, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithInvariantCulture(Scalar scalar) => EqualsToStringWithInvariantCulture(scalar, null);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Scalar scalar, string? format)
    {
        var expected = scalar.ToString(format, CultureInfo.InvariantCulture);
        var actual = Target(scalar, format);

        Assert.Equal(expected, actual);
    }
}
