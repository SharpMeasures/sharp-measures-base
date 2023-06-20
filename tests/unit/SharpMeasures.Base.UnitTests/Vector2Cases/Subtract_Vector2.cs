namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Subtract_Vector2
{
    private static Vector2 Target(Vector2 vector, Vector2 subtrahend) => vector.Subtract(subtrahend);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsSubtractionOfComponents(Vector2 vector) => EqualsSubtractionOfComponents(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsSubtractionOfComponents(Vector2 vector) => EqualsSubtractionOfComponents(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsSubtractionOfComponents(Vector2 vector) => EqualsSubtractionOfComponents(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsSubtractionOfComponents(Vector2 vector) => EqualsSubtractionOfComponents(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsSubtractionOfComponents(Vector2 vector) => EqualsSubtractionOfComponents(vector, (1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsSubtractionOfComponents(Vector2 vector) => EqualsSubtractionOfComponents(vector, (-1.5, -4.5));

    [AssertionMethod]
    private static void EqualsSubtractionOfComponents(Vector2 vector, Vector2 subtrahend)
    {
        Vector2 expected = (vector.X - subtrahend.X, vector.Y - subtrahend.Y);
        var actual = Target(vector, subtrahend);

        Assert.Equal(expected, actual);
    }
}
