namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Unhandled4
{
    private static Unhandled4 Target(Scalar scalar, Unhandled4 factor) => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Scalar.NaN * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, new Unhandled4(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, new Unhandled4(-1.5, -4.5, -7.5, -10.5));

    [AssertionMethod]
    private static void EqualsMultiplyByVector2(Scalar scalar, Unhandled4 factor)
    {
        var expected = scalar.Multiply(factor.Components);
        var actual = Target(scalar, factor).Components;

        Assert.Equal(expected, actual);
    }
}
