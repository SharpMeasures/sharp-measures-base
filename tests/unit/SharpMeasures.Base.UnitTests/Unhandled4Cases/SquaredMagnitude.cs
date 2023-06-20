namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class SquaredMagnitude
{
    private static Unhandled Target(Unhandled4 vector) => vector.SquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfComponentsSquaredMagnitude(Unhandled4 vector)
    {
        Unhandled expected = new(vector.Components.SquaredMagnitude());
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
