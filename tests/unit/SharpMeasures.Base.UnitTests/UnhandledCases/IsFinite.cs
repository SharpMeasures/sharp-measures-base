namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsFinite
{
    private static bool Target(Unhandled unhandled) => unhandled.IsFinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsFinite(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsFinite;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
