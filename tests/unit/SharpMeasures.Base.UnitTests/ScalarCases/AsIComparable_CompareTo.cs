namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class AsIComparable_CompareTo
{
    private static int Target(Scalar scalar, Scalar other)
    {
        return execute(scalar);

        int execute(IComparable<Scalar> comparable) => comparable.CompareTo(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_SameSignAsScalarCompareTo(Scalar scalar) => SameSignAsScalarCompareTo(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_SameSignAsScalarCompareTo(Scalar scalar) => SameSignAsScalarCompareTo(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_SameSignAsScalarCompareTo(Scalar scalar) => SameSignAsScalarCompareTo(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_SameSignAsScalarCompareTo(Scalar scalar) => SameSignAsScalarCompareTo(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_SameSignAsScalarCompareTo(Scalar scalar) => SameSignAsScalarCompareTo(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_SameSignAsScalarCompareTo(Scalar scalar) => SameSignAsScalarCompareTo(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalar_SameSignAsScalarCompareTo(Scalar scalar) => SameSignAsScalarCompareTo(scalar, scalar);

    [AssertionMethod]
    private static void SameSignAsScalarCompareTo(Scalar scalar, Scalar other)
    {
        var expected = Math.Sign(scalar.CompareTo(other));
        var actual = Math.Sign(Target(scalar, other));

        Assert.Equal(expected, actual);
    }
}
