namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVector4Quantity_Y
{
    private static Scalar Target(Unhandled4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.Y;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled4Y(Unhandled4 vector)
    {
        var expected = vector.Y.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
