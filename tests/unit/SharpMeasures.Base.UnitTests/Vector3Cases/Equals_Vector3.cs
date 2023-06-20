namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Equals_Vector3
{
    private static bool Target(Vector3 vector, Vector3 other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsEquals(Vector3 vector) => EqualsComponentsEquals(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsEquals(Vector3 vector) => EqualsComponentsEquals(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsEquals(Vector3 vector) => EqualsComponentsEquals(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsEquals(Vector3 vector) => EqualsComponentsEquals(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsEquals(Vector3 vector) => EqualsComponentsEquals(vector, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsEquals(Vector3 vector) => EqualsComponentsEquals(vector, (-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector3s_EqualsComponentsEquals(Vector3 vector) => EqualsComponentsEquals(vector, vector);

    [AssertionMethod]
    private static void EqualsComponentsEquals(Vector3 vector, Vector3 other)
    {
        var expected = (vector.X == other.X) && (vector.Y == other.Y) && (vector.Z == other.Z);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
