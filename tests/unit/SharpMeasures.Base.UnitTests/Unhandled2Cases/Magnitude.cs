namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Magnitude
{
    private static Unhandled Target(Unhandled2 vector) => vector.Magnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfComponentsMagnitude(Unhandled2 vector)
    {
        Unhandled expected = new(vector.Components.Magnitude());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
