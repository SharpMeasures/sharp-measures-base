namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Negate
{
    private static Unhandled3 Target(Unhandled3 vector) => vector.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNegation(Unhandled3 vector)
    {
        Unhandled3 expected = new(vector.Components.Negate());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
