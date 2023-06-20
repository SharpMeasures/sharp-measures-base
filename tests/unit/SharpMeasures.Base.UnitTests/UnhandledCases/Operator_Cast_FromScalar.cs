namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Cast_FromScalar
{
    private static Unhandled Target(Scalar value) => (Unhandled)value;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudeOfProvidedUnhandled_EqualsProvidedUnhandled(Unhandled unhandled)
    {
        var actual = Target(unhandled.Magnitude);

        Assert.Equal(unhandled, actual);
    }
}
