namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Equals_Unhandled3
{
    private static bool Target(Unhandled3 vector, Unhandled3 other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsEquals(Unhandled3 vector) => EqualsComponentsEquals(vector, Unhandled3.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsEquals(Unhandled3 vector) => EqualsComponentsEquals(vector, Scalar.NaN * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsEquals(Unhandled3 vector) => EqualsComponentsEquals(vector, Scalar.PositiveInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsEquals(Unhandled3 vector) => EqualsComponentsEquals(vector, Scalar.NegativeInfinity * new Unhandled3(1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsEquals(Unhandled3 vector) => EqualsComponentsEquals(vector, new(1.5, 4.5, 7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsEquals(Unhandled3 vector) => EqualsComponentsEquals(vector, new(-1.5, -4.5, -7.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled3s_EqualsComponentsEquals(Unhandled3 vector) => EqualsComponentsEquals(vector, vector);

    [AssertionMethod]
    private static void EqualsComponentsEquals(Unhandled3 vector, Unhandled3 other)
    {
        var expected = vector.Components.Equals(other.Components);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
