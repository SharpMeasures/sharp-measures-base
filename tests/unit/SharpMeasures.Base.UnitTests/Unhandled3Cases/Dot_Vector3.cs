namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Dot_Vector3
{
    private static Unhandled Target(Unhandled3 vector, Vector3 factor) => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Vector3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NaN * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.PositiveInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NegativeInfinity * Vector3.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMagnitudeOfDotProductOfComponents(Unhandled3 vector, Vector3 factor)
    {
        Unhandled expected = new(vector.Components.Dot(factor));
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
