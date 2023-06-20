namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Multiply_Unhandled_Scalar
{
    private static Unhandled Target(Unhandled x, Scalar y) => x * y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled x) => EqualsMethod(x, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled x) => EqualsMethod(x, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled x) => EqualsMethod(x, -1.5);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled x, Scalar y)
    {
        var expected = Unhandled.Multiply(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
