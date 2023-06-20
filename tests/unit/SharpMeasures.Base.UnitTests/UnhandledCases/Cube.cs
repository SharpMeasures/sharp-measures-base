namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Cube
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.Cube();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeCube(Unhandled unhandled)
    {
        Unhandled expected = new(unhandled.Magnitude.Cube());
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
