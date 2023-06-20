namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class AsIVector2Quantity_WithComponents_Vector2
{
    private static Unhandled2 Target(Vector2 components)
    {
        return execute<Unhandled2>(components);

        static T execute<T>(Vector2 components) where T : IVector2Quantity<T> => T.WithComponents(components);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled2_EqualsProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target(vector.Components);

        Assert.Equal(vector, actual);
    }
}
