namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Zero
{
    public static Unhandled Target() => Unhandled.Zero;

    [Fact]
    public void MagnitudeIsZero()
    {
        var actual = Target().Magnitude.IsZero;

        Assert.True(actual);
    }
}
