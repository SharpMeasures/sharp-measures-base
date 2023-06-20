namespace SharpMeasures.Unhandled4Cases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Unhandled4 vector, Unhandled4 other)
    {
        return execute(vector);

        bool execute(IEquatable<Unhandled4> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsUnhandled4Equals(Unhandled4 vector) => EqualsUnhandled4Equals(vector, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsUnhandled4Equals(Unhandled4 vector) => EqualsUnhandled4Equals(vector, Unhandled.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsUnhandled4Equals(Unhandled4 vector) => EqualsUnhandled4Equals(vector, Unhandled.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsUnhandled4Equals(Unhandled4 vector) => EqualsUnhandled4Equals(vector, Unhandled.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsUnhandled4Equals(Unhandled4 vector) => EqualsUnhandled4Equals(vector, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsUnhandled4Equals(Unhandled4 vector) => EqualsUnhandled4Equals(vector, new(-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector4s_EqualsUnhandled4Equals(Unhandled4 vector) => EqualsUnhandled4Equals(vector, vector);

    [AssertionMethod]
    private static void EqualsUnhandled4Equals(Unhandled4 vector, Unhandled4 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
