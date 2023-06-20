namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class AsIVector2Quantity_WithComponents_Vector3
{
    private static Unhandled3 Target(Vector3 components)
    {
        return execute<Unhandled3>(components);

        static T execute<T>(Vector3 components) where T : IVector3Quantity<T> => T.WithComponents(components);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled3_EqualsProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target(vector.Components);

        Assert.Equal(vector, actual);
    }
}
