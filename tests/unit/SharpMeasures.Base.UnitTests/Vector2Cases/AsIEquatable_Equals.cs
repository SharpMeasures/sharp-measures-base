namespace SharpMeasures.Vector2Cases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Vector2 vector, Vector2 other)
    {
        return execute(vector);

        bool execute(IEquatable<Vector2> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector2Equals(Vector2 vector) => EqualsVector2Equals(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector2Equals(Vector2 vector) => EqualsVector2Equals(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector2Equals(Vector2 vector) => EqualsVector2Equals(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector2Equals(Vector2 vector) => EqualsVector2Equals(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector2Equals(Vector2 vector) => EqualsVector2Equals(vector, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector2Equals(Vector2 vector) => EqualsVector2Equals(vector, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector2s_EqualsVector2Equals(Vector2 vector) => EqualsVector2Equals(vector, vector);

    [AssertionMethod]
    private static void EqualsVector2Equals(Vector2 vector, Vector2 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
