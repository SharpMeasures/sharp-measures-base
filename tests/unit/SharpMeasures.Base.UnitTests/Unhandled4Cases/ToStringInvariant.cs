namespace SharpMeasures.Unhandled4Cases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant
{
    private static string Target(Unhandled4 vector) => vector.ToStringInvariant();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithInvariantCulture(Unhandled4 vector) => EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithInvariantCulture(Unhandled4 vector) => EqualsToStringWithInvariantCulture(vector);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Unhandled4 vector)
    {
        var expected = vector.ToString(CultureInfo.InvariantCulture);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
