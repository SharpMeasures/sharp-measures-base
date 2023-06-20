namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Constructor_Vector4
{
    private static Unhandled4 Target(Vector4 components) => new(components);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled4_EqualsProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target(vector.Components);

        Assert.Equal(vector, actual);
    }
}
