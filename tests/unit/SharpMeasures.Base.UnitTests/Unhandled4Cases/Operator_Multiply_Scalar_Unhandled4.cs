namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Multiply_Scalar_Unhandled4
{
    private static Unhandled4 Target(Scalar a, Unhandled4 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.NaN, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.PositiveInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.NegativeInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled4 b) => EqualsMethod(1.5, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled4 b) => EqualsMethod(-1.5, b);

    [AssertionMethod]
    private static void EqualsMethod(Scalar a, Unhandled4 b)
    {
        var expected = Unhandled4.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
