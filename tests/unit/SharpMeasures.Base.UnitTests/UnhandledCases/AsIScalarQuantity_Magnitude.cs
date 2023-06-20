namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class AsIScalarQuantity_Magnitude
{
    private static Scalar Target(Unhandled unhandled)
    {
        return execute(unhandled);

        static Scalar execute(IScalarQuantity quantity) => quantity.Magnitude;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsUnhandledMagnitude(Unhandled unhandled)
    {
        var expected = unhandled.Magnitude;
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
