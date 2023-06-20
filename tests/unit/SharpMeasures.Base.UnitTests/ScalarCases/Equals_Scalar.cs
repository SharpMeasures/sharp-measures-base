namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Equals_Scalar
{
    private static bool Target(Scalar scalar, Scalar other) => scalar.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDoubleEquals(Scalar scalar) => EqualsDoubleEquals(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDoubleEquals(Scalar scalar) => EqualsDoubleEquals(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDoubleEquals(Scalar scalar) => EqualsDoubleEquals(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDoubleEquals(Scalar scalar) => EqualsDoubleEquals(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDoubleEquals(Scalar scalar) => EqualsDoubleEquals(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDoubleEquals(Scalar scalar) => EqualsDoubleEquals(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalar_EqualsDoubleEquals(Scalar scalar) => EqualsDoubleEquals(scalar, scalar);

    [AssertionMethod]
    private static void EqualsDoubleEquals(Scalar scalar, Scalar other)
    {
        var expected = scalar.ToDouble().Equals(other.ToDouble());
        var actual = Target(scalar, other);

        Assert.Equal(expected, actual);
    }
}
