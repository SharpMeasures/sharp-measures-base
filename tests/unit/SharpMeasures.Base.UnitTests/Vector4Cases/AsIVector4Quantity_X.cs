namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVector4Quantity_X
{
    private static Scalar Target(Vector4 vector)
    {
        return execute(vector);

        static Scalar execute(IVector4Quantity quantity) => quantity.X;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsVector4X(Vector4 vector)
    {
        var expected = vector.X;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
