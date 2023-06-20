namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Square
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.Square();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeSquare(Unhandled unhandled)
    {
        Unhandled expected = new(unhandled.Magnitude.Square());
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
