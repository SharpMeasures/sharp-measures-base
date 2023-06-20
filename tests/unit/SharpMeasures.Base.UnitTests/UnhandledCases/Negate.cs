namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Negate
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.Negate();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeNegation(Unhandled unhandled)
    {
        Unhandled expected = new(-unhandled.Magnitude);
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
