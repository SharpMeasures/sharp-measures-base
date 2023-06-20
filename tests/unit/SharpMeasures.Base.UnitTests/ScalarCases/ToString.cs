namespace SharpMeasures.ScalarCases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString().")]
    private static string Target(Scalar scalar) => scalar.ToString();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithCurrentCulture(Scalar scalar) => EqualsToStringWithCurrentCulture(scalar);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithCurrentCulture(Scalar scalar) => EqualsToStringWithCurrentCulture(scalar);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(Scalar scalar)
    {
        var expected = scalar.ToString(CultureInfo.CurrentCulture);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
