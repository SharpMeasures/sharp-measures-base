namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Multiply_Unhandled_Vector3
{
    private static Unhandled3 Target(Unhandled a, Vector3 b) => a * b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Unhandled a) => EqualsMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Unhandled a) => EqualsMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Unhandled a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Unhandled a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Unhandled a) => EqualsMethod(a, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Unhandled a) => EqualsMethod(a, (-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsMethod(Unhandled a, Vector3 b)
    {
        var expected = a.Multiply(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
