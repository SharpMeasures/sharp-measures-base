namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Operator_Add_Vector2_Vector2
{
    private static Vector2 Target(Vector2 a, Vector2 b) => a + b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsMethod(Vector2 a) => EqualsMethod(a, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsMethod(Vector2 b) => EqualsMethod(Vector2.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsMethod(Vector2 a) => EqualsMethod(a, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsMethod(Vector2 b) => EqualsMethod(Scalar.NaN * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsMethod(Vector2 a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsMethod(Vector2 b) => EqualsMethod(Scalar.PositiveInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsMethod(Vector2 a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsMethod(Vector2 b) => EqualsMethod(Scalar.NegativeInfinity * Vector2.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsMethod(Vector2 a) => EqualsMethod(a, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsMethod(Vector2 b) => EqualsMethod((1.5, 4.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsMethod(Vector2 a) => EqualsMethod(a, (-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsMethod(Vector2 b) => EqualsMethod((-1.5, -4.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Vector2 a, Vector2 b)
    {
        var expected = Vector2.Add(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
