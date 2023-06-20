namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Vector2
{
    private static Unhandled2 Target(Unhandled unhandled, Vector2 factor) => unhandled.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, (-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsMultiplicationByMagnitude(Unhandled unhandled, Vector2 factor)
    {
        Unhandled2 expected = new(unhandled.Magnitude.Multiply(factor));
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }
}
