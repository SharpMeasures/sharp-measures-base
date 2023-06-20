namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVectorQuantity_Magnitude
{
    private static Scalar Target(Vector4 vector)
    {
        return execute(vector);

        static Scalar execute(IVectorQuantity quantity) => quantity.Magnitude();
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector4Magnitude(Vector4 vector)
    {
        var expected = vector.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
