namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class SquareRoot
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.SquareRoot();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeSquareRoot(Unhandled unhandled)
    {
        Unhandled expected = new(unhandled.Magnitude.SquareRoot());
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
