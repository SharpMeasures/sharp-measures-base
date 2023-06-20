namespace SharpMeasures.Vector2Cases;

using System;
using System.Globalization;

using Xunit;

public sealed class ToString_IFormatProvider
{
    private static string Target(Vector2 vector, IFormatProvider? formatProvider) => vector.ToString(formatProvider);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_En_EqualsToStringWithFormatG(Vector2 vector) => CurrentCulture_EqualsToStringWithFormatG(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void CurrentCulture_De_EqualsToStringWithFormatG(Vector2 vector) => CurrentCulture_EqualsToStringWithFormatG(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void InvariantCulture_De_EqualsToStringWithFormatG(Vector2 vector) => EqualsToStringWithFormatG(vector, CultureInfo.InvariantCulture);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithFormatG(Vector2 vector) => Null_EqualsToStringWithFormatG(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithFormatG(Vector2 vector) => Null_EqualsToStringWithFormatG(vector);

    [AssertionMethod]
    private static void CurrentCulture_EqualsToStringWithFormatG(Vector2 vector) => EqualsToStringWithFormatG(vector, CultureInfo.CurrentCulture);

    [AssertionMethod]
    private static void Null_EqualsToStringWithFormatG(Vector2 vector) => EqualsToStringWithFormatG(vector, null);

    [AssertionMethod]
    private static void EqualsToStringWithFormatG(Vector2 vector, IFormatProvider? formatProvider)
    {
        var expected = vector.ToString("G", formatProvider);
        var actual = Target(vector, formatProvider);

        Assert.Equal(expected, actual);
    }
}
