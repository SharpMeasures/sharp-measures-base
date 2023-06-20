namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Remainder_Scalar
{
    private static Vector3 Target(Vector3 vector, Scalar divisor) => vector.Remainder(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfComponents(Vector3 vector) => EqualsRemainderOfComponents(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfComponents(Vector3 vector) => EqualsRemainderOfComponents(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfComponents(Vector3 vector) => EqualsRemainderOfComponents(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfComponents(Vector3 vector) => EqualsRemainderOfComponents(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfComponents(Vector3 vector) => EqualsRemainderOfComponents(vector, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfComponents(Vector3 vector) => EqualsRemainderOfComponents(vector, -1.5);

    [AssertionMethod]
    private static void EqualsRemainderOfComponents(Vector3 vector, Scalar divisor)
    {
        Vector3 expected = (vector.X % divisor, vector.Y % divisor, vector.Z % divisor);
        var actual = Target(vector, divisor);

        Assert.Equal(expected, actual);
    }
}
