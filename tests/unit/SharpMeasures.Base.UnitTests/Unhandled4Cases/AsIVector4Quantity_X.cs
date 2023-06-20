namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVector4Quantity_X
{
    private static Scalar Target(Unhandled4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.X;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled4X(Unhandled4 vector)
    {
        var expected = vector.X.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
