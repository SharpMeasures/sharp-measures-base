namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsPositive
{
    private static bool Target(Unhandled unhandled) => unhandled.IsPositive;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsPositive(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsPositive;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
