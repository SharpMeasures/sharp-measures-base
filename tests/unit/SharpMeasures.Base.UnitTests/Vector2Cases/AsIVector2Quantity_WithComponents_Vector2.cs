namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class AsIVector2Quantity_WithComponents_Vector2
{
    private static Vector2 Target(Vector2 components)
    {
        return execute<Vector2>(components);

        static T execute<T>(Vector2 components) where T : IVector2Quantity<T> => T.WithComponents(components);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ProvidedVector2_EqualsProvidedVector2(Vector2 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
