namespace SharpMeasures.ScalarCases;

using System;

using Xunit;

public sealed class Difference_Scalar
{
    private static Scalar Target(Scalar scalar, Scalar other) => scalar.Difference(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, -1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void SameValue_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, scalar);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegatedScalar_EqualsAbsoluteOfDoubleSubtraction(Scalar scalar) => EqualsAbsoluteOfDoubleSubtraction(scalar, -scalar);

    [AssertionMethod]
    private static void EqualsAbsoluteOfDoubleSubtraction(Scalar scalar, Scalar other)
    {
        Scalar expected = Math.Abs(scalar.ToDouble() - other.ToDouble());
        var actual = Target(scalar, other);

        Assert.Equal(expected, actual);
    }
}
