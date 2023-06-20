namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Equals_Object
{
    private static bool Target(Scalar scalar, object? other) => scalar.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Null_False(Scalar scalar)
    {
        var actual = Target(scalar, null);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void String_False(Scalar scalar)
    {
        var actual = Target(scalar, string.Empty);

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Zero_EqualsSpecificEqualsMethod(Scalar scalar) => EqualsSpecificEqualsMethod(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NaN_EqualsSpecificEqualsMethod(Scalar scalar) => EqualsSpecificEqualsMethod(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_PositiveInfinity_EqualsSpecificEqualsMethod(Scalar scalar) => EqualsSpecificEqualsMethod(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_NegativeInfinity_EqualsSpecificEqualsMethod(Scalar scalar) => EqualsSpecificEqualsMethod(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Positive_EqualsSpecificEqualsMethod(Scalar scalar) => EqualsSpecificEqualsMethod(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Negative_EqualsSpecificEqualsMethod(Scalar scalar) => EqualsSpecificEqualsMethod(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameType_Equal_EqualsSpecificEqualsMethod(Scalar scalar) => EqualsSpecificEqualsMethod(scalar, scalar);

    [AssertionMethod]
    private static void EqualsSpecificEqualsMethod(Scalar scalar, Scalar other)
    {
        var expected = scalar.Equals(other);
        var actual = Target(scalar, other);

        Assert.Equal(expected, actual);
    }
}
