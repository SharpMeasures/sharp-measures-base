namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class AsIVector3Quantity_X
{
    private static Scalar Target(Unhandled3 vector)
    {
        return execute(vector);

        static Scalar execute(IVector3Quantity quantity) => quantity.X;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled3X(Unhandled3 vector)
    {
        var expected = vector.X.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
