namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Operator_Subtract_Unhandled3_Unhandled3
{
    private static Unhandled3 Target(Unhandled3 a, Unhandled3 b) => a - b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Unhandled3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsMethod(Unhandled3 b) => EqualsMethod(Unhandled3.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.NaN * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsMethod(Unhandled3 b) => EqualsMethod(Scalar.NaN * new Unhandled3(1, 1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.PositiveInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsMethod(Unhandled3 b) => EqualsMethod(Scalar.PositiveInfinity * new Unhandled3(1, 1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsMethod(Unhandled3 a) => EqualsMethod(a, Scalar.NegativeInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsMethod(Unhandled3 b) => EqualsMethod(Scalar.NegativeInfinity * new Unhandled3(1, 1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsMethod(Unhandled3 a) => EqualsMethod(a, new(1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsMethod(Unhandled3 b) => EqualsMethod(new(1.5, 4.5, 7.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsMethod(Unhandled3 a) => EqualsMethod(a, new(-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsMethod(Unhandled3 b) => EqualsMethod(new(-1.5, -4.5, -7.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled3 a, Unhandled3 b)
    {
        var expected = Unhandled3.Subtract(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
