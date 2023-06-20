namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Operator_Multiply_Unhandled_Unhandled2
{
    private static Unhandled2 Target(Unhandled a, Unhandled2 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled2 b) => EqualsMethod(Unhandled.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled2 b) => EqualsMethod(Unhandled.NaN, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled2 b) => EqualsMethod(Unhandled.PositiveInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled2 b) => EqualsMethod(Unhandled.NegativeInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled2 b) => EqualsMethod(new(1.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled2 b) => EqualsMethod(new(-1.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled a, Unhandled2 b)
    {
        var expected = Unhandled2.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
