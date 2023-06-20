namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Divide_Vector3_Scalar
{
    private static Vector3 Target(Vector3 a, Scalar b) => Vector3.Divide(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Vector3 a) => EqualsInstanceMethod(a, -1.5);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Vector3 a, Scalar b)
    {
        var expected = a.DivideBy(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
