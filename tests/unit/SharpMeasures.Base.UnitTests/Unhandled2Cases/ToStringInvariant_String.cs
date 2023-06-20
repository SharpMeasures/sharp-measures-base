﻿namespace SharpMeasures.Unhandled2Cases;

using System.Globalization;

using Xunit;

public sealed class ToStringInvariant_String
{
    private static string Target(Unhandled2 vector, string? format) => vector.ToStringInvariant(format);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void G_En_EqualsToStringWithInvariantCulture(Unhandled2 vector) => G_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void G_De_EqualsToStringWithInvariantCulture(Unhandled2 vector) => G_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void F4_En_EqualsToStringWithInvariantCulture(Unhandled2 vector) => F4_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void F4_De_EqualsToStringWithInvariantCulture(Unhandled2 vector) => F4_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void Null_En_EqualsToStringWithInvariantCulture(Unhandled2 vector) => Null_EqualsToStringWithInvariantCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void Null_De_EqualsToStringWithInvariantCulture(Unhandled2 vector) => Null_EqualsToStringWithInvariantCulture(vector);

    [AssertionMethod]
    private static void G_EqualsToStringWithInvariantCulture(Unhandled2 vector) => EqualsToStringWithInvariantCulture(vector, "G");

    [AssertionMethod]
    private static void F4_EqualsToStringWithInvariantCulture(Unhandled2 vector) => EqualsToStringWithInvariantCulture(vector, "F4");

    [AssertionMethod]
    private static void Null_EqualsToStringWithInvariantCulture(Unhandled2 vector) => EqualsToStringWithInvariantCulture(vector, null);

    [AssertionMethod]
    private static void EqualsToStringWithInvariantCulture(Unhandled2 vector, string? format)
    {
        var expected = vector.ToString(format, CultureInfo.InvariantCulture);
        var actual = Target(vector, format);

        Assert.Equal(expected, actual);
    }
}
