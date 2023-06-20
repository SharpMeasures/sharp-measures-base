namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Unhandled2
{
    private static Unhandled2 Target(Unhandled unhandled, Unhandled2 factor) => unhandled.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, new(-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsMultiplicationByComponents(Unhandled unhandled, Unhandled2 factor)
    {
        var expected = unhandled.Multiply(factor.Components);
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }
}
