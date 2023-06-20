namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Operator_Divide_Vector4_Unhandled
{
    private static Unhandled4 Target(Vector4 a, Unhandled b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Vector4 a) => EqualsMethod(a, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Vector4 a) => EqualsMethod(a, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Vector4 a) => EqualsMethod(a, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Vector4 a) => EqualsMethod(a, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Vector4 a) => EqualsMethod(a, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Vector4 a) => EqualsMethod(a, new(-1.5));

    [AssertionMethod]
    private static void EqualsMethod(Vector4 a, Unhandled b)
    {
        var expected = Vector4.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
