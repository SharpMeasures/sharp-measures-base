namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVector4Quantity_W
{
    private static Scalar Target(Unhandled4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.W;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled4W(Unhandled4 vector)
    {
        var expected = vector.W.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
