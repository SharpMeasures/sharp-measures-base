namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Constructor_Scalar
{
    private static Unhandled Target(Scalar value) => new(value);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudeOfProvidedUnhandled_EqualsProvidedUnhandled(Unhandled unhandled)
    {
        var actual = Target(unhandled.Magnitude);

        Assert.Equal(unhandled, actual);
    }
}
