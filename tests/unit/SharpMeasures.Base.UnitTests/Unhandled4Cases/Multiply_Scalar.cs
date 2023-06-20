namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Multiply_Scalar
{
    private static Unhandled4 Target(Unhandled4 vector, Scalar factor) => vector.Multiply(factor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsMultiplicationOfComponents(Unhandled4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsMultiplicationOfComponents(Unhandled4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsMultiplicationOfComponents(Unhandled4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsMultiplicationOfComponents(Unhandled4 vector) => EqualsMultiplicationOfComponents(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsMultiplicationOfComponents(Unhandled4 vector) => EqualsMultiplicationOfComponents(vector, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsMultiplicationOfComponents(Unhandled4 vector) => EqualsMultiplicationOfComponents(vector, -1.5);

    [AssertionMethod]
    private static void EqualsMultiplicationOfComponents(Unhandled4 vector, Scalar factor)
    {
        Unhandled4 expected = new(vector.Components * factor);
        var actual = Target(vector, factor);

        Assert.Equal(expected, actual);
    }
}
