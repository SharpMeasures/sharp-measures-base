namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Equals_Object
{
    private static bool Target(Vector4 vector, object? other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(Vector4 vector)
    {
        var actual = Target(vector, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void String_False(Vector4 vector)
    {
        var actual = Target(vector, string.Empty);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Zero_EqualsSpecificEqualsMethod(Vector4 vector) => EqualsSpecificEqualsMethod(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NaN_EqualsSpecificEqualsMethod(Vector4 vector) => EqualsSpecificEqualsMethod(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_PositiveInfinity_EqualsSpecificEqualsMethod(Vector4 vector) => EqualsSpecificEqualsMethod(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NegativeInfinity_EqualsSpecificEqualsMethod(Vector4 vector) => EqualsSpecificEqualsMethod(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Positive_EqualsSpecificEqualsMethod(Vector4 vector) => EqualsSpecificEqualsMethod(vector, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Negative_EqualsSpecificEqualsMethod(Vector4 vector) => EqualsSpecificEqualsMethod(vector, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Equal_EqualsSpecificEqualsMethod(Vector4 vector) => EqualsSpecificEqualsMethod(vector, vector);

    [AssertionMethod]
    private static void EqualsSpecificEqualsMethod(Vector4 vector, Vector4 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
