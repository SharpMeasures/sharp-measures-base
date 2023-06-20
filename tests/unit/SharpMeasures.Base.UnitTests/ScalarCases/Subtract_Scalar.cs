namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Subtract_Scalar
{
    private static Scalar Target(Scalar scalar, Scalar subtrahend) => scalar.Subtract(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDoubleSubtraction(Scalar scalar) => EqualsDoubleSubtraction(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDoubleSubtraction(Scalar scalar) => EqualsDoubleSubtraction(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDoubleSubtraction(Scalar scalar) => EqualsDoubleSubtraction(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDoubleSubtraction(Scalar scalar) => EqualsDoubleSubtraction(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDoubleSubtraction(Scalar scalar) => EqualsDoubleSubtraction(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDoubleSubtraction(Scalar scalar) => EqualsDoubleSubtraction(scalar, -1.5);

    [AssertionMethod]
    private static void EqualsDoubleSubtraction(Scalar scalar, Scalar subtrahend)
    {
        Scalar expected = scalar.ToDouble() - subtrahend.ToDouble();
        var actual = Target(scalar, subtrahend);

        Assert.Equal(expected, actual);
    }
}
