namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class CompareTo
{
    private static int Target(Scalar scalar, Scalar other) => scalar.CompareTo(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsDoubleCompareTo(Scalar scalar) => SameSignAsDoubleCompareTo(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_SameSignAsDoubleCompareTo(Scalar scalar) => SameSignAsDoubleCompareTo(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_SameSignAsDoubleCompareTo(Scalar scalar) => SameSignAsDoubleCompareTo(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_SameSignAsDoubleCompareTo(Scalar scalar) => SameSignAsDoubleCompareTo(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_SameSignAsDoubleCompareTo(Scalar scalar) => SameSignAsDoubleCompareTo(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_SameSignAsDoubleCompareTo(Scalar scalar) => SameSignAsDoubleCompareTo(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalar_SameSignAsDoubleCompareTo(Scalar scalar) => SameSignAsDoubleCompareTo(scalar, scalar);

    [AssertionMethod]
    private static void SameSignAsDoubleCompareTo(Scalar scalar, Scalar other)
    {
        var expected = Math.Sign(scalar.ToDouble().CompareTo(other.ToDouble()));
        var actual = Math.Sign(Target(scalar, other));

        Assert.Equal(expected, actual);
    }
}
