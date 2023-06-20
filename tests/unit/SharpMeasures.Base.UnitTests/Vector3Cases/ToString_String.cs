namespace SharpMeasures.Vector3Cases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString_String
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString(string).")]
    private static string Target(Vector3 vector, string? format) => vector.ToString(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithCurrentCulture(Vector3 vector) => G_EqualsToStringWithCurrentCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithCurrentCulture(Vector3 vector) => G_EqualsToStringWithCurrentCulture(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithCurrentCulture(Vector3 vector) => F4_EqualsToStringWithCurrentCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithCurrentCulture(Vector3 vector) => F4_EqualsToStringWithCurrentCulture(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithCurrentCulture(Vector3 vector) => Null_EqualsToStringWithCurrentCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithCurrentCulture(Vector3 vector) => Null_EqualsToStringWithCurrentCulture(vector);

    [AssertionMethod]
    private static void G_EqualsToStringWithCurrentCulture(Vector3 vector) => EqualsToStringWithCurrentCulture(vector, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithCurrentCulture(Vector3 vector) => EqualsToStringWithCurrentCulture(vector, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithCurrentCulture(Vector3 vector) => EqualsToStringWithCurrentCulture(vector, null);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(Vector3 vector, string? format)
    {
        var expected = vector.ToString(format, CultureInfo.CurrentCulture);
        var actual = Target(vector, format);

        Assert.Equal(expected, actual);
    }
}
