namespace SharpMeasures.ScalarCases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant
{
    private static string Target(Scalar scalar) => scalar.ToStringInvariant();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithInvariantCulture(Scalar scalar) => EqualsToStringWithInvariantCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithInvariantCulture(Scalar scalar) => EqualsToStringWithInvariantCulture(scalar);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Scalar scalar)
    {
        var expected = scalar.ToString(CultureInfo.InvariantCulture);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
