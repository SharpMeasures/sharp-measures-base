namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Multiply_Unhandled_Unhandled4
{
    private static Unhandled4 Target(Unhandled a, Unhandled4 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled4 b) => EqualsMethod(Unhandled.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled4 b) => EqualsMethod(Unhandled.NaN, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Unhandled.PositiveInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Unhandled.NegativeInfinity, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled4 b) => EqualsMethod(new(1.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled4 b) => EqualsMethod(new(-1.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled a, Unhandled4 b)
    {
        var expected = Unhandled4.Multiply(b, a);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
