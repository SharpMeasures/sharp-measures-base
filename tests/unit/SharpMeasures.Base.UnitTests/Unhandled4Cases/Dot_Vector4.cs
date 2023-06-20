namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Dot_Vector4
{
    private static Unhandled Target(Unhandled4 vector, Vector4 factor) => vector.Dot(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Vector4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NaN * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.PositiveInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, Scalar.NegativeInfinity * Vector4.Ones);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.One);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector) => EqualsMagnitudeOfDotProductOfComponents(vector, (1.5, 4.5, 7.5, 10.5) * Scalar.NegativeOne);

    [AssertionMethod]
    private static void EqualsMagnitudeOfDotProductOfComponents(Unhandled4 vector, Vector4 factor)
    {
        Unhandled expected = new(vector.Components.Dot(factor));
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
