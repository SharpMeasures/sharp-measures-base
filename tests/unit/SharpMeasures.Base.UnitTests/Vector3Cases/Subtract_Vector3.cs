namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Subtract_Vector3
{
    private static Vector3 Target(Vector3 vector, Vector3 subtrahend) => vector.Subtract(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsSubtractionOfComponents(Vector3 vector) => EqualsSubtractionOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsSubtractionOfComponents(Vector3 vector) => EqualsSubtractionOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsSubtractionOfComponents(Vector3 vector) => EqualsSubtractionOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsSubtractionOfComponents(Vector3 vector) => EqualsSubtractionOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsSubtractionOfComponents(Vector3 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsSubtractionOfComponents(Vector3 vector) => EqualsSubtractionOfComponents(vector, (-1.5, -4.5, -7.5));

    [AssertionMethod]
    private static void EqualsSubtractionOfComponents(Vector3 vector, Vector3 subtrahend)
    {
        Vector3 expected = (vector.X - subtrahend.X, vector.Y - subtrahend.Y, vector.Z - subtrahend.Z);
        var actual = Target(vector, subtrahend);

        Assert.Equal(expected, actual);
    }
}
