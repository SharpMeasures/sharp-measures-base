namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsNegative
{
    private static bool Target(Unhandled unhandled) => unhandled.IsNegative;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsNegative(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsNegative;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
