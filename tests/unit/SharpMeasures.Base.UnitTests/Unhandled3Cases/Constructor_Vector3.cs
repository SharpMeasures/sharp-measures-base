namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Constructor_Vector3
{
    private static Unhandled3 Target(Vector3 components) => new(components);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ComponentsOfProvidedUnhandled3_EqualsProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target(vector.Components);

        Assert.Equal(vector, actual);
    }
}
