namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Operator_Divide_Vector3_Unhandled
{
    private static Unhandled3 Target(Vector3 a, Unhandled b) => a / b;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMethod(Vector3 a) => EqualsMethod(a, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMethod(Vector3 a) => EqualsMethod(a, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMethod(Vector3 a) => EqualsMethod(a, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMethod(Vector3 a) => EqualsMethod(a, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMethod(Vector3 a) => EqualsMethod(a, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMethod(Vector3 a) => EqualsMethod(a, new(-1.5));

    [AssertionMethod]
    private static void EqualsMethod(Vector3 a, Unhandled b)
    {
        var expected = Vector3.Divide(a, b);
        var actual = Target(a, b);

        Assert.Equal(expected, actual);
    }
}
