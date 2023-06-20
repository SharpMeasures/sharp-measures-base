namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Multiply_Vector3
{
    private static Unhandled3 Target(Unhandled unhandled, Vector3 factor) => unhandled.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationByMagnitude(Unhandled unhandled) => EqualsMultiplicationByMagnitude(unhandled, (-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsMultiplicationByMagnitude(Unhandled unhandled, Vector3 factor)
    {
        Unhandled3 expected = new(unhandled.Magnitude.Multiply(factor));
        var actual = Target(unhandled, factor);

        Assert.Equal(expected, actual);
    }
}
