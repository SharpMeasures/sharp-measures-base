namespace SharpMeasures.UnhandledCases;

using System;

using Xunit;

public sealed class AsIComparable_CompareTo
{
    private static int Target(Unhandled unhandled, Unhandled other)
    {
        return execute(unhandled);

        int execute(IComparable<Unhandled> comparable) => comparable.CompareTo(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsUnhandledCompareTo(Unhandled unhandled) => SameSignAsUnhandledCompareTo(unhandled, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_SameSignAsUnhandledCompareTo(Unhandled unhandled) => SameSignAsUnhandledCompareTo(unhandled, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_SameSignAsUnhandledCompareTo(Unhandled unhandled) => SameSignAsUnhandledCompareTo(unhandled, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_SameSignAsUnhandledCompareTo(Unhandled unhandled) => SameSignAsUnhandledCompareTo(unhandled, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_SameSignAsUnhandledCompareTo(Unhandled unhandled) => SameSignAsUnhandledCompareTo(unhandled, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_SameSignAsUnhandledCompareTo(Unhandled unhandled) => SameSignAsUnhandledCompareTo(unhandled, new(-1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled_SameSignAsUnhandledCompareTo(Unhandled unhandled) => SameSignAsUnhandledCompareTo(unhandled, unhandled);

    [AssertionMethod]
    private static void SameSignAsUnhandledCompareTo(Unhandled unhandled, Unhandled other)
    {
        var expected = Math.Sign(unhandled.CompareTo(other));
        var actual = Math.Sign(Target(unhandled, other));

        Assert.Equal(expected, actual);
    }
}
