namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Absolute
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.Absolute();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeAbsolute(Unhandled unhandled)
    {
        Unhandled expected = new(unhandled.Magnitude.Absolute());
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
