namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Normalize
{
    private static Unhandled4 Target(Unhandled4 vector) => vector.Normalize();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsNormalization(Unhandled4 vector)
    {
        Unhandled4 expected = new(vector.Components.Normalize());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
