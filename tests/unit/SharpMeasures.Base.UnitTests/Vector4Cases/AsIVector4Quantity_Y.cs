namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVector4Quantity_Y
{
    private static Scalar Target(Vector4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.Y;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector4Y(Vector4 vector)
    {
        var expected = vector.Y;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
