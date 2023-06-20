namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class ToScalar
{
    private static Scalar Target(Unhandled unhandled) => (Scalar)unhandled;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitude(Unhandled unhandled)
    {
        var actual = Target(unhandled);

        Assert.Equal(unhandled.Magnitude, actual);
    }
}
