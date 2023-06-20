namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class AsIVector3Quantity_Y
{
    private static Scalar Target(Unhandled3 vector)
    {
        return execute(vector);

        static Scalar execute(IVector3Quantity quantity) => quantity.Y;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled3Y(Unhandled3 vector)
    {
        var expected = vector.Y.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
