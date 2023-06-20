namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Multiply_Unhandled_Unhandled3
{
    private static Unhandled3 Target(Unhandled a, Unhandled3 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled3 b) => EqualsMethod(Unhandled.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled3 b) => EqualsMethod(Unhandled.NaN, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled3 b) => EqualsMethod(Unhandled.PositiveInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled3 b) => EqualsMethod(Unhandled.NegativeInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled3 b) => EqualsMethod(new(1.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled3 b) => EqualsMethod(new(-1.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled a, Unhandled3 b)
    {
        var expected = Unhandled3.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
