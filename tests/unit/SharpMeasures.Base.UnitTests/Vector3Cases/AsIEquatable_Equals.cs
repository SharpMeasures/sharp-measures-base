namespace SharpMeasures.Vector3Cases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Vector3 vector, Vector3 other)
    {
        return execute(vector);

        bool execute(IEquatable<Vector3> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector3Equals(Vector3 vector) => EqualsVector3Equals(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector3Equals(Vector3 vector) => EqualsVector3Equals(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector3Equals(Vector3 vector) => EqualsVector3Equals(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector3Equals(Vector3 vector) => EqualsVector3Equals(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector3Equals(Vector3 vector) => EqualsVector3Equals(vector, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector3Equals(Vector3 vector) => EqualsVector3Equals(vector, (-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector3s_EqualsVector3Equals(Vector3 vector) => EqualsVector3Equals(vector, vector);

    [AssertionMethod]
    private static void EqualsVector3Equals(Vector3 vector, Vector3 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
