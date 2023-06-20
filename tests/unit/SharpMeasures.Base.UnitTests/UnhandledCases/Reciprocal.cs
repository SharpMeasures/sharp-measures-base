namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Reciprocal
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.Reciprocal();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeReciprocal(Unhandled unhandled)
    {
        Unhandled expected = new(unhandled.Magnitude.Reciprocal());
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
