namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Equals_Unhandled2
{
    private static bool Target(Unhandled2 vector, Unhandled2 other) => vector.Equals(other);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Zero_EqualsComponentsEquals(Unhandled2 vector) => EqualsComponentsEquals(vector, Unhandled2.Zero);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NaN_EqualsComponentsEquals(Unhandled2 vector) => EqualsComponentsEquals(vector, Scalar.NaN * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void PositiveInfinity_EqualsComponentsEquals(Unhandled2 vector) => EqualsComponentsEquals(vector, Scalar.PositiveInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void NegativeInfinity_EqualsComponentsEquals(Unhandled2 vector) => EqualsComponentsEquals(vector, Scalar.NegativeInfinity * new Unhandled2(1, 1));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Positive_EqualsComponentsEquals(Unhandled2 vector) => EqualsComponentsEquals(vector, new(1.5, 4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void Negative_EqualsComponentsEquals(Unhandled2 vector) => EqualsComponentsEquals(vector, new(-1.5, -4.5));

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualUnhandled2s_EqualsComponentsEquals(Unhandled2 vector) => EqualsComponentsEquals(vector, vector);

    [AssertionMethod]
    private static void EqualsComponentsEquals(Unhandled2 vector, Unhandled2 other)
    {
        var expected = vector.Components.Equals(other.Components);
        var actual = Target(vector, other);

        Assert.Equal(expected, actual);
    }
}
