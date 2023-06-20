namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Multiply_Unhandled_Vector2
{
    private static Unhandled2 Target(Unhandled a, Vector2 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled a) => EqualsMethod(a, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled a) => EqualsMethod(a, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled a) => EqualsMethod(a, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled a) => EqualsMethod(a, (-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsMethod(Unhandled a, Vector2 b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
