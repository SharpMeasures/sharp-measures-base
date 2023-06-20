namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Magnitude
{
    private static Unhandled Target(Unhandled4 vector) => vector.Magnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfComponentsMagnitude(Unhandled4 vector)
    {
        Unhandled expected = new(vector.Components.Magnitude());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
