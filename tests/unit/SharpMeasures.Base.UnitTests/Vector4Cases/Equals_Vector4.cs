namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Equals_Vector4
{
    private static bool Target(Vector4 vector, Vector4 other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsEquals(Vector4 vector) => EqualsComponentsEquals(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsEquals(Vector4 vector) => EqualsComponentsEquals(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsEquals(Vector4 vector) => EqualsComponentsEquals(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsEquals(Vector4 vector) => EqualsComponentsEquals(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsEquals(Vector4 vector) => EqualsComponentsEquals(vector, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsEquals(Vector4 vector) => EqualsComponentsEquals(vector, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector4s_EqualsComponentsEquals(Vector4 vector) => EqualsComponentsEquals(vector, vector);

    [AssertionMethod]
    private static void EqualsComponentsEquals(Vector4 vector, Vector4 other)
    {
        var expected = (vector.X == other.X) && (vector.Y == other.Y);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
