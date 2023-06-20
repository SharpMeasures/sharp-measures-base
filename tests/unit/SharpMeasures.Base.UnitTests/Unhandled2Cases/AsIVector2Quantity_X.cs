namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class AsIVector2Quantity_X
{
    private static Scalar Target(Unhandled2 vector)
    {
        return execute(vector);

        static Scalar execute(IVector2Quantity quantity) => quantity.X;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled2X(Unhandled2 vector)
    {
        var expected = vector.X.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
