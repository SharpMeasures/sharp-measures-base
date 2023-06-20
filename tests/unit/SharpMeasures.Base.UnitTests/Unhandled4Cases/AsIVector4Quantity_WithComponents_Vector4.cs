namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVector4Quantity_WithComponents_Vector4
{
    private static Unhandled4 Target(Vector4 components)
    {
        return execute<Unhandled4>(components);

        static T execute<T>(Vector4 components) where T : IVector4Quantity<T> => T.WithComponents(components);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled4_EqualsProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target(vector.Components);

        Assert.Equal(vector, actual);
    }
}
