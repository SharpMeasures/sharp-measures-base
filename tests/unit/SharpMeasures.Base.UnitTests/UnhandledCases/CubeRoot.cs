namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class CubeRoot
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.CubeRoot();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeCubeRoot(Unhandled unhandled)
    {
        Unhandled expected = new(unhandled.Magnitude.CubeRoot());
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
