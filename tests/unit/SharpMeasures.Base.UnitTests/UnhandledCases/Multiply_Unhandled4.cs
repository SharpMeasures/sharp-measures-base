namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Unhandled4
{
    private static Unhandled4 Target(Unhandled unhandled, Unhandled4 factor) => unhandled.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, Unhandled.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationByComponents(Unhandled unhandled) => EqualsMultiplicationByComponents(unhandled, new(-1.5, -4.5, -7.5, -10.5));

    [AssertionMethod]
    private static void EqualsMultiplicationByComponents(Unhandled unhandled, Unhandled4 factor)
    {
        var expected = unhandled.Multiply(factor.Components);
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }
}
