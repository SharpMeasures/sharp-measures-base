namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class AsIVector4Quantity_WithComponents_Scalars
{
    private static Vector4 Target(Scalar x, Scalar y, Scalar z, Scalar w)
    {
        return execute<Vector4>(x, y, z, w);

        static T execute<T>(Scalar x, Scalar y, Scalar z, Scalar w) where T : IVector4Quantity<T> => T.WithComponents(x, y, z, w);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector4_EqualsProvidedVector4(Vector4 vector)
    {
        var actual = Target(vector.X, vector.Y, vector.Z, vector.W);

        Assert.Equal(vector, actual);
    }
}
