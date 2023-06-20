namespace SharpMeasures.Unhandled2Cases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Unhandled2 vector, Unhandled2 other)
    {
        return execute(vector);

        bool execute(IEquatable<Unhandled2> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsUnhandled2Equals(Unhandled2 vector) => EqualsUnhandled2Equals(vector, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsUnhandled2Equals(Unhandled2 vector) => EqualsUnhandled2Equals(vector, Unhandled.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsUnhandled2Equals(Unhandled2 vector) => EqualsUnhandled2Equals(vector, Unhandled.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsUnhandled2Equals(Unhandled2 vector) => EqualsUnhandled2Equals(vector, Unhandled.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsUnhandled2Equals(Unhandled2 vector) => EqualsUnhandled2Equals(vector, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsUnhandled2Equals(Unhandled2 vector) => EqualsUnhandled2Equals(vector, new(-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualVector2s_EqualsUnhandled2Equals(Unhandled2 vector) => EqualsUnhandled2Equals(vector, vector);

    [AssertionMethod]
    private static void EqualsUnhandled2Equals(Unhandled2 vector, Unhandled2 other)
    {
        var expected = vector.Equals(other);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
