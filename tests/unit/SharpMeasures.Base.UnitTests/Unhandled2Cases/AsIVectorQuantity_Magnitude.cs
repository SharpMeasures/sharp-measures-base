namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class AsIVectorQuantity_Magnitude
{
    private static Scalar Target(Unhandled2 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.Magnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled2Magnitude(Unhandled2 vector)
    {
        var expected = vector.Magnitude().Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
