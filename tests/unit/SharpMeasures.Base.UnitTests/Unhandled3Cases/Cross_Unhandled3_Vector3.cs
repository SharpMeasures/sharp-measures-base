namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Cross_Unhandled3_Vector3
{
    private static Unhandled3 Target(Unhandled3 a, Vector3 b) => Unhandled3.Cross(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled3 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled3 a, Vector3 b)
    {
        var expected = a.Cross(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
