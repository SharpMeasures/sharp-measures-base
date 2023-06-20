namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Add_Scalar
{
    private static Scalar Target(Scalar scalar, Scalar addend) => scalar.Add(addend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDoubleAddition(Scalar scalar) => EqualsDoubleAddition(scalar, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDoubleAddition(Scalar scalar) => EqualsDoubleAddition(scalar, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDoubleAddition(Scalar scalar) => EqualsDoubleAddition(scalar, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDoubleAddition(Scalar scalar) => EqualsDoubleAddition(scalar, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDoubleAddition(Scalar scalar) => EqualsDoubleAddition(scalar, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDoubleAddition(Scalar scalar) => EqualsDoubleAddition(scalar, -1.5);

    [AssertionMethod]
    private static void EqualsDoubleAddition(Scalar scalar, Scalar addend)
    {
        Scalar expected = scalar.ToDouble() + addend.ToDouble();
        var actual = Target(scalar, addend);

        Assert.Equal(expected, actual);
    }
}
