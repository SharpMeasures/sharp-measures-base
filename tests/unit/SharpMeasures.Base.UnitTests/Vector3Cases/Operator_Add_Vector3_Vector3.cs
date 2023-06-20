namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Operator_Add_Vector3_Vector3
{
    private static Vector3 Target(Vector3 a, Vector3 b) => a + b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Zero_EqualsMethod(Vector3 a) => EqualsMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Zero_EqualsMethod(Vector3 b) => EqualsMethod(Vector3.Zero, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NaN_EqualsMethod(Vector3 a) => EqualsMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NaN_EqualsMethod(Vector3 b) => EqualsMethod(Scalar.NaN * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_PositiveInfinity_EqualsMethod(Vector3 a) => EqualsMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_PositiveInfinity_EqualsMethod(Vector3 b) => EqualsMethod(Scalar.PositiveInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_NegativeInfinity_EqualsMethod(Vector3 a) => EqualsMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_NegativeInfinity_EqualsMethod(Vector3 b) => EqualsMethod(Scalar.NegativeInfinity * Vector3.Ones, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Positive_EqualsMethod(Vector3 a) => EqualsMethod(a, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Positive_EqualsMethod(Vector3 b) => EqualsMethod((1.5, 4.5, 7.5), b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void A_Negative_EqualsMethod(Vector3 a) => EqualsMethod(a, (-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void B_Negative_EqualsMethod(Vector3 b) => EqualsMethod((-1.5, -4.5, -7.5), b);

    [AssertionMethod]
    private static void EqualsMethod(Vector3 a, Vector3 b)
    {
        var expected = Vector3.Add(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
