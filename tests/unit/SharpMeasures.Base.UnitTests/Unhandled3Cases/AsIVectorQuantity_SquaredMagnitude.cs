namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class AsIVectorQuantity_SquaredMagnitude
{
    private static Scalar Target(Unhandled3 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.SquaredMagnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled3SquaredMagnitude(Unhandled3 vector)
    {
        var expected = vector.SquaredMagnitude().Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
