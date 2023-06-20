namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Negate
{
    private static Unhandled2 Target(Unhandled2 vector) => vector.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNegation(Unhandled2 vector)
    {
        Unhandled2 expected = new(vector.Components.Negate());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
