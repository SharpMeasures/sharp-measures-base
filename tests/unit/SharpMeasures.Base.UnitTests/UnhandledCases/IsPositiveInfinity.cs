namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsPositiveInfinity
{
    private static bool Target(Unhandled unhandled) => unhandled.IsPositiveInfinity;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsPositiveInfinity(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsPositiveInfinity;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
