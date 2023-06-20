namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class AsIEquatable_Equals
{
    private static bool Target(Scalar scalar, Scalar other)
    {
        return execute(scalar);

        bool execute(IEquatable<Scalar> equatable) => equatable.Equals(other);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsScalarEquals(Scalar scalar) => EqualsScalarEquals(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsScalarEquals(Scalar scalar) => EqualsScalarEquals(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsScalarEquals(Scalar scalar) => EqualsScalarEquals(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsScalarEquals(Scalar scalar) => EqualsScalarEquals(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsScalarEquals(Scalar scalar) => EqualsScalarEquals(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsScalarEquals(Scalar scalar) => EqualsScalarEquals(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualScalar_EqualsScalarEquals(Scalar scalar) => EqualsScalarEquals(scalar, scalar);

    [AssertionMethod]
    private static void EqualsScalarEquals(Scalar scalar, Scalar other)
    {
        var expected = scalar.Equals(other);
        var actual = Target(scalar, other);

        Assert.Equal(expected, actual);
    }
}
