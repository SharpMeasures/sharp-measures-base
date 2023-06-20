namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Add_Unhandled_Unhandled
{
    private static Unhandled Target(Unhandled x, Unhandled y) => x + y;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled unhandled) => EqualsMethod(unhandled, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled unhandled) => EqualsMethod(unhandled, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled unhandled) => EqualsMethod(unhandled, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled unhandled) => EqualsMethod(unhandled, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled unhandled) => EqualsMethod(unhandled, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled unhandled) => EqualsMethod(unhandled, new(-1.5));

    [AssertionMethod]
    private static void EqualsMethod(Unhandled x, Unhandled y)
    {
        var expected = Unhandled.Add(x, y);
        var actual = Target(x, y);

        Assert.Equal(expected, actual);
    }
}
