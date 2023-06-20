namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Operator_Add_Unhandled2_Unhandled2
{
    private static Unhandled2 Target(Unhandled2 a, Unhandled2 b) => a + b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsMethod(Unhandled2 b) => EqualsMethod(Unhandled2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Scalar.NaN * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsMethod(Unhandled2 b) => EqualsMethod(Scalar.NaN * new Unhandled2(1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Scalar.PositiveInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsMethod(Unhandled2 b) => EqualsMethod(Scalar.PositiveInfinity * new Unhandled2(1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsMethod(Unhandled2 a) => EqualsMethod(a, Scalar.NegativeInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsMethod(Unhandled2 b) => EqualsMethod(Scalar.NegativeInfinity * new Unhandled2(1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsMethod(Unhandled2 a) => EqualsMethod(a, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsMethod(Unhandled2 b) => EqualsMethod(new(1.5, 4.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsMethod(Unhandled2 a) => EqualsMethod(a, new(-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsMethod(Unhandled2 b) => EqualsMethod(new(-1.5, -4.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled2 a, Unhandled2 b)
    {
        var expected = Unhandled2.Add(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
