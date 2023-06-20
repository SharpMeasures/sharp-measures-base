namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class NaN
{
    public static Unhandled Target() => Unhandled.NaN;

    [Fact]
    public void MagnitudeIsNaN()
    {
        var actual = Target().Magnitude.IsNaN;

        Assert.True(actual);
    }
}
