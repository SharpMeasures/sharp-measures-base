namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Operator_Add_Unhandled4_Unhandled4
{
    private static Unhandled4 Target(Unhandled4 a, Unhandled4 b) => a + b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsMethod(Unhandled4 b) => EqualsMethod(Unhandled4.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.NaN * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.NaN * new Unhandled4(1, 1, 1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsMethod(Unhandled4 a) => EqualsMethod(a, Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsMethod(Unhandled4 b) => EqualsMethod(Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsMethod(Unhandled4 a) => EqualsMethod(a, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsMethod(Unhandled4 b) => EqualsMethod(new(1.5, 4.5, 7.5, 10.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsMethod(Unhandled4 a) => EqualsMethod(a, new(-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsMethod(Unhandled4 b) => EqualsMethod(new(-1.5, -4.5, -7.5, -10.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Unhandled4 a, Unhandled4 b)
    {
        var expected = Unhandled4.Add(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
