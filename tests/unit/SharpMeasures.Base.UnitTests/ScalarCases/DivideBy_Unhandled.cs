namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class DivideBy_Unhandled
{
    private static Unhandled Target(Scalar scalar, Unhandled divisor) => scalar.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsScalarDivision(Scalar scalar) => EqualsScalarDivision(scalar, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsScalarDivision(Scalar scalar) => EqualsScalarDivision(scalar, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsScalarDivision(Scalar scalar) => EqualsScalarDivision(scalar, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsScalarDivision(Scalar scalar) => EqualsScalarDivision(scalar, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsScalarDivision(Scalar scalar) => EqualsScalarDivision(scalar, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsScalarDivision(Scalar scalar) => EqualsScalarDivision(scalar, new(-1.5));

    [AssertionMethod]
    private static void EqualsScalarDivision(Scalar scalar, Unhandled divisor)
    {
        var expected = scalar / divisor.Magnitude;
        var actual = Target(scalar, divisor).Magnitude;

        Assert.Equal(expected, actual);
    }
}
