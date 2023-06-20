namespace SharpMeasures.Vector2Cases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant_String
{
    private static string Target(Vector2 vector, string? format) => vector.ToStringInvariant(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithInvariantCulture(Vector2 vector) => G_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithInvariantCulture(Vector2 vector) => G_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithInvariantCulture(Vector2 vector) => F4_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithInvariantCulture(Vector2 vector) => F4_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithInvariantCulture(Vector2 vector) => Null_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithInvariantCulture(Vector2 vector) => Null_EqualsToStringWithInvariantCulture(vector);

    [AssertionMethod]
    private static void G_EqualsToStringWithInvariantCulture(Vector2 vector) => EqualsToStringWithInvariantCulture(vector, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithInvariantCulture(Vector2 vector) => EqualsToStringWithInvariantCulture(vector, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithInvariantCulture(Vector2 vector) => EqualsToStringWithInvariantCulture(vector, null);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Vector2 vector, string? format)
    {
        var expected = vector.ToString(format, CultureInfo.InvariantCulture);
        var actual = Target(vector, format);

        Assert.Equal(expected, actual);
    }
}
