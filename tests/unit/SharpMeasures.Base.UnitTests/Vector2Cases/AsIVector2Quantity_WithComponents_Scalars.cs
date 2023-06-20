namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class AsIVector2Quantity_WithComponents_Scalars
{
    private static Vector2 Target(Scalar x, Scalar y)
    {
        return execute<Vector2>(x, y);

        static T execute<T>(Scalar x, Scalar y) where T : IVector2Quantity<T> => T.WithComponents(x, y);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedVector2_EqualsProvidedVector2(Vector2 vector)
    {
        var actual = Target(vector.X, vector.Y);

        Assert.Equal(vector, actual);
    }
}
