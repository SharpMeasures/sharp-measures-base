namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVector4Quantity_W
{
    private static Scalar Target(Vector4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.W;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector4W(Vector4 vector)
    {
        var expected = vector.W;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
