namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Divide_Unhandled_Unhandled
{
    private static Unhandled Target(Unhandled x, Unhandled y) => x / y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled x) => EqualsMethod(x, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled x) => EqualsMethod(x, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled x) => EqualsMethod(x, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled x) => EqualsMethod(x, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled x) => EqualsMethod(x, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled x) => EqualsMethod(x, new(-1.5));

    [AssertionMethod]
    private static void EqualsMethod(Unhandled x, Unhandled y)
    {
        var expected = Unhandled.Divide(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
