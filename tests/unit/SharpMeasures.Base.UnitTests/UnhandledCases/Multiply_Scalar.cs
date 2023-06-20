namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Scalar
{
    private static Unhandled Target(Unhandled unhandled, Scalar factor) => unhandled.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfMagnitude(Unhandled unhandled) => EqualsMultiplicationOfMagnitude(unhandled, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfMagnitude(Unhandled unhandled) => EqualsMultiplicationOfMagnitude(unhandled, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfMagnitude(Unhandled unhandled) => EqualsMultiplicationOfMagnitude(unhandled, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfMagnitude(Unhandled unhandled) => EqualsMultiplicationOfMagnitude(unhandled, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfMagnitude(Unhandled unhandled) => EqualsMultiplicationOfMagnitude(unhandled, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfMagnitude(Unhandled unhandled) => EqualsMultiplicationOfMagnitude(unhandled, -1.5);

    [AssertionMethod]
    private static void EqualsMultiplicationOfMagnitude(Unhandled unhandled, Scalar factor)
    {
        Unhandled expected = new(unhandled.Magnitude * factor);
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }
}
