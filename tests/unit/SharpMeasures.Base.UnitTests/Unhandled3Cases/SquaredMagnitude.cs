namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class SquaredMagnitude
{
    private static Unhandled Target(Unhandled3 vector) => vector.SquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfComponentsSquaredMagnitude(Unhandled3 vector)
    {
        Unhandled expected = new(vector.Components.SquaredMagnitude());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
