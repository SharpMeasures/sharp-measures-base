namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Divide_Unhandled3_Scalar
{
    private static Unhandled3 Target(Unhandled3 a, Scalar b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled3 a) => EqualsMethod(a, 1.5 * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled3 a) => EqualsMethod(a, 1.5 * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled3 a, Scalar b)
    {
        var expected = Unhandled3.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
