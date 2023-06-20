namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Dot_Unhandled4_Vector4
{
    private static Unhandled Target(Unhandled4 a, Vector4 b) => Unhandled4.Dot(a, b);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsInstanceMethod(Unhandled4 a) => EqualsInstanceMethod(a, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsInstanceMethod(Unhandled4 a, Vector4 b)
    {
        var expected = a.Dot(b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
