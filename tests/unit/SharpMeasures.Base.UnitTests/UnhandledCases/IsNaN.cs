namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Unhandled unhandled) => unhandled.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsNaN(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsNaN;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
