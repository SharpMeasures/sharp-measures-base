namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Equals_Object
{
    private static bool Target(Unhandled unhandled, object? other) => unhandled.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(Unhandled unhandled)
    {
        var actual = Target(unhandled, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void String_False(Unhandled unhandled)
    {
        var actual = Target(unhandled, string.Empty);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Zero_EqualsSpecificEqualsMethod(Unhandled unhandled) => EqualsSpecificEqualsMethod(unhandled, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NaN_EqualsSpecificEqualsMethod(Unhandled unhandled) => EqualsSpecificEqualsMethod(unhandled, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_PositiveInfinity_EqualsSpecificEqualsMethod(Unhandled unhandled) => EqualsSpecificEqualsMethod(unhandled, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NegativeInfinity_EqualsSpecificEqualsMethod(Unhandled unhandled) => EqualsSpecificEqualsMethod(unhandled, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Positive_EqualsSpecificEqualsMethod(Unhandled unhandled) => EqualsSpecificEqualsMethod(unhandled, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Negative_EqualsSpecificEqualsMethod(Unhandled unhandled) => EqualsSpecificEqualsMethod(unhandled, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Equal_EqualsSpecificEqualsMethod(Unhandled unhandled) => EqualsSpecificEqualsMethod(unhandled, unhandled);

    [AssertionMethod]
    private static void EqualsSpecificEqualsMethod(Unhandled unhandled, Unhandled other)
    {
        var expected = unhandled.Equals(other);
        var actual = Target(unhandled, other);

        Assert.Equal(expected, actual);
    }
}
