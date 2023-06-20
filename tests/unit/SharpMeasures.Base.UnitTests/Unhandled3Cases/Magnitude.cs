namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Magnitude
{
    private static Unhandled Target(Unhandled3 vector) => vector.Magnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfComponentsMagnitude(Unhandled3 vector)
    {
        Unhandled expected = new(vector.Components.Magnitude());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
