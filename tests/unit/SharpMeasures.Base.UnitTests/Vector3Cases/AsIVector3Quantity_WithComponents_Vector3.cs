namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class AsIVector3Quantity_WithComponents_Vector3
{
    private static Vector3 Target(Vector3 components)
    {
        return execute<Vector3>(components);

        static T execute<T>(Vector3 components) where T : IVector3Quantity<T> => T.WithComponents(components);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ProvidedVector3_EqualsProvidedVector3(Vector3 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
