namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Normalize
{
    private static Unhandled2 Target(Unhandled2 vector) => vector.Normalize();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNormalization(Unhandled2 vector)
    {
        Unhandled2 expected = new(vector.Components.Normalize());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
