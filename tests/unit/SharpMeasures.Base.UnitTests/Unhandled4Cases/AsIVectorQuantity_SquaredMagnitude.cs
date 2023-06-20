namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVectorQuantity_SquaredMagnitude
{
    private static Scalar Target(Unhandled4 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.SquaredMagnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled4SquaredMagnitude(Unhandled4 vector)
    {
        var expected = vector.SquaredMagnitude().Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
