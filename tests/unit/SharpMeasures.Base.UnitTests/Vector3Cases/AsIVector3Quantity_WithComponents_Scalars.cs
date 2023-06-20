namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class AsIVector3Quantity_WithComponents_Scalars
{
    private static Vector3 Target(Scalar x, Scalar y, Scalar z)
    {
        return execute<Vector3>(x, y, z);

        static T execute<T>(Scalar x, Scalar y, Scalar z) where T : IVector3Quantity<T> => T.WithComponents(x, y, z);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector3_EqualsProvidedVector3(Vector3 vector)
    {
        var actual = Target(vector.X, vector.Y, vector.Z);

        Assert.Equal(vector, actual);
    }
}
