namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Multiply_Unhandled2
{
    private static Unhandled2 Target(Scalar scalar, Unhandled2 factor) => scalar.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Scalar.NaN * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Scalar.PositiveInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, Scalar.NegativeInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, new Unhandled2(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplyByVector2(Scalar scalar) => EqualsMultiplyByVector2(scalar, new Unhandled2(-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsMultiplyByVector2(Scalar scalar, Unhandled2 factor)
    {
        var expected = scalar.Multiply(factor.Components);
        var actual = Target(scalar, factor).Components;

        Assert.Equal(expected, actual);
    }
}
