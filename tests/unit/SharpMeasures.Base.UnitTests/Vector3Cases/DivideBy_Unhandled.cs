namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class DivideBy_Unhandled
{
    private static Unhandled3 Target(Vector3 vector, Unhandled divisor) => vector.DivideBy(divisor);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsDivisionOfComponents(Vector3 vector) => EqualsDivisionOfComponents(vector, Unhandled.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsDivisionOfComponents(Vector3 vector) => EqualsDivisionOfComponents(vector, Unhandled.NaN);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsDivisionOfComponents(Vector3 vector) => EqualsDivisionOfComponents(vector, Unhandled.PositiveInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsDivisionOfComponents(Vector3 vector) => EqualsDivisionOfComponents(vector, Unhandled.NegativeInfinity);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsDivisionOfComponents(Vector3 vector) => EqualsDivisionOfComponents(vector, new(1.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsDivisionOfComponents(Vector3 vector) => EqualsDivisionOfComponents(vector, new(-1.5));

    [AssertionMethod]
    private static void EqualsDivisionOfComponents(Vector3 vector, Unhandled divisor)
    {
        Unhandled3 expected = (vector.X / divisor, vector.Y / divisor, vector.Z / divisor);
        var actual = Target(vector, divisor);

        Assert.Equal(expected, actual);
    }
}
