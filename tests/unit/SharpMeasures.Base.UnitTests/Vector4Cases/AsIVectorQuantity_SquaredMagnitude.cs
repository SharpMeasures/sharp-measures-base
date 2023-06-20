namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVectorQuantity_SquaredMagnitude
{
    private static Scalar Target(Vector4 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.SquaredMagnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector4SquaredMagnitude(Vector4 vector)
    {
        var expected = vector.SquaredMagnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
