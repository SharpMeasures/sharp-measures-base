﻿namespace SharpMeasures.Unhandled2Cases;

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using Xunit;

public sealed class ToString
{
    [SuppressMessage("Globalization", "CA1305: Specify IFormatProvider", Justification = "Test-case for ToString().")]
    private static string Target(Unhandled2 vector) => vector.ToString();

    [Theory]
    [UseCulture("en")]
    [ClassData(typeof(Dataset))]
    public void En_EqualsToStringWithCurrentCulture(Unhandled2 vector) => EqualsToStringWithCurrentCulture(vector);

    [Theory]
    [UseCulture("de")]
    [ClassData(typeof(Dataset))]
    public void De_EqualsToStringWithCurrentCulture(Unhandled2 vector) => EqualsToStringWithCurrentCulture(vector);

    [AssertionMethod]
    private static void EqualsToStringWithCurrentCulture(Unhandled2 vector)
    {
        var expected = vector.ToString(CultureInfo.CurrentCulture);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
