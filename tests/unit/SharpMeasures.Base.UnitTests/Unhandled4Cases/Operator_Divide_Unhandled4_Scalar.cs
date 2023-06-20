namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Divide_Unhandled4_Scalar
{
    private static Unhandled4 Target(Unhandled4 a, Scalar b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled4 a) => EqualsMethod(a, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled4 a) => EqualsMethod(a, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled4 a, Scalar b)
    {
        var expected = Unhandled4.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
