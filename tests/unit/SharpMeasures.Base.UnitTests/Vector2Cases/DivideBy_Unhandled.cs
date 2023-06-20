namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class DivideBy_Unhandled
{
    private static Unhandled2 Target(Vector2 vector, Unhandled divisor) => vector.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfComponents(Vector2 vector) => EqualsDivisionOfComponents(vector, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfComponents(Vector2 vector) => EqualsDivisionOfComponents(vector, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfComponents(Vector2 vector) => EqualsDivisionOfComponents(vector, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfComponents(Vector2 vector) => EqualsDivisionOfComponents(vector, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfComponents(Vector2 vector) => EqualsDivisionOfComponents(vector, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfComponents(Vector2 vector) => EqualsDivisionOfComponents(vector, new(-1.5));

    [AssertionMethod]
    private static void EqualsDivisionOfComponents(Vector2 vector, Unhandled divisor)
    {
        Unhandled2 expected = (vector.X / divisor, vector.Y / divisor);
        var actual = Target(vector, divisor);

        Assert.Equal(expected, actual);
    }
}
