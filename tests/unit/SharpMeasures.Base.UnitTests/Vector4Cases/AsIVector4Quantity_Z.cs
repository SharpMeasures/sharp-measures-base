namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVector4Quantity_Z
{
    private static Scalar Target(Vector4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.Z;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector4Z(Vector4 vector)
    {
        var expected = vector.Z;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
