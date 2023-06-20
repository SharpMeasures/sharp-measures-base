namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class DivideBy_Scalar
{
    private static Unhandled4 Target(Unhandled4 vector, Scalar divisor) => vector.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisonOfComponents(Unhandled4 vector) => EqualsDivisonOfComponents(vector, Scalar.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisonOfComponents(Unhandled4 vector) => EqualsDivisonOfComponents(vector, Scalar.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisonOfComponents(Unhandled4 vector) => EqualsDivisonOfComponents(vector, Scalar.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisonOfComponents(Unhandled4 vector) => EqualsDivisonOfComponents(vector, Scalar.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisonOfComponents(Unhandled4 vector) => EqualsDivisonOfComponents(vector, 1.5);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisonOfComponents(Unhandled4 vector) => EqualsDivisonOfComponents(vector, -1.5);

    [AssertionMethod]
    private static void EqualsDivisonOfComponents(Unhandled4 vector, Scalar divisor)
    {
        Unhandled4 expected = new(vector.Components / divisor);
        var actual = Target(vector, divisor);

        Assert.Equal(expected, actual);
    }
}
