namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Divide_Unhandled4_Unhandled
{
    private static Unhandled4 Target(Unhandled4 a, Unhandled b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled4 a) => EqualsMethod(a, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled4 a) => EqualsMethod(a, new(-1.5));

    [AssertionMethod]
    private static void EqualsMethod(Unhandled4 a, Unhandled b)
    {
        var expected = Unhandled4.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
