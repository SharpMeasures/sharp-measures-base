namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Normalize
{
    private static Unhandled3 Target(Unhandled3 vector) => vector.Normalize();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNormalization(Unhandled3 vector)
    {
        Unhandled3 expected = new(vector.Components.Normalize());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
