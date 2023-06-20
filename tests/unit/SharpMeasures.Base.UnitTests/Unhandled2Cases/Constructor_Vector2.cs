namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Constructor_Vector2
{
    private static Unhandled2 Target(Vector2 components) => new(components);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled2_EqualsProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target(vector.Components);

        Assert.Equal(vector, actual);
    }
}
