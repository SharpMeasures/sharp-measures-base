namespace SharpMeasures.Vector4Cases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant
{
    private static string Target(Vector4 vector) => vector.ToStringInvariant();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithInvariantCulture(Vector4 vector) => EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithInvariantCulture(Vector4 vector) => EqualsToStringWithInvariantCulture(vector);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Vector4 vector)
    {
        var expected = vector.ToString(CultureInfo.InvariantCulture);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
