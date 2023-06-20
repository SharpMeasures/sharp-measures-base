namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class PositiveInfinity
{
    public static Unhandled Target() => Unhandled.PositiveInfinity;

    [Fact]
    public void MagnitudeIsPositiveInfinityInfinity()
    {
        var actual = Target().Magnitude.IsPositiveInfinity;

        Assert.True(actual);
    }
}
