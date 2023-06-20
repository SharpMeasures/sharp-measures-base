namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class AsIVector2Quantity_Y
{
    private static Scalar Target(Unhandled2 vector)
    {
        return execute(vector);

        static Scalar execute(IVector2Quantity quantity) => quantity.Y;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled2Y(Unhandled2 vector)
    {
        var expected = vector.Y.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
