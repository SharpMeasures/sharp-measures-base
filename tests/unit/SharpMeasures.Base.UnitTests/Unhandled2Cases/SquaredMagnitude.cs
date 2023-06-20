namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class SquaredMagnitude
{
    private static Unhandled Target(Unhandled2 vector) => vector.SquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfComponentsSquaredMagnitude(Unhandled2 vector)
    {
        Unhandled expected = new(vector.Components.SquaredMagnitude());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
