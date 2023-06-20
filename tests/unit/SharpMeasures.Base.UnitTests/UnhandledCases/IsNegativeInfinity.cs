namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsNegativeInfinity
{
    private static bool Target(Unhandled unhandled) => unhandled.IsNegativeInfinity;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsNegativeInfinity(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsNegativeInfinity;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
