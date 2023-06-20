namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVector4Quantity_Components
{
    private static Vector4 Target(Vector4 vector)
    {
        return execute(vector);

        static Vector4 execute(IVector4Quantity quantity) => quantity.Components;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedVector4(Vector4 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
