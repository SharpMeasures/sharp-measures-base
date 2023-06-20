namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Equals_Unhandled4
{
    private static bool Target(Unhandled4 vector, Unhandled4 other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsEquals(Unhandled4 vector) => EqualsComponentsEquals(vector, Unhandled4.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsEquals(Unhandled4 vector) => EqualsComponentsEquals(vector, Scalar.NaN * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsEquals(Unhandled4 vector) => EqualsComponentsEquals(vector, Scalar.PositiveInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsEquals(Unhandled4 vector) => EqualsComponentsEquals(vector, Scalar.NegativeInfinity * new Unhandled4(1, 1, 1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsEquals(Unhandled4 vector) => EqualsComponentsEquals(vector, new(1.5, 4.5, 7.5, 10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsEquals(Unhandled4 vector) => EqualsComponentsEquals(vector, new(-1.5, -4.5, -7.5, -10.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled4s_EqualsComponentsEquals(Unhandled4 vector) => EqualsComponentsEquals(vector, vector);

    [AssertionMethod]
    private static void EqualsComponentsEquals(Unhandled4 vector, Unhandled4 other)
    {
        var expected = vector.Components.Equals(other.Components);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
