namespace SharpMeasures.Unhandled3Cases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Unhandled3 vector, Unhandled3 other)
    {
        return execute(vector);

        bool execute(IEquatable<Unhandled3> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsUnhandled3Equals(Unhandled3 vector) => EqualsUnhandled3Equals(vector, Unhandled3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsUnhandled3Equals(Unhandled3 vector) => EqualsUnhandled3Equals(vector, Unhandled.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsUnhandled3Equals(Unhandled3 vector) => EqualsUnhandled3Equals(vector, Unhandled.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsUnhandled3Equals(Unhandled3 vector) => EqualsUnhandled3Equals(vector, Unhandled.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsUnhandled3Equals(Unhandled3 vector) => EqualsUnhandled3Equals(vector, new(1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsUnhandled3Equals(Unhandled3 vector) => EqualsUnhandled3Equals(vector, new(-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector3s_EqualsUnhandled3Equals(Unhandled3 vector) => EqualsUnhandled3Equals(vector, vector);

    [AssertionMethod]
    private static void EqualsUnhandled3Equals(Unhandled3 vector, Unhandled3 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
