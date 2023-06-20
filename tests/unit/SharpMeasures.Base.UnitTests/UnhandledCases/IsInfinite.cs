namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class IsInfinite
{
    private static bool Target(Unhandled unhandled) => unhandled.IsInfinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeIsInfinite(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude.IsInfinite;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
