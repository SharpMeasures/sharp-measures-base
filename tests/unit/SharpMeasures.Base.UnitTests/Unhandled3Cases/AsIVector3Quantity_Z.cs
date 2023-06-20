namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class AsIVector3Quantity_Z
{
    private static Scalar Target(Unhandled3 vector)
    {
        return execute(vector);

        static Scalar execute(IVector3Quantity quantity) => quantity.Z;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsMagnitudeOfUnhandled3Z(Unhandled3 vector)
    {
        var expected = vector.Z.Magnitude;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
