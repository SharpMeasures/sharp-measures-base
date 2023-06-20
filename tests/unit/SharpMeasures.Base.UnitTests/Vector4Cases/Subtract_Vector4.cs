namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Subtract_Vector4
{
    private static Vector4 Target(Vector4 vector, Vector4 subtrahend) => vector.Subtract(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsSubtractionOfComponents(Vector4 vector) => EqualsSubtractionOfComponents(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsSubtractionOfComponents(Vector4 vector) => EqualsSubtractionOfComponents(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsSubtractionOfComponents(Vector4 vector) => EqualsSubtractionOfComponents(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsSubtractionOfComponents(Vector4 vector) => EqualsSubtractionOfComponents(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsSubtractionOfComponents(Vector4 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsSubtractionOfComponents(Vector4 vector) => EqualsSubtractionOfComponents(vector, (-1.5, -4.5, -7.5, -10.5));

    [AssertionMethod]
    private static void EqualsSubtractionOfComponents(Vector4 vector, Vector4 subtrahend)
    {
        Vector4 expected = (vector.X - subtrahend.X, vector.Y - subtrahend.Y, vector.Z - subtrahend.Z, vector.W - subtrahend.W);
        var actual = Target(vector, subtrahend);

        Assert.Equal(expected, actual);
    }
}
