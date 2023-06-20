namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class NegativeInfinity
{
    public static Unhandled Target() => Unhandled.NegativeInfinity;

    [Fact]
    public void MagnitudeIsNegativeInfinity()
    {
        var actual = Target().Magnitude.IsNegativeInfinity;

        Assert.True(actual);
    }
}
