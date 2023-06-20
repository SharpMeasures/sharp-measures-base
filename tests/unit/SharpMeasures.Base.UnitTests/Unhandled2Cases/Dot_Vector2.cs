namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Dot_Vector2
{
    private static Unhandled Target(Unhandled2 vector, Vector2 factor) => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Vector2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NaN * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.PositiveInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NegativeInfinity * Vector2.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMagnitudeOfDotProductOfComponents(Unhandled2 vector, Vector2 factor)
    {
        Unhandled expected = new(vector.Components.Dot(factor));
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
