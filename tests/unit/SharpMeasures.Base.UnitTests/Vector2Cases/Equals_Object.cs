namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Equals_Object
{
    private static bool Target(Vector2 vector, object? other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(Vector2 vector)
    {
        var actual = Target(vector, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void String_False(Vector2 vector)
    {
        var actual = Target(vector, string.Empty);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Zero_EqualsSpecificEqualsMethod(Vector2 vector) => EqualsSpecificEqualsMethod(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NaN_EqualsSpecificEqualsMethod(Vector2 vector) => EqualsSpecificEqualsMethod(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_PositiveInfinity_EqualsSpecificEqualsMethod(Vector2 vector) => EqualsSpecificEqualsMethod(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NegativeInfinity_EqualsSpecificEqualsMethod(Vector2 vector) => EqualsSpecificEqualsMethod(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Positive_EqualsSpecificEqualsMethod(Vector2 vector) => EqualsSpecificEqualsMethod(vector, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Negative_EqualsSpecificEqualsMethod(Vector2 vector) => EqualsSpecificEqualsMethod(vector, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Equal_EqualsSpecificEqualsMethod(Vector2 vector) => EqualsSpecificEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsSpecificEqualsMethod(Vector2 vector, Vector2 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
