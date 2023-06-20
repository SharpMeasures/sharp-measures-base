namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVectorQuantity_Magnitude
{
    private static Scalar Target(Unhandled4 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.Magnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled4Magnitude(Unhandled4 vector)
    {
        var expected = vector.Magnitude().Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
