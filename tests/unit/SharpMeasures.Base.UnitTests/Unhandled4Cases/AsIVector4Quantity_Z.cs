namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVector4Quantity_Z
{
    private static Scalar Target(Unhandled4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.Z;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled4Z(Unhandled4 vector)
    {
        var expected = vector.Z.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
