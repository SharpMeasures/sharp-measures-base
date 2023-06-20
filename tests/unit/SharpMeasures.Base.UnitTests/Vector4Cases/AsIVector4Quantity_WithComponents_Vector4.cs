namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVector4Quantity_WithComponents_Vector4
{
    private static Vector4 Target(Vector4 components)
    {
        return execute<Vector4>(components);

        static T execute<T>(Vector4 components) where T : IVector4Quantity<T> => T.WithComponents(components);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ProvidedVector4_EqualsProvidedVector4(Vector4 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
