namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class DivideBy_Scalar
{
    private static Vector4 Target(Vector4 vector, Scalar divisor) => vector.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfComponents(Vector4 vector) => EqualsDivisionOfComponents(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfComponents(Vector4 vector) => EqualsDivisionOfComponents(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfComponents(Vector4 vector) => EqualsDivisionOfComponents(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfComponents(Vector4 vector) => EqualsDivisionOfComponents(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfComponents(Vector4 vector) => EqualsDivisionOfComponents(vector, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfComponents(Vector4 vector) => EqualsDivisionOfComponents(vector, -1.5);

    [AssertionMethod]
    private static void EqualsDivisionOfComponents(Vector4 vector, Scalar divisor)
    {
        Vector4 expected = (vector.X / divisor, vector.Y / divisor, vector.Z / divisor, vector.W / divisor);
        var actual = Target(vector, divisor);

        Assert.Equal(expected, actual);
    }
}
