namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Equals_Vector2
{
    private static bool Target(Vector2 vector, Vector2 other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsEquals(Vector2 vector) => EqualsComponentsEquals(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsEquals(Vector2 vector) => EqualsComponentsEquals(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsEquals(Vector2 vector) => EqualsComponentsEquals(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsEquals(Vector2 vector) => EqualsComponentsEquals(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsEquals(Vector2 vector) => EqualsComponentsEquals(vector, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsEquals(Vector2 vector) => EqualsComponentsEquals(vector, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector2s_EqualsComponentsEquals(Vector2 vector) => EqualsComponentsEquals(vector, vector);

    [AssertionMethod]
    private static void EqualsComponentsEquals(Vector2 vector, Vector2 other)
    {
        var expected = (vector.X == other.X) && (vector.Y == other.Y);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
