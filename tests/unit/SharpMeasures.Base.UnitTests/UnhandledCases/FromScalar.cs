namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class FromScalar
{
    private static Unhandled Target(Scalar value) => Unhandled.FromScalar(value);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudeOfProvidedUnhandled_EqualsProvidedUnhandled(Unhandled unhandled)
    {
        var actual = Target(unhandled.Magnitude);

        Assert.Equal(unhandled, actual);
    }
}
