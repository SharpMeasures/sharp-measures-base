namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Plus
{
    private static Unhandled Target(Unhandled unhandled) => unhandled.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedUnhandled(Unhandled unhandled)
    {
        var actual = Target(unhandled);

        Assert.Equal(unhandled, actual);
    }
}
