namespace SharpMeasures.Vector4Cases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Vector4 vector, Vector4 other)
    {
        return execute(vector);

        bool execute(IEquatable<Vector4> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsVector4Equals(Vector4 vector) => EqualsVector4Equals(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsVector4Equals(Vector4 vector) => EqualsVector4Equals(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsVector4Equals(Vector4 vector) => EqualsVector4Equals(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsVector4Equals(Vector4 vector) => EqualsVector4Equals(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsVector4Equals(Vector4 vector) => EqualsVector4Equals(vector, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsVector4Equals(Vector4 vector) => EqualsVector4Equals(vector, (-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector4s_EqualsVector4Equals(Vector4 vector) => EqualsVector4Equals(vector, vector);

    [AssertionMethod]
    private static void EqualsVector4Equals(Vector4 vector, Vector4 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
