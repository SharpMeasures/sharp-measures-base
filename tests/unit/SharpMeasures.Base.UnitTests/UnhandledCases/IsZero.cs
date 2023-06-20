namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Unhandled unhandled) => unhandled.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsZero(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsZero;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
