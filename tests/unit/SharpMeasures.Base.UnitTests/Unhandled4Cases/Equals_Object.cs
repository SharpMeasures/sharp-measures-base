namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Equals_Object
{
    private static bool Target(Unhandled4 vector, object? other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(Unhandled4 vector)
    {
        var actual = Target(vector, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void String_False(Unhandled4 vector)
    {
        var actual = Target(vector, string.Empty);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Zero_EqualsSpecificEqualsMethod(Unhandled4 vector) => EqualsSpecificEqualsMethod(vector, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NaN_EqualsSpecificEqualsMethod(Unhandled4 vector) => EqualsSpecificEqualsMethod(vector, Scalar.NaN * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_PositiveInfinity_EqualsSpecificEqualsMethod(Unhandled4 vector) => EqualsSpecificEqualsMethod(vector, Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NegativeInfinity_EqualsSpecificEqualsMethod(Unhandled4 vector) => EqualsSpecificEqualsMethod(vector, Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Positive_EqualsSpecificEqualsMethod(Unhandled4 vector) => EqualsSpecificEqualsMethod(vector, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Negative_EqualsSpecificEqualsMethod(Unhandled4 vector) => EqualsSpecificEqualsMethod(vector, new(-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Equal_EqualsSpecificEqualsMethod(Unhandled4 vector) => EqualsSpecificEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsSpecificEqualsMethod(Unhandled4 vector, Unhandled4 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
