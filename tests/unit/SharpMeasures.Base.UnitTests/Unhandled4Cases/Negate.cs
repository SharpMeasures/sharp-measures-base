namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Negate
{
    private static Unhandled4 Target(Unhandled4 vector) => vector.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNegation(Unhandled4 vector)
    {
        Unhandled4 expected = new(vector.Components.Negate());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
